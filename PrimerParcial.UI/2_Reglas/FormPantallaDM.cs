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

        /// <summary>
        /// Inicializa una nueva instania de la clase FormSpellCard.
        /// </summary>
        public FormPantallaDM()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Evento de carga de formulario
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void FormPantallaDM_Load(object sender, EventArgs e)
        {
            //CargarArchivoRTF(richTextBoxIzquierda, "Pantalla Izquierda");
            //CargarArchivoRTF(richTextBoxCentro, "Pantalla Centro");
            //CargarArchivoRTF(richTextBoxDerecha, "Pantalla Derecha");
        }
        /// <summary>
        /// Carga el archivo de texto en formato enriquecido para mostrarlo en un RichTextBox
        /// </summary>
        /// <param name="richTextBox"></param>
        /// <param name="nombreArchivo"></param>
        private void CargarArchivoRTF(RichTextBox richTextBox, string nombreArchivo)
        {
            richTextBox.LoadFile(@$"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\RTF\{nombreArchivo}.rtf", RichTextBoxStreamType.RichText);

        }

    }
}
