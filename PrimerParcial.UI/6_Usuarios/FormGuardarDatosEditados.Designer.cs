namespace PrimerParcial.UI._6_Usuarios
{
    partial class FormGuardarDatosEditados
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
            comboBoxTipoUsuario = new ComboBox();
            textBoxNombreApellido = new TextBox();
            textBoxContraseñaConfirm = new TextBox();
            textBoxUsuario = new TextBox();
            buttonGuardar = new Button();
            labelLogin = new Label();
            textBoxContraseña = new TextBox();
            buttonBorrar = new Button();
            SuspendLayout();
            // 
            // comboBoxTipoUsuario
            // 
            comboBoxTipoUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxTipoUsuario.BackColor = Color.LavenderBlush;
            comboBoxTipoUsuario.Font = new Font("Universal Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            comboBoxTipoUsuario.FormattingEnabled = true;
            comboBoxTipoUsuario.Items.AddRange(new object[] { "administrador", "usuario" });
            comboBoxTipoUsuario.Location = new Point(31, 165);
            comboBoxTipoUsuario.Name = "comboBoxTipoUsuario";
            comboBoxTipoUsuario.Size = new Size(286, 21);
            comboBoxTipoUsuario.TabIndex = 18;
            // 
            // textBoxNombreApellido
            // 
            textBoxNombreApellido.BackColor = Color.LavenderBlush;
            textBoxNombreApellido.Font = new Font("Universal Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxNombreApellido.Location = new Point(31, 49);
            textBoxNombreApellido.Name = "textBoxNombreApellido";
            textBoxNombreApellido.PlaceholderText = "Ingrese nombre y apellido";
            textBoxNombreApellido.Size = new Size(286, 20);
            textBoxNombreApellido.TabIndex = 14;
            // 
            // textBoxContraseñaConfirm
            // 
            textBoxContraseñaConfirm.BackColor = Color.LavenderBlush;
            textBoxContraseñaConfirm.Font = new Font("Universal Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxContraseñaConfirm.Location = new Point(31, 136);
            textBoxContraseñaConfirm.Name = "textBoxContraseñaConfirm";
            textBoxContraseñaConfirm.PlaceholderText = "Confirmar la contraseña";
            textBoxContraseñaConfirm.Size = new Size(286, 20);
            textBoxContraseñaConfirm.TabIndex = 17;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.LavenderBlush;
            textBoxUsuario.Font = new Font("Universal Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxUsuario.Location = new Point(31, 78);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "Ingrese nombre de usuario";
            textBoxUsuario.Size = new Size(286, 20);
            textBoxUsuario.TabIndex = 15;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.Transparent;
            buttonGuardar.BackgroundImage = Properties.Resources.boton2;
            buttonGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonGuardar.Dock = DockStyle.Bottom;
            buttonGuardar.FlatAppearance.BorderSize = 0;
            buttonGuardar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonGuardar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.Font = new Font("Universal Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGuardar.Location = new Point(0, 227);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(344, 35);
            buttonGuardar.TabIndex = 20;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelLogin.AutoSize = true;
            labelLogin.FlatStyle = FlatStyle.Flat;
            labelLogin.Font = new Font("Universal Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.Lavender;
            labelLogin.Location = new Point(92, 6);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(161, 18);
            labelLogin.TabIndex = 19;
            labelLogin.Text = "Editar Usuario";
            labelLogin.TextAlign = ContentAlignment.MiddleCenter;
            labelLogin.UseMnemonic = false;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.BackColor = Color.LavenderBlush;
            textBoxContraseña.Font = new Font("Universal Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxContraseña.Location = new Point(31, 107);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.PlaceholderText = "Ingrese la contraseña";
            textBoxContraseña.Size = new Size(286, 20);
            textBoxContraseña.TabIndex = 16;
            // 
            // buttonBorrar
            // 
            buttonBorrar.BackColor = Color.Transparent;
            buttonBorrar.BackgroundImage = Properties.Resources.boton2;
            buttonBorrar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonBorrar.Dock = DockStyle.Bottom;
            buttonBorrar.FlatAppearance.BorderSize = 0;
            buttonBorrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonBorrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonBorrar.FlatStyle = FlatStyle.Flat;
            buttonBorrar.Font = new Font("Universal Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBorrar.Location = new Point(0, 192);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(344, 35);
            buttonBorrar.TabIndex = 21;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = false;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // FormGuardarDatosEditados
            // 
            AcceptButton = buttonGuardar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 48);
            ClientSize = new Size(344, 262);
            Controls.Add(buttonBorrar);
            Controls.Add(comboBoxTipoUsuario);
            Controls.Add(textBoxNombreApellido);
            Controls.Add(textBoxContraseñaConfirm);
            Controls.Add(textBoxUsuario);
            Controls.Add(buttonGuardar);
            Controls.Add(labelLogin);
            Controls.Add(textBoxContraseña);
            Name = "FormGuardarDatosEditados";
            Text = "FormGuardarFatosEditados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTipoUsuario;
        private TextBox textBoxNombreApellido;
        private TextBox textBoxContraseñaConfirm;
        private TextBox textBoxUsuario;
        private Button buttonGuardar;
        private Label labelLogin;
        private TextBox textBoxContraseña;
        private Button buttonBorrar;
    }
}