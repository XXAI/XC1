using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace AsistenciaSalud
{
    public partial class Permisos : MetroForm
    {
        public Permisos()
        {
            InitializeComponent();
        }

        private void Permisos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'checadorMaestraDataSetPermisos.permissions' Puede moverla o quitarla según sea necesario.
            this.permissionsTableAdapter.Fill(this.checadorMaestraDataSetPermisos.permissions);

        }

        private void mpnbusqueda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_principal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
