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
        SqlDataAdapter da;
        DataTable dt;
   
        public Conexion()
        {
            try
            {
                con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=ControlPasantiaDb; Integrated Security=True");
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de conexion" + ex.ToString());
            }
        }

        public string insertar(string nombre,string apellido,string universidad, DateTime fecha  ,int horaCursar)
        {
            string salida = "Guardado Con Exito";
            string sql = "";
            try
            {
                sql = "Insert into Estudiante(nombre,apellido,universidad,fechaIngreso,horaCursar) values('" + nombre + "','" + apellido + "','" + universidad + "','" + fecha.ToString("yyyyMMdd") + "'," + horaCursar + ")";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();      
            }
            catch(Exception ex)
            {
                salida = "Error al Guardar" + ex.ToString();
            }   
            finally
            {
                con.Close();
            }
            return salida;
        }

    

        public string insertarControl(int id ,DateTime fecha,DateTime horaEntrada,DateTime horaSalida,double horas)
        {
            string salida = "";
            string sql = "";
            try
            {
                sql = "Insert into Control(idPasante,fecha,horaEntrada,horaSalida,horas) values("+id+",'"+fecha.ToString("yyyyMMdd")+"','"+horaEntrada.ToString("hh:mm:ss")+"','"+horaSalida.ToString("hh:mm:ss")+"',"+horas+")";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "Error al Guardar" + ex.ToString();
            }
            finally
            {
                con.Close();
            }
            return salida;
        }

        public void ListadoPasante(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select id AS'ID',nombre AS 'Nombre',apellido AS 'Apellido',universidad AS 'Universidad',fechaIngreso AS 'Fecha Ingreso',horaCursar AS 'Hora Cursar' from Estudiante ", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo llenar el datagridview" + ex.ToString());
            }
        }

        public void ListadoControl(DataGridView dgv,int id)
        {
            try
            { 
                da = new SqlDataAdapter("select idPasante AS'ID',fecha AS 'Fecha',horaEntrada AS 'Hora Entrada', horaSalida AS 'Hora Salida', horas AS 'Horas' from Control where idPasante ="+id+"", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el datagridview" + ex.ToString());
            }
        }
     
        public bool Existe(int id)
        {
            bool paso = false;
            string sql = "";
            try
            {
                sql = " SELECT COUNT(*) FROM Estudiante WHERE id ="+id+"";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                    return false;
                else
                    return true;
            }
            catch (Exception)
            {

            }
            return paso;
        }

        public string Eliminar()
        {
            string paso = "";
            try
            {
                cmd = new SqlCommand("delete from Control where idPasante= @ID", con);
               // cmd.Parameters.AddWithValue("@idPasante");

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return paso;
        }

        public string Reporte(int id)
        {
            string paso = "";
            try
            {
                cmd = new SqlCommand("select sum(horas)  from Control where id ="+id+" ",con);
             
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return paso;
        }

        public void llenacombobox(ComboBox cb)
        {
            try
            {
                da = new SqlDataAdapter("select id,nombre AS 'Nombre' from Estudiante ", con);

                DataTable dt = new DataTable();
                da.Fill(dt);        
                cb.ValueMember = "ID";
                cb.DisplayMember = "Nombre";
                cb.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void logins(string usuario,string pass)
        {
            try
            {
                cmd = new SqlCommand("SELECT usuario, pass FROM usuarios WHERE usuario = @usuario AND pass = @pass");
                cmd.ExecuteNonQuery();              
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

