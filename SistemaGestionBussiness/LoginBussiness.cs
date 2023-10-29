using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public class LoginBussiness
    {
        private readonly LoginData loginData;

        public LoginBussiness(LoginData loginData)
        {
            this.loginData = loginData;
        }

        public Usuario? AutenticarUsuario(string nombreUsuario, string contrasena)
        {
            return loginData.AutenticarUsuario(nombreUsuario, contrasena);
        }
    }
}

