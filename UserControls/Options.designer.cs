namespace FuryAppDebloater
{
    partial class Options
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxLogo = new System.Windows.Forms.PictureBox();
            this.lblRights = new System.Windows.Forms.Label();
            this.lblOpt = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblCopy = new System.Windows.Forms.Label();
            this.paypalBtn = new FontAwesome.Sharp.IconButton();
            this.gitBtn = new FontAwesome.Sharp.IconButton();
            this.ytBtn = new FontAwesome.Sharp.IconButton();
            this.lblHelp = new System.Windows.Forms.Label();
            this.updateBtn = new FontAwesome.Sharp.IconButton();
            this.updateLbl = new System.Windows.Forms.Label();
            this.lblLang = new System.Windows.Forms.Label();
            this.langBox = new System.Windows.Forms.ComboBox();
            this.thanksLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.boxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxLogo
            // 
            this.boxLogo.Image = global::FuryAppDebloater.Properties.Resources.fury;
            this.boxLogo.Location = new System.Drawing.Point(25, 51);
            this.boxLogo.Name = "boxLogo";
            this.boxLogo.Size = new System.Drawing.Size(335, 270);
            this.boxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxLogo.TabIndex = 27;
            this.boxLogo.TabStop = false;
            // 
            // lblRights
            // 
            this.lblRights.AutoSize = true;
            this.lblRights.Font = new System.Drawing.Font("Aldo the Apache", 15.75F);
            this.lblRights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(230)))), ((int)(((byte)(158)))));
            this.lblRights.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRights.Location = new System.Drawing.Point(7, 324);
            this.lblRights.Name = "lblRights";
            this.lblRights.Size = new System.Drawing.Size(205, 27);
            this.lblRights.TabIndex = 23;
            this.lblRights.Text = "FURY GREENWOOD - 2022";
            // 
            // lblOpt
            // 
            this.lblOpt.AutoSize = true;
            this.lblOpt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblOpt.ForeColor = System.Drawing.Color.White;
            this.lblOpt.Location = new System.Drawing.Point(12, 23);
            this.lblOpt.Name = "lblOpt";
            this.lblOpt.Size = new System.Drawing.Size(91, 25);
            this.lblOpt.TabIndex = 22;
            this.lblOpt.Text = "Opciones";
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAbout.ForeColor = System.Drawing.Color.White;
            this.lblAbout.Location = new System.Drawing.Point(7, 23);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(96, 25);
            this.lblAbout.TabIndex = 21;
            this.lblAbout.Text = "Acerca de";
            // 
            // lblCopy
            // 
            this.lblCopy.AutoSize = true;
            this.lblCopy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopy.ForeColor = System.Drawing.Color.White;
            this.lblCopy.Location = new System.Drawing.Point(8, 351);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(369, 84);
            this.lblCopy.TabIndex = 20;
            this.lblCopy.Text = "\"The Android robot is reproduced or modified from \r\nwork created and shared by Go" +
    "ogle and used \r\naccording to terms described in the Creative \r\nCommons 3.0 Attri" +
    "bution License.\"";
            this.lblCopy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // paypalBtn
            // 
            this.paypalBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.paypalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paypalBtn.FlatAppearance.BorderSize = 0;
            this.paypalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paypalBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paypalBtn.ForeColor = System.Drawing.Color.White;
            this.paypalBtn.IconChar = FontAwesome.Sharp.IconChar.Paypal;
            this.paypalBtn.IconColor = System.Drawing.Color.White;
            this.paypalBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.paypalBtn.IconSize = 40;
            this.paypalBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paypalBtn.Location = new System.Drawing.Point(17, 455);
            this.paypalBtn.Name = "paypalBtn";
            this.paypalBtn.Size = new System.Drawing.Size(234, 42);
            this.paypalBtn.TabIndex = 19;
            this.paypalBtn.Text = "Donate";
            this.paypalBtn.UseVisualStyleBackColor = false;
            this.paypalBtn.Click += new System.EventHandler(this.paypalBtn_Click);
            // 
            // gitBtn
            // 
            this.gitBtn.BackColor = System.Drawing.Color.Black;
            this.gitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gitBtn.FlatAppearance.BorderSize = 0;
            this.gitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gitBtn.ForeColor = System.Drawing.Color.White;
            this.gitBtn.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.gitBtn.IconColor = System.Drawing.Color.White;
            this.gitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.gitBtn.IconSize = 40;
            this.gitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gitBtn.Location = new System.Drawing.Point(17, 407);
            this.gitBtn.Name = "gitBtn";
            this.gitBtn.Size = new System.Drawing.Size(234, 42);
            this.gitBtn.TabIndex = 18;
            this.gitBtn.Text = "GitHub";
            this.gitBtn.UseVisualStyleBackColor = false;
            this.gitBtn.Click += new System.EventHandler(this.gitBtn_Click);
            // 
            // ytBtn
            // 
            this.ytBtn.BackColor = System.Drawing.Color.Red;
            this.ytBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ytBtn.FlatAppearance.BorderSize = 0;
            this.ytBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ytBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ytBtn.ForeColor = System.Drawing.Color.White;
            this.ytBtn.IconChar = FontAwesome.Sharp.IconChar.Youtube;
            this.ytBtn.IconColor = System.Drawing.Color.White;
            this.ytBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ytBtn.IconSize = 40;
            this.ytBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ytBtn.Location = new System.Drawing.Point(17, 359);
            this.ytBtn.Name = "ytBtn";
            this.ytBtn.Size = new System.Drawing.Size(234, 42);
            this.ytBtn.TabIndex = 17;
            this.ytBtn.Text = "YouTube";
            this.ytBtn.UseVisualStyleBackColor = false;
            this.ytBtn.Click += new System.EventHandler(this.ytBtn_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(13, 324);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(165, 25);
            this.lblHelp.TabIndex = 16;
            this.lblHelp.Text = "Ayuda y Contacto";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(11)))), ((int)(((byte)(166)))));
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.updateBtn.IconColor = System.Drawing.Color.White;
            this.updateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updateBtn.IconSize = 40;
            this.updateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Location = new System.Drawing.Point(17, 209);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(234, 42);
            this.updateBtn.TabIndex = 15;
            this.updateBtn.Text = "Buscar actualizaciones";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // updateLbl
            // 
            this.updateLbl.AutoSize = true;
            this.updateLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLbl.ForeColor = System.Drawing.Color.White;
            this.updateLbl.Location = new System.Drawing.Point(13, 185);
            this.updateLbl.Name = "updateLbl";
            this.updateLbl.Size = new System.Drawing.Size(116, 21);
            this.updateLbl.TabIndex = 14;
            this.updateLbl.Text = "Actualizaciones";
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLang.ForeColor = System.Drawing.Color.White;
            this.lblLang.Location = new System.Drawing.Point(14, 60);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(121, 21);
            this.lblLang.TabIndex = 13;
            this.lblLang.Text = "Cambiar idioma";
            // 
            // langBox
            // 
            this.langBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.langBox.FormattingEnabled = true;
            this.langBox.Items.AddRange(new object[] {
            "English (EN)",
            "Español (ES)"});
            this.langBox.Location = new System.Drawing.Point(17, 84);
            this.langBox.Name = "langBox";
            this.langBox.Size = new System.Drawing.Size(234, 28);
            this.langBox.TabIndex = 28;
            this.langBox.SelectedIndexChanged += new System.EventHandler(this.langBox_SelectedIndexChanged);
            // 
            // thanksLbl
            // 
            this.thanksLbl.AutoSize = true;
            this.thanksLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.thanksLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.thanksLbl.Location = new System.Drawing.Point(8, 435);
            this.thanksLbl.Name = "thanksLbl";
            this.thanksLbl.Size = new System.Drawing.Size(368, 40);
            this.thanksLbl.TabIndex = 29;
            this.thanksLbl.Text = "Agradecimientos especiales a: Ricaidito, AbrahamJLR\r\ny Ts-Pytham";
            this.thanksLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.thanksLbl);
            this.panel1.Controls.Add(this.lblRights);
            this.panel1.Controls.Add(this.lblCopy);
            this.panel1.Controls.Add(this.boxLogo);
            this.panel1.Controls.Add(this.lblAbout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(332, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 524);
            this.panel1.TabIndex = 30;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(332, 524);
            this.flowLayoutPanel1.TabIndex = 31;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.langBox);
            this.Controls.Add(this.lblOpt);
            this.Controls.Add(this.paypalBtn);
            this.Controls.Add(this.gitBtn);
            this.Controls.Add(this.ytBtn);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.updateLbl);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Options";
            this.Size = new System.Drawing.Size(724, 524);
            this.Load += new System.EventHandler(this.Options_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox boxLogo;
        private System.Windows.Forms.Label lblRights;
        private System.Windows.Forms.Label lblOpt;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblCopy;
        private FontAwesome.Sharp.IconButton paypalBtn;
        private FontAwesome.Sharp.IconButton gitBtn;
        private FontAwesome.Sharp.IconButton ytBtn;
        private System.Windows.Forms.Label lblHelp;
        private FontAwesome.Sharp.IconButton updateBtn;
        private System.Windows.Forms.Label updateLbl;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.ComboBox langBox;
        private System.Windows.Forms.Label thanksLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
