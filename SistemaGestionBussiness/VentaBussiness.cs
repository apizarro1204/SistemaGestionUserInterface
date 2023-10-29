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
        public Venta CrearVenta(Venta nuevaVenta)
        {
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

        public void ActualizarVenta(Venta venta)
        {
            ventaData.ActualizarVenta(venta);
        }

        public void EliminarVenta(int id)
        {
            ventaData.EliminarVenta(id);
        }
    }
}
