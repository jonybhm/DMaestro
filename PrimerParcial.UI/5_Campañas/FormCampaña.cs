using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using PrimerParcial.Entidades.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimerParcial.UI
{
    public partial class Campaña : Form
    {
        private Dictionary<string, string> datosFilaListaCampañas;
        public Campaña(Dictionary<string, string> datosFilaListaCampañas)
        {
            InitializeComponent();
            this.datosFilaListaCampañas = datosFilaListaCampañas;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

        }

        private void FormCampaña_Load(object sender, EventArgs e)
        {
            textBoxNombre.Text = datosFilaListaCampañas["titulo"];
            textBoxID.Text = datosFilaListaCampañas["id"];
            textBoxLugar.Text = datosFilaListaCampañas["lugar"];
            pictureBoxCabecera.ImageLocation = datosFilaListaCampañas["imagen_url"];
            dataGrid_Actualizar(Elemento.deserializarJsonStringAListDos(datosFilaListaCampañas["personajes"]), dataGridPersonajes);
            dataGrid_Actualizar(Elemento.deserializarJsonStringAListDos(datosFilaListaCampañas["aventuras"]), dataGridAventuras);
            dataGrid_Actualizar(Elemento.deserializarJsonStringAListDos(datosFilaListaCampañas["combates"]), dataGridCombates);
            dataGrid_Actualizar(Elemento.deserializarJsonStringAListDos(datosFilaListaCampañas["encuentros"]), dataGridEncuentros);
            dataGrid_Actualizar(Elemento.deserializarJsonStringAListDos(datosFilaListaCampañas["tesoros"]), dataGridTesoros);

        }
        private void dataGrid_Actualizar(List<Dictionary<string, object>> ListaDict, DataGridView dataGrid)
        {
            dataGrid.DataSource = null;

            List<object> ListaDiccionarios = new List<object>(ListaDict.Cast<object>());

            var tabla = Elemento.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGrid.DataSource = tabla;

        }

    }
}
