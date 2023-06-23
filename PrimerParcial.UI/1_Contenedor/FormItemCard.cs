using PrimerParcial.Entidades.Models;
using PrimerParcial.Entidades.SQL.ElementosDB;
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
        private DataGridView dataGridItems;


        /// <summary>
        /// Inicializa una nueva instania de la clase FormItemCard.
        /// </summary>
        public FormItemCard(Item datosItem, bool MostrarBotonAgregar, bool MostrarBotonEditar, DataGridView dataGridItems)
        {
            InitializeComponent();
            this.datosItem = datosItem;
            this.dataGridItems = dataGridItems;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.AgregarHabilitado = MostrarBotonAgregar;
            this.EditarHabilitado = MostrarBotonEditar;
        }

        /// <summary>
        /// Evento de carga de formulario
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
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
            textBoxPropiedades.Text = datosItem.properties;
            textBoxPeso.Text = datosItem.weight.ToString();

            textBoxClasificacion.Text = datosItem.classification;
            textBoxDaño.Text = datosItem.damage;
            textBoxDañoTipo.Text = datosItem.damageType;
            textBoxSigilo.Text = datosItem.stealth;
            textBoxAC.Text = datosItem.ac;

        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton Agregar.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dictItem = CrearDictConDatosItem();
            var itemDB = new ItemsDB();
            itemDB.InsertarDatos(dictItem);
            FormAux.dataGrid_Actualizar(itemDB.Traer(), dataGridItems);
            MessageBox.Show("Item Agregado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton Editar.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dictItem = CrearDictConDatosItem();
            var itemDB = new ItemsDB();
            itemDB.ActualizarDatos(dictItem);
            FormAux.dataGrid_Actualizar(itemDB.Traer(), dataGridItems);
            MessageBox.Show("Item Editado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }

        /// <summary>
        /// Carga valores en un objeto item en base a los valores de los TextBox.
        /// </summary>
        private Dictionary<string, object> CrearDictConDatosItem()
        {
            datosItem.id = int.Parse(textBoxId.Text) ;
            datosItem.name = textBoxNombre.Text;
            datosItem.category = textBoxCategoria.Text;
            datosItem.cost = int.Parse(textBoxCosto.Text);
            datosItem.rarity = textBoxRareza.Text;
            datosItem.description = richTextBoxDescripcion.Text;
            datosItem.properties = textBoxPropiedades.Text;
            datosItem.weight = int.Parse(textBoxPeso.Text);
            datosItem.classification = textBoxClasificacion.Text;
            datosItem.damage = textBoxDaño.Text;
            datosItem.damageType = textBoxDañoTipo.Text;
            datosItem.stealth = textBoxSigilo.Text;
            datosItem.ac = textBoxAC.Text;

            Dictionary<string, object> dictDatosItem = Elemento.CrearDictConDatos(datosItem);

            return dictDatosItem;
        }
    }
}
