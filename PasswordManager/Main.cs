using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Main : Form
    {
        public JsonManager json = new JsonManager();
        private List<Password> passwords = null;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loadPasswd();
        }

        private void loadPasswd()
        {
            passwords = json.getPasswords();
            displayPasswd(passwords);

        }

        private void displayPasswd(List<Password> passwords)
        {
            if (passwords == null)
            {
                return;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Password", typeof(string));
            dt.Columns.Add("Edit", typeof(string));
            dt.Columns.Add("Delete", typeof(string));


            int i = 1;
            foreach (Password passwd in passwords)
            {
                dt.Rows.Add(new object[] { i, passwd.Name, passwd.Passwd });
                i++;
            }

            dataGridView1.DataSource = dt;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (textBoxNewName == null ^ textBoxNewPasswd == null)
            {
                return;
            }

            Password passwd = new Password(textBoxNewName.Text, textBoxNewPasswd.Text);
            textBoxNewName.Text = "";
            textBoxNewPasswd.Text = "";
            json.writePassword(passwd);
            loadPasswd();
        }
    }
}
