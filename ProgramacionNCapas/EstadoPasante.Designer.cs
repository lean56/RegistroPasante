namespace ProgramacionNCapas
{
    partial class EstadoPasante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EstadoDataGridView = new System.Windows.Forms.DataGridView();
            this.Reportebutton = new System.Windows.Forms.Button();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.Imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EstadoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EstadoDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EstadoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EstadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EstadoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.EstadoDataGridView.Location = new System.Drawing.Point(47, 86);
            this.EstadoDataGridView.Name = "EstadoDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EstadoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.EstadoDataGridView.Size = new System.Drawing.Size(519, 150);
            this.EstadoDataGridView.TabIndex = 19;
            // 
            // Reportebutton
            // 
            this.Reportebutton.Location = new System.Drawing.Point(491, 45);
            this.Reportebutton.Name = "Reportebutton";
            this.Reportebutton.Size = new System.Drawing.Size(75, 23);
            this.Reportebutton.TabIndex = 18;
            this.Reportebutton.Text = "Reporte";
            this.Reportebutton.UseVisualStyleBackColor = true;
            this.Reportebutton.Click += new System.EventHandler(this.Reportebutton_Click);
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(47, 48);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(66, 20);
            this.IdtextBox.TabIndex = 17;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(66, 24);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 16;
            this.ID.Text = "ID";
            // 
            // Imprimir
            // 
            this.Imprimir.Image = global::ProgramacionNCapas.Properties.Resources.printer_78349;
            this.Imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Imprimir.Location = new System.Drawing.Point(500, 242);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(75, 53);
            this.Imprimir.TabIndex = 20;
            this.Imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Imprimir.UseVisualStyleBackColor = true;
            this.Imprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // EstadoPasante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 308);
            this.Controls.Add(this.Imprimir);
            this.Controls.Add(this.EstadoDataGridView);
            this.Controls.Add(this.Reportebutton);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.ID);
            this.Name = "EstadoPasante";
            this.Text = "EstadoPasante";
            ((System.ComponentModel.ISupportInitialize)(this.EstadoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EstadoDataGridView;
        private System.Windows.Forms.Button Reportebutton;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button Imprimir;
    }
}