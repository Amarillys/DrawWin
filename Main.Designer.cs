namespace drawwin
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.processList = new System.Windows.Forms.ListBox();
            this.TrnLabel = new System.Windows.Forms.Label();
            this.penetrateCheckBox = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.transparentBar = new System.Windows.Forms.TrackBar();
            this.languageComboxBox = new System.Windows.Forms.ComboBox();
            this.langLabel = new System.Windows.Forms.Label();
            this.alwaysOnTopCheckBox = new System.Windows.Forms.CheckBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.filterFrame = new System.Windows.Forms.GroupBox();
            this.nameExcludeLabel = new System.Windows.Forms.Label();
            this.titleExcludeLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.titleSearchText = new System.Windows.Forms.TextBox();
            this.processLimit = new System.Windows.Forms.TextBox();
            this.titleLimit = new System.Windows.Forms.TextBox();
            this.lengthLimitLabel = new System.Windows.Forms.Label();
            this.lengthLimit = new System.Windows.Forms.TextBox();
            this.darkMode = new System.Windows.Forms.CheckBox();
            this.selectedProc = new System.Windows.Forms.Label();
            this.windowMgrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.transparentBar)).BeginInit();
            this.filterFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowMgrBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // processList
            // 
            this.processList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.processList.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.processList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.processList.FormattingEnabled = true;
            this.processList.ItemHeight = 26;
            this.processList.Location = new System.Drawing.Point(12, 12);
            this.processList.Name = "processList";
            this.processList.Size = new System.Drawing.Size(351, 420);
            this.processList.TabIndex = 0;
            this.processList.SelectedIndexChanged += new System.EventHandler(this.processList_SelectedIndexChanged);
            // 
            // TrnLabel
            // 
            this.TrnLabel.AutoSize = true;
            this.TrnLabel.Location = new System.Drawing.Point(394, 99);
            this.TrnLabel.Name = "TrnLabel";
            this.TrnLabel.Size = new System.Drawing.Size(64, 13);
            this.TrnLabel.TabIndex = 1;
            this.TrnLabel.Text = "Transparent";
            this.TrnLabel.Click += new System.EventHandler(this.TrnLabel_Click);
            // 
            // penetrateCheckBox
            // 
            this.penetrateCheckBox.AutoSize = true;
            this.penetrateCheckBox.Location = new System.Drawing.Point(395, 12);
            this.penetrateCheckBox.Name = "penetrateCheckBox";
            this.penetrateCheckBox.Size = new System.Drawing.Size(72, 17);
            this.penetrateCheckBox.TabIndex = 2;
            this.penetrateCheckBox.Text = "Penetrate";
            this.penetrateCheckBox.UseVisualStyleBackColor = true;
            this.penetrateCheckBox.CheckedChanged += new System.EventHandler(this.penetrateCheckBox_CheckedChanged);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // transparentBar
            // 
            this.transparentBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transparentBar.LargeChange = 10;
            this.transparentBar.Location = new System.Drawing.Point(504, 99);
            this.transparentBar.Maximum = 255;
            this.transparentBar.Minimum = 10;
            this.transparentBar.Name = "transparentBar";
            this.transparentBar.Size = new System.Drawing.Size(192, 45);
            this.transparentBar.TabIndex = 3;
            this.transparentBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.transparentBar.Value = 255;
            this.transparentBar.Scroll += new System.EventHandler(this.transparentBar_Scroll);
            // 
            // languageComboxBox
            // 
            this.languageComboxBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.languageComboxBox.FormattingEnabled = true;
            this.languageComboxBox.Items.AddRange(new object[] {
            "简体中文",
            "English"});
            this.languageComboxBox.Location = new System.Drawing.Point(664, 12);
            this.languageComboxBox.Name = "languageComboxBox";
            this.languageComboxBox.Size = new System.Drawing.Size(121, 21);
            this.languageComboxBox.TabIndex = 4;
            this.languageComboxBox.SelectedIndexChanged += new System.EventHandler(this.languageComboxBox_SelectedIndexChanged);
            // 
            // langLabel
            // 
            this.langLabel.AutoSize = true;
            this.langLabel.Location = new System.Drawing.Point(521, 13);
            this.langLabel.Name = "langLabel";
            this.langLabel.Size = new System.Drawing.Size(90, 13);
            this.langLabel.TabIndex = 5;
            this.langLabel.Text = "Languange/语言";
            // 
            // alwaysOnTopCheckBox
            // 
            this.alwaysOnTopCheckBox.AutoSize = true;
            this.alwaysOnTopCheckBox.Location = new System.Drawing.Point(395, 54);
            this.alwaysOnTopCheckBox.Name = "alwaysOnTopCheckBox";
            this.alwaysOnTopCheckBox.Size = new System.Drawing.Size(98, 17);
            this.alwaysOnTopCheckBox.TabIndex = 6;
            this.alwaysOnTopCheckBox.Text = "Always On Top";
            this.alwaysOnTopCheckBox.UseVisualStyleBackColor = true;
            this.alwaysOnTopCheckBox.CheckedChanged += new System.EventHandler(this.alwaysOnTopCheckBox_CheckedChanged);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.refreshBtn.ForeColor = System.Drawing.Color.MistyRose;
            this.refreshBtn.Location = new System.Drawing.Point(646, 364);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(139, 57);
            this.refreshBtn.TabIndex = 7;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // filterFrame
            // 
            this.filterFrame.Controls.Add(this.nameExcludeLabel);
            this.filterFrame.Controls.Add(this.titleExcludeLabel);
            this.filterFrame.Controls.Add(this.searchLabel);
            this.filterFrame.Controls.Add(this.titleSearchText);
            this.filterFrame.Controls.Add(this.processLimit);
            this.filterFrame.Controls.Add(this.titleLimit);
            this.filterFrame.Controls.Add(this.lengthLimitLabel);
            this.filterFrame.Controls.Add(this.lengthLimit);
            this.filterFrame.Location = new System.Drawing.Point(395, 198);
            this.filterFrame.Name = "filterFrame";
            this.filterFrame.Size = new System.Drawing.Size(390, 160);
            this.filterFrame.TabIndex = 8;
            this.filterFrame.TabStop = false;
            this.filterFrame.Text = "Filter";
            // 
            // nameExcludeLabel
            // 
            this.nameExcludeLabel.Location = new System.Drawing.Point(4, 113);
            this.nameExcludeLabel.Name = "nameExcludeLabel";
            this.nameExcludeLabel.Size = new System.Drawing.Size(92, 41);
            this.nameExcludeLabel.TabIndex = 7;
            this.nameExcludeLabel.Text = "name excludes";
            // 
            // titleExcludeLabel
            // 
            this.titleExcludeLabel.Location = new System.Drawing.Point(6, 58);
            this.titleExcludeLabel.Name = "titleExcludeLabel";
            this.titleExcludeLabel.Size = new System.Drawing.Size(90, 60);
            this.titleExcludeLabel.TabIndex = 6;
            this.titleExcludeLabel.Text = "title excludes";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(6, 25);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(41, 13);
            this.searchLabel.TabIndex = 5;
            this.searchLabel.Text = "Search";
            // 
            // titleSearchText
            // 
            this.titleSearchText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.titleSearchText.Location = new System.Drawing.Point(95, 20);
            this.titleSearchText.Name = "titleSearchText";
            this.titleSearchText.Size = new System.Drawing.Size(164, 20);
            this.titleSearchText.TabIndex = 4;
            this.titleSearchText.TextChanged += new System.EventHandler(this.titleSearchText_TextChanged);
            // 
            // processLimit
            // 
            this.processLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.processLimit.Location = new System.Drawing.Point(95, 115);
            this.processLimit.Multiline = true;
            this.processLimit.Name = "processLimit";
            this.processLimit.Size = new System.Drawing.Size(289, 39);
            this.processLimit.TabIndex = 3;
            this.processLimit.TextChanged += new System.EventHandler(this.processLimit_TextChanged);
            // 
            // titleLimit
            // 
            this.titleLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.titleLimit.Location = new System.Drawing.Point(95, 55);
            this.titleLimit.Multiline = true;
            this.titleLimit.Name = "titleLimit";
            this.titleLimit.Size = new System.Drawing.Size(289, 54);
            this.titleLimit.TabIndex = 2;
            this.titleLimit.Text = "IME;Sogou;";
            this.titleLimit.TextChanged += new System.EventHandler(this.titleLimit_TextChanged);
            // 
            // lengthLimitLabel
            // 
            this.lengthLimitLabel.AutoSize = true;
            this.lengthLimitLabel.Location = new System.Drawing.Point(260, 24);
            this.lengthLimitLabel.Name = "lengthLimitLabel";
            this.lengthLimitLabel.Size = new System.Drawing.Size(103, 13);
            this.lengthLimitLabel.TabIndex = 1;
            this.lengthLimitLabel.Text = "titleLengthLimitLabel";
            // 
            // lengthLimit
            // 
            this.lengthLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.lengthLimit.Location = new System.Drawing.Point(328, 20);
            this.lengthLimit.Name = "lengthLimit";
            this.lengthLimit.Size = new System.Drawing.Size(56, 20);
            this.lengthLimit.TabIndex = 0;
            this.lengthLimit.Text = "40";
            this.lengthLimit.TextChanged += new System.EventHandler(this.lengthLimit_TextChanged);
            // 
            // darkMode
            // 
            this.darkMode.AutoSize = true;
            this.darkMode.Enabled = false;
            this.darkMode.Location = new System.Drawing.Point(573, 54);
            this.darkMode.Name = "darkMode";
            this.darkMode.Size = new System.Drawing.Size(79, 17);
            this.darkMode.TabIndex = 9;
            this.darkMode.Text = "Dark Mode";
            this.darkMode.UseVisualStyleBackColor = true;
            this.darkMode.CheckedChanged += new System.EventHandler(this.darkMode_CheckedChanged);
            // 
            // selectedProc
            // 
            this.selectedProc.AutoSize = true;
            this.selectedProc.Location = new System.Drawing.Point(394, 375);
            this.selectedProc.Name = "selectedProc";
            this.selectedProc.Size = new System.Drawing.Size(66, 13);
            this.selectedProc.TabIndex = 10;
            this.selectedProc.Text = "Process Info";
            // 
            // windowMgrBindingSource
            // 
            this.windowMgrBindingSource.DataSource = typeof(drawwin.WindowMgr);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(797, 443);
            this.Controls.Add(this.selectedProc);
            this.Controls.Add(this.darkMode);
            this.Controls.Add(this.filterFrame);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.alwaysOnTopCheckBox);
            this.Controls.Add(this.langLabel);
            this.Controls.Add(this.languageComboxBox);
            this.Controls.Add(this.transparentBar);
            this.Controls.Add(this.penetrateCheckBox);
            this.Controls.Add(this.TrnLabel);
            this.Controls.Add(this.processList);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "DrawWin";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Deactivate += new System.EventHandler(this.Main_Minimized);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Close);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transparentBar)).EndInit();
            this.filterFrame.ResumeLayout(false);
            this.filterFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowMgrBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox processList;
        private System.Windows.Forms.BindingSource windowMgrBindingSource;
        private System.Windows.Forms.Label TrnLabel;
        private System.Windows.Forms.CheckBox penetrateCheckBox;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TrackBar transparentBar;
        private System.Windows.Forms.ComboBox languageComboxBox;
        private System.Windows.Forms.Label langLabel;
        private System.Windows.Forms.CheckBox alwaysOnTopCheckBox;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.GroupBox filterFrame;
        private System.Windows.Forms.TextBox processLimit;
        private System.Windows.Forms.TextBox titleLimit;
        private System.Windows.Forms.Label lengthLimitLabel;
        private System.Windows.Forms.TextBox lengthLimit;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox titleSearchText;
        private System.Windows.Forms.Label nameExcludeLabel;
        private System.Windows.Forms.Label titleExcludeLabel;
        private System.Windows.Forms.CheckBox darkMode;
        private System.Windows.Forms.Label selectedProc;
    }
}

