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
        }

        private void FormSpellCard_Load(object sender, EventArgs e)
        {
            textBoxNombre.Text = datosFilaHechizos["name"];
            textBoxNivel.Text = "Nivel " + datosFilaHechizos["level"] + "| Clases:" + datosFilaHechizos["classes"];
            textBoxTiempo.Text = datosFilaHechizos["casting_time"];
            textBoxRango.Text = datosFilaHechizos["range"];
            textBoxDuracion.Text = datosFilaHechizos["duration"];
            richTextBoxDescripcion.Text = datosFilaHechizos["description"];
            try
            {
                Dictionary<string, object> dict = Archivos.deserializarJsonStringADictionary(datosFilaHechizos["components"]);
                textBoxComponentes.Text = dict["raw"].ToString();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
