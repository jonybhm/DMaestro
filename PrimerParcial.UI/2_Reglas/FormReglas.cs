using PrimerParcial.Entidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimerParcial.UI
{
    public partial class FormReglas : Form
    {
        private string nombreArchivo;

        /// <summary>
        /// Inicializa una nueva instania de la clase FormSpellCard.
        /// </summary>
        public FormReglas(string Archivo)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            nombreArchivo = Archivo;

        }

        /// <summary>
        /// Evento de carga de formulario
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void FormReglas_Load(object sender, EventArgs e)
        {
            richTextBoxReglas.LoadFile(@$"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\RTF\{nombreArchivo}.rtf", RichTextBoxStreamType.RichText);

        }
    }
}
