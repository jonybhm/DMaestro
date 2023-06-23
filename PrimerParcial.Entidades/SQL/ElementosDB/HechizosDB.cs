using PrimerParcial.Entidades.Models;
using PrimerParcial.Entidades.SQL.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.SQL.ElementosDB
{
    public class HechizosDB : ConsultasDB, IManipulable<Hechizo>
    {
        public int Agregar(Hechizo objeto)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Modificar(Hechizo objeto)
        {
            throw new NotImplementedException();
        }

        public List<Dictionary<string, object>> Traer()
        {
            string consulta = "SELECT * FROM spells";


            var hechizos = new List<Dictionary<string, object>>();

            hechizos = EjecutarConsulta(consulta);

            return hechizos;
        }

        public Hechizo Traer(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertarDatos(Dictionary<string, object> enemigo)
        {

            EjecutarNonQuery(ArmarStringComandoNonQueryInsert(enemigo, "spells"));


        }
        public void ActualizarDatos(Dictionary<string, object> enemigo)
        {
            EjecutarNonQuery(ArmarStringComandoNonQueryUpdate(enemigo, "spells"));

        }

        public void EliminarDatos(object idEnemigo)
        {
            EjecutarNonQuery(ArmarStringComandoNonQueryDelete(idEnemigo, "spells"));

        }
    }
}
