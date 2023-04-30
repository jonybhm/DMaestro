using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.Models
{
    public class Usuario : Persona
    {
        private string _nombreUsuario;
        private string _contraseña;

        public string NombreUsuario
        {
            get => _nombreUsuario;
            set => _nombreUsuario = value; 
        }
        public Usuario(int id, string nombre, string usuario, string contraseña) : base(id, nombre)
        {
            _nombreUsuario = usuario;
            _contraseña = contraseña;
        }

        public bool CheckPassword(string password)
        {
            return _contraseña.Equals(password);
        }
    }
}
