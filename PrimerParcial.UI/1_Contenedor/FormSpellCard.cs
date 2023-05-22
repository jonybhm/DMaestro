using PrimerParcial.Entidades.Models;
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
        //private Dictionary<string, string> datosFilaHechizos;
        private Hechizo datosFilaHechizos;
        private bool AgregarHabilitado;
        private bool EditarHabilitado;

        public FormSpellCard(Hechizo datosFilaHechizos, bool MostrarBotonAgregar, bool MostrarBotonEditar)
        {
            InitializeComponent();
            this.datosFilaHechizos = datosFilaHechizos;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.AgregarHabilitado = MostrarBotonAgregar;
            this.EditarHabilitado = MostrarBotonEditar;
        }

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
            textBoxClases.Text = Elemento.generarStringDesdeList(datosFilaHechizos.classes);
            textBoxTiempo.Text = datosFilaHechizos.casting_time;
            textBoxRango.Text = datosFilaHechizos.range;
            textBoxDuracion.Text = datosFilaHechizos.duration;
            richTextBoxDescripcion.Text = datosFilaHechizos.description;
            richTextBoxEscuela.Text = datosFilaHechizos.school;
            richTextBoxNivelSuperior.Text = datosFilaHechizos.higher_levels;

            if (!string.IsNullOrWhiteSpace(datosFilaHechizos.components.ToString()))
            {
                //Dictionary<string, object> dict = JsonSerializer.Deserialize<Dictionary<string, object>>(datosFilaHechizos.components.ToString());
                textBoxComponentes.Text = datosFilaHechizos.components["raw"].ToString();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CrearDatosJsonEnBaseAHechizo();
            Elemento.AgregarInfoEnArchivo(datosFilaHechizos, "spells-en-prueba");
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            CrearDatosJsonEnBaseAHechizo();
            Elemento.ModificarInfoEnArchivo(datosFilaHechizos, "spells-en-prueba");
        }

        private void CrearDatosJsonEnBaseAHechizo()
        {
            datosFilaHechizos.id = int.Parse(textBoxId.Text);
            datosFilaHechizos.name = textBoxNombre.Text;
            datosFilaHechizos.level = textBoxNivel.Text;
            datosFilaHechizos.classes = Elemento.generarListDesdeString(textBoxClases.Text);

            Dictionary<string, object> componentes = new Dictionary<string, object>();
            componentes["raw"] = textBoxComponentes.Text.ToString();
            datosFilaHechizos.components = componentes;
            datosFilaHechizos.casting_time = textBoxTiempo.Text;
            datosFilaHechizos.range = textBoxRango.Text;
            datosFilaHechizos.duration = textBoxDuracion.Text;
            datosFilaHechizos.description = richTextBoxDescripcion.Text;
            datosFilaHechizos.school = richTextBoxEscuela.Text;
            datosFilaHechizos.higher_levels = richTextBoxNivelSuperior.Text;
        }
    }
}
