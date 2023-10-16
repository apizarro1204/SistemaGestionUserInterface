using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public class VentaData
    {
        private readonly AppDbContext dbContext;

        public VentaData(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Venta> GetVentas()
        {
            return dbContext.Ventas.ToList();
        }

        public Venta? ObtenerVentaPorId(int id)
        {
            return dbContext.Ventas.FirstOrDefault(venta => venta.Id == id);
        }

        public Venta CrearVenta(Venta nuevaVenta)
        {
            dbContext.Ventas.Add(nuevaVenta);
            dbContext.SaveChanges();
            return nuevaVenta;
        }

        public void ActualizarVenta(Venta venta)
        {
            if (venta == null)
            {
                throw new ArgumentNullException(nameof(venta));
            }

            dbContext.Ventas.Update(venta);
            dbContext.SaveChanges();
        }

        public void EliminarVenta(int id)
        {
            var venta = dbContext.Ventas.FirstOrDefault(v => v.Id == id);
            if (venta != null)
            {
                dbContext.Ventas.Remove(venta);
                dbContext.SaveChanges();
            }
        }

    }
}
