using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PrimerParcial.Entidades.Models
{
    public static class Informe
    {
        
        public static void RegistrarYGuardarAccionUsuarioEnLog(string usuarioNombre, string nombreBoton)
        {
            string archivoLog = $@"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\Log\log{usuarioNombre}.txt";
            string logEntradaNueva = $"->{DateTime.Now} \n Usuario: {usuarioNombre} \n Click en {nombreBoton}";

            Archivos.CrearArchivoTXT(archivoLog, logEntradaNueva);
           
        }
        
    }
}
