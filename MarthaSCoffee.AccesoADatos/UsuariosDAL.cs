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
        public static List<UsuariosBL> ComboUsuarios()
        {
            string consulta = string.Format("SELECT IDUSUARIO, TIPO_USUARIO, CONTRASEÑA FROM USUARIOS ");


            IDataReader Leer = ComunDB.EjecutarComandoReader(consulta);
            List<UsuariosBL> ListadoUsuarios = new List<UsuariosBL>();
            while (Leer.Read())
            {
                UsuariosBL usuario = new UsuariosBL();
                usuario.IdUsuario = Leer.GetInt32(0);
                usuario.Tipo_Usuario = Leer.GetString(1);
                usuario.Password = Leer.GetString(2);
                ListadoUsuarios.Add(usuario);
            }
            return ListadoUsuarios;
        }
    }
}
