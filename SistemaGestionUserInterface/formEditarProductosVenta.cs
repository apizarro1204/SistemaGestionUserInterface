using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Windows.Forms;

namespace SistemaGestionUserInterface
{
    public partial class formEditarProductosVenta : Form
    {
        private readonly Venta venta;
        private readonly ProductoVendidoBussiness productoVendidoBussiness;

        public formEditarProductosVenta(Venta ventaParametro, ProductoVendidoBussiness productoVendidoBussiness)
        {
            InitializeComponent();
            this.venta = ventaParametro;
            this.productoVendidoBussiness = productoVendidoBussiness;
        }

        private void formEditarProductosVenta_Load(object sender, EventArgs e)
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

        private void btnEliminarProductoVenta_Click(object sender, EventArgs e)
        {
            if (dataGridProductosVenta.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridProductosVenta.SelectedRows[0];
                int idProductoVendido = (int)filaSeleccionada.Cells["Id"].Value;

                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto de la venta?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {

                    ActualizarProductosVenta();

                    MessageBox.Show("Producto eliminado de la venta con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto de la venta para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIconWarning);
            }
        }
    }
}
