using FuryAppDebloater.Languages;
using FuryAppDebloater.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace FuryAppDebloater
{
    public partial class Options : UserControl
    {
        private MainForm Fix { get; set; }
        //Custom Font (Aldo the Apache)
        [DllImport("gdi32.DLL")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
        FontFamily font_AldotheApache;
        private void CustomFont()
        {
            PrivateFontCollection new_Font = new PrivateFontCollection();
            int long_font = Resources.AldotheApache.Length;
            byte[] fontdata = Resources.AldotheApache;
            IntPtr replace = Marshal.AllocCoTaskMem(long_font);
            Marshal.Copy(fontdata, 0, replace, long_font);
            uint cFonts = 0;
            AddFontMemResourceEx(replace, (uint)fontdata.Length, IntPtr.Zero, ref cFonts);
            new_Font.AddMemoryFont(replace, long_font);
            Marshal.FreeCoTaskMem(replace);
            font_AldotheApache = new_Font.Families[0];
        }
        private void Options_Load(object sender, EventArgs e)
        {
            CustomFont();
            lblRights.Font = new Font(font_AldotheApache, 16, FontStyle.Regular);
            LoadLanguage();
            langBox.Text = Settings.Default.LangSelected;
        }
        public Options(MainForm mainForm)
        {
            InitializeComponent();
            Fix = mainForm;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/FuryGreenwood/FuryAppDebloater/releases");
        }
        private void ytBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UC30r679XKN70OdvHmmMAjcg");
        }
        private void gitBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/FuryGreenwood");
        }
        private void paypalBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://paypal.me/FuryGreenwood?");
        }
        private void discordBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/XUbuJYbUSG");
        }

        public void LoadLanguage()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Settings.Default.Language);
            lblOpt.Text = Lang.lblOpt;
            lblLang.Text = Lang.lblLang;
            updateLbl.Text = Lang.updateLbl;
            updateBtn.Text = Lang.updateBtn;
            lblHelp.Text = Lang.lblHelp;
            lblAbout.Text = Lang.lblAbout;
            thanksLbl.Text = Lang.thanksLbl;
            Fix.LoadLanguage();
        }
        //Language control
        private void langBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (langBox.SelectedIndex)
            {
                case 0:
                    Settings.Default.Language = "en";
                    Settings.Default.LangSelected = langBox.Text;
                    LoadLanguage();
                    break;

                case 1:
                    Settings.Default.Language = "es";
                    Settings.Default.LangSelected = langBox.Text;
                    LoadLanguage();
                    break;
            }
        }
    }
}