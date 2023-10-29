using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatosRegistroController : ControllerBase
    {
        private readonly RegistroBussiness _registroBussiness;

        public DatosRegistroController(RegistroBussiness registroBussiness)
        {
            _registroBussiness = registroBussiness;
        }

        [HttpPost]
        public IActionResult RegistrarUsuario([FromBody] Usuario usuario)
        {
            if (usuario == null)
            {
                return BadRequest("Los datos de registro son nulos.");
            }

            try
            {
                // No encontré un modo de eliminar la advertencia para usuario.NombreUsuario
                var usuarioExistente = _registroBussiness.ObtenerUsuarioPorNombreUsuario(usuario.NombreUsuario);

                if (usuarioExistente != null)
                {
                    return BadRequest("El usuario con el nombre de usuario especificado ya existe.");
                }

                var nuevoUsuario = _registroBussiness.RegistrarNuevoUsuario(usuario);
                return CreatedAtRoute("GetUsuario", new { id = nuevoUsuario.Id }, nuevoUsuario);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al registrar el usuario: {ex.Message}");
            }
        }
    }
}
