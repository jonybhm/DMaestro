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

namespace PrimerParcial.UI._1_Contenedor
{
    public partial class FormItemCard : Form
    {
        private Dictionary<string, string> datosFilaItems;
        public FormItemCard(Dictionary<string, string> datosFilaItems)
        {
            InitializeComponent();
            this.datosFilaItems = datosFilaItems;

        }

        private void FormItemCard_Load(object sender, EventArgs e)
        {
            textBoxNombre.Text = datosFilaItems["name"];
            textBoxCategoria.Text = datosFilaItems["category"];
            textBoxCosto.Text = datosFilaItems["cost"];
            textBoxRareza.Text = datosFilaItems["rarity"];
            richTextBoxDescripcion.Text += datosFilaItems["description"];
            try
            {
                textBoxPropiedades.Text = Archivos.generarStringDesdeList(Archivos.deserializarJsonStringAList(datosFilaItems["properties"]));
                richTextBoxDescripcion.Text += "\n" + "Sigilo: " + datosFilaItems["stealth"];
                richTextBoxDescripcion.Text += "\n" + "AC: " + datosFilaItems["ac"];
                richTextBoxDescripcion.Text += "\n" + "Peso: " + datosFilaItems["weight"];
                richTextBoxDescripcion.Text += "\n" + "Clasificación: " + datosFilaItems["classification"];
                richTextBoxDescripcion.Text += "\n" + "Daño: " + datosFilaItems["damage"] + " | " + datosFilaItems["damageType"];
            }
            catch (Exception ex)
            {
            }

        }

    }
}
