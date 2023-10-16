using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;

namespace SistemaGestionBussiness
{
    public class ProductoVendidoBussiness
    {
        private readonly ProductoVendidoData productoVendidoData;

        public ProductoVendidoBussiness(ProductoVendidoData productoVendidoData)
        {
            this.productoVendidoData = productoVendidoData;
        }

        public void RegistrarVenta(int idProducto, int stockVendido, int idVenta)
        {

            productoVendidoData.AgregarProductoVendido(idProducto, stockVendido, idVenta);
        }

        public List<ProductoVendido> ObtenerProductosVendidosPorVenta(int idVenta)
        {
            return productoVendidoData.ObtenerProductosVendidosPorVenta(idVenta);
        }

        public List<ProductoVendido> ObtenerProductosDeVenta(int idVenta)
        {
            return productoVendidoData.ObtenerProductosDeVenta(idVenta);
        }
    }
}
