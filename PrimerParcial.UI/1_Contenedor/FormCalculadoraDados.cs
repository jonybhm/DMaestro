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
        private FormContenedor mdiParentForm;

        /// <summary>
        /// Inicializa una nueva instania de la clase FormCalculadoraDados.
        /// </summary>
        public FormCalculadoraDados(FormContenedor parentForm)
        {
            InitializeComponent();
            mdiParentForm = parentForm;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1500, 100);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Dock = DockStyle.Right;
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton 1.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void button1_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "1";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "1");

        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton 2.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void button2_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "2";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "2");
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton 3.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void button3_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "3";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "3");
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton 4.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void button4_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "4";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "4");
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton 5.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void button5_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "5";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "5");
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton 6.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void button6_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "6";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "6");
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton 7.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void button7_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "7";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "7");
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton 8.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void button8_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "8";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "8");
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton 9.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void button9_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "9";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "9");
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton 0.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void button0_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "0";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "0");
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton d2.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonD2_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "+d2";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "d2");
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton d4.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonD4_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "+d4";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "d4");
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton d8.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonD8_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "+d8";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "d8");
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton d10.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonD10_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "+d10";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "d10");
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton d12.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonD12_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "+d12";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "d12");
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton d20.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonD20_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "+d20";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "d20");
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton d100.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonD100_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "+d100";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "d100");

        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton d6.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonD6_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "+d6";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "d6");
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton dx.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonDX_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "+d";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "d");
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton Tirar. 
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonTirar_Click(object sender, EventArgs e)
        {
            ReproductorDeSonido("Rolling-Dice");
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "Tirar");
            double resultadoTirada = Calculadora.CalcularDadosYModificadores(BoxCalculo.Text);
            BoxResultado.Text = resultadoTirada.ToString();

            if (BoxCalculo.Text == "+d20" && BoxResultado.Text == "20")
            {
                Detector20Nat.veinteNatural += ReproductorDeSonido;
                Detector20Nat.DetectarVeinteNatural("Exito");
            }

        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton +.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "+";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "+");
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton -.
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            BoxCalculo.Text += "-";
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "-");
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton <- (borrar).
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
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
            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "Borrar");
        }

        /// <summary>
        /// Evento que sucede al hacer click en el boton C (limpiar).
        /// </summary>
        /// <param name="sender">Objeto que representa al iniciador del evento.</param>
        /// <param name="e">Representa a los argumentos del evento</param>
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

            DetectorBoton.ClickBoton += Informe.RegistrarYGuardarAccionUsuarioEnLog;
            DetectorBoton.DetectarBotonPresionadoPorUsuario(mdiParentForm.usuarioActual.UserName, "Limpiar");
        }

        public static void ReproductorDeSonido(string nombreSonido)
        {
            SoundPlayer sonidoDados = new SoundPlayer($@"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\Assets\Sonidos\{nombreSonido}.wav");
            sonidoDados.Play();
        }
    }
}
