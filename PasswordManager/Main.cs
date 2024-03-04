using System;
using System.Collections.Generic;
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

            dataGrid.Rows.Clear();
            int i = 1;
            foreach (Password passwd in passwords)
            {

                dataGrid.Rows.Add(new object[] { i, passwd.Name, passwd.Passwd });
                i++;
            }
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

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    json.deletePassword(e.RowIndex);
                    loadPasswd();
                }
            }

        }
    }
}
