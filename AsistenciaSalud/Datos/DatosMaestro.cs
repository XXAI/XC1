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

                        if (cs.Name == "AsistenciaSalud.Properties.Settings.Maestro")
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
    }
}
