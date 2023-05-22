namespace PrimerParcial.UI
{
    partial class FormClases
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
            buttonAgregar = new Button();
            buttonMostrar = new Button();
            textBoxBuscador = new TextBox();
            label7 = new Label();
            dataGridBestiario = new DataGridView();
            Clase = new DataGridViewTextBoxColumn();
            Dadosdegolpe = new DataGridViewTextBoxColumn();
            HPNivel1 = new DataGridViewTextBoxColumn();
            HPNivelesSuperiores = new DataGridViewTextBoxColumn();
            Armadura = new DataGridViewTextBoxColumn();
            Armas = new DataGridViewTextBoxColumn();
            Herramientas = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridBestiario).BeginInit();
            SuspendLayout();
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.Transparent;
            buttonAgregar.BackgroundImage = Properties.Resources.boton2;
            buttonAgregar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAgregar.FlatAppearance.BorderSize = 0;
            buttonAgregar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonAgregar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonAgregar.FlatStyle = FlatStyle.Flat;
            buttonAgregar.Font = new Font("Universal Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregar.ForeColor = Color.White;
            buttonAgregar.Location = new Point(344, 3);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(153, 34);
            buttonAgregar.TabIndex = 28;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = false;
            // 
            // buttonMostrar
            // 
            buttonMostrar.BackColor = Color.Transparent;
            buttonMostrar.BackgroundImage = Properties.Resources.boton2;
            buttonMostrar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMostrar.FlatAppearance.BorderSize = 0;
            buttonMostrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMostrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMostrar.FlatStyle = FlatStyle.Flat;
            buttonMostrar.Font = new Font("Universal Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMostrar.ForeColor = Color.White;
            buttonMostrar.Location = new Point(344, 34);
            buttonMostrar.Name = "buttonMostrar";
            buttonMostrar.Size = new Size(153, 34);
            buttonMostrar.TabIndex = 27;
            buttonMostrar.Text = "Mostrar";
            buttonMostrar.UseVisualStyleBackColor = false;
            // 
            // textBoxBuscador
            // 
            textBoxBuscador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxBuscador.BackColor = Color.LavenderBlush;
            textBoxBuscador.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBuscador.Location = new Point(12, 43);
            textBoxBuscador.Name = "textBoxBuscador";
            textBoxBuscador.PlaceholderText = "BUSCAR POR NOMBRE...";
            textBoxBuscador.Size = new Size(263, 20);
            textBoxBuscador.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Universal Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Lavender;
            label7.Location = new Point(11, 8);
            label7.Name = "label7";
            label7.Size = new Size(94, 22);
            label7.TabIndex = 26;
            label7.Text = "Clases";
            // 
            // dataGridBestiario
            // 
            dataGridBestiario.AllowDrop = true;
            dataGridBestiario.AllowUserToAddRows = false;
            dataGridBestiario.AllowUserToDeleteRows = false;
            dataGridBestiario.AllowUserToResizeColumns = false;
            dataGridBestiario.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.RosyBrown;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridBestiario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridBestiario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridBestiario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridBestiario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridBestiario.BackgroundColor = Color.IndianRed;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle2.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridBestiario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridBestiario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridBestiario.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridBestiario.GridColor = Color.Linen;
            dataGridBestiario.Location = new Point(-1, 78);
            dataGridBestiario.Name = "dataGridBestiario";
            dataGridBestiario.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridBestiario.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.RosyBrown;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkRed;
            dataGridBestiario.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridBestiario.RowTemplate.Height = 25;
            dataGridBestiario.Size = new Size(510, 456);
            dataGridBestiario.TabIndex = 24;
            // 
            // Clase
            // 
            Clase.HeaderText = "Clase";
            Clase.Name = "Clase";
            Clase.Width = 74;
            // 
            // Dadosdegolpe
            // 
            Dadosdegolpe.HeaderText = "Dados de golpe";
            Dadosdegolpe.Name = "Dadosdegolpe";
            // 
            // HPNivel1
            // 
            HPNivel1.HeaderText = "HP Nivel 1";
            HPNivel1.Name = "HPNivel1";
            // 
            // HPNivelesSuperiores
            // 
            HPNivelesSuperiores.HeaderText = "HP Niveles Superiores";
            HPNivelesSuperiores.Name = "HPNivelesSuperiores";
            // 
            // Armadura
            // 
            Armadura.HeaderText = "Armadura";
            Armadura.Name = "Armadura";
            // 
            // Armas
            // 
            Armas.HeaderText = "Armas";
            Armas.Name = "Armas";
            // 
            // Herramientas
            // 
            Herramientas.HeaderText = "Herramientas";
            Herramientas.Name = "Herramientas";
            // 
            // FormClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 48);
            ClientSize = new Size(509, 537);
            Controls.Add(buttonAgregar);
            Controls.Add(buttonMostrar);
            Controls.Add(textBoxBuscador);
            Controls.Add(label7);
            Controls.Add(dataGridBestiario);
            Name = "FormClases";
            Text = "FormClases";
            ((System.ComponentModel.ISupportInitialize)dataGridBestiario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAgregar;
        private Button buttonMostrar;
        private TextBox textBoxBuscador;
        private Label label7;
        private DataGridView dataGridBestiario;
        private DataGridViewTextBoxColumn Clase;
        private DataGridViewTextBoxColumn Dadosdegolpe;
        private DataGridViewTextBoxColumn HPNivel1;
        private DataGridViewTextBoxColumn HPNivelesSuperiores;
        private DataGridViewTextBoxColumn Armadura;
        private DataGridViewTextBoxColumn Armas;
        private DataGridViewTextBoxColumn Herramientas;
    }
}