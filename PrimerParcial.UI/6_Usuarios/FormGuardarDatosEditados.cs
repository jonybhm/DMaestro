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
    public partial class FormGuardarDatosEditados : Form
    {
        private Usuario usuarioEditado;
        public FormGuardarDatosEditados(Usuario usuario)
        {
            InitializeComponent();
            usuarioEditado = usuario; 
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            usuarioEditado.Password = textBoxContraseña.Text;
            usuarioEditado.Name = textBoxNombreApellido.Text;
            usuarioEditado.IsAdmin = usuarioEditado.IsAdmin;
            usuarioEditado.UserName = textBoxUsuario.Text;
            Elemento.ModificarInfoEnArchivo(usuarioEditado, "usuarios",usuarioEditado.Id);
            MessageBox.Show("Usuario Editado");
            this.Close();
        }
    }
}
