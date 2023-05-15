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
        private Dictionary<string, string> datosFilaBestiario;
        public FormStatBlock(Dictionary<string, string> datosFilaBestiario)
        {
            InitializeComponent();
            this.datosFilaBestiario = datosFilaBestiario;
        }

        private void FormStatBlock_Load(object sender, EventArgs e)
        {
            textBoxNombre.Text = datosFilaBestiario["name"];
            textBoxTipo.Text = datosFilaBestiario["meta"];
            textBoxAC.Text = datosFilaBestiario["ac"];
            textBoxHP.Text = datosFilaBestiario["hp"];
            try
            {
                textBoxVelocidad.Text = datosFilaBestiario["speedRun"] + datosFilaBestiario["speedSwim"] + datosFilaBestiario["speedFly"];
            }
            catch (Exception ex)
            {
            }
            textBoxFUE.Text = datosFilaBestiario["str"] + " (+" + datosFilaBestiario["strMod"] + ")";
            textBoxDES.Text = datosFilaBestiario["dex"] + " (+" + datosFilaBestiario["dexMod"] + ")";
            textBoxINT.Text = datosFilaBestiario["int"] + " (+" + datosFilaBestiario["intMod"] + ")";
            textBoxCON.Text = datosFilaBestiario["con"] + " (+" + datosFilaBestiario["conMod"] + ")";
            textBoxCAR.Text = datosFilaBestiario["cha"] + " (+" + datosFilaBestiario["chaMod"] + ")";
            textBoxSAB.Text = datosFilaBestiario["wis"] + " (+" + datosFilaBestiario["wisMod"] + ")";
            try
            {
                textBoxSalvacion.Text = Archivos.generarStringDesdeDict(Archivos.deserializarJsonStringADictionary(datosFilaBestiario["savingThrows"]));
                textBoxHabilidades.Text = Archivos.generarStringDesdeDict(Archivos.deserializarJsonStringADictionary(datosFilaBestiario["skills"]));
                textBoxSentidos.Text = Archivos.generarStringDesdeList(Archivos.deserializarJsonStringAList(datosFilaBestiario["senses"]));
                textBoxIdiomas.Text = Archivos.generarStringDesdeList(Archivos.deserializarJsonStringAList(datosFilaBestiario["languages"]));
                textBoxDesafio.Text = datosFilaBestiario["challenge"] + " (+" + datosFilaBestiario["xp"] + " XP)";
                richTextBoxHabilidades.Text = Archivos.generarStringDesdeListDos(datosFilaBestiario["traits"]);
                richTextBoxAcciones.Text = Archivos.generarStringDesdeListDos(datosFilaBestiario["actions"]);
                richTextBoxAcciones.Text = Archivos.generarStringDesdeListDos(datosFilaBestiario["legendaryActions"]);
            }
            catch (Exception ex)
            {
            }
        }      

    }
}
