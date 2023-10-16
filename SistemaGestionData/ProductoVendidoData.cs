using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public class ProductoVendidoData
    {
        private readonly AppDbContext dbContext;

        public ProductoVendidoData(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AgregarProductoVendido(int idProducto, int stockVendido, int idVenta)
        {
            ProductoVendido productoVendido = new ProductoVendido
            {
                IdProducto = idProducto,
                Stock = stockVendido,
                IdVenta = idVenta
            };

            dbContext.ProductosVendidos.Add(productoVendido);
            dbContext.SaveChanges();
        }

        public List<ProductoVendido> ObtenerProductosVendidosPorVenta(int idVenta)
        {
            return dbContext.ProductosVendidos
                .Where(pv => pv.IdVenta == idVenta)
                .ToList();
        }

        public List<ProductoVendido> ObtenerProductosDeVenta(int idVenta)
        {
            return dbContext.ProductosVendidos.Where(pv => pv.IdVenta == idVenta).ToList();
        }

    }
}
