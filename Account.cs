using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppWPF
{
    public class Account
    {

        public string AccountName { get; set; }
        public int Balance { get; set; }
        public int AccountNumber { get; set; }
        public string AccountUserId { get; set; }


        public Account(string accountUserId, int accountNumber, string accountName, int balance)
        {
            AccountName = accountName;
            Balance = balance;
            AccountNumber = accountNumber;
            AccountUserId = accountUserId;

        }

        public string GetCSV()
        {
            return AccountUserId + ";" + AccountNumber + ";" + AccountName + ";" + Balance;
        }
    }
}
