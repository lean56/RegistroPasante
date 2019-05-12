namespace ProgramacionNCapas
{
    partial class RegistroPasante
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
            this.nombretextBox = new System.Windows.Forms.TextBox();
            this.apellidotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.universidadtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.horaCursarnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nuevobutton = new System.Windows.Forms.Button();
            this.buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.guardarbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label65 = new System.Windows.Forms.Label();
            this.idnumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.horaCursarnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // nombretextBox
            // 
            this.nombretextBox.Location = new System.Drawing.Point(154, 81);
            this.nombretextBox.Name = "nombretextBox";
            this.nombretextBox.Size = new System.Drawing.Size(130, 20);
            this.nombretextBox.TabIndex = 1;
            this.nombretextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nombretextBox_Validating);
            // 
            // apellidotextBox
            // 
            this.apellidotextBox.Location = new System.Drawing.Point(154, 119);
            this.apellidotextBox.Name = "apellidotextBox";
            this.apellidotextBox.Size = new System.Drawing.Size(130, 20);
            this.apellidotextBox.TabIndex = 3;
            this.apellidotextBox.Validating += new System.ComponentModel.CancelEventHandler(this.apellidotextBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // universidadtextBox
            // 
            this.universidadtextBox.Location = new System.Drawing.Point(154, 158);
            this.universidadtextBox.Name = "universidadtextBox";
            this.universidadtextBox.Size = new System.Drawing.Size(130, 20);
            this.universidadtextBox.TabIndex = 5;
            this.universidadtextBox.Validating += new System.ComponentModel.CancelEventHandler(this.universidadtextBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Universidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha Ingreso";
            // 
            // dtpfecha
            // 
            this.dtpfecha.CustomFormat = "dd/MM/yyyy";
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(154, 199);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(130, 20);
            this.dtpfecha.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cantidad Hora Cursar";
            // 
            // horaCursarnumericUpDown
            // 
            this.horaCursarnumericUpDown.Location = new System.Drawing.Point(154, 236);
            this.horaCursarnumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.horaCursarnumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.horaCursarnumericUpDown.Name = "horaCursarnumericUpDown";
            this.horaCursarnumericUpDown.Size = new System.Drawing.Size(130, 20);
            this.horaCursarnumericUpDown.TabIndex = 14;
            this.horaCursarnumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // nuevobutton
            // 
            this.nuevobutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.errorProvider.SetIconAlignment(this.nuevobutton, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.nuevobutton.Image = global::ProgramacionNCapas.Properties.Resources.New_file_icon1;
            this.nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nuevobutton.Location = new System.Drawing.Point(15, 12);
            this.nuevobutton.Name = "nuevobutton";
            this.nuevobutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nuevobutton.Size = new System.Drawing.Size(71, 68);
            this.nuevobutton.TabIndex = 10;
            this.nuevobutton.Text = "Nuevo";
            this.nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.nuevobutton.UseVisualStyleBackColor = true;
            this.nuevobutton.Click += new System.EventHandler(this.nuevobutton_Click);
            // 
            // buscarbutton
            // 
            this.buscarbutton.Image = global::ProgramacionNCapas.Properties.Resources.icons8_búsqueda_50;
            this.buscarbutton.Location = new System.Drawing.Point(250, 12);
            this.buscarbutton.Name = "buscarbutton";
            this.buscarbutton.Size = new System.Drawing.Size(75, 54);
            this.buscarbutton.TabIndex = 9;
            this.buscarbutton.Text = "Buscar";
            this.buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buscarbutton.UseVisualStyleBackColor = true;
            this.buscarbutton.Click += new System.EventHandler(this.buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::ProgramacionNCapas.Properties.Resources.icons8_eliminar_vista_50;
            this.Eliminarbutton.Location = new System.Drawing.Point(204, 12);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(74, 68);
            this.Eliminarbutton.TabIndex = 8;
            this.Eliminarbutton.Text = "Borrar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Eliminarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // guardarbutton
            // 
            this.guardarbutton.Image = global::ProgramacionNCapas.Properties.Resources.icons8_guardar_50;
            this.guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardarbutton.Location = new System.Drawing.Point(113, 12);
            this.guardarbutton.Name = "guardarbutton";
            this.guardarbutton.Size = new System.Drawing.Size(73, 68);
            this.guardarbutton.TabIndex = 7;
            this.guardarbutton.Text = "Guardar";
            this.guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.guardarbutton.UseVisualStyleBackColor = true;
            this.guardarbutton.Click += new System.EventHandler(this.guardarbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nuevobutton);
            this.groupBox1.Controls.Add(this.guardarbutton);
            this.groupBox1.Controls.Add(this.Eliminarbutton);
            this.groupBox1.Location = new System.Drawing.Point(41, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 87);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(21, 37);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(18, 13);
            this.label65.TabIndex = 16;
            this.label65.Text = "ID";
            // 
            // idnumericUpDown
            // 
            this.idnumericUpDown.Location = new System.Drawing.Point(154, 37);
            this.idnumericUpDown.Name = "idnumericUpDown";
            this.idnumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.idnumericUpDown.TabIndex = 17;
            // 
            // RegistroPasante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 365);
            this.Controls.Add(this.idnumericUpDown);
            this.Controls.Add(this.label65);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.horaCursarnumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buscarbutton);
            this.Controls.Add(this.universidadtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.apellidotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombretextBox);
            this.Controls.Add(this.label1);
            this.Name = "RegistroPasante";
            this.Text = "RegistroPasante";
            ((System.ComponentModel.ISupportInitialize)(this.horaCursarnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.idnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button buscarbutton;
        private System.Windows.Forms.Button nuevobutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox nombretextBox;
        public System.Windows.Forms.TextBox apellidotextBox;
        public System.Windows.Forms.TextBox universidadtextBox;
        public System.Windows.Forms.DateTimePicker dtpfecha;
        public System.Windows.Forms.NumericUpDown horaCursarnumericUpDown;
        private System.Windows.Forms.NumericUpDown idnumericUpDown;
        private System.Windows.Forms.Label label65;
    }
}