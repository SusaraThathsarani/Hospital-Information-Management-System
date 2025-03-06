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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            DoctorData();
        }

        private void DoctorData()
        {
            string query = "select * from doctors";
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int doctorid = int.Parse(textBox1.Text);
            string doctorname = textBox2.Text;
            string speciality = textBox3.Text;
            string phone = textBox4.Text;
            string department = textBox5.Text;

            string query = "insert into doctors(doctorid,doctorname,speciality,phone,department)values (@doctorid,@doctorname,@speciality,@phone,@department)";
            using (MySqlConnection conn = new DatabaseConnection().Getconnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DoctorID", doctorid);
                    cmd.Parameters.AddWithValue("@Doctorname", doctorname);
                    cmd.Parameters.AddWithValue("@Speciality", speciality);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Department", department);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Inserted Successfully");
            DoctorData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int doctorid = int.Parse(textBox1.Text);
            string doctorname = textBox2.Text;
            string speciality = textBox3.Text;
            string phone = textBox4.Text;
            string department = textBox5.Text;

            string query = "update doctors set doctorname = @doctorname,speciality = @speciality,phone = @phone,department = @department where doctorid = @doctorid";
            using (MySqlConnection conn = new DatabaseConnection().Getconnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DoctorID", doctorid);
                    cmd.Parameters.AddWithValue("@Doctorname", doctorname);
                    cmd.Parameters.AddWithValue("@Speciality", speciality);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Department", department);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Updated Successfully");
            DoctorData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int doctorid = int.Parse(textBox1.Text);
            

            string query = "delete from doctors where doctorid = @doctorid";
            using (MySqlConnection conn = new DatabaseConnection().Getconnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DoctorID", doctorid);
                    
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Deleted Successfully");
            DoctorData();
        }
    }
}
