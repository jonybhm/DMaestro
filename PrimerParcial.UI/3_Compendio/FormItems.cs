using PrimerParcial.Entidades.Models;
using PrimerParcial.Entidades.SQL;
using PrimerParcial.Entidades.SQL.ElementosDB;
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

        /*/// <summary>
        /// Actualiza el datagrid con la informacion de una lista.
        /// </summary>
        /// <param name="ListaDiccionarios">Lista de diccionarios con la informacion para el Data Grid.</param>
        private void dataGridItems_Actualizar(List<Dictionary<string,object>> ListaDiccionarios)
        {
            dataGridItems.DataSource = null;

            var items = Elemento.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGridItems.DataSource = items;
        }*/

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
            var itemsDB = new ItemsDB();
            FormAux.dataGrid_Actualizar(itemsDB.Traer(), dataGridItems);
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
                /*DataGridViewRow selectedRow = dataGridItems.SelectedRows[0];
                Dictionary<string, object> dictDatosFilas = new Dictionary<string, object>();

                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    string datosCelda = selectedRow.Cells[i].Value.ToString();
                    string nombreColumna = dataGridItems.Columns[i].HeaderText;

                    dictDatosFilas.Add(nombreColumna, datosCelda);

                }*/
                Item item = new Item(0, "");
                item.AgregarInfo(FormAux.ArmarDictEnBaseAFila(dataGridItems));

                FormItemCard itemCard = new FormItemCard((Item)item, mostrarBotonAgregarNuevo, mostrarBotonEditar, dataGridItems);
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
                //dictDatosFilas[column.Name] = "Contenido provisorio";
                switch (column.HeaderText)
                {
                    case "id":
                    case "cost":
                    case "weight":
                        dictDatosFilas[column.Name] = 0.ToString();
                        break;
                    default:
                        dictDatosFilas[column.Name] = "COMPLETAR...";
                        break;

                }

            }
            Item item = new Item(idFinal++, "");
            item.AgregarInfo(dictDatosFilas);

            FormItemCard itemCard = new FormItemCard((Item)item, mostrarBotonAgregarNuevo, mostrarBotonEditar, dataGridItems);
            itemCard.MdiParent = mdiParentForm;
            itemCard.WindowState = FormWindowState.Normal;

            itemCard.Show();

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridItems.SelectedRows[0];
                var idItem = selectedRow.Cells[0].Value;
                var itemDB = new ItemsDB();
                itemDB.EliminarDatos(idItem);
                FormAux.dataGrid_Actualizar(itemDB.Traer(), dataGridItems);
                MessageBox.Show("Item Eliminado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
