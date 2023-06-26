using PrimerParcial.Entidades.Models;
using PrimerParcial.Entidades.SQL.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace PrimerParcial.Entidades.SQL.ElementosDB
{
    public class CampañasDB : ConsultasDB, IManipulable<Campaña>
    {
        /// <summary>
        /// Trae datos de la tabla en la base de datos.
        /// </summary>
        /// <returns>Devuelve una liasta de diccionarios con los datos de la tabla.</returns>
        public List<Dictionary<string, object>> Traer()
        {
            string consulta = "SELECT * FROM campaigns";


            var campaigns = new List<Dictionary<string, object>>();

            campaigns = EjecutarConsulta(consulta);

            return campaigns;
        }


        public List<Dictionary<string, object>> TraerPersonajes()
        {
            string consulta = "SELECT ch.name AS [characterName],ch.class AS [characterClass],ch.level AS [characterLevel],ch.hp AS [characterHP],ch.ac AS [characterAC] " +
                "FROM campaigns AS c LEFT JOIN campaigns_characters AS cch ON c.id = cch.id_campaign LEFT JOIN characters AS ch ON cch.id_character= ch.id";


            var campaigns = new List<Dictionary<string, object>>();

            campaigns = EjecutarConsulta(consulta);

            return campaigns;
        }

        public List<Dictionary<string, object>> TraerAventuras()
        {
            string consulta = "SELECT ad.name AS[nameAdventure], ad.npcs AS[NPCS], ad.notes AS[notesAdventure] " +
                "FROM campaigns AS c LEFT JOIN campaigns_adventures AS ca ON c.id = ca.id_campaign LEFT JOIN adventures AS ad ON ca.id_adventure = ad.id";


            var campaigns = new List<Dictionary<string, object>>();

            campaigns = EjecutarConsulta(consulta);

            return campaigns;
        }

        public List<Dictionary<string, object>> TraerCombates()
        {
            string consulta = "SELECT co.name AS[nameCombat], co.level AS[levelCombat], co.enemies AS[enemies], co.cr AS[combatCR]" +
                "FROM campaigns AS c LEFT JOIN campaigns_combats AS cco ON c.id = cco.id_campaign LEFT JOIN combats AS co ON cco.id_combat = co.id";


            var campaigns = new List<Dictionary<string, object>>();

            campaigns = EjecutarConsulta(consulta);

            return campaigns;
        }

        public List<Dictionary<string, object>> TraerItems()
        {
            string consulta = "SELECT i.name AS[treasureName], i.description AS[treasureDescription], i.rarity AS[treasureRarity], i.cost AS[treasureCost]" +
                "FROM campaigns AS c LEFT JOIN campaigns_items ci ON c.id = ci.id_campaign LEFT JOIN items AS i ON ci.id_item = i.id";


            var campaigns = new List<Dictionary<string, object>>();

            campaigns = EjecutarConsulta(consulta);

            return campaigns;
        }

        /// <summary>
        /// Inserta datos en la tabla de la base de datos
        /// </summary>
        /// <param name="campaign">Diccionario con los datos de la fila a insertar en tabla.</param>
        public void InsertarDatos(Dictionary<string, object> campaign)
        {

            EjecutarNonQuery(ComandosDB.ArmarStringComandoNonQueryInsert(campaign, "campaigns"));


        }

        /// <summary>
        /// Actualiza datos en la tabla de la base de datos
        /// </summary>
        /// <param name="campaign">Diccionario con los datos de la fila a modificar en tabla.</param>
        public void ActualizarDatos(Dictionary<string, object> campaign)
        {
            EjecutarNonQuery(ComandosDB.ArmarStringComandoNonQueryUpdate(campaign, "campaigns"));

        }

        /// <summary>
        /// Elimina datos en la tabla de la base de datos
        /// </summary>
        /// <param name="idCampaña">id el item a eliminar de la tabla.</param>
        public void EliminarDatos(object idCampaña)
        {
            EjecutarNonQuery(ComandosDB.ArmarStringComandoNonQueryDelete(idCampaña, "campaigns"));

        }
    }
}
