using PrimerParcial.Entidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace PrimerParcial.UI
{
    public partial class FormCalculadoraDados : Form
    {
        public FormCalculadoraDados()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Dock = DockStyle.Right;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "0";
        }

        private void buttonD2_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "+d2";
        }

        private void buttonD4_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "+d4";
        }

        private void FormCalculadoraDados_Load(object sender, EventArgs e)
        {

        }

        private void buttonD8_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "+d8";
        }

        private void buttonD10_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "+d10";
        }

        private void buttonD12_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "+d12";
        }

        private void buttonD20_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "+d20";
        }
        private void buttonD100_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "+d100";

        }
        private void buttonD6_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "+d6";
        }
        private void buttonDX_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "+d";
        }

        private void buttonTirar_Click(object sender, EventArgs e)
        {
            SoundPlayer sonidoDados = new SoundPlayer(@"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\Assets\dados\Rolling-Dice.wav");
            sonidoDados.Play();
            Calculadora calculadora = new Calculadora();
            double resultadoTirada = calculadora.Cuenta(BoxCalculo.Text);
            BoxResultado.Text = resultadoTirada.ToString();

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "-";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string texto = BoxCalculo.Text;
            try
            {

                BoxCalculo.Text = texto.Substring(0, texto.Length - 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            string texto = BoxCalculo.Text;
            try
            {

                BoxCalculo.Text = texto.Remove(0, texto.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }
}
