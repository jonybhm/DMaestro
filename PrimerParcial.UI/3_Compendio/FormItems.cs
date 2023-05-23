using PrimerParcial.Entidades.Models;
using PrimerParcial.UI._1_Contenedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial.UI
{
    public partial class FormItems : Form
    {
        private FormContenedor mdiParentForm;

        /// <summary>
        /// Inicializa una nueva instania de la clase FormItems.
        /// </summary>
        public FormItems(FormContenedor parentForm)
        {
            InitializeComponent();
            mdiParentForm = parentForm;

        }

        /// <summary>
        /// Actualiza el datagrid con la informacion de una lista.
        /// </summary>
        /// <param name="ListaDiccionarios">Lista de diccionarios con la informacion para el Data Grid.</param>
        private void dataGridItems_Actualizar(List<object> ListaDiccionarios)
        {
            dataGridItems.DataSource = null;

            var items = Elemento.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGridItems.DataSource = items;
        }

        /// <summary>
        /// Busca informacion en el data grid con respecto al texto en Text Box Buscador.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataGridItems.DataSource;
            if (string.IsNullOrEmpty(textBoxBuscador.Text))
            {
                bindingSource.RemoveFilter();
            }
            else
            {
                bindingSource.Filter = $"name LIKE '%{textBoxBuscador.Text}%'";
            }
            dataGridItems.DataSource = bindingSource;
        }

        /// <summary>
        /// Evento de carga de formulario
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void FormItems_Load(object sender, EventArgs e)
        {
            dataGridItems_Actualizar(Elemento.LeerInfoArchivo("items-en-prueba"));
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton Mostrar.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            bool mostrarBotonEditar = true;
            bool mostrarBotonAgregarNuevo = false;
            try 
            { 
                DataGridViewRow selectedRow = dataGridItems.SelectedRows[0];
                Dictionary<string, object> dictDatosFilas = new Dictionary<string, object>();

                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    string datosCelda = selectedRow.Cells[i].Value.ToString();
                    string nombreColumna = dataGridItems.Columns[i].HeaderText;

                    dictDatosFilas.Add(nombreColumna, datosCelda);

                }
                Item item = new Item(0, "");
                AgregarInfoItem(item, dictDatosFilas);

                FormItemCard itemCard = new FormItemCard((Item)item, mostrarBotonEditar, mostrarBotonAgregarNuevo);
                itemCard.MdiParent = mdiParentForm;
                itemCard.WindowState = FormWindowState.Normal;
                itemCard.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una fila para mostrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
}

        /// <summary>
        /// Evento que sucede al hacer click en el boton Agregar.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            bool mostrarBotonEditar = false;
            bool mostrarBotonAgregarNuevo = true;

            int idFinal = dataGridItems.Rows.Count;


            Dictionary<string, object> dictDatosFilas = new Dictionary<string, object>();
            foreach (DataGridViewColumn column in dataGridItems.Columns)
            {
                dictDatosFilas[column.Name] = "Contenido provisorio";
                switch (column.HeaderText)
                {
                    case "id":
                        dictDatosFilas[column.Name] = idFinal++.ToString();
                        break;
                    case "cost":
                    case "weight":
                        dictDatosFilas[column.Name] = 0.ToString();
                        break;
                    case "properties":
                        dictDatosFilas[column.Name] = "[\"Contenido1\",\"Contenido2\"]";
                        break;
                    case "source":
                        dictDatosFilas[column.Name] = "{\"name\":\"\",\"link\":\"\"}";
                        break;

                }

            }
            Item item = new Item(idFinal++, "");
            AgregarInfoItem(item, dictDatosFilas);

            FormItemCard itemCard = new FormItemCard((Item)item, mostrarBotonAgregarNuevo, mostrarBotonEditar);
            itemCard.MdiParent = mdiParentForm;
            itemCard.WindowState = FormWindowState.Normal;

            itemCard.Show();

        }


        /// <summary>
        /// Carga los parametros para la instancia del objeto Item.
        /// </summary>
        /// <param name="item">Objeto de tipo Item sin valores pasados.</param>
        /// <param name="dictDatosFilas">Diccionario con la informacion de de las filas.</param>
        private void AgregarInfoItem(Item item, Dictionary<string, object> dictDatosFilas)
        {
            item.id = int.Parse((string)dictDatosFilas["id"]);
            item.name = (string)dictDatosFilas["name"];
            item.description = (string)dictDatosFilas["description"];
            item.category = (string)dictDatosFilas["category"];
            item.ac = (string)dictDatosFilas["ac"];
            item.rarity = (string)dictDatosFilas["rarity"];
            item.cost = int.Parse((string)dictDatosFilas["cost"]);
            item.weight = int.Parse((string)dictDatosFilas["weight"]);
            item.stealth = (string)dictDatosFilas["stealth"];
            item.damage = (string)dictDatosFilas["damage"];
            item.damageType = (string)dictDatosFilas["damageType"];


            item.properties = JsonSerializer.Deserialize<List<string>>((string)dictDatosFilas["properties"]);
            item.source = JsonSerializer.Deserialize<Dictionary<string, object>>((string)dictDatosFilas["source"]);
        }
    }
}
