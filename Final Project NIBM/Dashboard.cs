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

namespace Final_Project_NIBM
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_stu_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
            this.Hide();
        }

        private void btn_dep_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.Show();
            this.Hide();
        }

        private void btn_fees_Click(object sender, EventArgs e)
        {
            payments payments = new payments();
            payments.Show();
            this.Hide();
        }

        private void btn_lec_Click(object sender, EventArgs e)
        {
            Lecturers lecturers = new Lecturers();
            lecturers.Show();
            this.Hide();
        }

        private void picbox_nibm_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-TNT37LB;Initial Catalog=studentmanagementsystem;Integrated Security=True");
            conn.Open();
            //Students
            SqlDataAdapter sda1 = new SqlDataAdapter ("select count(*) from students",conn);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            stu_lbl.Text = dt1.Rows[0][0].ToString();

            //lecturers
            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from teachertb", conn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            lec_lbl.Text = dt2.Rows[0][0].ToString();

            //Departments
            SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from department", conn);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            dep_lbl.Text = dt3.Rows[0][0].ToString();

            //Payments
            cmd = new SqlCommand("SELECT SUM (amount) FROM payments", conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            fees_lbl.Text = count.ToString();
            conn.Close();
        }

        private void fees_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
