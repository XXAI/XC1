using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace AsistenciaSalud
{
    public partial class Form_Login : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

       

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        Clases.Usuario _usuario = new Clases.Usuario();
        int total_intentos = 0;
        SqlConnection _Conexion;
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_acceder_Click(object sender, EventArgs e)
        {
            AccederAlSistema();
        }

        private void close_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool ValidarTextBox()
        {
            try
            {
                if (txt_user.Text.Trim().Length == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Debe de ingresar el usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_user.Focus();
                    return false;
                }

                if (txt_pass.Text.Trim().Length == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Debe de ingresar la contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_pass.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;


            }
        }

        private void AccederAlSistema()
        {
            if (ValidarTextBox())
            {
                try
                {
                    Datos.DatosMaestro consultar = new Datos.DatosMaestro();
                    this._Conexion = consultar.DatosConexion("Maestra");
                    _usuario = consultar.ConsultarUsuario(this._Conexion, txt_user.Text.Trim(), txt_pass.Text.Trim());
                    if (_usuario.nombre != null)
                    {
                        Thread principal = new Thread(run);
                        this.Close();
                        principal.SetApartmentState(System.Threading.ApartmentState.STA);
                        principal.Start();
                       
                    }
                    else
                    {
                        MessageBox.Show(this, "Verifique sus datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(this, "Verifique sus datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Usuario y/o contraseña invalidos", "Fallo de inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                total_intentos++;
                txt_user.Focus();
                if (total_intentos == 3)
                {
                    MetroFramework.MetroMessageBox.Show(this, "El no maximo de intentos ha sido superado", "Fallo de inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void run()
        {
            Forms.SeleccionarClue pantalla = new Forms.SeleccionarClue();
            pantalla.CargarClues(this._usuario);
            pantalla.ShowDialog();
        }
    }
}
