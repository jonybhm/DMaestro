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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            buttonMostrar = new Button();
            textBoxBuscador = new TextBox();
            label7 = new Label();
            dataGridItems = new DataGridView();
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
            label7.Size = new Size(124, 22);
            label7.TabIndex = 29;
            label7.Text = "Hechizos";
            // 
            // dataGridItems
            // 
            dataGridViewCellStyle11.BackColor = Color.RosyBrown;
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridItems.BackgroundColor = Color.IndianRed;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dataGridItems.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridItems.GridColor = Color.Linen;
            dataGridItems.Location = new Point(0, 80);
            dataGridItems.Name = "dataGridItems";
            dataGridItems.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dataGridItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.BackColor = Color.RosyBrown;
            dataGridViewCellStyle15.ForeColor = Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = Color.DarkRed;
            dataGridItems.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dataGridItems.RowTemplate.Height = 25;
            dataGridItems.Size = new Size(507, 452);
            dataGridItems.TabIndex = 27;
            // 
            // FormItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 48);
            ClientSize = new Size(507, 532);
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
    }
}