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
    public class Hechizo : Elemento
    {
        public string casting_time
        { get;set;}        
        public string classes
        { get; set; }
        public string components
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
        public string school
        { get;set;}
        public string type
        { get;set;}        

        public string source
        { get;set;}

        /// <summary>
        /// Inicializa una nueva instania de la clase Hechizo.
        /// </summary>
        /// <param name="id">identificador numerico.</param>
        /// <param name="name">nombre del hechizo.</param>
        public Hechizo(int id, string name) : base(id, name)
        {

        }

        /// <summary>
        /// Carga los parametros para la instancia del objeto Hechizo.
        /// </summary>
        /// <param name="hechizo">Objeto de tipo Hechizo sin valores pasados.</param>
        /// <param name="dictDatosFilas">Diccionario con la informacion de de las filas.</param>
        public override void AgregarInfo(Dictionary<string, object> dictDatosFilas)
        {
            this.id = int.Parse((string)dictDatosFilas["id"]);
            this.name = (string)dictDatosFilas["name"];
            this.casting_time = (string)dictDatosFilas["casting_time"];
            this.classes = (string)dictDatosFilas["classes"];
            this.components = (string)dictDatosFilas["components"];
            this.description = (string)dictDatosFilas["description"];
            this.duration = (string)dictDatosFilas["duration"];
            this.higher_levels = (string)dictDatosFilas["higher_levels"];
            this.level = (string)dictDatosFilas["level"];
            this.range = (string)dictDatosFilas["range"];
            this.school = (string)dictDatosFilas["school"];
            this.type = (string)dictDatosFilas["type"];
            this.source = (string)dictDatosFilas["source"];


        }
    }
}
