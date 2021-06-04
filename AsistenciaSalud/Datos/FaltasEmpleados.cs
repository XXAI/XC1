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

        public List<Clases.Empleado> ConsultarUsuario(DataTable listaEmpleados, int anio, int mes)
        {
            this.conexion.Open();
            //Console.WriteLine(this.conexion.State);
            Clases.Fechas fechas = new Clases.Fechas();
            List<Clases.Empleado> _empleado = new List<Clases.Empleado>();

            string[] ListaClues = new string[2] { "CSSSA017213", "CSSSA007540" };
            string _Mes = fechas.NombreMes(mes - 1);
            
            try
            {
                String cadenasql = "LISTA_EMPLEADOS";
                

                for (int i = 0; i < ListaClues.Count(); i++)
                {
                    SqlCommand command = new SqlCommand(cadenasql, this.conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@clues_trabajador", ListaClues[i]);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Clases.Empleado empleado = new Clases.Empleado();
                            empleado.id = long.Parse(reader.GetInt32(0).ToString());
                            empleado.num_empleado = reader.GetString(1).ToString();
                            empleado.rfc = reader.GetString(2).ToString();
                            empleado.curp = reader.GetString(3).ToString();
                            empleado.nombre = reader.GetString(4).ToString();
                            empleado.apellido_paterno = reader.GetString(5).ToString();
                            empleado.apellido_materno = reader.GetString(6).ToString();
                            empleado.ur = reader.GetString(7).ToString();
                            empleado.codigo = reader.GetString(8).ToString();
                            empleado.clues = reader.GetString(9).ToString();
                            empleado.cr = reader.GetString(10).ToString();
                            empleado.fecha_ingreso = reader.GetString(11).ToString();
                            empleado.fecha_ingreso_federal = reader.GetString(12).ToString();

                            /*Asistencia*/
                            SqlCommand comandoChecadas = new SqlCommand("ASISTENCIA_EMPLEADOS", this.conexion);
                            comandoChecadas.CommandType = CommandType.StoredProcedure;

                            comandoChecadas.Parameters.AddWithValue("@empleado_id", empleado.id);
                            comandoChecadas.Parameters.AddWithValue("@fecha_inicial", 2021-01-01);
                            comandoChecadas.Parameters.AddWithValue("@fecha_final", 2021-01-31);

                            List<Clases.Checadas> _checadas = new List<Clases.Checadas>();
                            using (SqlDataReader lectorChecadas = comandoChecadas.ExecuteReader())
                            {
                                while (lectorChecadas.Read())
                                {
                                    Console.WriteLine(lectorChecadas.GetString(1));
                                    Clases.Checadas checadas = new Clases.Checadas();
                                    checadas.registroChecada = lectorChecadas.GetString(1);
                                    _checadas.Add(checadas);
                                }
                            }
                            comandoChecadas.Dispose();
                            empleado.checadas = _checadas;
                            /**/

                           _empleado.Add(empleado);

                        }
                        command.Dispose();
                    }
                    
                }
                

                
                this.conexion.Dispose();
                return _empleado;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw e;

            }
        }
    }
}
