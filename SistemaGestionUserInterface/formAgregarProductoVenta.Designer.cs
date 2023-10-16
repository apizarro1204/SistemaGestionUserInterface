namespace SistemaGestionUserInterface
{
    partial class formAgregarProductoVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridProductosVenta = new DataGridView();
            btnAgregarProductoVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridProductosVenta).BeginInit();
            SuspendLayout();
            // 
            // dataGridProductosVenta
            // 
            dataGridProductosVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProductosVenta.Location = new Point(418, 87);
            dataGridProductosVenta.Name = "dataGridProductosVenta";
            dataGridProductosVenta.RowHeadersWidth = 51;
            dataGridProductosVenta.RowTemplate.Height = 29;
            dataGridProductosVenta.Size = new Size(300, 188);
            dataGridProductosVenta.TabIndex = 0;
            // 
            // btnAgregarProductoVenta
            // 
            btnAgregarProductoVenta.Location = new Point(81, 286);
            btnAgregarProductoVenta.Name = "btnAgregarProductoVenta";
            btnAgregarProductoVenta.Size = new Size(97, 65);
            btnAgregarProductoVenta.TabIndex = 1;
            btnAgregarProductoVenta.Text = "Agregar Producto";
            btnAgregarProductoVenta.UseVisualStyleBackColor = true;
            // 
            // formAgregarProductoVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregarProductoVenta);
            Controls.Add(dataGridProductosVenta);
            Name = "formAgregarProductoVenta";
            Text = "formAgregarProductoVenta";
            Load += formAgregarProductoVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridProductosVenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridProductosVenta;
        private Button btnAgregarProductoVenta;
    }
}