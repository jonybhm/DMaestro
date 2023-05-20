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
    public partial class FormListaDeCampañas : Form
    {
        public FormListaDeCampañas()
        {
            InitializeComponent();
        }
        private void dataGridCampañas_Actualizar(List<object> ListaDiccionarios)
        {
            dataGridCampañas.DataSource = null;

            var bestiario = Elemento.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGridCampañas.DataSource = bestiario;
        }
        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataGridCampañas.DataSource;
            if (string.IsNullOrEmpty(textBoxBuscador.Text))
            {
                bindingSource.RemoveFilter();
            }
            else
            {
                bindingSource.Filter = $"name LIKE '%{textBoxBuscador.Text}%'";
            }
            dataGridCampañas.DataSource = bindingSource;
        }

        private void FormCampañas_Load(object sender, EventArgs e)
        {
        }

        private void dataGridCampañas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridCampañas.SelectedRows[0];
            Dictionary<string, string> dictDatosFilas = new Dictionary<string, string>();

            for (int i = 0; i < selectedRow.Cells.Count; i++)
            {
                string datosCelda = selectedRow.Cells[i].Value.ToString();
                string nombreColumna = dataGridCampañas.Columns[i].HeaderText;

                dictDatosFilas.Add(nombreColumna, datosCelda);

            }

            Campaña campaña = new Campaña(dictDatosFilas);

            /*statBlock.MdiParent = FormContenedor;
            statBlock.WindowState = FormWindowState.Normal;
            */
            campaña.Show();
        }

        private void FormListaCampañas_Load(object sender, EventArgs e)
        {
            dataGridCampañas_Actualizar(Elemento.LeerInfoArchivo("campañas"));
        }
    }
}
