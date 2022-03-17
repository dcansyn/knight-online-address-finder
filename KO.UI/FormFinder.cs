using KO.Core.Consts;
using KO.Core.Extensions;
using KO.Core.Helpers.Message;
using KO.Provider;
using KO.Provider.Domains;
using KO.Provider.Enums.Address;
using KO.Provider.Extensions;
using KO.Provider.Helpers;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KO.UI
{
    public partial class FormFinder : Form
    {
        public AddressType _addressType = AddressType.Pointer;

        public FormFinder() { InitializeComponent(); }
        private void ButtonAddAddress_Click(object sender, EventArgs e)
        {
            // Address Type
            var addressTypes = AddressType.Pointer.List().Select(x => $"{Environment.NewLine}{x.Value} - {x.DisplayName}");
            var addressInput = MessageHelper.Input(
                "Adres Tipi",
                $"Lütfen adres tipini giriniz..{Environment.NewLine}{string.Join(Environment.NewLine, addressTypes)}",
                "0");

            if (!Enum.TryParse(addressInput, out _addressType))
            {
                MessageHelper.Send("Geçersiz adres tipi.");
                return;
            }

            ListViewAddresses.Items.Clear();
            ListViewAddresses.Columns.Clear();
            ListViewOperationCodes.Items.Clear();

            var values = new List<string>();
            Client.Codes = new List<OperationCode>();

            foreach (var item in Client.Games)
            {
                var addressHex = "";
                var baseAddressHex = "";
#if DEBUG
                switch (item.Title)
                {
                    case "2345":
                        addressHex = "49F530";
                        break;
                    case "210208":
                        addressHex = "49E470";
                        break;
                    case "2108":
                        addressHex = "4BD350";
                        break;
                }

                //switch (item.Title)
                //{
                //    case "2345":
                //        addressHex = "F2A39C";
                //        baseAddressHex = "F2A39C";
                //        break;
                //    case "210208":
                //        addressHex = "E84C1C";
                //        baseAddressHex = "E84C1C";
                //        break;
                //    case "2108":
                //        addressHex = "10131C0";
                //        baseAddressHex = "10131C0";
                //        break;
                //}
#else
                addressHex = MessageHelper.Input(App.ApplicationName, 
                    $"Lütfen {item.Title} için adres hex değerini giriniz." +
                    $"{Environment.NewLine}" +
                    (addresType == AddressType.Offset ? "C0D" : "Örn:C0D0C06C"), "");
#endif
                if (string.IsNullOrEmpty(addressHex)) continue;

                if (_addressType == AddressType.Offset)
                {
                    baseAddressHex = MessageHelper.Input(App.ApplicationName,
                       $"Lütfen {item.Title} için üst pointer bilgisinin hex değerini giriniz." +
                       $"{Environment.NewLine}" +
                       $"Örn:C0D0C06C", "");
                }

                Client.Codes.Add(new OperationCode(item, addressHex, item.Handle, baseAddressHex, _addressType));

                ListViewAddresses.Columns.Add(new ColumnHeader()
                {
                    Width = 75,
                    Text = item.Title
                });
            }

            ListViewAddresses.Items.Add(new ListViewItem(Client.Codes.Select(x => x.Hex).ToArray()));
        }

        private void ButtonOperationCodeFind_Click(object sender, EventArgs e)
        {
            if (ListViewAddresses.Items.Count <= 0)
            {
                MessageBox.Show("Please insert the address.");
                return;
            }

            ListViewOperationCodes.Items.Clear();
            ButtonOperationCodeFind.Enabled = false;
            ButtonOperationCodeFind.Text = "Aranıyor..";

            var rows = !string.IsNullOrEmpty(TextBoxCompareRows.Text) ? TextBoxCompareRows.Text
                .Split(',')
                .Where(x => int.TryParse(x, out int index))
                .Select(x => Convert.ToInt32(x))
                .ToArray() : new[] { 0, 1 };

            OperationCodeHelper.FindOperationCode(rows);
            OperationCodeHelper.UpdateOperationCode();

            var maxBlockLength = Client.Codes.Where(x => x.Blocks != null).Max(x => x.Blocks.Count);
            for (int i = 0; i < Client.Codes.Count; i++)
            {
                Application.DoEvents();

                var code = Client.Codes[i];
                if (code.Blocks == null) continue;

                for (int j = 0; j < maxBlockLength; j++)
                {
                    Application.DoEvents();

                    var block = j < code.Blocks.Count ? code.Blocks[j] : null;
                    if (block == null)
                        continue;

                    ListViewOperationCodes.Items.Add(block.OperationCode);

                    Application.DoEvents();
                }
            }

            LabelCount.Text = ListViewOperationCodes.Items.Count.ToString();


            ButtonOperationCodeFind.Enabled = true;
            ButtonOperationCodeFind.Text = "Bul";
        }

        private void FormFinder_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();

            var form = new FormMain();
            form.Show();
        }

        private void ButtonOperationCodeCompare_Click(object sender, EventArgs e)
        {
            if (ListViewOperationCodes.Items.Count <= 0)
            {
                MessageBox.Show("Please insert the operation codes.");
                return;
            }

            foreach (ListViewItem item in ListViewOperationCodes.Items)
                foreach (var game in Client.Games)
                {
                    var address = new Address(true, App.ApplicationName, item.Text, type: _addressType);
                    var result = address.CollectAddress(game);
                    if (result.Value < 0x400000)
                    {
                        item.Remove();
                        break;
                    }

                    var code = Client.Codes.FirstOrDefault(x => x.Handle == game.Handle);
                    if (code != null && result.Result.ConvertHexToDword() != code.Dword)
                    {
                        item.Remove();
                        break;
                    }

                    Application.DoEvents();
                }
        }

        private void ListViewOperationCodes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListViewOperationCodes.FocusedItem != null && ModifierKeys.HasFlag(Keys.Control))
                ListViewOperationCodes.FocusedItem.Remove();
        }
    }
}
