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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.horaSalida = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.buscarbutton = new System.Windows.Forms.Button();
            this.idEstudiante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.horaEntrada = new System.Windows.Forms.DateTimePicker();
            this.f44 = new System.Windows.Forms.GroupBox();
            this.ControldataGridView = new System.Windows.Forms.DataGridView();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.f44.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControldataGridView)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(149, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora Entrada";
            // 
            // fecha
            // 
            this.fecha.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.fecha.CustomFormat = "";
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(18, 63);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(84, 20);
            this.fecha.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora Salida";
            // 
            // horaSalida
            // 
            this.horaSalida.CustomFormat = "hh:mm:ss ";
            this.horaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horaSalida.Location = new System.Drawing.Point(280, 63);
            this.horaSalida.Name = "horaSalida";
            this.horaSalida.ShowUpDown = true;
            this.horaSalida.Size = new System.Drawing.Size(92, 20);
            this.horaSalida.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buscarbutton
            // 
            this.buscarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buscarbutton.Image = global::ProgramacionNCapas.Properties.Resources.icons8_búsqueda_50;
            this.buscarbutton.Location = new System.Drawing.Point(113, 29);
            this.buscarbutton.Name = "buscarbutton";
            this.buscarbutton.Size = new System.Drawing.Size(75, 54);
            this.buscarbutton.TabIndex = 10;
            this.buscarbutton.Text = "Buscar";
            this.buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buscarbutton.UseVisualStyleBackColor = true;
            this.buscarbutton.Click += new System.EventHandler(this.buscarbutton_Click);
            // 
            // idEstudiante
            // 
            this.idEstudiante.Location = new System.Drawing.Point(22, 48);
            this.idEstudiante.Name = "idEstudiante";
            this.idEstudiante.Size = new System.Drawing.Size(75, 20);
            this.idEstudiante.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Estudiante";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buscarbutton);
            this.groupBox1.Controls.Add(this.idEstudiante);
            this.groupBox1.Location = new System.Drawing.Point(37, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.horaEntrada);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.fecha);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.horaSalida);
            this.groupBox2.Location = new System.Drawing.Point(264, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // horaEntrada
            // 
            this.horaEntrada.CustomFormat = "hh:mm:ss ";
            this.horaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horaEntrada.Location = new System.Drawing.Point(152, 63);
            this.horaEntrada.Name = "horaEntrada";
            this.horaEntrada.ShowUpDown = true;
            this.horaEntrada.Size = new System.Drawing.Size(92, 20);
            this.horaEntrada.TabIndex = 6;
            // 
            // f44
            // 
            this.f44.Controls.Add(this.ControldataGridView);
            this.f44.Location = new System.Drawing.Point(37, 167);
            this.f44.Name = "f44";
            this.f44.Size = new System.Drawing.Size(669, 193);
            this.f44.TabIndex = 15;
            this.f44.TabStop = false;
            // 
            // ControldataGridView
            // 
            this.ControldataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ControldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ControldataGridView.Location = new System.Drawing.Point(6, 16);
            this.ControldataGridView.Name = "ControldataGridView";
            this.ControldataGridView.Size = new System.Drawing.Size(656, 171);
            this.ControldataGridView.TabIndex = 9;
            // 
            // BtnCargar
            // 
            this.BtnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(143)))), ((int)(((byte)(214)))));
            this.BtnCargar.ForeColor = System.Drawing.Color.White;
            this.BtnCargar.Location = new System.Drawing.Point(115, 134);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(75, 30);
            this.BtnCargar.TabIndex = 16;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = false;
            // 
            // controlPasante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(143)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(731, 384);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.f44);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "controlPasante";
            this.Text = "Control Pasante";
            this.Load += new System.EventHandler(this.controlPasante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.f44.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ControldataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker horaSalida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buscarbutton;
        private System.Windows.Forms.TextBox idEstudiante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker horaEntrada;
        private System.Windows.Forms.GroupBox f44;
        private System.Windows.Forms.DataGridView ControldataGridView;
        internal System.Windows.Forms.Button BtnCargar;
    }
}