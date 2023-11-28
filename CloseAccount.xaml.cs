using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
    /// Interaction logic for CloseAccount.xaml
    /// </summary>
    public partial class CloseAccount : Window
    {

        AccountManager accountManager;
        User user;
        BankWindow bankwindow;
        List<Account> accounts;
        List<string> CloseAccountList = new List<string>();
        public CloseAccount(BankWindow bankWindow, User user)
        {
            InitializeComponent();
            this.user = user;
            this.bankwindow = bankWindow;
            this.accountManager = new AccountManager(bankWindow);
            ListAccounts();
        }
        private void ListAccounts()
        {
            accounts = accountManager.GetAccounts(user.UserId);
            if (accounts.Count > 1)
            {
                this.Show();
                foreach (Account account in accounts)
                {
                    CloseAccountList.Add(account.AccountNumber + "\t" + account.AccountName);
                }
                AccountListBoxCloseAccount.ItemsSource = CloseAccountList;
                AccountListBoxCloseAccount.Items.Refresh();
            }
            else 
            { 
                MessageBox.Show("Du behöver ha kvar minst ett konto");
                this.Close();
                bankwindow.Show();
            }

        }
        
        private void closeAccountButton_Click(object sender, RoutedEventArgs e)
        {
            object selectedItem = (object)AccountListBoxCloseAccount.SelectedItem;
          
            if (selectedItem != null)
            {
                for (int i = 0; i < accounts.Count; i++)
                {
                    bool emptyAccount = accountManager.CheckAccountBalance(accounts[i]);
                    int accountnumber = accounts[i].AccountNumber;
                    string nummer = accountnumber.ToString();
                    if (selectedItem.Equals(nummer + "\t" + accounts[i].AccountName))
                    {
                        if(emptyAccount)
                        {
                            accountManager.RemoveAccountFromUser(accounts[i].AccountUserId, accounts[i].AccountNumber);
                            break;
                        }
                        else
                        {
                            MessageBox.Show("There is money on this account the balance needs to be 0 to close account");
                        }
                        
                    }
                    
                }
               
            }
            this.Close();
            bankwindow.ListAccounts(user);
            bankwindow.Show();
            
        }

        private void cancelCloseAccountButton_Click_1(object sender, RoutedEventArgs e)
        {
            bankwindow.Show();
            this.Close();
        }
    } 
}
