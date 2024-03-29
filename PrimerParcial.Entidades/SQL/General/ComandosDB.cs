﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.SQL.General
{
    public static class ComandosDB
    {
        /// <summary>
        /// Arma el comando que se utilizara en el Non Query en formato string para insertar datos en tabla.
        /// </summary>
        /// <param name="item">Diccionario con el elemento al que corresponde la tabla.</param>
        /// <param name="nombreTabla">string que representa el nombre de la tabla.</param>
        /// <returns></returns>
        public static string ArmarStringComandoNonQueryInsert(Dictionary<string, object> item, string nombreTabla)
        {
            StringBuilder comandoInsert = new StringBuilder();
            comandoInsert.Append($"INSERT INTO {nombreTabla}(");
            StringBuilder comandoValues = new StringBuilder();
            comandoValues.Append("VALUES (");


            foreach (KeyValuePair<string, object> par in item)
            {
              
                switch (par.Key)
                {
                    case "id":
                    case "characters":
                    case "adventures":
                    case "combats":
                    case "items":
                        continue;
                        break;
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

        /// <summary>
        /// Arma el comando que se utilizara en el Non Query en formato string para actualizar datos en tabla.
        /// </summary>
        /// <param name="item">Diccionario con el elemento al que corresponde la tabla.</param>
        /// <param name="nombreTabla">string que representa el nombre de la tabla.</param>
        /// <returns></returns>
        public static string ArmarStringComandoNonQueryUpdate(Dictionary<string, object> item, string nombreTabla)
        {
            string comandoUpdate = $"UPDATE {nombreTabla} ";

            StringBuilder comandoSet = new StringBuilder();
            comandoSet.Append("SET ");

            string comandoWhere = $" WHERE id={item["id"]}";

            foreach (KeyValuePair<string, object> par in item)
            {
                
                switch (par.Key)
                {
                    case "id":
                    case "characters":
                    case "adventures":
                    case "combats":
                    case "items":
                        continue;
                        break;
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

        /// <summary>
        /// Arma el comando que se utilizara en el Non Query en formato string para eliminar datos en tabla.
        /// </summary>
        /// <param name="item">Diccionario con el elemento al que corresponde la tabla.</param>
        /// <param name="nombreTabla">string que representa el nombre de la tabla.</param>
        /// <returns></returns>
        public static string ArmarStringComandoNonQueryDelete(object idItem, string nombreTabla)
        {
            string comandoDelete = $"DELETE {nombreTabla} WHERE id={idItem}";

            return comandoDelete;
        }
    }
}
