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
        public NonQueryDB(string stringDeConexion) : base(stringDeConexion)
        {

        }

        public NonQueryDB() : base(@"Server=.;Database=monsters_en;Trusted_Connection=True;") { }



        protected void EjecutarNonQuery(string comando)
        {
            AbrirConexion();

            var command = new SqlCommand(comando, _connection);
            command.ExecuteNonQuery();

            CerrarConexion();
        }


    }
}
