
using System;

using System.Data;
using System.Data.SqlClient;


namespace MarthaSCoffee.AccesoADatos
{
    public class UsuariosDAL : ComunDB
    {
        public bool LOGIN(String user, String password)
        {
            using (var connection = ObtenerConexion())
            {
                
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (var _comando = new SqlCommand())
                {

                    _comando.Connection = connection;
                    _comando.CommandText = "select * from USUARIOS where TIPO_USUARIO=@user and CONTRASEÑA=@pass";
                    _comando.Parameters.AddWithValue("@user", user);
                    _comando.Parameters.AddWithValue("@pass", password);
                    _comando.CommandType = CommandType.Text;
                    SqlDataReader reader = _comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }

        }
    }
}
