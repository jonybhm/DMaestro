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
            var hijo = new FormPantallaDM();
            hijo.MdiParent = this;
            hijo.Show();
        }

    }
}