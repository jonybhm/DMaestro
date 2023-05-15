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
        public FormReglas(string nombreArchivo)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            richTextBoxReglas.LoadFile(@$"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\RTF\{nombreArchivo}.rtf", RichTextBoxStreamType.RichText);

        }

        private void FormReglas_Load(object sender, EventArgs e)
        {

        }
    }
}
