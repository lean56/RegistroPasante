namespace ProgramacionNCapas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.Desde = new System.Windows.Forms.Label();
            this.ReportedataGridView = new System.Windows.Forms.DataGridView();
            this.Reportebutton = new System.Windows.Forms.Button();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.Imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReportedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Hasta";
            // 
            // Desde
            // 
            this.Desde.AutoSize = true;
            this.Desde.Location = new System.Drawing.Point(198, 17);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(38, 13);
            this.Desde.TabIndex = 16;
            this.Desde.Text = "Desde";
            // 
            // ReportedataGridView
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReportedataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ReportedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReportedataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.ReportedataGridView.Location = new System.Drawing.Point(37, 97);
            this.ReportedataGridView.Name = "ReportedataGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReportedataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ReportedataGridView.Size = new System.Drawing.Size(519, 150);
            this.ReportedataGridView.TabIndex = 14;
            // 
            // Reportebutton
            // 
            this.Reportebutton.Location = new System.Drawing.Point(481, 46);
            this.Reportebutton.Name = "Reportebutton";
            this.Reportebutton.Size = new System.Drawing.Size(75, 23);
            this.Reportebutton.TabIndex = 13;
            this.Reportebutton.Text = "Reporte";
            this.Reportebutton.UseVisualStyleBackColor = true;
            this.Reportebutton.Click += new System.EventHandler(this.Reportebutton_Click);
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(327, 46);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.HastadateTimePicker.TabIndex = 12;
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(176, 45);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.DesdedateTimePicker.TabIndex = 11;
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(37, 45);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(66, 20);
            this.IdtextBox.TabIndex = 10;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(56, 21);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 9;
            this.ID.Text = "ID";
            // 
            // Imprimir
            // 
            this.Imprimir.Image = global::ProgramacionNCapas.Properties.Resources.printer_78349;
            this.Imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Imprimir.Location = new System.Drawing.Point(481, 255);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(75, 53);
            this.Imprimir.TabIndex = 15;
            this.Imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Imprimir.UseVisualStyleBackColor = true;
            this.Imprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 320);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Desde);
            this.Controls.Add(this.Imprimir);
            this.Controls.Add(this.ReportedataGridView);
            this.Controls.Add(this.Reportebutton);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.ID);
            this.Name = "Reporte";
            this.Text = "Reporte";
            ((System.ComponentModel.ISupportInitialize)(this.ReportedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Desde;
        private System.Windows.Forms.Button Imprimir;
        private System.Windows.Forms.DataGridView ReportedataGridView;
        private System.Windows.Forms.Button Reportebutton;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Label ID;
    }
}