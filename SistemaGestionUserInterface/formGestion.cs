using SistemaGestionBussiness;
using SistemaGestionEntities;


namespace SistemaGestionUserInterface
{
    public partial class formGestion : Form
    {
        private readonly UsuarioBussiness usuarioBussiness;
        private readonly ProductoBussiness productoBussiness;
        private readonly VentaBussiness ventaBussiness;
        public formGestion(UsuarioBussiness usuarioBussiness, ProductoBussiness productoBussiness, VentaBussiness ventaBussiness)
        {
            InitializeComponent();
            this.usuarioBussiness = usuarioBussiness;
            this.productoBussiness = productoBussiness;
            this.ventaBussiness = ventaBussiness;
        }

        private void ActualizarDataGridView()
        {
            // Limpia el contenido actual del DataGridView
            dgUsuarios.DataSource = null;
            dgUsuarios.Rows.Clear();

            // Vuelve a cargar los datos de usuarios desde la base de datos y asigna la lista al DataGridView
            List<Usuario> usuarios = usuarioBussiness.GetUsuarios();
            dgUsuarios.DataSource = usuarios;
        }

        private void formGestion_Load(object sender, EventArgs e)
        {
            List<Usuario> usuarios = usuarioBussiness.GetUsuarios();
            dgUsuarios.AutoGenerateColumns = true;
            dgUsuarios.DataSource = usuarios;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string nombreUsuario = txtNombreUsuario.Text;
            string contrase�a = txtContrase�a.Text;

            Usuario nuevoUsuario = new Usuario
            {
                Nombre = nombre,
                Apellido = apellido,
                NombreUsuario = nombreUsuario,
                Contrase�a = contrase�a,
            };

            usuarioBussiness.CrearUsuario(nuevoUsuario);

            ActualizarDataGridView();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgUsuarios.SelectedRows[0];
                Usuario usuarioSeleccionado = (Usuario)filaSeleccionada.DataBoundItem;

                // Crear una instancia de formEditarUsuario pasando el usuario seleccionado y UsuarioBussiness
                using (formEditarUsuario formEditar = new formEditarUsuario(usuarioSeleccionado, usuarioBussiness))
                {
                    DialogResult resultado = formEditar.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        // Actualizar el DataGridView despu�s de editar
                        ActualizarDataGridView();
                    }
                }
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre no puede estar vac�o.");
            }

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            string apellido = txtApellido.Text;

            if (string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("El apellido no puede estar vac�o.");
            }
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;

            if (string.IsNullOrEmpty(nombreUsuario))
            {
                MessageBox.Show("El nombre de usuario no puede estar vac�o.");
            }
        }

        private void txtContrase�a_TextChanged(object sender, EventArgs e)
        {
            string contrase�a = txtContrase�a.Text;

            if (string.IsNullOrEmpty(contrase�a))
            {
                MessageBox.Show("La contrase�a no puede estar vac�a.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgUsuarios.SelectedRows[0];
                Usuario usuarioSeleccionado = (Usuario)filaSeleccionada.DataBoundItem;

                DialogResult confirmacion = MessageBox.Show("�Est�s seguro de que deseas eliminar este usuario?", "Confirmaci�n de eliminaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    // Llamar a la funci�n para eliminar el usuario
                    usuarioBussiness.EliminarUsuario(usuarioSeleccionado.Id);

                    // Actualizar el DataGridView despu�s de eliminar
                    ActualizarDataGridView();
                }
            }
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            formEditarProducto formProductos = new formEditarProducto(productoBussiness);
            formProductos.Show();
        }

        private void btnMostrarVentas_Click(object sender, EventArgs e)
        {
            formEditarVenta formVentas = new formEditarVenta(ventaBussiness);
            formVentas.Show();
        }
    }
}