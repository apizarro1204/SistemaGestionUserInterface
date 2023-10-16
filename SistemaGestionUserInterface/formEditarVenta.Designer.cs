namespace SistemaGestionUserInterface
{
    partial class formEditarVenta
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
            dgVenta = new DataGridView();
            txtComentario = new RichTextBox();
            txtIdUsuario = new TextBox();
            btnGuardar = new Button();
            btnBorrar = new Button();
            btnCancelar = new Button();
            btnEditarProductosVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)dgVenta).BeginInit();
            SuspendLayout();
            // 
            // dgVenta
            // 
            dgVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVenta.Location = new Point(352, 59);
            dgVenta.Name = "dgVenta";
            dgVenta.RowHeadersWidth = 51;
            dgVenta.RowTemplate.Height = 29;
            dgVenta.Size = new Size(399, 321);
            dgVenta.TabIndex = 0;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(56, 59);
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(241, 119);
            txtComentario.TabIndex = 1;
            txtComentario.Text = "";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(56, 239);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(125, 27);
            txtIdUsuario.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(56, 316);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(56, 351);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(56, 386);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditarProductosVenta
            // 
            btnEditarProductosVenta.Location = new Point(187, 316);
            btnEditarProductosVenta.Name = "btnEditarProductosVenta";
            btnEditarProductosVenta.Size = new Size(110, 56);
            btnEditarProductosVenta.TabIndex = 6;
            btnEditarProductosVenta.Text = "Editar Venta";
            btnEditarProductosVenta.UseVisualStyleBackColor = true;
            // 
            // formEditarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditarProductosVenta);
            Controls.Add(btnCancelar);
            Controls.Add(btnBorrar);
            Controls.Add(btnGuardar);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtComentario);
            Controls.Add(dgVenta);
            Name = "formEditarVenta";
            Text = "formEditarVenta";
            Load += formEditarVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgVenta;
        private RichTextBox txtComentario;
        private TextBox txtIdUsuario;
        private Button btnGuardar;
        private Button btnBorrar;
        private Button btnCancelar;
        private Button btnEditarProductosVenta;
    }
}