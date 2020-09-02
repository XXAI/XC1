using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Datos
{
    public class BD_conexion
    {
        public string Conectar()
        {
            return @"Data Source=10.10.10.250; Initial Catalog=ZKAccess;uid=sa;pwd=DIABLO0409!!";
        }
    }
    
}
