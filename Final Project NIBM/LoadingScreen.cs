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
    public partial class LoadingScreen : Form
    {
        
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            loadingbar.Value = startpos;
            if (loadingbar.Value == 100)
            {
                loadingbar.Value = 0;
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
