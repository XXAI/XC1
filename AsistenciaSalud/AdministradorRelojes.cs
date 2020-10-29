using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsistenciaSalud.Datos;
using MetroFramework.Forms;
namespace AsistenciaSalud
{
    public partial class AdministradorRelojes : MetroForm
    {
        String clueconexion = "";
        private bool Agregar;
        public AdministradorRelojes(String clue)
        {
            InitializeComponent();
            clueconexion = clue;
        }

        private void AdminitradorRelojes_Load(object sender, EventArgs e)
        {
            try
            {
                actualizar();
                HabilitaCaptura(false);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HabilitaCaptura(bool Valor)
        {
            gbdatosgenerales.Enabled = Valor;
            mgrelojes.Enabled = !Valor;

            mlsalir.Enabled = !Valor;
            mlagregar.Enabled = !Valor;
            mlmodificar.Enabled = !Valor;
            mleliminar.Enabled = !Valor;

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


        private void actualizar()
        {try
            {
                DatosClue consultar = new DatosClue(clueconexion);
                DataTable dt;
                dt = consultar.ConsultarDispositivos();

                if (dt.Rows.Count > 0)
                {
                    mgrelojes.DataSource = dt;
                   
                    int valor = mgrelojes.CurrentCell.RowIndex;
                    mtxtid.Text = mgrelojes.Rows[valor].Cells[0].Value.ToString();
                    mtxtnombre.Text = mgrelojes.Rows[valor].Cells[1].Value.ToString();
                    mtxtip.Text = mgrelojes.Rows[valor].Cells[2].Value.ToString();
                    mtxtport.Text = mgrelojes.Rows[valor].Cells[3].Value.ToString();
                    mcbactivo.Checked = Convert.ToBoolean(mgrelojes.Rows[valor].Cells[4].Value.ToString());
                    mtxtserialnumber.Text = mgrelojes.Rows[valor].Cells[5].Value.ToString();
                    mtxtmachinenumber.Text = mgrelojes.Rows[valor].Cells[6].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void mlsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_principal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mgrelojes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int valor = mgrelojes.CurrentCell.RowIndex;
                mtxtid.Text = mgrelojes.Rows[valor].Cells[0].Value.ToString();
                mtxtnombre.Text = mgrelojes.Rows[valor].Cells[1].Value.ToString();
                mtxtip.Text = mgrelojes.Rows[valor].Cells[2].Value.ToString();
                mtxtport.Text = mgrelojes.Rows[valor].Cells[3].Value.ToString();
                mcbactivo.Checked = Convert.ToBoolean(mgrelojes.Rows[valor].Cells[4].Value.ToString());
                mtxtserialnumber.Text = mgrelojes.Rows[valor].Cells[5].Value.ToString();
                mtxtmachinenumber.Text= mgrelojes.Rows[valor].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mlagregar_Click(object sender, EventArgs e)
        {
            Agregar = true;
            LimpiarFormulario();
            HabilitaCaptura(true);
            mtxtnombre.Focus();
        }

        private void LimpiarFormulario()
        {
            mtxtid.Text = "";
            mtxtnombre.Text = "";
            mtxtip.Text = "";
            mtxtport.Text = "";
            mtxtmachinenumber.Text = "";
            mtxtserialnumber.Text = "";
            mcbactivo.Checked = false;
                


        }

        private void mlmodificar_Click(object sender, EventArgs e)
        {
            if (ValidarVacios())
            {
                if (mgrelojes.SelectedRows[0].Index >= 0)
                {
                    Agregar = false;
                    HabilitaCaptura(true);
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Error de seleccion, elija un elemento de la lista", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Error de seleccion, elija un elemento de la lista", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void mlcancelar_Click(object sender, EventArgs e)
        {
            HabilitaCaptura(false);
            actualizar();
        }

        private void mleliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarVacios())
                {
                    if (mgrelojes.SelectedRows[0].Index >= 0)
                    {
                        if (MetroFramework.MetroMessageBox.Show(this, "¿Está seguro de querer eliminar el registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) == System.Windows.Forms.DialogResult.Yes)
                        {
                            DatosClue eliminar = new DatosClue(clueconexion);
                            int valor = eliminar.EliminarDispositivo(mtxtid.Text);
                            if (valor > 0)
                                MetroFramework.MetroMessageBox.Show(this, "Reloj checador elimindo con exito", "Confirmación de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            actualizar();
                        }
                        else
                            MetroFramework.MetroMessageBox.Show(this, "El reloj checador no a podido ser eliminado", "Administrador de relojes", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Error de seleccion, elija un elemento de la lista", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

                        DatosClue insertar = new DatosClue(clueconexion);

                        int valor = insertar.InsertarDispositivo(mtxtnombre.Text, mtxtip.Text, mtxtport.Text, mtxtmachinenumber.Text, mcbactivo.Checked, mtxtserialnumber.Text);
                        if (valor > 0)
                            MetroFramework.MetroMessageBox.Show(this, "Reloj checador Guardado con exito", "Administrador de relojes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "El Reloj checador no pudo ser agregado", "Administrador de relojes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        LimpiarFormulario();
                    }
                    else
                    {
                        DatosClue modificar = new DatosClue(clueconexion);


                        int valor = modificar.ModificarDispositivo(mtxtnombre.Text, mtxtip.Text, mtxtport.Text, mtxtmachinenumber.Text, mcbactivo.Checked, mtxtserialnumber.Text,mtxtid.Text);
                        if (valor > 0)
                            MetroFramework.MetroMessageBox.Show(this, "Reloj checador modificado con exito", "Administrador de relojes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Reloj checador no pudo ser modificado", "Administrador de relojes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        LimpiarFormulario();

                    }
                    HabilitaCaptura(false);
                    actualizar();
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Error de captura, es necesario capturar todos los datos que cuentan con un *", "Error de captura", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidaFormulario()
        {
            if (mtxtnombre.Text == "" || mtxtip.Text == "" || mtxtmachinenumber.Text == "" || mtxtport.Text == "" || mtxtserialnumber.Text == "" )
                return false;
            else
                return true;
        }

        private bool ValidarVacios()
        {
            if (mtxtnombre.Text == "")
                return false;
            else
                return true;

        }
    }
}
