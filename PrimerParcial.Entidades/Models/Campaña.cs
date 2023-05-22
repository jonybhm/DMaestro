using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PrimerParcial.Entidades.Models
{
    public class Campaña : Elemento
    {
        
        public string place
        {get;set;}
        public string imageUrl
        { get; set; }
        public List<Dictionary<string, object>> characters
        {get;set;}
        public List<Dictionary<string, object>> adventures
        { get;set;}
        public List<Dictionary<string,object>> combats
        { get;set;}
        public List<Dictionary<string,object>> encounters
        { get;set;}
        public List<Dictionary<string,object>> treasure
        { get;set;}
        public string notes
        { get;set;}

        public Campaña(int id, string name) :base(id,name)
        {
        }
    }
}
