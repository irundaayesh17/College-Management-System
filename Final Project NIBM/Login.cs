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

namespace Final_Project_NIBM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_pass.Clear();
        }

        
        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = '●';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "ADMIN@NIBM" && txt_pass.Text == "admin1234")
            {
                Home home = new Home();
                home.Show();
                this.Close();
            }
            else if (txt_pass.Text == "" && txt_username.Text == "")
            {
                MessageBox.Show("Enter Username & Password");
            }
            else if (txt_username.Text == "")
            {
                MessageBox.Show("Please Enter Username");
            }
            else  if (txt_pass.Text == "")
            {
                MessageBox.Show("Please Enter Password");
            }
           
            else
            {
                MessageBox.Show(" Invalid Credentia" ) ;
                clear();
            }
           
        }
        public void clear()
        {
            txt_username.Clear();
            txt_pass.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpass.Checked)
            {
                string a = txt_pass.Text;
                txt_pass.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '●';
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
