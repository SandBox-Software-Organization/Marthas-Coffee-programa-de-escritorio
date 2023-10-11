using System.Data.SqlClient;
using System.Data;
using System;
using MarthaSCoffee.AccesoADatos;

namespace MarthaSCoffee.EntidadesDeNegocios
{
   public class UsuarioDAL:ComunDB
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
                    _comando.CommandText = "select * from USUARIOS where TIPO_USUARIO=@user and PASSWOR=@pass";
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