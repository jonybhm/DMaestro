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

        public Usuario(int id, string nombre, string userName, string password, bool isAdmin) : base(id, nombre)
        {
            _userName = userName;
            _password = password;
            _isAdmin = isAdmin;
        }

        public bool CheckPassword(string password)
        {
            return _password.Equals(password);
        }

        public static Usuario Parse(JsonElement infoUsuario)
        {
            int id = infoUsuario.GetProperty("Id").GetInt32();
            string name = infoUsuario.GetProperty("Name").GetString();
            string userName = infoUsuario.GetProperty("UserName").GetString();
            string password = infoUsuario.GetProperty("Password").GetString();
            bool isAdmin = infoUsuario.GetProperty("IsAdmin").GetBoolean();

            return new Usuario(id, name, userName, password, isAdmin);

            //return new Usuario(0,"jose","admin", "admin",true);

        }

       
    }
}
