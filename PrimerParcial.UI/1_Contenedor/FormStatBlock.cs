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
using PrimerParcial.Entidades.Models;
using PrimerParcial.Entidades.SQL.ElementosDB;
using System.Collections;
using System.Reflection;

namespace PrimerParcial.UI._1_Contenedor
{
    public partial class FormStatBlock : Form
    {
        private Enemigo datosEnemigo;
        private bool AgregarHabilitado;
        private bool EditarHabilitado;
        private DataGridView dataGridBestiario;

        /// <summary>
        /// Inicializa una nueva instania de la clase FormStatBlock.
        /// </summary>
        public FormStatBlock(Enemigo datosEnemigo, bool MostrarBotonAgregar, bool MostrarBotonEditar, DataGridView dataGridBestiario)
        {
            InitializeComponent();
            this.datosEnemigo = datosEnemigo;
            this.dataGridBestiario = dataGridBestiario;
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
        private void FormStatBlock_Load(object sender, EventArgs e)
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
            textBoxId.Text = datosEnemigo.id.ToString();
            textBoxNombre.Text = datosEnemigo.name;
            textBoxTipo.Text = datosEnemigo.meta;
            textBoxAC.Text = datosEnemigo.ac;
            textBoxHP.Text = datosEnemigo.hp;
            textBoxVelocidadPie.Text = datosEnemigo.speedRun.ToString();
            textBoxVelocidadVuelo.Text = datosEnemigo.speedFly.ToString();
            textBoxVelocidadNado.Text = datosEnemigo.speedSwim.ToString();
            textBoxFUE.Text = datosEnemigo.str.ToString();
            textBoxDES.Text = datosEnemigo.dex.ToString();
            textBoxINT.Text = datosEnemigo.@int.ToString();
            textBoxCON.Text = datosEnemigo.con.ToString();
            textBoxCAR.Text = datosEnemigo.cha.ToString();
            textBoxSAB.Text = datosEnemigo.wis.ToString();
            textBoxFUEMod.Text = datosEnemigo.strMod.ToString();
            textBoxDESMod.Text = datosEnemigo.dexMod.ToString();
            textBoxINTMod.Text = datosEnemigo.intMod.ToString();
            textBoxCONMod.Text = datosEnemigo.conMod.ToString();
            textBoxCARMod.Text = datosEnemigo.chaMod.ToString();
            textBoxSABMod.Text = datosEnemigo.wisMod.ToString();
            textBoxSalvacion.Text = datosEnemigo.savingThrows.ToString();
            textBoxHabilidades.Text = datosEnemigo.skills.ToString();
            textBoxSentidos.Text = datosEnemigo.senses.ToString();
            textBoxIdiomas.Text = datosEnemigo.languages.ToString();
            textBoxDesafio.Text = datosEnemigo.challenge;
            textBoxExperiencia.Text = datosEnemigo.xp.ToString();
            richTextBoxHabilidades.Text = datosEnemigo.traits.ToString();
            richTextBoxAcciones.Text = datosEnemigo.actions.ToString();
            richTextBoxAccionesLegendarias.Text = datosEnemigo.legendaryActions.ToString();            

        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton Agregar.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Dictionary<string,object> dictEnemigo = CrearDictConDatosEnemigo();
            var enemigoDB = new EnemigosDB();
            enemigoDB.InsertarDatos(dictEnemigo);
            FormAux.dataGrid_Actualizar(enemigoDB.Traer(), dataGridBestiario);
            MessageBox.Show("Enemigo Agregado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton Editar.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            
            Dictionary<string, object> dictEnemigo = CrearDictConDatosEnemigo();
            var enemigoDB = new EnemigosDB();
            enemigoDB.ActualizarDatos(dictEnemigo);
            FormAux.dataGrid_Actualizar(enemigoDB.Traer(), dataGridBestiario);
            MessageBox.Show("Monstruo Editado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /// <summary>
        /// Carga valores en un objeto item en base a los valores de los TextBox.
        /// </summary>
        private Dictionary<string, object> CrearDictConDatosEnemigo()
        {

            datosEnemigo.id = int.Parse(textBoxId.Text);
            datosEnemigo.name = textBoxNombre.Text;
            datosEnemigo.meta = textBoxTipo.Text;
            datosEnemigo.ac = textBoxAC.Text;
            datosEnemigo.hp = textBoxHP.Text;
            datosEnemigo.speedRun = int.Parse(textBoxVelocidadPie.Text);
            datosEnemigo.speedFly = int.Parse(textBoxVelocidadVuelo.Text);
            datosEnemigo.speedSwim = int.Parse(textBoxVelocidadNado.Text);
            datosEnemigo.str = int.Parse(textBoxFUE.Text);
            datosEnemigo.dex = int.Parse(textBoxDES.Text);
            datosEnemigo.@int = int.Parse(textBoxINT.Text);
            datosEnemigo.con = int.Parse(textBoxCON.Text);
            datosEnemigo.cha = int.Parse(textBoxCAR.Text);
            datosEnemigo.wis = int.Parse(textBoxSAB.Text);
            datosEnemigo.strMod = int.Parse(textBoxFUEMod.Text);
            datosEnemigo.dexMod = int.Parse(textBoxDESMod.Text);
            datosEnemigo.intMod = int.Parse(textBoxINTMod.Text);
            datosEnemigo.conMod = int.Parse(textBoxCONMod.Text);
            datosEnemigo.chaMod = int.Parse(textBoxCARMod.Text);
            datosEnemigo.wisMod = int.Parse(textBoxSABMod.Text);
            datosEnemigo.savingThrows = textBoxSalvacion.Text;
            datosEnemigo.skills = textBoxHabilidades.Text;
            datosEnemigo.senses = textBoxSentidos.Text;
            datosEnemigo.languages = textBoxIdiomas.Text;
            datosEnemigo.challenge = textBoxDesafio.Text;
            datosEnemigo.xp = int.Parse(textBoxExperiencia.Text);
            datosEnemigo.traits = richTextBoxHabilidades.Text;
            datosEnemigo.actions = richTextBoxAcciones.Text;
            datosEnemigo.legendaryActions = richTextBoxAccionesLegendarias.Text;

            Dictionary<string, object> dictDatosEnemigo = Elemento.CrearDictConDatos(datosEnemigo);
                       
            return dictDatosEnemigo;
        }

    }
}
