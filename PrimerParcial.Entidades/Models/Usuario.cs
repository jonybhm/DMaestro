﻿using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.Models
{
    public class Usuario : Persona
    {
        private string _userName;
        private string _password;
        private bool _isAdmin;

        public string UserName
        {
            get => _userName;
            set => _userName = value; 
        }
        public string Password
        {
            get => _password;
            set => _password = value; 
        }

        public bool IsAdmin
        {
            get => _isAdmin;
            set => _isAdmin = value;
        }

        /// <summary>
        ///Inicializa una nueva instania de la clase Usuario.
        /// </summary>
        /// <param name="id">identificador numerico.</param>
        /// <param name="nombre">Nombre real del usuario.</param>
        /// <param name="userName">Nombre alias del usuario.</param>
        /// <param name="password">Contraseña del usuario.</param>
        /// <param name="isAdmin">Valor int que identifica si el usuario es Admin o no.</param>
        public Usuario(int id, string nombre, string userName, string password, bool isAdmin) : base(id, nombre)
        {
            _userName = userName;
            _password = password;
            _isAdmin = isAdmin;
        }

        /// <summary>
        /// Convierte explicitamente un elemento en el tipo Usuario.
        /// </summary>
        /// <param name="infoUsuario">Informacion obtenida de un Json con datos de usuarios.</param>
        /// <returns>nuevo Usuario con la info obtenida del Json.</returns>
        public static Usuario Parse(Dictionary<string,object> infoUsuario)
        {
            int id = int.Parse(infoUsuario["id"].ToString());
            string name = (string)infoUsuario["name"];
            string userName = (string)infoUsuario["userName"];
            string password = (string)infoUsuario["password"];
            bool isAdmin = Convert.ToBoolean(infoUsuario["isAdmin"]);

            return new Usuario(id, name, userName, password, isAdmin);
                        
        }

        /// <summary>
        /// Verifica si el usuario existe dentro de la lista de usuarios provista.
        /// </summary>
        /// <param name="usuario">strig que representa el nombre de usuario.</param>
        /// <param name="usuarioEncontrado">Objeto Usuario pasado por referencia.</param>
        /// <param name="_usuarios">lista de usuarios.</param>
        /// <returns>Valor booleano que verifica la existencia del usuario.</returns>
        public static bool UsuarioExiste(string usuario, out Usuario usuarioEncontrado, List<Usuario> _usuarios)
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

        /// <summary>
        /// Verifica si la contraseña coincide con la ingresada por el usuario.
        /// </summary>
        /// <param name="contraseña">string que representa la contraseña.</param>
        /// <param name="_usuarios">lista de usuarios.</param>
        /// <returns>Valor booleano que verifica si la constraseña coincide</returns>
        public static bool ContraseñaCoincide(string contraseña, List<Usuario> _usuarios)
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

        /// <summary>
        /// Arma un diccionario en base a un objeto Usuario.
        /// </summary>
        /// <param name="id">int que representa la id.</param>
        /// <param name="nombreApellido">string que representa el nombre de pila del usuario.</param>
        /// <param name="nombreUsuario">string que representa el nombre alias de usuario.</param>
        /// <param name="contraseña">string que representa la contraseña para ingreso.</param>
        /// <param name="rolUsuario">booleano que indica si el usuario tiene permismos administrativos o no.</param>
        /// <returns>Diccionario con los datos ordenaso con sus llaves y valores.</returns>
        public static Dictionary<string,object> ArmarDiccionarioDeUsuario(int id,string nombreApellido,string nombreUsuario, string contraseña, bool rolUsuario)
        {
            Dictionary<string, object> dictUsuario = new Dictionary<string, object>();
            dictUsuario.Add("id", id);
            dictUsuario.Add("name", nombreApellido);
            dictUsuario.Add("userName", nombreUsuario);
            dictUsuario.Add("password", contraseña);
            dictUsuario.Add("isAdmin", Convert.ToByte(rolUsuario));
            return dictUsuario;
        }


        /// <summary>
        /// Verifica si los valores ingresados por el usuario estan bien. 
        /// En particular si la contraseña coincide y el usuario no se repite.
        /// </summary>
        /// <param name="_usuarios">>Lista con los usuarios obtenida de la base de datos.</param>
        /// <param name="textBoxUsuario">Nombre de usuario ingresado por el admin.</param>
        /// <param name="textBoxContraseñaConfirm">Confirmacion de contraseña ingresado por el admin.</param>
        /// <param name="textBoxContraseña">Contraseña ingresada por el admin.</param>
        /// <returns></returns>
        public static string VerificarCasillas(List<Usuario> _usuarios, string textBoxUsuario, string textBoxContraseñaConfirm, string textBoxContraseña)
        {
            string resultadoVerificacion = "";

            bool usuarioExistente = false;

            bool contraseñaCoincidente = false;

            foreach (Usuario item in _usuarios)
            {
                if (item.UserName == textBoxUsuario)
                {
                    usuarioExistente = true;
                    break;
                }
            }

            if (textBoxContraseñaConfirm == textBoxContraseña)
            {
                contraseñaCoincidente = true;
            }

            if (contraseñaCoincidente && !usuarioExistente)
            {
                resultadoVerificacion = "casillas verifican";
            }
            else if (!contraseñaCoincidente)
            {
                resultadoVerificacion = "contraseña no coincidente";

            }
            else if (usuarioExistente)
            {
                resultadoVerificacion = "usuario existente";
            }

            return resultadoVerificacion;
        }

        

    }
}
