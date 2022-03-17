namespace KO.UI
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MenuSaveSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxGames = new System.Windows.Forms.GroupBox();
            this.ButtonClearGames = new System.Windows.Forms.Button();
            this.ButtonOpenGame = new System.Windows.Forms.Button();
            this.ButtonAddGame = new System.Windows.Forms.Button();
            this.ListViewGames = new System.Windows.Forms.ListView();
            this.ColumnGamePlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnGameName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnGamePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LabelInformation = new System.Windows.Forms.Label();
            this.MemoryTimer = new System.Windows.Forms.Timer(this.components);
            this.GroupBoxConnect = new System.Windows.Forms.GroupBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ListViewConnect = new System.Windows.Forms.ListView();
            this.ColumnConnectPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnConnectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnConnectPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Menu.SuspendLayout();
            this.GroupBoxGames.SuspendLayout();
            this.GroupBoxConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSaveSettings});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(507, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // MenuSaveSettings
            // 
            this.MenuSaveSettings.Name = "MenuSaveSettings";
            this.MenuSaveSettings.Size = new System.Drawing.Size(98, 20);
            this.MenuSaveSettings.Text = "Ayarları Kaydet";
            this.MenuSaveSettings.Click += new System.EventHandler(this.MenuSaveSettings_Click);
            // 
            // GroupBoxGames
            // 
            this.GroupBoxGames.Controls.Add(this.ButtonClearGames);
            this.GroupBoxGames.Controls.Add(this.ButtonOpenGame);
            this.GroupBoxGames.Controls.Add(this.ButtonAddGame);
            this.GroupBoxGames.Controls.Add(this.ListViewGames);
            this.GroupBoxGames.ForeColor = System.Drawing.Color.Black;
            this.GroupBoxGames.Location = new System.Drawing.Point(12, 27);
            this.GroupBoxGames.Name = "GroupBoxGames";
            this.GroupBoxGames.Size = new System.Drawing.Size(483, 170);
            this.GroupBoxGames.TabIndex = 5;
            this.GroupBoxGames.TabStop = false;
            this.GroupBoxGames.Text = "Açılacak Oyunlar";
            // 
            // ButtonClearGames
            // 
            this.ButtonClearGames.Location = new System.Drawing.Point(451, 20);
            this.ButtonClearGames.Name = "ButtonClearGames";
            this.ButtonClearGames.Size = new System.Drawing.Size(25, 25);
            this.ButtonClearGames.TabIndex = 13;
            this.ButtonClearGames.Text = "X";
            this.ButtonClearGames.UseVisualStyleBackColor = true;
            this.ButtonClearGames.Click += new System.EventHandler(this.ButtonClearGames_Click);
            // 
            // ButtonOpenGame
            // 
            this.ButtonOpenGame.Location = new System.Drawing.Point(6, 138);
            this.ButtonOpenGame.Name = "ButtonOpenGame";
            this.ButtonOpenGame.Size = new System.Drawing.Size(76, 26);
            this.ButtonOpenGame.TabIndex = 12;
            this.ButtonOpenGame.Text = "Aç";
            this.ButtonOpenGame.UseVisualStyleBackColor = true;
            this.ButtonOpenGame.Click += new System.EventHandler(this.ButtonOpenGame_Click);
            // 
            // ButtonAddGame
            // 
            this.ButtonAddGame.Location = new System.Drawing.Point(401, 138);
            this.ButtonAddGame.Name = "ButtonAddGame";
            this.ButtonAddGame.Size = new System.Drawing.Size(76, 26);
            this.ButtonAddGame.TabIndex = 11;
            this.ButtonAddGame.Text = "Ekle";
            this.ButtonAddGame.UseVisualStyleBackColor = true;
            this.ButtonAddGame.Click += new System.EventHandler(this.ButtonAddGame_Click);
            // 
            // ListViewGames
            // 
            this.ListViewGames.BackColor = System.Drawing.SystemColors.Window;
            this.ListViewGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnGamePlatform,
            this.ColumnGameName,
            this.ColumnGamePath});
            this.ListViewGames.ForeColor = System.Drawing.Color.Black;
            this.ListViewGames.FullRowSelect = true;
            this.ListViewGames.GridLines = true;
            this.ListViewGames.HideSelection = false;
            this.ListViewGames.Location = new System.Drawing.Point(6, 19);
            this.ListViewGames.Name = "ListViewGames";
            this.ListViewGames.ShowItemToolTips = true;
            this.ListViewGames.Size = new System.Drawing.Size(471, 113);
            this.ListViewGames.TabIndex = 10;
            this.ListViewGames.UseCompatibleStateImageBehavior = false;
            this.ListViewGames.View = System.Windows.Forms.View.Details;
            this.ListViewGames.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewGames_MouseClick);
            this.ListViewGames.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewGames_MouseDoubleClick);
            // 
            // ColumnGamePlatform
            // 
            this.ColumnGamePlatform.Text = "Platform";
            this.ColumnGamePlatform.Width = 64;
            // 
            // ColumnGameName
            // 
            this.ColumnGameName.Text = "Adı";
            this.ColumnGameName.Width = 67;
            // 
            // ColumnGamePath
            // 
            this.ColumnGamePath.Text = "Dosya Yolu";
            this.ColumnGamePath.Width = 314;
            // 
            // LabelInformation
            // 
            this.LabelInformation.Location = new System.Drawing.Point(12, 376);
            this.LabelInformation.Name = "LabelInformation";
            this.LabelInformation.Size = new System.Drawing.Size(483, 18);
            this.LabelInformation.TabIndex = 6;
            this.LabelInformation.Text = "cansayan.com.tr";
            this.LabelInformation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MemoryTimer
            // 
            this.MemoryTimer.Interval = 1000;
            this.MemoryTimer.Tick += new System.EventHandler(this.MemoryTimer_Tick);
            // 
            // GroupBoxConnect
            // 
            this.GroupBoxConnect.Controls.Add(this.ButtonConnect);
            this.GroupBoxConnect.Controls.Add(this.ButtonRefresh);
            this.GroupBoxConnect.Controls.Add(this.ListViewConnect);
            this.GroupBoxConnect.ForeColor = System.Drawing.Color.Black;
            this.GroupBoxConnect.Location = new System.Drawing.Point(12, 203);
            this.GroupBoxConnect.Name = "GroupBoxConnect";
            this.GroupBoxConnect.Size = new System.Drawing.Size(483, 170);
            this.GroupBoxConnect.TabIndex = 7;
            this.GroupBoxConnect.TabStop = false;
            this.GroupBoxConnect.Text = "Bağlanılacak Oyunlar";
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(6, 138);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(76, 26);
            this.ButtonConnect.TabIndex = 12;
            this.ButtonConnect.Text = "Bağlan";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(401, 138);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(76, 26);
            this.ButtonRefresh.TabIndex = 11;
            this.ButtonRefresh.Text = "Yenile";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // ListViewConnect
            // 
            this.ListViewConnect.BackColor = System.Drawing.SystemColors.Window;
            this.ListViewConnect.CheckBoxes = true;
            this.ListViewConnect.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnConnectPlatform,
            this.ColumnConnectName,
            this.ColumnConnectPath});
            this.ListViewConnect.ForeColor = System.Drawing.Color.Black;
            this.ListViewConnect.FullRowSelect = true;
            this.ListViewConnect.GridLines = true;
            this.ListViewConnect.HideSelection = false;
            this.ListViewConnect.Location = new System.Drawing.Point(6, 19);
            this.ListViewConnect.Name = "ListViewConnect";
            this.ListViewConnect.ShowItemToolTips = true;
            this.ListViewConnect.Size = new System.Drawing.Size(471, 113);
            this.ListViewConnect.TabIndex = 10;
            this.ListViewConnect.UseCompatibleStateImageBehavior = false;
            this.ListViewConnect.View = System.Windows.Forms.View.Details;
            // 
            // ColumnConnectPlatform
            // 
            this.ColumnConnectPlatform.Text = "Platform";
            this.ColumnConnectPlatform.Width = 64;
            // 
            // ColumnConnectName
            // 
            this.ColumnConnectName.Text = "Adı";
            this.ColumnConnectName.Width = 67;
            // 
            // ColumnConnectPath
            // 
            this.ColumnConnectPath.Text = "Dosya Yolu";
            this.ColumnConnectPath.Width = 314;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 404);
            this.Controls.Add(this.GroupBoxConnect);
            this.Controls.Add(this.LabelInformation);
            this.Controls.Add(this.GroupBoxGames);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Text = "Finder";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.GroupBoxGames.ResumeLayout(false);
            this.GroupBoxConnect.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuSaveSettings;
        internal System.Windows.Forms.GroupBox GroupBoxGames;
        internal System.Windows.Forms.Button ButtonOpenGame;
        internal System.Windows.Forms.Button ButtonAddGame;
        internal System.Windows.Forms.ListView ListViewGames;
        private System.Windows.Forms.ColumnHeader ColumnGameName;
        private System.Windows.Forms.ColumnHeader ColumnGamePath;
        internal System.Windows.Forms.Button ButtonClearGames;
        private System.Windows.Forms.Label LabelInformation;
        private System.Windows.Forms.Timer MemoryTimer;
        private System.Windows.Forms.ColumnHeader ColumnGamePlatform;
        internal System.Windows.Forms.GroupBox GroupBoxConnect;
        internal System.Windows.Forms.Button ButtonConnect;
        internal System.Windows.Forms.Button ButtonRefresh;
        internal System.Windows.Forms.ListView ListViewConnect;
        private System.Windows.Forms.ColumnHeader ColumnConnectName;
        private System.Windows.Forms.ColumnHeader ColumnConnectPath;
        private System.Windows.Forms.ColumnHeader ColumnConnectPlatform;
    }
}