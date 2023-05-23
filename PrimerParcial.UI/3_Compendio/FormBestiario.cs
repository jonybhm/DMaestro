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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial.UI
{
    public partial class FormBestiario : Form
    {
        private FormContenedor mdiParentForm;

        /// <summary>
        /// Inicializa una nueva instania de la clase FormBestiario.
        /// </summary>
        public FormBestiario(FormContenedor parentForm)
        {
            InitializeComponent();
            mdiParentForm = parentForm;

        }

        /// <summary>
        /// Actualiza el datagrid con la informacion de una lista.
        /// </summary>
        /// <param name="ListaDiccionarios">Lista de diccionarios con la informacion para el Data Grid.</param>
        private void dataGridBestiario_Actualizar(List<object> ListaDiccionarios)
        {
            dataGridBestiario.DataSource = null;

            var bestiario = Elemento.ArmarTablaParaDataGrid(ListaDiccionarios);

            dataGridBestiario.DataSource = bestiario;
        }

        /// <summary>
        /// Busca informacion en el data grid con respecto al texto en Text Box Buscador.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataGridBestiario.DataSource;
            if (string.IsNullOrEmpty(textBoxBuscador.Text))
            {
                bindingSource.RemoveFilter();
            }
            else
            {
                bindingSource.Filter = $"name LIKE '%{textBoxBuscador.Text}%'";
            }
            dataGridBestiario.DataSource = bindingSource;
        }

        /// <summary>
        /// Evento de carga de formulario
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void FormBestiario_Load(object sender, EventArgs e)
        {
            dataGridBestiario_Actualizar(Elemento.LeerInfoArchivo("monsters-en-prueba"));           
        }


        /// <summary>
        /// Evento que sucede al hacer click en el boton Mostrar.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            bool mostrarBotonEditar = true;
            bool mostrarBotonAgregarNuevo = false;
            try
            {
                DataGridViewRow selectedRow = dataGridBestiario.SelectedRows[0];
                Dictionary<string, object> dictDatosFilas = new Dictionary<string, object>();
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    var datosCelda = selectedRow.Cells[i].Value;
                    string nombreColumna = dataGridBestiario.Columns[i].HeaderText;

                    dictDatosFilas.Add(nombreColumna, datosCelda);
                }

                Enemigo enemigo = new Enemigo(0, "");
                AgregarInfoEnemigo(enemigo, dictDatosFilas);

                FormStatBlock statBlock = new FormStatBlock((Enemigo)enemigo, mostrarBotonAgregarNuevo, mostrarBotonEditar);

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
        /// Evento que sucede al hacer click en el boton Agregar.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            bool mostrarBotonEditar = false;
            bool mostrarBotonAgregarNuevo = true;

            int idFinal = dataGridBestiario.Rows.Count;


            Dictionary<string, object> dictDatosFilas = new Dictionary<string, object>();
            foreach (DataGridViewColumn column in dataGridBestiario.Columns)
            {
                dictDatosFilas[column.Name] = "Contenido provisorio";
                switch (column.HeaderText)
                {
                    case "id":
                        dictDatosFilas[column.Name] = idFinal++.ToString();
                        break;
                    case "xp":
                    case "str":
                    case "dex":
                    case "con":
                    case "int":
                    case "wis":
                    case "cha":
                    case "strMod":
                    case "dexMod":
                    case "conMod":
                    case "intMod":
                    case "wisMod":
                    case "chaMod":
                    case "speedRun":
                    case "speedSwim":
                    case "speedFly":
                        dictDatosFilas[column.Name] = 0.ToString();
                        break;
                    case "senses":
                    case "languages":
                        //dictDatosFilas[column.Name] = new List<string>().ToString();
                        dictDatosFilas[column.Name] = "[\"Contenido1\",\"Contenido2\"]";
                        break;
                    case "traits":
                    case "actions":
                    case "legendaryActions":
                        //dictDatosFilas[column.Name] = new List<Dictionary<string, object>>().ToString();
                        dictDatosFilas[column.Name] = "[{\"name\":\"Titulo1\",\"text\":\"Texto1\"},{\"name\":\"Titulo2\",\"text\":\"Texto2\"}]";
                        break;
                    case "savingThrows":
                    case "skills":
                    case "source":
                        //dictDatosFilas[column.Name] = new Dictionary<string, object>().ToString();
                        dictDatosFilas[column.Name] = "{\"texto1\":0,\"texto2\":0}";
                        break;
                }

            }


            Enemigo enemigo = new Enemigo(idFinal++, "");
            AgregarInfoEnemigo(enemigo, dictDatosFilas);

            FormStatBlock statBlock = new FormStatBlock((Enemigo)enemigo, mostrarBotonAgregarNuevo, mostrarBotonEditar);

            statBlock.MdiParent = mdiParentForm;
            statBlock.WindowState = FormWindowState.Normal;
            

            statBlock.Show();

        }

        /// <summary>
        /// Carga los parametros para la instancia del objeto enemigo.
        /// </summary>
        /// <param name="enemigo">Objeto de tipo Enemigo sin valores pasados.</param>
        /// <param name="dictDatosFilas">Diccionario con la informacion de de las filas.</param>
        public static void AgregarInfoEnemigo(Enemigo enemigo, Dictionary<string, object> dictDatosFilas)
        {
            enemigo.id = int.Parse((string)dictDatosFilas["id"]);
            enemigo.name = (string)dictDatosFilas["name"];
            enemigo.meta = (string)dictDatosFilas["meta"];
            enemigo.challenge = (string)dictDatosFilas["challenge"];
            enemigo.xp = int.Parse((string)dictDatosFilas["xp"]);
            enemigo.ac = (string)dictDatosFilas["ac"];
            enemigo.hp = (string)dictDatosFilas["hp"];

            enemigo.str = int.Parse((string)dictDatosFilas["str"]);
            enemigo.dex = int.Parse((string)dictDatosFilas["dex"]);
            enemigo.con = int.Parse((string)dictDatosFilas["con"]);
            enemigo.@int = int.Parse((string)dictDatosFilas["int"]);
            enemigo.wis = int.Parse((string)dictDatosFilas["wis"]);
            enemigo.cha = int.Parse((string)dictDatosFilas["cha"]);
            enemigo.strMod = int.Parse((string)dictDatosFilas["strMod"]);
            enemigo.dexMod = int.Parse((string)dictDatosFilas["dexMod"]);
            enemigo.conMod = int.Parse((string)dictDatosFilas["conMod"]);
            enemigo.intMod = int.Parse((string)dictDatosFilas["intMod"]);
            enemigo.wisMod = int.Parse((string)dictDatosFilas["wisMod"]);
            enemigo.chaMod = int.Parse((string)dictDatosFilas["chaMod"]);
            enemigo.speedRun = int.Parse((string)dictDatosFilas["speedRun"]);
            if (!string.IsNullOrEmpty((string)dictDatosFilas["speedSwim"]))
            {
                enemigo.speedSwim = int.Parse((string)dictDatosFilas["speedSwim"]);
            }
            if (!string.IsNullOrEmpty((string)dictDatosFilas["speedFly"]))
            {
                enemigo.speedFly = int.Parse((string)dictDatosFilas["speedFly"]);
            }


            enemigo.senses = JsonSerializer.Deserialize<List<string>>((string)dictDatosFilas["senses"]);
            enemigo.languages = JsonSerializer.Deserialize<List<string>>((string)dictDatosFilas["languages"]);
            enemigo.traits = JsonSerializer.Deserialize<List<Dictionary<string, object>>>((string)dictDatosFilas["traits"]);
            enemigo.actions = JsonSerializer.Deserialize<List<Dictionary<string, object>>>((string)dictDatosFilas["actions"]);
            if (!string.IsNullOrEmpty((string)dictDatosFilas["savingThrows"]))
            {
                enemigo.savingThrows = JsonSerializer.Deserialize<Dictionary<string, object>>((string)dictDatosFilas["savingThrows"]);
            }
            else
            {
                enemigo.savingThrows = new Dictionary<string, object>();
            }

            if (!string.IsNullOrEmpty((string)dictDatosFilas["skills"]))
            {
                enemigo.skills = JsonSerializer.Deserialize<Dictionary<string, object>>((string)dictDatosFilas["skills"]);
            }
            else
            {
                enemigo.skills = new Dictionary<string, object>();
            }
            if (!string.IsNullOrEmpty((string)dictDatosFilas["legendaryActions"]))
            {
                enemigo.legendaryActions = JsonSerializer.Deserialize<List<Dictionary<string, object>>>((string)dictDatosFilas["legendaryActions"]);
            }
            else
            {
                enemigo.legendaryActions = new List<Dictionary<string, object>>();
            }

            enemigo.size = (string)dictDatosFilas["size"];
            enemigo.type = (string)dictDatosFilas["type"];
            enemigo.alignment = (string)dictDatosFilas["alignment"];

            enemigo.source = JsonSerializer.Deserialize<Dictionary<string, object>>((string)dictDatosFilas["source"]);
        }

        
    }
}
