namespace PrimerParcial.UI
{
    partial class FormCombateDificultad
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
            textBoxCantidadPC = new TextBox();
            comboBoxDificultad = new ComboBox();
            textBoxNivelPC = new TextBox();
            comboBoxTipoEnemigos = new ComboBox();
            textBoxCantidadEnemigos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxChallengeRating = new TextBox();
            textBoxXP = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            dataGridEnemigos = new DataGridView();
            dataGridTablaReferencia = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridEnemigos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTablaReferencia).BeginInit();
            SuspendLayout();
            // 
            // textBoxCantidadPC
            // 
            textBoxCantidadPC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxCantidadPC.BackColor = Color.Linen;
            textBoxCantidadPC.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCantidadPC.Location = new Point(12, 18);
            textBoxCantidadPC.Name = "textBoxCantidadPC";
            textBoxCantidadPC.PlaceholderText = "Cantidad Jugadores";
            textBoxCantidadPC.Size = new Size(210, 20);
            textBoxCantidadPC.TabIndex = 0;
            // 
            // comboBoxDificultad
            // 
            comboBoxDificultad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxDificultad.BackColor = Color.Linen;
            comboBoxDificultad.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDificultad.FormattingEnabled = true;
            comboBoxDificultad.Items.AddRange(new object[] { "Fácil", "Medio", "Difícil", "Mortal" });
            comboBoxDificultad.Location = new Point(12, 76);
            comboBoxDificultad.Name = "comboBoxDificultad";
            comboBoxDificultad.Size = new Size(210, 21);
            comboBoxDificultad.TabIndex = 2;
            // 
            // textBoxNivelPC
            // 
            textBoxNivelPC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxNivelPC.BackColor = Color.Linen;
            textBoxNivelPC.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNivelPC.Location = new Point(12, 47);
            textBoxNivelPC.Name = "textBoxNivelPC";
            textBoxNivelPC.PlaceholderText = "Nivel Promedio";
            textBoxNivelPC.Size = new Size(210, 20);
            textBoxNivelPC.TabIndex = 3;
            // 
            // comboBoxTipoEnemigos
            // 
            comboBoxTipoEnemigos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxTipoEnemigos.BackColor = Color.Linen;
            comboBoxTipoEnemigos.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTipoEnemigos.FormattingEnabled = true;
            comboBoxTipoEnemigos.Items.AddRange(new object[] { "1 Jefe", "Grupo", "1 Jefe + Grupo", "1 Jefe + 1 Subjefe", "1 Jefe + 1 Subjefe + Grupo" });
            comboBoxTipoEnemigos.Location = new Point(12, 134);
            comboBoxTipoEnemigos.Name = "comboBoxTipoEnemigos";
            comboBoxTipoEnemigos.Size = new Size(210, 21);
            comboBoxTipoEnemigos.TabIndex = 4;
            // 
            // textBoxCantidadEnemigos
            // 
            textBoxCantidadEnemigos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxCantidadEnemigos.BackColor = Color.Linen;
            textBoxCantidadEnemigos.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCantidadEnemigos.Location = new Point(12, 105);
            textBoxCantidadEnemigos.Name = "textBoxCantidadEnemigos";
            textBoxCantidadEnemigos.PlaceholderText = "Cantidad Enemigos";
            textBoxCantidadEnemigos.Size = new Size(210, 20);
            textBoxCantidadEnemigos.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(239, 31);
            label1.Name = "label1";
            label1.Size = new Size(27, 13);
            label1.TabIndex = 6;
            label1.Text = "CR:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(239, 89);
            label2.Name = "label2";
            label2.Size = new Size(72, 13);
            label2.TabIndex = 7;
            label2.Text = "XP Total:";
            // 
            // textBoxChallengeRating
            // 
            textBoxChallengeRating.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxChallengeRating.BackColor = Color.Linen;
            textBoxChallengeRating.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxChallengeRating.Location = new Point(241, 47);
            textBoxChallengeRating.Name = "textBoxChallengeRating";
            textBoxChallengeRating.ReadOnly = true;
            textBoxChallengeRating.Size = new Size(214, 20);
            textBoxChallengeRating.TabIndex = 8;
            // 
            // textBoxXP
            // 
            textBoxXP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxXP.BackColor = Color.Linen;
            textBoxXP.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxXP.Location = new Point(239, 105);
            textBoxXP.Name = "textBoxXP";
            textBoxXP.ReadOnly = true;
            textBoxXP.Size = new Size(105, 20);
            textBoxXP.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(350, 89);
            label3.Name = "label3";
            label3.Size = new Size(75, 13);
            label3.TabIndex = 10;
            label3.Text = "XP por PC:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.BackColor = Color.Linen;
            textBox1.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(350, 105);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(105, 20);
            textBox1.TabIndex = 11;
            // 
            // dataGridEnemigos
            // 
            dataGridEnemigos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridEnemigos.BackgroundColor = Color.Linen;
            dataGridEnemigos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEnemigos.GridColor = Color.Linen;
            dataGridEnemigos.Location = new Point(523, 18);
            dataGridEnemigos.Name = "dataGridEnemigos";
            dataGridEnemigos.RowTemplate.Height = 25;
            dataGridEnemigos.Size = new Size(370, 559);
            dataGridEnemigos.TabIndex = 12;
            // 
            // dataGridTablaReferencia
            // 
            dataGridTablaReferencia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridTablaReferencia.BackgroundColor = Color.Linen;
            dataGridTablaReferencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTablaReferencia.GridColor = Color.Linen;
            dataGridTablaReferencia.Location = new Point(12, 334);
            dataGridTablaReferencia.Name = "dataGridTablaReferencia";
            dataGridTablaReferencia.RowTemplate.Height = 25;
            dataGridTablaReferencia.Size = new Size(210, 237);
            dataGridTablaReferencia.TabIndex = 13;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Universal Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 318);
            label4.Name = "label4";
            label4.Size = new Size(152, 13);
            label4.TabIndex = 14;
            label4.Text = "Tabla de referencia";
            label4.Click += label4_Click;
            // 
            // FormCombateDificultad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(904, 589);
            Controls.Add(label4);
            Controls.Add(dataGridTablaReferencia);
            Controls.Add(dataGridEnemigos);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(textBoxXP);
            Controls.Add(textBoxChallengeRating);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxCantidadEnemigos);
            Controls.Add(comboBoxTipoEnemigos);
            Controls.Add(textBoxNivelPC);
            Controls.Add(comboBoxDificultad);
            Controls.Add(textBoxCantidadPC);
            Name = "FormCombateDificultad";
            Text = "FormCombateDificultad";
            Load += FormCombateDificultad_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridEnemigos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTablaReferencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCantidadPC;
        private ComboBox comboBoxDificultad;
        private TextBox textBoxNivelPC;
        private ComboBox comboBoxTipoEnemigos;
        private TextBox textBoxCantidadEnemigos;
        private Label label1;
        private Label label2;
        private TextBox textBoxChallengeRating;
        private TextBox textBoxXP;
        private Label label3;
        private TextBox textBox1;
        private DataGridView dataGridEnemigos;
        private DataGridView dataGridTablaReferencia;
        private Label label4;
    }
}