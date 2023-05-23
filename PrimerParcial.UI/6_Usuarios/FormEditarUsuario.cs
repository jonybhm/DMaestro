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
        public FormEditarUsuario(List<Usuario> usuarios)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            _usuarios = usuarios;
        }
        private void FormUsuarioNuevo_Load(object sender, EventArgs e)
        {
            //comboBoxTipoUsuario.SelectedIndex = 0;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

            if (VerificarCasillas())
            {
                bool userRoleAdmin = false;
                //string userFirstLastName = textBoxNombreApellido.Text;
                string userName = textBoxUsuario.Text;
                //string userPassword = textBoxContraseña.Text;
                //if (comboBoxTipoUsuario.Text == "administrativo")
                //{
                //    userRoleAdmin = true;
                //}
                foreach (Usuario usuario in _usuarios)
                {
                    if (usuario.UserName == textBoxUsuario.Text)
                    {
                        Usuario usuarioNuevo = usuario;
                        var hijo = new FormGuardarDatosEditados(usuarioNuevo);
                        //hijo.MdiParent = this;
                        hijo.WindowState = FormWindowState.Normal;
                        hijo.Show();
                        this.Hide();
                    }
                }

            }
            else
            {
                MessageBox.Show("Faltan valores");

            }

        }

        private bool VerificarCasillas()
        {
            bool casillasVerifican = false;

            bool usuarioExistente = false;

            bool contraseñaCoincidente = false;

            foreach (Usuario item in _usuarios)
            {
                if (item.UserName == textBoxUsuario.Text)
                {
                    usuarioExistente = true;
                    break;
                }
                else
                {
                    
                    usuarioExistente = false;
                }
            }

            /*if (textBoxContraseñaConfirm.Text == textBoxContraseña.Text)
            {
                contraseñaCoincidente = true;
            }
            else
            {
                MessageBox.Show("La contraseña no coincide");
                contraseñaCoincidente = false;
            }*/

            if (usuarioExistente)
            {
                casillasVerifican = true;
            }
            else
            {
                MessageBox.Show("El usuario no existe");
            }

            return casillasVerifican;
        }

    }
}
