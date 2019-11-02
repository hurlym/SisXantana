namespace SistemaXantana.Login
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.LBWelcome = new System.Windows.Forms.Label();
            this.BTLogin = new System.Windows.Forms.Button();
            this.CKUsuario = new System.Windows.Forms.CheckBox();
            this.TBClave = new System.Windows.Forms.TextBox();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.BTMinimizar = new System.Windows.Forms.PictureBox();
            this.BTCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BTMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LBWelcome
            // 
            this.LBWelcome.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.LBWelcome.ForeColor = System.Drawing.Color.Black;
            this.LBWelcome.Location = new System.Drawing.Point(343, 18);
            this.LBWelcome.Name = "LBWelcome";
            this.LBWelcome.Size = new System.Drawing.Size(317, 40);
            this.LBWelcome.TabIndex = 3;
            this.LBWelcome.Text = "Bienvenido al Sistema";
            this.LBWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTLogin
            // 
            this.BTLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BTLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTLogin.FlatAppearance.BorderSize = 0;
            this.BTLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.BTLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BTLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTLogin.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.BTLogin.ForeColor = System.Drawing.Color.Black;
            this.BTLogin.Location = new System.Drawing.Point(307, 227);
            this.BTLogin.Name = "BTLogin";
            this.BTLogin.Size = new System.Drawing.Size(400, 40);
            this.BTLogin.TabIndex = 10;
            this.BTLogin.Text = "ACCEDER";
            this.BTLogin.UseVisualStyleBackColor = false;
            this.BTLogin.Click += new System.EventHandler(this.BTLogin_Click);
            // 
            // CKUsuario
            // 
            this.CKUsuario.AutoSize = true;
            this.CKUsuario.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.CKUsuario.ForeColor = System.Drawing.Color.Black;
            this.CKUsuario.Location = new System.Drawing.Point(307, 168);
            this.CKUsuario.Name = "CKUsuario";
            this.CKUsuario.Size = new System.Drawing.Size(129, 21);
            this.CKUsuario.TabIndex = 9;
            this.CKUsuario.Text = "Recordar usuario";
            this.CKUsuario.UseVisualStyleBackColor = true;
            this.CKUsuario.Visible = false;
            // 
            // TBClave
            // 
            this.TBClave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TBClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBClave.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.TBClave.ForeColor = System.Drawing.Color.DarkGray;
            this.TBClave.Location = new System.Drawing.Point(307, 124);
            this.TBClave.Name = "TBClave";
            this.TBClave.Size = new System.Drawing.Size(400, 23);
            this.TBClave.TabIndex = 8;
            this.TBClave.Text = "CONTRASEÑA";
            // 
            // TBUsuario
            // 
            this.TBUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TBUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBUsuario.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.TBUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.TBUsuario.Location = new System.Drawing.Point(307, 76);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(400, 23);
            this.TBUsuario.TabIndex = 7;
            this.TBUsuario.Text = "USUARIO - EMAIL";
            // 
            // BTMinimizar
            // 
            this.BTMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BTMinimizar.Image")));
            this.BTMinimizar.Location = new System.Drawing.Point(720, 6);
            this.BTMinimizar.Name = "BTMinimizar";
            this.BTMinimizar.Size = new System.Drawing.Size(15, 15);
            this.BTMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTMinimizar.TabIndex = 17;
            this.BTMinimizar.TabStop = false;
            this.BTMinimizar.Click += new System.EventHandler(this.BTMinimizar_Click);
            // 
            // BTCerrar
            // 
            this.BTCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BTCerrar.Image")));
            this.BTCerrar.Location = new System.Drawing.Point(741, 6);
            this.BTCerrar.Name = "BTCerrar";
            this.BTCerrar.Size = new System.Drawing.Size(15, 15);
            this.BTCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTCerrar.TabIndex = 16;
            this.BTCerrar.TabStop = false;
            this.BTCerrar.Click += new System.EventHandler(this.BTCerrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemaXantana.Properties.Resources.X_FONDO_BLANCO;
            this.pictureBox2.Location = new System.Drawing.Point(8, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(259, 292);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 291);
            this.Controls.Add(this.BTMinimizar);
            this.Controls.Add(this.BTCerrar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BTLogin);
            this.Controls.Add(this.CKUsuario);
            this.Controls.Add(this.TBClave);
            this.Controls.Add(this.TBUsuario);
            this.Controls.Add(this.LBWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BTMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBWelcome;
        private System.Windows.Forms.Button BTLogin;
        private System.Windows.Forms.CheckBox CKUsuario;
        private System.Windows.Forms.TextBox TBClave;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox BTMinimizar;
        private System.Windows.Forms.PictureBox BTCerrar;
    }
}