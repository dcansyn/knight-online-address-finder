namespace KO.UI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.GroupBoxFinder = new System.Windows.Forms.GroupBox();
            this.ButtonSaveAddress = new System.Windows.Forms.Button();
            this.ButtonClearAddresses = new System.Windows.Forms.Button();
            this.ButtonRefreshAddresses = new System.Windows.Forms.Button();
            this.ListViewAddresses = new System.Windows.Forms.ListView();
            this.ColumnGameName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupBoxHelper = new System.Windows.Forms.GroupBox();
            this.LabelResult = new System.Windows.Forms.Label();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.LabelCall = new System.Windows.Forms.Label();
            this.TextBoxCall = new System.Windows.Forms.TextBox();
            this.LabelPlatform = new System.Windows.Forms.Label();
            this.ComboBoxPlatform = new System.Windows.Forms.ComboBox();
            this.ButtonHelperFindNext = new System.Windows.Forms.Button();
            this.ButtonHelperFind = new System.Windows.Forms.Button();
            this.LabelSearchLength = new System.Windows.Forms.Label();
            this.TextBoxSearchLength = new System.Windows.Forms.TextBox();
            this.TextBoxStartIndex = new System.Windows.Forms.TextBox();
            this.LabelStartIndex = new System.Windows.Forms.Label();
            this.TextBoxHex = new System.Windows.Forms.TextBox();
            this.LabelHex = new System.Windows.Forms.Label();
            this.TextBoxBasePointer = new System.Windows.Forms.TextBox();
            this.LabelBasePointer = new System.Windows.Forms.Label();
            this.LabelInformation = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuOperationCodeFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxFinder.SuspendLayout();
            this.GroupBoxHelper.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxFinder
            // 
            this.GroupBoxFinder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxFinder.Controls.Add(this.ButtonSaveAddress);
            this.GroupBoxFinder.Controls.Add(this.ButtonClearAddresses);
            this.GroupBoxFinder.Controls.Add(this.ButtonRefreshAddresses);
            this.GroupBoxFinder.Controls.Add(this.ListViewAddresses);
            this.GroupBoxFinder.ForeColor = System.Drawing.Color.Black;
            this.GroupBoxFinder.Location = new System.Drawing.Point(262, 27);
            this.GroupBoxFinder.Name = "GroupBoxFinder";
            this.GroupBoxFinder.Size = new System.Drawing.Size(496, 483);
            this.GroupBoxFinder.TabIndex = 8;
            this.GroupBoxFinder.TabStop = false;
            this.GroupBoxFinder.Text = "Adresler";
            // 
            // ButtonSaveAddress
            // 
            this.ButtonSaveAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSaveAddress.Location = new System.Drawing.Point(414, 451);
            this.ButtonSaveAddress.Name = "ButtonSaveAddress";
            this.ButtonSaveAddress.Size = new System.Drawing.Size(76, 26);
            this.ButtonSaveAddress.TabIndex = 24;
            this.ButtonSaveAddress.Text = "Kaydet";
            this.ButtonSaveAddress.UseVisualStyleBackColor = true;
            // 
            // ButtonClearAddresses
            // 
            this.ButtonClearAddresses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClearAddresses.Location = new System.Drawing.Point(464, 20);
            this.ButtonClearAddresses.Name = "ButtonClearAddresses";
            this.ButtonClearAddresses.Size = new System.Drawing.Size(25, 25);
            this.ButtonClearAddresses.TabIndex = 14;
            this.ButtonClearAddresses.Text = "X";
            this.ButtonClearAddresses.UseVisualStyleBackColor = true;
            this.ButtonClearAddresses.Click += new System.EventHandler(this.ButtonClearAddresses_Click);
            // 
            // ButtonRefreshAddresses
            // 
            this.ButtonRefreshAddresses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonRefreshAddresses.Location = new System.Drawing.Point(6, 451);
            this.ButtonRefreshAddresses.Name = "ButtonRefreshAddresses";
            this.ButtonRefreshAddresses.Size = new System.Drawing.Size(76, 26);
            this.ButtonRefreshAddresses.TabIndex = 12;
            this.ButtonRefreshAddresses.Text = "Yenile";
            this.ButtonRefreshAddresses.UseVisualStyleBackColor = true;
            this.ButtonRefreshAddresses.Click += new System.EventHandler(this.ButtonRefreshAddresses_Click);
            // 
            // ListViewAddresses
            // 
            this.ListViewAddresses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewAddresses.BackColor = System.Drawing.SystemColors.Window;
            this.ListViewAddresses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnGameName});
            this.ListViewAddresses.ForeColor = System.Drawing.Color.Black;
            this.ListViewAddresses.FullRowSelect = true;
            this.ListViewAddresses.GridLines = true;
            this.ListViewAddresses.HideSelection = false;
            this.ListViewAddresses.Location = new System.Drawing.Point(6, 19);
            this.ListViewAddresses.Name = "ListViewAddresses";
            this.ListViewAddresses.ShowItemToolTips = true;
            this.ListViewAddresses.Size = new System.Drawing.Size(484, 426);
            this.ListViewAddresses.TabIndex = 10;
            this.ListViewAddresses.UseCompatibleStateImageBehavior = false;
            this.ListViewAddresses.View = System.Windows.Forms.View.Details;
            this.ListViewAddresses.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewAddresses_MouseDoubleClick);
            // 
            // ColumnGameName
            // 
            this.ColumnGameName.Text = "Name";
            this.ColumnGameName.Width = 110;
            // 
            // GroupBoxHelper
            // 
            this.GroupBoxHelper.Controls.Add(this.LabelResult);
            this.GroupBoxHelper.Controls.Add(this.TextBoxResult);
            this.GroupBoxHelper.Controls.Add(this.LabelCall);
            this.GroupBoxHelper.Controls.Add(this.TextBoxCall);
            this.GroupBoxHelper.Controls.Add(this.LabelPlatform);
            this.GroupBoxHelper.Controls.Add(this.ComboBoxPlatform);
            this.GroupBoxHelper.Controls.Add(this.ButtonHelperFindNext);
            this.GroupBoxHelper.Controls.Add(this.ButtonHelperFind);
            this.GroupBoxHelper.Controls.Add(this.LabelSearchLength);
            this.GroupBoxHelper.Controls.Add(this.TextBoxSearchLength);
            this.GroupBoxHelper.Controls.Add(this.TextBoxStartIndex);
            this.GroupBoxHelper.Controls.Add(this.LabelStartIndex);
            this.GroupBoxHelper.Controls.Add(this.TextBoxHex);
            this.GroupBoxHelper.Controls.Add(this.LabelHex);
            this.GroupBoxHelper.Controls.Add(this.TextBoxBasePointer);
            this.GroupBoxHelper.Controls.Add(this.LabelBasePointer);
            this.GroupBoxHelper.ForeColor = System.Drawing.Color.Black;
            this.GroupBoxHelper.Location = new System.Drawing.Point(12, 27);
            this.GroupBoxHelper.Name = "GroupBoxHelper";
            this.GroupBoxHelper.Size = new System.Drawing.Size(244, 483);
            this.GroupBoxHelper.TabIndex = 9;
            this.GroupBoxHelper.TabStop = false;
            this.GroupBoxHelper.Text = "Yardımcı";
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(6, 409);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(65, 13);
            this.LabelResult.TabIndex = 30;
            this.LabelResult.Text = "Result (Hex)";
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Location = new System.Drawing.Point(6, 425);
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.ReadOnly = true;
            this.TextBoxResult.Size = new System.Drawing.Size(232, 20);
            this.TextBoxResult.TabIndex = 29;
            // 
            // LabelCall
            // 
            this.LabelCall.AutoSize = true;
            this.LabelCall.Location = new System.Drawing.Point(6, 370);
            this.LabelCall.Name = "LabelCall";
            this.LabelCall.Size = new System.Drawing.Size(52, 13);
            this.LabelCall.TabIndex = 28;
            this.LabelCall.Text = "Call (Hex)";
            // 
            // TextBoxCall
            // 
            this.TextBoxCall.Location = new System.Drawing.Point(6, 386);
            this.TextBoxCall.Name = "TextBoxCall";
            this.TextBoxCall.ReadOnly = true;
            this.TextBoxCall.Size = new System.Drawing.Size(232, 20);
            this.TextBoxCall.TabIndex = 27;
            // 
            // LabelPlatform
            // 
            this.LabelPlatform.AutoSize = true;
            this.LabelPlatform.Location = new System.Drawing.Point(6, 16);
            this.LabelPlatform.Name = "LabelPlatform";
            this.LabelPlatform.Size = new System.Drawing.Size(45, 13);
            this.LabelPlatform.TabIndex = 26;
            this.LabelPlatform.Text = "Platform";
            // 
            // ComboBoxPlatform
            // 
            this.ComboBoxPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPlatform.FormattingEnabled = true;
            this.ComboBoxPlatform.Location = new System.Drawing.Point(6, 32);
            this.ComboBoxPlatform.Name = "ComboBoxPlatform";
            this.ComboBoxPlatform.Size = new System.Drawing.Size(232, 21);
            this.ComboBoxPlatform.TabIndex = 25;
            this.ComboBoxPlatform.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPlatform_SelectedIndexChanged);
            // 
            // ButtonHelperFindNext
            // 
            this.ButtonHelperFindNext.Location = new System.Drawing.Point(162, 451);
            this.ButtonHelperFindNext.Name = "ButtonHelperFindNext";
            this.ButtonHelperFindNext.Size = new System.Drawing.Size(76, 26);
            this.ButtonHelperFindNext.TabIndex = 24;
            this.ButtonHelperFindNext.Text = "Sonraki";
            this.ButtonHelperFindNext.UseVisualStyleBackColor = true;
            this.ButtonHelperFindNext.Click += new System.EventHandler(this.ButtonHelperFindNext_Click);
            // 
            // ButtonHelperFind
            // 
            this.ButtonHelperFind.Location = new System.Drawing.Point(6, 451);
            this.ButtonHelperFind.Name = "ButtonHelperFind";
            this.ButtonHelperFind.Size = new System.Drawing.Size(76, 26);
            this.ButtonHelperFind.TabIndex = 23;
            this.ButtonHelperFind.Text = "Bul";
            this.ButtonHelperFind.UseVisualStyleBackColor = true;
            this.ButtonHelperFind.Click += new System.EventHandler(this.ButtonHelperFind_Click);
            // 
            // LabelSearchLength
            // 
            this.LabelSearchLength.AutoSize = true;
            this.LabelSearchLength.Location = new System.Drawing.Point(6, 331);
            this.LabelSearchLength.Name = "LabelSearchLength";
            this.LabelSearchLength.Size = new System.Drawing.Size(105, 13);
            this.LabelSearchLength.TabIndex = 22;
            this.LabelSearchLength.Text = "Search Length (Hex)";
            // 
            // TextBoxSearchLength
            // 
            this.TextBoxSearchLength.Location = new System.Drawing.Point(6, 347);
            this.TextBoxSearchLength.Name = "TextBoxSearchLength";
            this.TextBoxSearchLength.Size = new System.Drawing.Size(232, 20);
            this.TextBoxSearchLength.TabIndex = 21;
            this.TextBoxSearchLength.Text = "5B2000";
            // 
            // TextBoxStartIndex
            // 
            this.TextBoxStartIndex.Location = new System.Drawing.Point(6, 308);
            this.TextBoxStartIndex.Name = "TextBoxStartIndex";
            this.TextBoxStartIndex.Size = new System.Drawing.Size(232, 20);
            this.TextBoxStartIndex.TabIndex = 20;
            this.TextBoxStartIndex.Text = "401000";
            this.TextBoxStartIndex.Click += new System.EventHandler(this.TextBoxStartIndex_Click);
            // 
            // LabelStartIndex
            // 
            this.LabelStartIndex.AutoSize = true;
            this.LabelStartIndex.Location = new System.Drawing.Point(6, 292);
            this.LabelStartIndex.Name = "LabelStartIndex";
            this.LabelStartIndex.Size = new System.Drawing.Size(86, 13);
            this.LabelStartIndex.TabIndex = 4;
            this.LabelStartIndex.Text = "Start Index (Hex)";
            // 
            // TextBoxHex
            // 
            this.TextBoxHex.Location = new System.Drawing.Point(6, 72);
            this.TextBoxHex.Multiline = true;
            this.TextBoxHex.Name = "TextBoxHex";
            this.TextBoxHex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxHex.Size = new System.Drawing.Size(232, 178);
            this.TextBoxHex.TabIndex = 3;
            this.TextBoxHex.TextChanged += new System.EventHandler(this.TextBoxHex_TextChanged);
            this.TextBoxHex.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxHex_MouseDoubleClick);
            // 
            // LabelHex
            // 
            this.LabelHex.AutoSize = true;
            this.LabelHex.Location = new System.Drawing.Point(6, 56);
            this.LabelHex.Name = "LabelHex";
            this.LabelHex.Size = new System.Drawing.Size(26, 13);
            this.LabelHex.TabIndex = 2;
            this.LabelHex.Text = "Hex";
            // 
            // TextBoxBasePointer
            // 
            this.TextBoxBasePointer.Location = new System.Drawing.Point(6, 269);
            this.TextBoxBasePointer.Name = "TextBoxBasePointer";
            this.TextBoxBasePointer.Size = new System.Drawing.Size(232, 20);
            this.TextBoxBasePointer.TabIndex = 1;
            // 
            // LabelBasePointer
            // 
            this.LabelBasePointer.AutoSize = true;
            this.LabelBasePointer.Location = new System.Drawing.Point(6, 253);
            this.LabelBasePointer.Name = "LabelBasePointer";
            this.LabelBasePointer.Size = new System.Drawing.Size(95, 13);
            this.LabelBasePointer.TabIndex = 0;
            this.LabelBasePointer.Text = "Base Pointer (Hex)";
            // 
            // LabelInformation
            // 
            this.LabelInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelInformation.AutoSize = true;
            this.LabelInformation.Location = new System.Drawing.Point(673, 513);
            this.LabelInformation.Name = "LabelInformation";
            this.LabelInformation.Size = new System.Drawing.Size(85, 13);
            this.LabelInformation.TabIndex = 10;
            this.LabelInformation.Text = "cansayan.com.tr";
            this.LabelInformation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOperationCodeFinder,
            this.MenuCloseAll});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuOperationCodeFinder
            // 
            this.MenuOperationCodeFinder.Name = "MenuOperationCodeFinder";
            this.MenuOperationCodeFinder.Size = new System.Drawing.Size(140, 20);
            this.MenuOperationCodeFinder.Text = "Operasyon Kod Bulucu";
            this.MenuOperationCodeFinder.Click += new System.EventHandler(this.MenuOperationCodeFinder_Click);
            // 
            // MenuCloseAll
            // 
            this.MenuCloseAll.Name = "MenuCloseAll";
            this.MenuCloseAll.Size = new System.Drawing.Size(92, 20);
            this.MenuCloseAll.Text = "Hepsini Kapat";
            this.MenuCloseAll.Click += new System.EventHandler(this.MenuCloseAll_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 538);
            this.Controls.Add(this.LabelInformation);
            this.Controls.Add(this.GroupBoxHelper);
            this.Controls.Add(this.GroupBoxFinder);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Finder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.GroupBoxFinder.ResumeLayout(false);
            this.GroupBoxHelper.ResumeLayout(false);
            this.GroupBoxHelper.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBoxFinder;
        internal System.Windows.Forms.Button ButtonRefreshAddresses;
        internal System.Windows.Forms.ListView ListViewAddresses;
        private System.Windows.Forms.ColumnHeader ColumnGameName;
        internal System.Windows.Forms.GroupBox GroupBoxHelper;
        private System.Windows.Forms.Label LabelBasePointer;
        private System.Windows.Forms.TextBox TextBoxBasePointer;
        private System.Windows.Forms.Label LabelStartIndex;
        private System.Windows.Forms.Label LabelHex;
        private System.Windows.Forms.TextBox TextBoxStartIndex;
        private System.Windows.Forms.Label LabelSearchLength;
        private System.Windows.Forms.TextBox TextBoxSearchLength;
        internal System.Windows.Forms.Button ButtonHelperFindNext;
        internal System.Windows.Forms.Button ButtonHelperFind;
        internal System.Windows.Forms.Button ButtonClearAddresses;
        internal System.Windows.Forms.Button ButtonSaveAddress;
        private System.Windows.Forms.Label LabelPlatform;
        private System.Windows.Forms.ComboBox ComboBoxPlatform;
        private System.Windows.Forms.Label LabelCall;
        private System.Windows.Forms.TextBox TextBoxCall;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.Label LabelInformation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuOperationCodeFinder;
        public System.Windows.Forms.TextBox TextBoxHex;
        private System.Windows.Forms.ToolStripMenuItem MenuCloseAll;
    }
}