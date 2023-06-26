using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.Models
{
    public class Detector20Nat
    {
        public delegate void veinteNaturalHandler(string nombreSonido);
        public static event veinteNaturalHandler veinteNatural;

        /// <summary>
        /// Detecta cada vez que sale un 20 natural en el tirador de dados e invoca un evento de sonido.
        /// </summary>
        /// <param name="nombreSonido">Nombre del sonido a reproducir.</param>
        public static void DetectarVeinteNatural(string nombreSonido)
        {
            veinteNatural?.Invoke(nombreSonido);
        }
    }
}
