namespace PrimerParcial.UI
{
    partial class FormBestiario
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            dataGridBestiario = new DataGridView();
            textBoxBuscador = new TextBox();
            label7 = new Label();
            buttonMostrar = new Button();
            buttonAgregar = new Button();
            buttonEliminar = new Button();
            buttonExportar = new Button();
            buttonAddIniciativa = new Button();
            flowLayoutPanelBotones = new FlowLayoutPanel();
            buttonPlus = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridBestiario).BeginInit();
            flowLayoutPanelBotones.SuspendLayout();
            SuspendLayout();
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
            dataGridBestiario.Location = new Point(-1, 104);
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
            dataGridBestiario.Size = new Size(510, 434);
            dataGridBestiario.TabIndex = 14;
            // 
            // textBoxBuscador
            // 
            textBoxBuscador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxBuscador.BackColor = Color.LavenderBlush;
            textBoxBuscador.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBuscador.Location = new Point(267, 34);
            textBoxBuscador.Name = "textBoxBuscador";
            textBoxBuscador.PlaceholderText = "BUSCAR POR NOMBRE...";
            textBoxBuscador.Size = new Size(230, 20);
            textBoxBuscador.TabIndex = 20;
            textBoxBuscador.TextChanged += textBoxBuscador_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Universal Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Lavender;
            label7.Location = new Point(371, 9);
            label7.Name = "label7";
            label7.Size = new Size(126, 22);
            label7.TabIndex = 21;
            label7.Text = "Bestiario";
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
            buttonMostrar.Location = new Point(129, 3);
            buttonMostrar.Name = "buttonMostrar";
            buttonMostrar.Size = new Size(120, 34);
            buttonMostrar.TabIndex = 22;
            buttonMostrar.Text = "Mostrar";
            buttonMostrar.UseVisualStyleBackColor = false;
            buttonMostrar.Click += buttonMostrar_Click;
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
            buttonAgregar.Location = new Point(3, 3);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(120, 34);
            buttonAgregar.TabIndex = 23;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.Transparent;
            buttonEliminar.BackgroundImage = Properties.Resources.boton2;
            buttonEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEliminar.FlatAppearance.BorderSize = 0;
            buttonEliminar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonEliminar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonEliminar.FlatStyle = FlatStyle.Flat;
            buttonEliminar.Font = new Font("Universal Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEliminar.ForeColor = Color.White;
            buttonEliminar.Location = new Point(255, 3);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(120, 34);
            buttonEliminar.TabIndex = 24;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonExportar
            // 
            buttonExportar.BackColor = Color.Transparent;
            buttonExportar.BackgroundImage = Properties.Resources.boton2;
            buttonExportar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonExportar.FlatAppearance.BorderSize = 0;
            buttonExportar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonExportar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonExportar.FlatStyle = FlatStyle.Flat;
            buttonExportar.Font = new Font("Universal Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExportar.ForeColor = Color.White;
            buttonExportar.Location = new Point(3, 43);
            buttonExportar.Name = "buttonExportar";
            buttonExportar.Size = new Size(120, 34);
            buttonExportar.TabIndex = 25;
            buttonExportar.Text = "Exportar";
            buttonExportar.UseVisualStyleBackColor = false;
            buttonExportar.Click += buttonExportar_Click;
            // 
            // buttonAddIniciativa
            // 
            buttonAddIniciativa.BackColor = Color.Transparent;
            buttonAddIniciativa.BackgroundImage = Properties.Resources.boton2;
            buttonAddIniciativa.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAddIniciativa.FlatAppearance.BorderSize = 0;
            buttonAddIniciativa.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonAddIniciativa.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonAddIniciativa.FlatStyle = FlatStyle.Flat;
            buttonAddIniciativa.Font = new Font("Universal Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddIniciativa.ForeColor = Color.White;
            buttonAddIniciativa.Location = new Point(129, 43);
            buttonAddIniciativa.Name = "buttonAddIniciativa";
            buttonAddIniciativa.Size = new Size(120, 34);
            buttonAddIniciativa.TabIndex = 26;
            buttonAddIniciativa.Text = "+ Iniciativa";
            buttonAddIniciativa.UseVisualStyleBackColor = false;
            buttonAddIniciativa.Click += buttonAddIniciativa_Click;
            // 
            // flowLayoutPanelBotones
            // 
            flowLayoutPanelBotones.Controls.Add(buttonAgregar);
            flowLayoutPanelBotones.Controls.Add(buttonMostrar);
            flowLayoutPanelBotones.Controls.Add(buttonEliminar);
            flowLayoutPanelBotones.Controls.Add(buttonExportar);
            flowLayoutPanelBotones.Controls.Add(buttonAddIniciativa);
            flowLayoutPanelBotones.Location = new Point(103, 9);
            flowLayoutPanelBotones.Name = "flowLayoutPanelBotones";
            flowLayoutPanelBotones.Size = new Size(394, 80);
            flowLayoutPanelBotones.TabIndex = 27;
            flowLayoutPanelBotones.Visible = false;
            // 
            // buttonPlus
            // 
            buttonPlus.BackgroundImage = Properties.Resources.boton21;
            buttonPlus.BackgroundImageLayout = ImageLayout.Stretch;
            buttonPlus.FlatAppearance.BorderSize = 0;
            buttonPlus.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonPlus.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonPlus.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonPlus.FlatStyle = FlatStyle.Flat;
            buttonPlus.Font = new Font("Universal Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPlus.ForeColor = SystemColors.ButtonHighlight;
            buttonPlus.Location = new Point(12, 12);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(75, 70);
            buttonPlus.TabIndex = 27;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // FormBestiario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 48);
            ClientSize = new Size(509, 537);
            Controls.Add(flowLayoutPanelBotones);
            Controls.Add(textBoxBuscador);
            Controls.Add(label7);
            Controls.Add(dataGridBestiario);
            Controls.Add(buttonPlus);
            Name = "FormBestiario";
            Text = "FormBestiario";
            Load += FormBestiario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridBestiario).EndInit();
            flowLayoutPanelBotones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridBestiario;
        private TextBox textBoxBuscador;
        private Label label7;
        private Button buttonMostrar;
        private Button buttonAgregar;
        private Button buttonEliminar;
        private Button buttonExportar;
        private Button buttonAddIniciativa;
        private FlowLayoutPanel flowLayoutPanelBotones;
        private Button buttonPlus;
    }
}