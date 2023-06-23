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
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimerParcial.UI
{
    public partial class FormCalculoDeDificultad : Form
    {
        private FormContenedor mdiParentForm;

        /// <summary>
        /// Inicializa una nueva instania de la clase FormCalculoDeDificultad.
        /// </summary>
        public FormCalculoDeDificultad(FormContenedor parentForm)
        {
            InitializeComponent();
            mdiParentForm = parentForm;

        }

        /// <summary>
        /// Actualiza el datagrid con la informacion de una lista.
        /// </summary>
        /// <param name="ListaDiccionarios">Lista de diccionarios con la informacion para el Data Grid.</param>
        private void dataGrid_Actualizar(List<Dictionary<string,object>> ListaDiccionarios, DataGridView dataGrid)
        {
            dataGrid.DataSource = null;

            var tabla = Elemento.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGrid.DataSource = tabla;
        }

        /// <summary>
        /// Busca informacion en el data grid con respecto al texto en Text Box CR.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void textBoxResultadoCR_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataGridEnemigos.DataSource;
            if (string.IsNullOrEmpty(textBoxResultadoCR.Text))
            {
                bindingSource.RemoveFilter();
            }
            else
            {
                bindingSource.Filter = $"challenge LIKE '{textBoxResultadoCR.Text}'";
            }
            dataGridEnemigos.DataSource = bindingSource;

        }

        /// <summary>
        /// Busca informacion en el data grid con respecto al texto en Text Box Buscador.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataGridEnemigos.DataSource;
            if (string.IsNullOrEmpty(textBoxBuscador.Text))
            {
                bindingSource.RemoveFilter();
            }
            else
            {
                bindingSource.Filter = $"Name LIKE '%{textBoxBuscador.Text}%'";
            }
            dataGridEnemigos.DataSource = bindingSource;
        }

        /// <summary>
        /// Evento de carga de formulario
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void FormCombateDificultad_Load_1(object sender, EventArgs e)
        {
            comboBoxDificultad.SelectedIndex = 0;
            var enemigoDB = new EnemigosDB();
            dataGrid_Actualizar(enemigoDB.Traer(), dataGridEnemigos);
            dataGrid_Actualizar(Elemento.LeerInfoArchivo("tabla1"), dataGridTablaReferencia);
            dataGrid_Actualizar(Elemento.LeerInfoArchivo("tabla2"), dataGridNivelDificultad);
            dataGrid_Actualizar(Elemento.LeerInfoArchivo("tabla3"), dataGridCantidadModificador);
        }


        /// <summary>
        /// Evento que sucede al hacer click en el boton Calcular.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonCalcualrCR_Click(object sender, EventArgs e)
        {
            try
            {
                int XP = Enemigo.CalcularXP(int.Parse(textBoxNivelPC.Text), int.Parse(textBoxCantidadPC.Text), int.Parse(textBoxCantidadEnemigos.Text),
                    comboBoxDificultad.Text, Elemento.LeerInfoArchivo("tabla2"), Elemento.LeerInfoArchivo("tabla3"));
                textBoxResultadoXP.Text = XP.ToString();
                textBoxResultadoXPporPC.Text = (XP / int.Parse(textBoxCantidadPC.Text)).ToString();

                string CR = Enemigo.CalcularCR(XP, Elemento.LeerInfoArchivo("tabla1"));
                textBoxResultadoCR.Text = CR;
            }
            catch (Exception c)
            {
                MessageBox.Show("Falta ingresar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton Mostrar.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            bool mostrarBotonEditar = false;
            bool mostrarBotonAgregarNuevo = false;
            try
            {
                DataGridViewRow selectedRow = dataGridEnemigos.SelectedRows[0];
                Dictionary<string, object> dictDatosFilas = new Dictionary<string, object>();
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    var datosCelda = selectedRow.Cells[i].Value;
                    string nombreColumna = dataGridEnemigos.Columns[i].HeaderText;

                    dictDatosFilas.Add(nombreColumna, datosCelda);
                }

                Enemigo enemigo = new Enemigo(0, "");
                enemigo.AgregarInfo(dictDatosFilas);

                FormStatBlock statBlock = new FormStatBlock((Enemigo)enemigo, mostrarBotonAgregarNuevo, mostrarBotonEditar, dataGridEnemigos);

                statBlock.MdiParent = mdiParentForm;
                statBlock.WindowState = FormWindowState.Normal;

                statBlock.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una fila para mostrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Limita el tipo de texto a ingresar a numeros y teclas de control
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Objeto que representa al iniciador del evento.</param>
        private void textBoxCantidadPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            //la caja de texto acepta solo numeros y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Limita el tipo de texto a ingresar a numeros y teclas de control
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Objeto que representa al iniciador del evento.</param>
        private void textBoxNivelPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        /// <summary>
        /// Limita el tipo de texto a ingresar a numeros y teclas de control
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Objeto que representa al iniciador del evento.</param>
        private void textBoxCantidadEnemigos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      



    }
}
