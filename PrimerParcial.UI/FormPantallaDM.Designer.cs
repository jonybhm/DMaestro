namespace PrimerParcial.UI
{
    partial class FormPantallaDM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPantallaDM));
            label1 = new Label();
            button_Pin = new Button();
            dataGrid_Estados = new DataGridView();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Estados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Universal Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(531, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 0;
            label1.Text = "Pantalla DM";
            // 
            // button_Pin
            // 
            button_Pin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_Pin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_Pin.BackColor = Color.Transparent;
            button_Pin.Cursor = Cursors.Hand;
            button_Pin.FlatAppearance.BorderSize = 0;
            button_Pin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_Pin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_Pin.FlatStyle = FlatStyle.Flat;
            button_Pin.Font = new Font("Universal Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Pin.ForeColor = Color.Black;
            button_Pin.Image = (Image)resources.GetObject("button_Pin.Image");
            button_Pin.ImageAlign = ContentAlignment.BottomRight;
            button_Pin.Location = new Point(165, 9);
            button_Pin.Name = "button_Pin";
            button_Pin.Size = new Size(122, 55);
            button_Pin.TabIndex = 3;
            button_Pin.Text = "Agregar";
            button_Pin.TextAlign = ContentAlignment.TopLeft;
            button_Pin.UseVisualStyleBackColor = false;
            button_Pin.Click += button_Pin_Click;
            // 
            // dataGrid_Estados
            // 
            dataGrid_Estados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGrid_Estados.BackgroundColor = Color.Linen;
            dataGrid_Estados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Estados.GridColor = Color.Linen;
            dataGrid_Estados.Location = new Point(12, 73);
            dataGrid_Estados.Name = "dataGrid_Estados";
            dataGrid_Estados.RowTemplate.Height = 25;
            dataGrid_Estados.Size = new Size(275, 548);
            dataGrid_Estados.TabIndex = 4;
            dataGrid_Estados.CellContentClick += dataGrid_Estados_CellContentClick;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridView1.BackgroundColor = Color.Linen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Linen;
            dataGridView1.Location = new Point(338, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(556, 548);
            dataGridView1.TabIndex = 5;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView2.BackgroundColor = Color.Linen;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = Color.Linen;
            dataGridView2.Location = new Point(948, 73);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(275, 548);
            dataGridView2.TabIndex = 6;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Universal Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.BottomRight;
            button1.Location = new Point(12, 9);
            button1.Name = "button1";
            button1.Size = new Size(149, 55);
            button1.TabIndex = 7;
            button1.Text = "Mostrar Detalles";
            button1.TextAlign = ContentAlignment.TopLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormPantallaDM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1235, 633);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(button_Pin);
            Controls.Add(dataGridView2);
            Controls.Add(dataGrid_Estados);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "FormPantallaDM";
            Text = "Pantalla DM";
            Load += FormPantallaDM_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_Estados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_Pin;
        private DataGridView dataGrid_reglas;
        private DataGridView dataGrid_Estados;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button button1;
    }
}