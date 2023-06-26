using PrimerParcial.Entidades.Models;
using PrimerParcial.Entidades.SQL.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.SQL.ElementosDB
{
    public class ItemsDB : ConsultasDB, IManipulable<Item>
    {

        /// <summary>
        /// Trae datos de la tabla en la base de datos.
        /// </summary>
        /// <returns>Devuelve una liasta de diccionarios con los datos de la tabla.</returns>
        public List<Dictionary<string, object>> Traer()
        {
            string consulta = "SELECT * FROM items";


            var items = new List<Dictionary<string, object>>();

            items = EjecutarConsulta(consulta);

            return items;
        }

        /// <summary>
        /// Inserta datos en la tabla de la base de datos
        /// </summary>
        /// <param name="item">Diccionario con los datos de la fila a insertar en tabla.</param>
        public void InsertarDatos(Dictionary<string, object> item)
        {

            EjecutarNonQuery(ComandosDB.ArmarStringComandoNonQueryInsert(item, "items"));


        }

        /// <summary>
        /// Inserta datos en la tabla de la base de datos
        /// </summary>
        /// <param name="item">Diccionario con los datos de la fila a modificar en tabla.</param>
        public void ActualizarDatos(Dictionary<string, object> item)
        {
            EjecutarNonQuery(ComandosDB.ArmarStringComandoNonQueryUpdate(item, "items"));

        }

        /// <summary>
        /// Elimina datos en la tabla de la base de datos
        /// </summary>
        /// <param name="idItems">id el item a eliminar de la tabla.</param>
        public void EliminarDatos(object idItems)
        {
            EjecutarNonQuery(ComandosDB.ArmarStringComandoNonQueryDelete(idItems, "items"));

        }
    }
}
