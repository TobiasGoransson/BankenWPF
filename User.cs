using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppWPF
{
    public class User
    {

        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }


        public User(string userId, string password, string fristName, string lastName, string email, string adress)
        {
            UserId = userId;
            FirstName = fristName;
            LastName = lastName;
            Email = email;
            Password = password;
            Adress = adress;
        }
        public string GetCSV()
        {
            return UserId + ";" + Password + ";" + FirstName + ";" + LastName + ";" + Email + ";" + Adress;
        }
    }
}
