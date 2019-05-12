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
    public partial class Listado : Form
    {
        Conexion c = new Conexion();
        RegistroPasante rg = new RegistroPasante();

        public Listado()
        {
            InitializeComponent();
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            c.cargar(listadodataGridView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //  listadodataGridView.CurrentRow.Selected = true;
               // if (listadodataGridView.Rows.Contains > 0)
               // {
                    rg.nombretextBox.Text = listadodataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                    rg.apellidotextBox.Text = listadodataGridView.CurrentRow.Cells["Apellido"].Value.ToString();
                    rg.universidadtextBox.Text = listadodataGridView.CurrentRow.Cells["Universidad"].Value.ToString();
                    // vern.Dato.Nombre = dgvDocente.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
               // }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
