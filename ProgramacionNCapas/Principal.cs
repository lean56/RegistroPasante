using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionNCapas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void Max_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Max.Visible = false;
            restaurar.Visible = true;
        }

        private void min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            Max.Visible = true;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (SiderBar.Width == 150)
            {
                SiderBar.Width = 50;
            }
            else
                SiderBar.Width = 150;
        }
        private void AbrirFormInPanel(object FormHijo)
        {
            if (this.Wropper.Controls.Count > 0)
            {
                this.Wropper.Controls.RemoveAt(0);
            }
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Wropper.Controls.Add(fh);
            this.Wropper.Tag = fh;
            fh.Show();
        }
        private void RegistroPasante_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new RegistroPasante());
        }

        private void CPasante_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new controlPasante());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Reporte());
        }

        private void MenuBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
