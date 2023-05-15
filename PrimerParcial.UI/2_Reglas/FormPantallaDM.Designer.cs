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
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Universal Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Lavender;
            label1.Location = new Point(584, 13);
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
            buttonAgregarPin.Location = new Point(1195, 566);
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
            timer.Tick += timer_Tick;
            // 
            // FormPantallaDM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1327, 633);
            Controls.Add(buttonAgregarPin);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "FormPantallaDM";
            Text = "Pantalla DM";
            Load += FormPantallaDM_Load;
            Paint += FormPantallaDM_Paint;
            MouseDown += FormPantallaDM_MouseDown;
            MouseMove += FormPantallaDM_MouseMove;
            MouseUp += FormPantallaDM_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonAgregarPin;
        private DataGridView dataGrid_reglas;
        private System.Windows.Forms.Timer timer;
    }
}