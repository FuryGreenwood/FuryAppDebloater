using System.Globalization;
using FuryAppDebloater.Languages;
using FuryAppDebloater.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace FuryAppDebloater
{
    public partial class Uninstaller : UserControl
    {
        private void Uninstaller_Load(object sender, EventArgs e)
        {
            LoadLanguage();
        }
        public Uninstaller()
        {
            InitializeComponent();
        }

        private void cmdBtn_Click(object sender, EventArgs e)
        {
            try //DLLS
            {
                string directory = Directory.GetCurrentDirectory() + @"/ADB";
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                var dllFileName = Path.Combine(directory, "AdbWinApi.dll");
                File.Delete(dllFileName);

                using (FileStream stream =
                    new FileStream(dllFileName, FileMode.CreateNew, FileAccess.Write))
                {
                    var bytes = Resources.AdbWinApi;
                    stream.Write(bytes, 0, bytes.Length);
                }
            }
            catch { }
            try
            {
                string directory = Directory.GetCurrentDirectory() + @"/ADB";
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                var dllFileName = Path.Combine(directory, "AdbWinUsbApi.dll");
                File.Delete(dllFileName);

                using (FileStream stream =
                    new FileStream(dllFileName, FileMode.CreateNew, FileAccess.Write))
                {
                    var bytes = Resources.AdbWinUsbApi;
                    stream.Write(bytes, 0, bytes.Length);
                }
            }
            catch { }

            try //EXEs
            {
                string directory = Directory.GetCurrentDirectory() + @"/ADB";
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                var exeFileName = Path.Combine(directory, "adb.exe");
                File.Delete(exeFileName);

                using (FileStream stream =
                    new FileStream(exeFileName, FileMode.CreateNew, FileAccess.Write))
                {
                    var bytes = Resources.adb;
                    stream.Write(bytes, 0, bytes.Length);
                }
                Process.Start(exeFileName);
            }
            catch { }
            try
            {
                string directory = Directory.GetCurrentDirectory() + @"/ADB";
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                var exeFileName = Path.Combine(directory, "fastboot.exe");
                File.Delete(exeFileName);

                using (FileStream stream =
                    new FileStream(exeFileName, FileMode.CreateNew, FileAccess.Write))
                {
                    var bytes = Resources.fastboot;
                    stream.Write(bytes, 0, bytes.Length);
                }
            }
            catch { }

            try //UnisBAT
            {
                string directory = Directory.GetCurrentDirectory() + @"/ADB";
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                var batFileName = Path.Combine(directory, "Uninstaller.bat");
                File.Delete(batFileName);

                using (FileStream stream =
                    new FileStream(batFileName, FileMode.CreateNew, FileAccess.Write))
                {
                    var bytes = Resources.Uninstaller;
                    stream.Write(bytes, 0, bytes.Length);
                }
                Process.Start(batFileName);
            }
            catch { }
        }

        private void appBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://play.google.com/store/apps/details?id=com.devrimtuncer.appinfo");
        }

        public void LoadLanguage()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Settings.Default.Language);
            txtInfo.Text = Lang.txtInfo;
            appBtn.Text = Lang.appBtn;
        }
    }
}