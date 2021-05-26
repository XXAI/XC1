using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistenciaSalud.Forms
{
    public partial class SeleccionarClue : MetroFramework.Forms.MetroForm
    {
        public Clases.Usuario Usuario;
        public SeleccionarClue()
        {
            InitializeComponent();
        }

        public void CargarClues(Clases.Usuario _User)
        {
            this.Usuario = _User;
            unidadClues.DataSource = this.Usuario.Unidades;
            unidadClues.DisplayMember = "unidad";
            unidadClues.ValueMember = "id";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(this.Usuario.Unidades.Count > 0)
            {
                this.Usuario.unidadSeleccionada = unidadClues.SelectedIndex;
                Thread principal = new Thread(run);
                this.Close();
                principal.SetApartmentState(System.Threading.ApartmentState.STA);
                principal.Start();
            }
            else
            {
                MessageBox.Show(this, "No se tiene unidades asignadas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void run()
        {
            Principal pantalla = new Principal(this.Usuario);
            pantalla.ShowDialog();
        }
    }
}
