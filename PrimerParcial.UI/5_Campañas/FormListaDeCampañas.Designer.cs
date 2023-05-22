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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            buttonOpen = new Button();
            textBoxBuscador = new TextBox();
            label7 = new Label();
            dataGridCampañas = new DataGridView();
            buttonNew = new Button();
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
            buttonOpen.Location = new Point(343, 39);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(153, 34);
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
            dataGridViewCellStyle6.BackColor = Color.RosyBrown;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridCampañas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridCampañas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridCampañas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridCampañas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridCampañas.BackgroundColor = Color.IndianRed;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle7.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridCampañas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridCampañas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridCampañas.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridCampañas.GridColor = Color.Linen;
            dataGridCampañas.Location = new Point(-2, 83);
            dataGridCampañas.Name = "dataGridCampañas";
            dataGridCampañas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridCampañas.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = Color.RosyBrown;
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.DarkRed;
            dataGridCampañas.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridCampañas.RowTemplate.Height = 50;
            dataGridCampañas.Size = new Size(510, 424);
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
            buttonNew.Location = new Point(343, 8);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(153, 34);
            buttonNew.TabIndex = 32;
            buttonNew.Text = "Nueva";
            buttonNew.UseVisualStyleBackColor = false;
            buttonNew.Click += buttonNew_Click;
            // 
            // FormListaDeCampañas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 48);
            ClientSize = new Size(506, 505);
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
    }
}