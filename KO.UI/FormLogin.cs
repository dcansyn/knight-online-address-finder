using KO.Core.Consts;
using KO.Core.Extensions;
using KO.Core.Helpers.Memory;
using KO.Core.Helpers.Message;
using KO.Core.Helpers.Settings;
using KO.Provider;
using KO.Provider.Domains;
using KO.Provider.Enums.Game;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KO.UI
{
    public partial class FormLogin : Form
    {
        public static Game _game;

        public FormLogin() { InitializeComponent(); }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (!this.Deserialize())
                MessageHelper.Send("Ayarlar doğru şekilde yüklenemedi.");

            ButtonRefresh_Click(sender, e);
        }

        private void MenuSaveSettings_Click(object sender, EventArgs e)
        {
            if (!this.Serialize())
                MessageHelper.Send("Ayarlar doğru şekilde kayıt edilemedi.");
            else
                MessageHelper.Send("Ayarlar kayıt edildi..");
        }

        private void ListViewGames_MouseClick(object sender, MouseEventArgs e)
        {
            var focusedItem = ListViewGames.FocusedItem;

            if (e.Button == MouseButtons.Right && focusedItem != null && focusedItem.Bounds.Contains(e.Location))
            {
                var contextMenu = new ContextMenu();

                // Change name
                var contextMenuChangeName = new MenuItem("Adı Değiştir");
                contextMenuChangeName.Click += delegate (object menuItemSender, EventArgs menuItemEvent)
                {
                    var name = MessageHelper.Input("Oyun Adı", $"Lütfen oyun adını giriniz.", "KO");
                    if (string.IsNullOrEmpty(name))
                        return;

                    focusedItem.SubItems[1].Text = name;
                };


                // Change path with menu
                var contextMenuChangePath = new MenuItem("Dosya Yolu Değiştir.");
                contextMenuChangePath.Click += delegate (object menuItemSender, EventArgs menuItemEvent)
                {
                    var fileDialog = new OpenFileDialog()
                    {
                        Filter = "* | *.exe",
                        InitialDirectory = @"C:\"
                    };
                    fileDialog.ShowDialog();

                    if (string.IsNullOrWhiteSpace(fileDialog.FileName))
                        return;

                    focusedItem.SubItems[2].Text = fileDialog.FileName;
                };

                contextMenu.MenuItems.AddRange(new[] { contextMenuChangeName, contextMenuChangePath });
                contextMenu.Show(ListViewGames, new Point(e.X, e.Y));
            }
        }

        private void ListViewGames_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (MessageHelper.Send("Silmek istediğinize emin misiniz?", MessageBoxButtons.YesNo) && ListViewGames.FocusedItem != null)
                ListViewGames.FocusedItem.Remove();
        }

        private void ButtonClearGames_Click(object sender, EventArgs e)
        {
            if (MessageHelper.Send("Tüm oyunları silmek istediğinize emin misiniz?", MessageBoxButtons.YesNo) && ListViewGames.Items.Count > 0)
                ListViewGames.Items.Clear();
        }

        private void ButtonAddGame_Click(object sender, EventArgs e)
        {
            // Platform
            var platformTypes = PlatformType.Global.List().Select(x => $"{Environment.NewLine}{x.Value} - {x.DisplayName}");
            var platform = MessageHelper.Input(
                "Platform",
                $"Lütfen oyun platformunu seçiniz.{Environment.NewLine}{string.Join(Environment.NewLine, platformTypes)}",
                "0");

            if (!Enum.TryParse(platform, out PlatformType platformType))
            {
                MessageHelper.Send("Geçersiz platform tipi.");
                return;
            }

            // Title
            var title = MessageHelper.Input("Oyun Adı", $"Lütfen oyun adını giriniz.", "KO");
            if (string.IsNullOrEmpty(title))
            {
                MessageHelper.Send("Game title not found.");
                return;
            }

            // Path
            var fileDialog = new OpenFileDialog()
            {
                Filter = "* | *.exe",
                InitialDirectory = @"C:\"
            };
            fileDialog.ShowDialog();

            if (string.IsNullOrWhiteSpace(fileDialog.FileName))
                return;

            // Add
            ListViewGames.Items.Add(new ListViewItem(new[] { platformType.Get().DisplayName, title, fileDialog.FileName }));
        }

        private void ButtonOpenGame_Click(object sender, EventArgs e)
        {
            if (ListViewGames.Items.Count == 1)
                ListViewGames.Items[0].Focused = true;

            var focusedItem = ListViewGames.FocusedItem;

            var platformTypes = PlatformType.Global.List();
            var platformType = platformTypes.FirstOrDefault(y => y.DisplayName == focusedItem.SubItems[0].Text);
            if (platformType == null) throw new ArgumentNullException(nameof(platformType));

            _game = new Game((PlatformType)platformType.Self, focusedItem.SubItems[1].Text, focusedItem.SubItems[2].Text);
            _game.Start();

            LabelInformation.Text = "Lütfen oyun başlangıç ve bypass işlemi bitene kadar bekleyiniz.";
            ButtonOpenGame.Enabled = false;
            MemoryTimer.Enabled = true;
        }

        private void MemoryTimer_Tick(object sender, EventArgs e)
        {
            if (_game == null) return;

            if (!_game.IsAvailable) return;

            if (_game.IsStarted && !_game.IsThreadAction && !_game.IsCompleted && MemoryHelper.CheckProcessByName(_game.Title))
            {
                LabelInformation.Text = "Bypass işlemi başlatıldı..";
                _game.Bypass();
                return;
            }

            if (_game.IsCompleted)
            {
                MemoryTimer.Enabled = false;

                if (MessageHelper.Send($"Bypass işlemi tamamlandı.{Environment.NewLine}Yeni bir oyun açmak istiyor musunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    Application.Restart();
                else
                    return;
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            if (ListViewGames.Items.Count <= 0)
            {
                MessageHelper.Send($"Lütfen önce oyun ekleyip bypass işlemlerinin bitmesini bekleyiniz!", icon: MessageBoxIcon.Warning);
                return;
            }

            ListViewConnect.Items.Clear();

            foreach (ListViewItem item in ListViewGames.Items)
            {
                var process = MemoryHelper.GetProcessByTitle(item.SubItems[1].Text);
                if (process != null)
                {
                    var clone = (ListViewItem)item.Clone();
                    clone.Checked = true;
                    ListViewConnect.Items.Add(clone);
                }
            }
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (ListViewConnect.Items.Count == 1)
                ListViewConnect.Items[0].Checked = true;

            Client.Games = ListViewConnect.Items.Cast<ListViewItem>()
                .Where(x => x.Checked)
                .Select(x =>
                {
                    var platformTypes = PlatformType.Global.List();
                    var platformType = platformTypes.FirstOrDefault(y => y.DisplayName == x.SubItems[0].Text);
                    if (platformType == null) throw new ArgumentNullException(nameof(platformType));

                    return new Game((PlatformType)platformType.Self, x.SubItems[1].Text);
                }).ToList();

            if (Client.Games.Count <= 0)
            {
                MessageHelper.Send("Lütfen bağlanmak istediğiniz oyunları seçiniz.");
                return;
            }

            Hide();
            var main = new FormMain();
            main.Show();
        }
    }
}
