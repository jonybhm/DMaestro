using PrimerParcial.EntcolumnaUnoades.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.Models
{
    public class Enemigo
    {
        private string _nombre;
        private int _puntosExperiencia;
        private int _challengeRating;
        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }
        public int PuntosExperiencia
        {
            get => _puntosExperiencia;
            set => _puntosExperiencia = value;
        }

        public int ChallengeRating
        {
            get => _challengeRating;
            set => _challengeRating = value;
        }

        public Enemigo(string nombre, int puntosExperiencia, int challengeRating)
        {
            _nombre = nombre;
            _puntosExperiencia = puntosExperiencia;
            _challengeRating = challengeRating;
        }

        public string Mostrar()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{_nombre}");
            sb.AppendLine($"{_puntosExperiencia}");

            return sb.ToString();
        }

        public static int CalcularXP(int nivelPromedio, int cantPersonajes, string dificultad, List<object> tablaDos )
        {
            int XP = 0;
            foreach (Dictionary<string, object> dict in tablaDos)
            {
                if (int.Parse(dict["Nivel"].ToString()) == nivelPromedio) 
                {
                    XP = cantPersonajes * int.Parse(dict[dificultad].ToString());
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
                int minimoValor = int.Parse(lista[i]["XP"].ToString());
                int cuentaHasta = int.Parse(lista[i + 1]["XP"].ToString()) - minimoValor;
                var rango = Enumerable.Range(minimoValor, cuentaHasta);

                if (rango.Contains(puntosExperiencia)) 
                {
                    CR = lista[i]["CR"].ToString();
                    break;
                }
            }
            return CR;
        }


    }
}
