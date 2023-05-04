using PrimerParcial.Entidades.Models;
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
    public partial class FormCombateDificultad : Form
    {
       
        public FormCombateDificultad()
        {
            InitializeComponent();
        }

        private void dataGridEnemigos_Actualizar(List<object> ListaDiccionarios)
        {
            dataGridEnemigos.DataSource = null;

            var bestiario = Archivos.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGridEnemigos.DataSource = bestiario;
        }

        private void dataGridTablaReferencia_Actualizar(List<object> ListaDiccionarios)
        {
            dataGridTablaReferencia.DataSource = null;

            var tabla = Archivos.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGridTablaReferencia.DataSource = tabla;            
        }
        private void FormCombateDificultad_Load_1(object sender, EventArgs e)
        {
            
            dataGridEnemigos_Actualizar(Archivos.LeerInfoEnemigos());            
            dataGridTablaReferencia_Actualizar(Archivos.LeerInfoTablaUno());
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }


        /*private void button_Pin_Click(object sender, EventArgs e)
        {
            var agregarRegla = new FormAgregarRegla();
            if (agregarRegla.ShowDialog() == DialogResult.OK)
            {
                enemigo.Add(agregarRegla.ReglaNueva);
                dataGrid_Estados_Actualizar(enemigo);
            }
            else
            {
                MessageBox.Show("Error al agregar regla");
            }
        }*/

        /*private void button1_Click(object sender, EventArgs e)
        {
            Enemigo enemigo = (Enemigo)dataGridEnemigos.SelectedRows[0].DataBoundItem;

            MessageBox.Show(enemigo.Mostrar());
        }*/


    }
}
