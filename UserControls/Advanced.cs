using FuryAppDebloater.Languages;
using FuryAppDebloater.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace FuryAppDebloater
{
    public partial class Advanced : UserControl
    {
        private void Advanced_Load(object sender, EventArgs e)
        {
            LoadLanguage();
        }
        public Advanced()
        {
            InitializeComponent();
        }

        private void cmdBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string directory = Directory.GetCurrentDirectory() + @"/ADB";
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                var batFileName = Path.Combine(directory, "Advanced.bat");
                File.Delete(batFileName);

                using (FileStream stream =
                    new FileStream(batFileName, FileMode.CreateNew, FileAccess.Write))
                {
                    var bytes = Resources.Advanced;
                    stream.Write(bytes, 0, bytes.Length);
                }
                Process.Start(batFileName);
            }
            catch { }
        }

        private void btnSDK_Click(object sender, EventArgs e)
        {
            Process.Start("https://developer.android.com/studio#downloads");
        }

        public void LoadLanguage()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Settings.Default.Language);
            lblTitle.Text = Lang.lblTitle;
            lblInfo.Text = Lang.lblInfo;
            btnSDK.Text = Lang.btnSDK;
        }
    }
}
