using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProgramacionNCapas
{
    public partial class EstadoPasante : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;

        public EstadoPasante()
        {
            InitializeComponent();
            try
            {
                con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=ControlPasantiaDb; Integrated Security=True");
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion" + ex.ToString());
            }
        }

        public string Estado(DataGridView dgv)
        {
            VentanaEstadoPasante report = new VentanaEstadoPasante();
            EstadoPasanteReport cr = new EstadoPasanteReport();

            string sql = "";
            try
            {
                sql = "select C.idPasante,P.nombre,P.apellido,c.fecha,c.horas from dbo.Estudiante P, dbo.Control C where c.idPasante =P.id and c.idPasante =" + IdtextBox.Text;
                da = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                da.Fill(dt);

                cr.SetDataSource(dt);

                report.crystalReportViewer1.ReportSource = cr;
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el datagridview" + ex.ToString());
            }
            return sql;
        }

        private void Reportebutton_Click(object sender, EventArgs e)
        {
            Estado(EstadoDataGridView);
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            VentanaEstadoPasante report = new VentanaEstadoPasante();
            EstadoPasanteReport cr = new EstadoPasanteReport();

            report.crystalReportViewer1.ReportSource = cr;
            report.Show();
        }
    }
}
