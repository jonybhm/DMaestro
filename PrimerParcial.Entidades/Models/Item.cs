using PrimerParcial.Entidades.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
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
        public List<string> properties
        { get; set; }

        public Dictionary<string, object> source
        { get;set;}

        public Item(int id, string name) : base(id, name)
        {

        }      
    }
}
