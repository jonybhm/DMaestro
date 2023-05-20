using PrimerParcial.Entidades.Models;
using PrimerParcial.UI._1_Contenedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial.UI
{
    public partial class FormItems : Form
    {
        public FormItems()
        {
            InitializeComponent();
        }
        private void dataGridItems_Actualizar(List<object> ListaDiccionarios)
        {
            dataGridItems.DataSource = null;

            var items = Elemento.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGridItems.DataSource = items;
        }
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

        private void FormItems_Load(object sender, EventArgs e)
        {
            dataGridItems_Actualizar(Elemento.LeerInfoArchivo("items-en"));
        }

        private void dataGridItems_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridItems.SelectedRows[0];
            Dictionary<string, string> dictDatosFilas = new Dictionary<string, string>();

            for (int i = 0; i < selectedRow.Cells.Count; i++)
            {
                string datosCelda = selectedRow.Cells[i].Value.ToString();
                string nombreColumna = dataGridItems.Columns[i].HeaderText;

                dictDatosFilas.Add(nombreColumna, datosCelda);

            }

            FormItemCard itemCard = new FormItemCard(dictDatosFilas);
            itemCard.Show();
        }
    }
}
