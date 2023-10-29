using System;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public class RegistroBussiness
    {
        private readonly RegistroData registroData;

        public RegistroBussiness(RegistroData registroData)
        {
            this.registroData = registroData;
        }

        public Usuario RegistrarNuevoUsuario(Usuario nuevoUsuario)
        {
            return registroData.RegistrarNuevoUsuario(nuevoUsuario);
        }


        public Usuario? ObtenerUsuarioPorNombreUsuario(string nombreUsuario)
        {
            return registroData.ObtenerUsuarioPorNombreUsuario(nombreUsuario);
        }


    }
}
