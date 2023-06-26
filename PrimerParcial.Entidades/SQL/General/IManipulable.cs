using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.SQL.General
{
    public interface IManipulable<T>
    {
        //Interfaz para estructuras de bases de datos.
        public List<Dictionary<string,object>> Traer();
        public void InsertarDatos(Dictionary<string, object> objeto);
        public void ActualizarDatos(Dictionary<string, object> objeto);
        public void EliminarDatos(object id);
    }
}
