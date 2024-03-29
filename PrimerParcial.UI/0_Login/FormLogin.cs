﻿using Microsoft.VisualBasic.ApplicationServices;
using PrimerParcial.Entidades.Models;
using PrimerParcial.Entidades.SQL.ElementosDB;
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

        /// <summary>
        /// Inicializa una nueva instania de la clase FormLogin.
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
            _usuarios = new List<Usuario>();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton Ingresar.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            Usuario.UsuarioExiste(textUsuario.Text, out Usuario usuarioEncontrado, _usuarios);

            if (usuarioEncontrado is not null)
            {
                if (Usuario.ContraseñaCoincide(textContraseña.Text,_usuarios))
                {
                    MessageBox.Show($"ID del usuario: {usuarioEncontrado!.Id.ToString()}");
                    var sistema = new FormContenedor(usuarioEncontrado, _usuarios);
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

        /// <summary>
        /// Evento que sucede al cargar el Form.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void FormLogin_Load(object sender, EventArgs e)
        {
            UsuariosDB usuariosDB = new UsuariosDB();
            var usersArray = usuariosDB.Traer();

            foreach (Dictionary<string,object> item in usersArray)
            {
                _usuarios.Add(Usuario.Parse(item));
            }

            string[] arrayDeUsuarios = new string[]{};
            foreach (Usuario usuario in  _usuarios)
            {
                arrayDeUsuarios = arrayDeUsuarios.Append(usuario.UserName).ToArray();
            }
            textUsuario.AutoCompleteCustomSource.AddRange(arrayDeUsuarios);
        }

        


    }
}
