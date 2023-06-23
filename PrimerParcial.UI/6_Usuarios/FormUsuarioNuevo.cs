using PrimerParcial.Entidades.Models;
using PrimerParcial.Entidades.SQL.ElementosDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PrimerParcial.UI._1_Contenedor
{
    public partial class FormUsuarioNuevo : Form
    {
        Usuario usuarioNuevo;
        private List<Usuario> _usuarios;
        public FormUsuarioNuevo(List<Usuario> usuarios)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            _usuarios = usuarios;
        }
        private void FormUsuarioNuevo_Load(object sender, EventArgs e)
        {
            comboBoxTipoUsuario.SelectedIndex = 0;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (VerificarCasillas())
            {
                bool userRoleAdmin = false;
                string userFirstLastName = textBoxNombreApellido.Text;
                string userName = textBoxUsuario.Text;
                string userPassword = textBoxContraseña.Text;
                if (comboBoxTipoUsuario.Text == "administrador")
                {
                    userRoleAdmin = true;
                }
                UsuariosDB usuariosDB = new UsuariosDB();
                usuariosDB.InsertarDatos(Usuario.ArmarDiccionarioDeUsuario(0,userFirstLastName, userName, userPassword, userRoleAdmin));
                MessageBox.Show("Usuario agregado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Faltan valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                    MessageBox.Show("El usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usuarioExistente = true;

                }
                else
                {
                    usuarioExistente = false;
                    break;
                }
            }

            if (textBoxContraseñaConfirm.Text == textBoxContraseña.Text)
            {
                contraseñaCoincidente = true;

            }
            else
            {
                MessageBox.Show("La contraseña no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contraseñaCoincidente = false;
            }

            if (contraseñaCoincidente && !usuarioExistente)
            {
                casillasVerifican = true;
            }


            return casillasVerifican;
        }

        
    }
}
