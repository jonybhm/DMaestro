using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
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
        public List<Dictionary<string,object>> items
        { get;set;}
        public string notes
        { get;set;}

        /// <summary>
        /// Inicializa una nueva instania de la clase Campaña.
        /// </summary>
        /// <param name="id">identificador numerico.</param>
        /// <param name="name">nombre de la campaña.</param>
        public Campaña(int id, string name) :base(id,name)
        {
        }

        /// <summary>
        /// Carga los parametros para la instancia del objeto campaña.
        /// </summary>
        /// <param name="campaña">Objeto de tipo Campaña sin valores pasados.</param>
        /// <param name="dictDatosFilas">Diccionario con la informacion de de las filas.</param>
        public override void AgregarInfo(Dictionary<string, object> dictDatosFilas)
        {
            this.id = int.Parse((string)dictDatosFilas["id"]);
            this.name = (string)dictDatosFilas["name"];
            this.place = (string)dictDatosFilas["place"];
            this.imageUrl = (string)dictDatosFilas["imageUrl"];

            this.characters = (List<Dictionary<string, object>>)dictDatosFilas["characters"];
            this.adventures = (List<Dictionary<string, object>>)dictDatosFilas["adventures"];
            this.combats = (List<Dictionary<string, object>>)dictDatosFilas["combats"];
            this.items = (List<Dictionary<string, object>>)dictDatosFilas["items"];

            this.notes = (string)dictDatosFilas["notes"];
        }

        
    }
}
