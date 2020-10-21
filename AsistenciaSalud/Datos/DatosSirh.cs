using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace AsistenciaSalud.Datos
{
    class DatosSirh
    {
        private MySqlConnection conexion;

        public DatosSirh()
        {
            try
            {
                //string connStr = "server=slmexgps.ddns.net;user=mike;database=politracker;port=3306;password=DIABLO0409!!";
                string connStr = "server=5.196.110.172;user=ssa_checador;database=sirh;port=3306;password=ssadev2020!!";

                conexion = new MySqlConnection();
                conexion.ConnectionString = connStr;

                conexion.Open();
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }

#region clues
        public DataTable ConsultarClues()
        {
            try
            {
                DataTable tabla = new DataTable();
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                String cadenasql = "Select clues,nombre_unidad,nivel_atencion from catalogo_clues where estatus='EN OPERACIÓN'";
                cmd.Connection = conexion;
                cmd.CommandText = cadenasql;
                cmd.CommandType = CommandType.Text;


                adapter.SelectCommand = cmd;
                adapter.Fill(tabla);

                cmd.Dispose();
                adapter.Dispose();

                return tabla;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public DataTable ConsultarCluesByUnidad(String unidad)
        {
            try
            {
                DataTable tabla = new DataTable();
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                String cadenasql = "Select clues from catalogo_clues where nombre_unidad='"+unidad+"'";
                cmd.Connection = conexion;
                cmd.CommandText = cadenasql;
                cmd.CommandType = CommandType.Text;


                adapter.SelectCommand = cmd;
                adapter.Fill(tabla);

                cmd.Dispose();
                adapter.Dispose();

                return tabla;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        #endregion

        #region personalactivo

        public DataTable ConsultarPersonalActivo(String clues)
        {
            try
            {
                DataTable tabla = new DataTable();
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                String cadenasql = "SELECT * FROM empleados where estatus=1 and validado=1 and clues='"+clues+"'";
                cmd.Connection = conexion;
                cmd.CommandText = cadenasql;
                cmd.CommandType = CommandType.Text;


                adapter.SelectCommand = cmd;
                adapter.Fill(tabla);

                cmd.Dispose();
                adapter.Dispose();

                return tabla;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        #endregion
    }
}
