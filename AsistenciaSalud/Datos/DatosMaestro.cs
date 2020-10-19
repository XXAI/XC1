using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;


namespace AsistenciaSalud.Datos
{
    class DatosMaestro
    {
        private SqlConnection conexion;
        string cadenaConeccion;
        public DatosMaestro()
        {
            try
            {
                ConnectionStringSettingsCollection settings =
                ConfigurationManager.ConnectionStrings;

                if (settings != null)
                {
                    foreach (ConnectionStringSettings cs in settings)
                    {

                        if (cs.Name == "AsistenciaSalud.Properties.Settings.Maestra")
                        {
                            cadenaConeccion = cs.ConnectionString;
                        }
                    }
                }

                conexion = new SqlConnection();
                conexion.ConnectionString = cadenaConeccion;
                conexion.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region usuarios
        public DataTable ConsultarUsuario(String usuario, string password)
        {
            try
            {
                DataTable tabla = new DataTable();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@password", hash(password));

                String cadenasql = "ConsultarUsuario";
                cmd.Connection = conexion;
                cmd.CommandText = cadenasql;
                cmd.CommandType = CommandType.StoredProcedure;


                adapter.SelectCommand = cmd;
                adapter.Fill(tabla);

                cmd.Dispose();
                adapter.Dispose();
                conexion.Dispose();
                return tabla;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public int EliminarUsuario(String id)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.AddWithValue("@id",Convert.ToInt32( id));

            string cadenasql = "EliminarUsuario";

            cmd.CommandText = cadenasql;
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;

            int dato = Convert.ToInt32(cmd.ExecuteNonQuery());
            cmd.Dispose();
            return dato;
        }

        public int InsertarUsuario(String username, String password, String email,string nombre,string apellidopaterno,string apellidomaterno, string alias, bool activo, string clue)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", hash(password));
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellidopaterno", apellidopaterno);
                cmd.Parameters.AddWithValue("@apellidomaterno", apellidomaterno);
                cmd.Parameters.AddWithValue("@alias", alias);
                cmd.Parameters.AddWithValue("@activo", activo);
                cmd.Parameters.AddWithValue("@clue", clue);



                String cadenasql = "InsertarUsuario";
                cmd.Connection = conexion;
                cmd.CommandText = cadenasql;
                cmd.CommandType = CommandType.StoredProcedure;


                adapter.SelectCommand = cmd;
                int dato = Convert.ToInt32(cmd.ExecuteNonQuery());
                cmd.Dispose();
                return dato;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public int ModificarUsuario(String username, String password, String email, string nombre, string apellidopaterno, string apellidomaterno, string alias, bool activo, string clue, string id, int bandera)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string temp = hash(password);

                cmd.Parameters.AddWithValue("@username", username);
                if (bandera == 1)
                    cmd.Parameters.AddWithValue("@password", temp);
                else
                    cmd.Parameters.AddWithValue("@password", password);

                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellidopaterno", apellidopaterno);
                cmd.Parameters.AddWithValue("@apellidomaterno", apellidomaterno);
                cmd.Parameters.AddWithValue("@alias", alias);
                cmd.Parameters.AddWithValue("@activo", activo);
                cmd.Parameters.AddWithValue("@clue", clue);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));



                String cadenasql = "ModificarUsuario";
                cmd.Connection = conexion;
                cmd.CommandText = cadenasql;
                cmd.CommandType = CommandType.StoredProcedure;


                adapter.SelectCommand = cmd;
                int dato = Convert.ToInt32(cmd.ExecuteNonQuery());
                cmd.Dispose();
                return dato;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        #endregion

        #region Permisos
        public int EliminarPermiso(String id)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.AddWithValue("@id", id);

            string cadenasql = "EliminarPermiso";

            cmd.CommandText = cadenasql;
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;

            int dato = Convert.ToInt32(cmd.ExecuteNonQuery());
            cmd.Dispose();
            return dato;
        }

        public int InsertarPermiso(String idpermiso, String descripcion, String grupo)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();

                cmd.Parameters.AddWithValue("@id", idpermiso);
                cmd.Parameters.AddWithValue("@descripcion",descripcion);
                cmd.Parameters.AddWithValue("@rupo", grupo);
                


                String cadenasql = "InsertarPermiso";
                cmd.Connection = conexion;
                cmd.CommandText = cadenasql;
                cmd.CommandType = CommandType.StoredProcedure;


                adapter.SelectCommand = cmd;
                int dato = Convert.ToInt32(cmd.ExecuteNonQuery());
                cmd.Dispose();
                return dato;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public int ModificarPermiso(String idpermiso, String descripcion, String grupo)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();

                cmd.Parameters.AddWithValue("@id", idpermiso);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@grupo", grupo);



                String cadenasql = "ModificarPermiso";
                cmd.Connection = conexion;
                cmd.CommandText = cadenasql;
                cmd.CommandType = CommandType.StoredProcedure;


                adapter.SelectCommand = cmd;
                int dato = Convert.ToInt32(cmd.ExecuteNonQuery());
                cmd.Dispose();
                return dato;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        #endregion

        #region clues

        public int InsertarClues(String descripcion, String ruta, String clues)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();

                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@ruta", ruta);
                cmd.Parameters.AddWithValue("@clues", clues);



                String cadenasql = "InsertarClues";
                cmd.Connection = conexion;
                cmd.CommandText = cadenasql;
                cmd.CommandType = CommandType.StoredProcedure;


                adapter.SelectCommand = cmd;
                int dato = Convert.ToInt32(cmd.ExecuteNonQuery());
                cmd.Dispose();
                return dato;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public int ModificarClues(String descripcion, String ruta, String clues,string idclue)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();

                cmd.Parameters.AddWithValue("@id", idclue);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@ruta", ruta);
                cmd.Parameters.AddWithValue("@clues", clues);



                String cadenasql = "ModificarClues";
                cmd.Connection = conexion;
                cmd.CommandText = cadenasql;
                cmd.CommandType = CommandType.StoredProcedure;


                adapter.SelectCommand = cmd;
                int dato = Convert.ToInt32(cmd.ExecuteNonQuery());
                cmd.Dispose();
                return dato;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        #endregion

        #region encrypt
        public string hash(string password)
        {

            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(password));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        #endregion
    }
}
