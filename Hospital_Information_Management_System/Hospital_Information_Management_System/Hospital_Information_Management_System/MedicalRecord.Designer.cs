namespace Hospital_Information_Management_System
{
    partial class MedicalRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1429, 113);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Dutch801 Rm BT", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(505, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(439, 71);
            label1.TabIndex = 0;
            label1.Text = "Medical Record";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(438, 446);
            textBox5.Margin = new Padding(4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(856, 27);
            textBox5.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(438, 376);
            textBox4.Margin = new Padding(4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(856, 27);
            textBox4.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(438, 303);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(856, 27);
            textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(438, 233);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(856, 27);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(438, 158);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(856, 27);
            textBox1.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(115, 233);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(197, 41);
            label6.TabIndex = 15;
            label6.Text = "PatientName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(115, 303);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(194, 41);
            label5.TabIndex = 14;
            label5.Text = "DoctorName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(115, 376);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 41);
            label4.TabIndex = 13;
            label4.Text = "Nurse";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(115, 446);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(170, 41);
            label3.TabIndex = 12;
            label3.Text = "Diagonosis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(115, 151);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 41);
            label2.TabIndex = 11;
            label2.Text = "MID";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.Font = new Font("Century", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(947, 662);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(182, 60);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdate.Font = new Font("Century", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(588, 662);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(182, 60);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(255, 128, 0);
            btnInsert.Font = new Font("Century", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(249, 662);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(182, 60);
            btnInsert.TabIndex = 21;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(103, 761);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1179, 282);
            dataGridView1.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(115, 514);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(182, 41);
            label7.TabIndex = 25;
            label7.Text = "Prescription";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(115, 575);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(159, 41);
            label8.TabIndex = 26;
            label8.Text = "Treatment";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(438, 514);
            textBox6.Margin = new Padding(4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(856, 27);
            textBox6.TabIndex = 27;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(438, 575);
            textBox7.Margin = new Padding(4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(856, 27);
            textBox7.TabIndex = 28;
            // 
            // MedicalRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1429, 1055);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "MedicalRecord";
            Text = "MedicalRecord";
            Load += MedicalRecord_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private DataGridView dataGridView1;
        private Label label7;
        private Label label8;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}