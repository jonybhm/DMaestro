using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.SQL.General
{
    public interface IManipulable<T>
    {
        //public List<T> Traer();
        public T Traer(int id);

        public int Agregar(T objeto);
        public int Modificar(T objeto);
        public int Eliminar(int id);
    }
}
