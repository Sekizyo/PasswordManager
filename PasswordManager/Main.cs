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
            passwords = json.getPasswords();
            displayPasswd(passwords);
        }

        private void displayPasswd(List<Password> passwords)
        {
            if (passwords == null)
            {
                return;
            }

            int index = 0;
            foreach (Password password in passwords)
            {

                index++;
            }
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
