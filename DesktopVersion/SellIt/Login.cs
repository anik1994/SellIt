using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SellIt
{
    public partial class Login : Form
    {
        UserinfoDAO userinfoDao = new UserinfoDAO();
        public Login()
        {
            Thread t = new Thread(new ThreadStart(splashStart));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();
        }
        public void splashStart()
        {
            Application.Run(new SplashScreen());
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (radioButtonAdmin.Checked == true)
            {
                int x = userinfoDao.GetLoginInfo(new UserinfoDTO(textBoxUserName.Text, textBoxPassword.Text, "admin"));
                if (x < 1)
                {
                    MessageBox.Show("Invalid Username or password or account type", "Login Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Hide();
                    WelcomeAdmin obj = new WelcomeAdmin();
                    obj.Show();
                }
            }
            else
            {
                int x = userinfoDao.GetLoginInfo(new UserinfoDTO(textBoxUserName.Text, textBoxPassword.Text, "cashier"));
                if (x < 1)
                {
                    MessageBox.Show("Invalid Username or password or account type", "Login Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Hide();
                    WelcomeCashier obj = new WelcomeCashier();
                    obj.Show();
                }
            }
        }
    }
}
