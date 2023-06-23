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
    public class Personaje : Elemento
    {
        public string meta
        {get;set;}        
        public string challenge
        { get; set; }
        public int xp
        {get;set;}
        public string ac
        {get;set;}
        public string hp
        {get;set;}
        public int str
        {get;set;}
        public int dex
        {get;set;}
        public int con
        {get;set;}
        public int @int
        {get;set;}
        public int wis
        {get;set;}
        public int cha
        {get;set;}
        public int strMod
        {get;set;}
        public int dexMod
        {get;set;}
        public int conMod
        {get;set;}
        public int intMod
        {get;set;}
        public int wisMod
        {get;set;}
        public int chaMod
        {get;set;}
        public int speedRun
        {get;set;}
        public int speedSwim
        {get;set;}
        public int speedFly
        {get;set;}
        public List<string > senses
        {get;set;}
        public List<string> languages
        {get;set;}
        public List<Dictionary<string, object>> traits
        {get;set;}
        public List<Dictionary<string, object>> actions
        {get;set;}
        public List<Dictionary<string, object>> legendaryActions
        { get;set;}
        public Dictionary<string, object> savingThrows
        { get;set;}
        public Dictionary<string, object> skills
        { get;set;}
        public string size
        { get;set;}
        public string @type
        {get;set;}
        public string alignment
        { get;set;}
        public Dictionary<string, object> source
        { get;set;}

        /// <summary>
        /// Inicializa una nueva instania de la clase Personaje.
        /// </summary>
        /// <param name="id">identificador numerico.</param>
        /// <param name="name">nombre de la campaña.</param>
        public Personaje(int id, string name) : base(id, name)
        {

        }



        /// <summary>
        /// Carga los parametros para la instancia del objeto enemigo.
        /// </summary>
        /// <param name="enemigo">Objeto de tipo Personaje sin valores pasados.</param>
        /// <param name="dictDatosFilas">Diccionario con la informacion de de las filas.</param>
        public override void AgregarInfo(Dictionary<string, object> dictDatosFilas)
        {
            this.id = int.Parse((string)dictDatosFilas["id"]);
            this.name = (string)dictDatosFilas["name"];
            this.meta = (string)dictDatosFilas["meta"];
            this.challenge = (string)dictDatosFilas["challenge"];
            this.xp = int.Parse((string)dictDatosFilas["xp"]);
            this.ac = (string)dictDatosFilas["ac"];
            this.hp = (string)dictDatosFilas["hp"];

            this.str = int.Parse((string)dictDatosFilas["str"]);
            this.dex = int.Parse((string)dictDatosFilas["dex"]);
            this.con = int.Parse((string)dictDatosFilas["con"]);
            this.@int = int.Parse((string)dictDatosFilas["int"]);
            this.wis = int.Parse((string)dictDatosFilas["wis"]);
            this.cha = int.Parse((string)dictDatosFilas["cha"]);
            this.strMod = int.Parse((string)dictDatosFilas["strMod"]);
            this.dexMod = int.Parse((string)dictDatosFilas["dexMod"]);
            this.conMod = int.Parse((string)dictDatosFilas["conMod"]);
            this.intMod = int.Parse((string)dictDatosFilas["intMod"]);
            this.wisMod = int.Parse((string)dictDatosFilas["wisMod"]);
            this.chaMod = int.Parse((string)dictDatosFilas["chaMod"]);
            this.speedRun = int.Parse((string)dictDatosFilas["speedRun"]);
            if (!string.IsNullOrEmpty((string)dictDatosFilas["speedSwim"]))
            {
                this.speedSwim = int.Parse((string)dictDatosFilas["speedSwim"]);
            }
            if (!string.IsNullOrEmpty((string)dictDatosFilas["speedFly"]))
            {
                this.speedFly = int.Parse((string)dictDatosFilas["speedFly"]);
            }


            this.senses = JsonSerializer.Deserialize<List<string>>((string)dictDatosFilas["senses"]);
            this.languages = JsonSerializer.Deserialize<List<string>>((string)dictDatosFilas["languages"]);
            this.traits = JsonSerializer.Deserialize<List<Dictionary<string, object>>>((string)dictDatosFilas["traits"]);
            this.actions = JsonSerializer.Deserialize<List<Dictionary<string, object>>>((string)dictDatosFilas["actions"]);
            if (!string.IsNullOrEmpty((string)dictDatosFilas["savingThrows"]))
            {
                this.savingThrows = JsonSerializer.Deserialize<Dictionary<string, object>>((string)dictDatosFilas["savingThrows"]);
            }
            else
            {
                this.savingThrows = new Dictionary<string, object>();
            }

            if (!string.IsNullOrEmpty((string)dictDatosFilas["skills"]))
            {
                this.skills = JsonSerializer.Deserialize<Dictionary<string, object>>((string)dictDatosFilas["skills"]);
            }
            else
            {
                this.skills = new Dictionary<string, object>();
            }
            if (!string.IsNullOrEmpty((string)dictDatosFilas["legendaryActions"]))
            {
                this.legendaryActions = JsonSerializer.Deserialize<List<Dictionary<string, object>>>((string)dictDatosFilas["legendaryActions"]);
            }
            else
            {
                this.legendaryActions = new List<Dictionary<string, object>>();
            }

            this.size = (string)dictDatosFilas["size"];
            this.type = (string)dictDatosFilas["type"];
            this.alignment = (string)dictDatosFilas["alignment"];

            this.source = JsonSerializer.Deserialize<Dictionary<string, object>>((string)dictDatosFilas["source"]);
        }

    }
}
