using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Windows.Forms;

namespace SistemaGestionUserInterface
{
    public partial class formAgregarProductoVenta : Form
    {
        private readonly Venta venta;
        private readonly VentaBussiness ventaBussiness;
        private readonly ProductoVendidoBussiness productoVendidoBussiness;


        public formAgregarProductoVenta(Venta ventaParametro, VentaBussiness ventaBussiness, ProductoVendidoBussiness productoVendidoBussiness)
        {
            InitializeComponent();
            this.venta = ventaParametro;
            this.ventaBussiness = ventaBussiness;
            this.productoVendidoBussiness = productoVendidoBussiness;
        }
        private void formAgregarProductoVenta_Load(object sender, EventArgs e)
        {
            ActualizarProductosVenta();
        }

        private void ActualizarProductosVenta()
        {
            if (venta != null)
            {
                var productosVenta = productoVendidoBussiness.ObtenerProductosDeVenta(venta.Id);
                dataGridProductosVenta.DataSource = productosVenta;
            }
        }
        private void btnAgregarProductoVenta_Click(object sender, EventArgs e)
        {
            // Implementa la lógica para agregar productos a la venta y actualiza el DataGridView en formEditarProductosVenta.
        }

        // Otros métodos para agregar productos a la venta, como seleccionar productos disponibles, etc.
    }
}
