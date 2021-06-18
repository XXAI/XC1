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
                int resultado = 0;
                for (int i = 0; i < ListaClues.Count(); i++)
                {
                    //Console.WriteLine("Clues "+i);
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
                            _empleado.Add(empleado);
                            resultado++;
                            //Console.WriteLine(resultado);
                        }
                        reader.Close();
                    }
                    command.Dispose();
                } 

                SqlCommand cmd = new SqlCommand();
                string fecha_inicial = "2021-01-01";
                string fecha_final = "2021-01-31";
                string listaClues = string.Join("','", ListaClues); 
                cmd.CommandText = "SELECT e.id, ea.fecha_hora " +
                    "from empleados e, empleados_nomina en, empleado_asistencia ea " +
                    "where e.rfc= en.rfc and e.id=ea.empleado_id and ea.fecha_hora BETWEEN '" + fecha_inicial + "' and '" + fecha_final + "'" +
                    "and en.clues in ('"+ listaClues + "') order by e.id, ea.fecha_hora" ;

                cmd.CommandType = CommandType.Text;
                cmd.Connection = this.conexion;
                SqlDataReader dr = cmd.ExecuteReader();

                List<Clases.Checadas> checadas = new List<Clases.Checadas>();

                while (dr.Read())
                {
                    Clases.Checadas _checadas = new Clases.Checadas();
                    _checadas.empleado_id = long.Parse(dr.GetInt32(0).ToString()); 
                    _checadas.registroChecada = dr.GetDateTime(1).ToString("yyyy-MM-dd");
                    checadas.Add(_checadas);                    
                }

                dr.Close();
                cmd.Dispose();
                
                for (int k = 0; k < _empleado.Count(); k++)
                {
                    var listaAsistencia = checadas.Where(item => item.empleado_id == _empleado[k].id).Select(item => item.registroChecada);
                    if(listaAsistencia.Count() > 0)
                    {
                        List<Clases.Checadas> registroChecadas = new List<Clases.Checadas>();
                        foreach (var registro in listaAsistencia)
                        {
                            Clases.Checadas _registroChecadas = new Clases.Checadas();
                            _registroChecadas.empleado_id = _empleado[k].id;
                            _registroChecadas.registroChecada = registro;
                            registroChecadas.Add(_registroChecadas);
                        }

                        _empleado[k].checadas = registroChecadas;
                    }
                }

                /*REGISTRAR LOS HORARIOS*/
                SqlCommand cmd_horario = new SqlCommand();
                string query = "SELECT reh.empleado_id, reh.fecha_inicial, reh.fecha_final, ch.descripcion from rel_empleado_horario reh, catalogo_horarios ch " +
                                            "where reh.horario_id = ch.id " +
                                            "and reh.fecha_inicial <= '" + fecha_inicial + "' and reh.fecha_final >= '" + fecha_final + "'";

                cmd_horario.CommandText = query;
                //Console.WriteLine(query);
                cmd_horario.CommandType = CommandType.Text;
                cmd_horario.Connection = this.conexion;

                SqlDataReader lector_horario = cmd_horario.ExecuteReader();

                List<Clases.Horario> horarios = new List<Clases.Horario>();

                while (lector_horario.Read())
                {
                    Clases.Horario _horario = new Clases.Horario();
                    _horario.empleado_id = long.Parse(lector_horario.GetInt32(0).ToString());
                    _horario.fecha_inicial = lector_horario.GetDateTime(1).ToString("yyyy-MM-dd");
                    _horario.fecha_final = lector_horario.GetDateTime(2).ToString("yyyy-MM-dd");
                    _horario.nombre = lector_horario.GetString(3).ToString();
                    horarios.Add(_horario);
                }
                //_empleado[k].horario = horarios;
                lector_horario.Close();
                cmd_horario.Dispose();
                /**/

                /*REGISTRAR LAS REGLAS*/
                SqlCommand cmd_reglas = new SqlCommand();
                string query_reglas = "SELECT reh.empleado_id, reh.horario_id, reh.orden, rhd.dia_inicio, rhd.dia_fin, rhr.hora_inicio, rhr.hora_fin, rhr.min_tarde, rhr.min_temprano, rhr.entrada_desde, rhr.entrada_hasta, " +
                                        "rhr.salida_desde, rhr.salida_hasta, rhr.dias_trabajo, rhr.min_trabajo from rel_empleado_horario reh, rel_horario_dias rhd, rel_horario_reglas rhr " +
                                        "where rhd.rel_horario_regla_id = rhr.id and reh.horario_id = rhd.horario_id reh.fecha_inicial <= '" + fecha_inicial + "' and reh.fecha_final >= '" + fecha_final + "'" +
                                        "order by reh.empleado_id, reh.fecha_inicial, reh.horario_id, reh.orden ";


                cmd_reglas.CommandText = query_reglas;
                cmd_reglas.CommandType = CommandType.Text;
                cmd_reglas.Connection = this.conexion;

                SqlDataReader lector_reglas = cmd_reglas.ExecuteReader();

                List<Clases.Reglas> reglas = new List<Clases.Reglas>();

                while (lector_reglas.Read())
                {
                    Clases.Reglas _reglas = new Clases.Reglas();
                    _reglas.empleado_id = long.Parse(lector_horario.GetInt32(0).ToString());
                    _reglas.horario_id = lector_horario.GetString(1);
                    _reglas.orden = lector_horario.GetString(2);
                    _reglas.dia_inicio = lector_horario.GetInt32(3);
                    _reglas.dia_fin = lector_horario.GetInt32(4);
                    _reglas.hora_inicio = lector_horario.GetString(5);
                    _reglas.hora_fin = lector_horario.GetString(6);
                    _reglas.min_tarde = lector_horario.GetInt32(7);
                    _reglas.min_temprano = lector_horario.GetInt32(8);
                    _reglas.entrada_desde = lector_horario.GetString(9);
                    _reglas.entrada_hasta = lector_horario.GetString(10);
                    _reglas.salida_desde = lector_horario.GetString(11);
                    _reglas.salida_hasta = lector_horario.GetString(12);

                    reglas.Add(_reglas);
                }
                //_empleado[k].horario = horarios;
                lector_reglas.Close();
                cmd_reglas.Dispose();
                /**/




                /*cmd.CommandType = CommandType.Text;
                cmd.Connection = this.conexion;
                SqlDataReader dr = cmd.ExecuteReader();

                List<Clases.Checadas> checadas = new List<Clases.Checadas>();

                while (dr.Read())
                {
                    Clases.Checadas _checadas = new Clases.Checadas();
                    _checadas.empleado_id = long.Parse(dr.GetInt32(0).ToString());
                    _checadas.registroChecada = dr.GetDateTime(1).ToString("yyyy-MM-dd");
                    checadas.Add(_checadas);
                }

                for (int k = 0; k < _empleado.Count(); k++)
                {
                    var listaAsistencia = checadas.Where(item => item.empleado_id == _empleado[k].id).Select(item => item.registroChecada);
                    if (listaAsistencia.Count() > 0)
                    {
                        List<Clases.Checadas> registroChecadas = new List<Clases.Checadas>();
                        foreach (var registro in listaAsistencia)
                        {
                            Clases.Checadas _registroChecadas = new Clases.Checadas();
                            _registroChecadas.empleado_id = _empleado[k].id;
                            _registroChecadas.registroChecada = registro;
                            registroChecadas.Add(_registroChecadas);
                        }

                        _empleado[k].checadas = registroChecadas;
                    }
                }

                dr.Close();
                cmd.Dispose();*/

                this.conexion.Dispose();
                return _empleado;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;

            }
        }

        
    }
}
