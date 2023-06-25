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
        public int Agregar(Item objeto)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Modificar(Item objeto)
        {
            throw new NotImplementedException();
        }

        public List<Dictionary<string, object>> Traer()
        {
            string consulta = "SELECT * FROM items";


            var items = new List<Dictionary<string, object>>();

            items = EjecutarConsulta(consulta);

            return items;
        }

        public Item Traer(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertarDatos(Dictionary<string, object> item)
        {

            EjecutarNonQuery(ComandosDB.ArmarStringComandoNonQueryInsert(item, "items"));


        }
        public void ActualizarDatos(Dictionary<string, object> item)
        {
            EjecutarNonQuery(ComandosDB.ArmarStringComandoNonQueryUpdate(item, "items"));

        }

        public void EliminarDatos(object idEnemigo)
        {
            EjecutarNonQuery(ComandosDB.ArmarStringComandoNonQueryDelete(idEnemigo, "items"));

        }
    }
}
