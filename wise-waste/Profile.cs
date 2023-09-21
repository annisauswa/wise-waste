using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wise_waste
{
    public class Profile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; private set; } // Password we set for read-only for security purpose
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        // define constructor
        public Profile(string firstName, string lastName, string email, string password, string address, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public void ShowProfile()
        {
            // we haven't design our UI, so we suppose we just write it onto console
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Password: {Password}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
        }

        public void EditProfile(string newFirstName, string newLastName, string newEmail, string newAddress, string newPhoneNumber)
        {
            // suppose it's only temporary change and haven't connected to our database
            FirstName = newFirstName;
            LastName = newLastName;
            Email = newEmail;
            Address = newAddress;
            PhoneNumber = newPhoneNumber;
        }

        public void DeleteUser()
        {
            // method to delete user that connect to database
        }
    }

}
