﻿namespace ProgramacionNCapas
{
    partial class VentanaReporte
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
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport11 = new ProgramacionNCapas.CrystalReport1();
            this.CrystalReport1 = new ProgramacionNCapas.CrystalReport();
            this.Report11 = new ProgramacionNCapas.Report1();
            this.SuspendLayout();
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = 0;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.ReportSource = this.Report11;
            this.crystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer.TabIndex = 0;
            // 
            // VentanaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer);
            this.Name = "VentanaReporte";
            this.Text = "VentanaReporte";
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalReport CrystalReport1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private CrystalReport1 CrystalReport11;
        private Report1 Report11;
    }
}