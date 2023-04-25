using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeCastro_PrimerParcial.Models
{
    internal class Usuario
    {
        private int id;
        public int Id
        {
            get => id;
            set => id = value;
        }

        private string nombre;
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public Usuario(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }

}
