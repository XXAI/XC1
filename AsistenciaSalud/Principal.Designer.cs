namespace AsistenciaSalud
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbpersonal = new System.Windows.Forms.ToolStripLabel();
            this.tslclue = new System.Windows.Forms.ToolStripLabel();
            this.mtcmenu = new MetroFramework.Controls.MetroTabControl();
            this.mtpempleados = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.mtcmenuprincipal = new MetroFramework.Controls.MetroTabPage();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mltrabajadores = new MetroFramework.Controls.MetroTile();
            this.mlusuarios = new MetroFramework.Controls.MetroTile();
            this.mlpermisos = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.pbsalud = new System.Windows.Forms.PictureBox();
            this.close_principal = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.mtcmenu.SuspendLayout();
            this.mtpempleados.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.mtcmenuprincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbsalud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_principal)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbpersonal,
            this.tslclue});
            this.toolStrip1.Location = new System.Drawing.Point(20, 405);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(760, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslbpersonal
            // 
            this.tslbpersonal.Name = "tslbpersonal";
            this.tslbpersonal.Size = new System.Drawing.Size(0, 22);
            // 
            // tslclue
            // 
            this.tslclue.Name = "tslclue";
            this.tslclue.Size = new System.Drawing.Size(0, 22);
            // 
            // mtcmenu
            // 
            this.mtcmenu.Controls.Add(this.mtpempleados);
            this.mtcmenu.Controls.Add(this.metroTabPage2);
            this.mtcmenu.Controls.Add(this.mtcmenuprincipal);
            this.mtcmenu.Controls.Add(this.metroTabPage1);
            this.mtcmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtcmenu.Location = new System.Drawing.Point(20, 60);
            this.mtcmenu.Name = "mtcmenu";
            this.mtcmenu.SelectedIndex = 2;
            this.mtcmenu.Size = new System.Drawing.Size(760, 345);
            this.mtcmenu.TabIndex = 18;
            this.mtcmenu.UseSelectable = true;
            // 
            // mtpempleados
            // 
            this.mtpempleados.Controls.Add(this.metroTile1);
            this.mtpempleados.HorizontalScrollbarBarColor = true;
            this.mtpempleados.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpempleados.HorizontalScrollbarSize = 10;
            this.mtpempleados.Location = new System.Drawing.Point(4, 38);
            this.mtpempleados.Name = "mtpempleados";
            this.mtpempleados.Size = new System.Drawing.Size(752, 303);
            this.mtpempleados.TabIndex = 3;
            this.mtpempleados.Text = "Empleados";
            this.mtpempleados.VerticalScrollbarBarColor = true;
            this.mtpempleados.VerticalScrollbarHighlightOnWheel = false;
            this.mtpempleados.VerticalScrollbarSize = 10;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(752, 303);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Dispositivos";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.mltrabajadores);
            this.metroTabPage2.Controls.Add(this.mlusuarios);
            this.metroTabPage2.Controls.Add(this.mlpermisos);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(752, 303);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Catalogos";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // mtcmenuprincipal
            // 
            this.mtcmenuprincipal.Controls.Add(this.metroTile2);
            this.mtcmenuprincipal.Controls.Add(this.metroTile3);
            this.mtcmenuprincipal.Controls.Add(this.metroTile4);
            this.mtcmenuprincipal.HorizontalScrollbarBarColor = true;
            this.mtcmenuprincipal.HorizontalScrollbarHighlightOnWheel = false;
            this.mtcmenuprincipal.HorizontalScrollbarSize = 10;
            this.mtcmenuprincipal.Location = new System.Drawing.Point(4, 38);
            this.mtcmenuprincipal.Name = "mtcmenuprincipal";
            this.mtcmenuprincipal.Size = new System.Drawing.Size(752, 303);
            this.mtcmenuprincipal.TabIndex = 2;
            this.mtcmenuprincipal.Text = "Reportes";
            this.mtcmenuprincipal.VerticalScrollbarBarColor = true;
            this.mtcmenuprincipal.VerticalScrollbarHighlightOnWheel = false;
            this.mtcmenuprincipal.VerticalScrollbarSize = 10;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Enabled = false;
            this.metroTile1.Location = new System.Drawing.Point(14, 15);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(161, 150);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile1.TabIndex = 13;
            this.metroTile1.Text = "Administración";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = global::AsistenciaSalud.Properties.Resources.workers;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            // 
            // mltrabajadores
            // 
            this.mltrabajadores.ActiveControl = null;
            this.mltrabajadores.Enabled = false;
            this.mltrabajadores.Location = new System.Drawing.Point(417, 15);
            this.mltrabajadores.Name = "mltrabajadores";
            this.mltrabajadores.Size = new System.Drawing.Size(161, 150);
            this.mltrabajadores.Style = MetroFramework.MetroColorStyle.Silver;
            this.mltrabajadores.TabIndex = 12;
            this.mltrabajadores.Text = "&Empleados";
            this.mltrabajadores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mltrabajadores.TileImage = global::AsistenciaSalud.Properties.Resources.workers;
            this.mltrabajadores.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mltrabajadores.UseSelectable = true;
            this.mltrabajadores.UseTileImage = true;
            // 
            // mlusuarios
            // 
            this.mlusuarios.ActiveControl = null;
            this.mlusuarios.Enabled = false;
            this.mlusuarios.Location = new System.Drawing.Point(216, 15);
            this.mlusuarios.Name = "mlusuarios";
            this.mlusuarios.Size = new System.Drawing.Size(161, 150);
            this.mlusuarios.Style = MetroFramework.MetroColorStyle.Silver;
            this.mlusuarios.TabIndex = 11;
            this.mlusuarios.Text = "&Usuarios";
            this.mlusuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mlusuarios.TileImage = global::AsistenciaSalud.Properties.Resources.users;
            this.mlusuarios.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlusuarios.UseSelectable = true;
            this.mlusuarios.UseTileImage = true;
            // 
            // mlpermisos
            // 
            this.mlpermisos.ActiveControl = null;
            this.mlpermisos.Enabled = false;
            this.mlpermisos.Location = new System.Drawing.Point(14, 15);
            this.mlpermisos.Name = "mlpermisos";
            this.mlpermisos.Size = new System.Drawing.Size(161, 150);
            this.mlpermisos.Style = MetroFramework.MetroColorStyle.Silver;
            this.mlpermisos.TabIndex = 10;
            this.mlpermisos.Text = "&Permisos";
            this.mlpermisos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mlpermisos.TileImage = global::AsistenciaSalud.Properties.Resources.shield;
            this.mlpermisos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlpermisos.UseSelectable = true;
            this.mlpermisos.UseTileImage = true;
            this.mlpermisos.Click += new System.EventHandler(this.mlpermisos_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Enabled = false;
            this.metroTile2.Location = new System.Drawing.Point(417, 15);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(161, 150);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile2.TabIndex = 15;
            this.metroTile2.Text = "&Trimestral";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImage = global::AsistenciaSalud.Properties.Resources.calendar;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Enabled = false;
            this.metroTile3.Location = new System.Drawing.Point(216, 15);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(161, 150);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile3.TabIndex = 14;
            this.metroTile3.Text = "&Faltas";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile3.TileImage = global::AsistenciaSalud.Properties.Resources.assistace;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Enabled = false;
            this.metroTile4.Location = new System.Drawing.Point(14, 15);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(161, 150);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile4.TabIndex = 13;
            this.metroTile4.Text = "&Kardex";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile4.TileImage = global::AsistenciaSalud.Properties.Resources.kardex;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            // 
            // pbsalud
            // 
            this.pbsalud.Image = ((System.Drawing.Image)(resources.GetObject("pbsalud.Image")));
            this.pbsalud.Location = new System.Drawing.Point(613, 12);
            this.pbsalud.Name = "pbsalud";
            this.pbsalud.Size = new System.Drawing.Size(130, 51);
            this.pbsalud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsalud.TabIndex = 16;
            this.pbsalud.TabStop = false;
            // 
            // close_principal
            // 
            this.close_principal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_principal.Image = ((System.Drawing.Image)(resources.GetObject("close_principal.Image")));
            this.close_principal.Location = new System.Drawing.Point(761, 12);
            this.close_principal.Name = "close_principal";
            this.close_principal.Size = new System.Drawing.Size(30, 28);
            this.close_principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_principal.TabIndex = 15;
            this.close_principal.TabStop = false;
            this.close_principal.Click += new System.EventHandler(this.close_principal_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtcmenu);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pbsalud);
            this.Controls.Add(this.close_principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(814, 464);
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Sistema de asistencia";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mtcmenu.ResumeLayout(false);
            this.mtpempleados.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.mtcmenuprincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbsalud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_principal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox close_principal;
        private System.Windows.Forms.PictureBox pbsalud;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbpersonal;
        private MetroFramework.Controls.MetroTabControl mtcmenu;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage mtcmenuprincipal;
        private MetroFramework.Controls.MetroTile mlpermisos;
        private MetroFramework.Controls.MetroTile mlusuarios;
        private MetroFramework.Controls.MetroTile mltrabajadores;
        private MetroFramework.Controls.MetroTabPage mtpempleados;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private System.Windows.Forms.ToolStripLabel tslclue;
    }
}