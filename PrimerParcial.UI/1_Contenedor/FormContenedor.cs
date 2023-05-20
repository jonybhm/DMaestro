using PrimerParcial.Entidades.Models;
using PrimerParcial.UI._1_Contenedor;

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
                if (this.MdiChildren[i].Name == "FormPantallaDM")
                {
                    this.MdiChildren[i].Close();
                }
            }
            var hijo = new FormPantallaDM();
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Normal;
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
                if (this.MdiChildren[i].Name == "FormCombateDificultad")
                {
                    this.MdiChildren[i].Close();
                }
            }
            var hijo = new FormCalculoDeDificultad();
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Maximized;
            hijo.Show();
        }


        private void bestiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == "FormBestiario")
                {
                    this.MdiChildren[i].Close();
                }
            }
            var hijo = new FormBestiario();
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Normal;
            hijo.Show();
        }


        private void hechizosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == "FormHechizos")
                {
                    this.MdiChildren[i].Close();
                }
            }
            var hijo = new FormHechizos();
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Normal;
            hijo.Show();

        }

        private void objetosYTesorosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == "FormobjetosYTesoros")
                {
                    this.MdiChildren[i].Close();
                }
            }
            var hijo = new FormItems();
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Normal;
            hijo.Show();
        }

        private void clasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == "FormClases")
                {
                    this.MdiChildren[i].Close();
                }
            }
            var hijo = new FormClases();
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Normal;
            hijo.Show();
        }

        private void razasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == "FormRazas")
                {
                    this.MdiChildren[i].Close();
                }
            }
            var hijo = new FormRazas();
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Normal;
            hijo.Show();
        }

        private void trasfondosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == "FormTrasfondos")
                {
                    this.MdiChildren[i].Close();
                }
            }
            var hijo = new FormTrasfondos();
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Normal;
            hijo.Show();
        }

        private void featsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == "FormFeats")
                {
                    this.MdiChildren[i].Close();
                }
            }
            var hijo = new FormFeats();
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Normal;
            hijo.Show();
        }


        private void crearNuevaCampañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == "FormCrearNuevaCampaña")
                {
                    this.MdiChildren[i].Close();
                }
            }
            var hijo = new FormCrearNuevaCampaña();
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Normal;
            hijo.Show();
        }

        private void listaCampañasCreadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == "FormListaDeCampañas")
                {
                    this.MdiChildren[i].Close();
                }
            }
            var hijo = new FormListaDeCampañas();
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Normal;
            hijo.Show();
        }

        private void crearCombateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == "FormIniciativa")
                {
                    this.MdiChildren[i].Close();
                }
            }
            var hijo = new FormIniciativa();
            hijo.MdiParent = this;
            hijo.WindowState = FormWindowState.Normal;
            hijo.Show();
        }

        
        private void Alineamientos_Click(object sender, EventArgs e)
        {
            MostrarRegla(Alineamientos);
        }



        private void VentajaYDesventaja_Click(object sender, EventArgs e)
        {
            MostrarRegla(VentajaYDesventaja);
        }

        private void CombatirBajoElAgua_Click(object sender, EventArgs e)
        {
            MostrarRegla(CombatirBajoElAgua);
        }

        private void Competencia_Click(object sender, EventArgs e)
        {
            MostrarRegla(Competencia);
        }

        private void Estados_Click(object sender, EventArgs e)
        {
            MostrarRegla(Estados);
        }

        private void Inspiracion_Click(object sender, EventArgs e)
        {
            MostrarRegla(Inspiracion);
        }

        private void Feats_Click(object sender, EventArgs e)
        {
            MostrarRegla(Feats);
        }

        private void Enfermedades_Click(object sender, EventArgs e)
        {
            MostrarRegla(Enfermedades);
        }

        private void Locura_Click(object sender, EventArgs e)
        {
            MostrarRegla(Locura);
        }

        private void Trampas_Click(object sender, EventArgs e)
        {
            MostrarRegla(Trampas);
        }

        private void Venenos_Click(object sender, EventArgs e)
        {
            MostrarRegla(Venenos);
        }

        private void AccionesEnCombate_Click(object sender, EventArgs e)
        {
            MostrarRegla(AccionesEnCombate);
        }

        private void RealizarUnAtaque_Click(object sender, EventArgs e)
        {
            MostrarRegla(RealizarUnAtaque);
        }

        private void MovimientoYPosicion_Click(object sender, EventArgs e)
        {
            MostrarRegla(MovimientoYPosicion);
        }

        private void OrdenDeCombate_Click(object sender, EventArgs e)
        {
            MostrarRegla(OrdenDeCombate);
        }

        private void Cobertura_Click(object sender, EventArgs e)
        {
            MostrarRegla(Cobertura);
        }

        private void CombatirDesdeMontura_Click(object sender, EventArgs e)
        {
            MostrarRegla(CombatirDesdeMontura);
        }

        private void Clases_Click(object sender, EventArgs e)
        {
            MostrarRegla(Clases);
        }

        private void Razas_Click(object sender, EventArgs e)
        {
            MostrarRegla(Razas);
        }

        private void Idiomas_Click(object sender, EventArgs e)
        {
            MostrarRegla(Idiomas);
        }

        private void Trasfondos_Click(object sender, EventArgs e)
        {
            MostrarRegla(Trasfondos);
        }

        private void Multiclaseo_Click(object sender, EventArgs e)
        {
            MostrarRegla(Multiclaseo);
        }

        private void NPC_Click(object sender, EventArgs e)
        {
            MostrarRegla(NPC);
        }

        private void QueEsUnConjuro_Click(object sender, EventArgs e)
        {
            MostrarRegla(QueEsUnConjuro);
        }

        private void LanzarUnConjuro_Click(object sender, EventArgs e)
        {
            MostrarRegla(LanzarUnConjuro);
        }

        private void Armadura_Click(object sender, EventArgs e)
        {
            MostrarRegla(Armadura);
        }

        private void Armas_Click(object sender, EventArgs e)
        {
            MostrarRegla(Armas);
        }

        private void EquipoDeAventuras_Click(object sender, EventArgs e)
        {
            MostrarRegla(EquipoDeAventuras);
        }

        private void Herramientas_Click(object sender, EventArgs e)
        {
            MostrarRegla(Herramientas);
        }

        private void Monedas_Click(object sender, EventArgs e)
        {
            MostrarRegla(Monedas);
        }

        private void Monturas_Click(object sender, EventArgs e)
        {
            MostrarRegla(Monturas);
        }

        private void PacksIniciales_Click(object sender, EventArgs e)
        {
            MostrarRegla(PacksIniciales);
        }

        private void ProductosComerciales_Click(object sender, EventArgs e)
        {
            MostrarRegla(ProductosComerciales);
        }

        private void Objetos_Click(object sender, EventArgs e)
        {
            MostrarRegla(Objetos);
        }

        private void ObjetosMagicos_Click(object sender, EventArgs e)
        {
            MostrarRegla(ObjetosMagicos);
        }

        private void EntreAventuras_Click(object sender, EventArgs e)
        {
            MostrarRegla(EntreAventuras);
        }

        private void Descansar_Click(object sender, EventArgs e)
        {
            MostrarRegla(Descansar);
        }

        private void Entorno_Click(object sender, EventArgs e)
        {
            MostrarRegla(Entorno);
        }

        private void Movimiento_Click(object sender, EventArgs e)
        {
            MostrarRegla(Movimiento);
        }

        private void Tiempo_Click(object sender, EventArgs e)
        {
            MostrarRegla(Tiempo);
        }

        private void Planos_Click(object sender, EventArgs e)
        {
            MostrarRegla(Planos);
        }

        private void Mitologia_Click(object sender, EventArgs e)
        {
            MostrarRegla(Mitologia);
        }

        private void MostrarRegla(ToolStripMenuItem ReglaBoton)
        {
            string nombreArchivo = ReglaBoton.Text;
            FormReglas regla = new FormReglas(nombreArchivo);
            regla.MdiParent = this;
            regla.WindowState = FormWindowState.Normal;
            regla.Show();
        }
    }
}