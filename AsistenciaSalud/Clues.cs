using System;
using System.Data;
using System.Windows.Forms;
using AsistenciaSalud.Negocio;
using MetroFramework.Forms;
namespace AsistenciaSalud
{
    public partial class Clues : MetroForm
    {

        private bool Agregar;
        string cluenombre;
        public Clues()
        {
            InitializeComponent();
        }

        private void Clues_Load(object sender, EventArgs e)
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
            // TODO: esta línea de código carga datos en la tabla 'checadorMaestraDataSetClues.Clues' Puede moverla o quitarla según sea necesario.
            this.cluesTableAdapter.Fill(this.checadorMaestraDataSetClues.Clues);
        }

        private void HabilitaCaptura(bool Valor)
        {
            gbclues.Enabled = Valor;
            mgclues.Enabled = !Valor;
           
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
            mtxtdescripcion.Focus();
        }

        private void LimpiarFormulario()
        {
            mtxtid.Text = "";
            mtxtdescripcion.Text = "";
            mtxtruta.Text = "";
            cbclue.Text = "--seleccionar--";
            
        }

        private void mlmodificar_Click(object sender, EventArgs e)
        {
            if (mgclues.SelectedRows[0].Index >= 0)
            {
                Agregar = false;
               
                cluenombre = cbclue.Text;
                HabilitaCaptura(true);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Error de seleccion, elija un elemento de la lista", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                        String clueid = "";
                        if (dtclue.Rows.Count > 0)
                        {
                            clueid = dtclue.Rows[0]["clues"].ToString();
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Ocurrio un error al obtener la clue, intente de nuevo", "Clues", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            return;
                        }
                        int valor = insertar.InsertarClues(mtxtdescripcion.Text,mtxtruta.Text,clueid);
                        if (valor > 0)
                            MetroFramework.MetroMessageBox.Show(this, "Clue Guardado con exito", "Clues", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "La clue no pudo ser agregada", "Clues", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        LimpiarFormulario();
                    }
                    else
                    {
                        Datos.DatosMaestro modificar = new Datos.DatosMaestro();
                      
                        String clueid = "";
                       

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

                        int valor = modificar.ModificarClues(mtxtdescripcion.Text,mtxtruta.Text,clueid,mtxtid.Text);
                        if (valor > 0)
                            MetroFramework.MetroMessageBox.Show(this, "Clue modificada con exito", "Clues", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Clue no pudo ser modificada", "Clues", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (mtxtdescripcion.Text == "" || mtxtruta.Text == "" ||  cbclue.Text == "--seleccionar--" )
                return false;
            else
                return true;
        }

    }
}
