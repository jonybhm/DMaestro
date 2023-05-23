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
using Microsoft.VisualBasic;
using PrimerParcial.Entidades.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimerParcial.UI
{
    public partial class FormCampaña : Form
    {
        private Campaña datosCampaña;
        private bool AgregarHabilitado;
        private bool EditarHabilitado;

        /// <summary>
        /// Inicializa una nueva instania de la clase FormCampaña.
        /// </summary>
        public FormCampaña(Campaña datosCampaña, bool MostrarBotonEditar, bool MostrarBotonAgregar)
        {
            InitializeComponent();
            this.datosCampaña = datosCampaña;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.AgregarHabilitado = MostrarBotonAgregar;
            this.EditarHabilitado = MostrarBotonEditar;

        }

        /// <summary>
        /// Evento de carga de formulario
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void FormCampaña_Load(object sender, EventArgs e)
        {
            if (AgregarHabilitado && !EditarHabilitado)
            {
                buttonAgregar.Enabled = true;
                buttonEditar.Enabled = false;
            }
            else
            {
                buttonAgregar.Enabled = false;
                buttonEditar.Enabled = true;
            }
            textBoxNombre.Text = datosCampaña.name;
            textBoxID.Text = datosCampaña.id.ToString();
            textBoxLugar.Text = datosCampaña.place;
            pictureBoxCabecera.ImageLocation = datosCampaña.imageUrl;
            richTextBoxNotas.Text = datosCampaña.notes;

            dataGrid_Actualizar(datosCampaña.characters, dataGridPersonajes);
            dataGrid_Actualizar(datosCampaña.adventures, dataGridAventuras);
            dataGrid_Actualizar(datosCampaña.combats, dataGridCombates);
            dataGrid_Actualizar(datosCampaña.encounters, dataGridEncuentros);
            dataGrid_Actualizar(datosCampaña.treasure, dataGridTesoros);

        }


        /// <summary>
        /// Actualiza el datagrid con la informacion de una lista.
        /// </summary>
        /// <param name="ListaDict">Lista de diccionarios con la informacion para el Data Grid.</param>
        /// <param name="dataGrid">Data Grid.</param>
        private void dataGrid_Actualizar(List<Dictionary<string, object>> ListaDict, DataGridView dataGrid)
        {
            dataGrid.DataSource = null;

            List<object> ListaDiccionarios = new List<object>(ListaDict.Cast<object>());

            var tabla = Elemento.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGrid.DataSource = tabla;
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton Agregar.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            CrearDatosJsonEnBaseAItem();
            Elemento.AgregarInfoEnArchivo(datosCampaña, "campañas");
            MessageBox.Show("Campaña Agregada", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton Editar.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            CrearDatosJsonEnBaseAItem();
            Elemento.ModificarInfoEnArchivo(datosCampaña, "campañas", datosCampaña.id);
            MessageBox.Show("Campaña Editada", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Carga valores en un objeto item en base a los valores de los TextBox.
        /// </summary>
        private void CrearDatosJsonEnBaseAItem()
        {
            datosCampaña.id = int.Parse(textBoxID.Text);
            datosCampaña.name = textBoxNombre.Text;
            datosCampaña.place = textBoxLugar.Text;
            datosCampaña.notes = richTextBoxNotas.Text;


        }
    }
}
