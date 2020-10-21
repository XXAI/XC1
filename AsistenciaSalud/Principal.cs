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
            Cursor.Current = Cursors.WaitCursor;
            _FormularioSecundario = new Permisos();
            Thread principal = new Thread(run);
            //this.Close();
            principal.SetApartmentState(System.Threading.ApartmentState.STA);
            principal.Start();

        }

        private void mlusuarios_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _FormularioSecundario = new Usuarios();
            //Thread principal = new Thread(run);
            ////this.Close();
            //principal.SetApartmentState(System.Threading.ApartmentState.STA);
            //principal.Start();
            _FormularioSecundario.ShowDialog();
        }

        private void mlconexiones_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            _FormularioSecundario = new Clues();
            Thread principal = new Thread(run);
            //this.Close();
            principal.SetApartmentState(System.Threading.ApartmentState.STA);
            principal.Start();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            tslbpersonal.Text = "Bienvenido " + nombre;
            tslclue.Text = "Esta conectado a la CLUE " + clue;

            mlpermisos.Enabled = true;

            if (isroot)
            {
                mlpermisos.Visible = true;
            }

            else
            { }


        }

        private void close_principal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
