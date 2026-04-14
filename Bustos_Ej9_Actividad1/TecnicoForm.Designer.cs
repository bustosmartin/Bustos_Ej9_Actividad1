namespace Bustos_Ej9_Actividad1
{
    partial class TecnicoForm
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
            NumeroTicketTextBox = new TextBox();
            DescripcionProblemaTextBox = new TextBox();
            DescripcionProblemaLabel = new Label();
            TipoProblemaComboBox = new ComboBox();
            TipoProblemaLabel = new Label();
            NumeroTicketLabel = new Label();
            EstadoLabel = new Label();
            EstadoComboBox = new ComboBox();
            ObservacionesLabel = new Label();
            ObservacionesTextBox = new TextBox();
            ActualizarButton = new Button();
            CancelarButton = new Button();
            DetalleTicketGroupBox.SuspendLayout();
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
            DetalleTicketGroupBox.Location = new Point(12, 12);
            DetalleTicketGroupBox.Name = "DetalleTicketGroupBox";
            DetalleTicketGroupBox.Size = new Size(414, 279);
            DetalleTicketGroupBox.TabIndex = 1;
            DetalleTicketGroupBox.TabStop = false;
            DetalleTicketGroupBox.Text = "Detalle ticket";
            // 
            // NumeroTicketTextBox
            // 
            NumeroTicketTextBox.Location = new Point(6, 63);
            NumeroTicketTextBox.Name = "NumeroTicketTextBox";
            NumeroTicketTextBox.Size = new Size(394, 27);
            NumeroTicketTextBox.TabIndex = 13;
            // 
            // DescripcionProblemaTextBox
            // 
            DescripcionProblemaTextBox.Location = new Point(6, 225);
            DescripcionProblemaTextBox.Name = "DescripcionProblemaTextBox";
            DescripcionProblemaTextBox.ReadOnly = true;
            DescripcionProblemaTextBox.Size = new Size(394, 27);
            DescripcionProblemaTextBox.TabIndex = 12;
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
            // TipoProblemaComboBox
            // 
            TipoProblemaComboBox.FormattingEnabled = true;
            TipoProblemaComboBox.Items.AddRange(new object[] { "Hardware", "Software", "Red", "Otro" });
            TipoProblemaComboBox.Location = new Point(9, 143);
            TipoProblemaComboBox.Name = "TipoProblemaComboBox";
            TipoProblemaComboBox.Size = new Size(391, 28);
            TipoProblemaComboBox.TabIndex = 10;
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
            // NumeroTicketLabel
            // 
            NumeroTicketLabel.AutoSize = true;
            NumeroTicketLabel.Location = new Point(9, 31);
            NumeroTicketLabel.Name = "NumeroTicketLabel";
            NumeroTicketLabel.Size = new Size(127, 20);
            NumeroTicketLabel.TabIndex = 0;
            NumeroTicketLabel.Text = "Número de Ticket";
            // 
            // EstadoLabel
            // 
            EstadoLabel.AutoSize = true;
            EstadoLabel.Location = new Point(21, 306);
            EstadoLabel.Name = "EstadoLabel";
            EstadoLabel.Size = new Size(54, 20);
            EstadoLabel.TabIndex = 1;
            EstadoLabel.Text = "Estado";
            EstadoLabel.Click += EstadoLabel_Click;
            // 
            // EstadoComboBox
            // 
            EstadoComboBox.FormattingEnabled = true;
            EstadoComboBox.Items.AddRange(new object[] { "Sin asignar", "Asignado pero sin resolver", "En proceso", "Resuelto" });
            EstadoComboBox.Location = new Point(21, 339);
            EstadoComboBox.Name = "EstadoComboBox";
            EstadoComboBox.Size = new Size(391, 28);
            EstadoComboBox.TabIndex = 11;
            // 
            // ObservacionesLabel
            // 
            ObservacionesLabel.AutoSize = true;
            ObservacionesLabel.Location = new Point(18, 384);
            ObservacionesLabel.Name = "ObservacionesLabel";
            ObservacionesLabel.Size = new Size(105, 20);
            ObservacionesLabel.TabIndex = 12;
            ObservacionesLabel.Text = "Observaciones";
            // 
            // ObservacionesTextBox
            // 
            ObservacionesTextBox.Location = new Point(18, 418);
            ObservacionesTextBox.Name = "ObservacionesTextBox";
            ObservacionesTextBox.Size = new Size(389, 27);
            ObservacionesTextBox.TabIndex = 14;
            // 
            // ActualizarButton
            // 
            ActualizarButton.Location = new Point(169, 468);
            ActualizarButton.Name = "ActualizarButton";
            ActualizarButton.Size = new Size(133, 34);
            ActualizarButton.TabIndex = 16;
            ActualizarButton.Text = "Actualizar Estado";
            ActualizarButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(308, 468);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(133, 34);
            CancelarButton.TabIndex = 15;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            // 
            // TecnicoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 509);
            Controls.Add(EstadoComboBox);
            Controls.Add(ActualizarButton);
            Controls.Add(EstadoLabel);
            Controls.Add(CancelarButton);
            Controls.Add(ObservacionesTextBox);
            Controls.Add(ObservacionesLabel);
            Controls.Add(DetalleTicketGroupBox);
            Name = "TecnicoForm";
            Text = "TecnicoForm";
            DetalleTicketGroupBox.ResumeLayout(false);
            DetalleTicketGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox DetalleTicketGroupBox;
        private TextBox NumeroTicketTextBox;
        private TextBox DescripcionProblemaTextBox;
        private Label DescripcionProblemaLabel;
        private ComboBox TipoProblemaComboBox;
        private Label TipoProblemaLabel;
        private Label NumeroTicketLabel;
        private Label EstadoLabel;
        private ComboBox EstadoComboBox;
        private Label ObservacionesLabel;
        private TextBox ObservacionesTextBox;
        private Button ActualizarButton;
        private Button CancelarButton;
    }
}