using PrimerParcial.Entidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimerParcial.UI
{
    public partial class FormAux : Form
    {
        public FormAux()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Actualiza el datagrid con la informacion de una lista.
        /// </summary>
        /// <param name="ListaDiccionarios">Lista de diccionarios con la informacion para el Data Grid.</param>
        public static void dataGrid_Actualizar(List<Dictionary<string, object>> ListaDiccionarios, DataGridView dataGrid)
        {
            dataGrid.DataSource = null;

            var tabla = Elemento.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGrid.DataSource = tabla;
        }

        public static Dictionary<string,object> ArmarDictEnBaseAFila(DataGridView dataGrid)
        {
            DataGridViewRow selectedRow = dataGrid.SelectedRows[0];
            Dictionary<string, object> dictDatosFilas = new Dictionary<string, object>();
            for (int i = 0; i < selectedRow.Cells.Count; i++)
            {
                var datosCelda = selectedRow.Cells[i].Value;
                string nombreColumna = dataGrid.Columns[i].HeaderText;

                dictDatosFilas.Add(nombreColumna, datosCelda);
            }

            return dictDatosFilas;
        }
    }
}
