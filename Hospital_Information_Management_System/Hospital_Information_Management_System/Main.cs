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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient pt = new Patient();
            pt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doctor dr = new Doctor();
            dr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nurse ne = new Nurse();
            ne.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MedicalRecord md = new MedicalRecord();
            md.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bill bl = new Bill();
            bl.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dashboard dd = new Dashboard();
            dd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Appointment().Show();
            Close();
        }
    }
}
