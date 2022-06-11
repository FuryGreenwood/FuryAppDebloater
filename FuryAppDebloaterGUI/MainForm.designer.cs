
namespace FuryAppDebloater
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVer = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnAdv = new FontAwesome.Sharp.IconButton();
            this.btnMain = new FontAwesome.Sharp.IconButton();
            this.btnOptions = new FontAwesome.Sharp.IconButton();
            this.pnlChild = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlTitle.Controls.Add(this.pictureBox1);
            this.pnlTitle.Controls.Add(this.lblVer);
            this.pnlTitle.Controls.Add(this.lblTitle2);
            this.pnlTitle.Controls.Add(this.lblTitle1);
            resources.ApplyResources(this.pnlTitle, "pnlTitle");
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FuryAppDebloater.Properties.Resources.fury;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lblVer
            // 
            resources.ApplyResources(this.lblVer, "lblVer");
            this.lblVer.ForeColor = System.Drawing.Color.White;
            this.lblVer.Name = "lblVer";
            // 
            // lblTitle2
            // 
            resources.ApplyResources(this.lblTitle2, "lblTitle2");
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Name = "lblTitle2";
            // 
            // lblTitle1
            // 
            resources.ApplyResources(this.lblTitle1, "lblTitle1");
            this.lblTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(230)))), ((int)(((byte)(158)))));
            this.lblTitle1.Name = "lblTitle1";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlMenu.Controls.Add(this.btnAdv);
            this.pnlMenu.Controls.Add(this.btnMain);
            this.pnlMenu.Controls.Add(this.btnOptions);
            resources.ApplyResources(this.pnlMenu, "pnlMenu");
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseDown);
            // 
            // btnAdv
            // 
            this.btnAdv.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAdv, "btnAdv");
            this.btnAdv.FlatAppearance.BorderSize = 0;
            this.btnAdv.ForeColor = System.Drawing.Color.White;
            this.btnAdv.IconChar = FontAwesome.Sharp.IconChar.Terminal;
            this.btnAdv.IconColor = System.Drawing.Color.White;
            this.btnAdv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdv.IconSize = 45;
            this.btnAdv.Name = "btnAdv";
            this.btnAdv.UseVisualStyleBackColor = true;
            this.btnAdv.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // btnMain
            // 
            this.btnMain.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnMain, "btnMain");
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.ForeColor = System.Drawing.Color.White;
            this.btnMain.IconChar = FontAwesome.Sharp.IconChar.Android;
            this.btnMain.IconColor = System.Drawing.Color.White;
            this.btnMain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMain.IconSize = 45;
            this.btnMain.Name = "btnMain";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnOptions, "btnOptions");
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.ForeColor = System.Drawing.Color.White;
            this.btnOptions.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnOptions.IconColor = System.Drawing.Color.White;
            this.btnOptions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOptions.IconSize = 45;
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // pnlChild
            // 
            resources.ApplyResources(this.pnlChild, "pnlChild");
            this.pnlChild.Name = "pnlChild";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.pnlChild);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlChild;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnOptions;
        private FontAwesome.Sharp.IconButton btnAdv;
        private FontAwesome.Sharp.IconButton btnMain;
    }
}

