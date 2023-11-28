using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BankAppWPF
{
    /// <summary>
    /// Interaction logic for wihtdrawWindow.xaml
    /// </summary>
    public partial class wihtdrawWindow : Window
    {
        AccountManager accountManager;
        BankWindow bankWindow;
        User user;
        List<Account> accounts;
        public wihtdrawWindow(BankWindow bankWindow, User user)
        {
            InitializeComponent();
            this.bankWindow = bankWindow;
            this.user = user;
            this.accountManager = new AccountManager(bankWindow);
            ListAccounts(user);
        }
        public void ListAccounts(User user)
        {
            accounts = accountManager.GetAccounts(user.UserId);
            List<string> accountNumbers = new List<string>();
            List<string> accountNames = new List<string>();
            List<string> accountBalances = new List<string>();

            for (int i = 0; i < accounts.Count; i++)
            {
                string accountNumber = accounts[i].AccountNumber.ToString();
                accountNumbers.Add(accountNumber);
                accountNames.Add(accounts[i].AccountName);
                string accountBalance = accounts[i].Balance.ToString();
                accountBalances.Add(accountBalance);

            }
            AccountListBox.ItemsSource = accountNumbers;
            AccountListBox.Items.Refresh();
            AccountNameListBox.ItemsSource = accountNames;
            AccountNameListBox.Items.Refresh();
            BalanceListBox.ItemsSource = accountBalances;
            BalanceListBox.Items.Refresh();
        }

        private void AccountNameListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = (object)AccountNameListBox.SelectedItem;
            if (selectedItem != null)
            {
                for (int i = 0; i < accounts.Count; i++)
                {
                    if (selectedItem.Equals(accounts[i].AccountName))
                    {
                        accountNameTextBlock.Text = accounts[i].AccountName;

                        break;
                    }
                }
            }
        }
    
        private void cancelWithdrawButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            bankWindow.Show();
        }

        private void makeWithdrawButton_Click(object sender, RoutedEventArgs e)
        {

            object selectedItem = (object)AccountNameListBox.SelectedItem;

            if (selectedItem != null)
            {
                for (int i = 0; i < accounts.Count; i++)
                {
                    if (selectedItem.Equals(accounts[i].AccountName))
                    {
                        bool numbers = false;
                        while (!numbers)
                        {
                            try
                            {
                                accountNameTextBlock.Text = accounts[i].AccountName;
                                int sumToWithdraw = int.Parse(sumToWithdrawTextBox.Text);
                           
                                while (!accountManager.EnoughMoney(accounts[i].Balance, sumToWithdraw))
                                {
                                    MessageBox.Show("Not enough money in the account");
                                    sumToWithdraw = 0;
                                }
                                int newBalance = accounts[i].Balance - sumToWithdraw;
                                accounts[i].Balance = newBalance;
                            }
                            catch { MessageBox.Show("The sum to withdraw needs to bee numbers"); }
                            break;
                        }
                    }
                }
            }
            string accountFilePath = "UserAccounts/" + user.UserId + ".csv";
            File.Delete("UserAccounts/" + user.UserId + ".csv");
            foreach (Account account in accounts)
            {
                accountManager.RegisterNewAccount(account, user.UserId);
            }
            this.Close();
            bankWindow.ListAccounts(user);
            bankWindow.Show();
        }
    }
}
