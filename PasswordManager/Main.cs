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
            foreach (Password pass in passwords)
            {
                dt.Rows.Add(new object[] { i, pass.Name, pass.Passwd });
                i++;
            }

            dataGridView1.DataSource = dt;
        }

        private void extendTable()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
