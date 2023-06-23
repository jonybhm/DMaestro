namespace PrimerParcial.UI._6_Usuarios
{
    partial class FormEditarUsuario
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
            textBoxUsuario = new TextBox();
            buttonEditar = new Button();
            labelLogin = new Label();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.LavenderBlush;
            textBoxUsuario.Font = new Font("Universal Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxUsuario.Location = new Point(31, 116);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "Ingrese nombre de usuario";
            textBoxUsuario.Size = new Size(286, 20);
            textBoxUsuario.TabIndex = 8;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.Transparent;
            buttonEditar.BackgroundImage = Properties.Resources.boton2;
            buttonEditar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEditar.Dock = DockStyle.Bottom;
            buttonEditar.FlatAppearance.BorderSize = 0;
            buttonEditar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonEditar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.Font = new Font("Universal Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditar.Location = new Point(0, 227);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(350, 35);
            buttonEditar.TabIndex = 13;
            buttonEditar.Text = "Editar/Borrar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelLogin.AutoSize = true;
            labelLogin.FlatStyle = FlatStyle.Flat;
            labelLogin.Font = new Font("Universal Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.Lavender;
            labelLogin.Location = new Point(0, 9);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(348, 18);
            labelLogin.TabIndex = 12;
            labelLogin.Text = "Ingrese Usuario a Editar/Borrar";
            labelLogin.TextAlign = ContentAlignment.MiddleCenter;
            labelLogin.UseMnemonic = false;
            // 
            // FormEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 48);
            ClientSize = new Size(350, 262);
            Controls.Add(textBoxUsuario);
            Controls.Add(buttonEditar);
            Controls.Add(labelLogin);
            Name = "FormEditarUsuario";
            Text = "FormEditarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxUsuario;
        private Button buttonEditar;
        private Label labelLogin;
    }
}