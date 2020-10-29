using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AsistenciaSalud.Negocio;
using MetroFramework.Forms;

namespace AsistenciaSalud
{
    public partial class Usuarios : MetroForm
    {
        private bool Agregar;
        String password,cluenombre;
        bool issuper;
       
        public Usuarios()
        {
            InitializeComponent();
           
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

            try
            {
                actualizar();
                HabilitaCaptura(false);

                cbclue.DataSource = AutoCompleClues.Datos();
                cbclue.DisplayMember = "nombre_unidad";
                cbclue.ValueMember = "nombre_unidad";
                cbclue.AutoCompleteCustomSource = AutoCompleClues.Autocomplete();
                cbclue.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbclue.AutoCompleteSource = AutoCompleteSource.CustomSource;
                // LimpiarFormulario();



            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void actualizar()
        {
            // TODO: esta línea de código carga datos en la tabla 'checadorMaestraDataSetUsuarios.usersV2' Puede moverla o quitarla según sea necesario.
            this.usersV2TableAdapter.Fill(this.checadorMaestraDataSetUsuarios.usersV2);
        }

        private void HabilitaCaptura(bool Valor)
        {
            gbpermisos.Enabled = Valor;
            mgvusuarios.Enabled = !Valor;
            gbdatosgenerales.Enabled = Valor;
            mlsalir.Enabled = !Valor;
            mlagregar.Enabled = !Valor;
            mlmodificar.Enabled = !Valor;
            mleliminar.Enabled = !Valor;
            mlcargarpermisos.Enabled = !Valor;
            mlcancelar.Enabled = Valor;
            mlguardar.Enabled = Valor;

            if (!Valor)
            {
                mlcancelar.Style = MetroFramework.MetroColorStyle.Black;
                mlguardar.Style = MetroFramework.MetroColorStyle.Black;
                mlagregar.Style = MetroFramework.MetroColorStyle.Silver;
                mlmodificar.Style = MetroFramework.MetroColorStyle.Silver;
                mleliminar.Style = MetroFramework.MetroColorStyle.Silver;
                mlcargarpermisos.Style = MetroFramework.MetroColorStyle.Silver;
                mlsalir.Style = MetroFramework.MetroColorStyle.Silver;
            }
            else
            {
                mlcancelar.Style = MetroFramework.MetroColorStyle.Silver;
                mlguardar.Style = MetroFramework.MetroColorStyle.Silver;

                mlagregar.Style = MetroFramework.MetroColorStyle.Black;
                mlmodificar.Style = MetroFramework.MetroColorStyle.Black;
                mleliminar.Style = MetroFramework.MetroColorStyle.Black;
                mlcargarpermisos.Style = MetroFramework.MetroColorStyle.Black;
                mlsalir.Style = MetroFramework.MetroColorStyle.Black;
            }
        }

        private void toolStriptbid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                usersV2BindingSource.Filter = "nombre LIKE '%" + toolStriptbid.Text + "%' OR apellido_paterno LIKE '" + toolStriptbid.Text + "%' OR apellido_materno LIKE '" + toolStriptbid.Text + "%'  OR username LIKE '" + toolStriptbid.Text + "%'";
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "CLientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_principal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mlsalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
            mtxtapellidopaterno.Text = "";
            mtxtapellidomaterno.Text = "";
            mtxtemail.Text = "";
            mtxtusername.Text = "";
            mtxtpassword.Text = "";
            mtxtalias.Text = "";
            cbclue.Text = "--seleccionar--";
            mcbactivo.Checked = false;
        }

        private void mlmodificar_Click(object sender, EventArgs e)
        {
            if (ValidarVacios())
            {
                if (mgvusuarios.SelectedRows[0].Index >= 0)
                {
                    Agregar = false;
                    password = mtxtpassword.Text;
                    cluenombre = cbclue.Text;
                    HabilitaCaptura(true);
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Error de seleccion, elija un elemento de la lista", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Error de seleccion, elija un elemento de la lista", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool ValidarVacios()
        {
            if (mtxtnombre.Text == "")
                return false;
            else
                return true;

        }

        private void mleliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mgvusuarios.SelectedRows[0].Index >= 0)
                {
                    int index = mgvusuarios.CurrentCell.RowIndex;
                    issuper = Convert.ToBoolean(mgvusuarios.Rows[index].Cells[8].Value.ToString());

                    if (issuper)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Un super usaurio no puede ser eliminado", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    if (MetroFramework.MetroMessageBox.Show(this, "¿Está seguro de querer eliminar el registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Datos.DatosMaestro eliminar = new Datos.DatosMaestro();
                        int valor = eliminar.EliminarUsuario(mtxtid.Text);
                        if (valor > 0)
                            MetroFramework.MetroMessageBox.Show(this, "Usuario eliminado con exito", "Confirmación de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void mlcancelar_Click(object sender, EventArgs e)
        {
            HabilitaCaptura(false);
            actualizar();
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
                        Datos.DatosSirh consultarclue = new Datos.DatosSirh();
                        DataTable dtclue;
                        dtclue = consultarclue.ConsultarCluesByUnidad(cbclue.Text);
                        String clueid="";
                        if (dtclue.Rows.Count > 0)
                        { 
                            clueid= dtclue.Rows[0]["clues"].ToString();
                        }
                        int valor = insertar.InsertarUsuario(mtxtusername.Text, mtxtpassword.Text, mtxtemail.Text, mtxtnombre.Text, mtxtapellidopaterno.Text, mtxtapellidomaterno.Text, mtxtalias.Text, mcbactivo.Checked, clueid);
                        if (valor > 0)
                            MetroFramework.MetroMessageBox.Show(this, "Usuario Guardado con exito", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "El Usuario no pudo ser agregado", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        LimpiarFormulario();
                    }
                    else
                    {
                        Datos.DatosMaestro modificar = new Datos.DatosMaestro();
                        int bandera = 0;
                        String clueid = "";
                        if (password != mtxtpassword.Text)
                        {
                            password = mtxtpassword.Text;
                            bandera = 1;
                        }

                        if (cluenombre != cbclue.Text)
                        {
                            Datos.DatosSirh consultarclue = new Datos.DatosSirh();
                            DataTable dtclue;
                            dtclue = consultarclue.ConsultarCluesByUnidad(cbclue.Text);
                           
                            if (dtclue.Rows.Count > 0)
                            {
                                clueid = dtclue.Rows[0]["clues"].ToString();
                            }
                        }
                        else
                        {
                            clueid = cbclue.Text;
                        }

                        int valor = modificar.ModificarUsuario(mtxtusername.Text, mtxtpassword.Text, mtxtemail.Text, mtxtnombre.Text, mtxtapellidopaterno.Text, mtxtapellidomaterno.Text, mtxtalias.Text, mcbactivo.Checked, clueid,mtxtid.Text,bandera);
                        if (valor > 0)
                            MetroFramework.MetroMessageBox.Show(this, "Usuario modificado con exito", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Usuario no pudo ser modificado", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (mtxtnombre.Text == "" || mtxtapellidopaterno.Text == "" || mtxtapellidomaterno.Text == "" || mtxtemail.Text == "" || mtxtpassword.Text == "" || cbclue.Text=="" || cbclue.Text == "--seleccionar--" || mtxtalias.Text=="")
                return false;
            else
                return true;
        }

        private void mlcargarpermisos_Click(object sender, EventArgs e)
        {
            int index = mgvusuarios.CurrentCell.RowIndex;
            issuper = Convert.ToBoolean(mgvusuarios.Rows[index].Cells[8].Value.ToString());
            if (issuper)
            {
                MetroFramework.MetroMessageBox.Show(this, "No es necesario asignarle permisos a un super admin", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                AsignacionPermisoUsuarios ver = new AsignacionPermisoUsuarios(mtxtid.Text);
                ver.ShowDialog();
            }
        }

        private void mgvusuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = mgvusuarios.CurrentCell.RowIndex;
            issuper = Convert.ToBoolean(mgvusuarios.Rows[index].Cells[8].Value.ToString());
        }

        private void mtxtemail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(this.mtxtemail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {

                this.mtxtusername.Focus();
                errorproveedor.Clear();
            }
            else
            {
                errorproveedor.SetError(mtxtemail, "el formato del Email ingresado no es valido");
                this.mtxtemail.Focus();

            }
        }
    }
}
