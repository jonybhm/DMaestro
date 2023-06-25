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
        public static void DetectarVeinteNatural(string nombreSonido)
        {
            veinteNatural?.Invoke(nombreSonido);
        }
    }
}
