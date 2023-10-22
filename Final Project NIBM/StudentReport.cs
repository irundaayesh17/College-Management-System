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
    public partial class StudentReport : Form
    {
        public StudentReport()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlDataAdapter sda;

        private void StudentReport_Load(object sender, EventArgs e)
        {

            conn = new SqlConnection("Data Source=DESKTOP-TNT37LB;Initial Catalog=studentmanagementsystem;Integrated Security=True");

            fillstudentreport();
        }
        private void fillstudentreport()
        {
            conn.Open();
            sda = new SqlDataAdapter ("select stuid from students",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                cmd_fillstuid.Items.Add(dr["stuid"].ToString());
            }
            conn.Close();   
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cmd_fillstuid.Text == "" )
            {
                MessageBox.Show("Student ID is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // TODO: This line of code loads data into the 'cMSreport.students' table. You can move, or remove it, as needed.
                this.studentsTableAdapter.Fill(this.cMSreport.students, Convert.ToInt32(cmd_fillstuid.Text));
                this.reportViewer1.RefreshReport();
            }

        }

        private void picbox_nibm_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
    
}
