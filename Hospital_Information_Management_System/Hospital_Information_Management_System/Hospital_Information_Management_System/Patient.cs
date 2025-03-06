using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Information_Management_System
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void label5_Click_Patient(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click1(object sender, EventArgs e)
        {
            int patientid = int.Parse(textBox1.Text);
            string patientname = textBox2.Text;
            int age = int.Parse(textBox3.Text);
            string gender = textBox4.Text;
            string address = textBox5.Text;

            string query = "insert into patients(patientid,patientname,age,gender,address)values (@patientid,@patientname,@age,@gender,@address)";
            using (MySqlConnection conn = new DatabaseConnection().Getconnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PatientID", patientid);
                    cmd.Parameters.AddWithValue("@Patientname", patientname);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Inserted Successfully");
            PatientData1();

        }

        private void btnUpdate_Click1(object sender, EventArgs e)
        {
            int patientid = int.Parse(textBox1.Text);
            string patientname = textBox2.Text;
            int age = int.Parse(textBox3.Text);
            string gender = textBox4.Text;
            string address = textBox5.Text;

            string query = "update patients set patientname = @patientname,age = @age,gender = @gender,address = @address where patientid = @patientid";
            using (MySqlConnection conn = new DatabaseConnection().Getconnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PatientID", patientid);
                    cmd.Parameters.AddWithValue("@Patientname", patientname);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Updated Successfully");
            PatientData1();
        }

        private void btnDelete_Click1(object sender, EventArgs e)
        {
            int patientid = int.Parse(textBox1.Text);


            string query = "delete from patients where patientid = @patientid";
            using (MySqlConnection conn = new DatabaseConnection().Getconnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PatientID", patientid);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Deleted Successfully");
            PatientData1();
        }

        private void Patient_Load1(object sender, EventArgs e)
        {
            PatientData1();

        }

        private void PatientData1()
        {
            string query = "select * from patients";
            using (MySqlConnection conn = new DatabaseConnection().Getconnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;


                    }

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
