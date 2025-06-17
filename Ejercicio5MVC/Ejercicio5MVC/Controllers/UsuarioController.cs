using Models;
using Views;

namespace Controllers
{
    internal class UsuarioController
    {
        public Usuario CargarUsuario()
        {
            return UsuarioView.CargarUsuario();
        }

        public void MostrarUsuario(Usuario usuario)
        {
            UsuarioView.MostrarUsuario(usuario);
        }
    }
}