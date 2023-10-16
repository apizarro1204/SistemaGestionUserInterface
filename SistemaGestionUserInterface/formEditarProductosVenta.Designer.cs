namespace SistemaGestionUserInterface
{
    partial class formEditarProductosVenta
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
            ((System.ComponentModel.ISupportInitialize)dataGridProductosVenta).BeginInit();
            SuspendLayout();
            // 
            // dataGridProductosVenta
            // 
            dataGridProductosVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProductosVenta.Location = new Point(369, 78);
            dataGridProductosVenta.Name = "dataGridProductosVenta";
            dataGridProductosVenta.RowHeadersWidth = 51;
            dataGridProductosVenta.RowTemplate.Height = 29;
            dataGridProductosVenta.Size = new Size(300, 188);
            dataGridProductosVenta.TabIndex = 0;
            // 
            // formEditarProductosVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridProductosVenta);
            Name = "formEditarProductosVenta";
            Text = "formEditarProductosVenta";
            Load += formEditarProductosVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridProductosVenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridProductosVenta;
    }
}