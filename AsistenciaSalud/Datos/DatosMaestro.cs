using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;


namespace AsistenciaSalud.Datos
{
    class DatosMaestro
    {
        private SqlConnection conexion;
        string cadenaConeccion;
        public DatosMaestro()
        { 
        }

        public void DatosMaestra()
        {
            try
            {
                ConnectionStringSettingsCollection settings =
                ConfigurationManager.ConnectionStrings;

                if (settings != null)
                {
                    foreach (ConnectionStringSettings cs in settings)
                    {

                        if (cs.Name == "AsistenciaSalud.Properties.Settings.Maestra")
                        {
                            cadenaConeccion = cs.ConnectionString;
                        }
                    }
                }

                conexion = new SqlConnection();
                conexion.ConnectionString = cadenaConeccion;
                conexion.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlConnection DatosConexion(string _Conexion)
        {
            try
            {
                ConnectionStringSettingsCollection settings =
                ConfigurationManager.ConnectionStrings;

                if (settings != null)
                {
                    foreach (ConnectionStringSettings cs in settings)
                    {

                        if (cs.Name == "AsistenciaSalud.Properties.Settings."+ _Conexion)
                        {
                            cadenaConeccion = cs.ConnectionString;
                        }
                    }
                }

                conexion = new SqlConnection();
                conexion.ConnectionString = cadenaConeccion;
                return conexion;
                //conexion.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #region usuarios
        public DataTable ConsultarUsuario_down(SqlConnection _conexion , String usuario, string password)
        {
            try
            {
                DataTable tabla = new DataTable();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@password", hash(password));

                String cadenasql = "ConsultarUsuario";
                cmd.Connection = _conexion;
                cmd.CommandText = cadenasql;
                cmd.CommandType = CommandType.StoredProcedure;


                adapter.SelectCommand = cmd;
                adapter.Fill(tabla);

                cmd.Dispose();
                adapter.Dispose();
                conexion.Dispose();
                return tabla;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Clases.Usuario ConsultarUsuario(SqlConnection _conexion, String usuario, string password)
        {
            long id = 0;
            _conexion.Open();
            try
            {
                
                Clases.Usuario _usuario = new Clases.Usuario();
                
                String cadenasql = "ConsultarUsuario";

                SqlCommand command = new SqlCommand(cadenasql, _conexion);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@password", hash(password));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt64(0);
                        _usuario.id = reader.GetInt64(0).ToString();
                        _usuario.username = reader.GetString(1).ToString();
                        _usuario.nombre = reader.GetString(4).ToString();
                        _usuario.apellido_paterno = reader.GetString(5).ToString();
                        _usuario.apellido_materno = reader.GetString(6).ToString();
                        _usuario.superUser = reader.GetString(8).ToString();

                    }
                }
                
                command.Dispose();

                if (id != 0)
                {
                    // Crear lista de conexiones unidades
                    String cadenaUnidades = "usuarioUnidad";

                    SqlCommand commandUnidades = new SqlCommand(cadenaUnidades, this.conexion);
                    commandUnidades.CommandType = CommandType.StoredProcedure;

                    commandUnidades.Parameters.AddWithValue("@idusuario", id.ToString());
                    List<Clases.Unidades> _unidades = new List<Clases.Unidades>();
                    using (SqlDataReader readerUnidades = commandUnidades.ExecuteReader())
                    {
                        
                        while (readerUnidades.Read())
                        {
                            Clases.Unidades _unidad = new Clases.Unidades();
                            _unidad.id = readerUnidades.GetInt32(0);
                            _unidad.unidad = readerUnidades.GetString(1).ToString();
                            _unidad.conexion = readerUnidades.GetString(2).ToString();
                            _unidades.Add(_unidad);

                        }
                    }
                    commandUnidades.Dispose();
                    _usuario.Unidades = _unidades;
                    
                    if(_usuario.Unidades.Count > 0)
                    {
                        // Crear lista de clues
                        String cadenaClues = "UnidadClue";
                        SqlCommand commandClues = new SqlCommand(cadenaClues, this.conexion);
                        commandClues.CommandType = CommandType.StoredProcedure;

                        //Console.WriteLine(_usuario.Unidades[0].Clues);
                        List<Clases.Clues> _clues = new List<Clases.Clues>();
                        for (int i = 0; i < _usuario.Unidades.Count; i++)
                        {
                            commandClues.Parameters.AddWithValue("@unidad", _usuario.Unidades[i].id);
                            using (SqlDataReader readerClues = commandClues.ExecuteReader())
                            {
                                while (readerClues.Read())
                                {
                                    Clases.Clues _clue = new Clases.Clues();
                                    _clue.id = readerClues.GetInt32(0);
                                    _clue.clue = readerClues.GetString(1).ToString();

                                    _clues.Add(_clue);

                                }
                            }
                        }
                        _usuario.Unidades[0].Clues = _clues;
                        commandClues.Dispose();
                    }
                }
                _conexion.Dispose();
                return _usuario;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw e;
                
            }
        }

        public int EliminarUsuario(String id)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.AddWithValue("@id",Convert.ToInt32( id));

            string cadenasql = "EliminarUsuario";

            cmd.CommandText = cadenasql;
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;

            int dato = Convert.ToInt32(cmd.ExecuteNonQuery());
            cmd.Dispose();
            return dato;
        }

        public int InsertarUsuario(String username, String password, String email,string nombre,string apellidopaterno,string apellidomaterno, string alias, bool activo, string clue)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", hash(password));
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellidopaterno", apellidopaterno);
                cmd.Parameters.AddWithValue("@apellidomaterno", apellidomaterno);
                cmd.Parameters.AddWithValue("@alias", alias);
                cmd.Parameters.AddWithValue("@activo", activo);
                cmd.Parameters.AddWithValue("@clue", clue);



                String cadenasql = "InsertarUsuario";
                cmd.Connection = conexion;
                cmd.CommandText = cadenasql;
                cmd.CommandType = CommandType.StoredProcedure;


                adapter.SelectCommand = cmd;
                int dato = Convert.ToInt32(cmd.ExecuteNonQuery());
                cmd.Dispose();
                return dato;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public int ModificarUsuario(String username, String password, String email, string nombre, string apellidopaterno, string apellidomaterno, string alias, bool activo, string clue, string id, int bandera)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string temp = hash(password);

                cmd.Parameters.AddWithValue("@username", username);
                if (bandera == 1)
                    cmd.Parameters.AddWithValue("@password", temp);
                else
                    cmd.Parameters.AddWithValue("@password", password);

                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellidopaterno", apellidopaterno);
                cmd.Parameters.AddWithValue("@apellidomaterno", apellidomaterno);
                cmd.Parameters.AddWithValue("@alias", alias);
                cmd.Parameters.AddWithValue("@activo", activo);
                cmd.Parameters.AddWithValue("@clue", clue);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));



                String cadenasql = "ModificarUsuario";
                cmd.Connection = conexion;
                cmd.CommandText = cadenasql;
                cmd.CommandType = CommandType.StoredProcedure;


                adapter.SelectCommand = cmd;
                int dato = Convert.ToInt32(cmd.ExecuteNonQuery());
                cmd.Dispose();
                return dato;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        #endregion

        #region Permisos
        public int EliminarPermiso(String id)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.AddWithValue("@id", id);

            string cadenasql = "EliminarPermiso";

            cmd.CommandText = cadenasql;
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;

            int dato = Convert.ToInt32(cmd.ExecuteNonQuery());
            cmd.Dispose();
            return dato;
        }

