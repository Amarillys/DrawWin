using System;
using System.Timers;
using System.Windows.Forms;

namespace drawwin
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // init window manager
            WindowMgr wmgr = new WindowMgr();
            var mainWin = new Main();
            Application.Run(mainWin);
        }

        // Reference from https://www.cnblogs.com/wuchang/archive/2009/02/19/1096496.html
        public static void SetInterval(double interval, Action<ElapsedEventArgs> action)
        {
            System.Timers.Timer timer = new System.Timers.Timer(interval);
            timer.Elapsed += delegate (object sender, System.Timers.ElapsedEventArgs e)
            {
                action(e);
            };
            timer.Enabled = true;
        }
    }
}
