namespace Bustos_Ej9_Actividad1
{
    partial class ClienteReporteForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NombreClienteLabel = new Label();
            NombreClienteTextBox = new TextBox();
            ApellidoClienteLabel = new Label();
            ApellidoClienteTextBox = new TextBox();
            MailClienteLabel = new Label();
            TelefonoClienteLabel = new Label();
            MailClienteTextBox = new TextBox();
            TelefonoClienteTextBox = new TextBox();
            TipoProblemaLabel = new Label();
            TipoProblemaComboBox = new ComboBox();
            DescripcionProblemaLabel = new Label();
            DatosClienteGroupBox = new GroupBox();
            ReporteGroupBox = new GroupBox();
            DescripcionProblemaTextBox = new TextBox();
            EnviarButton = new Button();
            CancelarButton = new Button();
            DatosClienteGroupBox.SuspendLayout();
            ReporteGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // NombreClienteLabel
            // 
            NombreClienteLabel.AutoSize = true;
            NombreClienteLabel.Location = new Point(6, 33);
            NombreClienteLabel.Name = "NombreClienteLabel";
            NombreClienteLabel.Size = new Size(64, 20);
            NombreClienteLabel.TabIndex = 0;
            NombreClienteLabel.Text = "Nombre";
            // 
            // NombreClienteTextBox
            // 
            NombreClienteTextBox.Location = new Point(6, 56);
            NombreClienteTextBox.Name = "NombreClienteTextBox";
            NombreClienteTextBox.Size = new Size(394, 27);
            NombreClienteTextBox.TabIndex = 1;
            // 
            // ApellidoClienteLabel
            // 
            ApellidoClienteLabel.AutoSize = true;
            ApellidoClienteLabel.Location = new Point(4, 96);
            ApellidoClienteLabel.Name = "ApellidoClienteLabel";
            ApellidoClienteLabel.Size = new Size(66, 20);
            ApellidoClienteLabel.TabIndex = 2;
            ApellidoClienteLabel.Text = "Apellido";
            // 
            // ApellidoClienteTextBox
            // 
            ApellidoClienteTextBox.Location = new Point(6, 130);
            ApellidoClienteTextBox.Name = "ApellidoClienteTextBox";
            ApellidoClienteTextBox.Size = new Size(394, 27);
            ApellidoClienteTextBox.TabIndex = 3;
            // 
            // MailClienteLabel
            // 
            MailClienteLabel.AutoSize = true;
            MailClienteLabel.Location = new Point(6, 176);
            MailClienteLabel.Name = "MailClienteLabel";
            MailClienteLabel.Size = new Size(38, 20);
            MailClienteLabel.TabIndex = 4;
            MailClienteLabel.Text = "Mail";
            // 
            // TelefonoClienteLabel
            // 
            TelefonoClienteLabel.AutoSize = true;
            TelefonoClienteLabel.Location = new Point(6, 252);
            TelefonoClienteLabel.Name = "TelefonoClienteLabel";
            TelefonoClienteLabel.Size = new Size(67, 20);
            TelefonoClienteLabel.TabIndex = 5;
            TelefonoClienteLabel.Text = "Teléfono";
            // 
            // MailClienteTextBox
            // 
            MailClienteTextBox.Location = new Point(6, 199);
            MailClienteTextBox.Name = "MailClienteTextBox";
            MailClienteTextBox.Size = new Size(394, 27);
            MailClienteTextBox.TabIndex = 6;
            MailClienteTextBox.TextChanged += MailClienteTextBox_TextChanged;
            // 
            // TelefonoClienteTextBox
            // 
            TelefonoClienteTextBox.Location = new Point(6, 275);
            TelefonoClienteTextBox.Name = "TelefonoClienteTextBox";
            TelefonoClienteTextBox.Size = new Size(394, 27);
            TelefonoClienteTextBox.TabIndex = 7;
            // 
            // TipoProblemaLabel
            // 
            TipoProblemaLabel.AutoSize = true;
            TipoProblemaLabel.Location = new Point(6, 37);
            TipoProblemaLabel.Name = "TipoProblemaLabel";
            TipoProblemaLabel.Size = new Size(129, 20);
            TipoProblemaLabel.TabIndex = 8;
            TipoProblemaLabel.Text = "Tipo de problema";
            // 
            // TipoProblemaComboBox
            // 
            TipoProblemaComboBox.FormattingEnabled = true;
            TipoProblemaComboBox.Items.AddRange(new object[] { "Hardware", "Software", "Red", "Otro" });
            TipoProblemaComboBox.Location = new Point(6, 70);
            TipoProblemaComboBox.Name = "TipoProblemaComboBox";
            TipoProblemaComboBox.Size = new Size(394, 28);
            TipoProblemaComboBox.TabIndex = 9;
            TipoProblemaComboBox.SelectedIndexChanged += TipoProblemaComboBox_SelectedIndexChanged;
            // 
            // DescripcionProblemaLabel
            // 
            DescripcionProblemaLabel.AutoSize = true;
            DescripcionProblemaLabel.Location = new Point(2, 118);
            DescripcionProblemaLabel.Name = "DescripcionProblemaLabel";
            DescripcionProblemaLabel.Size = new Size(177, 20);
            DescripcionProblemaLabel.TabIndex = 10;
            DescripcionProblemaLabel.Text = "Descripción de problema";
            // 
            // DatosClienteGroupBox
            // 
            DatosClienteGroupBox.Controls.Add(NombreClienteTextBox);
            DatosClienteGroupBox.Controls.Add(NombreClienteLabel);
            DatosClienteGroupBox.Controls.Add(ApellidoClienteLabel);
            DatosClienteGroupBox.Controls.Add(ApellidoClienteTextBox);
            DatosClienteGroupBox.Controls.Add(TelefonoClienteLabel);
            DatosClienteGroupBox.Controls.Add(TelefonoClienteTextBox);
            DatosClienteGroupBox.Controls.Add(MailClienteTextBox);
            DatosClienteGroupBox.Controls.Add(MailClienteLabel);
            DatosClienteGroupBox.Location = new Point(12, 12);
            DatosClienteGroupBox.Name = "DatosClienteGroupBox";
            DatosClienteGroupBox.Size = new Size(406, 337);
            DatosClienteGroupBox.TabIndex = 11;
            DatosClienteGroupBox.TabStop = false;
            DatosClienteGroupBox.Text = "Datos cliente";
            DatosClienteGroupBox.Enter += groupBox1_Enter;
            // 
            // ReporteGroupBox
            // 
            ReporteGroupBox.Controls.Add(DescripcionProblemaTextBox);
            ReporteGroupBox.Controls.Add(TipoProblemaComboBox);
            ReporteGroupBox.Controls.Add(TipoProblemaLabel);
            ReporteGroupBox.Controls.Add(DescripcionProblemaLabel);
            ReporteGroupBox.Location = new Point(12, 364);
            ReporteGroupBox.Name = "ReporteGroupBox";
            ReporteGroupBox.Size = new Size(406, 201);
            ReporteGroupBox.TabIndex = 12;
            ReporteGroupBox.TabStop = false;
            ReporteGroupBox.Text = "Reporte";
            // 
            // DescripcionProblemaTextBox
            // 
            DescripcionProblemaTextBox.Location = new Point(6, 153);
            DescripcionProblemaTextBox.Name = "DescripcionProblemaTextBox";
            DescripcionProblemaTextBox.Size = new Size(394, 27);
            DescripcionProblemaTextBox.TabIndex = 11;
            // 
            // EnviarButton
            // 
            EnviarButton.Location = new Point(178, 584);
            EnviarButton.Name = "EnviarButton";
            EnviarButton.Size = new Size(115, 28);
            EnviarButton.TabIndex = 13;
            EnviarButton.Text = "Enviar";
            EnviarButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(303, 584);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(115, 28);
            CancelarButton.TabIndex = 14;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 614);
            Controls.Add(CancelarButton);
            Controls.Add(EnviarButton);
            Controls.Add(ReporteGroupBox);
            Controls.Add(DatosClienteGroupBox);
            Name = "ClienteForm";
            Text = "Reporte de problema (cliente)";
            Load += ClienteForm_Load;
            DatosClienteGroupBox.ResumeLayout(false);
            DatosClienteGroupBox.PerformLayout();
            ReporteGroupBox.ResumeLayout(false);
            ReporteGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label NombreClienteLabel;
        private TextBox NombreClienteTextBox;
        private Label ApellidoClienteLabel;
        private TextBox ApellidoClienteTextBox;
        private Label MailClienteLabel;
        private Label TelefonoClienteLabel;
        private TextBox MailClienteTextBox;
        private TextBox TelefonoClienteTextBox;
        private Label TipoProblemaLabel;
        private ComboBox TipoProblemaComboBox;
        private Label DescripcionProblemaLabel;
        private GroupBox DatosClienteGroupBox;
        private GroupBox ReporteGroupBox;
        private TextBox DescripcionProblemaTextBox;
        private Button EnviarButton;
        private Button CancelarButton;
    }
}
