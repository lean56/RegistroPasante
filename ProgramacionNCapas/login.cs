using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ProgramacionNCapas
{
    public partial class login : Form
    {
        String cs = "Data Source =EMIL56\\SQLEXPRESS; Initial Catalog = ControlPasantia; User ID = emil; Password = 5656";

        public login()
        {
            InitializeComponent();
        }



        public void logins()
        {
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("SELECT usuario,pass FROM usuarios WHERE usuario = @usuario AND pass = @pass", myConnection);

                // SELECT usuario, pass FROM usuarios WHERE usuario = '" 
                SqlParameter uName = new SqlParameter("@usuario", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@pass", SqlDbType.VarChar);

                uName.Value = usertextBox.Text;
                uPassword.Value = passtextBox.Text;

                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);

                myCommand.Connection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                /* try
                 {
                     string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                     using (SqlConnection conexion = new SqlConnection(cnn))
                     {
                         conexion.Open();
                         using (SqlCommand cmd = new SqlCommand("SELECT usuario,pass FROM usuarios WHERE usuario ='" + usertextBox.Text + "'AND pass ='" + passtextBox.Text + "'", conexion))
                         {
                             SqlDataReader dr = cmd.ExecuteReader();

                             if (dr.Read())
                             {
                                 MessageBox.Show("login");
                             }
                             else
                             {
                                 MessageBox.Show("Datos Incorrectos");
                             }

                         }
                     }
                 }
                 catch(Exception ex)
                 {
                     MessageBox.Show(ex.ToString());
                 } */
                if (myReader.Read() == true)
                {
                    MessageBox.Show("You have logged in successfully " + usertextBox.Text);
                    //Hide the login form
                    this.Hide();
                }


                else
                {
                    MessageBox.Show("Login Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    usertextBox.Clear();
                    passtextBox.Clear();
                    usertextBox.Focus();

                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logins();
        }
    }
}
