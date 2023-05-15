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
            labelLogin = new Label();
            buttonIngresar = new Button();
            textUsuario = new TextBox();
            SuspendLayout();
            // 
            // textContraseña
            // 
            textContraseña.Location = new Point(31, 130);
            textContraseña.Name = "textContraseña";
            textContraseña.PlaceholderText = "Ingrese la contraseña";
            textContraseña.Size = new Size(286, 23);
            textContraseña.TabIndex = 1;
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelLogin.AutoSize = true;
            labelLogin.FlatStyle = FlatStyle.Flat;
            labelLogin.Font = new Font("Universal Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.Lavender;
            labelLogin.Location = new Point(101, 22);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(148, 18);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "INICIAR SESION";
            labelLogin.TextAlign = ContentAlignment.MiddleCenter;
            labelLogin.UseMnemonic = false;
            // 
            // buttonIngresar
            // 
            buttonIngresar.BackColor = Color.Transparent;
            buttonIngresar.BackgroundImage = Properties.Resources.boton2;
            buttonIngresar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonIngresar.Dock = DockStyle.Bottom;
            buttonIngresar.FlatAppearance.BorderSize = 0;
            buttonIngresar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonIngresar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonIngresar.FlatStyle = FlatStyle.Flat;
            buttonIngresar.Font = new Font("Universal Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIngresar.Location = new Point(0, 212);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(350, 35);
            buttonIngresar.TabIndex = 2;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = false;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(31, 78);
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
            BackColor = Color.FromArgb(37, 41, 48);
            ClientSize = new Size(350, 247);
            Controls.Add(textUsuario);
            Controls.Add(buttonIngresar);
            Controls.Add(labelLogin);
            Controls.Add(textContraseña);
            Name = "FormLogin";
            Text = "Iniciar Sesion";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textContraseña;
        private Label labelLogin;
        private Button buttonIngresar;
        private TextBox textUsuario;
    }
}