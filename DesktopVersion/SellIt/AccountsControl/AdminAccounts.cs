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
    public partial class AdminAccounts : Form
    {
        UserinfoDAO userinfoDao = new UserinfoDAO();
        string id="", password="";
        public AdminAccounts()
        {
            InitializeComponent();
            loadAdmin();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            userinfoDao.AddUser(new UserinfoDTO(textBoxName.Text, textBoxUserName.Text, "123456", "admin", textBoxAddress.Text, textBoxPhn.Text, Convert.ToInt32(textBoxAge.Text), Convert.ToDouble(textBoxSalary.Text)));
            loadAdmin();
            makeEmpty();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeAdmin obj = new WelcomeAdmin();
            obj.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            userinfoDao.UpdateUser(new UserinfoDTO(textBoxName.Text, textBoxUserName.Text, password, "admin", textBoxAddress.Text, textBoxPhn.Text, Convert.ToInt32(textBoxAge.Text), Convert.ToDouble(textBoxSalary.Text),id));
            loadAdmin();
            makeEmpty();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            userinfoDao.DeleteUser(id);
            loadAdmin();
            makeEmpty();
        }

        private void loadAdmin()
        {
            dataGridViewAdmin.DataSource = userinfoDao.GetAdmins().Tables[0];
        }

        private void dataGridViewAdmin_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAdmin.SelectedRows.Count == 1)
            {
                int idx = dataGridViewAdmin.SelectedRows[0].Index;
                id = dataGridViewAdmin.Rows[idx].Cells[0].Value.ToString();
                textBoxName.Text = dataGridViewAdmin.Rows[idx].Cells[1].Value.ToString();
                textBoxUserName.Text = dataGridViewAdmin.Rows[idx].Cells[2].Value.ToString();
                password = dataGridViewAdmin.Rows[idx].Cells[3].Value.ToString();
                textBoxAge.Text = dataGridViewAdmin.Rows[idx].Cells[5].Value.ToString();
                textBoxAddress.Text = dataGridViewAdmin.Rows[idx].Cells[6].Value.ToString();
                textBoxPhn.Text = dataGridViewAdmin.Rows[idx].Cells[7].Value.ToString();
                textBoxSalary.Text = dataGridViewAdmin.Rows[idx].Cells[8].Value.ToString();

            }
        }
        private void makeEmpty()
        {
            //make the text boxes and others empty
            textBoxName.Text = "";
            textBoxUserName.Text = "";
            textBoxAge.Text = "";
            textBoxAddress.Text = "";
            textBoxPhn.Text = "";
            textBoxSalary.Text = "";
            id = "";
            password = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            makeEmpty();
        }
    }
}
