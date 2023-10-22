using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_NIBM
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();       
        }

        private void btn_stu_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
            this.Hide();
        }

        private void btn_lec_Click(object sender, EventArgs e)
        {
            Lecturers lecturers = new Lecturers();
            lecturers.Show();
            this.Hide();
        }

        private void btn_fees_Click(object sender, EventArgs e)
        {
            payments payments = new payments();
            payments.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
            else
            {

            }
                
        }

        private void btn_dep_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            StudentReport report = new StudentReport();
            report.Show();
            this.Hide();
        }
    }
}
