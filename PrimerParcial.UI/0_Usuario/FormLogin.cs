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
                MessageBox.Show(usuarioEncontrado!.Id.ToString());
                var sistema = new FormContenedor();
                sistema.Show();
                sistema.WindowState = FormWindowState.Maximized;
                this.Hide();
            }
            else
            {
                MessageBox.Show("No existe el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Elemento.LeerInfoUsuarios(_usuarios);
        }

        private bool UsuarioExiste(string usuario, out Usuario usuarioEncontrado)
        {
            usuarioEncontrado = null;
            foreach (Usuario item in _usuarios)
            {
                if (item.NombreUsuario == usuario)
                {
                    usuarioEncontrado = item;
                    return true;
                }
            }
            return false;
        }
    }
}
