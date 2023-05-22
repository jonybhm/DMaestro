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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimerParcial.UI._1_Contenedor
{
    public partial class FormItemCard : Form
    {
        private Item datosItem;
        private bool AgregarHabilitado;
        private bool EditarHabilitado;
        public FormItemCard(Item datosItem, bool MostrarBotonAgregar, bool MostrarBotonEditar)
        {
            InitializeComponent();
            this.datosItem = datosItem;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.AgregarHabilitado = MostrarBotonAgregar;
            this.EditarHabilitado = MostrarBotonEditar;
        }

        private void FormItemCard_Load(object sender, EventArgs e)
        {
            if (AgregarHabilitado && !EditarHabilitado)
            {
                buttonAdd.Enabled = true;
                buttonEdit.Enabled = false;
            }
            else
            {
                buttonAdd.Enabled = false;
                buttonEdit.Enabled = true;
            }

            textBoxId.Text = datosItem.id.ToString();
            textBoxNombre.Text = datosItem.name;
            textBoxCategoria.Text = datosItem.category;
            textBoxCosto.Text = datosItem.cost.ToString();
            textBoxRareza.Text = datosItem.rarity;
            richTextBoxDescripcion.Text = datosItem.description;
            textBoxPropiedades.Text = Elemento.generarStringDesdeList(datosItem.properties);
            textBoxPeso.Text = datosItem.weight.ToString();

            textBoxClasificacion.Text = datosItem.classification;
            textBoxDaño.Text = datosItem.damage;
            textBoxDañoTipo.Text = datosItem.damageType;
            textBoxSigilo.Text = datosItem.stealth;
            textBoxAC.Text = datosItem.ac;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CrearDatosJsonEnBaseAItem();
            Elemento.AgregarInfoEnArchivo(datosItem, "items-en-prueba");
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            CrearDatosJsonEnBaseAItem();
            Elemento.ModificarInfoEnArchivo(datosItem, "items-en-prueba");
        }

        private void CrearDatosJsonEnBaseAItem()
        {
            datosItem.id = int.Parse(textBoxId.Text) ;
            datosItem.name = textBoxNombre.Text;
            datosItem.category = textBoxCategoria.Text;
            datosItem.cost = int.Parse(textBoxCosto.Text);
            datosItem.rarity = textBoxRareza.Text;
            datosItem.description = richTextBoxDescripcion.Text;
            datosItem.properties = Elemento.generarListDesdeString(textBoxPropiedades.Text);
            datosItem.weight = int.Parse(textBoxPeso.Text);
            datosItem.classification = textBoxClasificacion.Text;
            datosItem.damage = textBoxDaño.Text;
            datosItem.damageType = textBoxDañoTipo.Text;
            datosItem.stealth = textBoxSigilo.Text;
            datosItem.ac = textBoxAC.Text;
        }
    }
}
