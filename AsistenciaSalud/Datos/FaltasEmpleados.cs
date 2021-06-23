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

        public async Task<List<Clases.Empleado>> ConsultarUsuario(DataTable listaEmpleados, int anio, int mes)
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
                Console.WriteLine("empleado");

                SqlCommand cmd = new SqlCommand();
                string fecha_inicial = "2021-01-01";
                string fecha_final = "2021-01-31";
                string listaClues = string.Join("','", ListaClues); 
                cmd.CommandText = "SELECT e.id, ea.fecha_hora " +
                    "from empleados e, empleados_nomina en, empleado_asistencia ea " +
                    "where e.rfc= en.rfc and e.id=ea.empleado_id and ea.fecha_hora BETWEEN '" + fecha_inicial + "' and '" + fecha_final + "'" +
                    "and en.clues in ('"+ listaClues + "')  order by e.id, ea.fecha_hora" ;

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
                Console.WriteLine("checadas");

                dr.Close();
                cmd.Dispose();
                
                /*REGISTRAR LOS HORARIOS*/
                SqlCommand cmd_horario = new SqlCommand();
                string query = "SELECT  reh.empleado_id, reh.horario_id, reh.fecha_inicial, reh.fecha_final, ch.descripcion from rel_empleado_horario reh, catalogo_horarios ch " +
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
                    _horario.horario_id = lector_horario.GetInt32(1);
                    _horario.fecha_inicial = lector_horario.GetDateTime(2).ToString("yyyy-MM-dd");
                    _horario.fecha_final = lector_horario.GetDateTime(3).ToString("yyyy-MM-dd");
                    _horario.nombre = lector_horario.GetString(4).ToString();
                    horarios.Add(_horario);
                }
                Console.WriteLine("horarios");
                //_empleado[k].horario = horarios;
                lector_horario.Close();
                cmd_horario.Dispose();
                /**/

                /*REGISTRAR LAS REGLAS*/
                SqlCommand cmd_reglas = new SqlCommand();
                string query_reglas = "SELECT reh.empleado_id, reh.horario_id,  reh.fecha_inicial, reh.fecha_final, reh.orden, rhd.dia_inicio, rhd.dia_fin, rhr.hora_inicio, rhr.hora_fin, rhr.min_tarde, rhr.min_temprano, rhr.entrada_desde, rhr.entrada_hasta, " +
                                        "rhr.salida_desde, rhr.salida_hasta, rhr.dias_trabajo, rhr.min_trabajo from rel_empleado_horario reh, rel_horario_dias rhd, rel_horario_reglas rhr " +
                                        "where rhd.rel_horario_regla_id = rhr.id and reh.horario_id = rhd.horario_id and reh.fecha_inicial <= '" + fecha_inicial + "' and reh.fecha_final >= '" + fecha_final + "'" +
                                        " order by reh.empleado_id, reh.fecha_inicial, reh.horario_id, reh.orden ";

                //Console.WriteLine(query_reglas);
                cmd_reglas.CommandText = query_reglas;
                cmd_reglas.CommandType = CommandType.Text;
                cmd_reglas.Connection = this.conexion;

                SqlDataReader lector_reglas = cmd_reglas.ExecuteReader();

                List<Clases.Reglas> reglas = new List<Clases.Reglas>();

                while (lector_reglas.Read())
                {
                    Clases.Reglas _reglas = new Clases.Reglas();
                    _reglas.empleado_id = long.Parse(lector_reglas.GetInt32(0).ToString());
                    _reglas.horario_id = lector_reglas.GetInt32(1);
                   

                    _reglas.fecha_inicial = lector_reglas.GetDateTime(2).ToString("yyyy-MM-dd");
                    _reglas.fecha_final = lector_reglas.GetDateTime(3).ToString("yyyy-MM-dd");
                    _reglas.orden = lector_reglas.GetInt32(4);
                    _reglas.dia_inicio = lector_reglas.GetInt16(5);
                    _reglas.dia_fin = lector_reglas.GetInt16(6);
                    _reglas.hora_inicio = lector_reglas.GetTimeSpan(7);
                    _reglas.hora_fin = lector_reglas.GetTimeSpan(8);
                    _reglas.min_tarde = lector_reglas.GetInt32(9);
                    _reglas.min_temprano = lector_reglas.GetInt32(10);
                    _reglas.entrada_desde = lector_reglas.GetTimeSpan(11);
                    _reglas.entrada_hasta = lector_reglas.GetTimeSpan(12);
                    _reglas.salida_desde = lector_reglas.GetTimeSpan(13);
                    _reglas.salida_hasta = lector_reglas.GetTimeSpan(14);

                    reglas.Add(_reglas);
                }
                Console.WriteLine("reglas");
                //_empleado[k].horario = horarios;
                lector_reglas.Close();
                cmd_reglas.Dispose();
                
               
                /**/

                /*Reindexar los indices*/
                for (int k = 0; k < _empleado.Count(); k++)
                {
                    /*var listaAsistencia = checadas.Where(item => item.empleado_id == _empleado[k].id).Select(item => item.registroChecada);
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
                    }*/

                    
                    var listahorario = horarios.Where(item => item.empleado_id == _empleado[k].id);

                    List<Clases.Horario> registroHorarios = new List<Clases.Horario>();
                    _empleado[k].horario = registroHorarios;

                    if (listahorario.Count() > 0)
                    {
                        
                        foreach (var horario in listahorario)
                        {
                            Clases.Horario _horario = new Clases.Horario();
                            _horario.empleado_id = _empleado[k].id;
                            _horario.fecha_inicial = horario.fecha_inicial;
                            _horario.fecha_final = horario.fecha_final;
                            _horario.nombre = horario.nombre;
                            

                            //se agregan reglas
                            var listareglas = reglas.Where(item => item.empleado_id == _empleado[k].id).Where(item => item.horario_id == horario.horario_id).Where(item => item.fecha_inicial == horario.fecha_inicial);
                            if(listareglas.Count() > 0)
                            {
                                _horario.reglas = listareglas.ToList();
                            }
                            registroHorarios.Add(_horario);
                     
                        }

                        _empleado[k].horario = registroHorarios;
                    }
                    /*Console.WriteLine(_empleado[k].horario.Count);
                    Console.WriteLine(_empleado[k].horario[0].reglas.Count);
                    foreach(var x in _empleado[k].horario[0].reglas)
                    {
                        Console.WriteLine(x.dia_inicio);
                    }*/

                }
                /**/
                Console.WriteLine("asignacion");
                _empleado = await verificarFaltas(_empleado, fecha_inicial, fecha_final);
              
                this.conexion.Dispose();
                return _empleado;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Data);
                //return _empleado;
                throw e;

            }
        }

        public async Task<List<Clases.Empleado>> verificarFaltas(List<Clases.Empleado> _empleado, string fecha_inicial, string fecha_final)
        {
            DateTime fechaPivote = DateTime.Parse(fecha_inicial);
            DateTime fechaInicial = DateTime.Parse(fecha_inicial);
            DateTime fechaFinal = DateTime.Parse(fecha_final);
            int dias_diferencia = (fechaFinal - fechaInicial).Days;
            
            int indice = 0;

            //Console.WriteLine(_empleado.Count());
            try
            {
                foreach (var empleados in _empleado)
                {
                    int bandera_dias = 0;
                    Clases.Horario horario_trabajador = new Clases.Horario();
                    List<Clases.Registros> registrosTrabajador = new List<Clases.Registros>();
                    int dia = 1;
                    while ((fechaFinal - fechaInicial).Days >= 0)
                    {
                        //Console.WriteLine((byte)fechaInicial.DayOfWeek);
                        byte numerodia = (byte)fechaInicial.DayOfWeek;
                        if(numerodia == 0)
                        {
                            numerodia = 7;
                        }
                        if (bandera_dias == 0)
                        {
                            if(empleados.horario.Count() > 0)
                            {
                                var horario = empleados.horario.Where(item => DateTime.Parse(item.fecha_inicial) <= fechaInicial).Where(item => DateTime.Parse(item.fecha_final) >= fechaFinal).Take(1);
                                if (horario.Count() == 1)
                                {
                                    horario_trabajador = horario.Single();
                                    //Console.WriteLine("reglas"+horario_trabajador.reglas.Count());
                                    bandera_dias = (DateTime.Parse(horario_trabajador.fecha_final) - fechaInicial).Days;
                                }
                            }
                        }
                        

                        //Revisar los registros
                        Clases.Registros registro = new Clases.Registros();
                        registro.dia = dia;

                        
                        if(empleados.horario.Count() > 0)
                        {
                            if (horario_trabajador.reglas != null)
                            {
                                var regla = horario_trabajador.reglas.Where(item => item.dia_inicio == numerodia).Take(1);
                                if (regla.Count() > 0)
                                {
                                    registro.letra = "A";
                                }
                                else
                                {
                                    registro.letra = "";
                                }
                            }
                            else
                            {
                                registro.letra = "S/R";
                            }
                        }
                        else
                        {
                            registro.letra = "S/H";
                        }
                        
                        //registro.letra = "F";
                        registrosTrabajador.Add(registro);
                        //

                        fechaInicial = fechaInicial.AddDays(1);
                        bandera_dias--;
                        dia++;
                    }
                    _empleado[indice].registros = registrosTrabajador;
                    
                    fechaInicial = fechaPivote;
                    indice++;

                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message+" - "+ex.StackTrace);
            }
            return _empleado;
        }
        
    }
}
