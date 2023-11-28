using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppWPF
{
    public class UserManager
    {

        
        List<User> users = new List<User>();
        string userFilePath = "Users/users.csv";

        public UserManager()
        {
            
            
        }

        public List<User> CreateUserList()
        {
            using (StreamReader sr = new StreamReader(userFilePath))
            {
                string nextLine = sr.ReadLine();
                while (nextLine != null)
                {
                    string[] variables = nextLine.Split(';');

                    User user = new User(variables[0], variables[1], variables[2], variables[3], variables[4], variables[5]);
                    users.Add(user);
                    nextLine = sr.ReadLine();
                }
            }
            return users;
        }

        public void DeleteUsersFile()
        {
            File.Delete(userFilePath);
        }

        public void RegisterNewUser(User user)
        {
            BankWindow bankWindow =new BankWindow(user);
            AccountManager accountManager = new AccountManager(bankWindow);
            using (StreamWriter sw = File.AppendText(userFilePath))
            {
                sw.WriteLine(user.GetCSV());
            }
        }
    }
}
