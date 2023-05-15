using PrimerParcial.Entidades.Models;
using PrimerParcial.UI._1_Contenedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial.UI
{
    public partial class FormBestiario : Form
    {
        public FormBestiario()
        {
            InitializeComponent();
        }

        private void dataGridBestiario_Actualizar(List<object> ListaDiccionarios)
        {
            dataGridBestiario.DataSource = null;

            var bestiario = Archivos.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGridBestiario.DataSource = bestiario;
        }
        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataGridBestiario.DataSource;
            if (string.IsNullOrEmpty(textBoxBuscador.Text))
            {
                bindingSource.RemoveFilter();
            }
            else
            {
                bindingSource.Filter = $"name LIKE '%{textBoxBuscador.Text}%'";
            }
            dataGridBestiario.DataSource = bindingSource;
        }

        private void FormBestiario_Load(object sender, EventArgs e)
        {
            dataGridBestiario_Actualizar(Archivos.LeerInfoEnemigos());
        }

        private void dataGridBestiario_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridBestiario.SelectedRows[0];
            Dictionary<string, string> dictDatosFilas = new Dictionary<string, string>();
            
            for (int i = 0; i < selectedRow.Cells.Count; i++)
            {
            string datosCelda = selectedRow.Cells[i].Value.ToString();
            string nombreColumna = dataGridBestiario.Columns[i].HeaderText;
                    
            dictDatosFilas.Add(nombreColumna, datosCelda);

            }

            FormStatBlock statBlock = new FormStatBlock(dictDatosFilas);
            
            /*statBlock.MdiParent = FormContenedor;
            statBlock.WindowState = FormWindowState.Normal;
            */
            statBlock.Show();
        }
    }
}
