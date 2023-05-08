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
        
        public FormReglas()
        {
            InitializeComponent();
            richTextBoxReglas.Rtf = Archivos.ConcatenarStringsParaTextBox(Archivos.LeerInfoReglas());
            //richTextBoxReglas.Text = Archivos.ConcatenarStringsParaTextBox(Archivos.LeerInfoReglas());
        }

        private void FormReglas_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;

        }

        private void richTextBoxReglas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
