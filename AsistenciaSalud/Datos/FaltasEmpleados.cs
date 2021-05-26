using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaSalud.Datos
{
    class FaltasEmpleados
    {
        private SqlConnection conexion;
        
        public FaltasEmpleados(SqlConnection _conexion)
        {
            this.conexion = _conexion;
            
        }

        public DataTable ConsultarUsuario(DataTable listaEmpleados, int anio, int mes)
        {
            this.conexion.Open();
            //Console.WriteLine(this.conexion.State);
            Clases.Fechas fechas = new Clases.Fechas();
            string _Mes = fechas.NombreMes(mes - 1);
            try
            {
                String cadenasql = "LISTA_EMPLEADOS";
                

                SqlCommand command = new SqlCommand(cadenasql, this.conexion);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@tipo_trabajador", "416");
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //Console.WriteLine(reader.Read());
                    while (reader.Read())
                    {
                        DataRow row_local = listaEmpleados.NewRow();
                        row_local["AÑO"] = anio.ToString();
                        row_local["MES"] = _Mes;
                        row_local["RFC"] = reader.GetString(5).ToString();
                        //Console.WriteLine(reader.GetString(5).ToString());
                        listaEmpleados.Rows.Add(row_local);
                        //_usuario.apellido_paterno = reader.GetString(5).ToString();

                    }
                }

                command.Dispose();
                this.conexion.Dispose();
                return listaEmpleados;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw e;

            }
        }
    }
}
