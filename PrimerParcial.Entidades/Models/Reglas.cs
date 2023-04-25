using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.Models
{
    internal class Reglas
    {
        
        private string _titulo;
        public string Titulo 
        { 
            get => _titulo; 
            set => _titulo = value;
        }

        private string _contenido;
        public string Contenido
        {
            get => _contenido;
            set => _contenido = value;
        }

        public Reglas(string titulo, string contenido)
        {
            _titulo = titulo;
            _contenido = contenido;
        }

    }
}
