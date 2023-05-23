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


namespace PrimerParcial.UI._1_Contenedor
{
    public partial class FormStatBlock : Form
    {
        private Enemigo datosEnemigo;
        private bool AgregarHabilitado;
        private bool EditarHabilitado;
        public FormStatBlock(Enemigo datosEnemigo, bool MostrarBotonAgregar, bool MostrarBotonEditar)
        {
            InitializeComponent();
            this.datosEnemigo = datosEnemigo;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.AgregarHabilitado = MostrarBotonAgregar;
            this.EditarHabilitado = MostrarBotonEditar;
        }

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

            textBoxSalvacion.Text = Elemento.generarStringDesdeDict(datosEnemigo.savingThrows);
            if (datosEnemigo.skills.Count > 0)
            {
                textBoxHabilidades.Text = Elemento.generarStringDesdeDict(datosEnemigo.skills);
            }
            textBoxSentidos.Text = Elemento.generarStringDesdeList(datosEnemigo.senses);
            textBoxIdiomas.Text = Elemento.generarStringDesdeList(datosEnemigo.languages);

            textBoxDesafio.Text = datosEnemigo.challenge;
            textBoxExperiencia.Text = datosEnemigo.xp.ToString();

            richTextBoxHabilidades.Text = Elemento.generarStringDesdeListDict(datosEnemigo.traits);
            richTextBoxAcciones.Text = Elemento.generarStringDesdeListDict(datosEnemigo.actions);
            if (datosEnemigo.legendaryActions.Count > 0)
            {
                richTextBoxAccionesLegendarias.Text = Elemento.generarStringDesdeListDict(datosEnemigo.legendaryActions);
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CrearDatosJsonEnBaseAEnemigo();
            Elemento.AgregarInfoEnArchivo(datosEnemigo, "monsters-en-prueba");
            MessageBox.Show("Monstruo Agregado");
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            CrearDatosJsonEnBaseAEnemigo();
            Elemento.ModificarInfoEnArchivo(datosEnemigo, "monsters-en-prueba", datosEnemigo.id);
            MessageBox.Show("Monstruo Editado");
        }

        private void CrearDatosJsonEnBaseAEnemigo()
        {
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

            datosEnemigo.savingThrows = Elemento.generarDictDesdeString(textBoxSalvacion.Text);
            datosEnemigo.skills = Elemento.generarDictDesdeString(textBoxHabilidades.Text);
            datosEnemigo.senses = Elemento.generarListDesdeString(textBoxSentidos.Text);
            datosEnemigo.languages = Elemento.generarListDesdeString(textBoxIdiomas.Text);

            datosEnemigo.challenge = textBoxDesafio.Text;
            datosEnemigo.xp = int.Parse(textBoxExperiencia.Text);

            datosEnemigo.traits = Elemento.generarListDeDictDesdeString(richTextBoxHabilidades.Text);
            datosEnemigo.actions = Elemento.generarListDeDictDesdeString(richTextBoxAcciones.Text);
            datosEnemigo.legendaryActions = Elemento.generarListDeDictDesdeString(richTextBoxAccionesLegendarias.Text);
        }

    }
}
