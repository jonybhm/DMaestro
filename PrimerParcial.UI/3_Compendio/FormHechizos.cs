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
    public partial class FormHechizos : Form
    {
        private FormContenedor mdiParentForm;
        public FormHechizos(FormContenedor parentForm)
        {
            InitializeComponent();
            mdiParentForm = parentForm;

        }

        private void dataGridHechizos_Actualizar(List<object> ListaDiccionarios)
        {
            dataGridHechizos.DataSource = null;

            var hechizos = Elemento.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGridHechizos.DataSource = hechizos;
        }
        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataGridHechizos.DataSource;
            if (string.IsNullOrEmpty(textBoxBuscador.Text))
            {
                bindingSource.RemoveFilter();
            }
            else
            {
                bindingSource.Filter = $"name LIKE '%{textBoxBuscador.Text}%'";
            }
            dataGridHechizos.DataSource = bindingSource;
        }

        private void FormHechizos_Load(object sender, EventArgs e)
        {
            dataGridHechizos_Actualizar(Elemento.LeerInfoArchivo("spells-en-prueba"));
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            bool mostrarBotonEditar = true;
            bool mostrarBotonAgregarNuevo = false;
            try 
            { 
                DataGridViewRow selectedRow = dataGridHechizos.SelectedRows[0];
                Dictionary<string, object> dictDatosFilas = new Dictionary<string, object>();

                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    string datosCelda = selectedRow.Cells[i].Value.ToString();
                    string nombreColumna = dataGridHechizos.Columns[i].HeaderText;

                    dictDatosFilas.Add(nombreColumna, datosCelda);

                }
                Hechizo hechizo = new Hechizo(0, "");
                AgregarInfoHechizo(hechizo, dictDatosFilas);

                FormSpellCard spellCard = new FormSpellCard((Hechizo)hechizo, mostrarBotonEditar, mostrarBotonAgregarNuevo);

                spellCard.MdiParent = mdiParentForm;
                spellCard.WindowState = FormWindowState.Normal;

                spellCard.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una fila para mostrar");
            }
}

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            bool mostrarBotonEditar = false;
            bool mostrarBotonAgregarNuevo = true;

            int idFinal = dataGridHechizos.Rows.Count;


            Dictionary<string, object> dictDatosFilas = new Dictionary<string, object>();
            foreach (DataGridViewColumn column in dataGridHechizos.Columns)
            {
                dictDatosFilas[column.Name] = "Contenido provisorio";
                switch (column.HeaderText)
                {
                    case "id":
                        dictDatosFilas[column.Name] = idFinal++.ToString();
                        break;
                    case "classes":
                        dictDatosFilas[column.Name] = "[\"Contenido1\",\"Contenido2\"]";
                        break;
                    case "source":
                        dictDatosFilas[column.Name] = "{\"name\":\"\",\"link\":\"\"}";
                        break;
                    case "components":
                        dictDatosFilas[column.Name] = "{\"raw\":\"\"}";
                        break;
                }

            }


            Hechizo hechizo = new Hechizo(idFinal++, "");
            AgregarInfoHechizo(hechizo, dictDatosFilas);

            FormSpellCard spellCard = new FormSpellCard((Hechizo)hechizo, mostrarBotonAgregarNuevo, mostrarBotonEditar);

            spellCard.MdiParent = mdiParentForm;
            spellCard.WindowState = FormWindowState.Normal;

            spellCard.Show();
        }

        private void AgregarInfoHechizo(Hechizo hechizo, Dictionary<string, object> dictDatosFilas)
        {
            hechizo.id = int.Parse((string)dictDatosFilas["id"]);
            hechizo.name = (string)dictDatosFilas["name"];
            hechizo.casting_time = (string)dictDatosFilas["casting_time"];
            hechizo.classes = JsonSerializer.Deserialize<List<string>>((string)dictDatosFilas["classes"]);
            if (!string.IsNullOrEmpty((string)dictDatosFilas["components"]))
            {
                hechizo.components = JsonSerializer.Deserialize<Dictionary<string, object>>((string)dictDatosFilas["components"]);
            }
            else
            {
                hechizo.components = new Dictionary<string, object>();
            }

            hechizo.description = (string)dictDatosFilas["description"];
            hechizo.duration = (string)dictDatosFilas["duration"];
            hechizo.higher_levels = (string)dictDatosFilas["higher_levels"];

            hechizo.level = (string)dictDatosFilas["level"];
            hechizo.range = (string)dictDatosFilas["range"];
            hechizo.ritual = false;

            hechizo.school = (string)dictDatosFilas["school"];
            hechizo.type = (string)dictDatosFilas["type"];

            hechizo.source = JsonSerializer.Deserialize<Dictionary<string, object>>((string)dictDatosFilas["source"]);


        }
    }
}
