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

namespace PrimerParcial.UI
{
    public partial class FormAgregarRegla : Form
    {
        private Reglas _reglaNueva;

        public Reglas ReglaNueva
        {
            get => _reglaNueva;
            set => _reglaNueva = value;
        }

        public FormAgregarRegla()
        {
            InitializeComponent();
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            _reglaNueva = new Reglas(textBox1.Text, richTextBox1.Text);
            DialogResult = DialogResult.OK;
        }
    }
}
