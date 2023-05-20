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

namespace PrimerParcial.UI._1_Contenedor
{
    public partial class FormSpellCard : Form
    {
        private Dictionary<string, string> datosFilaHechizos;

        public FormSpellCard(Dictionary<string, string> datosFilaHechizos)
        {
            InitializeComponent();
            this.datosFilaHechizos = datosFilaHechizos;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void FormSpellCard_Load(object sender, EventArgs e)
        {
            textBoxNombre.Text = datosFilaHechizos["name"];
            textBoxNivel.Text = "Nivel " + datosFilaHechizos["level"] + "| Clases:" + datosFilaHechizos["classes"];
            textBoxTiempo.Text = datosFilaHechizos["casting_time"];
            textBoxRango.Text = datosFilaHechizos["range"];
            textBoxDuracion.Text = datosFilaHechizos["duration"];
            richTextBoxDescripcion.Text += datosFilaHechizos["description"];
            richTextBoxDescripcion.Text += "\n" + " - " + datosFilaHechizos["school"];

            if (!string.IsNullOrWhiteSpace(datosFilaHechizos["higher_levels"]))
            {
                richTextBoxDescripcion.Text += "\n" + " - " + "A niveles superiores: " + datosFilaHechizos["higher_levels"];
            }

            if (!string.IsNullOrWhiteSpace(datosFilaHechizos["components"]))
            {
                Dictionary<string, object> dict = Elemento.deserializarJsonStringADictionary(datosFilaHechizos["components"]);
                textBoxComponentes.Text = dict["raw"].ToString();
            }
        }
    }
}
