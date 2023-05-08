namespace PrimerParcial.UI
{
    partial class FormLogin
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
            textContraseña = new TextBox();
            label1 = new Label();
            buttonIngresar = new Button();
            textUsuario = new TextBox();
            SuspendLayout();
            // 
            // textContraseña
            // 
            textContraseña.Location = new Point(31, 113);
            textContraseña.Name = "textContraseña";
            textContraseña.PlaceholderText = "Ingrese la contraseña";
            textContraseña.Size = new Size(286, 23);
            textContraseña.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(136, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // buttonIngresar
            // 
            buttonIngresar.Location = new Point(101, 157);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(129, 53);
            buttonIngresar.TabIndex = 2;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = true;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(31, 70);
            textUsuario.Name = "textUsuario";
            textUsuario.PlaceholderText = "Ingrese nombre de usuario";
            textUsuario.Size = new Size(286, 23);
            textUsuario.TabIndex = 0;
            // 
            // FormLogin
            // 
            AcceptButton = buttonIngresar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 261);
            Controls.Add(textUsuario);
            Controls.Add(buttonIngresar);
            Controls.Add(label1);
            Controls.Add(textContraseña);
            Name = "FormLogin";
            Text = "Iniciar Sesion";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textContraseña;
        private Label label1;
        private Button buttonIngresar;
        private TextBox textUsuario;
    }
}