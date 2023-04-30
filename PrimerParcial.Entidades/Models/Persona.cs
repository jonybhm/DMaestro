using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.Models
{
    public class Persona
    {
        private int _id;
        private string _nombre;
        
        public int Id 
        { get => _id; 
          set => _id = value; 
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public Persona(int id, string nombre)
        {
            _id = id;
            _nombre = nombre;
        }

    }
}
