namespace KO
{
    partial class frmGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneral));
            this.btnHandle = new System.Windows.Forms.Button();
            this.lstvAddresses = new System.Windows.Forms.ListView();
            this.lvcName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave = new System.Windows.Forms.Button();
            this.rbUsko = new System.Windows.Forms.RadioButton();
            this.rbSteam = new System.Windows.Forms.RadioButton();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.chkWithCall = new System.Windows.Forms.CheckBox();
            this.lblCanSayan = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.chkCSharp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnHandle
            // 
            this.btnHandle.Location = new System.Drawing.Point(143, 11);
            this.btnHandle.Name = "btnHandle";
            this.btnHandle.Size = new System.Drawing.Size(61, 44);
            this.btnHandle.TabIndex = 5;
            this.btnHandle.Text = "Connect";
            this.btnHandle.UseVisualStyleBackColor = true;
            this.btnHandle.Click += new System.EventHandler(this.btnHandle_Click);
            // 
            // lstvAddresses
            // 
            this.lstvAddresses.BackColor = System.Drawing.SystemColors.Window;
            this.lstvAddresses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvcName,
            this.lvcValue,
            this.lvcAddress});
            this.lstvAddresses.ForeColor = System.Drawing.Color.Black;
            this.lstvAddresses.FullRowSelect = true;
            this.lstvAddresses.GridLines = true;
            this.lstvAddresses.HideSelection = false;
            this.lstvAddresses.Location = new System.Drawing.Point(12, 61);
            this.lstvAddresses.MultiSelect = false;
            this.lstvAddresses.Name = "lstvAddresses";
            this.lstvAddresses.Size = new System.Drawing.Size(374, 388);
            this.lstvAddresses.TabIndex = 6;
            this.lstvAddresses.UseCompatibleStateImageBehavior = false;
            this.lstvAddresses.View = System.Windows.Forms.View.Details;
            // 
            // lvcName
            // 
            this.lvcName.Text = "Name";
            this.lvcName.Width = 140;
            // 
            // lvcValue
            // 
            this.lvcValue.Text = "Value";
            this.lvcValue.Width = 100;
            // 
            // lvcAddress
            // 
            this.lvcAddress.Text = "Address";
            this.lvcAddress.Width = 100;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(321, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 26);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbUsko
            // 
            this.rbUsko.AutoSize = true;
            this.rbUsko.Checked = true;
            this.rbUsko.Location = new System.Drawing.Point(12, 38);
            this.rbUsko.Name = "rbUsko";
            this.rbUsko.Size = new System.Drawing.Size(50, 17);
            this.rbUsko.TabIndex = 8;
            this.rbUsko.TabStop = true;
            this.rbUsko.Text = "Usko";
            this.rbUsko.UseVisualStyleBackColor = true;
            // 
            // rbSteam
            // 
            this.rbSteam.AutoSize = true;
            this.rbSteam.Location = new System.Drawing.Point(82, 38);
            this.rbSteam.Name = "rbSteam";
            this.rbSteam.Size = new System.Drawing.Size(55, 17);
            this.rbSteam.TabIndex = 9;
            this.rbSteam.Text = "Steam";
            this.rbSteam.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(125, 20);
            this.txtTitle.TabIndex = 10;
            this.txtTitle.Text = "Knight OnLine Client";
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkWithCall
            // 
            this.chkWithCall.AutoSize = true;
            this.chkWithCall.Location = new System.Drawing.Point(322, 39);
            this.chkWithCall.Name = "chkWithCall";
            this.chkWithCall.Size = new System.Drawing.Size(64, 17);
            this.chkWithCall.TabIndex = 11;
            this.chkWithCall.Text = "with call";
            this.chkWithCall.UseVisualStyleBackColor = true;
            // 
            // lblCanSayan
            // 
            this.lblCanSayan.AutoSize = true;
            this.lblCanSayan.Location = new System.Drawing.Point(301, 452);
            this.lblCanSayan.Name = "lblCanSayan";
            this.lblCanSayan.Size = new System.Drawing.Size(85, 13);
            this.lblCanSayan.TabIndex = 12;
            this.lblCanSayan.Text = "cansayan.com.tr";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 452);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 13;
            // 
            // chkCSharp
            // 
            this.chkCSharp.AutoSize = true;
            this.chkCSharp.Location = new System.Drawing.Point(276, 39);
            this.chkCSharp.Name = "chkCSharp";
            this.chkCSharp.Size = new System.Drawing.Size(40, 17);
            this.chkCSharp.TabIndex = 14;
            this.chkCSharp.Text = "C#";
            this.chkCSharp.UseVisualStyleBackColor = true;
            // 
            // frmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 474);
            this.Controls.Add(this.chkCSharp);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblCanSayan);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkWithCall);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.rbSteam);
            this.Controls.Add(this.rbUsko);
            this.Controls.Add(this.lstvAddresses);
            this.Controls.Add(this.btnHandle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGeneral";
            this.Text = "Can Sayan";
            this.Load += new System.EventHandler(this.frmGeneral_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHandle;
        internal System.Windows.Forms.ListView lstvAddresses;
        internal System.Windows.Forms.ColumnHeader lvcName;
        private System.Windows.Forms.ColumnHeader lvcValue;
        private System.Windows.Forms.ColumnHeader lvcAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbUsko;
        private System.Windows.Forms.RadioButton rbSteam;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.CheckBox chkWithCall;
        private System.Windows.Forms.Label lblCanSayan;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.CheckBox chkCSharp;
    }
}

