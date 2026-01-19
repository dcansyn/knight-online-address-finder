using KO.Core.Consts;
using KO.Core.Extensions;
using KO.Core.Helpers.Memory;
using KO.Core.Helpers.Message;
using KO.Provider;
using KO.Provider.Domains;
using KO.Provider.Enums.Game;
using KO.Provider.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KO.UI
{
    public partial class FormMain : Form
    {
        public FormMain() { InitializeComponent(); }
        private void FormMain_Load(object sender, EventArgs e)
        {
            ComboBoxPlatform.Items.Add("All");
            foreach (var item in Client.Games)
            {
                ComboBoxPlatform.Items.Add(item.Title);
                ListViewAddresses.Columns.Add(new ColumnHeader()
                {
                    Width = 110,
                    Text = item.Title
                });
            }

            ButtonRefreshAddresses_Click(sender, e);
            ComboBoxPlatform.SelectedIndex = 0;
        }

        private void ButtonClearAddresses_Click(object sender, EventArgs e)
        {
            if (MessageHelper.Send("Are you sure to delete games?", MessageBoxButtons.YesNo) && ListViewAddresses.Items.Count > 0)
                ListViewAddresses.Items.Clear();
        }

        private void ButtonRefreshAddresses_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Client.Games.Count; i++)
            {
                var game = Client.Games[i];

                game.CollectAddresses();

                for (int j = 0; j < game.Addresses.Count; j++)
                {
                    var address = game.Addresses[j];
                    if (i == 0)
                        ListViewAddresses.Items.Add(new ListViewItem(new[] { address.Name, address.Result }));
                    else
                        ListViewAddresses.Items[j].SubItems.Add(address.Result);
                }
            }
        }

        private void ComboBoxPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonHelperFindNext.Enabled = ComboBoxPlatform.Text != "All";
            TextBoxCall.Text = "";
        }

        private void ButtonHelperFind_Click(object sender, EventArgs e)
        {
            TextBoxHex.Text = TextBoxHex.Text
                .Replace(Environment.NewLine, "")
                .Replace(" ", "")
                .ToUpper(); 

            var baseAddressHex = !string.IsNullOrEmpty(TextBoxBasePointer.Text) ? TextBoxBasePointer.Text.ConvertHexToDword() : "";
            var start = int.Parse(TextBoxStartIndex.Text, NumberStyles.HexNumber) + 1;
            var length = int.Parse(TextBoxSearchLength.Text, NumberStyles.HexNumber);

            switch (ComboBoxPlatform.Text)
            {
                case "All":
                    ListViewAddresses.Items.Clear();
                    var listViewItems = new List<string>() { App.ApplicationName };
                    foreach (var item in Client.Games)
                    {
                        var address1 = new Address(true, App.ApplicationName, TextBoxHex.Text, start, length);
                        address1.UpdateBaseAddress(baseAddressHex);

                        var result1 = address1.CollectAddress(item);
                        listViewItems.Add(result1.FullResult);
                    }
                    ListViewAddresses.Items.Add(new ListViewItem(listViewItems.ToArray()));
                    break;

                default:
                    var game = Client.Games.FirstOrDefault(x => x.Title == ComboBoxPlatform.Text);
                    var address2 = new Address(true, App.ApplicationName, TextBoxHex.Text, start, length);
                    address2.UpdateBaseAddress(baseAddressHex);

                    var result2 = address2.CollectAddress(game);
                    TextBoxCall.Text = result2.Call;
                    TextBoxResult.Text = result2.Result;
                    break;
            }
        }

        private void ButtonHelperFindNext_Click(object sender, EventArgs e)
        {
            TextBoxStartIndex.Text = TextBoxCall.Text;
            if(string.IsNullOrEmpty(TextBoxStartIndex.Text))
                TextBoxStartIndex.Text = "401000";

            ButtonHelperFind_Click(sender, e);
        }

        private void TextBoxStartIndex_Click(object sender, EventArgs e)
        {
            TextBoxStartIndex.Text = "401000";
        }

        private void TextBoxHex_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TextBoxHex.Text = "";
        }

        private void ListViewAddresses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListViewAddresses.FocusedItem == null) return;

            var text = "";
            foreach (ListViewItem.ListViewSubItem item in ListViewAddresses.FocusedItem.SubItems)
                text += item.Text + Environment.NewLine;

            Clipboard.SetText(text);
        }

        private void MenuOperationCodeFinder_Click(object sender, EventArgs e)
        {
            var form = new FormFinder();
            form.Show();

            form.ListViewOperationCodes.MouseDoubleClick += new MouseEventHandler((object obj, MouseEventArgs evnt) =>
            {
                TextBoxHex.Text = form.ListViewOperationCodes.FocusedItem.Text;
                ButtonHelperFind_Click(sender, e);
            });
        }

        private void MenuCloseAll_Click(object sender, EventArgs e)
        {
            var confirm = MessageHelper.Send("Are you sure to close all game?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm)
                foreach (var item in Client.Games)
                    MemoryHelper.KillByTitle(item.Title);
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (Width < 783)
                Width = 783;

            if (Height < 577)
                Height = 577;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}