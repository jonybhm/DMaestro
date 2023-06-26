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

        /// <summary>
        /// Detectar un boton e invocar a un evento al realizarse esta accion. 
        /// </summary>
        /// <param name="usuario">string que representa el nombre usuario.</param>
        /// <param name="nombreBoton">string que representa el nombre del boton presionado.</param>
        public static void DetectarBotonPresionadoPorUsuario(string usuario, string nombreBoton)
        {
            
            ClickBoton?.Invoke(usuario, nombreBoton);
           
        }


    }
}
