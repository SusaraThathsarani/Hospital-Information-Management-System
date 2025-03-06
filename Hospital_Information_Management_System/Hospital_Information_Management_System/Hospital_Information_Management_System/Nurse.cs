﻿using MySql.Data.MySqlClient;
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
    public partial class Nurse : Form
    {
        public Nurse()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int nurseid = int.Parse(textBox1.Text);
            string nursename = textBox2.Text;
            string phone = textBox3.Text;
            string department = textBox4.Text;

            string query = "insert into nurses(nurseid,nursename,phone,department)values (@nurseid,@nursename,@phone,@department)";
            using (MySqlConnection conn = new DatabaseConnection().Getconnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NurseID", nurseid);
                    cmd.Parameters.AddWithValue("@Nursename", nursename);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Department", department);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Inserted Successfully");
            NurseData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int nurseid = int.Parse(textBox1.Text);
            string nursename = textBox2.Text;
            string phone = textBox3.Text;
            string department = textBox4.Text;

            string query = "update nurses set nursename = @nursename,phone = @phone,department = @department where nurseid = @nurseid";
            using (MySqlConnection conn = new DatabaseConnection().Getconnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NurseID", nurseid);
                    cmd.Parameters.AddWithValue("@Nursename", nursename);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Department", department);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Updated Successfully");
            NurseData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int nurseid = int.Parse(textBox1.Text);


            string query = "delete from nurses where nurseid = @nurseid";
            using (MySqlConnection conn = new DatabaseConnection().Getconnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NurseID", nurseid);

                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Record Deleted Successfully");
            NurseData();
        }

        private void Nurse_Load(object sender, EventArgs e)
        {
            NurseData();
        }

        private void NurseData()
        {

            string query = "select * from nurses";
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
