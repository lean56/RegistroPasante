﻿namespace ProgramacionNCapas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guardarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CerrarButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.horaCursarnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // nombretextBox
            // 
            this.nombretextBox.Location = new System.Drawing.Point(449, 93);
            this.nombretextBox.Name = "nombretextBox";
            this.nombretextBox.Size = new System.Drawing.Size(130, 20);
            this.nombretextBox.TabIndex = 1;
            this.nombretextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nombretextBox_Validating);
            // 
            // apellidotextBox
            // 
            this.apellidotextBox.Location = new System.Drawing.Point(449, 131);
            this.apellidotextBox.Name = "apellidotextBox";
            this.apellidotextBox.Size = new System.Drawing.Size(130, 20);
            this.apellidotextBox.TabIndex = 3;
            this.apellidotextBox.Validating += new System.ComponentModel.CancelEventHandler(this.apellidotextBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // universidadtextBox
            // 
            this.universidadtextBox.Location = new System.Drawing.Point(449, 170);
            this.universidadtextBox.Name = "universidadtextBox";
            this.universidadtextBox.Size = new System.Drawing.Size(130, 20);
            this.universidadtextBox.TabIndex = 5;
            this.universidadtextBox.Validating += new System.ComponentModel.CancelEventHandler(this.universidadtextBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Universidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(298, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha Ingreso";
            // 
            // dtpfecha
            // 
            this.dtpfecha.CustomFormat = "";
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(449, 211);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(130, 20);
            this.dtpfecha.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(298, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cantidad Hora Cursar";
            // 
            // horaCursarnumericUpDown
            // 
            this.horaCursarnumericUpDown.Location = new System.Drawing.Point(449, 248);
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
            this.nuevobutton.BackColor = System.Drawing.SystemColors.Control;
            this.errorProvider.SetIconAlignment(this.nuevobutton, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.nuevobutton.Image = global::ProgramacionNCapas.Properties.Resources.New_file_icon1;
            this.nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nuevobutton.Location = new System.Drawing.Point(15, 13);
            this.nuevobutton.Name = "nuevobutton";
            this.nuevobutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nuevobutton.Size = new System.Drawing.Size(71, 68);
            this.nuevobutton.TabIndex = 10;
            this.nuevobutton.Text = "Nuevo";
            this.nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.nuevobutton.UseVisualStyleBackColor = false;
            this.nuevobutton.Click += new System.EventHandler(this.nuevobutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nuevobutton);
            this.groupBox1.Controls.Add(this.guardarbutton);
            this.groupBox1.Controls.Add(this.Cancelarbutton);
            this.groupBox1.Location = new System.Drawing.Point(301, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 87);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // guardarbutton
            // 
            this.guardarbutton.BackColor = System.Drawing.SystemColors.Control;
            this.guardarbutton.Image = global::ProgramacionNCapas.Properties.Resources.icons8_guardar_50;
            this.guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardarbutton.Location = new System.Drawing.Point(113, 13);
            this.guardarbutton.Name = "guardarbutton";
            this.guardarbutton.Size = new System.Drawing.Size(73, 68);
            this.guardarbutton.TabIndex = 7;
            this.guardarbutton.Text = "Guardar";
            this.guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.guardarbutton.UseVisualStyleBackColor = false;
            this.guardarbutton.Click += new System.EventHandler(this.guardarbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.BackColor = System.Drawing.SystemColors.Control;
            this.Cancelarbutton.Image = global::ProgramacionNCapas.Properties.Resources.Cancel_icon_icons_com_73703__1_;
            this.Cancelarbutton.Location = new System.Drawing.Point(204, 13);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(74, 68);
            this.Cancelarbutton.TabIndex = 8;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Cancelarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cancelarbutton.UseVisualStyleBackColor = false;
            this.Cancelarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(339, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 41);
            this.label6.TabIndex = 16;
            this.label6.Text = "Registro Pasante";
            // 
            // CerrarButton
            // 
            this.CerrarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarButton.AutoSize = true;
            this.CerrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarButton.Location = new System.Drawing.Point(922, 9);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(17, 17);
            this.CerrarButton.TabIndex = 30;
            this.CerrarButton.Text = "X";
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // RegistroPasante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(951, 551);
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.horaCursarnumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.universidadtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.apellidotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombretextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroPasante";
            this.Text = "RegistroPasante";
            ((System.ComponentModel.ISupportInitialize)(this.horaCursarnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button guardarbutton;
        private System.Windows.Forms.Button Cancelarbutton;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CerrarButton;
    }
}