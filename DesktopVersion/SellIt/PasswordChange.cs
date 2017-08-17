using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SellIt
{
    public partial class PasswordChange : Form
    {
        UserinfoDAO userinfoDao = new UserinfoDAO();

        public PasswordChange()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxNewPass.Text.Equals(textBoxConfirmPass.Text))
            {
                if (radioButtonAdmin.Checked == true)
                {
                    int x = userinfoDao.GetLoginInfo(new UserinfoDTO(textBoxUserName.Text, textBoxOldPass.Text, "admin"));
                    if (x < 1)
                    {
                        MessageBox.Show("Invalid Username or password or account type", "Operation Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        userinfoDao.ResetPass(new UserinfoDTO(textBoxUserName.Text, textBoxNewPass.Text));
                        MessageBox.Show("Password Changed!!", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Hide();
                        WelcomeCashier obj = new WelcomeCashier();
                        obj.Show();
                    }
                }
                else
                {
                    int x = userinfoDao.GetLoginInfo(new UserinfoDTO(textBoxUserName.Text, textBoxOldPass.Text, "cashier"));
                    if (x < 1)
                    {
                        MessageBox.Show("Invalid Username or password or account type", "Operation Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        userinfoDao.ResetPass(new UserinfoDTO(textBoxUserName.Text, textBoxNewPass.Text));
                        MessageBox.Show("Password Changed!!", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Hide();
                        WelcomeCashier obj = new WelcomeCashier();
                        obj.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Password Miss Matched!!", "Operation Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
