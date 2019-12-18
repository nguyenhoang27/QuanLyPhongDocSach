using System;
using System.IO;
using System.Windows.Forms;

using DataAccess;

namespace QuanLiThuVien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Config.ConfigFilePath = "config.xml";
            if (!File.Exists("config.xml"))
            {
                MessageBox.Show("Không tìm thấy file config!", "Lỗi");
            }

            Config.GetConfig();

            //setup database
            Database.InitDatabase(Config.Instance.database, Config.Instance.secret);

            //setup crash handler
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var entryform = new LoginForm();
            entryform.FormClosed += (o, e) =>
            {
                Config.SetConfig();
            };
            Application.Run(entryform);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            string message = new string('=', 20) + Environment.NewLine +
                ex.Message + Environment.NewLine +
                ex.StackTrace + Environment.NewLine +
                ex.TargetSite;
            string logfilename = "crashlog_" + DateTime.Now.ToString(@"dd_MM_yyyy_HH_mm") + ".txt";
            try
            {
                File.WriteAllText(logfilename, message);
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
    }
}
