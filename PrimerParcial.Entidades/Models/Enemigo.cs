using PrimerParcial.EntcolumnaUnoades.Models;
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
    public class Enemigo : Elemento
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

        public Enemigo(int id, string name) : base(id, name)
        {

        }
        

        public static int CalcularXP(int nivelPromedio, int cantPersonajes, int cantEnemigos, string dificultad, List<object> tablaDos, List<object> tablaTres)
        {
            int XP = 0;
            foreach (Dictionary<string, object> dict in tablaDos)
            {
                if (int.Parse(dict["Nivel"].ToString()) == nivelPromedio) 
                {
                    XP = cantPersonajes * int.Parse(dict[dificultad].ToString());
                }                
            }

            if (cantEnemigos > 1)
            {
                foreach (Dictionary<string, object> dict in tablaTres)
                {
                    if (int.Parse(dict["Cantidad"].ToString()) == cantEnemigos)
                    {
                        float XPvarios;
                        XPvarios = XP / (cantEnemigos * float.Parse(dict["Modificador"].ToString(), CultureInfo.InvariantCulture));
                        XP = (int)XPvarios;
                    }
                }

            }
            return XP;                
        }

        
        public static string CalcularCR(int puntosExperiencia, List<object> tablaUno)
        {
            string CR = "";
            
            List<Dictionary<string,object>> lista = new List<Dictionary<string, object>>();

            foreach (Dictionary<string,object> item in tablaUno)
            {
                Dictionary<string, object> dict = item; 
                lista.Add(dict); 
            }

            for (int i=0; i<lista.Count; i++)
            {
                try 
                { 
                    int minimoValor = int.Parse(lista[i]["XP"].ToString());
                    int cuentaHasta = int.Parse(lista[i + 1]["XP"].ToString()) - minimoValor;
                    var rango = Enumerable.Range(minimoValor, cuentaHasta);
                    if (rango.Contains(puntosExperiencia)) 
                    {
                        CR = lista[i]["CR"].ToString();
                        break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
            return CR;
        }


    }
}
