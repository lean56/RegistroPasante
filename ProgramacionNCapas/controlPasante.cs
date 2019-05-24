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
    public partial class controlPasante : Form
    {
        double horas,horaRestante;
        
        public controlPasante()
        {
            InitializeComponent();
        }

        private void controlPasante_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();

            c.ListadoControl(ControldataGridView);
            ControldataGridView.Columns[2].DefaultCellStyle.Format = "hh:mm tt";
            ControldataGridView.Columns[3].DefaultCellStyle.Format="hh:mm tt";

            c.llenacombobox(EstudiantecomboBox);
        }

        private void buscarbutton_Click(object sender, EventArgs e)
        {
            Listado l = new Listado();
            l.ShowDialog();
            idEstudiante.Text = l.ID.ToString();
            l.Close();
        }


      public void validarId()
        {
            Conexion c = new Conexion();
            if (!c.Existe(Convert.ToInt32(idEstudiante.Text)))
                MessageBox.Show("Id no existe!!!");
        }


        private void agregarButton_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();

            //verificar si el textbox id esta vacio

            if (idEstudiante.Text == "")
            {
                errorProvider.SetError(idEstudiante, "Campo Id Vacio!!!");
                idEstudiante.Focus();
            }
            else
            {   //validar si el id existe en la db
                if (!c.Existe(Convert.ToInt32(idEstudiante.Text)))
                {
                    MessageBox.Show("Id no existe!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }         
               else
                {   
                    if (horaEntrada.Value > horaSalida.Value)
                    {
                        MessageBox.Show("La hora salida debe ser mayor a la hora de entrada","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        RegistroPasante rp = new RegistroPasante();
                        //Para restar 2 las horas
                        DateTime fecha1 = Convert.ToDateTime(horaEntrada.Value);
                        DateTime fecha2 = Convert.ToDateTime(horaSalida.Value);
                        horas = Math.Round(fecha2.Subtract(fecha1).TotalMinutes, 1);
                        horaRestante = 180 - (horas/60);
                        //agregar datos a la db
                        c.insertarControl(Convert.ToInt32(idEstudiante.Text), fecha.Value, horaEntrada.Value, horaSalida.Value, horas / 60, horaRestante);
                        MessageBox.Show("Guardado con Exito!!!","Guardado",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        c.ListadoControl(ControldataGridView);
                    }
                }
            }
        }

        private void idEstudiante_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(idEstudiante, "");
        }

    }
}
