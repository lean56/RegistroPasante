using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProgramacionNCapas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registroPasanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPasante rp = new RegistroPasante();
            rp.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           Conexion conexion = new Conexion();
        }

        private void controlPasanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlPasante cp = new controlPasante();
            cp.Show();
        }

        private void reporteListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login lo = new login();
            lo.Show();
        }
    }
}
