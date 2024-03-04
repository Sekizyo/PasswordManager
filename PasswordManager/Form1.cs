using System;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Form1 : Form
    {
        private string masterPasswd = null;
        public JsonManager json = new JsonManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            loadMasterPasswd();

            string password = textBoxPass.Text;
            if (password == masterPasswd)
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
            if (json.checkIfEmpty())
            {
                var firstLoginForm = new FirstLogin();
                firstLoginForm.ShowDialog();
            }

        }

        private void loadMasterPasswd()
        {
            if (masterPasswd == null)
            {
                masterPasswd = json.getMasterPassword();
            }
        }
    }
}
