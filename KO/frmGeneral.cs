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

            // Search
            var game = new Helpers.GameHelper(txtTitle.Text, rbUsko.Checked ? Enums.PlatformType.USKO : Enums.PlatformType.STEAM);

            if (game.Handle == IntPtr.Zero)
            {
                MessageBox.Show("Please open the game.", "CS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                if (chkWithCall.Checked)
                {
                    save.Write(item.SubItems[0].Text, $"{item.SubItems[1].Text}-{item.SubItems[2].Text}");
                }
                else
                {
                    save.Write(item.SubItems[0].Text, $"&H{item.SubItems[1].Text}");
                }
            }
        }
    }
}
