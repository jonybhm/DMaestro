﻿using PrimerParcial.Entidades.Models;
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
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial.UI
{
    public partial class FormListaDeCampañas : Form
    {
        private FormContenedor mdiParentForm;

        /// <summary>
        /// Inicializa una nueva instania de la clase FormListaDeCampañas.
        /// </summary>
        public FormListaDeCampañas(FormContenedor parentForm)
        {
            InitializeComponent();
            mdiParentForm = parentForm;

        }

        /// <summary>
        /// Actualiza el datagrid con la informacion de una lista.
        /// </summary>
        /// <param name="ListaDiccionarios">Lista de diccionarios con la informacion para el Data Grid.</param>
        private void dataGridCampañas_Actualizar(List<Dictionary<string, object>> ListaDiccionarios)
        {
            dataGridCampañas.DataSource = null;

            var listaCampañas = Elemento.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGridCampañas.DataSource = listaCampañas;
        }

        /// <summary>
        /// Busca informacion en el data grid con respecto al texto en Text Box Buscador.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
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

        /// <summary>
        /// Evento de carga de formulario
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void FormListaCampañas_Load(object sender, EventArgs e)
        {
            var campañaDB = new CampañasDB();
            dataGridCampañas_Actualizar(campañaDB.Traer());
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton Abrir.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del event
        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            bool mostrarBotonEditar = true;
            bool mostrarBotonAgregarNuevo = false;
            try { 

                DataGridViewRow selectedRow = dataGridCampañas.SelectedRows[0];
                Dictionary<string, object> dictDatosFilas = new Dictionary<string, object>();

                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    string datosCelda = selectedRow.Cells[i].Value.ToString();
                    string nombreColumna = dataGridCampañas.Columns[i].HeaderText;

                    dictDatosFilas.Add(nombreColumna, datosCelda);

                }
                var campañaDB = new CampañasDB();

                List<Dictionary<string, object>> personajesCampaña = campañaDB.TraerPersonajes();
                List<Dictionary<string, object>> aventurasCampaña = campañaDB.TraerAventuras();
                List<Dictionary<string, object>> combatesCampaña = campañaDB.TraerCombates();
                List<Dictionary<string, object>> itemsCampaña = campañaDB.TraerItems();
                Campaña campaña = new Campaña(0,"");
                campaña.AgregarInfo(dictDatosFilas);
                campaña.characters = personajesCampaña;
                campaña.adventures = aventurasCampaña;
                campaña.combats = combatesCampaña;
                campaña.treasure = itemsCampaña;


                FormCampaña formCampaña = new FormCampaña((Campaña)campaña, mostrarBotonEditar, mostrarBotonAgregarNuevo);
                
                formCampaña.MdiParent = mdiParentForm;
                formCampaña.WindowState = FormWindowState.Normal;

                formCampaña.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una fila para mostrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton Nuevo.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del event
        private void buttonNew_Click(object sender, EventArgs e)
        {
            bool mostrarBotonEditar = false;
            bool mostrarBotonAgregarNuevo = true;

            int idFinal = dataGridCampañas.Rows.Count;


            Dictionary<string, object> dictDatosFilas = new Dictionary<string, object>();
            foreach (DataGridViewColumn column in dataGridCampañas.Columns)
            {
                dictDatosFilas[column.Name] = "Contenido provisorio";
                switch (column.HeaderText)
                {
                    case "id":
                        dictDatosFilas[column.Name] = idFinal++.ToString();
                        break;
                    case "characters":
                    case "adventures":
                    case "combats":
                    case "encounters":
                    case "treasure":
                        dictDatosFilas[column.Name] = "[{\"name\":\"Contenido provisorio\"},{\"name\":\"Contenido provisorio\"}]";
                        break;                    
                }

            }


            Campaña campaña = new Campaña(idFinal++, "");
            campaña.AgregarInfo(dictDatosFilas);

            FormCampaña formCampaña = new FormCampaña((Campaña)campaña, mostrarBotonEditar, mostrarBotonAgregarNuevo);

            formCampaña.MdiParent = mdiParentForm;
            formCampaña.WindowState = FormWindowState.Normal;

            formCampaña.Show();
        }        

    }
}
