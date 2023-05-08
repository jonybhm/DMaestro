using PrimerParcial.Entidades.Models;

namespace PrimerParcial.UI
{
    public partial class FormContenedor : Form
    {
        public FormContenedor()
        {
            InitializeComponent();
        }

        private void FormContenedor_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }


        private void verPantallaDMToolStripMenuItem_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name != "FormCalculadoraDados")
                {
                    this.MdiChildren[i].Close();
                }
            }
            var hijo = new FormPantallaDM();
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Maximized;
            hijo.Show();



        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            var login = new FormLogin();
            login.Show();
        }

        private void button3_Dices_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == "FormCalculadoraDados")
                {
                    this.MdiChildren[i].Close();
                }
            }
            var calculadora = new FormCalculadoraDados();
            calculadora.MdiParent = this;
            calculadora.WindowState = FormWindowState.Normal;
            calculadora.Show();
        }

        private void cálculoDeDificultadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name != "FormCalculadoraDados")
                {
                    this.MdiChildren[i].Close();
                }
            }
            var hijo = new FormCombateDificultad();
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Maximized;
            hijo.Show();
        }
        private void ReglasStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name != "FormCalculadoraDados")
                {
                    this.MdiChildren[i].Close();
                }
            }
            var hijo = new FormReglas();
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Maximized;
            hijo.Show();

        }

        private void bestiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void hechizosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void objetosYTesorosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clasesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void razasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trasfondosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void featsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearEncuentroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaEncuentrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

 
        private void crearNuevaCampañaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaCampañasCreadasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}