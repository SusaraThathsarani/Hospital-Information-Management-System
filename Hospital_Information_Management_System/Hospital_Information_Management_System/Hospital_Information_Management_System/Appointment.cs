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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Information_Management_System
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int aid = int.Parse(textBox1.Text);
            string patientname = textBox2.Text;
            string doctorname = textBox3.Text;
            string date_created = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string status = textBox4.Text;


            string query = "insert into appointments(aid,patientname,doctorname,date_created,status)values (@aid,@patientname,@doctorname,@date_created,@status)";
            using (MySqlConnection conn = new DatabaseConnection().Getconnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AID", aid);
                    cmd.Parameters.AddWithValue("@Patientname", patientname);
                    cmd.Parameters.AddWithValue("@Doctorname", doctorname);
                    cmd.Parameters.AddWithValue("@Date_created", date_created);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Inserted Successfully");
            AppointmentData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int aid = int.Parse(textBox1.Text);
            string patientname = textBox2.Text;
            string doctorname = textBox3.Text;
            string date_created = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string status = textBox4.Text;


            string query = "update appointments set patientname = @patientname,doctorname=@doctorname,date_created=@date_created,status=@status where aid = @aid";
            using (MySqlConnection conn = new DatabaseConnection().Getconnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AID", aid);
                    cmd.Parameters.AddWithValue("@Patientname", patientname);
                    cmd.Parameters.AddWithValue("@Doctorname", doctorname);
                    cmd.Parameters.AddWithValue("@Date_created", date_created);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Updated Successfully");
            AppointmentData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int aid = int.Parse(textBox1.Text);


            string query = "delete from appointments where aid = @aid";
            using (MySqlConnection conn = new DatabaseConnection().Getconnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AID", aid);

                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Deleted Successfully");
            AppointmentData();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            AppointmentData();
        }

        private void AppointmentData()
        {
            string query = "select * from appointments";
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
    }
}
