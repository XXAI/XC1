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
    public partial class AsignacionPermisoUsuarios : MetroForm
    {
        String iduser = "";
        DataTable permisosoriginales;
        public AsignacionPermisoUsuarios(String idusuario)
        {
            InitializeComponent();
            iduser = idusuario;
        }

        private void AsignacionPermisoUsuarios_Load(object sender, EventArgs e)
        {

            try
            {
                actualizar();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualizar()
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'checadorMaestraDataSetPermisos.permissions' Puede moverla o quitarla según sea necesario.
                this.permissionsTableAdapter.Fill(this.checadorMaestraDataSetPermisos.permissions);

                Datos.DatosMaestro consultar = new Datos.DatosMaestro();
                DataTable dt;

                dt = consultar.ConsultarPermisosUsurio(iduser);
                if (dt.Rows.Count > 0)
                {
                    permisosoriginales = dt;
                    foreach (DataRow row in dt.Rows)
                    {

                        mgpermisosusuarios.Rows.Add(row[0].ToString(), row[1].ToString());

                    }
                }
            }
            catch (Exception ex)
            { 
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void mgpermisosusuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mlnext_Click(object sender, EventArgs e)
        {
            try
            {
                if (mgpermisosusuarios.Rows.Count > 0)
                {
                    if (validarpermisos())
                    {
                        int index = mgpermisos.CurrentCell.RowIndex;
                        mgpermisosusuarios.Rows.Add(mgpermisos.Rows[index].Cells[3].Value.ToString(), mgpermisos.Rows[index].Cells[0].Value.ToString());
                    }
                }
                else
                {
                    int index = mgpermisos.CurrentCell.RowIndex;
                    mgpermisosusuarios.Rows.Add(mgpermisos.Rows[index].Cells[3].Value.ToString(), mgpermisos.Rows[index].Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            { 
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                if (mgpermisosusuarios.SelectedRows[0].Index >= 0)
                {
                    mgpermisosusuarios.Rows.RemoveAt(mgpermisosusuarios.SelectedRows[0].Index);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "seleccione un elemento de la lista", "Elemento de lista", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "no hay mas permisos que eliminar", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private bool validarpermisos()
        {
            try
            {
                int index = mgpermisos.CurrentCell.RowIndex;
                string id = mgpermisos.Rows[index].Cells[0].Value.ToString();

                foreach (DataGridViewRow row in mgpermisosusuarios.Rows)
                {
                    if (id == row.Cells[1].Value.ToString())
                    {
                        return false;

                    }

                }
                return true;
            }
            catch (Exception ex)
            { 
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }




        }

        private void mlguardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (mgpermisosusuarios.Rows.Count > 0)
                {
                    Datos.DatosMaestro eliminar = new Datos.DatosMaestro();
                    eliminar.EliminarTodosPermisos(iduser);
                    Datos.DatosMaestro insertar = new Datos.DatosMaestro();

                    string permiso = "";
                    foreach (DataGridViewRow row in mgpermisosusuarios.Rows)
                    {
                        permiso += Convert.ToString(row.Cells[1].Value);
                        insertar.InsertarPermisoUsuario(permiso, iduser);
                        permiso = "";
                    }

                    MetroFramework.MetroMessageBox.Show(this, "Permisos agregados correctamente", "Asignación de permisos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "no existen permisos a guardar", "asignacion de permsisos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        
        }
    }
}
