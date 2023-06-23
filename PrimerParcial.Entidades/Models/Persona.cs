using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.Models
{
    public abstract class Persona
    {
        private int _id;
        private string _name;
        
        public int Id 
        { get => _id; 
          set => _id = value; 
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        /// <summary>
        /// Inicializa una nueva instania de la clase Persona.
        /// </summary>
        /// <param name="id">identificador numerico.</param>
        /// <param name="name">nombre de la persona.</param>
        public Persona(int id, string name)
        {
            _id = id;
            _name = name;
        } 

    }
}
