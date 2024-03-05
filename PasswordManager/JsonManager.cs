using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace PasswordManager
{
    public partial class JsonManager
    {
        public string jsonPath = "data.json";
        public Crypt crypto = new Crypt();

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
                File.WriteAllText(jsonPath, "[]");
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
            List<Password> hashed = encryptPasswordList(data);

            string jsonString = JsonSerializer.Serialize(hashed);
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
            List<Password> hashed = JsonSerializer.Deserialize<List<Password>>(jsonString);
            return decryptPasswordList(hashed);
        }

        private List<Password> encryptPasswordList(List<Password> passwords)
        {
            List<Password> output = new List<Password>();
            foreach (Password passwd in passwords)
            {
                string password = crypto.encrypt(passwd.Passwd);
                output.Add(new Password(passwd.Name, password));
            }

            return output;

        }
        private List<Password> decryptPasswordList(List<Password> passwords)
        {
            List<Password> output = new List<Password>();
            foreach (Password passwd in passwords)
            {
                string password = crypto.decrypt(passwd.Passwd);
                output.Add(new Password(passwd.Name, password));
            }

            return output;

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


            List<Password> hashed = encryptPasswordList(passwords);
            string jsonString = JsonSerializer.Serialize(hashed);
            File.WriteAllText(jsonPath, jsonString);

        }
    }
}
