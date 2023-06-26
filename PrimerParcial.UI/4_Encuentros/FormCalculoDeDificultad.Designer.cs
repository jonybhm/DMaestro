namespace PrimerParcial.UI
{
    partial class FormCalculoDeDificultad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            textBoxCantidadPC = new TextBox();
            comboBoxDificultad = new ComboBox();
            textBoxNivelPC = new TextBox();
            textBoxCantidadEnemigos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxResultadoXP = new TextBox();
            label3 = new Label();
            textBoxResultadoXPporPC = new TextBox();
            dataGridTablaReferencia = new DataGridView();
            label4 = new Label();
            dataGridNivelDificultad = new DataGridView();
            dataGridCantidadModificador = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            buttonCalcualrCR = new Button();
            textBoxResultadoCR = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBoxBuscador = new TextBox();
            buttonMostrar = new Button();
            dataGridBestiario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridTablaReferencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridNivelDificultad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCantidadModificador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridBestiario).BeginInit();
            SuspendLayout();
            // 
            // textBoxCantidadPC
            // 
            textBoxCantidadPC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxCantidadPC.BackColor = Color.LavenderBlush;
            textBoxCantidadPC.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCantidadPC.Location = new Point(12, 18);
            textBoxCantidadPC.Name = "textBoxCantidadPC";
            textBoxCantidadPC.PlaceholderText = "Ingresar numero...";
            textBoxCantidadPC.Size = new Size(210, 20);
            textBoxCantidadPC.TabIndex = 0;
            textBoxCantidadPC.KeyPress += textBoxCantidadPC_KeyPress;
            // 
            // comboBoxDificultad
            // 
            comboBoxDificultad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxDificultad.BackColor = Color.LavenderBlush;
            comboBoxDificultad.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDificultad.FormattingEnabled = true;
            comboBoxDificultad.Items.AddRange(new object[] { "Fácil", "Medio", "Difícil", "Mortal" });
            comboBoxDificultad.Location = new Point(12, 96);
            comboBoxDificultad.Name = "comboBoxDificultad";
            comboBoxDificultad.Size = new Size(210, 21);
            comboBoxDificultad.TabIndex = 2;
            // 
            // textBoxNivelPC
            // 
            textBoxNivelPC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxNivelPC.BackColor = Color.LavenderBlush;
            textBoxNivelPC.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNivelPC.Location = new Point(12, 57);
            textBoxNivelPC.Name = "textBoxNivelPC";
            textBoxNivelPC.PlaceholderText = "Ingresar numero...";
            textBoxNivelPC.Size = new Size(210, 20);
            textBoxNivelPC.TabIndex = 1;
            textBoxNivelPC.KeyPress += textBoxNivelPC_KeyPress;
            // 
            // textBoxCantidadEnemigos
            // 
            textBoxCantidadEnemigos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxCantidadEnemigos.BackColor = Color.LavenderBlush;
            textBoxCantidadEnemigos.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCantidadEnemigos.Location = new Point(12, 137);
            textBoxCantidadEnemigos.Name = "textBoxCantidadEnemigos";
            textBoxCantidadEnemigos.PlaceholderText = "Ingresar numero...";
            textBoxCantidadEnemigos.Size = new Size(210, 20);
            textBoxCantidadEnemigos.TabIndex = 3;
            textBoxCantidadEnemigos.KeyPress += textBoxCantidadEnemigos_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Lavender;
            label1.Location = new Point(246, 80);
            label1.Name = "label1";
            label1.Size = new Size(117, 13);
            label1.TabIndex = 6;
            label1.Text = "CR por enemigo:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Lavender;
            label2.Location = new Point(246, 122);
            label2.Name = "label2";
            label2.Size = new Size(72, 13);
            label2.TabIndex = 7;
            label2.Text = "XP Total:";
            // 
            // textBoxResultadoXP
            // 
            textBoxResultadoXP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxResultadoXP.BackColor = Color.LavenderBlush;
            textBoxResultadoXP.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxResultadoXP.Location = new Point(246, 138);
            textBoxResultadoXP.Name = "textBoxResultadoXP";
            textBoxResultadoXP.ReadOnly = true;
            textBoxResultadoXP.Size = new Size(99, 20);
            textBoxResultadoXP.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Lavender;
            label3.Location = new Point(357, 122);
            label3.Name = "label3";
            label3.Size = new Size(75, 13);
            label3.TabIndex = 10;
            label3.Text = "XP por PC:";
            // 
            // textBoxResultadoXPporPC
            // 
            textBoxResultadoXPporPC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxResultadoXPporPC.BackColor = Color.LavenderBlush;
            textBoxResultadoXPporPC.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxResultadoXPporPC.Location = new Point(357, 138);
            textBoxResultadoXPporPC.Name = "textBoxResultadoXPporPC";
            textBoxResultadoXPporPC.ReadOnly = true;
            textBoxResultadoXPporPC.Size = new Size(99, 20);
            textBoxResultadoXPporPC.TabIndex = 8;
            // 
            // dataGridTablaReferencia
            // 
            dataGridViewCellStyle1.BackColor = Color.RosyBrown;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridTablaReferencia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridTablaReferencia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridTablaReferencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTablaReferencia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridTablaReferencia.BackgroundColor = Color.IndianRed;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridTablaReferencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridTablaReferencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridTablaReferencia.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridTablaReferencia.GridColor = Color.Linen;
            dataGridTablaReferencia.Location = new Point(12, 315);
            dataGridTablaReferencia.Name = "dataGridTablaReferencia";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridTablaReferencia.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.RosyBrown;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkRed;
            dataGridTablaReferencia.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridTablaReferencia.RowTemplate.Height = 25;
            dataGridTablaReferencia.ScrollBars = ScrollBars.None;
            dataGridTablaReferencia.Size = new Size(148, 222);
            dataGridTablaReferencia.TabIndex = 11;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Lavender;
            label4.Location = new Point(12, 299);
            label4.Name = "label4";
            label4.Size = new Size(94, 13);
            label4.TabIndex = 14;
            label4.Text = "Tabla CR/XP";
            // 
            // dataGridNivelDificultad
            // 
            dataGridNivelDificultad.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridNivelDificultad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridNivelDificultad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridNivelDificultad.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridNivelDificultad.BackgroundColor = Color.IndianRed;
            dataGridNivelDificultad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridNivelDificultad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridNivelDificultad.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridNivelDificultad.GridColor = Color.Linen;
            dataGridNivelDificultad.Location = new Point(166, 315);
            dataGridNivelDificultad.Name = "dataGridNivelDificultad";
            dataGridNivelDificultad.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridNivelDificultad.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridNivelDificultad.RowTemplate.Height = 25;
            dataGridNivelDificultad.ScrollBars = ScrollBars.None;
            dataGridNivelDificultad.Size = new Size(148, 222);
            dataGridNivelDificultad.TabIndex = 12;
            // 
            // dataGridCantidadModificador
            // 
            dataGridCantidadModificador.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridCantidadModificador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridCantidadModificador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCantidadModificador.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridCantidadModificador.BackgroundColor = Color.IndianRed;
            dataGridCantidadModificador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridCantidadModificador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCantidadModificador.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridCantidadModificador.GridColor = Color.Linen;
            dataGridCantidadModificador.Location = new Point(320, 315);
            dataGridCantidadModificador.Name = "dataGridCantidadModificador";
            dataGridCantidadModificador.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridCantidadModificador.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridCantidadModificador.RowTemplate.Height = 25;
            dataGridCantidadModificador.ScrollBars = ScrollBars.None;
            dataGridCantidadModificador.Size = new Size(148, 222);
            dataGridCantidadModificador.TabIndex = 13;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Lavender;
            label5.Location = new Point(166, 299);
            label5.Name = "label5";
            label5.Size = new Size(131, 13);
            label5.TabIndex = 17;
            label5.Text = "NIVEL/DIFICULTAD";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Lavender;
            label6.Location = new Point(322, 299);
            label6.Name = "label6";
            label6.Size = new Size(111, 13);
            label6.TabIndex = 18;
            label6.Text = "cantidad/mod";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Universal Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Lavender;
            label7.Location = new Point(474, 6);
            label7.Name = "label7";
            label7.Size = new Size(126, 22);
            label7.TabIndex = 19;
            label7.Text = "Bestiario";
            // 
            // buttonCalcualrCR
            // 
            buttonCalcualrCR.BackColor = Color.Transparent;
            buttonCalcualrCR.BackgroundImage = Properties.Resources.boton2;
            buttonCalcualrCR.BackgroundImageLayout = ImageLayout.Zoom;
            buttonCalcualrCR.FlatAppearance.BorderSize = 0;
            buttonCalcualrCR.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonCalcualrCR.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonCalcualrCR.FlatStyle = FlatStyle.Flat;
            buttonCalcualrCR.Font = new Font("Universal Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCalcualrCR.ForeColor = Color.White;
            buttonCalcualrCR.Location = new Point(246, 18);
            buttonCalcualrCR.Name = "buttonCalcualrCR";
            buttonCalcualrCR.Size = new Size(210, 44);
            buttonCalcualrCR.TabIndex = 5;
            buttonCalcualrCR.Text = "Calcular CR";
            buttonCalcualrCR.UseVisualStyleBackColor = false;
            buttonCalcualrCR.Click += buttonCalcualrCR_Click;
            // 
            // textBoxResultadoCR
            // 
            textBoxResultadoCR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxResultadoCR.BackColor = Color.LavenderBlush;
            textBoxResultadoCR.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxResultadoCR.Location = new Point(246, 96);
            textBoxResultadoCR.Name = "textBoxResultadoCR";
            textBoxResultadoCR.ReadOnly = true;
            textBoxResultadoCR.Size = new Size(210, 20);
            textBoxResultadoCR.TabIndex = 6;
            textBoxResultadoCR.TextChanged += textBoxResultadoCR_TextChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Lavender;
            label8.Location = new Point(12, 2);
            label8.Name = "label8";
            label8.Size = new Size(155, 13);
            label8.TabIndex = 22;
            label8.Text = "Cantidad Jugadores:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Lavender;
            label9.Location = new Point(12, 41);
            label9.Name = "label9";
            label9.Size = new Size(134, 13);
            label9.TabIndex = 23;
            label9.Text = "Nivel Personajes:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Lavender;
            label10.Location = new Point(12, 80);
            label10.Name = "label10";
            label10.Size = new Size(87, 13);
            label10.TabIndex = 24;
            label10.Text = "Dificultad:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Lavender;
            label11.Location = new Point(12, 120);
            label11.Name = "label11";
            label11.Size = new Size(147, 13);
            label11.TabIndex = 25;
            label11.Text = "Cantidad Enemigos:";
            // 
            // textBoxBuscador
            // 
            textBoxBuscador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxBuscador.BackColor = Color.LavenderBlush;
            textBoxBuscador.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBuscador.Location = new Point(474, 31);
            textBoxBuscador.Name = "textBoxBuscador";
            textBoxBuscador.PlaceholderText = "BUSCAR POR NOMBRE...";
            textBoxBuscador.Size = new Size(192, 20);
            textBoxBuscador.TabIndex = 9;
            textBoxBuscador.TextChanged += textBoxBuscador_TextChanged;
            // 
            // buttonMostrar
            // 
            buttonMostrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMostrar.BackColor = Color.Transparent;
            buttonMostrar.BackgroundImage = Properties.Resources.boton2;
            buttonMostrar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMostrar.FlatAppearance.BorderSize = 0;
            buttonMostrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMostrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMostrar.FlatStyle = FlatStyle.Flat;
            buttonMostrar.Font = new Font("Universal Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMostrar.ForeColor = Color.White;
            buttonMostrar.Location = new Point(687, 9);
            buttonMostrar.Name = "buttonMostrar";
            buttonMostrar.Size = new Size(157, 45);
            buttonMostrar.TabIndex = 26;
            buttonMostrar.Text = "Mostrar";
            buttonMostrar.UseVisualStyleBackColor = false;
            buttonMostrar.Click += buttonMostrar_Click;
            // 
            // dataGridBestiario
            // 
            dataGridBestiario.AllowDrop = true;
            dataGridBestiario.AllowUserToAddRows = false;
            dataGridBestiario.AllowUserToDeleteRows = false;
            dataGridBestiario.AllowUserToResizeColumns = false;
            dataGridBestiario.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.RosyBrown;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridBestiario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridBestiario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridBestiario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridBestiario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridBestiario.BackgroundColor = Color.IndianRed;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle7.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridBestiario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridBestiario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridBestiario.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridBestiario.GridColor = Color.Linen;
            dataGridBestiario.Location = new Point(474, 57);
            dataGridBestiario.Name = "dataGridBestiario";
            dataGridBestiario.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridBestiario.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = Color.RosyBrown;
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.DarkRed;
            dataGridBestiario.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridBestiario.RowTemplate.Height = 25;
            dataGridBestiario.Size = new Size(370, 480);
            dataGridBestiario.TabIndex = 27;
            // 
            // FormCalculoDeDificultad
            // 
            AcceptButton = buttonCalcualrCR;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 48);
            BackgroundImage = Properties.Resources.blindaje_1_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(856, 549);
            Controls.Add(dataGridBestiario);
            Controls.Add(buttonMostrar);
            Controls.Add(textBoxBuscador);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBoxResultadoCR);
            Controls.Add(buttonCalcualrCR);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dataGridCantidadModificador);
            Controls.Add(dataGridNivelDificultad);
            Controls.Add(label4);
            Controls.Add(dataGridTablaReferencia);
            Controls.Add(textBoxResultadoXPporPC);
            Controls.Add(label3);
            Controls.Add(textBoxResultadoXP);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxCantidadEnemigos);
            Controls.Add(textBoxNivelPC);
            Controls.Add(comboBoxDificultad);
            Controls.Add(textBoxCantidadPC);
            DoubleBuffered = true;
            Name = "FormCalculoDeDificultad";
            Text = "FormCombateDificultad";
            Load += FormCombateDificultad_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridTablaReferencia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridNivelDificultad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCantidadModificador).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridBestiario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCantidadPC;
        private ComboBox comboBoxDificultad;
        private TextBox textBoxNivelPC;
        private TextBox textBoxCantidadEnemigos;
        private Label label1;
        private Label label2;
        private TextBox textBoxResultadoXP;
        private Label label3;
        private TextBox textBoxResultadoXPporPC;
        private DataGridView dataGridEnemigos;
        private DataGridView dataGridTablaReferencia;
        private Label label4;
        private DataGridView dataGridNivelDificultad;
        private DataGridView dataGridCantidadModificador;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button buttonCalcualrCR;
        private TextBox textBoxResultadoCR;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBoxBuscador;
        private Button buttonMostrar;
        private DataGridView dataGridBestiario;
    }
}