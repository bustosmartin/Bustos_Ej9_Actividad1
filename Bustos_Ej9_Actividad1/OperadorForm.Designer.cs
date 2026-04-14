namespace Bustos_Ej9_Actividad1
{
    partial class OperadorForm
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
            DetalleTicketGroupBox = new GroupBox();
            NumeroTicketLabel = new Label();
            TipoProblemaLabel = new Label();
            TipoProblemaComboBox = new ComboBox();
            DescripcionProblemaLabel = new Label();
            DescripcionProblemaTextBox = new TextBox();
            DetallesTecnicoGrupoBox = new GroupBox();
            NombreTecnicoLabel = new Label();
            ApellidoTecnicoLabel = new Label();
            NombreTecnicoTextBox = new TextBox();
            NumeroTicketTextBox = new TextBox();
            ApellidoTecnicoTextBox = new TextBox();
            LegajoLabel = new Label();
            textBox1 = new TextBox();
            CancelarButton = new Button();
            AsignarButton = new Button();
            DetalleTicketGroupBox.SuspendLayout();
            DetallesTecnicoGrupoBox.SuspendLayout();
            SuspendLayout();
            // 
            // DetalleTicketGroupBox
            // 
            DetalleTicketGroupBox.Controls.Add(NumeroTicketTextBox);
            DetalleTicketGroupBox.Controls.Add(DescripcionProblemaTextBox);
            DetalleTicketGroupBox.Controls.Add(DescripcionProblemaLabel);
            DetalleTicketGroupBox.Controls.Add(TipoProblemaComboBox);
            DetalleTicketGroupBox.Controls.Add(TipoProblemaLabel);
            DetalleTicketGroupBox.Controls.Add(NumeroTicketLabel);
            DetalleTicketGroupBox.Location = new Point(16, 12);
            DetalleTicketGroupBox.Name = "DetalleTicketGroupBox";
            DetalleTicketGroupBox.Size = new Size(414, 279);
            DetalleTicketGroupBox.TabIndex = 0;
            DetalleTicketGroupBox.TabStop = false;
            DetalleTicketGroupBox.Text = "Detalle ticket";
            // 
            // NumeroTicketLabel
            // 
            NumeroTicketLabel.AutoSize = true;
            NumeroTicketLabel.Location = new Point(9, 31);
            NumeroTicketLabel.Name = "NumeroTicketLabel";
            NumeroTicketLabel.Size = new Size(127, 20);
            NumeroTicketLabel.TabIndex = 0;
            NumeroTicketLabel.Text = "Número de Ticket";
            // 
            // TipoProblemaLabel
            // 
            TipoProblemaLabel.AutoSize = true;
            TipoProblemaLabel.Location = new Point(9, 110);
            TipoProblemaLabel.Name = "TipoProblemaLabel";
            TipoProblemaLabel.Size = new Size(129, 20);
            TipoProblemaLabel.TabIndex = 9;
            TipoProblemaLabel.Text = "Tipo de problema";
            // 
            // TipoProblemaComboBox
            // 
            TipoProblemaComboBox.FormattingEnabled = true;
            TipoProblemaComboBox.Items.AddRange(new object[] { "Hardware", "Software", "Red", "Otro" });
            TipoProblemaComboBox.Location = new Point(9, 143);
            TipoProblemaComboBox.Name = "TipoProblemaComboBox";
            TipoProblemaComboBox.Size = new Size(391, 28);
            TipoProblemaComboBox.TabIndex = 10;
            // 
            // DescripcionProblemaLabel
            // 
            DescripcionProblemaLabel.AutoSize = true;
            DescripcionProblemaLabel.Location = new Point(9, 188);
            DescripcionProblemaLabel.Name = "DescripcionProblemaLabel";
            DescripcionProblemaLabel.Size = new Size(177, 20);
            DescripcionProblemaLabel.TabIndex = 11;
            DescripcionProblemaLabel.Text = "Descripción de problema";
            // 
            // DescripcionProblemaTextBox
            // 
            DescripcionProblemaTextBox.Location = new Point(6, 225);
            DescripcionProblemaTextBox.Name = "DescripcionProblemaTextBox";
            DescripcionProblemaTextBox.ReadOnly = true;
            DescripcionProblemaTextBox.Size = new Size(394, 27);
            DescripcionProblemaTextBox.TabIndex = 12;
            // 
            // DetallesTecnicoGrupoBox
            // 
            DetallesTecnicoGrupoBox.Controls.Add(textBox1);
            DetallesTecnicoGrupoBox.Controls.Add(LegajoLabel);
            DetallesTecnicoGrupoBox.Controls.Add(ApellidoTecnicoTextBox);
            DetallesTecnicoGrupoBox.Controls.Add(NombreTecnicoTextBox);
            DetallesTecnicoGrupoBox.Controls.Add(ApellidoTecnicoLabel);
            DetallesTecnicoGrupoBox.Controls.Add(NombreTecnicoLabel);
            DetallesTecnicoGrupoBox.Location = new Point(16, 308);
            DetallesTecnicoGrupoBox.Name = "DetallesTecnicoGrupoBox";
            DetallesTecnicoGrupoBox.Size = new Size(414, 241);
            DetallesTecnicoGrupoBox.TabIndex = 1;
            DetallesTecnicoGrupoBox.TabStop = false;
            DetallesTecnicoGrupoBox.Text = "Detalles técnico";
            // 
            // NombreTecnicoLabel
            // 
            NombreTecnicoLabel.AutoSize = true;
            NombreTecnicoLabel.Location = new Point(8, 105);
            NombreTecnicoLabel.Name = "NombreTecnicoLabel";
            NombreTecnicoLabel.Size = new Size(64, 20);
            NombreTecnicoLabel.TabIndex = 1;
            NombreTecnicoLabel.Text = "Nombre";
            // 
            // ApellidoTecnicoLabel
            // 
            ApellidoTecnicoLabel.AutoSize = true;
            ApellidoTecnicoLabel.Location = new Point(6, 182);
            ApellidoTecnicoLabel.Name = "ApellidoTecnicoLabel";
            ApellidoTecnicoLabel.Size = new Size(66, 20);
            ApellidoTecnicoLabel.TabIndex = 2;
            ApellidoTecnicoLabel.Text = "Apellido";
            // 
            // NombreTecnicoTextBox
            // 
            NombreTecnicoTextBox.Location = new Point(6, 139);
            NombreTecnicoTextBox.Name = "NombreTecnicoTextBox";
            NombreTecnicoTextBox.ReadOnly = true;
            NombreTecnicoTextBox.Size = new Size(394, 27);
            NombreTecnicoTextBox.TabIndex = 13;
            // 
            // NumeroTicketTextBox
            // 
            NumeroTicketTextBox.Location = new Point(6, 63);
            NumeroTicketTextBox.Name = "NumeroTicketTextBox";
            NumeroTicketTextBox.Size = new Size(394, 27);
            NumeroTicketTextBox.TabIndex = 13;
            // 
            // ApellidoTecnicoTextBox
            // 
            ApellidoTecnicoTextBox.Location = new Point(4, 205);
            ApellidoTecnicoTextBox.Name = "ApellidoTecnicoTextBox";
            ApellidoTecnicoTextBox.ReadOnly = true;
            ApellidoTecnicoTextBox.Size = new Size(394, 27);
            ApellidoTecnicoTextBox.TabIndex = 14;
            // 
            // LegajoLabel
            // 
            LegajoLabel.AutoSize = true;
            LegajoLabel.Location = new Point(8, 38);
            LegajoLabel.Name = "LegajoLabel";
            LegajoLabel.Size = new Size(54, 20);
            LegajoLabel.TabIndex = 15;
            LegajoLabel.Text = "Legajo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 27);
            textBox1.TabIndex = 14;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(308, 579);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(122, 34);
            CancelarButton.TabIndex = 2;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            // 
            // AsignarButton
            // 
            AsignarButton.Location = new Point(180, 579);
            AsignarButton.Name = "AsignarButton";
            AsignarButton.Size = new Size(122, 34);
            AsignarButton.TabIndex = 3;
            AsignarButton.Text = "Asignar Técnico";
            AsignarButton.UseVisualStyleBackColor = true;
            AsignarButton.Click += AsignarButton_Click;
            // 
            // OperadorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 616);
            Controls.Add(AsignarButton);
            Controls.Add(CancelarButton);
            Controls.Add(DetallesTecnicoGrupoBox);
            Controls.Add(DetalleTicketGroupBox);
            Name = "OperadorForm";
            Text = "OperadorForm";
            DetalleTicketGroupBox.ResumeLayout(false);
            DetalleTicketGroupBox.PerformLayout();
            DetallesTecnicoGrupoBox.ResumeLayout(false);
            DetallesTecnicoGrupoBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox DetalleTicketGroupBox;
        private Label NumeroTicketLabel;
        private Label TipoProblemaLabel;
        private ComboBox TipoProblemaComboBox;
        private Label DescripcionProblemaLabel;
        private TextBox DescripcionProblemaTextBox;
        private GroupBox DetallesTecnicoGrupoBox;
        private Label NombreTecnicoLabel;
        private TextBox NumeroTicketTextBox;
        private TextBox ApellidoTecnicoTextBox;
        private TextBox NombreTecnicoTextBox;
        private Label ApellidoTecnicoLabel;
        private TextBox textBox1;
        private Label LegajoLabel;
        private Button CancelarButton;
        private Button AsignarButton;
    }
}