namespace PrimerParcial.UI
{
    partial class FormListaDeCampañas
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
            buttonOpen = new Button();
            textBoxBuscador = new TextBox();
            label7 = new Label();
            dataGridCampañas = new DataGridView();
            buttonNew = new Button();
            buttonEliminar = new Button();
            buttonExportar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridCampañas).BeginInit();
            SuspendLayout();
            // 
            // buttonOpen
            // 
            buttonOpen.BackColor = Color.Transparent;
            buttonOpen.BackgroundImage = Properties.Resources.boton2;
            buttonOpen.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOpen.FlatAppearance.BorderSize = 0;
            buttonOpen.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonOpen.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonOpen.FlatStyle = FlatStyle.Flat;
            buttonOpen.Font = new Font("Universal Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOpen.ForeColor = Color.White;
            buttonOpen.Location = new Point(241, 39);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(122, 34);
            buttonOpen.TabIndex = 30;
            buttonOpen.Text = "Abrir";
            buttonOpen.UseVisualStyleBackColor = false;
            buttonOpen.Click += buttonAbrir_Click;
            // 
            // textBoxBuscador
            // 
            textBoxBuscador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxBuscador.BackColor = Color.LavenderBlush;
            textBoxBuscador.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBuscador.Location = new Point(11, 48);
            textBoxBuscador.Name = "textBoxBuscador";
            textBoxBuscador.PlaceholderText = "BUSCAR POR NOMBRE...";
            textBoxBuscador.Size = new Size(221, 20);
            textBoxBuscador.TabIndex = 28;
            textBoxBuscador.TextChanged += textBoxBuscador_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Universal Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Lavender;
            label7.Location = new Point(10, 13);
            label7.Name = "label7";
            label7.Size = new Size(130, 22);
            label7.TabIndex = 29;
            label7.Text = "Campañas";
            // 
            // dataGridCampañas
            // 
            dataGridCampañas.AllowUserToAddRows = false;
            dataGridCampañas.AllowUserToDeleteRows = false;
            dataGridCampañas.AllowUserToResizeColumns = false;
            dataGridCampañas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.RosyBrown;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridCampañas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridCampañas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridCampañas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridCampañas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridCampañas.BackgroundColor = Color.IndianRed;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle2.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridCampañas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridCampañas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridCampañas.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridCampañas.GridColor = Color.Linen;
            dataGridCampañas.Location = new Point(-2, 110);
            dataGridCampañas.Name = "dataGridCampañas";
            dataGridCampañas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridCampañas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.RosyBrown;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkRed;
            dataGridCampañas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridCampañas.RowTemplate.Height = 50;
            dataGridCampañas.Size = new Size(510, 397);
            dataGridCampañas.TabIndex = 27;
            // 
            // buttonNew
            // 
            buttonNew.BackColor = Color.Transparent;
            buttonNew.BackgroundImage = Properties.Resources.boton2;
            buttonNew.BackgroundImageLayout = ImageLayout.Zoom;
            buttonNew.FlatAppearance.BorderSize = 0;
            buttonNew.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonNew.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonNew.FlatStyle = FlatStyle.Flat;
            buttonNew.Font = new Font("Universal Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNew.ForeColor = Color.White;
            buttonNew.Location = new Point(241, 8);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(122, 34);
            buttonNew.TabIndex = 32;
            buttonNew.Text = "Nueva";
            buttonNew.UseVisualStyleBackColor = false;
            buttonNew.Click += buttonNew_Click;
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
            buttonEliminar.Location = new Point(369, 8);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(122, 34);
            buttonEliminar.TabIndex = 33;
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
            buttonExportar.Location = new Point(369, 39);
            buttonExportar.Name = "buttonExportar";
            buttonExportar.Size = new Size(122, 34);
            buttonExportar.TabIndex = 34;
            buttonExportar.Text = "Exportar";
            buttonExportar.UseVisualStyleBackColor = false;
            buttonExportar.Click += buttonExportar_Click;
            // 
            // FormListaDeCampañas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 48);
            ClientSize = new Size(506, 505);
            Controls.Add(buttonExportar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonNew);
            Controls.Add(buttonOpen);
            Controls.Add(textBoxBuscador);
            Controls.Add(label7);
            Controls.Add(dataGridCampañas);
            Name = "FormListaDeCampañas";
            Text = "FormListaDeCampañas";
            Load += FormListaCampañas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCampañas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOpen;
        private TextBox textBoxBuscador;
        private Label label7;
        private DataGridView dataGridCampañas;
        private Button buttonNew;
        private Button buttonEliminar;
        private Button buttonExportar;
    }
}