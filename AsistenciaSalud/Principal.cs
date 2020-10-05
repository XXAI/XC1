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
using MetroFramework.Forms;
namespace AsistenciaSalud
{
    public partial class Principal : MetroForm
    {
        String nombre, id,clue;
        bool  isroot;
        private Form _FormularioSecundario;
        public Principal(String name, String clues, String ids, string issuper)
        {
            InitializeComponent();
            nombre = name;
            clue = clues;
            isroot = Convert.ToBoolean(issuper);
            id = ids;

        }

        private void run()
        {
            _FormularioSecundario.ShowDialog();
        }

        private void mlpermisos_Click(object sender, EventArgs e)
        {
            _FormularioSecundario = new Permisos();
            Thread principal = new Thread(run);
            this.Close();
            principal.SetApartmentState(System.Threading.ApartmentState.STA);
            principal.Start();

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            tslbpersonal.Text = "Bienvenido " + nombre;
            tslclue.Text = "Esta conectado a la CLUE " + clue;

            mlpermisos.Enabled = true;


        }

        private void close_principal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
