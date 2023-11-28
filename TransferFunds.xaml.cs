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
    /// Interaction logic for TransferFunds.xaml
    /// </summary>
    public partial class TransferFunds : Window
    {
        AccountManager accountManager;
        BankWindow bankWindow;
        User user;
        List<Account> accounts;
        public TransferFunds(BankWindow bankWindow, User user)
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
            AccountListBoxFrom.ItemsSource = accountNumbers;
            AccountListBoxFrom.Items.Refresh();
            AccountNameListBoxFrom.ItemsSource = accountNames;
            AccountNameListBoxFrom.Items.Refresh();
            BalanceListBoxFrom.ItemsSource = accountBalances;
            BalanceListBoxFrom.Items.Refresh();
            AccountListBoxTo.ItemsSource = accountNumbers;
            AccountListBoxTo.Items.Refresh();
            AccountNameListBoxTo.ItemsSource = accountNames;
            AccountNameListBoxTo.Items.Refresh();
            BalanceListBoxTo.ItemsSource = accountBalances;
            BalanceListBoxTo.Items.Refresh();
        }

        private void transferFundsButton_Click(object sender, RoutedEventArgs e)
        {
           
            object selectedItem1 = (object)AccountNameListBoxFrom.SelectedItem;
            object selectedItem2 = (object)AccountNameListBoxTo.SelectedItem;

            if (selectedItem1 != null && selectedItem2 != null)
            {
                for (int i = 0; i < accounts.Count; i++)
                {
                    if (selectedItem1.Equals(accounts[i].AccountName))
                    {

                        bool numbers = false;
                        while (!numbers)
                        {
                            try
                            {
                                accountNameTextBlock1.Text = accounts[i].AccountName;
                                int sumToWithdraw = int.Parse(sumToTransferTextBox.Text);

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

                        for (int j = 0; j < accounts.Count; j++)
                        {
                            if (selectedItem2.Equals(accounts[j].AccountName))
                            {

                                accountNameTextBlock2.Text = accounts[j].AccountName;
                                int sumToDeposit = int.Parse(sumToTransferTextBox.Text);
                                int newBalance = accounts[j].Balance + sumToDeposit;
                                accounts[j].Balance = newBalance;
                                break;
                            }
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

        private void AccountNameListBoxFrom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = (object)AccountNameListBoxFrom.SelectedItem;
            if (selectedItem != null)
            {
                for (int i = 0; i < accounts.Count; i++)
                {
                    if (selectedItem.Equals(accounts[i].AccountName))
                    {
                        accountNameTextBlock1.Text = accounts[i].AccountName;

                        break;
                    }
                }

            }
        }
        private void AccountNameListBoxTo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = (object)AccountNameListBoxTo.SelectedItem;
            if (selectedItem != null)
            {
                for (int i = 0; i < accounts.Count; i++)
                {
                    if (selectedItem.Equals(accounts[i].AccountName))
                    {
                        accountNameTextBlock2.Text = accounts[i].AccountName;

                        break;
                    }
                }

            }
        }

        private void cancelTransferButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            bankWindow.Show();
        }
    }
}
