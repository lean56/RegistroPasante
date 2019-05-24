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
    public partial class RegistroPasante : Form
    {
        public RegistroPasante()
        {
            InitializeComponent();
        }

        internal static void show()
        {
            throw new NotImplementedException();
        }

        private void guardarbutton_Click(object sender, EventArgs e)
        {
            if (nombretextBox.Text == "")
            {
                errorProvider.SetError(nombretextBox, "Campo Vacio");
            }

            if (apellidotextBox.Text == "")
            {
                errorProvider.SetError(apellidotextBox, "Campo vacio");
            }

            if (universidadtextBox.Text == "")
            {
                errorProvider.SetError(universidadtextBox, "Campo Vacio");
            }
            else
            {
                Conexion c = new Conexion();
                MessageBox.Show(c.insertar(nombretextBox.Text, apellidotextBox.Text, universidadtextBox.Text, dtpfecha.Value, Convert.ToInt32(horaCursarnumericUpDown.Value)));
                nuevo();
                Close();
            }
        }

        private void nuevo()
        {
            nombretextBox.Text = "";
            apellidotextBox.Text = "";
            universidadtextBox.Text = "";
            horaCursarnumericUpDown.Value = 1;
            dtpfecha.Value = DateTime.Now;
            errorProvider.SetError(nombretextBox, "");
            errorProvider.SetError(apellidotextBox, "");
            errorProvider.SetError(universidadtextBox, "");
        }

        private void nuevobutton_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void nombretextBox_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(nombretextBox, "");
        }

        private void apellidotextBox_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(apellidotextBox, "");
        }

        private void universidadtextBox_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(universidadtextBox, "");
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
