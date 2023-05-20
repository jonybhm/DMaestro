namespace PrimerParcial.UI
{
    partial class FormHechizos
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
            dataGridHechizos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridHechizos).BeginInit();
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
            buttonMostrar.Location = new Point(344, 34);
            buttonMostrar.Name = "buttonMostrar";
            buttonMostrar.Size = new Size(153, 34);
            buttonMostrar.TabIndex = 26;
            buttonMostrar.Text = "Mostrar";
            buttonMostrar.UseVisualStyleBackColor = false;
            buttonMostrar.Click += buttonMostrar_Click;
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
            textBoxBuscador.TabIndex = 24;
            textBoxBuscador.TextChanged += textBoxBuscador_TextChanged;
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
            label7.Size = new Size(124, 22);
            label7.TabIndex = 25;
            label7.Text = "Hechizos";
            // 
            // dataGridHechizos
            // 
            dataGridHechizos.AllowUserToAddRows = false;
            dataGridHechizos.AllowUserToDeleteRows = false;
            dataGridHechizos.AllowUserToResizeColumns = false;
            dataGridHechizos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.RosyBrown;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridHechizos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridHechizos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridHechizos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridHechizos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridHechizos.BackgroundColor = Color.IndianRed;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle2.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridHechizos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridHechizos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridHechizos.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridHechizos.GridColor = Color.Linen;
            dataGridHechizos.Location = new Point(-2, 78);
            dataGridHechizos.Name = "dataGridHechizos";
            dataGridHechizos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridHechizos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.RosyBrown;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkRed;
            dataGridHechizos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridHechizos.RowTemplate.Height = 25;
            dataGridHechizos.Size = new Size(537, 406);
            dataGridHechizos.TabIndex = 23;
            // 
            // FormHechizos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 48);
            ClientSize = new Size(533, 479);
            Controls.Add(buttonMostrar);
            Controls.Add(textBoxBuscador);
            Controls.Add(label7);
            Controls.Add(dataGridHechizos);
            Name = "FormHechizos";
            Text = "FormHechizos";
            Load += FormHechizos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridHechizos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMostrar;
        private TextBox textBoxBuscador;
        private Label label7;
        private DataGridView dataGridHechizos;
    }
}