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
    public partial class payments : Form
    {
        public payments()
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

        private void btn_dep_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.Show();
            this.Hide();
        }

        private void btnfees_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (feesid_txt.Text == "" || feestunam_txt.Text == "" || feesamount_txt.Text == "") 
                {
                    MessageBox.Show("All the infomations are requird", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (feesid_txt.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Payment ID Must be Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (feesamount_txt.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Payment Amount must be Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string date = feesdatetime_period.Value.Year.ToString();
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter ("select count(*) from payments where stuid = " + feestuid_combo.SelectedValue.ToString() + " and peried = '" + date + "'", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("No Dues for the Selected Period");
                        conn.Close();
                    }

                    else
                    {
                        conn.Close();
                        conn.Open();
                        cmd = new SqlCommand("insert into payments values ('" + feesid_txt.Text + "' , '" + feestuid_combo.SelectedValue.ToString() + "', '" + feestunam_txt.Text + "' , '" + date + "','" + feesamount_txt.Text + "')", conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        viewpaymentdetails();
                        updatestd();
                        MessageBox.Show("Data Added Succesfully!", "Reminder!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                }
            }
            catch 
            {

                MessageBox.Show("Oops! Something Wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

        private void payments_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-TNT37LB;Initial Catalog=studentmanagementsystem;Integrated Security=True");
            fillstudentid();
            viewpaymentdetails();
        }
        private void fillstudentid()
        {
            conn.Open();
            cmd = new SqlCommand("select stuid from students", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("stuid", typeof(string));
            dt.Load(rdr);
            feestuid_combo.ValueMember = "stuid";
            feestuid_combo.DataSource = dt;
            conn.Close();
        }

        private void feestuid_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void feestuid_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from students where stuid =" + feestuid_combo.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                feestunam_txt.Text = dr["stuname"].ToString();
            }
            conn.Close();
        }
        private void viewpaymentdetails()
        {
            conn.Open();
            string query = " select * from payments";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_fees.DataSource = ds.Tables[0];
            conn.Close();

        }
        private void updatestd()
        {
            conn.Open();
            string query = "update students set stufees ='" + feesamount_txt.Text + "' where stuid = " + feestuid_combo.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear();

        }
        private void clear()
        {
            feesid_txt.Clear();
            feestuid_combo.ResetText();
            feestunam_txt.Clear();
            feesdatetime_period.ResetText();
            feesamount_txt.Clear(); 
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (feesid_txt.Text == "")
                {
                    MessageBox.Show("Payment ID is Requird.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Open();
                    string query = "delete from payments where feesnum='" + feesid_txt.Text + "';";
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    viewpaymentdetails();
                    MessageBox.Show("Data Deleted Succesfully!", "Reminder!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
            catch
            {

                MessageBox.Show("Oops! Something Wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_fees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            feesid_txt.Text = dgv_fees.SelectedRows[0].Cells[0].Value.ToString();
            feestuid_combo.SelectedValue = dgv_fees.SelectedRows[0].Cells[1].Value.ToString();
            feestunam_txt.Text = dgv_fees.SelectedRows[0].Cells[2].Value.ToString();
            feesdatetime_period.Text = dgv_fees.SelectedRows[0].Cells[3].Value.ToString();
            feesamount_txt.Text = dgv_fees.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
