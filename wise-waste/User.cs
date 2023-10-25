using System;

namespace wise_waste
{
    public class User
    {
        private string email;
        private string password;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public bool Login(string Email, string Password)
        {
            // suppose we have a dummy data
            if (Email == "user" & Password == "user123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
