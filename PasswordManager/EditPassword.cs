using System.Windows.Forms;

namespace PasswordManager
{
    public partial class EditPassword : Form
    {
        private Password passOriginal = null;
        public EditPassword(Password pass)
        {
            InitializeComponent();
            passOriginal = pass;
        }

        private void EditPassword_Load(object sender, System.EventArgs e)
        {
            textBoxName.Text = passOriginal.Name;
            textBoxPasswd.Text = passOriginal.Passwd;
        }

        private void btnSubmit_Click(object sender, System.EventArgs e)
        {
            if (textBoxName.Text == null ^ textBoxPasswd.Text == null)
            {
                MessageBox.Show("One or more fields are empty");
            }

            JsonManager json = new JsonManager();

            json.editPassword(passOriginal, new Password(textBoxName.Text, textBoxPasswd.Text));
            Close();

        }
    }
}
