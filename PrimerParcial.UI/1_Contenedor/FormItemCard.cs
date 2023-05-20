using PrimerParcial.Entidades.Models;
using System;
using System.Collections;
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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void FormItemCard_Load(object sender, EventArgs e)
        {
            
                    
            textBoxNombre.Text = datosFilaItems["name"];
            textBoxCategoria.Text = datosFilaItems["category"];
            textBoxCosto.Text = datosFilaItems["cost"];
            textBoxRareza.Text = datosFilaItems["rarity"];
            richTextBoxDescripcion.Text += datosFilaItems["description"];
            if(!string.IsNullOrWhiteSpace(datosFilaItems["properties"]))
            {
                textBoxPropiedades.Text = Elemento.generarStringDesdeList(Elemento.deserializarJsonStringAList(datosFilaItems["properties"]));
            }
            if (!string.IsNullOrWhiteSpace(datosFilaItems["weight"]))
            {
                richTextBoxDescripcion.Text += "\n" + " - " + "Peso: " + datosFilaItems["weight"];
            }
            if (!string.IsNullOrWhiteSpace(datosFilaItems["classification"]))
            {
                richTextBoxDescripcion.Text += "\n" + " - " + "Clasificación: " + datosFilaItems["classification"];
            }
            if (!string.IsNullOrWhiteSpace(datosFilaItems["damage"]))
            {
                richTextBoxDescripcion.Text += "\n" + " - " + "Daño: " + datosFilaItems["damage"] + " - " + datosFilaItems["damageType"];
            }
            if (!string.IsNullOrWhiteSpace(datosFilaItems["stealth"]))
            {
                richTextBoxDescripcion.Text += "\n" + " - " + "Sigilo: " + datosFilaItems["stealth"];
            }
            if (!string.IsNullOrWhiteSpace(datosFilaItems["ac"]))
            {
                richTextBoxDescripcion.Text += "\n" + " - " + "AC: " + datosFilaItems["ac"];
            }           
        }       
       
    }
}
