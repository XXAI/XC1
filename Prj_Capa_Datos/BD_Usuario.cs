using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Prj_Capa_Entidad;
using System.Windows.Forms;

namespace Prj_Capa_Datos 
{
    public class BD_Usuario : BD_conexion
    {
        public bool BD_Verificar_Acceso(String Usuario, String Contraseña)
        {
            bool functionReturnValue = false;
            Int32 xfill = 0;

            SqlConnection Cn = new SqlConnection();
            SqlCommand Cmd = new SqlCommand();
            Cn.ConnectionString = Conectar();

            var _with1 = Cmd;

            _with1.CommandText = "Sp_Login";
            _with1.Connection = Cn;
            _with1.CommandTimeout = 20;
            _with1.CommandType = CommandType.StoredProcedure;

            //Parametros de entrada
            _with1.Parameters.AddWithValue("@Usuario", Usuario);
            _with1.Parameters.AddWithValue("@Contraseña", Contraseña);

            Console.WriteLine(Usuario);
            Console.WriteLine(Contraseña);
            try
            {
                Cn.Open();
                xfill = (Int32)Cmd.ExecuteScalar();
                Console.WriteLine(xfill.ToString());
                if(xfill > 0)
                {
                    functionReturnValue = true;
                }
                else
                {
                    functionReturnValue = false;
                }
                Cmd.Parameters.Clear();
                Cmd.Dispose();
                Cmd = null;
                Cn.Close();
                Cn = null;
            }catch(Exception ex)
            {
                if(Cn.State == ConnectionState.Open)
                {
                    Cn.Close();
                }
                Cmd.Dispose();
                Cmd = null;
                Cn.Close();
                Cn = null;
                MessageBox.Show("Algo malo pasó: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return functionReturnValue;
        }
    }
}
