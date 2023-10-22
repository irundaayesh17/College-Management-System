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
using System.Text.RegularExpressions;

namespace Final_Project_NIBM
{
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        

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

        private void btn_fees_Click(object sender, EventArgs e)
        {
            payments payments = new payments();
            payments.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Department_Load(object sender, EventArgs e)
        {
            conn= new SqlConnection("Data Source=DESKTOP-TNT37LB;Initial Catalog=studentmanagementsystem;Integrated Security=True");
            viewdepartment();

        }
        private void viewdepartment()
        {
            conn.Open();
            string query = " select * from department";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn) ;
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_dep.DataSource = ds.Tables[0];
            conn.Close();

        }
        private void btndep_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (depid_txt.Text == "" || depname_text.Text == "" || depdes_txt.Text == "" || deptime_txt.Text == "")
                {
                    MessageBox.Show("All the infomations are requird", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (depname_text.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Department Name Cannot be Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
                else if (depid_txt.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Department ID Must be Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    conn.Open();
                    cmd= new SqlCommand("insert into department values ('" + depid_txt.Text + "' ,'" + depname_text.Text + "','" + depdes_txt.Text + "','" + deptime_txt.Text + "')",conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    viewdepartment();
                    MessageBox.Show("Data Added Succesfully!", "Reminder!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
            catch 
            {

                MessageBox.Show("Oops! Something Wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgv_dep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            depid_txt.Text = dgv_dep.SelectedRows[0].Cells[0].Value.ToString();
            depname_text.Text = dgv_dep.SelectedRows[0].Cells[1].Value.ToString();
            depdes_txt.Text = dgv_dep.SelectedRows[0].Cells[2].Value.ToString();
            deptime_txt.Text = dgv_dep.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void btn_dep_Click(object sender, EventArgs e)
        {

        }

        private void btndep_del_Click(object sender, EventArgs e)
        {
            try
            {
                if(depid_txt.Text == "")
                {
                    MessageBox.Show("Department ID is Requird.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Open();
                    string query = "delete from department where depid='" + depid_txt.Text + "';";
                    cmd= new SqlCommand(query,conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    viewdepartment();
                    MessageBox.Show("Data Deleted Succesfully!", "Reminder!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
            catch 
            {

                MessageBox.Show("Oops! Something Wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndep_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (depid_txt.Text == "" || depname_text.Text == "" || depdes_txt.Text == "" || deptime_txt.Text == "")
                {
                    MessageBox.Show("All the infomations are requird", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (depname_text.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Department Name Cannot be Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (depid_txt.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Department ID Muse be Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    conn.Open();
                    string query = "update department set depname = '" + depname_text.Text + "' , depdesc = '" + depdes_txt.Text + "' , depduration = '" + deptime_txt.Text + "' where depid = '" + depid_txt.Text + "';";
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    viewdepartment();
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
            depid_txt.Clear();
            depname_text.Clear();
            depdes_txt.Clear();
            deptime_txt.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void depdes_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
