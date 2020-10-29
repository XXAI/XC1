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
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.mtcmenuprincipal = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.mladministracion = new MetroFramework.Controls.MetroTile();
            this.mlconexiones = new MetroFramework.Controls.MetroTile();
            this.mltrabajadores = new MetroFramework.Controls.MetroTile();
            this.mlusuarios = new MetroFramework.Controls.MetroTile();
            this.mlpermisos = new MetroFramework.Controls.MetroTile();
            this.mltrimestral = new MetroFramework.Controls.MetroTile();
            this.mlfaltas = new MetroFramework.Controls.MetroTile();
            this.mlkardex = new MetroFramework.Controls.MetroTile();
            this.mllogs = new MetroFramework.Controls.MetroTile();
            this.mladministrarchecadores = new MetroFramework.Controls.MetroTile();
            this.pbsalud = new System.Windows.Forms.PictureBox();
            this.close_principal = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.mtcmenu.SuspendLayout();
            this.mtpempleados.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.mtcmenuprincipal.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(799, 25);
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
            this.mtcmenu.SelectedIndex = 3;
            this.mtcmenu.Size = new System.Drawing.Size(799, 345);
            this.mtcmenu.TabIndex = 18;
            this.mtcmenu.UseSelectable = true;
            // 
            // mtpempleados
            // 
            this.mtpempleados.Controls.Add(this.mladministracion);
            this.mtpempleados.HorizontalScrollbarBarColor = true;
            this.mtpempleados.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpempleados.HorizontalScrollbarSize = 10;
            this.mtpempleados.Location = new System.Drawing.Point(4, 38);
            this.mtpempleados.Name = "mtpempleados";
            this.mtpempleados.Size = new System.Drawing.Size(791, 303);
            this.mtpempleados.TabIndex = 3;
            this.mtpempleados.Text = "Empleados";
            this.mtpempleados.VerticalScrollbarBarColor = true;
            this.mtpempleados.VerticalScrollbarHighlightOnWheel = false;
            this.mtpempleados.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.mlconexiones);
            this.metroTabPage2.Controls.Add(this.mltrabajadores);
            this.metroTabPage2.Controls.Add(this.mlusuarios);
            this.metroTabPage2.Controls.Add(this.mlpermisos);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(791, 303);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Catalogos";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // mtcmenuprincipal
            // 
            this.mtcmenuprincipal.Controls.Add(this.mltrimestral);
            this.mtcmenuprincipal.Controls.Add(this.mlfaltas);
            this.mtcmenuprincipal.Controls.Add(this.mlkardex);
            this.mtcmenuprincipal.HorizontalScrollbarBarColor = true;
            this.mtcmenuprincipal.HorizontalScrollbarHighlightOnWheel = false;
            this.mtcmenuprincipal.HorizontalScrollbarSize = 10;
            this.mtcmenuprincipal.Location = new System.Drawing.Point(4, 38);
            this.mtcmenuprincipal.Name = "mtcmenuprincipal";
            this.mtcmenuprincipal.Size = new System.Drawing.Size(791, 303);
            this.mtcmenuprincipal.TabIndex = 2;
            this.mtcmenuprincipal.Text = "Reportes";
            this.mtcmenuprincipal.VerticalScrollbarBarColor = true;
            this.mtcmenuprincipal.VerticalScrollbarHighlightOnWheel = false;
            this.mtcmenuprincipal.VerticalScrollbarSize = 10;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.mllogs);
            this.metroTabPage1.Controls.Add(this.mladministrarchecadores);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(791, 303);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Dispositivos";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // mladministracion
            // 
            this.mladministracion.ActiveControl = null;
            this.mladministracion.Enabled = false;
            this.mladministracion.Location = new System.Drawing.Point(14, 15);
            this.mladministracion.Name = "mladministracion";
            this.mladministracion.Size = new System.Drawing.Size(161, 150);
            this.mladministracion.Style = MetroFramework.MetroColorStyle.Silver;
            this.mladministracion.TabIndex = 13;
            this.mladministracion.Text = "Administración";
            this.mladministracion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mladministracion.TileImage = global::AsistenciaSalud.Properties.Resources.workers;
            this.mladministracion.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mladministracion.UseSelectable = true;
            this.mladministracion.UseTileImage = true;
            this.mladministracion.Visible = false;
            // 
            // mlconexiones
            // 
            this.mlconexiones.ActiveControl = null;
            this.mlconexiones.Enabled = false;
            this.mlconexiones.Location = new System.Drawing.Point(627, 15);
            this.mlconexiones.Name = "mlconexiones";
            this.mlconexiones.Size = new System.Drawing.Size(161, 150);
            this.mlconexiones.Style = MetroFramework.MetroColorStyle.Silver;
            this.mlconexiones.TabIndex = 13;
            this.mlconexiones.Text = "&Conexiones";
            this.mlconexiones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mlconexiones.TileImage = global::AsistenciaSalud.Properties.Resources.clues;
            this.mlconexiones.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlconexiones.UseSelectable = true;
            this.mlconexiones.UseTileImage = true;
            this.mlconexiones.Visible = false;
            this.mlconexiones.Click += new System.EventHandler(this.mlconexiones_Click);
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
            this.mltrabajadores.Visible = false;
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
            this.mlusuarios.Visible = false;
            this.mlusuarios.Click += new System.EventHandler(this.mlusuarios_Click);
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
            this.mlpermisos.Visible = false;
            this.mlpermisos.Click += new System.EventHandler(this.mlpermisos_Click);
            // 
            // mltrimestral
            // 
            this.mltrimestral.ActiveControl = null;
            this.mltrimestral.Enabled = false;
            this.mltrimestral.Location = new System.Drawing.Point(417, 15);
            this.mltrimestral.Name = "mltrimestral";
            this.mltrimestral.Size = new System.Drawing.Size(161, 150);
            this.mltrimestral.Style = MetroFramework.MetroColorStyle.Silver;
            this.mltrimestral.TabIndex = 15;
            this.mltrimestral.Text = "&Trimestral";
            this.mltrimestral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mltrimestral.TileImage = global::AsistenciaSalud.Properties.Resources.calendar;
            this.mltrimestral.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mltrimestral.UseSelectable = true;
            this.mltrimestral.UseTileImage = true;
            this.mltrimestral.Visible = false;
            // 
            // mlfaltas
            // 
            this.mlfaltas.ActiveControl = null;
            this.mlfaltas.Enabled = false;
            this.mlfaltas.Location = new System.Drawing.Point(216, 15);
            this.mlfaltas.Name = "mlfaltas";
            this.mlfaltas.Size = new System.Drawing.Size(161, 150);
            this.mlfaltas.Style = MetroFramework.MetroColorStyle.Silver;
            this.mlfaltas.TabIndex = 14;
            this.mlfaltas.Text = "&Faltas";
            this.mlfaltas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mlfaltas.TileImage = global::AsistenciaSalud.Properties.Resources.assistace;
            this.mlfaltas.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlfaltas.UseSelectable = true;
            this.mlfaltas.UseTileImage = true;
            this.mlfaltas.Visible = false;
            // 
            // mlkardex
            // 
            this.mlkardex.ActiveControl = null;
            this.mlkardex.Enabled = false;
            this.mlkardex.Location = new System.Drawing.Point(14, 15);
            this.mlkardex.Name = "mlkardex";
            this.mlkardex.Size = new System.Drawing.Size(161, 150);
            this.mlkardex.Style = MetroFramework.MetroColorStyle.Silver;
            this.mlkardex.TabIndex = 13;
            this.mlkardex.Text = "&Kardex";
            this.mlkardex.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mlkardex.TileImage = global::AsistenciaSalud.Properties.Resources.kardex;
            this.mlkardex.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlkardex.UseSelectable = true;
            this.mlkardex.UseTileImage = true;
            this.mlkardex.Visible = false;
            // 
            // mllogs
            // 
            this.mllogs.ActiveControl = null;
            this.mllogs.Enabled = false;
            this.mllogs.Location = new System.Drawing.Point(216, 15);
            this.mllogs.Name = "mllogs";
            this.mllogs.Size = new System.Drawing.Size(161, 150);
            this.mllogs.Style = MetroFramework.MetroColorStyle.Silver;
            this.mllogs.TabIndex = 16;
            this.mllogs.Text = "Registros";
            this.mllogs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mllogs.TileImage = global::AsistenciaSalud.Properties.Resources.registros;
            this.mllogs.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mllogs.UseSelectable = true;
            this.mllogs.UseTileImage = true;
            this.mllogs.Visible = false;
            // 
            // mladministrarchecadores
            // 
            this.mladministrarchecadores.ActiveControl = null;
            this.mladministrarchecadores.Enabled = false;
            this.mladministrarchecadores.Location = new System.Drawing.Point(14, 15);
            this.mladministrarchecadores.Name = "mladministrarchecadores";
            this.mladministrarchecadores.Size = new System.Drawing.Size(161, 150);
            this.mladministrarchecadores.Style = MetroFramework.MetroColorStyle.Silver;
            this.mladministrarchecadores.TabIndex = 15;
            this.mladministrarchecadores.Text = "&Administrar Relojes";
            this.mladministrarchecadores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mladministrarchecadores.TileImage = global::AsistenciaSalud.Properties.Resources.biometrico112;
            this.mladministrarchecadores.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mladministrarchecadores.UseSelectable = true;
            this.mladministrarchecadores.UseTileImage = true;
            this.mladministrarchecadores.Visible = false;
            this.mladministrarchecadores.Click += new System.EventHandler(this.mladministrarchecadores_Click);
            // 
            // pbsalud
            // 
            this.pbsalud.Image = ((System.Drawing.Image)(resources.GetObject("pbsalud.Image")));
            this.pbsalud.Location = new System.Drawing.Point(613, 12);
            this.pbsalud.Name = "pbsalud";
            this.pbsalud.Size = new System.Drawing.Size(130, 53);
            this.pbsalud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsalud.TabIndex = 16;
            this.pbsalud.TabStop = false;
            // 
            // close_principal
            // 
            this.close_principal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_principal.Image = ((System.Drawing.Image)(resources.GetObject("close_principal.Image")));
            this.close_principal.Location = new System.Drawing.Point(805, 8);
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
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.mtcmenu);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pbsalud);
            this.Controls.Add(this.close_principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(853, 464);
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
            this.metroTabPage1.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroTile mladministracion;
        private MetroFramework.Controls.MetroTile mltrimestral;
        private MetroFramework.Controls.MetroTile mlfaltas;
        private MetroFramework.Controls.MetroTile mlkardex;
        private System.Windows.Forms.ToolStripLabel tslclue;
        private MetroFramework.Controls.MetroTile mlconexiones;
        private MetroFramework.Controls.MetroTile mllogs;
        private MetroFramework.Controls.MetroTile mladministrarchecadores;
    }
}