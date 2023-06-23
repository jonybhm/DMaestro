using PrimerParcial.Entidades.Models;
using PrimerParcial.Entidades.SQL.ElementosDB;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimerParcial.UI._1_Contenedor
{

    public partial class FormSpellCard : Form
    {
        private Hechizo datosFilaHechizos;
        private bool AgregarHabilitado;
        private bool EditarHabilitado;
        private DataGridView dataGridHechizos;


        /// <summary>
        /// Inicializa una nueva instania de la clase FormSpellCard.
        /// </summary>
        public FormSpellCard(Hechizo datosFilaHechizos, bool MostrarBotonAgregar, bool MostrarBotonEditar, DataGridView dataGridHechizos)
        {
            InitializeComponent();
            this.datosFilaHechizos = datosFilaHechizos;
            this.dataGridHechizos = dataGridHechizos;
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
        private void FormSpellCard_Load(object sender, EventArgs e)
        {
            if (AgregarHabilitado && !EditarHabilitado)
            {
                buttonAdd.Enabled = true;
                buttonEdit.Enabled = false;
            }
            else
            {
                buttonAdd.Enabled = false;
                buttonEdit.Enabled = true;
            }

            textBoxId.Text = datosFilaHechizos.id.ToString();
            textBoxNombre.Text = datosFilaHechizos.name;
            textBoxNivel.Text = datosFilaHechizos.level;
            textBoxClases.Text = datosFilaHechizos.classes;
            textBoxTiempo.Text = datosFilaHechizos.casting_time;
            textBoxRango.Text = datosFilaHechizos.range;
            textBoxDuracion.Text = datosFilaHechizos.duration;
            richTextBoxDescripcion.Text = datosFilaHechizos.description;
            richTextBoxEscuela.Text = datosFilaHechizos.school;
            richTextBoxNivelSuperior.Text = datosFilaHechizos.higher_levels;
            textBoxComponentes.Text = datosFilaHechizos.components.ToString();
            
        }


        /// <summary>
        /// Evento que sucede al hacer click en el boton Agregar.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dictHechizo = CrearDictConDatosHechizo();
            var hechizoDB = new HechizosDB();
            hechizoDB.InsertarDatos(dictHechizo);
            FormAux.dataGrid_Actualizar(hechizoDB.Traer(), dataGridHechizos);
            MessageBox.Show("Hechizo Agregado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton Editar.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dictHechizo = CrearDictConDatosHechizo();
            var hechizoDB = new HechizosDB();
            hechizoDB.ActualizarDatos(dictHechizo);
            FormAux.dataGrid_Actualizar(hechizoDB.Traer(), dataGridHechizos);
            MessageBox.Show("Hechizo Editado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        /// <summary>
        /// Carga valores en un objeto item en base a los valores de los TextBox.
        /// </summary>
        private Dictionary<string, object> CrearDictConDatosHechizo()
        {
            datosFilaHechizos.id = int.Parse(textBoxId.Text);
            datosFilaHechizos.name = textBoxNombre.Text;
            datosFilaHechizos.level = textBoxNivel.Text;
            datosFilaHechizos.classes = textBoxClases.Text;
            datosFilaHechizos.components = textBoxComponentes.Text.ToString(); ;
            datosFilaHechizos.casting_time = textBoxTiempo.Text;
            datosFilaHechizos.range = textBoxRango.Text;
            datosFilaHechizos.duration = textBoxDuracion.Text;
            datosFilaHechizos.description = richTextBoxDescripcion.Text;
            datosFilaHechizos.school = richTextBoxEscuela.Text;
            datosFilaHechizos.higher_levels = richTextBoxNivelSuperior.Text;

            Dictionary<string, object> dictDatosHechizo = Elemento.CrearDictConDatos(datosFilaHechizos);

            return dictDatosHechizo;
        }
    }
}
