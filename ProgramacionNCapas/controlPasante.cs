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
    public partial class controlPasante : Form
    {
        Conexion c = new Conexion();

        public controlPasante()
        {
            InitializeComponent();
        }

private void controlPasante_Load(object sender, EventArgs e)
        {
            c.cargar2(ControldataGridView);
            ControldataGridView.Columns[2].DefaultCellStyle.Format = "hh:mm tt";
            ControldataGridView.Columns[3].DefaultCellStyle.Format="hh:mm tt";
        }

        private void buscarbutton_Click(object sender, EventArgs e)
        {
            Listado l = new Listado();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(c.insertarControl(Convert.ToInt32(idEstudiante.Text), dtpfecha.Text, horaEntrada.Text, horaSalida.Text));
             MessageBox.Show(c.insertarControl(Convert.ToInt32(idEstudiante.Text),fecha.Text,horaEntrada.Text,horaSalida.Text));
             c.cargar2(ControldataGridView);
        }
    }
}
