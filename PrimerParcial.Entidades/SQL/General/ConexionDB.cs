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
        private string _connectionString;

        /// <summary>
        /// Inicializa una nueva instania de la clase ConexionDB.
        /// </summary>
        /// <param name="stringDeConexion"></param>
        public ConexionDB(string stringDeConexion)
        {
            _connectionString = stringDeConexion; 
        }

        /// <summary>
        /// Abre la conexion con la base de datos.
        /// </summary>
        protected void AbrirConexion()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        /// <summary>
        /// Cierra la conexion con la base de datos.
        /// </summary>
        protected void CerrarConexion()
        {
            _connection.Close();
        }

    }
}
