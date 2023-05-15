namespace PrimerParcial.UI
{
    partial class FormReglas
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
            richTextBoxReglas = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBoxReglas
            // 
            richTextBoxReglas.BackColor = Color.FromArgb(37, 41, 48);
            richTextBoxReglas.BorderStyle = BorderStyle.None;
            richTextBoxReglas.Dock = DockStyle.Fill;
            richTextBoxReglas.Font = new Font("Universal Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxReglas.ForeColor = SystemColors.MenuBar;
            richTextBoxReglas.Location = new Point(0, 0);
            richTextBoxReglas.Name = "richTextBoxReglas";
            richTextBoxReglas.Size = new Size(528, 807);
            richTextBoxReglas.TabIndex = 0;
            richTextBoxReglas.Text = "";
            // 
            // FormReglas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 807);
            Controls.Add(richTextBoxReglas);
            Name = "FormReglas";
            Text = "Reglas";
            Load += FormReglas_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxReglas;
    }
}