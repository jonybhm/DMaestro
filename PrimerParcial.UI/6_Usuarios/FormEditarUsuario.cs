using PrimerParcial.Entidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial.UI._6_Usuarios
{
    public partial class FormEditarUsuario : Form
    {
        private List<Usuario> _usuarios;
        private FormContenedor mdiParentForm;

        /// <summary>
        /// Inicializa una nueva instania de la clase FormEditarUsuario.
        /// </summary>
        public FormEditarUsuario(List<Usuario> usuarios, FormContenedor mdiParentForm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            _usuarios = usuarios;
            this.mdiParentForm = mdiParentForm;
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton Editar.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Usuario.UsuarioExiste(textBoxUsuario.Text, out Usuario usuarioEncontrado, _usuarios);

            if (usuarioEncontrado is not null)
            {
                bool userRoleAdmin = false;
                string userName = textBoxUsuario.Text;

                foreach (Usuario usuario in _usuarios)
                {
                    if (usuario.UserName == textBoxUsuario.Text)
                    {
                        Usuario usuarioNuevo = usuario;
                        FormGuardarDatosEditados guardarBorrarDatos = new FormGuardarDatosEditados(usuarioNuevo);
                        guardarBorrarDatos.MdiParent = mdiParentForm;
                        guardarBorrarDatos.WindowState = FormWindowState.Normal;
                        guardarBorrarDatos.Show();
                        this.Hide();
                    }
                }

            }
            else
            {
                MessageBox.Show("Usuario No Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



    }
}
