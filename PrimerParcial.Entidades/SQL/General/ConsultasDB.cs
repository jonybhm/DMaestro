using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PrimerParcial.Entidades.Models;


namespace PrimerParcial.Entidades.SQL.General
{
    public class ConsultasDB : ConexionDB
    {
        /// <summary>
        /// Inicializa una nueva instania de la clase ConsultasDB.
        /// </summary>
        /// <param name="stringDeConexion">string que representa el string necesario para conectar a la base de datos.</param>
        public ConsultasDB(string stringDeConexion) : base(stringDeConexion)
        {

        }

        public ConsultasDB() : base(@"Server=.;Database=monsters_en;Trusted_Connection=True;TrustServerCertificate=true;") { }

        /// <summary>
        /// 
        /// Ejecuta la consulta en en la base de datos.
        /// </summary>
        /// <param name="consulta">string que representa la consulta.</param>
        protected List<Dictionary<string, object>> EjecutarConsulta(string consulta)
        {
            AbrirConexion();
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();

            var command = new SqlCommand(consulta, _connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Dictionary<string, object> monsterDict = new Dictionary<string, object>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string columnName = reader.GetName(i);
                    object columnValue = reader.GetValue(i);

                    monsterDict[columnName] = columnValue;
                }

                list.Add(monsterDict);
            }

            reader.Close();
            CerrarConexion();
            return list;

        }

        /// <summary>
        /// 
        /// Ejecuta el Non Query en en la base de datos.
        /// </summary>
        /// <param name="consulta">string que representa la consulta.</param>
        protected void EjecutarNonQuery(string consulta)
        {
            AbrirConexion();

            var command = new SqlCommand(consulta, _connection);
            var reader = command.ExecuteNonQuery();


            CerrarConexion();
        }

        
    }
}
