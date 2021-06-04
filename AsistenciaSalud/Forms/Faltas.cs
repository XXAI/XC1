using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistenciaSalud.Forms
{
    public partial class Faltas : MetroFramework.Forms.MetroForm
    {
        Clases.Usuario _Usuario;
        DataTable dataGridFaltas = new DataTable(); //Grid Faltas
        SqlConnection _Conexion;

        public Faltas(/*Clases.Usuario _User*/)
        {
            InitializeComponent();
            //this._Usuario = _User;
            ConfigurarGrid();
            configurarCampos();
        }
        
        private void CargarReporte()
        {
            string conexion = "Mario";
            Datos.DatosMaestro conectarBase = new Datos.DatosMaestro();
            conectarBase.DatosConexion(conexion);
            //DatosConexion
        }

        private void configurarCampos()
        {
            Clases.Fechas _meses = new Clases.Fechas();
            comboMeses.DataSource = _meses._Meses();
            comboMeses.DisplayMember = "Mes";
            comboMeses.ValueMember = "Indice";


            Clases.Fechas _anio = new Clases.Fechas();
            comboAnio.DataSource = _meses._Anio();
            comboAnio.DisplayMember = "Anio";
            comboAnio.ValueMember = "Indice";

        }

        private void ConfigurarGrid()
        {
            dataGridFaltas.Columns.Add("AÑO");
            dataGridFaltas.Columns.Add("MES");
            dataGridFaltas.Columns.Add("NOMBRE");
            dataGridFaltas.Columns.Add("RFC");
            for(int i = 1; i <= 31; i++)
            {
                dataGridFaltas.Columns.Add(i.ToString());
            }

            GridFaltas.DataSource = dataGridFaltas;
            GridFaltas.AutoResizeColumns();
            GridFaltas.Columns[0].Width = 50;
            GridFaltas.Columns[1].Width = 80;
            GridFaltas.Columns[3].Width = 95;
            GridFaltas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            for (int i = 1; i <= 31; i++)
            {
                GridFaltas.Columns[i+3].Width = 30;
            }

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Datos.DatosMaestro consultar = new Datos.DatosMaestro();
            this._Conexion = consultar.DatosConexion("Mario");

            Datos.FaltasEmpleados lista = new Datos.FaltasEmpleados(this._Conexion);
            dataGridFaltas.Clear();
            List<Clases.Empleado> empleados = new List<Clases.Empleado>();
            empleados = lista.ConsultarUsuario(this.dataGridFaltas, 2021, 1);
            
            for(int i = 0; i < empleados.Count; i++)
            {
                DataRow row_local = dataGridFaltas.NewRow();
                row_local["AÑO"] = "2021";
                row_local["MES"] = "ENERO";
                row_local["NOMBRE"] = empleados[i].nombre + " " + empleados[i].apellido_paterno + " " + empleados[i].apellido_materno;
                row_local["RFC"] = empleados[i].rfc;
                //Console.WriteLine(reader.GetString(5).ToString());
                dataGridFaltas.Rows.Add(row_local);
            }
            //this.dataGridFaltas.ro
            //empleados = lista.ConsultarUsuario( 2021, 1);
            //dataGridFaltas = lista.ConsultarUsuario(this.dataGridFaltas, 2021, 1);

        }
    }
}
