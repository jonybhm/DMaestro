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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PrimerParcial.UI._6_Usuarios
{
    public partial class FormGuardarDatosEditados : Form
    {
        private Usuario usuarioEditado;

        /// <summary>
        /// Inicializa una nueva instania de la clase FormGuardarDatosUsuario.
        /// </summary>
        public FormGuardarDatosEditados(Usuario usuario)
        {
            InitializeComponent();
            usuarioEditado = usuario;
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton Guardar.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            bool userRoleAdmin = false;
            string userPassword = textBoxContraseña.Text;
            string userFirstLastName = textBoxNombreApellido.Text;
            string userName = textBoxUsuario.Text;
            if (comboBoxTipoUsuario.Text == "administrador")
            {
                userRoleAdmin = true;
            }
            
            UsuariosDB usuariosDB = new UsuariosDB();
            usuariosDB.ActualizarDatos(Usuario.ArmarDiccionarioDeUsuario(usuarioEditado.Id,userFirstLastName, userName, userPassword, userRoleAdmin));
            MessageBox.Show("Usuario Editado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            bool userRoleAdmin = false;
            string userPassword = textBoxContraseña.Text;
            string userFirstLastName = textBoxNombreApellido.Text;
            string userName = textBoxUsuario.Text;
            if (comboBoxTipoUsuario.Text == "administrador")
            {
                userRoleAdmin = true;
            }
            
            UsuariosDB usuariosDB = new UsuariosDB();
            DialogResult confirmacion = MessageBox.Show("¿Seguro desea Borrar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(confirmacion == DialogResult.Yes)
            {
                usuariosDB.EliminarDatos(usuarioEditado.Id);
                MessageBox.Show("Usuario Eliminado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
            this.Close();

        }
    }
}
