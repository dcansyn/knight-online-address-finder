using KO.Core.Consts;
using KO.Core.Extensions;
using KO.Provider;
using KO.Provider.Domains;
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
#if DEBUG
                var value = "";
                switch (item.Title)
                {
                    case "2345":
                        value = "F2A39C";
                        break;
                    case "210208":
                        value = "E84C1C";
                        break;
                    case "2108":
                        value = "10131C0";
                        break;
                }
                if (string.IsNullOrEmpty(value)) continue;
#else
                var value = Interaction.InputBox($"{item.Title}", $"Please enter the address hex value.", "");
                if (string.IsNullOrEmpty(value)) continue;
#endif
                Client.Codes.Add(new OperationCode(item, value.ConvertHexToDword(), item.Handle));

                ListViewAddresses.Columns.Add(new ColumnHeader()
                {
                    Width = 75,
                    Text = item.Title
                });
            }

            ListViewAddresses.Items.Add(new ListViewItem(Client.Codes.Select(x => x.Dword).ToArray()));
        }

        private void ButtonOperationCodeFind_Click(object sender, EventArgs e)
        {
            if (ListViewAddresses.Items.Count <= 0)
            {
                MessageBox.Show("Please insert the address.");
                return;
            }

            ButtonOperationCodeFind.Enabled = false;
            ButtonOperationCodeFind.Text = "Aranıyor..";

            var rows = !string.IsNullOrEmpty(TextBoxCompareRow.Text) ? TextBoxCompareRow.Text
                .Split(',')
                .Where(x => int.TryParse(x, out int index))
                .Select(x => Convert.ToInt32(x))
                .ToArray() : new[] { 1 };

            OperationCodeHelper.FindOperationCode();
            OperationCodeHelper.UpdateOperationCode(rows);

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

                    //var insert = true;
                    //foreach (var game in Client.Games)
                    //{
                    //    var address = new Address(true, App.ApplicationName, block.OperationCode);
                    //    var result = address.CollectAddress(game);
                    //    if (result.Value < 0x400000)
                    //    {
                    //        insert = false;
                    //        break;
                    //    }
                    //}
                    //
                    //if (!insert) continue;

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
                    var address = new Address(true, App.ApplicationName, item.Text);
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
            if ( ListViewOperationCodes.FocusedItem != null)
                ListViewOperationCodes.FocusedItem.Remove();
        }
    }
}
