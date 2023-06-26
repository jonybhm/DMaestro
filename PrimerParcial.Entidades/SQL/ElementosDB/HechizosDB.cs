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
        /// <summary>
        /// Trae datos de la tabla en la base de datos.
        /// </summary>
        /// <returns>Devuelve una liasta de diccionarios con los datos de la tabla.</returns>
        public List<Dictionary<string, object>> Traer()
        {
            string consulta = "SELECT * FROM spells";


            var hechizos = new List<Dictionary<string, object>>();

            hechizos = EjecutarConsulta(consulta);

            return hechizos;
        }
        /// <summary>
        /// Inserta datos en la tabla de la base de datos
        /// </summary>
        /// <param name="hechizo">Diccionario con los datos de la fila a insertar en tabla.</param>
        public void InsertarDatos(Dictionary<string, object> hechizo)
        {

            EjecutarNonQuery(ComandosDB.ArmarStringComandoNonQueryInsert(hechizo, "spells"));


        }

        /// <summary>
        /// Inserta datos en la tabla de la base de datos
        /// </summary>
        /// <param name="hechizo">Diccionario con los datos de la fila a modificar en tabla.</param>
        public void ActualizarDatos(Dictionary<string, object> hechizo)
        {
            EjecutarNonQuery(ComandosDB.ArmarStringComandoNonQueryUpdate(hechizo, "spells"));

        }

        /// <summary>
        /// Elimina datos en la tabla de la base de datos
        /// </summary>
        /// <param name="idHechizo">id el item a eliminar de la tabla.</param>
        public void EliminarDatos(object idHechizo)
        {
            EjecutarNonQuery(ComandosDB.ArmarStringComandoNonQueryDelete(idHechizo, "spells"));

        }
    }
}
