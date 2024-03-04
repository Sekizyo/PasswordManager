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
            writePassword("MASTERPASSWD", password);
        }

        public void writePassword(string name, string password)
        {

            List<Password> data = new List<Password>();
            data.Add(new Password(name, password));

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
    }
}
