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
            string sql = "";
            try
            {
                sql = "select C.idPasante AS ID,P.nombre AS Nombre,P.apellido AS Apellido,c.fecha AS Fecha,c.horas AS Horas from dbo.Estudiante P, dbo.Control C where c.idPasante = P.id and c.idPasante=" + IdtextBox.Text + "and fecha between '" + DesdedateTimePicker.Value.ToString("yyyy-MM-dd") + "' and '" + HastadateTimePicker.Value.ToString("yyyy-MM-dd") + "' ";
                da = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;    
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el datagridview" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return sql;
        }

        private void Reportebutton_Click_1(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            if (IdtextBox.Text == "")
            {
                MyErrorProvider.SetError(IdtextBox, "Campo Id Vacio!!!");
                IdtextBox.Focus();
            }
            else
            {
                if (!c.Existe(Convert.ToInt32(IdtextBox.Text)))
                {
                    MyErrorProvider.SetError(IdtextBox, "Id no Existe!!!");
                    IdtextBox.Focus();
                    // MessageBox.Show("Id no existe!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    reporte(ReportedataGridView);
                    MyErrorProvider.Clear();
                }
            }
          
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            if (IdtextBox.Text == "")
            {
                MyErrorProvider.SetError(IdtextBox, "Campo Id Vacio!!!");
                IdtextBox.Focus();
            }
            else
            {
                CargarReporte();
            }
        }

        public void CargarReporte()
        {
            VentanaReporte report = new VentanaReporte();
            Report1 cr = new Report1();
            cr.SetDataSource(filtro());
            report.crystalReportViewer.ReportSource = cr;
            report.crystalReportViewer.Refresh();
            report.Show();
        }

        public DataTable filtro()
        {
            try
            {
                string sql = "";
                sql = "select C.idPasante,P.nombre,P.apellido,c.fecha,c.horas,c.horaEntrada,c.horaSalida from dbo.Estudiante P, dbo.Control C where c.idPasante = P.id and c.idPasante=" + IdtextBox.Text + "and fecha between '" + DesdedateTimePicker.Value.ToString("yyyy-MM-dd") + "' and '" + HastadateTimePicker.Value.ToString("yyyy-MM-dd") + "' ";
                da = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        private void buscarbutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                Listado l = new Listado();
                l.ShowDialog();
                IdtextBox.Text = l.ID.ToString();
                l.Close();
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void IdtextBox_TextChanged_1(object sender, EventArgs e)
        {
            MyErrorProvider.SetError(IdtextBox, "");
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

