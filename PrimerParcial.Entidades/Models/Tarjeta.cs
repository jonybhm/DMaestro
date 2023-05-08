using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.Models
{
    public class Tarjeta
    {
        
        private string _titulo;
        private string _contenido;
        private int _ancho;
        private int _alto;
        private int _posicionX;
        private int _posicionY;
        private bool _esNuevo;
        private bool _enMovimiento;
        public string Titulo 
        { 
            get => _titulo; 
            set => value = _titulo; 
        }
        public string Contenido
        {
            get => _contenido;
            set => value = _contenido;
        }
        public int Ancho
        {
            get => _ancho;
            set => value = _ancho;
        }
        public int Alto
        {
            get => _alto;
            set => value = _alto;
        }
        public int PosicionX
        {
            get => _posicionX;
            set => value = _posicionX;
        }

        public int PosicionY
        {
            get => _posicionY;
            set => value = _posicionY;
        }
        public bool EsNuevo
        {
            get => _esNuevo;
            set => value = _esNuevo;
        }

        public bool EnMovimiento
        {
            get => _enMovimiento;
            set => value = _enMovimiento;
        }
        public Tarjeta(string titulo ,string contenido,int ancho, int alto, int posicionX, int posicionY, bool esNuevo)
        {
            _contenido = contenido;
            _titulo = titulo;   
            _contenido = contenido;
            _ancho = ancho;
            _alto = alto;
            _posicionX = posicionX;
            _posicionY = posicionY;
            _esNuevo = esNuevo;
        }

        

    }
}