        public int EliminarTodosPermisos(String id)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));

            string cadenasql = "EliminarTodosPermisos";

            cmd.CommandText = cadenasql;
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;

            int dato = Convert.ToInt32(cmd.ExecuteNonQuery());
            cmd.Dispose();
            return dato;
        }

        public int InsertarPermisoUsuario(String permiso, String iduser)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();

                cmd.Parameters.AddWithValue("@permiso", permiso);
                cmd.Parameters.AddWithValue("@userid", iduser);
              



                String cadenasql = "InsertarPermisoUsuario";
                cmd.Connection = conexion;
                cmd.CommandText = cadenasql;
                cmd.CommandType = CommandType.StoredProcedure;


                adapter.SelectCommand = cmd;
                int dato = Convert.ToInt32(cmd.ExecuteNonQuery());
                cmd.Dispose();
                return dato;
            }
            catch (Exception e)
            {

                throw e;
            }
        }


        public int InsertarPermiso(String idpermiso, String descripcion, String grupo)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();

                cmd.Parameters.AddWithValue("@id", idpermiso);
                cmd.Parameters.AddWithValue("@descripcion",descripcion);
                cmd.Parameters.AddWithValue("@rupo", grupo);
                


                String cadenasql = "InsertarPermiso";
                cmd.Connection = conexion;
                cmd.CommandText = cadenasql;
                cmd.CommandType = CommandType.StoredProcedure;


                adapter.SelectCommand = cmd;
                int dato = Convert.ToInt32(cmd.ExecuteNonQuery());
                cmd.Dispose();
                return dato;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public int ModificarPermiso(String idpermiso, String descripcion, String grupo)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();

                cmd.Parameters.AddWithValue("@id", idpermiso);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@grupo", grupo);



                String cadenasql = "ModificarPermiso";
                cmd.Connection = conexion;
                cmd.CommandText = cadenasql;
                cmd.CommandType = CommandType.StoredProcedure;


                adapter.SelectCommand = cmd;
                int dato = Convert.ToInt32(cmd.ExecuteNonQuery());
                cmd.Dispose();
                return dato;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public DataTable ConsultarPermisosUsurio(String idusuario)
        {
            try
            {
                DataTable tabla = new DataTable();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();

                cmd.Parameters.AddWithValue("@idusuario", Convert.ToInt32(idusuario));
              

                String cadenasql = "ConsultarPermisosUsuario";
                cmd.Connection = conexion;
                cmd.CommandText = cadenasql;
                cmd.CommandType = CommandType.StoredProcedure;


                adapter.SelectCommand = cmd;
                adapter.Fill(tabla);

                cmd.Dispose();
                adapter.Dispose();
                conexion.Dispose();
                return tabla;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        #endregion

        #region clues

        public int InsertarClues(String descripcion, String ruta, String clues)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();

                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@ruta", ruta);
                cmd.Parameters.AddWithValue("@clues", clues);



                String cadenasql = "InsertarClues";
                cmd.Connection = conexion;
                cmd.CommandText = cadenasql;
                cmd.CommandType = CommandType.StoredProcedure;


                adapter.SelectCommand = cmd;
                int dato = Convert.ToInt32(cmd.ExecuteNonQuery());
                cmd.Dispose();
                return dato;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public int ModificarClues(String descripcion, String ruta, String clues,string idclue)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();

                cmd.Parameters.AddWithValue("@id", idclue);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@ruta", ruta);
                cmd.Parameters.AddWithValue("@clues", clues);



                String cadenasql = "ModificarClues";
                cmd.Connection = conexion;
                cmd.CommandText = cadenasql;
                cmd.CommandType = CommandType.StoredProcedure;


                adapter.SelectCommand = cmd;
                int dato = Convert.ToInt32(cmd.ExecuteNonQuery());
                cmd.Dispose();
                return dato;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public int EliminarClue(String id)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));

            string cadenasql = "EliminarClue";

            cmd.CommandText = cadenasql;
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;

            int dato = Convert.ToInt32(cmd.ExecuteNonQuery());
            cmd.Dispose();
            return dato;
        }

        #endregion

        #region encrypt
        public string hash(string password)
        {

            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(password));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        #endregion
    }
}
