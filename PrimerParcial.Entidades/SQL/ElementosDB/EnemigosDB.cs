using PrimerParcial.Entidades.Models;
using PrimerParcial.Entidades.SQL.General;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.SQL.ElementosDB
{
    public class EnemigosDB : ConsultasDB, IManipulable<Enemigo>
    {
        
        /// <summary>
        /// Trae datos de la tabla en la base de datos.
        /// </summary>
        /// <returns>Devuelve una liasta de diccionarios con los datos de la tabla.</returns>
        public List<Dictionary<string, object>> Traer()
        {
            string consulta = "SELECT * FROM monsters";


            var enemigos = new List<Dictionary<string, object>>();

            enemigos = EjecutarConsulta(consulta);

            return enemigos;
        }
                
        /// <summary>
        /// Inserta datos en la tabla de la base de datos
        /// </summary>
        /// <param name="enemigo">Diccionario con los datos de la fila a insertar en tabla.</param>
        public void InsertarDatos(Dictionary<string, object> enemigo)
        {
            
            EjecutarNonQuery(ComandosDB.ArmarStringComandoNonQueryInsert(enemigo,"monsters"));           

        }

        /// <summary>
        /// Actualiza datos en la tabla de la base de datos
        /// </summary>
        /// <param name="enemigo">Diccionario con los datos de la fila a modificar en tabla.</param>
        public void ActualizarDatos(Dictionary<string, object> enemigo)
        {
            EjecutarNonQuery(ComandosDB.ArmarStringComandoNonQueryUpdate(enemigo, "monsters"));           

        }

        /// <summary>
        /// Elimina datos en la tabla de la base de datos
        /// </summary>
        /// <param name="idEnemigo">id el item a eliminar de la tabla.</param>
        public void EliminarDatos(object idEnemigo)
        {
            EjecutarNonQuery(ComandosDB.ArmarStringComandoNonQueryDelete(idEnemigo, "monsters"));

        }

    }
}
