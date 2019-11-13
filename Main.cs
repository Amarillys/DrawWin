using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Resources;


namespace drawwin
{
    using Setting = Properties.Settings;
    public partial class Main : Form
    {
        private ResourceManager i18n;
        private IntPtr currentWindowHandle;
        private bool isUserOperation = false;
        public bool activated = true;
        private ProcessInfo[] processes;
        private Font bigFont = new Font("Microsoft YaHei UI", 13);
        private Font medFont = new Font("Microsoft YaHei UI", 11);
        private string language;
        public Main()
        {
            InitializeComponent();
            i18n = new ResourceManager("drawwin.ui_zh_CN", typeof(Main).Assembly);
            InitUI();
            this.InitProcess();
            this.titleLimit.Text = Setting.Default.titleExcludeList;
            this.processLimit.Text = Setting.Default.processExcludeList;
            this.lengthLimit.Text = Setting.Default.maxLength.ToString();
            SetChromePictureInPicture();
            this.processList.DisplayMember = "Title";
            this.processList.ValueMember = "Handle";
        }

        public void InitProcess()
        {
            var allProcesses = WinApi.GetRootWindowsOfProcess(Properties.Settings.Default.minWidth, Properties.Settings.Default.minHeight);
            this.processes = allProcesses.Where(p => p.Title != "").ToArray();
            Array.Sort(this.processes, delegate (ProcessInfo p1, ProcessInfo p2) {
                return -p1.Title.CompareTo(p2.Title);
            });
            this.processList.DataSource = Filter();
        }

        public ProcessInfo[] Filter()
        {
            int lengthLimit = 50;
            try
            {
                lengthLimit = Int32.Parse(this.lengthLimit.Text);
            } catch
            {
                this.lengthLimit.Text = "50";
            }
            var filteredProcesses = this.processes.Where(p => p.Title.Length < lengthLimit).ToArray();
            if (this.titleSearchText.Text != "")
            {
                filteredProcesses = filteredProcesses.Where(p => p.Title.IndexOf(this.titleSearchText.Text) > -1).ToArray();
            }
            if (this.titleLimit.Text != "")
            {
                try
                {
                    var blockTitles = this.titleLimit.Text.Split(';');
                    for (int i = 0; i < blockTitles.Length; ++i)
                        if (blockTitles[i] != "")
                            filteredProcesses = filteredProcesses.Where(p => p.Title.IndexOf(blockTitles[i]) < 0).ToArray();
                } catch
                {
                    this.titleLimit.Text = "";
                }
            }
            if (this.processLimit.Text != "")
            {
                try
                {
                    var blockProcs = this.titleLimit.Text.Split(';');
                    for (int i = 0; i < blockProcs.Length; ++i)
                        if (blockProcs[i] != "")
                            filteredProcesses = filteredProcesses.Where(p => p.Name.IndexOf(blockProcs[i]) < 0).ToArray();
                }
                catch
                {
                    this.processLimit.Text = "";
                }
            }
            return filteredProcesses;
        }

        private void InitUI()
        {
            this.Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var FontColor = Color.FromArgb(233, 233, 233);
            this.ForeColor = FontColor;
            SetFont(new Control[] {
                alwaysOnTopCheckBox,
                darkMode,
                filterFrame,
                langLabel,
                languageComboxBox,
                refreshBtn,
                TrnLabel,
                penetrateCheckBox,
                filterFrame,
                selectedProc
            }, bigFont, FontColor);
            SetFont(new Control[] {
                lengthLimit,
                lengthLimitLabel,
                nameExcludeLabel,
                processLimit,
                titleExcludeLabel,
                titleLimit,
                titleSearchText,
                searchLabel
            }, medFont, FontColor);
            this.selectedProc.Size = new Size(200, 50);
            this.languageComboxBox.SelectedItem = Setting.Default.lang;
            this.SwitchLang();
        }

        private void SwitchLang()
        {
            switch (this.languageComboxBox.SelectedItem)
            {
                case "简体中文":
                    language = "zh_CN";
                    break;
                default:
                    language = "en";
                    break;
            }
            i18n = new ResourceManager("drawwin.ui_" + language, typeof(Main).Assembly);
            this.penetrateCheckBox.Text = i18n.GetString("pen");
            this.TrnLabel.Text = i18n.GetString("trn");
            this.alwaysOnTopCheckBox.Text = i18n.GetString("aot");
            this.refreshBtn.Text = i18n.GetString("rfb");
            this.lengthLimitLabel.Text = i18n.GetString("titleLimit");
            this.filterFrame.Text = i18n.GetString("filter");
            this.searchLabel.Text = i18n.GetString("search");
            this.nameExcludeLabel.Text = i18n.GetString("nameExclude");
            this.titleExcludeLabel.Text = i18n.GetString("titleExclude");
            this.darkMode.Text = i18n.GetString("dark");
        }

