namespace PrimerParcial.UI
{
    partial class FormItems
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
            buttonMostrar = new Button();
            textBoxBuscador = new TextBox();
            label7 = new Label();
            dataGridItems = new DataGridView();
            buttonAgregar = new Button();
            buttonEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridItems).BeginInit();
            SuspendLayout();
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
            buttonMostrar.Location = new Point(341, 38);
            buttonMostrar.Name = "buttonMostrar";
            buttonMostrar.Size = new Size(153, 34);
            buttonMostrar.TabIndex = 30;
            buttonMostrar.Text = "Mostrar";
            buttonMostrar.UseVisualStyleBackColor = false;
            buttonMostrar.Click += buttonMostrar_Click;
            // 
            // textBoxBuscador
            // 
            textBoxBuscador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxBuscador.BackColor = Color.LavenderBlush;
            textBoxBuscador.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBuscador.Location = new Point(9, 47);
            textBoxBuscador.Name = "textBoxBuscador";
            textBoxBuscador.PlaceholderText = "BUSCAR POR NOMBRE...";
            textBoxBuscador.Size = new Size(263, 20);
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
            label7.Location = new Point(8, 12);
            label7.Name = "label7";
            label7.Size = new Size(234, 22);
            label7.TabIndex = 29;
            label7.Text = "Objetos y tesoros";
            // 
            // dataGridItems
            // 
            dataGridItems.AllowUserToAddRows = false;
            dataGridItems.AllowUserToDeleteRows = false;
            dataGridItems.AllowUserToResizeColumns = false;
            dataGridItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.RosyBrown;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridItems.BackgroundColor = Color.IndianRed;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle2.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridItems.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridItems.GridColor = Color.Linen;
            dataGridItems.Location = new Point(0, 110);
            dataGridItems.Name = "dataGridItems";
            dataGridItems.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.RosyBrown;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkRed;
            dataGridItems.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridItems.RowTemplate.Height = 25;
            dataGridItems.Size = new Size(507, 422);
            dataGridItems.TabIndex = 27;
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
            buttonAgregar.Location = new Point(341, 7);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(153, 34);
            buttonAgregar.TabIndex = 31;
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
            buttonEliminar.Location = new Point(341, 70);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(153, 34);
            buttonEliminar.TabIndex = 32;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // FormItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 48);
            ClientSize = new Size(507, 532);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAgregar);
            Controls.Add(buttonMostrar);
            Controls.Add(textBoxBuscador);
            Controls.Add(label7);
            Controls.Add(dataGridItems);
            Name = "FormItems";
            Text = "FormobjetosYTesorosFormobjetosYTesoros";
            Load += FormItems_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMostrar;
        private TextBox textBoxBuscador;
        private Label label7;
        private DataGridView dataGridItems;
        private Button buttonAgregar;
        private Button buttonEliminar;
    }
}