using MarthaSCoffee.EntidadesDeNegocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarthaSCoffee.AccesoADatos
{
    public class UsuariosDAL
    {
        public static List<Usuarios> ComboUsuarios()
        {
            string consulta = string.Format("SELECT IDUSUARIO, TIPO_USUARIO, CONTRASEÑA FROM USUARIOS ");


            IDataReader Leer = ComunDB.EjecutarComandoReader(consulta);
            List<Usuarios> ListadoUsuarios = new List<Usuarios>();
            while (Leer.Read())
            {
                Usuarios usuario = new Usuarios();
                usuario.IdUsuario = Leer.GetInt32(0);
                usuario.Tipo_Usuario = Leer.GetString(1);
                usuario.Password = Leer.GetString(2);
                ListadoUsuarios.Add(usuario);
            }
            return ListadoUsuarios;
        }
    }
}
