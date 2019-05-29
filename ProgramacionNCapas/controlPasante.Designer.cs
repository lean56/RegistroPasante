namespace ProgramacionNCapas
{
    partial class controlPasante
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.horaSalida = new System.Windows.Forms.DateTimePicker();
            this.idEstudiante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buscarbutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.agregarButton = new System.Windows.Forms.Button();
            this.horaEntrada = new System.Windows.Forms.DateTimePicker();
            this.f44 = new System.Windows.Forms.GroupBox();
            this.ControldataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.f44.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControldataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora Entrada";
            // 
            // fecha
            // 
            this.fecha.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.fecha.CustomFormat = "";
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha.Location = new System.Drawing.Point(18, 63);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(84, 20);
            this.fecha.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora Salida";
            // 
            // horaSalida
            // 
            this.horaSalida.CustomFormat = "";
            this.horaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaSalida.Location = new System.Drawing.Point(235, 63);
            this.horaSalida.Name = "horaSalida";
            this.horaSalida.ShowUpDown = true;
            this.horaSalida.Size = new System.Drawing.Size(92, 20);
            this.horaSalida.TabIndex = 5;
            // 
            // idEstudiante
            // 
            this.idEstudiante.Location = new System.Drawing.Point(14, 45);
            this.idEstudiante.Name = "idEstudiante";
            this.idEstudiante.Size = new System.Drawing.Size(83, 20);
            this.idEstudiante.TabIndex = 11;
            this.idEstudiante.Validating += new System.ComponentModel.CancelEventHandler(this.idEstudiante_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Estudiante";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idEstudiante);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buscarbutton);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // buscarbutton
            // 
            this.buscarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buscarbutton.Image = global::ProgramacionNCapas.Properties.Resources.icons8_búsqueda_50;
            this.buscarbutton.Location = new System.Drawing.Point(110, 29);
            this.buscarbutton.Name = "buscarbutton";
            this.buscarbutton.Size = new System.Drawing.Size(75, 54);
            this.buscarbutton.TabIndex = 10;
            this.buscarbutton.Text = "Buscar";
            this.buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buscarbutton.UseVisualStyleBackColor = true;
            this.buscarbutton.Click += new System.EventHandler(this.buscarbutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.agregarButton);
            this.groupBox2.Controls.Add(this.horaEntrada);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.fecha);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.horaSalida);
            this.groupBox2.Location = new System.Drawing.Point(217, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // agregarButton
            // 
            this.agregarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(143)))), ((int)(((byte)(214)))));
            this.agregarButton.ForeColor = System.Drawing.Color.White;
            this.agregarButton.Location = new System.Drawing.Point(343, 57);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(80, 30);
            this.agregarButton.TabIndex = 16;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = false;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // horaEntrada
            // 
            this.horaEntrada.CustomFormat = "";
            this.horaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaEntrada.Location = new System.Drawing.Point(122, 63);
            this.horaEntrada.Name = "horaEntrada";
            this.horaEntrada.ShowUpDown = true;
            this.horaEntrada.Size = new System.Drawing.Size(92, 20);
            this.horaEntrada.TabIndex = 6;
            // 
            // f44
            // 
            this.f44.Controls.Add(this.ControldataGridView);
            this.f44.Location = new System.Drawing.Point(26, 137);
            this.f44.Name = "f44";
            this.f44.Size = new System.Drawing.Size(614, 218);
            this.f44.TabIndex = 15;
            this.f44.TabStop = false;
            // 
            // ControldataGridView
            // 
            this.ControldataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ControldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ControldataGridView.Location = new System.Drawing.Point(12, 16);
            this.ControldataGridView.Name = "ControldataGridView";
            this.ControldataGridView.Size = new System.Drawing.Size(591, 196);
            this.ControldataGridView.TabIndex = 9;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // controlPasante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(143)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(693, 384);
            this.Controls.Add(this.f44);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "controlPasante";
            this.Text = "Control Pasante";
            this.Load += new System.EventHandler(this.controlPasante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.f44.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ControldataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox f44;
        private System.Windows.Forms.DataGridView ControldataGridView;
        internal System.Windows.Forms.Button agregarButton;
        public System.Windows.Forms.DateTimePicker fecha;
        public System.Windows.Forms.DateTimePicker horaSalida;
        public System.Windows.Forms.Button buscarbutton;
        public System.Windows.Forms.TextBox idEstudiante;
        public System.Windows.Forms.DateTimePicker horaEntrada;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}