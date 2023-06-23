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
    public partial class FormHechizos : Form
    {
        private FormContenedor mdiParentForm;

        /// <summary>
        /// Inicializa una nueva instania de la clase FormHechizos.
        /// </summary>
        public FormHechizos(FormContenedor parentForm)
        {
            InitializeComponent();
            mdiParentForm = parentForm;
        }
        /*
        /// <summary>
        /// Actualiza el datagrid con la informacion de una lista.
        /// </summary>
        /// <param name="ListaDiccionarios">Lista de diccionarios con la informacion para el Data Grid.</param>
        private void dataGridHechizos_Actualizar(List<Dictionary<string,object>> ListaDiccionarios)
        {
            dataGridHechizos.DataSource = null;

            var hechizos = Elemento.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGridHechizos.DataSource = hechizos;
        }*/

        /// <summary>
        /// Busca informacion en el data grid con respecto al texto en Text Box Buscador.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataGridHechizos.DataSource;
            if (string.IsNullOrEmpty(textBoxBuscador.Text))
            {
                bindingSource.RemoveFilter();
            }
            else
            {
                bindingSource.Filter = $"name LIKE '%{textBoxBuscador.Text}%'";
            }
            dataGridHechizos.DataSource = bindingSource;
        }


        /// <summary>
        /// Evento de carga de formulario
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void FormHechizos_Load(object sender, EventArgs e)
        {
            var hechizoDB = new HechizosDB();
            FormAux.dataGrid_Actualizar(hechizoDB.Traer(), dataGridHechizos);

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
                Hechizo hechizo = new Hechizo(0, "");
                hechizo.AgregarInfo(FormAux.ArmarDictEnBaseAFila(dataGridHechizos));

                FormSpellCard spellCard = new FormSpellCard((Hechizo)hechizo, mostrarBotonAgregarNuevo, mostrarBotonEditar, dataGridHechizos);
                spellCard.MdiParent = mdiParentForm;
                spellCard.WindowState = FormWindowState.Normal;
                spellCard.Show();
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

            int idFinal = dataGridHechizos.Rows.Count;


            Dictionary<string, object> dictDatosFilas = new Dictionary<string, object>();
            foreach (DataGridViewColumn column in dataGridHechizos.Columns)
            {
                switch (column.HeaderText)
                {
                    case "id":
                        dictDatosFilas[column.Name] = 0.ToString();
                        break;
                    default:
                        dictDatosFilas[column.Name] = "COMPLETAR...";
                        break;
                }

            }
            Hechizo hechizo = new Hechizo(idFinal++, "");
            hechizo.AgregarInfo(dictDatosFilas);

            FormSpellCard spellCard = new FormSpellCard((Hechizo)hechizo, mostrarBotonAgregarNuevo, mostrarBotonEditar, dataGridHechizos);

            spellCard.MdiParent = mdiParentForm;
            spellCard.WindowState = FormWindowState.Normal;

            spellCard.Show();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridHechizos.SelectedRows[0];
                var idHechizo = selectedRow.Cells[0].Value;
                var hechizoDB = new HechizosDB();
                hechizoDB.EliminarDatos(idHechizo);
                FormAux.dataGrid_Actualizar(hechizoDB.Traer(), dataGridHechizos);
                MessageBox.Show("Hechizo Eliminado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
