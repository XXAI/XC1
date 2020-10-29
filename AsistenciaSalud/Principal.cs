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
using AsistenciaSalud.Datos;
using MetroFramework.Forms;
namespace AsistenciaSalud
{
    public delegate void MessageEvent(string message);
    public partial class Principal : MetroForm
    {
        String nombre, id, clue;
        bool isroot;
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

        private void mladministrarchecadores_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (isroot)
            {

            }
            else
            {
                _FormularioSecundario = new AdministradorRelojes(clue);
                _FormularioSecundario.ShowDialog();
                //Thread principal = new Thread(run);
                ////this.Close();
                //principal.SetApartmentState(System.Threading.ApartmentState.STA);
                //principal.Start();
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            tslbpersonal.Text = "Bienvenido " + nombre;
            tslclue.Text = "Esta conectado a la CLUE " + clue;

            //mlpermisos.Enabled = true;

            if (isroot)
            {
                mlpermisos.Visible = true;
                mlpermisos.Enabled = true;
                mladministracion.Visible = true;
                mladministracion.Enabled = true;
                mlusuarios.Enabled = true;
                mlusuarios.Visible = true;
                mltrabajadores.Visible = true;
                mltrabajadores.Enabled = true;
                mlconexiones.Enabled = true;
                mlconexiones.Visible = true;
                mlkardex.Visible = true;
                mlkardex.Enabled = true;
                mlfaltas.Visible = true;
                mlfaltas.Enabled = true;
                mltrimestral.Enabled = true;
                mltrimestral.Visible = true;
                mladministrarchecadores.Enabled = true;
                mladministrarchecadores.Visible = true;
                mllogs.Visible = true;
                mllogs.Enabled = true;
            }

            else
            { DatosMaestro consultar = new DatosMaestro();
                DataTable dt;  
                dt= consultar.ConsultarPermisosUsurio(id);

                if (dt.Rows.Count > 0)
                {
                   
                    foreach (DataRow row in dt.Rows)
                    {
                        
                        switch (row[1].ToString())
                        
                        {
                            case "2IxjQdxuQZQY3CItQRwlm2n1k":
                                mlfaltas.Visible = true;
                                mlfaltas.Enabled = true;
                                break;
                            case "72kLZd2l0eqKSXDMwbNwk0T32":
                                mladministracion.Visible = true;
                                mladministracion.Enabled = true;
                                break;
                            case "c7vI7wvLELuu0iE9j6jseAFsT":
                                mlkardex.Visible = true;
                                mlkardex.Enabled = true;
                                break;
                            case "m4svd2Wb4nJOxSaz1sbiDrE5K":
                                mltrabajadores.Visible = true;
                                mltrabajadores.Enabled = true;
                                break;
                            case "MYmuoq1L31jKCnrY5Flo59Y49":
                                mltrimestral.Enabled = true;
                                mltrimestral.Visible = true;
                                break;
                            case "RqOHXCX9eldwpxuTngvv684nb":
                                mlusuarios.Enabled = true;
                                mlusuarios.Visible = true;
                                break;
                            case "Ru8yPddcSBTVH3FQZEcyzntlm":
                                mladministrarchecadores.Enabled = true;
                                mladministrarchecadores.Visible = true;
                                break;
                            case "aVjp7xO37OnToT9Df5To9VwAb":
                                mllogs.Visible = true;
                                mllogs.Enabled = true;
                                break;
                        }
                    }
                }

            
            }


        }

        private void close_principal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
