using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BankAppWPF
{
    public class AccountManager
    {
        string UserId;
        string accountFilePath;
        
        UserManager userManager = new UserManager();
        BankWindow bankWindow;
        public AccountManager(BankWindow bankWindow)
        {
          this.bankWindow = bankWindow;
        }

        public List<Account> GetAccounts(string UserId)
        {
            accountFilePath = "UserAccounts/" + UserId + ".csv";
            List<Account> accounts = new List<Account>();
            using (StreamReader sr = new StreamReader(accountFilePath))
            {

                string nextLine = sr.ReadLine();
                while (nextLine != null)
                {
                    string[] variables = nextLine.Split(';');
                    int accountNumber = int.Parse(variables[1]);
                    int balance = int.Parse(variables[3]);

                    Account account = new Account(variables[0], accountNumber, variables[2], balance);
                    accounts.Add(account);

                    nextLine = sr.ReadLine();
                }

            }
            return accounts;

        }
        public List<Account> GetAllAccounts()
        {
            List<Account> allAccounts = GetAccounts("AllAccountnumbers");
            return allAccounts;
        }

        public int CreateNewAccount(User user)
        {
            List<Account> allAccounts = GetAllAccounts();
            int newaccountNumber = 0;
            for (int i = 0; i < allAccounts.Count; i++)
            {
                if (allAccounts[i] == allAccounts.Last())
                {
                    newaccountNumber = allAccounts[i].AccountNumber;
                    newaccountNumber++;
                }
            }

            Account newAccount = new Account(user.UserId, newaccountNumber, "New Account", 0);
            allAccounts.Add(newAccount);
            RegisterNewAccount(newAccount, "AllAccountnumbers");

            
            List<Account> accounts = new List<Account>();
            accounts.Add(newAccount);
            RegisterNewAccount(newAccount, user.UserId);

            return newaccountNumber;
        }
        public void RegisterNewAccount(Account account, string UserId)
        {
            accountFilePath = "UserAccounts/" + UserId + ".csv";

            using (StreamWriter sw = File.AppendText(accountFilePath))
            {
                sw.WriteLine(account.GetCSV());
            }

        }
        public bool CheckAccountBalance(Account account)
        {
            if (account.Balance > 0)
            {
                
                return false;
            }
            return true;
        }
        public void DeleteFile(string UserId)
        {
            File.Delete(accountFilePath);
        }
        public void RemoveAccountFromUser(string userId, int AccountNumber)
        {
            List<Account> accounts =GetAccounts(userId);
            string accountFilePath = "UserAccounts/" + userId + ".csv";
            File.Delete(accountFilePath);
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].AccountNumber == AccountNumber)
                {
                    accounts.RemoveAt(i);
                    break;
                }

            }
            foreach (Account account in accounts)
            {
                RegisterNewAccount(account, account.AccountUserId);
            }

        }
        public void EditAccountName(int AccountNumber, string AccountName, User user)
        {
            List<Account> userAccounts = new List<Account>();
            string accountFilePath;
            List<Account> allAccounts = GetAllAccounts();
            for (int i = 0; i < allAccounts.Count; i++)
            {
                if (AccountNumber == allAccounts[i].AccountNumber)
                {

                    accountFilePath = "UserAccounts/" + allAccounts[i].AccountUserId + ".csv";
                    userAccounts = GetAccounts(allAccounts[i].AccountUserId);

                    File.Delete(accountFilePath);
                    break;
                }
            }
            foreach (Account account1 in userAccounts)
            {
                if (account1.AccountNumber == AccountNumber)
                {
                    account1.AccountName = AccountName;
                }
            }

            foreach (Account account in userAccounts)
            {
                RegisterNewAccount(account, account.AccountUserId);
            }
            bankWindow.ListAccounts(user);


        }
        public void RemoveAllAccountsFromAUser(User user)
        {
            List<Account> accounts = GetAccounts(user.UserId);

            foreach (Account account in accounts)
            {
                bool emptyAccount = CheckAccountBalance(account);
                if (emptyAccount)
                {
                    RemoveAccountFromUser(account.AccountUserId, account.AccountNumber);

                }
                else
                {
                    MessageBox.Show($"There is money on this account: {account.AccountNumber}, the balance needs to be 0 to close account");
                }
            }
            try
            {
                List<Account> accounts1 = GetAccounts(user.UserId);
            }
            catch
            {
                DeleteFile(user.UserId);
            }

        }
        public void CancelAccount(User user)
        {
            RemoveAllAccountsFromAUser(user);
            List<User> users = userManager.CreateUserList();

            User userToRemove = null;
            foreach (User user1 in users)
            {
                if (user1.UserId == user.UserId)
                {
                    userToRemove = user1;
                    break;
                }
            }

            if (userToRemove != null)
            {
                users.Remove(userToRemove);
            }

            File.Delete("Users/users.csv");
            foreach (User user1 in users)
            {
                userManager.RegisterNewUser(user1);
            }

        }
        public bool EnoughMoney(int balance, int withdrawl)
        {
            if (balance - withdrawl > 0)
            {
                return true;
            }
            return false;
        }
       

    }
}