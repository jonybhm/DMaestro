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
        public ConsultasDB(string stringDeConexion) : base(stringDeConexion)
        {

        }

        public ConsultasDB() : base(@"Server=.;Database=monsters_en;Trusted_Connection=True;TrustServerCertificate=true;") { }

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

        protected void EjecutarNonQuery(string consulta)
        {
            AbrirConexion();

            var command = new SqlCommand(consulta, _connection);
            var reader = command.ExecuteNonQuery();


            CerrarConexion();
        }

        public string ArmarStringComandoNonQueryInsert(Dictionary<string, object> item,string nombreTabla)
        {
            StringBuilder comandoInsert = new StringBuilder();
            comandoInsert.Append($"INSERT INTO {nombreTabla}(");
            StringBuilder comandoValues = new StringBuilder();
            comandoValues.Append("VALUES (");


            foreach (KeyValuePair<string, object> par in item)
            {
                if (par.Key == "id")
                {
                    continue;
                }
                comandoInsert.Append(par.Key + ",");

                if (int.TryParse(par.Value.ToString(), out _))
                {
                    comandoValues.Append(par.Value.ToString() + ",");
                }
                else
                {
                    comandoValues.Append("'" + par.Value.ToString() + "',");
                }
            }
            comandoInsert.Remove(comandoInsert.Length - 1, 1);
            comandoValues.Remove(comandoValues.Length - 1, 1);
            comandoInsert.Append(")");
            comandoValues.Append(")");
            return comandoInsert.ToString() + comandoValues.ToString();            
        }

        public string ArmarStringComandoNonQueryUpdate(Dictionary<string, object> item, string nombreTabla)
        {
            string comandoUpdate = $"UPDATE {nombreTabla} ";
            
            StringBuilder comandoSet = new StringBuilder();
            comandoSet.Append("SET ");

            string comandoWhere = $" WHERE id={item["id"]}";

            foreach (KeyValuePair<string, object> par in item)
            {
                if (par.Key == "id")
                {
                    continue;
                }
                comandoSet.Append(par.Key + "=");

                if (int.TryParse(par.Value.ToString(), out _))
                {
                    comandoSet.Append(par.Value.ToString() + ",");
                }
                else
                {
                    comandoSet.Append("'" + par.Value.ToString() + "',");
                }
            }
            
            comandoSet.Remove(comandoSet.Length - 1, 1);
            
            return comandoUpdate + comandoSet.ToString() + comandoWhere;
        }

        public string ArmarStringComandoNonQueryDelete(object idItem, string nombreTabla)
        {
            string comandoDelete = $"DELETE {nombreTabla} WHERE id={idItem}";

            return comandoDelete;
        }
    }
}
