using Microsoft.EntityFrameworkCore;
using SistemaGestionEntities;
using System.Linq;

namespace SistemaGestionData
{
    public class LoginData
    {
        private readonly AppDbContext dbContext;

        public LoginData(AppDbContext context)
        {
            dbContext = context;
        }

        public Usuario? AutenticarUsuario(string nombreUsuario, string contrasena)
        {
            return dbContext.Usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario && u.Contraseña == contrasena);
        }
    }
}
