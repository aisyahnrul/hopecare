using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hopecare.view
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1 detik
            timer1.Start();
        }

        private void SplashScreen_QueryAccessibilityHelp(object sender, QueryAccessibilityHelpEventArgs e)
        {

        }

        byte i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 5)
            {
                timer1.Enabled = false;
                //Form1 login = new Form1();
                //login.Show();
                login login = new login();
                login.Show();
                this.Hide();
            }
        }
    }
}
