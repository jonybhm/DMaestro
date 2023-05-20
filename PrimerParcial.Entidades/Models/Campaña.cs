using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.Models
{
    internal class Campaña
    {
        private int _id;
        private string _tituloCampaña;
        private string _lugar;
        private List<Dictionary<string,object>> _personajes;
        private List<Dictionary<string, object>> _aventuras;
        private List<Dictionary<string, object>> _combates;
        private List<Dictionary<string, object>> _encuentros;
        private List<Dictionary<string, object>> _tesoros;
        private string _notas;
        public int Id 
        { 
            get => _id;
            set => _id = value; 
        }

        public string TituloCampaña
        {
            get => _tituloCampaña;
            set => _tituloCampaña = value;
        }
        public string Lugar
        {
            get => _lugar;
            set => _lugar = value;
        }
        public List<Dictionary<string, object>> Personajes
        {
            get => _personajes;
            set => _personajes = value;
        }
        public List<Dictionary<string, object>> Aventuras
        {
            get => _aventuras;
            set => _aventuras = value;
        }
        public List<Dictionary<string,object>>  Combates
        {
            get => _combates;
            set => _combates = value;
        }
        public List<Dictionary<string,object>>  Encuentros
        {
            get => _encuentros;
            set => _encuentros = value;
        }
        public List<Dictionary<string,object>>  Tesoros
        {
            get => _tesoros;
            set => _tesoros = value;
        }
        public string Notas
        {
            get => _notas;
            set => _notas = value;
        }

        public Campaña(int id, string tituloCampaña, string lugar, List<Dictionary<string, object>> personajes, 
            List<Dictionary<string, object>> aventuras, List<Dictionary<string, object>> combates, List<Dictionary<string, object>> encuentros, 
            List<Dictionary<string, object>> tesoros, string notas)
        {
            Id = id;
            TituloCampaña = tituloCampaña;
            Lugar = lugar;
            Personajes = personajes;
            Aventuras = aventuras;
            Combates = combates;
            Encuentros = encuentros;
            Tesoros = tesoros;
            Notas = notas;
        }
    }
}
