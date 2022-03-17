namespace KO.UI
{
    partial class FormFinder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinder));
            this.GroupBoxOpCodeAddresses = new System.Windows.Forms.GroupBox();
            this.ButtonAddAddress = new System.Windows.Forms.Button();
            this.ListViewAddresses = new System.Windows.Forms.ListView();
            this.GroupBoxOperationCodes = new System.Windows.Forms.GroupBox();
            this.ButtonOperationCodeCompare = new System.Windows.Forms.Button();
            this.TextBoxCompareRows = new System.Windows.Forms.TextBox();
            this.ButtonOperationCodeFind = new System.Windows.Forms.Button();
            this.LabelCount = new System.Windows.Forms.Label();
            this.ListViewOperationCodes = new System.Windows.Forms.ListView();
            this.ColumnOperationCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupBoxOpCodeAddresses.SuspendLayout();
            this.GroupBoxOperationCodes.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxOpCodeAddresses
            // 
            this.GroupBoxOpCodeAddresses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxOpCodeAddresses.Controls.Add(this.ButtonAddAddress);
            this.GroupBoxOpCodeAddresses.Controls.Add(this.ListViewAddresses);
            this.GroupBoxOpCodeAddresses.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxOpCodeAddresses.Name = "GroupBoxOpCodeAddresses";
            this.GroupBoxOpCodeAddresses.Size = new System.Drawing.Size(357, 106);
            this.GroupBoxOpCodeAddresses.TabIndex = 32;
            this.GroupBoxOpCodeAddresses.TabStop = false;
            this.GroupBoxOpCodeAddresses.Text = "Adresler";
            // 
            // ButtonAddAddress
            // 
            this.ButtonAddAddress.Location = new System.Drawing.Point(6, 19);
            this.ButtonAddAddress.Name = "ButtonAddAddress";
            this.ButtonAddAddress.Size = new System.Drawing.Size(88, 80);
            this.ButtonAddAddress.TabIndex = 33;
            this.ButtonAddAddress.Text = "Ekle";
            this.ButtonAddAddress.UseVisualStyleBackColor = true;
            this.ButtonAddAddress.Click += new System.EventHandler(this.ButtonAddAddress_Click);
            // 
            // ListViewAddresses
            // 
            this.ListViewAddresses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewAddresses.BackColor = System.Drawing.SystemColors.Window;
            this.ListViewAddresses.ForeColor = System.Drawing.Color.Black;
            this.ListViewAddresses.FullRowSelect = true;
            this.ListViewAddresses.GridLines = true;
            this.ListViewAddresses.HideSelection = false;
            this.ListViewAddresses.Location = new System.Drawing.Point(100, 19);
            this.ListViewAddresses.Name = "ListViewAddresses";
            this.ListViewAddresses.ShowItemToolTips = true;
            this.ListViewAddresses.Size = new System.Drawing.Size(251, 80);
            this.ListViewAddresses.TabIndex = 31;
            this.ListViewAddresses.UseCompatibleStateImageBehavior = false;
            this.ListViewAddresses.View = System.Windows.Forms.View.Details;
            // 
            // GroupBoxOperationCodes
            // 
            this.GroupBoxOperationCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxOperationCodes.Controls.Add(this.ButtonOperationCodeCompare);
            this.GroupBoxOperationCodes.Controls.Add(this.TextBoxCompareRows);
            this.GroupBoxOperationCodes.Controls.Add(this.ButtonOperationCodeFind);
            this.GroupBoxOperationCodes.Controls.Add(this.LabelCount);
            this.GroupBoxOperationCodes.Controls.Add(this.ListViewOperationCodes);
            this.GroupBoxOperationCodes.Location = new System.Drawing.Point(12, 124);
            this.GroupBoxOperationCodes.Name = "GroupBoxOperationCodes";
            this.GroupBoxOperationCodes.Size = new System.Drawing.Size(357, 421);
            this.GroupBoxOperationCodes.TabIndex = 33;
            this.GroupBoxOperationCodes.TabStop = false;
            this.GroupBoxOperationCodes.Text = "Operasyon Kodları";
            // 
            // ButtonOperationCodeCompare
            // 
            this.ButtonOperationCodeCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOperationCodeCompare.Location = new System.Drawing.Point(263, 19);
            this.ButtonOperationCodeCompare.Name = "ButtonOperationCodeCompare";
            this.ButtonOperationCodeCompare.Size = new System.Drawing.Size(88, 25);
            this.ButtonOperationCodeCompare.TabIndex = 41;
            this.ButtonOperationCodeCompare.Text = "Karşılaştır";
            this.ButtonOperationCodeCompare.UseVisualStyleBackColor = true;
            this.ButtonOperationCodeCompare.Click += new System.EventHandler(this.ButtonOperationCodeCompare_Click);
            // 
            // TextBoxCompareRows
            // 
            this.TextBoxCompareRows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxCompareRows.Location = new System.Drawing.Point(100, 22);
            this.TextBoxCompareRows.Name = "TextBoxCompareRows";
            this.TextBoxCompareRows.Size = new System.Drawing.Size(157, 20);
            this.TextBoxCompareRows.TabIndex = 40;
            this.TextBoxCompareRows.Text = "0,1,2,3,4";
            // 
            // ButtonOperationCodeFind
            // 
            this.ButtonOperationCodeFind.Location = new System.Drawing.Point(6, 19);
            this.ButtonOperationCodeFind.Name = "ButtonOperationCodeFind";
            this.ButtonOperationCodeFind.Size = new System.Drawing.Size(88, 25);
            this.ButtonOperationCodeFind.TabIndex = 39;
            this.ButtonOperationCodeFind.Text = "Bul";
            this.ButtonOperationCodeFind.UseVisualStyleBackColor = true;
            this.ButtonOperationCodeFind.Click += new System.EventHandler(this.ButtonOperationCodeFind_Click);
            // 
            // LabelCount
            // 
            this.LabelCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCount.BackColor = System.Drawing.Color.Transparent;
            this.LabelCount.Location = new System.Drawing.Point(-475, 0);
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelCount.Size = new System.Drawing.Size(826, 16);
            this.LabelCount.TabIndex = 38;
            this.LabelCount.Text = "0";
            // 
            // ListViewOperationCodes
            // 
            this.ListViewOperationCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewOperationCodes.BackColor = System.Drawing.SystemColors.Window;
            this.ListViewOperationCodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnOperationCode});
            this.ListViewOperationCodes.ForeColor = System.Drawing.Color.Black;
            this.ListViewOperationCodes.FullRowSelect = true;
            this.ListViewOperationCodes.GridLines = true;
            this.ListViewOperationCodes.HideSelection = false;
            this.ListViewOperationCodes.Location = new System.Drawing.Point(6, 50);
            this.ListViewOperationCodes.Name = "ListViewOperationCodes";
            this.ListViewOperationCodes.ShowItemToolTips = true;
            this.ListViewOperationCodes.Size = new System.Drawing.Size(345, 365);
            this.ListViewOperationCodes.TabIndex = 35;
            this.ListViewOperationCodes.UseCompatibleStateImageBehavior = false;
            this.ListViewOperationCodes.View = System.Windows.Forms.View.Details;
            this.ListViewOperationCodes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewOperationCodes_MouseDoubleClick);
            // 
            // ColumnOperationCode
            // 
            this.ColumnOperationCode.Text = "Operasyon Kodu";
            this.ColumnOperationCode.Width = 310;
            // 
            // FormFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 557);
            this.Controls.Add(this.GroupBoxOperationCodes);
            this.Controls.Add(this.GroupBoxOpCodeAddresses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFinder";
            this.Text = "Finder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFinder_FormClosing);
            this.GroupBoxOpCodeAddresses.ResumeLayout(false);
            this.GroupBoxOperationCodes.ResumeLayout(false);
            this.GroupBoxOperationCodes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxOpCodeAddresses;
        internal System.Windows.Forms.ListView ListViewAddresses;
        internal System.Windows.Forms.Button ButtonAddAddress;
        private System.Windows.Forms.GroupBox GroupBoxOperationCodes;
        private System.Windows.Forms.TextBox TextBoxCompareRows;
        internal System.Windows.Forms.Button ButtonOperationCodeFind;
        private System.Windows.Forms.Label LabelCount;
        internal System.Windows.Forms.ListView ListViewOperationCodes;
        internal System.Windows.Forms.Button ButtonOperationCodeCompare;
        private System.Windows.Forms.ColumnHeader ColumnOperationCode;
    }
}