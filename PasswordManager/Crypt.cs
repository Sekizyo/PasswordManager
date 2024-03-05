namespace PasswordManager
{
    public class Crypt
    {
        public string encrypt(string input)
        {
            string output = "";
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char cc = c;
                    if (c == 'z') cc = 'a';
                    if (c == 'Z') cc = 'A';
                    output += (char)(((int)cc) + 5);
                }
                else
                {
                    output += c;
                }
            }
            return output;
        }

        public string decrypt(string input)
        {
            string output = "";
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char cc = c;
                    if (c == 'z') cc = 'a';
                    if (c == 'Z') cc = 'A';
                    output += (char)(((int)cc) - 5);
                }
                else
                {
                    output += c;
                }
            }
            return output;
        }
    }
}
