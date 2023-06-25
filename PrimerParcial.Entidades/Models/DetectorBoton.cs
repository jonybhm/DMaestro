using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.Models
{
    public class DetectorBoton
    {
        public delegate void ClickBotonHandler(string usuario, string nombreBoton); //public event Action<string> ClickBoton; para delegate y event

        public static event ClickBotonHandler ClickBoton;

        public static void DetectarBotonPresionadoPorUsuario(string usuario, string nombreBoton)
        {
            
            ClickBoton?.Invoke(usuario, nombreBoton);

            //ClickBotonEvento += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            
        }


    }
}
