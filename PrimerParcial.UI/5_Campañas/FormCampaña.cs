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
using PrimerParcial.Entidades.SQL.ElementosDB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimerParcial.UI
{
    public partial class FormCampaña : Form
    {
        private Campaña datosCampaña;
        private bool AgregarHabilitado;
        private bool EditarHabilitado;
        private DataGridView dataGridCampañas;


        /// <summary>
        /// Inicializa una nueva instania de la clase FormCampaña.
        /// </summary>
        public FormCampaña(Campaña datosCampaña, bool MostrarBotonEditar, bool MostrarBotonAgregar, DataGridView dataGridCampañas)
        {
            InitializeComponent();
            this.datosCampaña = datosCampaña;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.AgregarHabilitado = MostrarBotonAgregar;
            this.EditarHabilitado = MostrarBotonEditar;
            this.dataGridCampañas = dataGridCampañas;
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
            textBoxURL.Text = datosCampaña.imageUrl;
            richTextBoxNotas.Text = datosCampaña.notes;

            FormAux.dataGrid_Actualizar(datosCampaña.characters, dataGridPersonajes);
            FormAux.dataGrid_Actualizar(datosCampaña.adventures, dataGridAventuras);
            FormAux.dataGrid_Actualizar(datosCampaña.combats, dataGridCombates);
            FormAux.dataGrid_Actualizar(datosCampaña.items, dataGridTesoros);

        }


        /// <summary>
        /// Evento que sucede al hacer click en el boton Agregar.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dictCampaña = CrearDictConDatosCampaña();
            var campañaDB = new CampañasDB();
            campañaDB.InsertarDatos(dictCampaña);
            FormAux.dataGrid_Actualizar(campañaDB.Traer(), dataGridCampañas);
            MessageBox.Show("Campaña Agregada", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton Editar.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dictCampaña = CrearDictConDatosCampaña();
            var campañaDB = new CampañasDB();
            campañaDB.ActualizarDatos(dictCampaña);
            FormAux.dataGrid_Actualizar(campañaDB.Traer(), dataGridCampañas);
            FormCampaña_Load(sender, e);
            MessageBox.Show("Campaña Editada", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Carga valores en un objeto item en base a los valores de los TextBox.
        /// </summary>
        private Dictionary<string, object> CrearDictConDatosCampaña()
        {
            datosCampaña.id = int.Parse(textBoxID.Text);
            datosCampaña.name = textBoxNombre.Text;
            datosCampaña.place = textBoxLugar.Text;
            datosCampaña.notes = richTextBoxNotas.Text;
            datosCampaña.imageUrl = textBoxURL.Text;

            Dictionary<string, object> dictDatosCampaña = Elemento.CrearDictConDatos(datosCampaña);

            return dictDatosCampaña;
        }
    }
}
