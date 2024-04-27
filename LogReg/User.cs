namespace LogReg
{
    struct User
    {
        public int id;
        public string username;
        public string email;
        public string password;

        public override string ToString()
        {
            return $"{id} {username} {email}";
        }
    }
}
