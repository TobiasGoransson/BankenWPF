using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
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
    /// Interaction logic for BankWindow.xaml
    /// </summary>
    public partial class BankWindow : Window
    {
        AccountManager accountManager;
        UserManager userManager = new UserManager();
        ShowUserInfo showUserInfo = new ShowUserInfo();
        EditUserInfo editUserInfo;
        MainWindow mainWindow;
    
        User user;
        List<Account> accounts = new List<Account>();
        public BankWindow(User user)
        {
            InitializeComponent();
            accountManager = new AccountManager(this);
            editUserInfo = new EditUserInfo(this,user);
            this.mainWindow = new MainWindow();
            this.user = user;
           
        }
        public void ListAccounts(User user)
        {
            List<Account> accounts = accountManager.GetAccounts(user.UserId);
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
                if (accounts[i].AccountName == "New Account")
                {
                    this.Hide();
                    ChooseAccountNameToChange chooseAccountNameToChange = new ChooseAccountNameToChange(this, user);
                    chooseAccountNameToChange.Show();
                    MessageBox.Show("You need to change account name New account to something else");
                }
            }
            AccountListBox.ItemsSource = accountNumbers;
            AccountListBox.Items.Refresh();
            AccountNameListBox.ItemsSource = accountNames;
            AccountNameListBox.Items.Refresh();
            BalanceListBox.ItemsSource = accountBalances;
            BalanceListBox.Items.Refresh();
        }

        public void HideTextblockUserInfo()
        {
            userIdTextBlock.Visibility = Visibility.Hidden;
            firstNameTextBlock.Visibility = Visibility.Hidden;
            lastNameTextBlock.Visibility = Visibility.Hidden;
            emailTextBlock.Visibility = Visibility.Hidden;
            adressTextBlock.Visibility = Visibility.Hidden;
        }
        public void ShowTextblockUserInfo()
        {
            userIdTextBlock.Visibility = Visibility.Visible;
            firstNameTextBlock.Visibility = Visibility.Visible;
            lastNameTextBlock.Visibility = Visibility.Visible;
            emailTextBlock.Visibility = Visibility.Visible;
            adressTextBlock.Visibility = Visibility.Visible;
        }
        private void MenuItemshowUserInfoMenu_Click(object sender, RoutedEventArgs e)
        {
            ShowTextblockUserInfo();
            showUserInfo.GetUserInfo(user);
            userControlContainer.Content = showUserInfo;
        }

        private void MenuItemchangeUserInfoMenu_Click(object sender, RoutedEventArgs e)
        { 
            ShowTextblockUserInfo();
            editUserInfo.GetUserInfoEdit(user);
            editUserInfo.Visibility = Visibility.Visible;
            userControlContainer.Content = editUserInfo;

        }

        private void MenuItemcloseWholeAccountMenu_Click(object sender, RoutedEventArgs e)
        {
            accountManager.CancelAccount(user);
            this.Close();
            mainWindow.Show();
            mainWindow.GoTOLogIN();
        }

        private void MenuItemexitMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            mainWindow.Show();
            mainWindow.GoTOLogIN();
        }

        private void MenuItemdepositMenu_Click(object sender, RoutedEventArgs e)
        {
            DepositWindow depositWindow = new DepositWindow(this, user);
            depositWindow.Show();
            this.Hide();
        }

        private void MenuItemwithdrawMenu_Click(object sender, RoutedEventArgs e)
        {
            wihtdrawWindow wihtdrawWindow = new wihtdrawWindow(this, user);
            wihtdrawWindow.Show();
            this.Hide();
        }

        private void MenuItemopenNewAccountMenu_Click(object sender, RoutedEventArgs e)
        {
            int accountNumber=accountManager.CreateNewAccount(user);
            ChooseAccountNameToChange chooseAccountNameToChange = new ChooseAccountNameToChange(this, user);
            chooseAccountNameToChange.Show();
            ListAccounts(user);
        }

        private void MenuItemcloseAccountMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            CloseAccount closeAccount = new CloseAccount(this, user);
            
        }


        private void transferMenu_Click(object sender, RoutedEventArgs e)
        {
            TransferFunds transferFunds = new TransferFunds(this, user);
            transferFunds.Show();
        }

        private void editAccountNameMenu_Click(object sender, RoutedEventArgs e)
        {
            ChooseAccountNameToChange chooseAccountNameToChange=new ChooseAccountNameToChange(this, user);
            chooseAccountNameToChange.Show();
        }
    }
}
