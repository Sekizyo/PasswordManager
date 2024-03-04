using System;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class FirstLogin : Form
    {

        public JsonManager json = new JsonManager();
        public FirstLogin()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (textBoxPassword1.Text != textBoxPassword2.Text)
            {
                MessageBox.Show("Passwords are not identical");
            }

            json.writeMasterPassword(textBoxPassword1.Text);
            Hide();

        }
    }
}
