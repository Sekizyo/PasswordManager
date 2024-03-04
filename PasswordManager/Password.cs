namespace PasswordManager
{
    public class Password
    {
        public string Name { get; set; }
        public string Passwd { get; set; }

        public Password(string name, string passwd)
        {
            Name = name;
            Passwd = passwd;
        }
    }
}
