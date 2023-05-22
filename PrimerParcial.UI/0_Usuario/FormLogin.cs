using Microsoft.VisualBasic.ApplicationServices;
using PrimerParcial.Entidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimerParcial.UI
{
    public partial class FormLogin : Form
    {
        private List<Usuario> _usuarios;
        public FormLogin()
        {
            InitializeComponent();
            _usuarios = new List<Usuario>();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //this.Location = new Point(0, 0);
            //this.Dock = DockStyle.Right;
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            UsuarioExiste(textUsuario.Text, out Usuario usuarioEncontrado);

            if (usuarioEncontrado is not null)
            {
                if (ContraseñaCoincide(textContraseña.Text))
                {
                    MessageBox.Show($"ID del usuario: {usuarioEncontrado!.Id.ToString()}");
                    var sistema = new FormContenedor(usuarioEncontrado.IsAdmin, _usuarios);
                    sistema.Show();
                    sistema.WindowState = FormWindowState.Maximized;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("No existe el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
                      
            string[] arrayDeUsuarios = _usuarios.Select(user => user.UserName).ToArray();
            textUsuario.AutoCompleteCustomSource.AddRange(arrayDeUsuarios);

            var jsonArray = Elemento.LeerInfoDocumento("usuarios");

            foreach (JsonElement item in jsonArray.EnumerateArray())
            {
                _usuarios.Add(Usuario.Parse(item));
            }

        }

        private bool UsuarioExiste(string usuario, out Usuario usuarioEncontrado)
        {
            usuarioEncontrado = null;
            foreach (Usuario item in _usuarios)
            {
                if (item.UserName == usuario)
                {
                    usuarioEncontrado = item;
                    return true;
                }
            }
            return false;
        }

        private bool ContraseñaCoincide(string contraseña)
        {
            bool contraseñaCoincide = false;

            foreach (Usuario item in _usuarios)
            {
                if (item.Password == contraseña)
                {
                    contraseñaCoincide = true;

                }
            }

            return contraseñaCoincide;
        }


    }
}