        private void TrnLabel_Click(object sender, EventArgs e)
        {

        }

        private void penetrateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (processList.SelectedItem == null || !this.isUserOperation)
            {
                return;
            }
            WindowMgr.SetPenetrate(((ProcessInfo)processList.SelectedItem).Handle, penetrateCheckBox.Checked);
        }

        private void processList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var currentProc = (ProcessInfo)processList.SelectedItem;
                this.penetrateCheckBox.Enabled = true;
                this.transparentBar.Enabled = true;
                this.alwaysOnTopCheckBox.Enabled = true;
                this.isUserOperation = false;
                this.currentWindowHandle = currentProc.Handle;
                this.penetrateCheckBox.Checked = WindowMgr.IsPenetrated(currentWindowHandle);
                this.transparentBar.Value = WindowMgr.GetTransparent(currentWindowHandle);
                this.alwaysOnTopCheckBox.Checked = WindowMgr.GetOnTop(currentWindowHandle);
                this.isUserOperation = true;
                this.selectedProc.Text = currentProc.Name + " - " + currentProc.Pid + Environment.NewLine + " w: " + currentProc.Rect.Width + " h: " + currentProc.Rect.Height;
                if (currentProc.Name == "drawwin")
                {
                    this.penetrateCheckBox.Enabled = false;
                }
            }
            catch
            {
                this.penetrateCheckBox.Enabled = false;
                this.transparentBar.Enabled = false;
                this.alwaysOnTopCheckBox.Enabled = false;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.notifyIcon.Visible = false;
            this.notifyIcon.Icon = this.Icon;
            this.notifyIcon.Text = "Drawwin is running...";
            this.notifyIcon.Click += notifyIcon1_Click;
        }

        private void Main_Minimized(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.notifyIcon.Visible = true;
                this.Hide();
                this.ShowInTaskbar = true;
                this.activated = false;
            }
        }
        
        private void Main_Activated(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                activated = true;
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.notifyIcon.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = false;
        }

        private void transparentBar_Scroll(object sender, EventArgs e)
        {
            if (this.isUserOperation)
            {
                WindowMgr.SetTransparent(currentWindowHandle, (byte)transparentBar.Value);
            }
        }

        private void Main_Close(object sender, FormClosedEventArgs e)
        {
            Setting.Default.titleExcludeList = this.titleLimit.Text;
            Setting.Default.processExcludeList = this.processLimit.Text;
            Setting.Default.maxLength = Int32.Parse(this.lengthLimit.Text);
            Setting.Default.lang = (String)this.languageComboxBox.SelectedItem;
            Properties.Settings.Default.Save();
            this.notifyIcon.Dispose();
        }

        private void languageComboxBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SwitchLang();
        }

        private void alwaysOnTopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isUserOperation)
            {
                WindowMgr.SetOnTop(currentWindowHandle, alwaysOnTopCheckBox.Checked);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.InitProcess();
        }

        private void lengthLimit_TextChanged(object sender, EventArgs e)
        {
            this.processList.DataSource = Filter();
        }

        private void titleSearchText_TextChanged(object sender, EventArgs e)
        {
            this.processList.DataSource = Filter();
        }

        private void titleLimit_TextChanged(object sender, EventArgs e)
        {
            this.processList.DataSource = Filter();
        }

        private void processLimit_TextChanged(object sender, EventArgs e)
        {
            this.processList.DataSource = Filter();
        }

        private void SetFont(Control[] components, Font font, Color foreColor)
        {
            foreach (Control comp in components)
            {
                comp.Font = font;
                comp.ForeColor = foreColor;
            }
        }

        private void darkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (darkMode.Checked)
            {
                // unavailable
                // WinApi.SetDarkTheme(this.currentWindowHandle);
            }
        }

        private void SetChromePictureInPicture()
        {
            var pip = this.processes.Where(p => p.Title == "画中画").ToArray()[0];
            WindowMgr.SetTransparent(pip.Handle, Setting.Default.pipAlpha);
            WindowMgr.SetPenetrate(pip.Handle, true);
            WindowMgr.SetOnTop(pip.Handle, true);
        }
    }
}
