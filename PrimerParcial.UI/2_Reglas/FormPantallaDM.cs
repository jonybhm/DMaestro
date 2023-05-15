using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimerParcial.Entidades.Models;


namespace PrimerParcial.UI
{
    public partial class FormPantallaDM : Form
    {
        Image tarjetaReglaImagen;
        Point posicion;
        Rectangle rectangulo;
        Tarjeta tarjetaPrueba; 
        bool enMovimiento;

        public FormPantallaDM()
        {
            InitializeComponent();
            tarjetaReglaImagen = Image.FromFile(@"C:\\Users\\JONY\\Desktop\\Programación\\2 do Cuatri\\Programacion 2\\Proyectos\\DeCastro_PrimerParcial\\Assets\\tarjetas reglas\\notas-ancladas.png");
            tarjetaPrueba = new Tarjeta("Titulo", "contenido", 200, 200, 200, 200, false);
            posicion = new Point(tarjetaPrueba.PosicionX, tarjetaPrueba.PosicionY);
            rectangulo = new Rectangle(posicion.X, posicion.Y, tarjetaPrueba.Ancho, tarjetaPrueba.Alto);
        }

        private void FormPantallaDM_MouseDown(object sender, MouseEventArgs e)
        {
            Point posicionMouse = new Point(e.X,e.Y);
            if(rectangulo.Contains(posicionMouse)) 
            {
                enMovimiento = true;                
            }
        }

        private void FormPantallaDM_MouseMove(object sender, MouseEventArgs e)
        {
            if(enMovimiento)
            {
                posicion = e.Location;
            }
        }

        private void FormPantallaDM_MouseUp(object sender, MouseEventArgs e)
        {
            if (enMovimiento)
            {
                enMovimiento = false;
                rectangulo.Location = new Point(e.X, e.Y);
            }
        }

        private void FormPantallaDM_Paint(object sender, PaintEventArgs e)
        {
            Font fuente = new Font("Universal Serif", 12);
            Brush pincel = new SolidBrush(Color.Black);
            e.Graphics.DrawString(tarjetaPrueba.Titulo, fuente, pincel,posicion.X, posicion.Y);
            e.Graphics.DrawImage(tarjetaReglaImagen, posicion.X, posicion.Y, tarjetaPrueba.Ancho, tarjetaPrueba.Alto);
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            rectangulo.X = posicion.X;
            rectangulo.Y = posicion.Y;
            
            this.Invalidate();

        }       

        private void FormPantallaDM_Load(object sender, EventArgs e)
        {

        }


        private void buttonAgregarPin_Click(object sender, EventArgs e)
        {

        }
    }
}
