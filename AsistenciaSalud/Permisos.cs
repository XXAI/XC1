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
        private bool Agregar;
        public Permisos()
        {
            InitializeComponent();
        }

        private void Permisos_Load(object sender, EventArgs e)
        {
            try
            {
                actualizar();
                HabilitaCaptura(false);
                // LimpiarFormulario();



            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void actualizar()
        {
            // TODO: esta línea de código carga datos en la tabla 'checadorMaestraDataSetPermisos.permissions' Puede moverla o quitarla según sea necesario.
            this.permissionsTableAdapter.Fill(this.checadorMaestraDataSetPermisos.permissions);
        }

        private void mpnbusqueda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_principal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mlsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mtlgenerar_Click(object sender, EventArgs e)
        {
            //mtxtpermiso.Text = GetRandomAlphaNumeric();
        }

        public static string GetRandomAlphaNumeric()
        {
            var random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(chars.Select(c => chars[random.Next(chars.Length)]).Take(25).ToArray());
        }

        private void mtlgenerar_Click_1(object sender, EventArgs e)
        {
            mtxtpermiso.Text = GetRandomAlphaNumeric();


        }

        private void mlagregar_Click(object sender, EventArgs e)
        {
            Agregar = true;
            LimpiarFormulario();
            HabilitaCaptura(true);
            mtxtdescripcion.Focus();
        }

        private void LimpiarFormulario()
        {
            mtxtpermiso.Text = "";
            mtxtdescripcion.Text = "";
            mtxtgrupo.Text = "";
        }

        private void HabilitaCaptura( bool Valor)
        {
            gbpermisos.Enabled = Valor;
            mgpermisos.Enabled =!Valor;
            mlagregar.Enabled = !Valor;
            mlmodificar.Enabled = !Valor;
            mleliminar.Enabled = !Valor;
            mlsalir.Enabled = !Valor;
            mlcancelar.Enabled = Valor;
            mlguardar.Enabled = Valor;

            if (!Valor)
            {
                mlcancelar.Style = MetroFramework.MetroColorStyle.Black;
                mlguardar.Style = MetroFramework.MetroColorStyle.Black;
                mlagregar.Style = MetroFramework.MetroColorStyle.Silver;
                mlmodificar.Style = MetroFramework.MetroColorStyle.Silver;
                mleliminar.Style = MetroFramework.MetroColorStyle.Silver;
                mlsalir.Style = MetroFramework.MetroColorStyle.Silver;
            }
            else
            {
                mlcancelar.Style = MetroFramework.MetroColorStyle.Silver;
                mlguardar.Style = MetroFramework.MetroColorStyle.Silver;

                mlagregar.Style = MetroFramework.MetroColorStyle.Black;
                mlmodificar.Style = MetroFramework.MetroColorStyle.Black;
                mleliminar.Style = MetroFramework.MetroColorStyle.Black;
                mlsalir.Style = MetroFramework.MetroColorStyle.Black;
            }

        }

        private void mlcancelar_Click(object sender, EventArgs e)
        {
            HabilitaCaptura(false);
            actualizar();
        }

        private void mlmodificar_Click(object sender, EventArgs e)
        {
            if (mgpermisos.SelectedRows[0].Index >= 0)
            {
                Agregar = false;

                HabilitaCaptura(true);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Error de seleccion, elija un elemento de la lista", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void mleliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mgpermisos.SelectedRows[0].Index >= 0)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "¿Está seguro de querer eliminar el registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Datos.DatosMaestro eliminar = new Datos.DatosMaestro();
                        int valor = eliminar.EliminarPermiso(mtxtpermiso.Text);
                        if (valor > 0)
                            MetroFramework.MetroMessageBox.Show(this, "Permiso elimindo con exito", "Confirmación de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizar();
                    }
                    //else
                    //    MetroFramework.MetroMessageBox.Show(this, "El cliente no a podido ser eliminado", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mlguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaFormulario())
                {
                    if (Agregar)
                    {

                        Datos.DatosMaestro insertar = new Datos.DatosMaestro();
                       
                        int valor = insertar.InsertarPermiso(mtxtpermiso.Text,mtxtdescripcion.Text,mtxtgrupo.Text);
                        if (valor > 0)
                            MetroFramework.MetroMessageBox.Show(this, "Permiso Guardado con exito", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "El Permiso no pudo ser agregado", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        LimpiarFormulario();
                    }
                    else
                    {
                        Datos.DatosMaestro modificar = new Datos.DatosMaestro();
                        int valor = modificar.ModificarPermiso(mtxtpermiso.Text, mtxtdescripcion.Text, mtxtgrupo.Text);
                        if (valor > 0)
                            MetroFramework.MetroMessageBox.Show(this, "Permiso modificado con exito", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Permiso no pudo ser modificado", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        LimpiarFormulario();

                    }
                    HabilitaCaptura(false);
                    actualizar();
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Error de captura, es posible que falten datos por capturar", "Error de captura", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "CLientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidaFormulario()
        {
            if (mtxtpermiso.Text != "" || mtxtdescripcion.Text!="")
                return true;
            else
                return false;
        }

        private void toolStripLabel1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                permissionsBindingSource.Filter = "descripcion LIKE '%" + toolStriptbid.Text + "%' OR id LIKE '" + toolStriptbid.Text + "%'";
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "CLientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
