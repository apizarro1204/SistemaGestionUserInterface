using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioBussiness _usuarioBussiness;

        public UsuarioController(UsuarioBussiness usuarioBussiness)
        {
            _usuarioBussiness = usuarioBussiness;
        }

        [HttpGet(Name = "GetUsuario")]
        public IEnumerable<Usuario> Get()
        {
            var usuarios = _usuarioBussiness.GetUsuarios();
            return usuarios.ToArray();
        }

        [HttpPost(Name = "CrearUsuario")]
        public IActionResult CrearUsuario([FromBody] Usuario nuevoUsuario)
        {
            try
            {
                if (nuevoUsuario == null)
                {
                    return BadRequest("Los datos del usuario son nulos.");
                }

                _usuarioBussiness.CrearUsuario(nuevoUsuario);

                return CreatedAtRoute("GetUsuario", new { id = nuevoUsuario.Id }, nuevoUsuario);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor: " + ex.Message);
            }
        }

        [HttpPut("{id}", Name = "ActualizarUsuario")]
        public IActionResult ActualizarUsuario(int id, [FromBody] Usuario usuario)
        {
            try
            {
                if (usuario == null)
                {
                    return BadRequest("Los datos del usuario son nulos.");
                }

                var usuarioExistente = _usuarioBussiness.ObtenerUsuarioPorId(id);

                if (usuarioExistente == null)
                {
                    return NotFound("Usuario no encontrado.");
                }

                usuario.Id = id;
                _usuarioBussiness.EditarUsuario(usuario);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor: " + ex.Message);
            }
        }

        [HttpDelete("{id}", Name = "EliminarUsuario")]
        public IActionResult EliminarUsuario(int id)
        {
            try
            {
                var usuario = _usuarioBussiness.ObtenerUsuarioPorId(id);

                if (usuario == null)
                {
                    return NotFound("Usuario no encontrado.");
                }

                _usuarioBussiness.EliminarUsuario(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor: " + ex.Message);
            }
        }
    }
}
