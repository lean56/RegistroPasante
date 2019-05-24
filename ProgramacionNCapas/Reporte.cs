﻿using System;
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
    public partial class Reporte : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;

       // VentanaReporte report = new VentanaReporte();
       // CrystalReport cr = new CrystalReport();

        public Reporte()
        {
            try
            {
                con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=ControlPasantiaDb; Integrated Security=True");
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion" + ex.ToString());
            }
            InitializeComponent();
        }

        public string reporte(DataGridView dgv)
        {
            VentanaReporte report = new VentanaReporte();
            CrystalReport1 cr = new CrystalReport1();

            string sql = "";
            try
            {
                sql = "select C.idPasante,P.nombre,P.apellido,c.fecha,c.horas from dbo.Estudiante P, dbo.Control C where c.idPasante = P.id and c.idPasante=" + IdtextBox.Text + "and fecha between '" + DesdedateTimePicker.Value.ToString("yyyy-MM-dd") + "' and '" + HastadateTimePicker.Value.ToString("yyyy-MM-dd") + "' ";
          //      sql = "select C.idPasante,P.nombre,P.apellido,c.fecha,c.horas from dbo.Estudiante P, dbo.Control C where c.idPasante=" + IdtextBox.Text + "and fecha between '" + DesdedateTimePicker.Value.ToString("yyyy-MM-dd") + "' and '" + HastadateTimePicker.Value.ToString("yyyy-MM-dd") + "' ";
                da = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                da.Fill(dt);
                cr.SetDataSource(dt);
             
                report.crystalReportViewer.ReportSource = cr;
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
            reporte(ReportedataGridView);
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            VentanaReporte report = new VentanaReporte();
            CrystalReport1 cr = new CrystalReport1();
            report.crystalReportViewer.ReportSource = cr;
            report.Show();        
        }
    }
}