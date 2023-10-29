using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly VentaBussiness _ventaBussiness;

        public VentaController(VentaBussiness ventaBussiness)
        {
            _ventaBussiness = ventaBussiness;
        }

        [HttpGet(Name = "GetVentas")]
        public IEnumerable<Venta> Get()
        {
            return _ventaBussiness.GetVentas();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Venta nuevaVenta)
        {
            try
            {
                _ventaBussiness.CrearVenta(nuevaVenta);
                return CreatedAtRoute("GetVentas", new { id = nuevaVenta.Id }, nuevaVenta);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al crear la venta: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Venta venta)
        {
            try
            {
                venta.Id = id; 
                _ventaBussiness.ActualizarVenta(venta);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al editar la venta: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _ventaBussiness.EliminarVenta(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al eliminar la venta: {ex.Message}");
            }
        }

        [HttpGet("{id}", Name = "GetVenta")]
        public IActionResult Get(int id)
        {
            var venta = _ventaBussiness.ObtenerVentaPorId(id);
            if (venta == null)
            {
                return NotFound();
            }
            return Ok(venta);
        }
    }
}
