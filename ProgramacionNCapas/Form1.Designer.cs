﻿namespace ProgramacionNCapas
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroPasanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlPasanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteListadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoPasanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.registroToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(297, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroPasanteToolStripMenuItem,
            this.controlPasanteToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // registroPasanteToolStripMenuItem
            // 
            this.registroPasanteToolStripMenuItem.Name = "registroPasanteToolStripMenuItem";
            this.registroPasanteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.registroPasanteToolStripMenuItem.Text = "Registro Pasante";
            this.registroPasanteToolStripMenuItem.Click += new System.EventHandler(this.registroPasanteToolStripMenuItem_Click);
            // 
            // controlPasanteToolStripMenuItem
            // 
            this.controlPasanteToolStripMenuItem.Name = "controlPasanteToolStripMenuItem";
            this.controlPasanteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.controlPasanteToolStripMenuItem.Text = "Control Pasante";
            this.controlPasanteToolStripMenuItem.Click += new System.EventHandler(this.controlPasanteToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteListadoToolStripMenuItem,
            this.estadoPasanteToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // reporteListadoToolStripMenuItem
            // 
            this.reporteListadoToolStripMenuItem.Name = "reporteListadoToolStripMenuItem";
            this.reporteListadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reporteListadoToolStripMenuItem.Text = "Horas Cursada";
            this.reporteListadoToolStripMenuItem.Click += new System.EventHandler(this.reporteListadoToolStripMenuItem_Click);
            // 
            // estadoPasanteToolStripMenuItem
            // 
            this.estadoPasanteToolStripMenuItem.Name = "estadoPasanteToolStripMenuItem";
            this.estadoPasanteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estadoPasanteToolStripMenuItem.Text = "Estado Pasante";
            this.estadoPasanteToolStripMenuItem.Click += new System.EventHandler(this.estadoPasanteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 253);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Control Pasantia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroPasanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteListadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlPasanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoPasanteToolStripMenuItem;
    }
}

