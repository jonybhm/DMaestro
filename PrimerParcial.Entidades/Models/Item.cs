using PrimerParcial.Entidades.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.Models
{
    public class Item : Elemento
    {
        public string description
        { get;set;}        
        public string category
        { get;set;}
        public string ac
        { get;set;}
        public string rarity
        { get;set;}
        public int cost
        { get;set;}
        public int weight
        { get;set;}
        public string classification
        { get;set;}
        public string stealth
        { get;set;}
        public string damage
        { get;set;}
        public string damageType
        { get; set; }
        public string properties
        { get; set; }

        public string source
        { get;set;}

        /// <summary>
        /// Inicializa una nueva instania de la clase Item.
        /// </summary>
        /// <param name="id">identificador numerico.</param>
        /// <param name="name">nombre del item.</param>
        public Item(int id, string name) : base(id, name)
        {

        }



        /// <summary>
        /// Carga los parametros para la instancia del objeto Item.
        /// </summary>
        /// <param name="item">Objeto de tipo Item sin valores pasados.</param>
        /// <param name="dictDatosFilas">Diccionario con la informacion de de las filas.</param>
        public override void AgregarInfo(Dictionary<string, object> dictDatosFilas)
        {
            this.id = int.Parse((string)dictDatosFilas["id"]);
            this.name = (string)dictDatosFilas["name"];
            this.description = (string)dictDatosFilas["description"];
            this.category = (string)dictDatosFilas["category"];
            this.ac = (string)dictDatosFilas["ac"];
            this.rarity = (string)dictDatosFilas["rarity"];
            this.cost = int.Parse((string)dictDatosFilas["cost"]);
            this.weight = int.Parse((string)dictDatosFilas["weight"]);
            this.stealth = (string)dictDatosFilas["stealth"];
            this.damage = (string)dictDatosFilas["damage"];
            this.damageType = (string)dictDatosFilas["damageType"];
            this.properties = (string)dictDatosFilas["properties"];
            this.source = (string)dictDatosFilas["source"];
        }
    }
}
