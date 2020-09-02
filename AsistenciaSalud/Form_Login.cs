using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Capa_Negocio;

namespace AsistenciaSalud
{
    public partial class Form_Login : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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
            if(txt_user.Text.Trim().Length == 0) { MessageBox.Show("Debe de ingresar el usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txt_user.Focus(); return false; }
            if (txt_pass.Text.Trim().Length == 0) { MessageBox.Show("Debe de ingresar la contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txt_pass.Focus(); return false; }
            return true;
        }

        private void AccederAlSistema()
        {
            RN_Usuario obj = new RN_Usuario();
            DataTable dt = new DataTable();

            int total_intentos = 0;
            string usuario, password;

            if(ValidarTextBox() == false)
            {
                return;
            }
            usuario = txt_user.Text.Trim();
            password = txt_pass.Text.Trim();

            if(obj.RN_Verificar_Acceso(usuario, password) == true)
            {
                MessageBox.Show("Bienvenido al sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña invalidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                total_intentos++;
                txt_user.Focus();
                if(total_intentos == 3) {
                    Application.Exit();
                    MessageBox.Show("El no maximo de intentos ha sido superado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        
    }
}
