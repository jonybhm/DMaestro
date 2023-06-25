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
            try
            {

                switch (Usuario.VerificarCasillas(_usuarios, textBoxUsuario.Text, textBoxContraseñaConfirm.Text, textBoxContraseña.Text))
                {
                    case "usuario existente":
                        MessageBox.Show("El usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "contraseña no coincidente":
                        MessageBox.Show("La contraseña no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "casillas verifican":
                        bool userRoleAdmin = false;
                        string userFirstLastName = textBoxNombreApellido.Text;
                        string userName = textBoxUsuario.Text;
                        string userPassword = textBoxContraseña.Text;
                        if (comboBoxTipoUsuario.Text == "administrador")
                        {
                            userRoleAdmin = true;
                        }
                        UsuariosDB usuariosDB = new UsuariosDB();
                        usuariosDB.InsertarDatos(Usuario.ArmarDiccionarioDeUsuario(0, userFirstLastName, userName, userPassword, userRoleAdmin));
                        MessageBox.Show("Usuario agregado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        break;                   
                }
            }
            catch
            {
                MessageBox.Show("Faltan valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        
    }
}
