using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.Models
{
    public class Reglas
    {
        
        private string _titulo;
        private string _contenido;
        public string Titulo 
        { 
            get => _titulo; 
            set => _titulo = value;
        }
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

        public string Mostrar()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{_titulo}");
            sb.AppendLine($"{_contenido}");

            return sb.ToString();

        }

    }
}
