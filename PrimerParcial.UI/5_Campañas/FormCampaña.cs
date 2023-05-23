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
        public FormCampaña(Campaña datosCampaña, bool MostrarBotonAgregar, bool MostrarBotonEditar)
        {
            InitializeComponent();
            this.datosCampaña = datosCampaña;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.AgregarHabilitado = MostrarBotonAgregar;
            this.EditarHabilitado = MostrarBotonEditar;

        }

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

            dataGrid_Actualizar(datosCampaña.characters, dataGridPersonajes);
            dataGrid_Actualizar(datosCampaña.adventures, dataGridAventuras);
            dataGrid_Actualizar(datosCampaña.combats, dataGridCombates);
            dataGrid_Actualizar(datosCampaña.encounters, dataGridEncuentros);
            dataGrid_Actualizar(datosCampaña.treasure, dataGridTesoros);
            //dataGrid_Actualizar(JsonSerializer.Deserialize<List<Dictionary<string, object>>>(datosCampaña.adventures), dataGridAventuras);
            //dataGrid_Actualizar(JsonSerializer.Deserialize<List<Dictionary<string, object>>>(datosCampaña.combats), dataGridCombates);
            //dataGrid_Actualizar(JsonSerializer.Deserialize<List<Dictionary<string, object>>>(datosCampaña.encounters), dataGridEncuentros);
            //dataGrid_Actualizar(JsonSerializer.Deserialize<List<Dictionary<string, object>>>(datosCampaña.treasure), dataGridTesoros);

        }
        private void dataGrid_Actualizar(List<Dictionary<string, object>> ListaDict, DataGridView dataGrid)
        {
            dataGrid.DataSource = null;

            List<object> ListaDiccionarios = new List<object>(ListaDict.Cast<object>());

            var tabla = Elemento.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGrid.DataSource = tabla;

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            CrearDatosJsonEnBaseAItem();
            Elemento.AgregarInfoEnArchivo(datosCampaña, "campañas");
            MessageBox.Show("Campaña Agregada");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            CrearDatosJsonEnBaseAItem();
            Elemento.ModificarInfoEnArchivo(datosCampaña, "campañas", datosCampaña.id);
            MessageBox.Show("Campaña Editada");
        }
        private void CrearDatosJsonEnBaseAItem()
        {
            datosCampaña.id = int.Parse(textBoxID.Text);
            datosCampaña.name = textBoxNombre.Text;
            datosCampaña.place = textBoxLugar.Text;
            
            /*datosCampaña.characters = 
            datosCampaña.adventures = 
            datosCampaña.combats = 
            datosCampaña.encounters = 
            datosCampaña.treasure = */

        }
    }
}
