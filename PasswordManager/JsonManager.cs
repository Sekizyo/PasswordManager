using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace PasswordManager
{
    public partial class JsonManager
    {
        public string jsonPath = "data.json";

        public void initJson()
        {
            if (!File.Exists(jsonPath))
            {
                File.Create(jsonPath).Close();
            }
        }
        public bool checkIfEmpty()
        {
            if (new FileInfo(jsonPath).Length == 0)
            {
                return true;
            }
            return false;
        }

        public void writeMasterPassword(string password)
        {
            writePassword(new Password("MASTERPASSWD", password));
        }

        public void writePassword(Password pass)
        {
            if (pass == null)
            {
                return;
            }

            List<Password> data = getPasswords();
            data.Add(pass);

            string jsonString = JsonSerializer.Serialize(data);
            File.WriteAllText(jsonPath, jsonString);
        }

        public string getMasterPassword()
        {
            List<Password> passwords = getPasswords();
            foreach (Password pass in passwords)
            {
                if (pass.Name == "MASTERPASSWD")
                {
                    return pass.Passwd;
                }
            }

            return null;
        }

        public List<Password> getPasswords()
        {
            string jsonString = File.ReadAllText(jsonPath);
            List<Password> passwords = JsonSerializer.Deserialize<List<Password>>(jsonString);
            return passwords;
        }

        public int getPasswdIndex(Password find)
        {
            int output = -1;
            int i = 0;
            List<Password> passwords = getPasswords();
            foreach (Password passwd in passwords)
            {
                if (passwd.Name == find.Name & passwd.Passwd == find.Passwd)
                {
                    output = i;
                    break;
                }
                i++;
            }

            return output;
        }

        public void editPassword(Password originalPasswd, Password newPasswd)
        {
            int index = getPasswdIndex(originalPasswd);

            deletePassword(index);
            writePassword(newPasswd);

        }

        public void deletePassword(int index)
        {
            List<Password> passwords = getPasswords();
            passwords.RemoveAt(index);
            string jsonString = JsonSerializer.Serialize(passwords);
            File.WriteAllText(jsonPath, jsonString);

        }
    }
}
