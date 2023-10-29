using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly ProductoBussiness _productoBussiness;

        public ProductoController(ProductoBussiness productoBussiness)
        {
            _productoBussiness = productoBussiness;
        }

        [HttpGet(Name = "GetProductos")]
        public IEnumerable<Producto> Get()
        {
            return _productoBussiness.GetProductos();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Producto nuevoProducto)
        {
            try
            {
                _productoBussiness.CrearProducto(nuevoProducto);
                return CreatedAtRoute("GetProductos", new { id = nuevoProducto.Id }, nuevoProducto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al crear el producto: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Producto producto)
        {
            try
            {
                producto.Id = id;
                _productoBussiness.EditarProducto(producto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al editar el producto: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _productoBussiness.EliminarProducto(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al eliminar el producto: {ex.Message}");
            }
        }

        [HttpGet("{id}", Name = "GetProducto")]
        public IActionResult Get(int id)
        {
            var producto = _productoBussiness.ObtenerProductoPorId(id);
            if (producto == null)
            {
                return NotFound();
            }
            return Ok(producto);
        }
    }
}
