using Azure;
using Microsoft.VisualBasic.Logging;
using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGestionUserInterface
{
    public partial class formEditarVenta : Form
    {
        private readonly Venta venta;
        private readonly VentaBussiness ventaBussiness;

        public formEditarVenta(Venta ventaParametro, VentaBussiness ventaBussiness)
        {
            InitializeComponent();
            this.venta = ventaParametro;
            this.ventaBussiness = ventaBussiness;
        }

        private void formEditarVenta_Load(object sender, EventArgs e)
        {
            if (venta != null)
            {
                if (dgVenta.Columns.Count == 0)
                {
                    dgVenta.Columns.Add("Propiedad", "Propiedad");
                    dgVenta.Columns.Add("Valor", "Valor");
                }

                dgVenta.Rows.Add("Comentarios:", venta.Comentarios);
                dgVenta.Rows.Add("ID de Usuario:", venta.IdUsuario.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nuevoComentario = txtComentario.Text;
            string nuevoIdUsuario = txtIdUsuario.Text;

            if (int.TryParse(nuevoIdUsuario, out int idUsuario))
            {
                venta.Comentarios = nuevoComentario;
                venta.IdUsuario = idUsuario;
            }
            else
            {
                MessageBox.Show("El ID del usuario no es válido. Por favor, ingrese un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnEditarProductosVenta_Click(object sender, EventArgs e)
        {
            using (var formProductosVenta = new formEditarProductosVenta(venta, ventaBussiness))
            {
                formProductosVenta.ShowDialog();
            }
        }
    }
}
