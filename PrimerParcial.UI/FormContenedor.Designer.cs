using PrimerParcial.Entidades.Models;


namespace PrimerParcial.UI
{
    partial class FormContenedor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContenedor));
            button3_Dices = new Button();
            menuStrip1 = new MenuStrip();
            reglasToolStripMenuItem = new ToolStripMenuItem();
            verPantallaDMToolStripMenuItem = new ToolStripMenuItem();
            modificarPantallaDMToolStripMenuItem = new ToolStripMenuItem();
            reglasToolStripMenuItem1 = new ToolStripMenuItem();
            compendioToolStripMenuItem = new ToolStripMenuItem();
            bestiarioToolStripMenuItem = new ToolStripMenuItem();
            hechizosToolStripMenuItem = new ToolStripMenuItem();
            objetosYTesorosToolStripMenuItem = new ToolStripMenuItem();
            personajesToolStripMenuItem = new ToolStripMenuItem();
            clasesToolStripMenuItem = new ToolStripMenuItem();
            razasToolStripMenuItem = new ToolStripMenuItem();
            trasfondosToolStripMenuItem = new ToolStripMenuItem();
            featsToolStripMenuItem = new ToolStripMenuItem();
            encuentrosToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            cálculoDeDificultadToolStripMenuItem = new ToolStripMenuItem();
            crearEncuentroToolStripMenuItem = new ToolStripMenuItem();
            listaEncuentrosToolStripMenuItem = new ToolStripMenuItem();
            exploraciónToolStripMenuItem = new ToolStripMenuItem();
            crearEncuentroToolStripMenuItem1 = new ToolStripMenuItem();
            listaEncuentrosToolStripMenuItem1 = new ToolStripMenuItem();
            campañasToolStripMenuItem = new ToolStripMenuItem();
            crearNuevaCampañaToolStripMenuItem = new ToolStripMenuItem();
            listaCampañasCreadasToolStripMenuItem = new ToolStripMenuItem();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            cambiarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            crearUsuarioToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button3_Dices
            // 
            button3_Dices.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3_Dices.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3_Dices.BackColor = Color.Transparent;
            button3_Dices.Cursor = Cursors.Hand;
            button3_Dices.FlatAppearance.BorderSize = 0;
            button3_Dices.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3_Dices.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3_Dices.FlatStyle = FlatStyle.Flat;
            button3_Dices.Font = new Font("Universal Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button3_Dices.ForeColor = Color.Black;
            button3_Dices.Image = (Image)resources.GetObject("button3_Dices.Image");
            button3_Dices.ImageAlign = ContentAlignment.MiddleLeft;
            button3_Dices.Location = new Point(1021, 470);
            button3_Dices.Name = "button3_Dices";
            button3_Dices.Size = new Size(154, 63);
            button3_Dices.TabIndex = 2;
            button3_Dices.Text = "Dados";
            button3_Dices.TextAlign = ContentAlignment.MiddleRight;
            button3_Dices.UseVisualStyleBackColor = false;
            button3_Dices.Click += button3_Dices_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Universal Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { reglasToolStripMenuItem, compendioToolStripMenuItem, encuentrosToolStripMenuItem, campañasToolStripMenuItem, opcionesToolStripMenuItem, usuarioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(151, 545);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // reglasToolStripMenuItem
            // 
            reglasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verPantallaDMToolStripMenuItem, modificarPantallaDMToolStripMenuItem, reglasToolStripMenuItem1 });
            reglasToolStripMenuItem.Image = (Image)resources.GetObject("reglasToolStripMenuItem.Image");
            reglasToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            reglasToolStripMenuItem.Name = "reglasToolStripMenuItem";
            reglasToolStripMenuItem.Size = new Size(138, 20);
            reglasToolStripMenuItem.Text = "Reglas";
            // 
            // verPantallaDMToolStripMenuItem
            // 
            verPantallaDMToolStripMenuItem.Name = "verPantallaDMToolStripMenuItem";
            verPantallaDMToolStripMenuItem.Size = new Size(284, 22);
            verPantallaDMToolStripMenuItem.Text = "Ver pantalla DM";
            verPantallaDMToolStripMenuItem.Click += verPantallaDMToolStripMenuItem_Click;
            // 
            // modificarPantallaDMToolStripMenuItem
            // 
            modificarPantallaDMToolStripMenuItem.Name = "modificarPantallaDMToolStripMenuItem";
            modificarPantallaDMToolStripMenuItem.Size = new Size(284, 22);
            modificarPantallaDMToolStripMenuItem.Text = "Modificar pantalla DM";
            // 
            // reglasToolStripMenuItem1
            // 
            reglasToolStripMenuItem1.Name = "reglasToolStripMenuItem1";
            reglasToolStripMenuItem1.Size = new Size(284, 22);
            reglasToolStripMenuItem1.Text = "Reglas";
            // 
            // compendioToolStripMenuItem
            // 
            compendioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bestiarioToolStripMenuItem, hechizosToolStripMenuItem, objetosYTesorosToolStripMenuItem, personajesToolStripMenuItem });
            compendioToolStripMenuItem.Image = (Image)resources.GetObject("compendioToolStripMenuItem.Image");
            compendioToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            compendioToolStripMenuItem.Name = "compendioToolStripMenuItem";
            compendioToolStripMenuItem.Size = new Size(138, 20);
            compendioToolStripMenuItem.Text = "Compendio";
            // 
            // bestiarioToolStripMenuItem
            // 
            bestiarioToolStripMenuItem.Name = "bestiarioToolStripMenuItem";
            bestiarioToolStripMenuItem.Size = new Size(243, 22);
            bestiarioToolStripMenuItem.Text = "Bestiario";
            // 
            // hechizosToolStripMenuItem
            // 
            hechizosToolStripMenuItem.Name = "hechizosToolStripMenuItem";
            hechizosToolStripMenuItem.Size = new Size(243, 22);
            hechizosToolStripMenuItem.Text = "Hechizos";
            // 
            // objetosYTesorosToolStripMenuItem
            // 
            objetosYTesorosToolStripMenuItem.Name = "objetosYTesorosToolStripMenuItem";
            objetosYTesorosToolStripMenuItem.Size = new Size(243, 22);
            objetosYTesorosToolStripMenuItem.Text = "Objetos y tesoros";
            // 
            // personajesToolStripMenuItem
            // 
            personajesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clasesToolStripMenuItem, razasToolStripMenuItem, trasfondosToolStripMenuItem, featsToolStripMenuItem });
            personajesToolStripMenuItem.Name = "personajesToolStripMenuItem";
            personajesToolStripMenuItem.Size = new Size(243, 22);
            personajesToolStripMenuItem.Text = "Personajes";
            // 
            // clasesToolStripMenuItem
            // 
            clasesToolStripMenuItem.Name = "clasesToolStripMenuItem";
            clasesToolStripMenuItem.Size = new Size(184, 22);
            clasesToolStripMenuItem.Text = "Clases";
            // 
            // razasToolStripMenuItem
            // 
            razasToolStripMenuItem.Name = "razasToolStripMenuItem";
            razasToolStripMenuItem.Size = new Size(184, 22);
            razasToolStripMenuItem.Text = "Razas";
            // 
            // trasfondosToolStripMenuItem
            // 
            trasfondosToolStripMenuItem.Name = "trasfondosToolStripMenuItem";
            trasfondosToolStripMenuItem.Size = new Size(184, 22);
            trasfondosToolStripMenuItem.Text = "Trasfondos";
            // 
            // featsToolStripMenuItem
            // 
            featsToolStripMenuItem.Name = "featsToolStripMenuItem";
            featsToolStripMenuItem.Size = new Size(184, 22);
            featsToolStripMenuItem.Text = "Feats";
            // 
            // encuentrosToolStripMenuItem
            // 
            encuentrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraToolStripMenuItem, exploraciónToolStripMenuItem });
            encuentrosToolStripMenuItem.Image = (Image)resources.GetObject("encuentrosToolStripMenuItem.Image");
            encuentrosToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            encuentrosToolStripMenuItem.Name = "encuentrosToolStripMenuItem";
            encuentrosToolStripMenuItem.Size = new Size(138, 20);
            encuentrosToolStripMenuItem.Text = "Encuentros";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cálculoDeDificultadToolStripMenuItem, crearEncuentroToolStripMenuItem, listaEncuentrosToolStripMenuItem });
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(189, 22);
            calculadoraToolStripMenuItem.Text = "Combate";
            // 
            // cálculoDeDificultadToolStripMenuItem
            // 
            cálculoDeDificultadToolStripMenuItem.Name = "cálculoDeDificultadToolStripMenuItem";
            cálculoDeDificultadToolStripMenuItem.Size = new Size(295, 22);
            cálculoDeDificultadToolStripMenuItem.Text = "Cálculo de dificultad";
            cálculoDeDificultadToolStripMenuItem.Click += cálculoDeDificultadToolStripMenuItem_Click;
            // 
            // crearEncuentroToolStripMenuItem
            // 
            crearEncuentroToolStripMenuItem.Name = "crearEncuentroToolStripMenuItem";
            crearEncuentroToolStripMenuItem.Size = new Size(295, 22);
            crearEncuentroToolStripMenuItem.Text = "Crear combate";
            // 
            // listaEncuentrosToolStripMenuItem
            // 
            listaEncuentrosToolStripMenuItem.Name = "listaEncuentrosToolStripMenuItem";
            listaEncuentrosToolStripMenuItem.Size = new Size(295, 22);
            listaEncuentrosToolStripMenuItem.Text = "Lista combates creados";
            // 
            // exploraciónToolStripMenuItem
            // 
            exploraciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearEncuentroToolStripMenuItem1, listaEncuentrosToolStripMenuItem1 });
            exploraciónToolStripMenuItem.Name = "exploraciónToolStripMenuItem";
            exploraciónToolStripMenuItem.Size = new Size(189, 22);
            exploraciónToolStripMenuItem.Text = "Exploración";
            // 
            // crearEncuentroToolStripMenuItem1
            // 
            crearEncuentroToolStripMenuItem1.Name = "crearEncuentroToolStripMenuItem1";
            crearEncuentroToolStripMenuItem1.Size = new Size(235, 22);
            crearEncuentroToolStripMenuItem1.Text = "Crear encuentro";
            // 
            // listaEncuentrosToolStripMenuItem1
            // 
            listaEncuentrosToolStripMenuItem1.Name = "listaEncuentrosToolStripMenuItem1";
            listaEncuentrosToolStripMenuItem1.Size = new Size(235, 22);
            listaEncuentrosToolStripMenuItem1.Text = "Lista encuentros";
            // 
            // campañasToolStripMenuItem
            // 
            campañasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearNuevaCampañaToolStripMenuItem, listaCampañasCreadasToolStripMenuItem });
            campañasToolStripMenuItem.Image = (Image)resources.GetObject("campañasToolStripMenuItem.Image");
            campañasToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            campañasToolStripMenuItem.Name = "campañasToolStripMenuItem";
            campañasToolStripMenuItem.Size = new Size(138, 20);
            campañasToolStripMenuItem.Text = "Campañas";
            // 
            // crearNuevaCampañaToolStripMenuItem
            // 
            crearNuevaCampañaToolStripMenuItem.Name = "crearNuevaCampañaToolStripMenuItem";
            crearNuevaCampañaToolStripMenuItem.Size = new Size(293, 22);
            crearNuevaCampañaToolStripMenuItem.Text = "Crear Nueva Campaña";
            // 
            // listaCampañasCreadasToolStripMenuItem
            // 
            listaCampañasCreadasToolStripMenuItem.Name = "listaCampañasCreadasToolStripMenuItem";
            listaCampañasCreadasToolStripMenuItem.Size = new Size(293, 22);
            listaCampañasCreadasToolStripMenuItem.Text = "Lista campañas creadas";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.Image = (Image)resources.GetObject("opcionesToolStripMenuItem.Image");
            opcionesToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(138, 20);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cambiarUsuarioToolStripMenuItem, crearUsuarioToolStripMenuItem, salirToolStripMenuItem });
            usuarioToolStripMenuItem.Image = (Image)resources.GetObject("usuarioToolStripMenuItem.Image");
            usuarioToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(138, 20);
            usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // cambiarUsuarioToolStripMenuItem
            // 
            cambiarUsuarioToolStripMenuItem.Name = "cambiarUsuarioToolStripMenuItem";
            cambiarUsuarioToolStripMenuItem.Size = new Size(223, 22);
            cambiarUsuarioToolStripMenuItem.Text = "Cambiar Usuario";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            crearUsuarioToolStripMenuItem.Size = new Size(223, 22);
            crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(223, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // FormContenedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 545);
            Controls.Add(button3_Dices);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormContenedor";
            Text = "Dungeon Master";
            Load += FormContenedor_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3_Dices;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem reglasToolStripMenuItem;
        private ToolStripMenuItem compendioToolStripMenuItem;
        private ToolStripMenuItem encuentrosToolStripMenuItem;
        private ToolStripMenuItem campañasToolStripMenuItem;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem verPantallaDMToolStripMenuItem;
        private ToolStripMenuItem bestiarioToolStripMenuItem;
        private ToolStripMenuItem hechizosToolStripMenuItem;
        private ToolStripMenuItem objetosYTesorosToolStripMenuItem;
        private ToolStripMenuItem personajesToolStripMenuItem;
        private ToolStripMenuItem clasesToolStripMenuItem;
        private ToolStripMenuItem razasToolStripMenuItem;
        private ToolStripMenuItem trasfondosToolStripMenuItem;
        private ToolStripMenuItem featsToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem exploraciónToolStripMenuItem;
        private ToolStripMenuItem cálculoDeDificultadToolStripMenuItem;
        private ToolStripMenuItem crearEncuentroToolStripMenuItem;
        private ToolStripMenuItem listaEncuentrosToolStripMenuItem;
        private ToolStripMenuItem crearEncuentroToolStripMenuItem1;
        private ToolStripMenuItem listaEncuentrosToolStripMenuItem1;
        private ToolStripMenuItem crearNuevaCampañaToolStripMenuItem;
        private ToolStripMenuItem listaCampañasCreadasToolStripMenuItem;
        private ToolStripMenuItem cambiarUsuarioToolStripMenuItem;
        private ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem modificarPantallaDMToolStripMenuItem;
        private ToolStripMenuItem reglasToolStripMenuItem1;
    }
}