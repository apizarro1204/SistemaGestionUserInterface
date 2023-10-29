using Microsoft.EntityFrameworkCore;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class RegistroData
    {

        private readonly AppDbContext dbContext;

        public RegistroData(AppDbContext context)
        {
            dbContext = context;
        }
        public Usuario RegistrarNuevoUsuario(Usuario nuevoUsuario)
        {
         
            nuevoUsuario.Nombre ??= "Sin Nombre";
            nuevoUsuario.Apellido ??= "Sin Apellido";
            nuevoUsuario.NombreUsuario ??= "Sin Nombre de usuario";
            nuevoUsuario.Contraseña ??= "Sin Contraseña";

            dbContext.Usuarios.Add(nuevoUsuario);
            dbContext.SaveChanges();

            return nuevoUsuario; 
        }
        public Usuario? ObtenerUsuarioPorNombreUsuario(string nombreUsuario)
        {
            return dbContext.Usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario);
        }


    }
}
