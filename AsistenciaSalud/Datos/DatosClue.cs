using System;
using System.Collections.Generic;
using System.Configuration;
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
    }
}
