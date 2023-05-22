using PrimerParcial.Entidades.Models;
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

        public FormListaDeCampañas(FormContenedor parentForm)
        {
            InitializeComponent();
            mdiParentForm = parentForm;

        }
        private void dataGridCampañas_Actualizar(List<object> ListaDiccionarios)
        {
            dataGridCampañas.DataSource = null;

            var listaCampañas = Elemento.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGridCampañas.DataSource = listaCampañas;
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

        private void FormListaCampañas_Load(object sender, EventArgs e)
        {
            dataGridCampañas_Actualizar(Elemento.LeerInfoArchivo("campañas"));
        }

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

                Campaña campaña = new Campaña(0,"");
                AgregarInfoCampaña(campaña, dictDatosFilas);
                                
                FormCampaña formCampaña = new FormCampaña((Campaña)campaña, mostrarBotonEditar, mostrarBotonAgregarNuevo);
                
                formCampaña.MdiParent = mdiParentForm;
                formCampaña.WindowState = FormWindowState.Normal;

                formCampaña.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una fila para mostrar");
            }
}
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
            AgregarInfoCampaña(campaña, dictDatosFilas);

            FormCampaña formCampaña = new FormCampaña((Campaña)campaña, mostrarBotonEditar, mostrarBotonAgregarNuevo);

            formCampaña.MdiParent = mdiParentForm;
            formCampaña.WindowState = FormWindowState.Normal;

            formCampaña.Show();
        }
        private void AgregarInfoCampaña(Campaña campaña, Dictionary<string, object> dictDatosFilas)
        {
            campaña.id = int.Parse((string)dictDatosFilas["id"]);
            campaña.name = (string)dictDatosFilas["name"];
            campaña.place = (string)dictDatosFilas["place"];
            campaña.imageUrl = (string)dictDatosFilas["imageUrl"];

            /*campaña.characters = (List<Dictionary<string, object>>)dictDatosFilas["characters"];
            campaña.combats = (List<Dictionary<string, object>>)dictDatosFilas["combats"];
            campaña.encounters = (List<Dictionary<string, object>>)dictDatosFilas["encounters"];
            campaña.treasure = (List<Dictionary<string, object>>)dictDatosFilas["treasure"];*/

            campaña.characters = JsonSerializer.Deserialize<List<Dictionary<string, object>>>((string)dictDatosFilas["characters"]);
            campaña.adventures = JsonSerializer.Deserialize<List<Dictionary<string, object>>>((string)dictDatosFilas["adventures"]);
            campaña.combats = JsonSerializer.Deserialize<List<Dictionary<string, object>>>((string)dictDatosFilas["combats"]);
            campaña.encounters = JsonSerializer.Deserialize<List<Dictionary<string, object>>>((string)dictDatosFilas["encounters"]);
            campaña.treasure = JsonSerializer.Deserialize<List<Dictionary<string, object>>>((string)dictDatosFilas["treasure"]);

            campaña.notes = (string)dictDatosFilas["notes"];


        }

    }
}
