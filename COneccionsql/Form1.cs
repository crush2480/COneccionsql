using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COneccionsql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // declarar la cadema de concexion para conectarse con sql server 
        static private string cadena = "server=dataepis.uandina.pe,49157;Database=BDAcademicoCamacho;User Id=camachof;Password=C@m@ch02480;";
        //empaquetar la llave de conexion para enviarlo al SQL server
        static private SqlConnection conexion = new SqlConnection(cadena);
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
       
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            //Generar la consulta
            string consulta = "spListarAlumno";
            //traer los datos de sql server en un contenedor 
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvDatos.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                using (SqlCommand cmdUsuario = new SqlCommand("spAgregar_Usuario", conexion))
                {
                    cmdUsuario.CommandType = CommandType.StoredProcedure;
                    cmdUsuario.Parameters.AddWithValue("@Usuario", txbUsuario.Text);
                    cmdUsuario.ExecuteNonQuery();
                }

                using (SqlCommand cmdAlumno = new SqlCommand("spAgregar_Alumno", conexion))
                {
                    cmdAlumno.CommandType = CommandType.StoredProcedure;
                    cmdAlumno.Parameters.AddWithValue("@CodAlumno", txbCodAlum.Text);
                    cmdAlumno.Parameters.AddWithValue("@APaterno", txbAPaterno.Text);
                    cmdAlumno.Parameters.AddWithValue("@AMaterno", txbAMaterno.Text);
                    cmdAlumno.Parameters.AddWithValue("@Nombres", txbNombre.Text);
                    cmdAlumno.Parameters.AddWithValue("@Usuario", txbUsuario.Text);
                    cmdAlumno.Parameters.AddWithValue("@CodCarrera", txbCodCarrera.Text);
                    cmdAlumno.ExecuteNonQuery();
                }

                MessageBox.Show("Datos guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnCargarDatosDocente_Click(object sender, EventArgs e)
        {
            //Generar la consulta
            string consulta = "splistarDocente";
            //traer los datos de sql server en un contenedor 
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvDatos.DataSource = table;
        }

        private void btnCargarDatosAsignatura_Click(object sender, EventArgs e)
        {
            //Generar la consulta
            string consulta = "splistarAsignatura";
            //traer los datos de sql server en un contenedor 
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvDatos.DataSource = table;
        }

        private void btnCargarDatosCarrera_Click(object sender, EventArgs e)
        {
            //Generar la consulta
            string consulta = "splistarCarrera";
            //traer los datos de sql server en un contenedor 
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvDatos.DataSource = table;
        }
    }
}
