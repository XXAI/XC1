namespace AsistenciaSalud
{
    partial class Permisos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Permisos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnmenu = new System.Windows.Forms.Panel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mlsalir = new MetroFramework.Controls.MetroTile();
            this.mlguardar = new MetroFramework.Controls.MetroTile();
            this.mlcancelar = new MetroFramework.Controls.MetroTile();
            this.mleliminar = new MetroFramework.Controls.MetroTile();
            this.mlmodificar = new MetroFramework.Controls.MetroTile();
            this.mlagregar = new MetroFramework.Controls.MetroTile();
            this.mpnbusqueda = new MetroFramework.Controls.MetroPanel();
            this.mgpermisos = new MetroFramework.Controls.MetroGrid();
            this.mpncuerpo = new MetroFramework.Controls.MetroPanel();
            this.gbpermisos = new System.Windows.Forms.GroupBox();
            this.mtxtgrupo = new MetroFramework.Controls.MetroTextBox();
            this.lbgrupo = new System.Windows.Forms.Label();
            this.mtlgenerar = new MetroFramework.Controls.MetroTile();
            this.mtxtdescripcion = new MetroFramework.Controls.MetroTextBox();
            this.lbdescripcion = new System.Windows.Forms.Label();
            this.lbpermiso = new System.Windows.Forms.Label();
            this.mtxtpermiso = new MetroFramework.Controls.MetroTextBox();
            this.pbsalud = new System.Windows.Forms.PictureBox();
            this.close_principal = new System.Windows.Forms.PictureBox();
            this.permissionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checadorMaestraDataSetPermisos = new AsistenciaSalud.ChecadorMaestraDataSetPermisos();
            this.permissionsTableAdapter = new AsistenciaSalud.ChecadorMaestraDataSetPermisosTableAdapters.permissionsTableAdapter();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuperDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnmenu.SuspendLayout();
            this.mpnbusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgpermisos)).BeginInit();
            this.mpncuerpo.SuspendLayout();
            this.gbpermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbsalud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checadorMaestraDataSetPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(20, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(778, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Location = new System.Drawing.Point(20, 575);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(778, 25);
            this.toolStrip2.TabIndex = 20;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.04171F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.95829F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.Controls.Add(this.pnmenu, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.mpnbusqueda, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mpncuerpo, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 85);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 490);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // pnmenu
            // 
            this.pnmenu.Controls.Add(this.metroTile2);
            this.pnmenu.Controls.Add(this.metroTile1);
            this.pnmenu.Controls.Add(this.mlsalir);
            this.pnmenu.Controls.Add(this.mlguardar);
            this.pnmenu.Controls.Add(this.mlcancelar);
            this.pnmenu.Controls.Add(this.mleliminar);
            this.pnmenu.Controls.Add(this.mlmodificar);
            this.pnmenu.Controls.Add(this.mlagregar);
            this.pnmenu.Location = new System.Drawing.Point(685, 3);
            this.pnmenu.Name = "pnmenu";
            this.pnmenu.Size = new System.Drawing.Size(85, 484);
            this.pnmenu.TabIndex = 35;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTile2.Location = new System.Drawing.Point(0, 455);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(85, 65);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile2.TabIndex = 44;
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseStyleColors = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTile1.Location = new System.Drawing.Point(0, 390);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(85, 65);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile1.TabIndex = 42;
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            // 
            // mlsalir
            // 
            this.mlsalir.ActiveControl = null;
            this.mlsalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.mlsalir.Location = new System.Drawing.Point(0, 325);
            this.mlsalir.Name = "mlsalir";
            this.mlsalir.Size = new System.Drawing.Size(85, 65);
            this.mlsalir.Style = MetroFramework.MetroColorStyle.Silver;
            this.mlsalir.TabIndex = 41;
            this.mlsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mlsalir.TileImage = global::AsistenciaSalud.Properties.Resources.salir;
            this.mlsalir.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlsalir.UseSelectable = true;
            this.mlsalir.UseStyleColors = true;
            this.mlsalir.UseTileImage = true;
            this.mlsalir.Click += new System.EventHandler(this.mlsalir_Click);
            // 
            // mlguardar
            // 
            this.mlguardar.ActiveControl = null;
            this.mlguardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.mlguardar.Location = new System.Drawing.Point(0, 260);
            this.mlguardar.Name = "mlguardar";
            this.mlguardar.Size = new System.Drawing.Size(85, 65);
            this.mlguardar.Style = MetroFramework.MetroColorStyle.Silver;
            this.mlguardar.TabIndex = 40;
            this.mlguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mlguardar.TileImage = global::AsistenciaSalud.Properties.Resources.guardar;
            this.mlguardar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlguardar.UseSelectable = true;
            this.mlguardar.UseStyleColors = true;
            this.mlguardar.UseTileImage = true;
            this.mlguardar.Click += new System.EventHandler(this.mlguardar_Click);
            // 
            // mlcancelar
            // 
            this.mlcancelar.ActiveControl = null;
            this.mlcancelar.Dock = System.Windows.Forms.DockStyle.Top;
            this.mlcancelar.Location = new System.Drawing.Point(0, 195);
            this.mlcancelar.Name = "mlcancelar";
            this.mlcancelar.Size = new System.Drawing.Size(85, 65);
            this.mlcancelar.Style = MetroFramework.MetroColorStyle.Silver;
            this.mlcancelar.TabIndex = 39;
            this.mlcancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mlcancelar.TileImage = global::AsistenciaSalud.Properties.Resources.cancelar;
            this.mlcancelar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlcancelar.UseSelectable = true;
            this.mlcancelar.UseStyleColors = true;
            this.mlcancelar.UseTileImage = true;
            this.mlcancelar.Click += new System.EventHandler(this.mlcancelar_Click);
            // 
            // mleliminar
            // 
            this.mleliminar.ActiveControl = null;
            this.mleliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.mleliminar.Location = new System.Drawing.Point(0, 130);
            this.mleliminar.Name = "mleliminar";
            this.mleliminar.Size = new System.Drawing.Size(85, 65);
            this.mleliminar.Style = MetroFramework.MetroColorStyle.Silver;
            this.mleliminar.TabIndex = 37;
            this.mleliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mleliminar.TileImage = global::AsistenciaSalud.Properties.Resources.eliminar;
            this.mleliminar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mleliminar.UseSelectable = true;
            this.mleliminar.UseStyleColors = true;
            this.mleliminar.UseTileImage = true;
            this.mleliminar.Click += new System.EventHandler(this.mleliminar_Click);
            // 
            // mlmodificar
            // 
            this.mlmodificar.ActiveControl = null;
            this.mlmodificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.mlmodificar.Location = new System.Drawing.Point(0, 65);
            this.mlmodificar.Name = "mlmodificar";
            this.mlmodificar.Size = new System.Drawing.Size(85, 65);
            this.mlmodificar.Style = MetroFramework.MetroColorStyle.Silver;
            this.mlmodificar.TabIndex = 36;
            this.mlmodificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mlmodificar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mlmodificar.TileImage = global::AsistenciaSalud.Properties.Resources.edit;
            this.mlmodificar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlmodificar.UseSelectable = true;
            this.mlmodificar.UseStyleColors = true;
            this.mlmodificar.UseTileImage = true;
            this.mlmodificar.Click += new System.EventHandler(this.mlmodificar_Click);
            // 
            // mlagregar
            // 
            this.mlagregar.AccessibleDescription = "";
            this.mlagregar.ActiveControl = null;
            this.mlagregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.mlagregar.Location = new System.Drawing.Point(0, 0);
            this.mlagregar.Name = "mlagregar";
            this.mlagregar.Size = new System.Drawing.Size(85, 65);
            this.mlagregar.Style = MetroFramework.MetroColorStyle.Silver;
            this.mlagregar.TabIndex = 35;
            this.mlagregar.Tag = "Agregar Permiso";
            this.mlagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mlagregar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mlagregar.TileImage = global::AsistenciaSalud.Properties.Resources.add;
            this.mlagregar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlagregar.UseSelectable = true;
            this.mlagregar.UseStyleColors = true;
            this.mlagregar.UseTileImage = true;
            this.mlagregar.Click += new System.EventHandler(this.mlagregar_Click);
            // 
            // mpnbusqueda
            // 
            this.mpnbusqueda.Controls.Add(this.mgpermisos);
            this.mpnbusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpnbusqueda.HorizontalScrollbarBarColor = true;
            this.mpnbusqueda.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnbusqueda.HorizontalScrollbarSize = 10;
            this.mpnbusqueda.Location = new System.Drawing.Point(3, 3);
            this.mpnbusqueda.Name = "mpnbusqueda";
            this.mpnbusqueda.Size = new System.Drawing.Size(281, 484);
            this.mpnbusqueda.TabIndex = 0;
            this.mpnbusqueda.VerticalScrollbarBarColor = true;
            this.mpnbusqueda.VerticalScrollbarHighlightOnWheel = false;
            this.mpnbusqueda.VerticalScrollbarSize = 10;
            this.mpnbusqueda.Paint += new System.Windows.Forms.PaintEventHandler(this.mpnbusqueda_Paint);
            // 
            // mgpermisos
            // 
            this.mgpermisos.AllowUserToAddRows = false;
            this.mgpermisos.AllowUserToDeleteRows = false;
            this.mgpermisos.AllowUserToResizeRows = false;
            this.mgpermisos.AutoGenerateColumns = false;
            this.mgpermisos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgpermisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgpermisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgpermisos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgpermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mgpermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgpermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.issuperDataGridViewCheckBoxColumn});
            this.mgpermisos.DataSource = this.permissionsBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgpermisos.DefaultCellStyle = dataGridViewCellStyle5;
            this.mgpermisos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mgpermisos.EnableHeadersVisualStyles = false;
            this.mgpermisos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgpermisos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgpermisos.Location = new System.Drawing.Point(0, 0);
            this.mgpermisos.Name = "mgpermisos";
            this.mgpermisos.ReadOnly = true;
            this.mgpermisos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgpermisos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mgpermisos.RowHeadersWidth = 51;
            this.mgpermisos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgpermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgpermisos.Size = new System.Drawing.Size(281, 484);
            this.mgpermisos.TabIndex = 2;
            // 
            // mpncuerpo
            // 
            this.mpncuerpo.Controls.Add(this.gbpermisos);
            this.mpncuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpncuerpo.HorizontalScrollbarBarColor = true;
            this.mpncuerpo.HorizontalScrollbarHighlightOnWheel = false;
            this.mpncuerpo.HorizontalScrollbarSize = 10;
            this.mpncuerpo.Location = new System.Drawing.Point(290, 3);
            this.mpncuerpo.Name = "mpncuerpo";
            this.mpncuerpo.Size = new System.Drawing.Size(389, 484);
            this.mpncuerpo.TabIndex = 1;
            this.mpncuerpo.VerticalScrollbarBarColor = true;
            this.mpncuerpo.VerticalScrollbarHighlightOnWheel = false;
            this.mpncuerpo.VerticalScrollbarSize = 10;
            // 
            // gbpermisos
            // 
            this.gbpermisos.Controls.Add(this.mtxtgrupo);
            this.gbpermisos.Controls.Add(this.lbgrupo);
            this.gbpermisos.Controls.Add(this.mtlgenerar);
            this.gbpermisos.Controls.Add(this.mtxtdescripcion);
            this.gbpermisos.Controls.Add(this.lbdescripcion);
            this.gbpermisos.Controls.Add(this.lbpermiso);
            this.gbpermisos.Controls.Add(this.mtxtpermiso);
            this.gbpermisos.Location = new System.Drawing.Point(2, 2);
            this.gbpermisos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbpermisos.Name = "gbpermisos";
            this.gbpermisos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbpermisos.Size = new System.Drawing.Size(386, 193);
            this.gbpermisos.TabIndex = 2;
            this.gbpermisos.TabStop = false;
            this.gbpermisos.Text = "Permisos";
            // 
            // mtxtgrupo
            // 
            this.mtxtgrupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.permissionsBindingSource, "grupo", true));
            this.mtxtgrupo.Lines = new string[0];
            this.mtxtgrupo.Location = new System.Drawing.Point(118, 128);
            this.mtxtgrupo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxtgrupo.MaxLength = 32767;
            this.mtxtgrupo.Name = "mtxtgrupo";
            this.mtxtgrupo.PasswordChar = '\0';
            this.mtxtgrupo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtgrupo.SelectedText = "";
            this.mtxtgrupo.Size = new System.Drawing.Size(255, 23);
            this.mtxtgrupo.TabIndex = 7;
            this.mtxtgrupo.UseSelectable = true;
            this.mtxtgrupo.UseStyleColors = true;
            // 
            // lbgrupo
            // 
            this.lbgrupo.AutoSize = true;
            this.lbgrupo.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgrupo.Location = new System.Drawing.Point(52, 132);
            this.lbgrupo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbgrupo.Name = "lbgrupo";
            this.lbgrupo.Size = new System.Drawing.Size(47, 18);
            this.lbgrupo.TabIndex = 6;
            this.lbgrupo.Text = "Grupo";
            // 
            // mtlgenerar
            // 
            this.mtlgenerar.ActiveControl = null;
            this.mtlgenerar.Location = new System.Drawing.Point(317, 17);
            this.mtlgenerar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtlgenerar.Name = "mtlgenerar";
            this.mtlgenerar.Size = new System.Drawing.Size(64, 58);
            this.mtlgenerar.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtlgenerar.TabIndex = 5;
            this.mtlgenerar.Text = "&Generar";
            this.mtlgenerar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtlgenerar.UseSelectable = true;
            this.mtlgenerar.Click += new System.EventHandler(this.mtlgenerar_Click_1);
            // 
            // mtxtdescripcion
            // 
            this.mtxtdescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.permissionsBindingSource, "descripcion", true));
            this.mtxtdescripcion.Lines = new string[0];
            this.mtxtdescripcion.Location = new System.Drawing.Point(118, 80);
            this.mtxtdescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxtdescripcion.MaxLength = 32767;
            this.mtxtdescripcion.Name = "mtxtdescripcion";
            this.mtxtdescripcion.PasswordChar = '\0';
            this.mtxtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtdescripcion.SelectedText = "";
            this.mtxtdescripcion.Size = new System.Drawing.Size(255, 23);
            this.mtxtdescripcion.TabIndex = 4;
            this.mtxtdescripcion.UseSelectable = true;
            this.mtxtdescripcion.UseStyleColors = true;
            // 
            // lbdescripcion
            // 
            this.lbdescripcion.AutoSize = true;
            this.lbdescripcion.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdescripcion.Location = new System.Drawing.Point(20, 84);
            this.lbdescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdescripcion.Name = "lbdescripcion";
            this.lbdescripcion.Size = new System.Drawing.Size(86, 18);
            this.lbdescripcion.TabIndex = 3;
            this.lbdescripcion.Text = "descripción*";
            // 
            // lbpermiso
            // 
            this.lbpermiso.AutoSize = true;
            this.lbpermiso.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpermiso.Location = new System.Drawing.Point(42, 32);
            this.lbpermiso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbpermiso.Name = "lbpermiso";
            this.lbpermiso.Size = new System.Drawing.Size(67, 18);
            this.lbpermiso.TabIndex = 2;
            this.lbpermiso.Text = "Permiso*";
            // 
            // mtxtpermiso
            // 
            this.mtxtpermiso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.permissionsBindingSource, "id", true));
            this.mtxtpermiso.Enabled = false;
            this.mtxtpermiso.Lines = new string[0];
            this.mtxtpermiso.Location = new System.Drawing.Point(118, 32);
            this.mtxtpermiso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxtpermiso.MaxLength = 32767;
            this.mtxtpermiso.Name = "mtxtpermiso";
            this.mtxtpermiso.PasswordChar = '\0';
            this.mtxtpermiso.ReadOnly = true;
            this.mtxtpermiso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtpermiso.SelectedText = "";
            this.mtxtpermiso.Size = new System.Drawing.Size(195, 23);
            this.mtxtpermiso.TabIndex = 1;
            this.mtxtpermiso.UseSelectable = true;
            this.mtxtpermiso.UseStyleColors = true;
            // 
            // pbsalud
            // 
            this.pbsalud.Image = ((System.Drawing.Image)(resources.GetObject("pbsalud.Image")));
            this.pbsalud.Location = new System.Drawing.Point(613, 12);
            this.pbsalud.Name = "pbsalud";
            this.pbsalud.Size = new System.Drawing.Size(130, 45);
            this.pbsalud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsalud.TabIndex = 18;
            this.pbsalud.TabStop = false;
            // 
            // close_principal
            // 
            this.close_principal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_principal.Image = ((System.Drawing.Image)(resources.GetObject("close_principal.Image")));
            this.close_principal.Location = new System.Drawing.Point(786, 12);
            this.close_principal.Name = "close_principal";
            this.close_principal.Size = new System.Drawing.Size(30, 28);
            this.close_principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_principal.TabIndex = 17;
            this.close_principal.TabStop = false;
            this.close_principal.Click += new System.EventHandler(this.close_principal_Click);
            // 
            // permissionsBindingSource
            // 
            this.permissionsBindingSource.DataMember = "permissions";
            this.permissionsBindingSource.DataSource = this.checadorMaestraDataSetPermisos;
            // 
            // checadorMaestraDataSetPermisos
            // 
            this.checadorMaestraDataSetPermisos.DataSetName = "ChecadorMaestraDataSetPermisos";
            this.checadorMaestraDataSetPermisos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // permissionsTableAdapter
            // 
            this.permissionsTableAdapter.ClearBeforeFill = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "id";
            this.Column2.HeaderText = "Permiso";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "descripcion";
            this.Column1.HeaderText = "Descripción";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // issuperDataGridViewCheckBoxColumn
            // 
            this.issuperDataGridViewCheckBoxColumn.DataPropertyName = "is_super";
            this.issuperDataGridViewCheckBoxColumn.HeaderText = "is_super";
            this.issuperDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.issuperDataGridViewCheckBoxColumn.Name = "issuperDataGridViewCheckBoxColumn";
            this.issuperDataGridViewCheckBoxColumn.ReadOnly = true;
            this.issuperDataGridViewCheckBoxColumn.Visible = false;
            this.issuperDataGridViewCheckBoxColumn.Width = 125;
            // 
            // Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 620);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pbsalud);
            this.Controls.Add(this.close_principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Permisos";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Catálogo de Permisos";
            this.Load += new System.EventHandler(this.Permisos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnmenu.ResumeLayout(false);
            this.mpnbusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgpermisos)).EndInit();
            this.mpncuerpo.ResumeLayout(false);
            this.gbpermisos.ResumeLayout(false);
            this.gbpermisos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbsalud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checadorMaestraDataSetPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbsalud;
        private System.Windows.Forms.PictureBox close_principal;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel mpnbusqueda;
        private MetroFramework.Controls.MetroPanel mpncuerpo;
        private MetroFramework.Controls.MetroGrid mgpermisos;
        private ChecadorMaestraDataSetPermisos checadorMaestraDataSetPermisos;
        private System.Windows.Forms.BindingSource permissionsBindingSource;
        private ChecadorMaestraDataSetPermisosTableAdapters.permissionsTableAdapter permissionsTableAdapter;
        private System.Windows.Forms.Panel pnmenu;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile mlsalir;
        private MetroFramework.Controls.MetroTile mlguardar;
        private MetroFramework.Controls.MetroTile mlcancelar;
        private MetroFramework.Controls.MetroTile mleliminar;
        private MetroFramework.Controls.MetroTile mlmodificar;
        private MetroFramework.Controls.MetroTile mlagregar;
        private System.Windows.Forms.GroupBox gbpermisos;
        private MetroFramework.Controls.MetroTextBox mtxtpermiso;
        private System.Windows.Forms.Label lbpermiso;
        private System.Windows.Forms.Label lbdescripcion;
        private MetroFramework.Controls.MetroTextBox mtxtdescripcion;
        private MetroFramework.Controls.MetroTile mtlgenerar;
        private System.Windows.Forms.Label lbgrupo;
        private MetroFramework.Controls.MetroTextBox mtxtgrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn issuperDataGridViewCheckBoxColumn;
    }
}