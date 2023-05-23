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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPantallaDM));
            label1 = new Label();
            buttonAgregarPin = new Button();
            timer = new System.Windows.Forms.Timer(components);
            splitContainer1 = new SplitContainer();
            richTextBoxIzquierda = new RichTextBox();
            splitContainer2 = new SplitContainer();
            label7 = new Label();
            richTextBoxCentro = new RichTextBox();
            richTextBoxDerecha = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Universal Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Lavender;
            label1.Location = new Point(597, 13);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 0;
            label1.Text = "Pantalla DM";
            // 
            // buttonAgregarPin
            // 
            buttonAgregarPin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAgregarPin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAgregarPin.BackColor = Color.Transparent;
            buttonAgregarPin.Cursor = Cursors.Hand;
            buttonAgregarPin.FlatAppearance.BorderSize = 0;
            buttonAgregarPin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonAgregarPin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonAgregarPin.FlatStyle = FlatStyle.Flat;
            buttonAgregarPin.Font = new Font("Universal Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAgregarPin.ForeColor = Color.Lavender;
            buttonAgregarPin.Image = (Image)resources.GetObject("buttonAgregarPin.Image");
            buttonAgregarPin.ImageAlign = ContentAlignment.BottomRight;
            buttonAgregarPin.Location = new Point(1221, 566);
            buttonAgregarPin.Name = "buttonAgregarPin";
            buttonAgregarPin.Size = new Size(119, 55);
            buttonAgregarPin.TabIndex = 3;
            buttonAgregarPin.Text = "Agregar";
            buttonAgregarPin.TextAlign = ContentAlignment.TopLeft;
            buttonAgregarPin.UseVisualStyleBackColor = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 20;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Transparent;
            splitContainer1.Panel1.BackgroundImage = Properties.Resources.DMscreen_011;
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(richTextBoxIzquierda);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1353, 633);
            splitContainer1.SplitterDistance = 451;
            splitContainer1.TabIndex = 4;
            // 
            // richTextBoxIzquierda
            // 
            richTextBoxIzquierda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxIzquierda.BackColor = Color.FromArgb(37, 41, 48);
            richTextBoxIzquierda.BorderStyle = BorderStyle.None;
            richTextBoxIzquierda.Location = new Point(30, 66);
            richTextBoxIzquierda.Name = "richTextBoxIzquierda";
            richTextBoxIzquierda.Size = new Size(387, 536);
            richTextBoxIzquierda.TabIndex = 0;
            richTextBoxIzquierda.Text = "";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.Transparent;
            splitContainer2.Panel1.BackgroundImage = Properties.Resources.DMscreen_02;
            splitContainer2.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer2.Panel1.Controls.Add(label7);
            splitContainer2.Panel1.Controls.Add(richTextBoxCentro);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.Transparent;
            splitContainer2.Panel2.BackgroundImage = Properties.Resources.DMscreen_031;
            splitContainer2.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer2.Panel2.Controls.Add(richTextBoxDerecha);
            splitContainer2.Size = new Size(898, 633);
            splitContainer2.SplitterDistance = 434;
            splitContainer2.TabIndex = 0;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Universal Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Lavender;
            label7.Location = new Point(132, 9);
            label7.Name = "label7";
            label7.Size = new Size(167, 22);
            label7.TabIndex = 20;
            label7.Text = "Pantalla DM";
            // 
            // richTextBoxCentro
            // 
            richTextBoxCentro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxCentro.BackColor = Color.FromArgb(37, 41, 48);
            richTextBoxCentro.BorderStyle = BorderStyle.None;
            richTextBoxCentro.Location = new Point(33, 36);
            richTextBoxCentro.Name = "richTextBoxCentro";
            richTextBoxCentro.Size = new Size(369, 566);
            richTextBoxCentro.TabIndex = 1;
            richTextBoxCentro.Text = "";
            // 
            // richTextBoxDerecha
            // 
            richTextBoxDerecha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxDerecha.BackColor = Color.FromArgb(37, 41, 48);
            richTextBoxDerecha.BorderStyle = BorderStyle.None;
            richTextBoxDerecha.Location = new Point(37, 66);
            richTextBoxDerecha.Name = "richTextBoxDerecha";
            richTextBoxDerecha.Size = new Size(387, 536);
            richTextBoxDerecha.TabIndex = 1;
            richTextBoxDerecha.Text = "";
            // 
            // FormPantallaDM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1353, 633);
            Controls.Add(splitContainer1);
            Controls.Add(buttonAgregarPin);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "FormPantallaDM";
            Text = "Pantalla DM";
            Load += FormPantallaDM_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonAgregarPin;
        private DataGridView dataGrid_reglas;
        private System.Windows.Forms.Timer timer;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private RichTextBox richTextBoxIzquierda;
        private RichTextBox richTextBoxCentro;
        private RichTextBox richTextBoxDerecha;
        private Label label7;
    }
}