using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaSalud.Clases
{
    class Fechas
    {
        public String NombreMes(int indice)
        {
            string[] meses = { "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE" };
            return meses[indice].ToString();
        }

        public String[] TodosMeses()
        {
            string[] meses = { "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE" };
            return meses;
        }

        public List<mes> _Meses()
        {
            List<mes> MesesAnio = new List<mes>();
            MesesAnio.Add(new mes() { Indice = 1, Mes = "ENERO" });
            MesesAnio.Add(new mes() { Indice = 2, Mes = "FEBRERO" });
            MesesAnio.Add(new mes() { Indice = 3, Mes = "MARZO" });
            MesesAnio.Add(new mes() { Indice = 4, Mes = "ABRIL" });
            MesesAnio.Add(new mes() { Indice = 5, Mes = "MAYO" });
            MesesAnio.Add(new mes() { Indice = 6, Mes = "JUNIO" });
            MesesAnio.Add(new mes() { Indice = 7, Mes = "JULIO" });
            MesesAnio.Add(new mes() { Indice = 8, Mes = "AGOSTO" });
            MesesAnio.Add(new mes() { Indice = 9, Mes = "SEPTIEMBRE" });
            MesesAnio.Add(new mes() { Indice = 10, Mes = "OCTUBRE" });
            MesesAnio.Add(new mes() { Indice = 11, Mes = "NOVIEMBRE" });
            MesesAnio.Add(new mes() { Indice = 12, Mes = "DICIEMBRE" });

            return MesesAnio;
        }

        public List<anio> _Anio()
        {
            List<anio> Anio = new List<anio>();
            Anio.Add(new anio() { Indice = 2020, Anio = 2020 });
            Anio.Add(new anio() { Indice = 2021, Anio = 2021 });
            Anio.Add(new anio() { Indice = 2022, Anio = 2022 });


            return Anio;
        }
    }

    class anio
    {
        public int Indice { get; set; }
        public int Anio { get; set; }
    }

    class mes
    {
        public int Indice { get; set; }
        public string Mes { get; set; }
    }
}
