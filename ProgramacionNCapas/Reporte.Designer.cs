﻿namespace ProgramacionNCapas
{
    partial class Reporte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Imprimir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buscarbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Desde = new System.Windows.Forms.Label();
            this.Reportebutton = new System.Windows.Forms.Button();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReportedataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // Imprimir
            // 
            this.Imprimir.Image = global::ProgramacionNCapas.Properties.Resources.mimetypes_PostScript_theprinter_349;
            this.Imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Imprimir.Location = new System.Drawing.Point(507, 280);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(62, 71);
            this.Imprimir.TabIndex = 15;
            this.Imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Imprimir.UseVisualStyleBackColor = true;
            this.Imprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buscarbutton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Desde);
            this.groupBox1.Controls.Add(this.Reportebutton);
            this.groupBox1.Controls.Add(this.HastadateTimePicker);
            this.groupBox1.Controls.Add(this.DesdedateTimePicker);
            this.groupBox1.Controls.Add(this.IdtextBox);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 79);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // buscarbutton
            // 
            this.buscarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buscarbutton.Image = global::ProgramacionNCapas.Properties.Resources.view_search_find_9565;
            this.buscarbutton.Location = new System.Drawing.Point(99, 14);
            this.buscarbutton.Name = "buscarbutton";
            this.buscarbutton.Size = new System.Drawing.Size(48, 55);
            this.buscarbutton.TabIndex = 26;
            this.buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buscarbutton.UseVisualStyleBackColor = true;
            this.buscarbutton.Click += new System.EventHandler(this.buscarbutton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Hasta";
            // 
            // Desde
            // 
            this.Desde.AutoSize = true;
            this.Desde.Location = new System.Drawing.Point(199, 10);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(38, 13);
            this.Desde.TabIndex = 24;
            this.Desde.Text = "Desde";
            // 
            // Reportebutton
            // 
            this.Reportebutton.Location = new System.Drawing.Point(457, 39);
            this.Reportebutton.Name = "Reportebutton";
            this.Reportebutton.Size = new System.Drawing.Size(75, 23);
            this.Reportebutton.TabIndex = 23;
            this.Reportebutton.Text = "Reporte";
            this.Reportebutton.UseVisualStyleBackColor = true;
            this.Reportebutton.Click += new System.EventHandler(this.Reportebutton_Click_1);
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(314, 39);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.HastadateTimePicker.TabIndex = 22;
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(177, 38);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.DesdedateTimePicker.TabIndex = 21;
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(13, 38);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(66, 20);
            this.IdtextBox.TabIndex = 20;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(32, 14);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 19;
            this.ID.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReportedataGridView);
            this.groupBox2.Location = new System.Drawing.Point(24, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 177);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // ReportedataGridView
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReportedataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ReportedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReportedataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.ReportedataGridView.Location = new System.Drawing.Point(12, 15);
            this.ReportedataGridView.Name = "ReportedataGridView";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReportedataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.ReportedataGridView.Size = new System.Drawing.Size(519, 150);
            this.ReportedataGridView.TabIndex = 15;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 363);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Imprimir);
            this.Name = "Reporte";
            this.Text = "Reporte";
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReportedataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Imprimir;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView ReportedataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button buscarbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Desde;
        private System.Windows.Forms.Button Reportebutton;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Label ID;
    }
}