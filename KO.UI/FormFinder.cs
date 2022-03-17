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
            ListViewAddresses.Items.Clear();
            ListViewAddresses.Columns.Clear();
            ListViewOperationCodes.Items.Clear();

            var values = new List<string>();
            Client.Codes = new List<OperationCode>();

            foreach (var item in Client.Games)
            {
                var addressHex = MessageHelper.Input(App.ApplicationName,
                    $"Lütfen {item.Title} için adres hex değerini giriniz." +
                    $"{Environment.NewLine}{Environment.NewLine}" +
                    $"Örn:C0D0C06C");
                if (string.IsNullOrEmpty(addressHex)) continue;

                Client.Codes.Add(new OperationCode(item, addressHex, item.Handle));

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
            ButtonOperationCodeCompare.Enabled = false;
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
            ButtonOperationCodeCompare.Enabled = true;
            ButtonOperationCodeFind.Text = "Bul";
        }

        private void ButtonOperationCodeCompare_Click(object sender, EventArgs e)
        {
            if (ListViewOperationCodes.Items.Count <= 0)
            {
                MessageBox.Show("Please insert the operation codes.");
                return;
            }

            ButtonOperationCodeFind.Enabled = false;
            ButtonOperationCodeCompare.Enabled = false;
            ButtonOperationCodeCompare.Text = "Aranıyor..";

            foreach (ListViewItem item in ListViewOperationCodes.Items)
            {
                Application.DoEvents();

                foreach (var game in Client.Games)
                {
                    Application.DoEvents();

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
                }
            }

            ButtonOperationCodeFind.Enabled = true;
            ButtonOperationCodeCompare.Enabled = true;
            ButtonOperationCodeCompare.Text = "Karşılaştır";
            LabelCount.Text = ListViewOperationCodes.Items.Count.ToString();
        }

        private void ListViewOperationCodes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.LControlKey && ListViewOperationCodes.FocusedItem != null)
                ListViewOperationCodes.FocusedItem.Remove();
        }
    }
}
