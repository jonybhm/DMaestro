namespace PrimerParcial.UI
{
    partial class FormIniciativa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIniciativa));
            dataGridSeguidorIniciativa = new DataGridView();
            Iniciativa = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            AC = new DataGridViewTextBoxColumn();
            HP = new DataGridViewTextBoxColumn();
            buttonTirar = new Button();
            buttonOrdenar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridSeguidorIniciativa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridSeguidorIniciativa
            // 
            dataGridSeguidorIniciativa.AllowDrop = true;
            dataGridSeguidorIniciativa.AllowUserToOrderColumns = true;
            dataGridSeguidorIniciativa.AllowUserToResizeColumns = false;
            dataGridSeguidorIniciativa.AllowUserToResizeRows = false;
            dataGridSeguidorIniciativa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridSeguidorIniciativa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridSeguidorIniciativa.BackgroundColor = Color.FromArgb(37, 41, 48);
            dataGridSeguidorIniciativa.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle1.Font = new Font("Universal Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridSeguidorIniciativa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridSeguidorIniciativa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSeguidorIniciativa.Columns.AddRange(new DataGridViewColumn[] { Iniciativa, Nombre, AC, HP });
            dataGridSeguidorIniciativa.GridColor = Color.SteelBlue;
            dataGridSeguidorIniciativa.ImeMode = ImeMode.NoControl;
            dataGridSeguidorIniciativa.Location = new Point(1, 0);
            dataGridSeguidorIniciativa.Name = "dataGridSeguidorIniciativa";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 41, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridSeguidorIniciativa.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridSeguidorIniciativa.RowTemplate.Height = 25;
            dataGridSeguidorIniciativa.ScrollBars = ScrollBars.None;
            dataGridSeguidorIniciativa.Size = new Size(355, 306);
            dataGridSeguidorIniciativa.TabIndex = 0;
            dataGridSeguidorIniciativa.CellContentClick += dataGridSeguidorIniciativa_CellContentClick;
            // 
            // Iniciativa
            // 
            Iniciativa.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Iniciativa.HeaderText = "Iniciativa";
            Iniciativa.Name = "Iniciativa";
            Iniciativa.Width = 116;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 96;
            // 
            // AC
            // 
            AC.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AC.HeaderText = "AC";
            AC.Name = "AC";
            AC.Width = 53;
            // 
            // HP
            // 
            HP.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            HP.HeaderText = "HP";
            HP.Name = "HP";
            HP.Width = 53;
            // 
            // buttonTirar
            // 
            buttonTirar.BackColor = Color.Transparent;
            buttonTirar.BackgroundImage = Properties.Resources.boton2;
            buttonTirar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonTirar.FlatAppearance.BorderSize = 0;
            buttonTirar.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonTirar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonTirar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonTirar.FlatStyle = FlatStyle.Flat;
            buttonTirar.Font = new Font("Universal Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTirar.Location = new Point(20, 517);
            buttonTirar.Name = "buttonTirar";
            buttonTirar.Size = new Size(155, 28);
            buttonTirar.TabIndex = 2;
            buttonTirar.Text = "Tirar";
            buttonTirar.UseVisualStyleBackColor = false;
            buttonTirar.Click += buttonTirar_Click;
            // 
            // buttonOrdenar
            // 
            buttonOrdenar.BackColor = Color.Transparent;
            buttonOrdenar.BackgroundImage = Properties.Resources.boton2;
            buttonOrdenar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOrdenar.FlatAppearance.BorderSize = 0;
            buttonOrdenar.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonOrdenar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonOrdenar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonOrdenar.FlatStyle = FlatStyle.Flat;
            buttonOrdenar.Font = new Font("Universal Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOrdenar.Location = new Point(181, 517);
            buttonOrdenar.Name = "buttonOrdenar";
            buttonOrdenar.Size = new Size(155, 28);
            buttonOrdenar.TabIndex = 1;
            buttonOrdenar.Text = "Ordenar";
            buttonOrdenar.UseVisualStyleBackColor = false;
            buttonOrdenar.Click += buttonOrdenar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(37, 41, 48);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(1, 312);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 260);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormIniciativa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(37, 41, 48);
            ClientSize = new Size(357, 573);
            Controls.Add(buttonOrdenar);
            Controls.Add(buttonTirar);
            Controls.Add(dataGridSeguidorIniciativa);
            Controls.Add(pictureBox1);
            Name = "FormIniciativa";
            Text = "FormCrearCombate";
            Load += FormIniciativa_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridSeguidorIniciativa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridSeguidorIniciativa;
        private Button buttonTirar;
        private Button buttonOrdenar;
        private DataGridViewTextBoxColumn Iniciativa;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn AC;
        private DataGridViewTextBoxColumn HP;
        private PictureBox pictureBox1;
    }
}