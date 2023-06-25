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
        public int Agregar(Enemigo objeto)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Modificar(Enemigo objeto)
        {
            throw new NotImplementedException();
        }

        public List<Dictionary<string, object>> Traer()
        {
            string consulta = "SELECT * FROM monsters";


            var enemigos = new List<Dictionary<string, object>>();

            enemigos = EjecutarConsulta(consulta);

            return enemigos;
        }

        public Enemigo Traer(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertarDatos(Dictionary<string, object> enemigo)
        {
            
            EjecutarNonQuery(ComandosDB.ArmarStringComandoNonQueryInsert(enemigo,"monsters"));
            

        }
        public void ActualizarDatos(Dictionary<string, object> enemigo)
        {
            EjecutarNonQuery(ComandosDB.ArmarStringComandoNonQueryUpdate(enemigo, "monsters"));           

        }

        public void EliminarDatos(object idEnemigo)
        {
            EjecutarNonQuery(ComandosDB.ArmarStringComandoNonQueryDelete(idEnemigo, "monsters"));

        }

    }
}
