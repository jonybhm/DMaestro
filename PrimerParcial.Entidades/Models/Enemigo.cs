using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.Models
{
    public class Enemigo
    {
        private string _nombre;
        private int _puntosExperiencia;
        private int _challengeRating;
        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }
        public int PuntosExperiencia
        {
            get => _puntosExperiencia;
            set => _puntosExperiencia = value;
        }

        public int ChallengeRating
        {
            get => _challengeRating;
            set => _challengeRating = value;
        }

        public Enemigo(string nombre, int puntosExperiencia, int challengeRating)
        {
            _nombre = nombre;
            _puntosExperiencia = puntosExperiencia;
            _challengeRating = challengeRating;
        }

        public string Mostrar()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{_nombre}");
            sb.AppendLine($"{_puntosExperiencia}");

            return sb.ToString();

        }
    }
}
