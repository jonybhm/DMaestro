using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimerParcial.Entidades.Models;


namespace PrimerParcial.UI
{
    public partial class FormPantallaDM : Form
    {
        List<Reglas> reglas;
        public FormPantallaDM()
        {
            InitializeComponent();
            reglas = new List<Reglas>();
        }

        private void FormPantallaDM_Load(object sender, EventArgs e)
        {
            Archivos.LeerInfoArchivos(reglas);
            dataGrid_Estados_Actualizar(reglas);



        }

        private void dataGrid_Estados_Actualizar(List<Reglas> reglas)
        {
            dataGrid_Estados.DataSource = null;
            dataGrid_Estados.DataSource = reglas;
        }

        private void dataGrid_Estados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Pin_Click(object sender, EventArgs e)
        {
            var agregarRegla = new FormAgregarRegla();
            if (agregarRegla.ShowDialog() == DialogResult.OK)
            {
                reglas.Add(agregarRegla.ReglaNueva);
                dataGrid_Estados_Actualizar(reglas);
            }
            else
            {
                MessageBox.Show("Error al agregar regla");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reglas reglas = (Reglas)dataGrid_Estados.SelectedRows[0].DataBoundItem;

            MessageBox.Show(reglas.Mostrar());
        }
    }
}
