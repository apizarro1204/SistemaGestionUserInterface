using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginBussiness _loginBussiness;

        public LoginController(LoginBussiness loginBussiness)
        {
            _loginBussiness = loginBussiness;
        }

        [HttpPost]
        public IActionResult Autenticar([FromBody] Login request)
        {
            if (request == null)
            {
                return BadRequest("Los datos de inicio de sesión son nulos.");
            }

            try
            {
                // Acá tampoco encontré una forma de eliminar las advertencias para request.NombreUsuario. 
                var usuarioAutenticado = _loginBussiness.AutenticarUsuario(request.NombreUsuario, request.Contrasena);

                if (usuarioAutenticado == null)
                {
                    return BadRequest("Credenciales incorrectas. Por favor, verifique su nombre de usuario y contraseña.");
                }

                return Ok("Autenticación exitosa");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al autenticar: {ex.Message}");
            }
        }
    }
}
