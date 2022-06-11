using FontAwesome.Sharp;
using FuryAppDebloater.Languages;
using FuryAppDebloater.Properties;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace FuryAppDebloater
{
    public partial class MainForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private string _currentButton, _lastActive;

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
        private void MainForm_Load(object sender, EventArgs e)
        {
            CustomFont();
            lblTitle1.Font = new Font(font_AldotheApache, 16, FontStyle.Regular);
            lblTitle2.Font = new Font(font_AldotheApache, 16, FontStyle.Regular);
            lblVer.Font = new Font(font_AldotheApache, 16, FontStyle.Regular);
            LoadLanguage();
            btnMain.PerformClick();
        }
        public MainForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 76);
            pnlMenu.Controls.Add(leftBorderBtn);
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlChild.Controls.Clear();
            pnlChild.Controls.Add(userControl);
            userControl.BringToFront();
        }

        //Colors Structure
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(23, 230, 158);
            public static Color color2 = Color.White;
        }
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(23, 158, 230);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                currentBtn.Cursor = Cursors.Arrow;
                //LeftBorder
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(20, 20, 20);
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.White;
                currentBtn.Cursor = Cursors.Hand;
            }
        }

        //Drag Form Functions
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pnlMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Buttons Functions
        private void btnMain_Click(object sender, EventArgs e)
        {
            _currentButton = sender.ToString();
            if (_currentButton != _lastActive)
            {
                _lastActive = _currentButton;
                ActiveButton(sender, RGBColors.color1);
                Uninstaller unis = new Uninstaller();
                addUserControl(unis);
            }
        }
        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            _currentButton = sender.ToString();
            if (_currentButton != _lastActive)
            {
                _lastActive = _currentButton;
                ActiveButton(sender, RGBColors.color2);
                Advanced adv = new Advanced();
                addUserControl(adv);
            }
        }
        private void btnOptions_Click(object sender, EventArgs e)
        {
            _currentButton = sender.ToString();
            if (_currentButton != _lastActive)
            {
                _lastActive = _currentButton;
                ActiveButton(sender, RGBColors.color2);
                Options op = new Options(this); //Lang Fixed
                addUserControl(op);
            }
        }

        public void LoadLanguage()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Settings.Default.Language);
            btnMain.Text = Lang.btnMain;
            btnAdv.Text = Lang.btnAdv;
            btnOptions.Text = Lang.btnOptions;
        }
    }
}