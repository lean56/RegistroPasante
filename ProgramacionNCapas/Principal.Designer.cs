namespace ProgramacionNCapas
{
    partial class Principal
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
            this.MenuBar = new System.Windows.Forms.Panel();
            this.restaurar = new System.Windows.Forms.PictureBox();
            this.Max = new System.Windows.Forms.PictureBox();
            this.min = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SiderBar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.RegistroPasante = new System.Windows.Forms.Button();
            this.CPasante = new System.Windows.Forms.Button();
            this.Wropper = new System.Windows.Forms.Panel();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SiderBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuBar.Controls.Add(this.restaurar);
            this.MenuBar.Controls.Add(this.Max);
            this.MenuBar.Controls.Add(this.min);
            this.MenuBar.Controls.Add(this.Salir);
            this.MenuBar.Controls.Add(this.pictureBox1);
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1100, 49);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuBar_MouseDown);
            // 
            // restaurar
            // 
            this.restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurar.Image = global::ProgramacionNCapas.Properties.Resources.Restore_Window_2_48px;
            this.restaurar.Location = new System.Drawing.Point(1022, 9);
            this.restaurar.Name = "restaurar";
            this.restaurar.Size = new System.Drawing.Size(30, 30);
            this.restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restaurar.TabIndex = 4;
            this.restaurar.TabStop = false;
            this.restaurar.Click += new System.EventHandler(this.restaurar_Click);
            // 
            // Max
            // 
            this.Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Max.Image = global::ProgramacionNCapas.Properties.Resources.Maximize_Window_2_48px;
            this.Max.Location = new System.Drawing.Point(1022, 9);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(30, 30);
            this.Max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Max.TabIndex = 3;
            this.Max.TabStop = false;
            this.Max.Click += new System.EventHandler(this.Max_Click);
            // 
            // min
            // 
            this.min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min.Image = global::ProgramacionNCapas.Properties.Resources.Minimize_Window_2_48px;
            this.min.Location = new System.Drawing.Point(986, 9);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(30, 30);
            this.min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.min.TabIndex = 2;
            this.min.TabStop = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.Image = global::ProgramacionNCapas.Properties.Resources.Close_Window__2_48px;
            this.Salir.Location = new System.Drawing.Point(1058, 9);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Salir.TabIndex = 1;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProgramacionNCapas.Properties.Resources.Menu_48px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SiderBar
            // 
            this.SiderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.SiderBar.Controls.Add(this.button1);
            this.SiderBar.Controls.Add(this.RegistroPasante);
            this.SiderBar.Controls.Add(this.CPasante);
            this.SiderBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SiderBar.Location = new System.Drawing.Point(0, 49);
            this.SiderBar.Name = "SiderBar";
            this.SiderBar.Size = new System.Drawing.Size(149, 551);
            this.SiderBar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::ProgramacionNCapas.Properties.Resources.businessapplication_distributor_report_document_negocio_2319;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Estado Pasante";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistroPasante
            // 
            this.RegistroPasante.FlatAppearance.BorderSize = 0;
            this.RegistroPasante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.RegistroPasante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistroPasante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegistroPasante.Image = global::ProgramacionNCapas.Properties.Resources.Businessman_48px;
            this.RegistroPasante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegistroPasante.Location = new System.Drawing.Point(1, 82);
            this.RegistroPasante.Name = "RegistroPasante";
            this.RegistroPasante.Size = new System.Drawing.Size(146, 48);
            this.RegistroPasante.TabIndex = 3;
            this.RegistroPasante.Text = "Registro Pasante";
            this.RegistroPasante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegistroPasante.UseVisualStyleBackColor = true;
            this.RegistroPasante.Click += new System.EventHandler(this.RegistroPasante_Click);
            // 
            // CPasante
            // 
            this.CPasante.FlatAppearance.BorderSize = 0;
            this.CPasante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.CPasante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPasante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CPasante.Image = global::ProgramacionNCapas.Properties.Resources.taskboardhd_106120__1_;
            this.CPasante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CPasante.Location = new System.Drawing.Point(3, 149);
            this.CPasante.Name = "CPasante";
            this.CPasante.Size = new System.Drawing.Size(143, 40);
            this.CPasante.TabIndex = 4;
            this.CPasante.Text = "Control Pasante";
            this.CPasante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CPasante.UseVisualStyleBackColor = true;
            this.CPasante.Click += new System.EventHandler(this.CPasante_Click);
            // 
            // Wropper
            // 
            this.Wropper.BackColor = System.Drawing.Color.Gray;
            this.Wropper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wropper.Location = new System.Drawing.Point(149, 49);
            this.Wropper.Name = "Wropper";
            this.Wropper.Size = new System.Drawing.Size(951, 551);
            this.Wropper.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.Wropper);
            this.Controls.Add(this.SiderBar);
            this.Controls.Add(this.MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.MenuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SiderBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SiderBar;
        private System.Windows.Forms.Panel Wropper;
        private System.Windows.Forms.PictureBox Max;
        private System.Windows.Forms.PictureBox min;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.PictureBox restaurar;
        private System.Windows.Forms.Button CPasante;
        private System.Windows.Forms.Button RegistroPasante;
        private System.Windows.Forms.Button button1;
    }
}