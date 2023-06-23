namespace PrimerParcial.UI._1_Contenedor
{
    partial class FormUsuarioNuevo
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
            buttonAgregar = new Button();
            labelLogin = new Label();
            textBoxContraseña = new TextBox();
            textBoxContraseñaConfirm = new TextBox();
            textBoxNombreApellido = new TextBox();
            comboBoxTipoUsuario = new ComboBox();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.LavenderBlush;
            textBoxUsuario.Font = new Font("Universal Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxUsuario.Location = new Point(31, 93);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "Ingrese nombre de usuario";
            textBoxUsuario.Size = new Size(286, 20);
            textBoxUsuario.TabIndex = 1;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.Transparent;
            buttonAgregar.BackgroundImage = Properties.Resources.boton2;
            buttonAgregar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAgregar.Dock = DockStyle.Bottom;
            buttonAgregar.FlatAppearance.BorderSize = 0;
            buttonAgregar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonAgregar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonAgregar.FlatStyle = FlatStyle.Flat;
            buttonAgregar.Font = new Font("Universal Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregar.Location = new Point(0, 227);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(344, 35);
            buttonAgregar.TabIndex = 6;
            buttonAgregar.Text = "Agregar Usuario";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelLogin.AutoSize = true;
            labelLogin.FlatStyle = FlatStyle.Flat;
            labelLogin.Font = new Font("Universal Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.Lavender;
            labelLogin.Location = new Point(46, 21);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(255, 18);
            labelLogin.TabIndex = 4;
            labelLogin.Text = "Ingresar Nuevo Usuario";
            labelLogin.TextAlign = ContentAlignment.MiddleCenter;
            labelLogin.UseMnemonic = false;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.BackColor = Color.LavenderBlush;
            textBoxContraseña.Font = new Font("Universal Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxContraseña.Location = new Point(31, 122);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.PlaceholderText = "Ingrese la contraseña";
            textBoxContraseña.Size = new Size(286, 20);
            textBoxContraseña.TabIndex = 2;
            // 
            // textBoxContraseñaConfirm
            // 
            textBoxContraseñaConfirm.BackColor = Color.LavenderBlush;
            textBoxContraseñaConfirm.Font = new Font("Universal Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxContraseñaConfirm.Location = new Point(31, 151);
            textBoxContraseñaConfirm.Name = "textBoxContraseñaConfirm";
            textBoxContraseñaConfirm.PlaceholderText = "Confirmar la contraseña";
            textBoxContraseñaConfirm.Size = new Size(286, 20);
            textBoxContraseñaConfirm.TabIndex = 3;
            // 
            // textBoxNombreApellido
            // 
            textBoxNombreApellido.BackColor = Color.LavenderBlush;
            textBoxNombreApellido.Font = new Font("Universal Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxNombreApellido.Location = new Point(31, 64);
            textBoxNombreApellido.Name = "textBoxNombreApellido";
            textBoxNombreApellido.PlaceholderText = "Ingrese nombre y apellido";
            textBoxNombreApellido.Size = new Size(286, 20);
            textBoxNombreApellido.TabIndex = 0;
            // 
            // comboBoxTipoUsuario
            // 
            comboBoxTipoUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxTipoUsuario.BackColor = Color.LavenderBlush;
            comboBoxTipoUsuario.Font = new Font("Universal Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            comboBoxTipoUsuario.FormattingEnabled = true;
            comboBoxTipoUsuario.Items.AddRange(new object[] { "administrador", "usuario" });
            comboBoxTipoUsuario.Location = new Point(31, 180);
            comboBoxTipoUsuario.Name = "comboBoxTipoUsuario";
            comboBoxTipoUsuario.Size = new Size(286, 21);
            comboBoxTipoUsuario.TabIndex = 4;
            // 
            // FormUsuarioNuevo
            // 
            AcceptButton = buttonAgregar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 48);
            ClientSize = new Size(344, 262);
            Controls.Add(comboBoxTipoUsuario);
            Controls.Add(textBoxNombreApellido);
            Controls.Add(textBoxContraseñaConfirm);
            Controls.Add(textBoxUsuario);
            Controls.Add(buttonAgregar);
            Controls.Add(labelLogin);
            Controls.Add(textBoxContraseña);
            Name = "FormUsuarioNuevo";
            Text = "FormUsuarioNuevo";
            Load += FormUsuarioNuevo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuario;
        private Button buttonAgregar;
        private Label labelLogin;
        private TextBox textBoxContraseña;
        private TextBox textBoxContraseñaConfirm;
        private TextBox textBoxNombreApellido;
        private ComboBox comboBoxTipoUsuario;
    }
}