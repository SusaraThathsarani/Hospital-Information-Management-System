﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hospital_Information_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Display();
            Display2();
            Display3();
            Display4();
        }

        private void Display()
        {
            string connectionString = "Server = 127.0.0.1; Database = HospitalDB; Uid = root; Pwd = @Sus12345";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM patients";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        lblCount1.Text = "Total Patients: " +count.ToString();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void Display2()
        {
            string connectionString = "Server = 127.0.0.1; Database = HospitalDB; Uid = root; Pwd = @Sus12345";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM doctors";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        lblCount2.Text = "Total Doctors: " + count.ToString();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        private void Display3()
        {
            string connectionString = "Server = 127.0.0.1; Database = HospitalDB; Uid = root; Pwd = @Sus12345";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM nurses";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        lblCount3.Text = "Total Nurses: " + count.ToString();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Display4()
        {
            string connectionString = "Server = 127.0.0.1; Database = HospitalDB; Uid = root; Pwd = @Sus12345";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM appointments";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        lblCount4.Text = "Total Appointments: " + count.ToString();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
