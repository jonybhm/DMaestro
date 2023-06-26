using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace PrimerParcial.Entidades.SQL.General
{
    public class NonQueryDB : ConexionDB
    {
        /// <summary>
        /// Inicializa una nueva instania de la clase NonQueryDB.
        /// </summary>
        /// <param name="stringDeConexion"></param>
        public NonQueryDB(string stringDeConexion) : base(stringDeConexion)
        {

        }

        public NonQueryDB() : base(@"Server=.;Database=monsters_en;Trusted_Connection=True;") { }


        /// <summary>
        /// Ejecuta el NonQuery.
        /// </summary>
        /// <param name="comando">string que representa el comando Non Query</param>
        protected void EjecutarNonQuery(string comando)
        {
            AbrirConexion();

            var command = new SqlCommand(comando, _connection);
            command.ExecuteNonQuery();

            CerrarConexion();
        }


    }
}
