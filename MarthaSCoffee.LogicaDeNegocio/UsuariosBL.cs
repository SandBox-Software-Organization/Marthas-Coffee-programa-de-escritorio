using MarthaSCoffee.AccesoADatos;
using MarthaSCoffee.EntidadesDeNegocios;
namespace MarthaSCoffee.LogicaDeNegocio
{
    public class UsuariosBL
    {
        UsuarioDAL UsuarioDAL = new UsuarioDAL();
        public bool LOGINUSER(string user, string pass)
        {
            return UsuarioDAL.LOGIN(user, pass);
        }

     
            
    }
}
