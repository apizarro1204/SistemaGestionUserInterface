using System;
using System.Collections.Generic;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public class VentaBussiness
    {
        private readonly VentaData ventaData;

        public VentaBussiness(VentaData ventaData)
        {
            this.ventaData = ventaData;
        }

        public Venta CrearVenta(string comentarios, int idUsuario)
        {
            Venta nuevaVenta = new Venta
            {
                Comentarios = comentarios,
                IdUsuario = idUsuario
            };

            return ventaData.CrearVenta(nuevaVenta);
        }

        public List<Venta> GetVentas()
        {
            return ventaData.GetVentas();
        }

        public Venta? ObtenerVentaPorId(int id)
        {
            return ventaData.ObtenerVentaPorId(id);
        }
    }
}
