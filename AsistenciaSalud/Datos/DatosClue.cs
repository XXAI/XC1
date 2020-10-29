using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaSalud.Datos
{
    class DatosClue
    {
        private SqlConnection conexion;
        string cadenaConeccion;
        public DatosClue(String clue)
        {
            try
            {
                ConnectionStringSettingsCollection settings =
                ConfigurationManager.ConnectionStrings;

                if (settings != null)
                {
                    foreach (ConnectionStringSettings cs in settings)
                    {

                        if (cs.Name == "AsistenciaSalud.Properties.Settings."+clue)
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

        public DataTable ConsultarDispositivos()
        {
            try
            {
                DataTable tabla = new DataTable();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();
                String cadenasql = "ConsultarChecadores";
                cmd.Connection = conexion;
                cmd.CommandText = cadenasql;
                cmd.CommandType = CommandType.StoredProcedure;


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

        public int EliminarDispositivo(String id)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));

            string cadenasql = "EliminarDispositivo";

            cmd.CommandText = cadenasql;
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;

            int dato = Convert.ToInt32(cmd.ExecuteNonQuery());
            cmd.Dispose();
            return dato;
        }

        public int InsertarDispositivo(String nombre, String ip, String port,String machinenumber,bool enabled, string sn)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@ip", ip);
                cmd.Parameters.AddWithValue("@port", port);
                cmd.Parameters.AddWithValue("@machinenumber", machinenumber);
                cmd.Parameters.AddWithValue("@enabled", enabled);
                cmd.Parameters.AddWithValue("@sn", sn);



                String cadenasql = "InsertarDispositivo";
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

        public int ModificarDispositivo(String nombre, String ip, String port, String machinenumber, bool enabled, string sn, String id)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@ip", ip);
                cmd.Parameters.AddWithValue("@port", port);
                cmd.Parameters.AddWithValue("@machinenumber", machinenumber);
                cmd.Parameters.AddWithValue("@enabled", enabled);
                cmd.Parameters.AddWithValue("@sn", sn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));




                String cadenasql = "ModificarDispositivo";
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


        public int InsertarLog(String Userid, String Checktime, String verifycode, String machinenumber, String serialnumber)
        {
            SqlCommand cmd = new SqlCommand();
            string cadenasql = "INSERT INTO CHECKINOUT (USERID,CHECKTIME,VERIFYCODE,Machineid,sn) VALUES ((select top 1 userid from USERINFO where Badgenumber=@userid),@checktime,@verify,@machine,@sn)";

            cmd.Parameters.AddWithValue("@userid", Convert.ToInt32(Userid));
            cmd.Parameters.AddWithValue("@checktime", Convert.ToDateTime(Checktime));
            cmd.Parameters.AddWithValue("@verify", Convert.ToInt32(verifycode));
            cmd.Parameters.AddWithValue("@machine", Convert.ToInt32(machinenumber));
            cmd.Parameters.AddWithValue("@sn", serialnumber);


            cmd.CommandText = cadenasql;
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;

            int dato = Convert.ToInt32(cmd.ExecuteNonQuery());
            cmd.Dispose();
            return dato;
        }

       
    }
}
