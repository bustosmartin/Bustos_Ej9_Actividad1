namespace Bustos_Ej9_Actividad1
{
    partial class JefeSoporteForm
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
            ObservacionesTextBox = new TextBox();
            DescripcionProblemaTextBox = new TextBox();
            ObservacionesLabel = new Label();
            DescripcionProblemaLabel = new Label();
            label1 = new Label();
            EstadoLabel = new Label();
            TipoProblemaComboBox = new ComboBox();
            TipoProblemaLabel = new Label();
            NumeroTicketLabel = new Label();
            SatisfaccionGroupBox = new GroupBox();
            SatisfaccionComboBox = new ComboBox();
            label2 = new Label();
            ComentariosLabel = new Label();
            ComentariosTextBox = new TextBox();
            TiempoRespuestaGroupBox = new GroupBox();
            FechaResolucionDateTimePicker = new DateTimePicker();
            FechaResolucionLabel = new Label();
            FechaCreacionDateTimePicker = new DateTimePicker();
            FechaCreacionLabel = new Label();
            AceptarButton = new Button();
            DetalleTicketGroupBox.SuspendLayout();
            SatisfaccionGroupBox.SuspendLayout();
            TiempoRespuestaGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // DetalleTicketGroupBox
            // 
            DetalleTicketGroupBox.Controls.Add(NumeroTicketTextBox);
            DetalleTicketGroupBox.Controls.Add(ObservacionesTextBox);
            DetalleTicketGroupBox.Controls.Add(DescripcionProblemaTextBox);
            DetalleTicketGroupBox.Controls.Add(ObservacionesLabel);
            DetalleTicketGroupBox.Controls.Add(DescripcionProblemaLabel);
            DetalleTicketGroupBox.Controls.Add(label1);
            DetalleTicketGroupBox.Controls.Add(EstadoLabel);
            DetalleTicketGroupBox.Controls.Add(TipoProblemaComboBox);
            DetalleTicketGroupBox.Controls.Add(TipoProblemaLabel);
            DetalleTicketGroupBox.Controls.Add(NumeroTicketLabel);
            DetalleTicketGroupBox.Location = new Point(12, 12);
            DetalleTicketGroupBox.Name = "DetalleTicketGroupBox";
            DetalleTicketGroupBox.Size = new Size(414, 401);
            DetalleTicketGroupBox.TabIndex = 2;
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
            // ObservacionesTextBox
            // 
            ObservacionesTextBox.Location = new Point(9, 362);
            ObservacionesTextBox.Name = "ObservacionesTextBox";
            ObservacionesTextBox.ReadOnly = true;
            ObservacionesTextBox.Size = new Size(389, 27);
            ObservacionesTextBox.TabIndex = 16;
            // 
            // DescripcionProblemaTextBox
            // 
            DescripcionProblemaTextBox.Location = new Point(6, 225);
            DescripcionProblemaTextBox.Name = "DescripcionProblemaTextBox";
            DescripcionProblemaTextBox.ReadOnly = true;
            DescripcionProblemaTextBox.Size = new Size(394, 27);
            DescripcionProblemaTextBox.TabIndex = 12;
            // 
            // ObservacionesLabel
            // 
            ObservacionesLabel.AutoSize = true;
            ObservacionesLabel.Location = new Point(9, 339);
            ObservacionesLabel.Name = "ObservacionesLabel";
            ObservacionesLabel.Size = new Size(182, 20);
            ObservacionesLabel.TabIndex = 15;
            ObservacionesLabel.Text = "Observaciones del técnico";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 291);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 13;
            label1.Text = "Resuelto";
            // 
            // EstadoLabel
            // 
            EstadoLabel.AutoSize = true;
            EstadoLabel.Location = new Point(9, 271);
            EstadoLabel.Name = "EstadoLabel";
            EstadoLabel.Size = new Size(54, 20);
            EstadoLabel.TabIndex = 12;
            EstadoLabel.Text = "Estado";
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
            // SatisfaccionGroupBox
            // 
            SatisfaccionGroupBox.Controls.Add(SatisfaccionComboBox);
            SatisfaccionGroupBox.Controls.Add(label2);
            SatisfaccionGroupBox.Controls.Add(ComentariosLabel);
            SatisfaccionGroupBox.Controls.Add(ComentariosTextBox);
            SatisfaccionGroupBox.Location = new Point(12, 433);
            SatisfaccionGroupBox.Name = "SatisfaccionGroupBox";
            SatisfaccionGroupBox.Size = new Size(411, 133);
            SatisfaccionGroupBox.TabIndex = 21;
            SatisfaccionGroupBox.TabStop = false;
            SatisfaccionGroupBox.Text = "Satisfaccion Cliente";
            // 
            // SatisfaccionComboBox
            // 
            SatisfaccionComboBox.FormattingEnabled = true;
            SatisfaccionComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            SatisfaccionComboBox.Location = new Point(171, 38);
            SatisfaccionComboBox.Name = "SatisfaccionComboBox";
            SatisfaccionComboBox.Size = new Size(69, 28);
            SatisfaccionComboBox.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 38);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 19;
            label2.Text = "Satisfacción";
            // 
            // ComentariosLabel
            // 
            ComentariosLabel.AutoSize = true;
            ComentariosLabel.Location = new Point(5, 74);
            ComentariosLabel.Name = "ComentariosLabel";
            ComentariosLabel.Size = new Size(93, 20);
            ComentariosLabel.TabIndex = 17;
            ComentariosLabel.Text = "Comentarios";
            // 
            // ComentariosTextBox
            // 
            ComentariosTextBox.Location = new Point(5, 97);
            ComentariosTextBox.Name = "ComentariosTextBox";
            ComentariosTextBox.ReadOnly = true;
            ComentariosTextBox.Size = new Size(394, 27);
            ComentariosTextBox.TabIndex = 18;
            // 
            // TiempoRespuestaGroupBox
            // 
            TiempoRespuestaGroupBox.Controls.Add(FechaResolucionDateTimePicker);
            TiempoRespuestaGroupBox.Controls.Add(FechaResolucionLabel);
            TiempoRespuestaGroupBox.Controls.Add(FechaCreacionDateTimePicker);
            TiempoRespuestaGroupBox.Controls.Add(FechaCreacionLabel);
            TiempoRespuestaGroupBox.Location = new Point(12, 587);
            TiempoRespuestaGroupBox.Name = "TiempoRespuestaGroupBox";
            TiempoRespuestaGroupBox.Size = new Size(411, 180);
            TiempoRespuestaGroupBox.TabIndex = 22;
            TiempoRespuestaGroupBox.TabStop = false;
            TiempoRespuestaGroupBox.Text = "Tiempo de respuesta";
            // 
            // FechaResolucionDateTimePicker
            // 
            FechaResolucionDateTimePicker.Location = new Point(9, 136);
            FechaResolucionDateTimePicker.Name = "FechaResolucionDateTimePicker";
            FechaResolucionDateTimePicker.Size = new Size(275, 27);
            FechaResolucionDateTimePicker.TabIndex = 20;
            // 
            // FechaResolucionLabel
            // 
            FechaResolucionLabel.AutoSize = true;
            FechaResolucionLabel.Location = new Point(9, 104);
            FechaResolucionLabel.Name = "FechaResolucionLabel";
            FechaResolucionLabel.Size = new Size(201, 20);
            FechaResolucionLabel.TabIndex = 19;
            FechaResolucionLabel.Text = "Fecha de resolución de ticket";
            // 
            // FechaCreacionDateTimePicker
            // 
            FechaCreacionDateTimePicker.Location = new Point(9, 60);
            FechaCreacionDateTimePicker.Name = "FechaCreacionDateTimePicker";
            FechaCreacionDateTimePicker.Size = new Size(275, 27);
            FechaCreacionDateTimePicker.TabIndex = 18;
            // 
            // FechaCreacionLabel
            // 
            FechaCreacionLabel.AutoSize = true;
            FechaCreacionLabel.Location = new Point(9, 37);
            FechaCreacionLabel.Name = "FechaCreacionLabel";
            FechaCreacionLabel.Size = new Size(189, 20);
            FechaCreacionLabel.TabIndex = 17;
            FechaCreacionLabel.Text = "Fecha de creación de ticket";
            // 
            // AceptarButton
            // 
            AceptarButton.Location = new Point(114, 784);
            AceptarButton.Name = "AceptarButton";
            AceptarButton.Size = new Size(182, 36);
            AceptarButton.TabIndex = 23;
            AceptarButton.Text = "Aceptar";
            AceptarButton.UseVisualStyleBackColor = true;
            // 
            // JefeSoporteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 823);
            Controls.Add(AceptarButton);
            Controls.Add(TiempoRespuestaGroupBox);
            Controls.Add(SatisfaccionGroupBox);
            Controls.Add(DetalleTicketGroupBox);
            Name = "JefeSoporteForm";
            Text = "Evaluación tickets (Jefe de soporte)";
            DetalleTicketGroupBox.ResumeLayout(false);
            DetalleTicketGroupBox.PerformLayout();
            SatisfaccionGroupBox.ResumeLayout(false);
            SatisfaccionGroupBox.PerformLayout();
            TiempoRespuestaGroupBox.ResumeLayout(false);
            TiempoRespuestaGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox DetalleTicketGroupBox;
        private TextBox NumeroTicketTextBox;
        private TextBox ObservacionesTextBox;
        private TextBox DescripcionProblemaTextBox;
        private Label ObservacionesLabel;
        private Label DescripcionProblemaLabel;
        private Label label1;
        private Label EstadoLabel;
        private ComboBox TipoProblemaComboBox;
        private Label TipoProblemaLabel;
        private Label NumeroTicketLabel;
        private GroupBox SatisfaccionGroupBox;
        private ComboBox SatisfaccionComboBox;
        private Label label2;
        private Label ComentariosLabel;
        private TextBox ComentariosTextBox;
        private GroupBox TiempoRespuestaGroupBox;
        private DateTimePicker FechaResolucionDateTimePicker;
        private Label FechaResolucionLabel;
        private DateTimePicker FechaCreacionDateTimePicker;
        private Label FechaCreacionLabel;
        private Button AceptarButton;
    }
}