using PrimerParcial.Entidades.Models;
using PrimerParcial.Entidades.SQL.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.SQL.ElementosDB
{
    public class UsuariosDB : ConsultasDB, IManipulable<Usuario>
    {
        /// <summary>
        /// Trae datos de la tabla en la base de datos.
        /// </summary>
        /// <returns>Devuelve una liasta de diccionarios con los datos de la tabla.</returns>
        public List<Dictionary<string, object>> Traer()
        {
            string consulta = "SELECT * FROM users";


            var usuarios = new List<Dictionary<string, object>>();

            usuarios = EjecutarConsulta(consulta);

            return usuarios;
        }

        /// <summary>
        /// Inserta datos en la tabla de la base de datos
        /// </summary>
        /// <param name="usuario">Diccionario con los datos de la fila a insertar en tabla.</param>
        public void InsertarDatos(Dictionary<string, object> usuario)
        {

            EjecutarNonQuery(ComandosDB.ArmarStringComandoNonQueryInsert(usuario, "users"));


        }

        /// <summary>
        /// Inserta datos en la tabla de la base de datos
        /// </summary>
        /// <param name="usuario">Diccionario con los datos de la fila a modificar en tabla.</param>
        public void ActualizarDatos(Dictionary<string, object> usuario)
        {
            EjecutarNonQuery(ComandosDB.ArmarStringComandoNonQueryUpdate(usuario, "users"));

        }

        /// <summary>
        /// Elimina datos en la tabla de la base de datos
        /// </summary>
        /// <param name="idUsuario">id el item a eliminar de la tabla.</param>
        public void EliminarDatos(object idUsuario)
        {
            EjecutarNonQuery(ComandosDB.ArmarStringComandoNonQueryDelete(idUsuario, "users"));

        }
    }
}
