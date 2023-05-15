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
    public partial class FormHechizos : Form
    {
        public FormHechizos()
        {
            InitializeComponent();
        }

        private void dataGridHechizos_Actualizar(List<object> ListaDiccionarios)
        {
            dataGridHechizos.DataSource = null;

            var hechizos = Archivos.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGridHechizos.DataSource = hechizos;
        }
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

        private void FormHechizos_Load(object sender, EventArgs e)
        {
            dataGridHechizos_Actualizar(Archivos.LeerInfoHechizos());
        }

        private void dataGridHechizos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridHechizos.SelectedRows[0];
            Dictionary<string, string> dictDatosFilas = new Dictionary<string, string>();

            for (int i = 0; i < selectedRow.Cells.Count; i++)
            {
                string datosCelda = selectedRow.Cells[i].Value.ToString();
                string nombreColumna = dataGridHechizos.Columns[i].HeaderText;

                dictDatosFilas.Add(nombreColumna, datosCelda);

            }

            FormSpellCard spellCard = new FormSpellCard(dictDatosFilas);
            spellCard.Show();
        }
    }
}
