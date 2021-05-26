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
        string nombre { get; set; }
        string apellido_paterno { get; set; }
        string apellido_materno { get; set; }
        string rfc { get; set; }
        string curp { get; set; }
        string num_empleado { get; set; }
        List<Horario> horario { get; set; }
        List<Incidencias> incidencia { get; set; }
    }

    class Horario
    {
        List<Reglas> Reglas { get; set; }
    }
    
    class Reglas
    {

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
