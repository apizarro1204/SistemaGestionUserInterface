using System.Collections.Generic;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public class ProductoBussiness
    {
        private readonly ProductoData productoData;

        public ProductoBussiness(ProductoData productoData)
        {
            this.productoData = productoData;
        }

        public List<Producto> GetProductos()
        {
            // Puedes agregar lógica adicional aquí si es necesario
            return productoData.GetProductos();
        }

        public void CrearProducto(Producto nuevoProducto)
        {
            // Puedes agregar lógica de negocio relacionada con la creación de productos aquí si es necesario
            productoData.CrearProducto(nuevoProducto);
        }

        public void EditarProducto(Producto producto)
        {
            // Puedes agregar lógica de negocio relacionada con la edición de productos aquí si es necesario
            productoData.EditarProducto(producto);
        }

        public void EliminarProducto(int id)
        {
            // Puedes agregar lógica de negocio relacionada con la eliminación de productos aquí si es necesario
            productoData.EliminarProducto(id);
        }
    }
}
