using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaSalud.Clases
{
    public class Usuario
    {
        public string id { get; set; }
        public string username { get; set;}
        public string nombre { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public string superUser { get; set; }
        public int unidadSeleccionada { get; set; }
        public List<Unidades> Unidades { get; set; }
    }

    public class Unidades
    {
        public int id { get; set; }
        public string unidad { get; set; }
        public string conexion { get; set; }
        public List<Clues> Clues { get; set; }
    }

    public class Clues
    {
        public int id { get; set; }
        public string clue { get; set; }
    }


}
