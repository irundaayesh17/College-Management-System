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
using System.Drawing.Text;

namespace Final_Project_NIBM
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_lec_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_dep_Click(object sender, EventArgs e)
        {

        }

        private void btn_fees_Click(object sender, EventArgs e)
        {

        }

        private void btn_users_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void Student_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-TNT37LB;Initial Catalog=studentmanagementsystem;Integrated Security=True");
            filldepartment();
            viewstudentdetails();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            

        }

        private void picbox_nibm_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_lec_Click_1(object sender, EventArgs e)
        {
            Lecturers lecturers = new Lecturers();
            lecturers.Show();
            this.Hide();
        }

        private void btn_fees_Click_1(object sender, EventArgs e)
        {
            payments payments = new payments();
            payments.Show();
            this.Hide();
        }

        private void btn_dep_Click_1(object sender, EventArgs e)
        {
            Department department = new Department();
            department.Show();
            this.Hide();
        }
        private void filldepartment()
        {
            conn.Open();
            cmd = new SqlCommand("select depdesc from department", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("depdesc", typeof(string));
            dt.Load(rdr);
            studep_combo.ValueMember = "depdesc";
            studep_combo.DataSource = dt;
            conn.Close();
        }
        private void viewstudentdetails()
        {
            conn.Open();
            string query = " select * from students";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_stu.DataSource = ds.Tables[0];
            conn.Close();

        }
        private void btnstu_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (stuid_txt.Text == "" || stuname_txt.Text == "" || stuadd_richtxt.Text == "" || stutel_txt.Text == "" || stugender_combo.SelectedItem == null || studep_combo.SelectedValue == null || stufees_txt.Text == "")
                {
                    MessageBox.Show("All the infomations are requird", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (stuname_txt.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Student Name Cannot be Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (stuid_txt.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Student ID must be Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(stuage_txt.Text) <= 17 || Convert.ToInt32(stuage_txt.Text) >= 60) MessageBox.Show("Age must be between 17 & 60", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (stutel_txt.Text.Length != 10 || stutel_txt.Text.Any(char.IsLetter)) MessageBox.Show("Student Telephone Must be 10 Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("insert into students values ('" + stuid_txt.Text + "','" + stuname_txt.Text + "','" + stugender_combo.SelectedItem.ToString() + "', '" + studob_datetime.Text + "','" + stuage_txt.Text + "' , '" + stuadd_richtxt.Text + "','" + stutel_txt.Text + "','" + studep_combo.SelectedValue.ToString() + "' , '" + stufees_txt.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    viewstudentdetails();
                    MessageBox.Show("Data Added Succesfully!", "Reminder!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
            catch 
            {

                MessageBox.Show("Oops! Something Wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

        private void studob_datetime_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - studob_datetime.Value.Year;
            stuage_txt.Text = age.ToString();
            stuage_txt.ReadOnly = true;
        }

        private void dgv_stu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            stuid_txt.Text = dgv_stu.SelectedRows[0].Cells[0].Value.ToString();
            stuname_txt.Text = dgv_stu.SelectedRows[0].Cells[1].Value.ToString();
            stugender_combo.SelectedItem = dgv_stu.SelectedRows[0].Cells[2].Value.ToString();
            studob_datetime.Text = dgv_stu.SelectedRows[0].Cells[3].Value.ToString();
            stuage_txt.Text = dgv_stu.SelectedRows[0].Cells[4].Value.ToString();
            stuadd_richtxt.Text = dgv_stu.SelectedRows[0].Cells[5].Value.ToString();
            stutel_txt.Text = dgv_stu.SelectedRows[0].Cells[6].Value.ToString();
            studep_combo.SelectedValue = dgv_stu.SelectedRows[0].Cells[7].Value.ToString();
            stufees_txt.Text = dgv_stu.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void btnstu_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (stuid_txt.Text == "" || stuname_txt.Text == "" || stuadd_richtxt.Text == "" || stutel_txt.Text == "" || stugender_combo.SelectedItem == null || studep_combo.SelectedValue == null || stufees_txt.Text == "")
                {
                    MessageBox.Show("All the infomations are requird", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (stuname_txt.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Student Name Cannot be Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (stuid_txt.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Studeent ID must be Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(stuage_txt.Text) <= 17) MessageBox.Show("Age must be higher than 17", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (stutel_txt.Text.Length != 10 || stutel_txt.Text.Any(char.IsLetter)) MessageBox.Show("Lecture Telephone Must be 10 Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    conn.Open();
                    string query = "update students set stuname = '" + stuname_txt.Text + "' , stugender = '" + stugender_combo.SelectedItem.ToString() + "', studob = '" + studob_datetime.Text + "' , stuage = '" + stuage_txt.Text + "' , stuadd = '" + stuadd_richtxt.Text + "' , stuphone = '" + stutel_txt.Text + "' , studep = '" + studep_combo.SelectedValue.ToString() + "' ,  stufees = '" + stufees_txt.Text + "'  where stuid = '" + stuid_txt.Text + "';";
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    viewstudentdetails();
                    MessageBox.Show("Data Updated Succesfully!", "Reminder!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();

                }
            }
            catch 
            {
                MessageBox.Show("Oops! Something Wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }
        private void clear()
        {
            stuid_txt.Clear();
            stuname_txt.Clear();
            stugender_combo.ResetText();
            studob_datetime.ResetText();
            stuage_txt.Clear();
            stuadd_richtxt.Clear();
            stutel_txt.Clear();
            studep_combo.ResetText();
            stufees_txt.Clear();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnstu_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (stuid_txt.Text == "")
                {
                    MessageBox.Show("Student ID is Requird.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Open();
                    string query = "delete from students where stuid ='" + stuid_txt.Text + "';";
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    viewstudentdetails();
                    MessageBox.Show("Data Deleted Succesfully!", "Reminder!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
            catch 
            {
                MessageBox.Show("Oops! Something Wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
