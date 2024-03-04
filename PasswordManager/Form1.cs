using System;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Form1 : Form
    {
        public JsonManager json = new JsonManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string password = textBoxPass.Text;
            if (password == json.getMasterPassword())
            {
                var mainForm = new Main();
                mainForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Wrong master password");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            json.initJson();
            firstLogin();

        }
        private void firstLogin()
        {
            if (json.checkIfEmpty() == true ^ json.getMasterPassword() == null)
            {
                var firstLoginForm = new FirstLogin();
                firstLoginForm.ShowDialog();
            }

        }
    }
}
