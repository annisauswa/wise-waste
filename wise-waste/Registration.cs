using System;

namespace wise_waste
{
    public class Registration
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; }

        // define constructor
        public Registration(string email, string firstName, string lastName, string password, DateTime registerDate)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            RegisterDate = registerDate;
        }

        public bool Register()
        {
            // suppose the registration are successfull
            return true;
        }
    }
}
