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
        public int Agregar(Usuario objeto)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Modificar(Usuario objeto)
        {
            throw new NotImplementedException();
        }

        public List<Dictionary<string, object>> Traer()
        {
            string consulta = "SELECT * FROM users";


            var usuarios = new List<Dictionary<string, object>>();

            usuarios = EjecutarConsulta(consulta);

            return usuarios;
        }

        public Usuario Traer(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertarDatos(Dictionary<string, object> usuario)
        {

            EjecutarNonQuery(ArmarStringComandoNonQueryInsert(usuario, "users"));


        }
        public void ActualizarDatos(Dictionary<string, object> usuario)
        {
            EjecutarNonQuery(ArmarStringComandoNonQueryUpdate(usuario, "users"));

        }

        public void EliminarDatos(object idUsuario)
        {
            EjecutarNonQuery(ArmarStringComandoNonQueryDelete(idUsuario, "users"));

        }
    }
}
