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
    public class Hechizo : Elemento
    {
        public string casting_time
        { get;set;}        
        public List<string> classes
        { get; set; }
        public Dictionary<string, object> components
        { get;set;}
        public string description
        { get;set;}
        public string duration
        { get;set;}
        public string higher_levels
        { get;set;}
        public string level
        { get;set;}
        public string range
        { get;set;}
        public bool ritual
        { get;set;}
        public string school
        { get;set;}
        public string type
        { get;set;}        

        public Dictionary<string, object> source
        { get;set;}

        /// <summary>
        /// Inicializa una nueva instania de la clase Hechizo.
        /// </summary>
        /// <param name="id">identificador numerico.</param>
        /// <param name="name">nombre del hechizo.</param>
        public Hechizo(int id, string name) : base(id, name)
        {

        }      
    }
}
