using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaSalud.Clases
{
    class Faltas
    {
        List<Empleado> _empleado { get; set; }
    }

    class Empleado
    {
        public long id { get; set; }
        public string nombre { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public string rfc { get; set; }
        public string curp { get; set; }
        public string num_empleado { get; set; }
        public string ur { get; set; }
        public string codigo { get; set; }
        public string clues { get; set; }
        public string cr { get; set; }
        public string fecha_ingreso { get; set; }
        public string fecha_ingreso_federal { get; set; }
        public List<Horario> horario { get; set; }
        public List<Incidencias> incidencia { get; set; }
        public List<Checadas> checadas { get; set; }
        public List<Registros> registros { get; set; }
    }


    class Registros
    {
        public long dia { get; set; }
        public string letra { get; set; }
    }

    class Checadas
    {
        public long empleado_id { get; set; }
        public string registroChecada { get; set; }
    }

    class Horario
    {
        public long empleado_id { get; set; }
        public Int32 horario_id { get; set; }
        public string fecha_inicial { get; set; }
        public string fecha_final { get; set; }
        public string nombre { get; set; }
        public List<Reglas> reglas { get; set; }
    }
    
    class Reglas
    {
        public long empleado_id { get; set; }
        public Int32 horario_id { get; set; }
        public string fecha_inicial { get; set; }
        public string fecha_final { get; set; }
        public Int32 orden { get; set; }
        public Int16 dia_inicio { get; set; }
        public Int16 dia_fin { get; set; }
        public TimeSpan hora_inicio { get; set; }
        public TimeSpan hora_fin { get; set; }
        public Int32 min_tarde { get; set; }
        public Int32 min_temprano { get; set; }
        public TimeSpan entrada_desde { get; set; }
        public TimeSpan entrada_hasta { get; set; }
        public TimeSpan salida_desde { get; set; }
        public TimeSpan salida_hasta { get; set; }

    }

    class Incidencias
    {

    }

    class DiasFestivos
    {

    }

    class DiasOtorgados
    {

    }

}
