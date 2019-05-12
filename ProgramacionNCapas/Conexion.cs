using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data;

namespace ProgramacionNCapas
{
    class Conexion
    {
        SqlConnection con;
        SqlCommand cmd;
        //SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
    

        public Conexion()
        {
           
            try
            {
                //con = new SqlConnection("Data Source=EMIL56\\SQLEXPRESS; Initial Catalog=ControlPasantia; Integrated Security=True");
                con = new SqlConnection("Data Source =EMIL56\\SQLEXPRESS; Initial Catalog = ControlPasantia; User ID = emil; Password = 5656");
                con.Open();
              //  MessageBox.Show("Conectado");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de conexion" + ex.ToString());
            }
        }

        public string insertar(int id,string nombre,string apellido,string universidad,string fecha,int horaCursar)
        {
            string salida = "Guardado Con Exito";
            try
            {
                cmd = new SqlCommand("Insert into Estudiante(id,nombre,apellido,universidad,fechaIngreso,horaCursar) values("+id+",'" + nombre + "','" + apellido + "','"+universidad+"','"+fecha+"',"+horaCursar+")", con);
                cmd.ExecuteNonQuery();      
            }
            catch(Exception ex)
            {
                salida = "Error al Guardar" + ex.ToString();
            }      
                con.Close();
            return salida;
        }
        //.......................................................

        public string insertarControl(int id ,string fecha,string horaEntrada,string horaSalida)
        {
            string salida = "Guardado Con Exito";
            try
            {
                cmd = new SqlCommand("Insert into Control(id,fecha,horaEntrada,horaSalida) values(" +id+",'"+fecha+"','"+horaEntrada+"','"+horaSalida+"')", con);
                //cmd = new SqlCommand("Insert into Control(id,fecha,horaEntrada,horaSalida) values(" + id + ",'" + fecha + "','" + horaEntrada + "','" + horaSalida + "')", con);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "Error al Guardar" + ex.ToString();
            }
            con.Close();
            return salida;
        }

        //..................

        public void cargar(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Estudiante", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo llenar el datagridview" + ex.ToString());
            }
        }


        public void cargar2(DataGridView dgv)
        {
            try
            {
                // da = new SqlDataAdapter("Select * from Control", con);
                //  da = new SqlDataAdapter("Select * from Control ", con);

                da = new SqlDataAdapter("select id AS'ID',fecha AS 'Fecha',horaEntrada AS 'Hora Entrada', horaSalida AS 'Hora Salida' from Control", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el datagridview" + ex.ToString());
            }
        }
    }
}
