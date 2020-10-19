using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistenciaSalud.Negocio
{
    public static class AutoCompleClues
    {
        //metodo para cargar los datos de la bd
        public static DataTable Datos()
        {
            DataTable dt = new DataTable();

            Datos.DatosSirh consultar = new Datos.DatosSirh();
           
            return consultar.ConsultarClues();
        }

        //metodo para cargar la coleccion de datos para el autocomplete
        public static AutoCompleteStringCollection Autocomplete()
        {
            DataTable dt = Datos();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                //coleccion.Add(Convert.ToString(row["Razon_social"]));
                coleccion.Add(Convert.ToString(row["clues"]));
                coleccion.Add(Convert.ToString(row["nombre_unidad"]));
            }

            return coleccion;
        }
    }
}
