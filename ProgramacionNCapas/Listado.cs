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

        public  int ID =0;
        
        public Listado()
        {
            InitializeComponent();
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            c.ListadoPasante(listadodataGridView);
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {      
            if (listadodataGridView.Rows.Count >0)
            {
                ID = int.Parse(listadodataGridView.CurrentRow.Cells[0].Value.ToString());
                this.Close();
            }
        }
    }
}
