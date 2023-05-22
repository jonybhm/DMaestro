using PrimerParcial.Entidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial.UI
{
    public partial class FormIniciativa : Form
    {
        public FormIniciativa()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1125, 300);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Dock = DockStyle.Right;

        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            dataGridSeguidorIniciativa.Sort(dataGridSeguidorIniciativa.Columns["Iniciativa"], ListSortDirection.Ascending);
        }

        private void dataGridSeguidorIniciativa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormIniciativa_Load(object sender, EventArgs e)
        {

        }

        private void buttonTirar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridSeguidorIniciativa.RowCount - 1; i++)
            {
                Random rnd = new Random();
                dataGridSeguidorIniciativa.Rows[i].Cells[0].Value = rnd.Next(1, 20);
            }
        }

        
    }
}
