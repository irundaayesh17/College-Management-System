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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_Project_NIBM
{
    public partial class Lecturers : Form
    {
        public Lecturers()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void btn_stu_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
            this.Hide();
        }

        private void btn_fees_Click(object sender, EventArgs e)
        {
            payments payments = new payments();
            payments.Show();
            this.Hide();
        }

        private void btn_dep_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.Show();
            this.Hide();
        }

        private void btnlec_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (lecid_txt.Text == "" || lecname_txt.Text == "" || lecadd_richtxt.Text == "" || lectel_txt.Text == "" || lecgender_combo.SelectedItem == null || lecdep_combo.SelectedValue==null)
                {
                    MessageBox.Show("All the infomations are requird", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (lecname_txt.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Lecturer Name Cannot be Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (lecid_txt.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Lecturer ID must be Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(lecage_txt.Text) <= 18 || Convert.ToInt32(lecage_txt.Text) >= 60) MessageBox.Show("Age must be between 18 - 60", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (lectel_txt.Text.Length != 10 || lectel_txt.Text.Any(char.IsLetter)) MessageBox.Show("Lecture Telephone Must be 10 Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("insert into teachertb values ('" + lecid_txt.Text + "','" + lecname_txt.Text + "','" + lecgender_combo.SelectedItem.ToString() + "', '" + lecdob_datetime.Text + "','" + lecage_txt.Text + "' , '" + lecadd_richtxt.Text + "','" + lectel_txt.Text + "','" + lecdep_combo.SelectedValue.ToString() + "')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    viewLecturedetails();
                    MessageBox.Show("Data Added Succesfully!", "Reminder!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
            catch 
            {

                MessageBox.Show("Oops! Something Wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }

        }

        private void Lecturers_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-TNT37LB;Initial Catalog=studentmanagementsystem;Integrated Security=True");
            filldepartment();
            viewLecturedetails();
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
            lecdep_combo.ValueMember = "depdesc";
            lecdep_combo.DataSource = dt;
            conn.Close();
        }

        private void lecdob_datetime_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - lecdob_datetime.Value.Year;
            lecage_txt.Text = age.ToString();
            lecage_txt.ReadOnly = true;


        }
        private void viewLecturedetails()
        {
            conn.Open();
            string query = " select * from teachertb";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_dep.DataSource = ds.Tables[0];
            conn.Close();

        }
        private void clear()
        {
            lecid_txt.Clear();
            lecname_txt.Clear();
            lecgender_combo.ResetText();
            lecdob_datetime.ResetText();
            lecage_txt.Clear();
            lecadd_richtxt.Clear();
            lectel_txt.Clear();
            lecdep_combo.ResetText();
        }

        private void dgv_dep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lecid_txt.Text = dgv_dep.SelectedRows[0].Cells[0].Value.ToString();
            lecname_txt.Text = dgv_dep.SelectedRows[0].Cells[1].Value.ToString();
            lecgender_combo.SelectedItem = dgv_dep.SelectedRows[0].Cells[2].Value.ToString();
            lecdob_datetime.Text = dgv_dep.SelectedRows[0].Cells[3].Value.ToString();
            lecage_txt.Text=dgv_dep.SelectedRows[0].Cells[4].Value.ToString();
            lecadd_richtxt.Text = dgv_dep.SelectedRows[0].Cells[5].Value.ToString();
            lectel_txt.Text = dgv_dep.SelectedRows[0].Cells[6].Value.ToString();
            lecdep_combo.SelectedValue=dgv_dep.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnlec_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (lecid_txt.Text == "" || lecname_txt.Text == "" || lecadd_richtxt.Text == "" || lecgender_combo.SelectedItem == null || lectel_txt.Text == "" || lecdep_combo.SelectedValue == null)
                {
                    MessageBox.Show("All the infomations are requird", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (lecname_txt.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Lecturer Name Cannot be Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (lecid_txt.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Lecturer ID must be Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(lecage_txt.Text) <= 18 || Convert.ToInt32(lecage_txt.Text) >= 60) MessageBox.Show("Age must be between 18 - 60", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (lectel_txt.Text.Length != 10 || lectel_txt.Text.Any(char.IsLetter)) MessageBox.Show("Lecture Telephone Must be 10 Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    conn.Open();
                    string query = "update teachertb set teachername = '" + lecname_txt.Text + "' , teachergender = '" + lecgender_combo.SelectedItem.ToString() + "', teacherdob = '" + lecdob_datetime.Text + "' , teacherage = '" + lecage_txt.Text + "' , teacheradddress = '" + lecadd_richtxt.Text + "' , teachertel = '" + lectel_txt.Text + "' , teacherdep = '" + lecdep_combo.SelectedValue.ToString() + "' where teacherid = '" + lecid_txt.Text + "';";
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    viewLecturedetails();
                    MessageBox.Show("Data Updated Succesfully!", "Reminder!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();

                }
            }
            catch 
            {
                MessageBox.Show("Oops! Something Wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void btnlec_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (lecid_txt.Text == "")
                {
                    MessageBox.Show("Lecturer ID is Requird.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Open();
                    string query = "delete from teachertb where teacherid ='" + lecid_txt.Text + "';";
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    viewLecturedetails();
                    MessageBox.Show("Data Deleted Succesfully!", "Reminder!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
            catch 
            {
                MessageBox.Show("Oops! Something Wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void lecage_txt_TextChanged(object sender, EventArgs e)
        {
            lecage_txt.ReadOnly = true;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}

