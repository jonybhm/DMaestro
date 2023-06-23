using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Server;
using PrimerParcial.Entidades.Models;

namespace PrimerParcial.Entidades.SQL.General
{
    public abstract class ConexionDB
    {
        protected SqlConnection _connection;
        //private static SqlCommand _command;
        private string _connectionString;

        public ConexionDB(string stringDeConexion)
        {
            _connectionString = stringDeConexion; //ej: "Server=.;Database=prog2;Trusted_Connection=True;"
            //_connection = new SqlConnection(_connectionString);
        }

        protected void AbrirConexion()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        protected void CerrarConexion()
        {
            _connection.Close();
        }

    }
}
