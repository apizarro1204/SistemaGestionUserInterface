namespace SistemaGestionUserInterface
{
    partial class formGestion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgUsuarios = new DataGridView();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtNombreUsuario = new TextBox();
            Agregar = new Button();
            Editar = new Button();
            Borrar = new Button();
            txtContraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCancelar = new Button();
            btnMostrarProductos = new Button();
            btnMostrarVentas = new Button();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgUsuarios
            // 
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsuarios.Location = new Point(339, 95);
            dgUsuarios.Margin = new Padding(3, 4, 3, 4);
            dgUsuarios.Name = "dgUsuarios";
            dgUsuarios.RowHeadersWidth = 51;
            dgUsuarios.RowTemplate.Height = 25;
            dgUsuarios.Size = new Size(561, 376);
            dgUsuarios.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(174, 95);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(174, 133);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(114, 27);
            txtApellido.TabIndex = 2;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(174, 172);
            txtNombreUsuario.Margin = new Padding(3, 4, 3, 4);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(114, 27);
            txtNombreUsuario.TabIndex = 3;
            txtNombreUsuario.TextChanged += txtNombreUsuario_TextChanged;
            // 
            // Agregar
            // 
            Agregar.Location = new Point(174, 324);
            Agregar.Margin = new Padding(3, 4, 3, 4);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(86, 31);
            Agregar.TabIndex = 5;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = true;
            Agregar.Click += btnAgregar_Click;
            // 
            // Editar
            // 
            Editar.Location = new Point(174, 363);
            Editar.Margin = new Padding(3, 4, 3, 4);
            Editar.Name = "Editar";
            Editar.Size = new Size(86, 31);
            Editar.TabIndex = 6;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = true;
            Editar.Click += Editar_Click;
            // 
            // Borrar
            // 
            Borrar.Location = new Point(174, 401);
            Borrar.Margin = new Padding(3, 4, 3, 4);
            Borrar.Name = "Borrar";
            Borrar.Size = new Size(86, 31);
            Borrar.TabIndex = 7;
            Borrar.Text = "Borrar";
            Borrar.UseVisualStyleBackColor = true;
            Borrar.Click += Borrar_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(174, 211);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(114, 27);
            txtContraseña.TabIndex = 4;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 99);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 137);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 9;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 176);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 10;
            label3.Text = "Nombre Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 215);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 11;
            label4.Text = "Contraseña";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(174, 440);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnMostrarProductos
            // 
            btnMostrarProductos.Location = new Point(59, 498);
            btnMostrarProductos.Margin = new Padding(3, 4, 3, 4);
            btnMostrarProductos.Name = "btnMostrarProductos";
            btnMostrarProductos.Size = new Size(88, 89);
            btnMostrarProductos.TabIndex = 13;
            btnMostrarProductos.Text = "Mostrar Productos";
            btnMostrarProductos.UseVisualStyleBackColor = true;
            btnMostrarProductos.Click += btnMostrarProductos_Click;
            // 
            // btnMostrarVentas
            // 
            btnMostrarVentas.Location = new Point(174, 498);
            btnMostrarVentas.Name = "btnMostrarVentas";
            btnMostrarVentas.Size = new Size(88, 89);
            btnMostrarVentas.TabIndex = 14;
            btnMostrarVentas.Text = "Mostrar Ventas";
            btnMostrarVentas.UseVisualStyleBackColor = true;
            btnMostrarVentas.Click += btnMostrarVentas_Click;
            // 
            // formGestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnMostrarVentas);
            Controls.Add(btnMostrarProductos);
            Controls.Add(btnCancelar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Borrar);
            Controls.Add(Editar);
            Controls.Add(Agregar);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(dgUsuarios);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formGestion";
            Text = "formGestion";
            Load += formGestion_Load;
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgUsuarios;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtNombreUsuario;
        private Button Agregar;
        private Button Editar;
        private Button Borrar;
        private TextBox txtContraseña;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCancelar;
        private Button btnMostrarProductos;
        private Button btnMostrarVentas;
    }
}