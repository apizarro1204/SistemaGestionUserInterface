using System;
using System.Windows.Forms;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionUserInterface
{
    public partial class formEditarUsuario : Form
    {
        private readonly Usuario usuario;
        private readonly UsuarioBussiness usuarioBussiness;

        public formEditarUsuario(Usuario usuarioParametro, UsuarioBussiness usuarioBussinessParametro)
        {
            InitializeComponent();
            this.usuario = usuarioParametro;
            this.usuarioBussiness = usuarioBussinessParametro;
        }

        private void formEditarUsuario_Load(object sender, EventArgs e)
        {
            // Verifica si el usuario no es nulo
            if (usuario != null)
            {
                if (dgUsuario.Columns.Count == 0)
                {
                    dgUsuario.Columns.Add("Propiedad", "Propiedad");
                    dgUsuario.Columns.Add("Valor", "Valor");
                }

                dgUsuario.Rows.Add("Nombre:", usuario.Nombre);
                dgUsuario.Rows.Add("Apellido:", usuario.Apellido);
                dgUsuario.Rows.Add("Nombre de Usuario:", usuario.NombreUsuario);
                dgUsuario.Rows.Add("Contraseña:", usuario.Contraseña);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnGuardarCambios_Click_1(object sender, EventArgs e)
        {
            string nuevoNombre = txtNombre.Text;
            string nuevoApellido = txtApellido.Text;
            string nuevoNombreUsuario = txtNombreUsuario.Text;
            string nuevaContraseña = txtContraseña.Text;

            usuario.Nombre = nuevoNombre;
            usuario.Apellido = nuevoApellido;
            usuario.NombreUsuario = nuevoNombreUsuario;
            usuario.Contraseña = nuevaContraseña;

            usuarioBussiness.EditarUsuario(usuario);

            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
