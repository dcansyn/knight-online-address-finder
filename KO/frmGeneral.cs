using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KO
{
    public partial class frmGeneral : Form
    {
        public frmGeneral()
        {
            InitializeComponent();
        }
        private void frmGeneral_Load(object sender, EventArgs e)
        {

        }

        private void btnHandle_Click(object sender, EventArgs e)
        {
            var st = new System.Diagnostics.Stopwatch();
            st.Start();

            // Information
            btnHandle.Enabled = false;
            btnHandle.Text = "Wait";
            lblTime.Text = "";
            Application.DoEvents();

            // Search
            var platform = rbUsko.Checked ? Enums.PlatformType.USKO : Enums.PlatformType.STEAM;
            var game = new Helpers.GameHelper(txtTitle.Text, platform);
            var addresses = game.SearchAddresses();
            lstvAddresses.Items.Clear();
            foreach (var address in addresses)
            {
                lstvAddresses.Items.Add(new ListViewItem(new string[] { address.Name, address.Pointer, address.Call }));
            }

            btnHandle.Text = "Connect";
            btnHandle.Enabled = true;
            lblTime.Text = $"{st.ElapsedMilliseconds}ms";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var save = new Helpers.SaveHelper("Pointer", $@"{AppDomain.CurrentDomain.BaseDirectory}{DateTime.Now.ToString("dd-MM-yyyy hh.mm")}.ini");
            foreach (ListViewItem item in lstvAddresses.Items)
            {
                var name = item.SubItems[0].Text;
                var value = $"{item.SubItems[1].Text}{(chkWithCall.Checked ? $"-{item.SubItems[2].Text}" : "")}";

                name = chkCSharp.Checked ? $"static public int {name}" : name;
                value = chkCSharp.Checked ? $"0x{value};" : $"&H{value}";

                save.Write(name, value);
            }
        }
    }
}
