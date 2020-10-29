namespace AsistenciaSalud
{
    partial class SeleccionarClue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarClue));
            this.pbsalud = new System.Windows.Forms.PictureBox();
            this.close_principal = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbsalud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_principal)).BeginInit();
            this.SuspendLayout();
            // 
            // pbsalud
            // 
            this.pbsalud.Image = ((System.Drawing.Image)(resources.GetObject("pbsalud.Image")));
            this.pbsalud.Location = new System.Drawing.Point(612, 11);
            this.pbsalud.Name = "pbsalud";
            this.pbsalud.Size = new System.Drawing.Size(130, 45);
            this.pbsalud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsalud.TabIndex = 24;
            this.pbsalud.TabStop = false;
            // 
            // close_principal
            // 
            this.close_principal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_principal.Image = ((System.Drawing.Image)(resources.GetObject("close_principal.Image")));
            this.close_principal.Location = new System.Drawing.Point(785, 11);
            this.close_principal.Name = "close_principal";
            this.close_principal.Size = new System.Drawing.Size(30, 28);
            this.close_principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_principal.TabIndex = 23;
            this.close_principal.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.7892F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.2108F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 203);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // SeleccionarClue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 283);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pbsalud);
            this.Controls.Add(this.close_principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeleccionarClue";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Seleccionar Clue";
            this.Load += new System.EventHandler(this.SeleccionarClue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbsalud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_principal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbsalud;
        private System.Windows.Forms.PictureBox close_principal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}