using System.Data;
using Npgsql;
using System.Windows.Forms;


namespace wise_waste
{
    public class Registration
    {
        private int _regID;    private string email;
        private string firstName;
        private string lastName;
        private string password;
        //private DateTime registerDate;
        public int regID
        {
            get { return _regID; }
            set { _regID = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        //public DateTime RegisterDate
        //{
           // set { registerDate = value; }
        //}

        // define constructor
        public Registration(string email, string firstName, string lastName, string password) //DateTime registerDate)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            //RegisterDate = registerDate;
        }

        public bool Register()
        {
            // suppose the registration are successfull
            return true;
        }
    }
}
