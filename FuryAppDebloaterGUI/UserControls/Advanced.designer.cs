namespace FuryAppDebloater
{
    partial class Advanced
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Advanced));
            this.pnlTxt = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.cmdBtn = new System.Windows.Forms.Button();
            this.btnSDK = new System.Windows.Forms.Button();
            this.boxLogo = new System.Windows.Forms.PictureBox();
            this.pnlTxt.SuspendLayout();
            this.pnlBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTxt
            // 
            this.pnlTxt.Controls.Add(this.lblInfo);
            this.pnlTxt.Controls.Add(this.lblTitle);
            this.pnlTxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTxt.Location = new System.Drawing.Point(0, 0);
            this.pnlTxt.Name = "pnlTxt";
            this.pnlTxt.Size = new System.Drawing.Size(724, 148);
            this.pnlTxt.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(13, 50);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(694, 60);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Modo Avanzado";
            // 
            // pnlBtn
            // 
            this.pnlBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlBtn.Controls.Add(this.cmdBtn);
            this.pnlBtn.Controls.Add(this.btnSDK);
            this.pnlBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBtn.Location = new System.Drawing.Point(0, 469);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(724, 55);
            this.pnlBtn.TabIndex = 2;
            // 
            // cmdBtn
            // 
            this.cmdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(239)))));
            this.cmdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdBtn.FlatAppearance.BorderSize = 0;
            this.cmdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmdBtn.ForeColor = System.Drawing.Color.White;
            this.cmdBtn.Location = new System.Drawing.Point(12, 11);
            this.cmdBtn.Name = "cmdBtn";
            this.cmdBtn.Size = new System.Drawing.Size(75, 33);
            this.cmdBtn.TabIndex = 3;
            this.cmdBtn.Text = "Run CMD";
            this.cmdBtn.UseVisualStyleBackColor = false;
            this.cmdBtn.Click += new System.EventHandler(this.cmdBtn_Click);
            // 
            // btnSDK
            // 
            this.btnSDK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(111)))), ((int)(((byte)(39)))));
            this.btnSDK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSDK.FlatAppearance.BorderSize = 0;
            this.btnSDK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSDK.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSDK.ForeColor = System.Drawing.Color.White;
            this.btnSDK.Location = new System.Drawing.Point(442, 11);
            this.btnSDK.Name = "btnSDK";
            this.btnSDK.Size = new System.Drawing.Size(270, 33);
            this.btnSDK.TabIndex = 4;
            this.btnSDK.Text = "Descargue aquí Android SDK Platform-Tools";
            this.btnSDK.UseVisualStyleBackColor = false;
            this.btnSDK.Click += new System.EventHandler(this.btnSDK_Click);
            // 
            // boxLogo
            // 
            this.boxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxLogo.Image = global::FuryAppDebloater.Properties.Resources.adv;
            this.boxLogo.Location = new System.Drawing.Point(0, 148);
            this.boxLogo.Name = "boxLogo";
            this.boxLogo.Size = new System.Drawing.Size(724, 321);
            this.boxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxLogo.TabIndex = 3;
            this.boxLogo.TabStop = false;
            // 
            // Advanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.boxLogo);
            this.Controls.Add(this.pnlBtn);
            this.Controls.Add(this.pnlTxt);
            this.Name = "Advanced";
            this.Size = new System.Drawing.Size(724, 524);
            this.Load += new System.EventHandler(this.Advanced_Load);
            this.pnlTxt.ResumeLayout(false);
            this.pnlTxt.PerformLayout();
            this.pnlBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTxt;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.Button cmdBtn;
        private System.Windows.Forms.Button btnSDK;
        private System.Windows.Forms.PictureBox boxLogo;
    }
}
