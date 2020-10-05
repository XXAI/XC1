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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Permisos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mpnbusqueda = new MetroFramework.Controls.MetroPanel();
            this.mpncuerpo = new MetroFramework.Controls.MetroPanel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.pnmenu = new System.Windows.Forms.Panel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mlsalir = new MetroFramework.Controls.MetroTile();
            this.mlguardar = new MetroFramework.Controls.MetroTile();
            this.mlcancelar = new MetroFramework.Controls.MetroTile();
            this.mlseleccionar = new MetroFramework.Controls.MetroTile();
            this.mleliminar = new MetroFramework.Controls.MetroTile();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuperDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createdatDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.permissionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checadorMaestraDataSetPermisos = new AsistenciaSalud.ChecadorMaestraDataSetPermisos();
            this.permissionsTableAdapter = new AsistenciaSalud.ChecadorMaestraDataSetPermisosTableAdapters.permissionsTableAdapter();
            this.mlmodificar = new MetroFramework.Controls.MetroTile();
            this.mlagregar = new MetroFramework.Controls.MetroTile();
            this.pbsalud = new System.Windows.Forms.PictureBox();
            this.close_principal = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.mpnbusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.pnmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checadorMaestraDataSetPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsalud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_principal)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(20, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(778, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Location = new System.Drawing.Point(20, 575);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(778, 25);
            this.toolStrip2.TabIndex = 20;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.0245F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.97549F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
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
            // mpnbusqueda
            // 
            this.mpnbusqueda.Controls.Add(this.metroGrid1);
            this.mpnbusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpnbusqueda.HorizontalScrollbarBarColor = true;
            this.mpnbusqueda.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnbusqueda.HorizontalScrollbarSize = 10;
            this.mpnbusqueda.Location = new System.Drawing.Point(3, 3);
            this.mpnbusqueda.Name = "mpnbusqueda";
            this.mpnbusqueda.Size = new System.Drawing.Size(186, 484);
            this.mpnbusqueda.TabIndex = 0;
            this.mpnbusqueda.VerticalScrollbarBarColor = true;
            this.mpnbusqueda.VerticalScrollbarHighlightOnWheel = false;
            this.mpnbusqueda.VerticalScrollbarSize = 10;
            this.mpnbusqueda.Paint += new System.Windows.Forms.PaintEventHandler(this.mpnbusqueda_Paint);
            // 
            // mpncuerpo
            // 
            this.mpncuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpncuerpo.HorizontalScrollbarBarColor = true;
            this.mpncuerpo.HorizontalScrollbarHighlightOnWheel = false;
            this.mpncuerpo.HorizontalScrollbarSize = 10;
            this.mpncuerpo.Location = new System.Drawing.Point(195, 3);
            this.mpncuerpo.Name = "mpncuerpo";
            this.mpncuerpo.Size = new System.Drawing.Size(489, 484);
            this.mpncuerpo.TabIndex = 1;
            this.mpncuerpo.VerticalScrollbarBarColor = true;
            this.mpncuerpo.VerticalScrollbarHighlightOnWheel = false;
            this.mpncuerpo.VerticalScrollbarSize = 10;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn,
            this.issuperDataGridViewCheckBoxColumn,
            this.createdatDataGridViewImageColumn});
            this.metroGrid1.DataSource = this.permissionsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 0);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(186, 484);
            this.metroGrid1.TabIndex = 2;
            // 
            // pnmenu
            // 
            this.pnmenu.Controls.Add(this.metroTile2);
            this.pnmenu.Controls.Add(this.metroTile1);
            this.pnmenu.Controls.Add(this.mlsalir);
            this.pnmenu.Controls.Add(this.mlguardar);
            this.pnmenu.Controls.Add(this.mlcancelar);
            this.pnmenu.Controls.Add(this.mlseleccionar);
            this.pnmenu.Controls.Add(this.mleliminar);
            this.pnmenu.Controls.Add(this.mlmodificar);
            this.pnmenu.Controls.Add(this.mlagregar);
            this.pnmenu.Location = new System.Drawing.Point(690, 3);
            this.pnmenu.Name = "pnmenu";
            this.pnmenu.Size = new System.Drawing.Size(85, 484);
            this.pnmenu.TabIndex = 35;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTile2.Location = new System.Drawing.Point(0, 520);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(85, 65);
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
            this.metroTile1.Location = new System.Drawing.Point(0, 455);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(85, 65);
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
            this.mlsalir.Location = new System.Drawing.Point(0, 390);
            this.mlsalir.Name = "mlsalir";
            this.mlsalir.Size = new System.Drawing.Size(85, 65);
            this.mlsalir.TabIndex = 41;
            this.mlsalir.Text = "Salir";
            this.mlsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mlsalir.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlsalir.UseSelectable = true;
            this.mlsalir.UseStyleColors = true;
            this.mlsalir.UseTileImage = true;
            // 
            // mlguardar
            // 
            this.mlguardar.ActiveControl = null;
            this.mlguardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.mlguardar.Location = new System.Drawing.Point(0, 325);
            this.mlguardar.Name = "mlguardar";
            this.mlguardar.Size = new System.Drawing.Size(85, 65);
            this.mlguardar.TabIndex = 40;
            this.mlguardar.Text = "Guardar";
            this.mlguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mlguardar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlguardar.UseSelectable = true;
            this.mlguardar.UseStyleColors = true;
            this.mlguardar.UseTileImage = true;
            // 
            // mlcancelar
            // 
            this.mlcancelar.ActiveControl = null;
            this.mlcancelar.Dock = System.Windows.Forms.DockStyle.Top;
            this.mlcancelar.Location = new System.Drawing.Point(0, 260);
            this.mlcancelar.Name = "mlcancelar";
            this.mlcancelar.Size = new System.Drawing.Size(85, 65);
            this.mlcancelar.TabIndex = 39;
            this.mlcancelar.Text = "Cancelar";
            this.mlcancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mlcancelar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlcancelar.UseSelectable = true;
            this.mlcancelar.UseStyleColors = true;
            this.mlcancelar.UseTileImage = true;
            // 
            // mlseleccionar
            // 
            this.mlseleccionar.ActiveControl = null;
            this.mlseleccionar.Dock = System.Windows.Forms.DockStyle.Top;
            this.mlseleccionar.Location = new System.Drawing.Point(0, 195);
            this.mlseleccionar.Name = "mlseleccionar";
            this.mlseleccionar.Size = new System.Drawing.Size(85, 65);
            this.mlseleccionar.TabIndex = 38;
            this.mlseleccionar.Text = "Seleccionar";
            this.mlseleccionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mlseleccionar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlseleccionar.UseSelectable = true;
            this.mlseleccionar.UseStyleColors = true;
            this.mlseleccionar.UseTileImage = true;
            // 
            // mleliminar
            // 
            this.mleliminar.ActiveControl = null;
            this.mleliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.mleliminar.Location = new System.Drawing.Point(0, 130);
            this.mleliminar.Name = "mleliminar";
            this.mleliminar.Size = new System.Drawing.Size(85, 65);
            this.mleliminar.TabIndex = 37;
            this.mleliminar.Text = "Eliminar";
            this.mleliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mleliminar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mleliminar.UseSelectable = true;
            this.mleliminar.UseStyleColors = true;
            this.mleliminar.UseTileImage = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // issuperDataGridViewCheckBoxColumn
            // 
            this.issuperDataGridViewCheckBoxColumn.DataPropertyName = "is_super";
            this.issuperDataGridViewCheckBoxColumn.HeaderText = "is_super";
            this.issuperDataGridViewCheckBoxColumn.Name = "issuperDataGridViewCheckBoxColumn";
            this.issuperDataGridViewCheckBoxColumn.ReadOnly = true;
            this.issuperDataGridViewCheckBoxColumn.Visible = false;
            // 
            // createdatDataGridViewImageColumn
            // 
            this.createdatDataGridViewImageColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewImageColumn.HeaderText = "created_at";
            this.createdatDataGridViewImageColumn.Name = "createdatDataGridViewImageColumn";
            this.createdatDataGridViewImageColumn.ReadOnly = true;
            this.createdatDataGridViewImageColumn.Visible = false;
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
            this.mlagregar.Tag = "Agregar Cliente";
            this.mlagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mlagregar.TileImage = global::AsistenciaSalud.Properties.Resources.add;
            this.mlagregar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlagregar.UseSelectable = true;
            this.mlagregar.UseStyleColors = true;
            this.mlagregar.UseTileImage = true;
            // 
            // pbsalud
            // 
            this.pbsalud.Image = ((System.Drawing.Image)(resources.GetObject("pbsalud.Image")));
            this.pbsalud.Location = new System.Drawing.Point(613, 12);
            this.pbsalud.Name = "pbsalud";
            this.pbsalud.Size = new System.Drawing.Size(130, 51);
            this.pbsalud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsalud.TabIndex = 18;
            this.pbsalud.TabStop = false;
            // 
            // close_principal
            // 
            this.close_principal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_principal.Image = ((System.Drawing.Image)(resources.GetObject("close_principal.Image")));
            this.close_principal.Location = new System.Drawing.Point(783, 12);
            this.close_principal.Name = "close_principal";
            this.close_principal.Size = new System.Drawing.Size(30, 28);
            this.close_principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_principal.TabIndex = 17;
            this.close_principal.TabStop = false;
            this.close_principal.Click += new System.EventHandler(this.close_principal_Click);
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
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Catálogo de Permisos";
            this.Load += new System.EventHandler(this.Permisos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.mpnbusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.pnmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.permissionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checadorMaestraDataSetPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsalud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_principal)).EndInit();
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
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private ChecadorMaestraDataSetPermisos checadorMaestraDataSetPermisos;
        private System.Windows.Forms.BindingSource permissionsBindingSource;
        private ChecadorMaestraDataSetPermisosTableAdapters.permissionsTableAdapter permissionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn issuperDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn createdatDataGridViewImageColumn;
        private System.Windows.Forms.Panel pnmenu;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile mlsalir;
        private MetroFramework.Controls.MetroTile mlguardar;
        private MetroFramework.Controls.MetroTile mlcancelar;
        private MetroFramework.Controls.MetroTile mlseleccionar;
        private MetroFramework.Controls.MetroTile mleliminar;
        private MetroFramework.Controls.MetroTile mlmodificar;
        private MetroFramework.Controls.MetroTile mlagregar;
    }
}