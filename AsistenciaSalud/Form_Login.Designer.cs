namespace AsistenciaSalud
{
    partial class Form_Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.pnl_imagen = new System.Windows.Forms.Panel();
            this.pbsalud = new System.Windows.Forms.PictureBox();
            this.lbsecretaria = new System.Windows.Forms.Label();
            this.lbsistema = new System.Windows.Forms.Label();
            this.txt_user = new MetroFramework.Controls.MetroTextBox();
            this.txt_pass = new MetroFramework.Controls.MetroTextBox();
            this.pbuser = new System.Windows.Forms.PictureBox();
            this.pbpassword = new System.Windows.Forms.PictureBox();
            this.mbaccesar = new MetroFramework.Controls.MetroButton();
            this.close_login = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbsalud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_login)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(1000, 30);
            this.pnl_titulo.TabIndex = 20;
            this.pnl_titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_titulo_MouseMove);
            // 
            // pnl_imagen
            // 
            this.pnl_imagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_imagen.BackgroundImage")));
            this.pnl_imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_imagen.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_imagen.Location = new System.Drawing.Point(500, 30);
            this.pnl_imagen.Name = "pnl_imagen";
            this.pnl_imagen.Size = new System.Drawing.Size(500, 570);
            this.pnl_imagen.TabIndex = 3;
            // 
            // pbsalud
            // 
            this.pbsalud.Image = ((System.Drawing.Image)(resources.GetObject("pbsalud.Image")));
            this.pbsalud.Location = new System.Drawing.Point(137, 53);
            this.pbsalud.Name = "pbsalud";
            this.pbsalud.Size = new System.Drawing.Size(191, 79);
            this.pbsalud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsalud.TabIndex = 2;
            this.pbsalud.TabStop = false;
            // 
            // lbsecretaria
            // 
            this.lbsecretaria.AutoSize = true;
            this.lbsecretaria.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsecretaria.ForeColor = System.Drawing.Color.DimGray;
            this.lbsecretaria.Location = new System.Drawing.Point(120, 150);
            this.lbsecretaria.Name = "lbsecretaria";
            this.lbsecretaria.Size = new System.Drawing.Size(235, 25);
            this.lbsecretaria.TabIndex = 3;
            this.lbsecretaria.Text = "SECRETARÍA DE SALUD";
            // 
            // lbsistema
            // 
            this.lbsistema.AutoSize = true;
            this.lbsistema.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsistema.ForeColor = System.Drawing.Color.DimGray;
            this.lbsistema.Location = new System.Drawing.Point(96, 175);
            this.lbsistema.Name = "lbsistema";
            this.lbsistema.Size = new System.Drawing.Size(273, 20);
            this.lbsistema.TabIndex = 4;
            this.lbsistema.Text = "SISTEMA DE CONTROL DE ASISTENCIA";
            // 
            // txt_user
            // 
            this.txt_user.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_user.Lines = new string[0];
            this.txt_user.Location = new System.Drawing.Point(110, 298);
            this.txt_user.MaxLength = 32767;
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '\0';
            this.txt_user.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_user.SelectedText = "";
            this.txt_user.Size = new System.Drawing.Size(301, 40);
            this.txt_user.TabIndex = 1;
            this.txt_user.UseSelectable = true;
            // 
            // txt_pass
            // 
            this.txt_pass.Lines = new string[0];
            this.txt_pass.Location = new System.Drawing.Point(111, 364);
            this.txt_pass.MaxLength = 32767;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '●';
            this.txt_pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pass.SelectedText = "";
            this.txt_pass.Size = new System.Drawing.Size(301, 40);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.UseSelectable = true;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // pbuser
            // 
            this.pbuser.Image = ((System.Drawing.Image)(resources.GetObject("pbuser.Image")));
            this.pbuser.Location = new System.Drawing.Point(57, 294);
            this.pbuser.Name = "pbuser";
            this.pbuser.Size = new System.Drawing.Size(43, 45);
            this.pbuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbuser.TabIndex = 11;
            this.pbuser.TabStop = false;
            // 
            // pbpassword
            // 
            this.pbpassword.Image = ((System.Drawing.Image)(resources.GetObject("pbpassword.Image")));
            this.pbpassword.Location = new System.Drawing.Point(57, 361);
            this.pbpassword.Name = "pbpassword";
            this.pbpassword.Size = new System.Drawing.Size(43, 45);
            this.pbpassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpassword.TabIndex = 12;
            this.pbpassword.TabStop = false;
            // 
            // mbaccesar
            // 
            this.mbaccesar.Location = new System.Drawing.Point(165, 452);
            this.mbaccesar.Name = "mbaccesar";
            this.mbaccesar.Size = new System.Drawing.Size(163, 61);
            this.mbaccesar.TabIndex = 13;
            this.mbaccesar.Text = "ACCESAR";
            this.mbaccesar.UseSelectable = true;
            this.mbaccesar.Click += new System.EventHandler(this.btn_acceder_Click);
            // 
            // close_login
            // 
            this.close_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_login.Image = ((System.Drawing.Image)(resources.GetObject("close_login.Image")));
            this.close_login.Location = new System.Drawing.Point(464, 53);
            this.close_login.Name = "close_login";
            this.close_login.Size = new System.Drawing.Size(30, 28);
            this.close_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_login.TabIndex = 14;
            this.close_login.TabStop = false;
            this.close_login.Click += new System.EventHandler(this.close_login_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.close_login);
            this.Controls.Add(this.mbaccesar);
            this.Controls.Add(this.pbpassword);
            this.Controls.Add(this.pbuser);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbsistema);
            this.Controls.Add(this.lbsecretaria);
            this.Controls.Add(this.pbsalud);
            this.Controls.Add(this.pnl_imagen);
            this.Controls.Add(this.pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbsalud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnl_imagen;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Label lbsistema;
        private System.Windows.Forms.Label lbsecretaria;
        private System.Windows.Forms.PictureBox pbsalud;
        private MetroFramework.Controls.MetroTextBox txt_user;
        private MetroFramework.Controls.MetroTextBox txt_pass;
        private System.Windows.Forms.PictureBox pbpassword;
        private System.Windows.Forms.PictureBox pbuser;
        private System.Windows.Forms.PictureBox close_login;
        private MetroFramework.Controls.MetroButton mbaccesar;
    }
}

