namespace FuryAppDebloater
{
    partial class Uninstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uninstaller));
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdBtn = new System.Windows.Forms.Button();
            this.appBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfo.Font = new System.Drawing.Font("Lucida Console", 9.75F);
            this.txtInfo.ForeColor = System.Drawing.Color.White;
            this.txtInfo.Location = new System.Drawing.Point(0, 15);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(724, 454);
            this.txtInfo.TabIndex = 2;
            this.txtInfo.Text = resources.GetString("txtInfo.Text");
            this.txtInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.cmdBtn);
            this.panel2.Controls.Add(this.appBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 469);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 55);
            this.panel2.TabIndex = 4;
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
            this.cmdBtn.TabIndex = 0;
            this.cmdBtn.Text = "Run CMD";
            this.cmdBtn.UseVisualStyleBackColor = false;
            this.cmdBtn.Click += new System.EventHandler(this.cmdBtn_Click);
            // 
            // appBtn
            // 
            this.appBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(111)))), ((int)(((byte)(39)))));
            this.appBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appBtn.FlatAppearance.BorderSize = 0;
            this.appBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.appBtn.ForeColor = System.Drawing.Color.White;
            this.appBtn.Location = new System.Drawing.Point(552, 11);
            this.appBtn.Name = "appBtn";
            this.appBtn.Size = new System.Drawing.Size(160, 33);
            this.appBtn.TabIndex = 2;
            this.appBtn.Text = "Descargue aquí App Info";
            this.appBtn.UseVisualStyleBackColor = false;
            this.appBtn.Click += new System.EventHandler(this.appBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 15);
            this.panel1.TabIndex = 5;
            // 
            // Uninstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Uninstaller";
            this.Size = new System.Drawing.Size(724, 524);
            this.Load += new System.EventHandler(this.Uninstaller_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdBtn;
        private System.Windows.Forms.Button appBtn;
        private System.Windows.Forms.Panel panel1;
    }
}
