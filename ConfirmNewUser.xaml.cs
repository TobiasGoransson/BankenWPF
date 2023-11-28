using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankAppWPF
{
    /// <summary>
    /// Interaction logic for ConfirmNewUser.xaml
    /// </summary>
 
        public partial class ConfirmNewUser : UserControl
        {
            RegisterUser registerUser;
            MainWindow mainWindow;
            UserManager userManager = new UserManager();

            public ConfirmNewUser(MainWindow mainWindow, RegisterUser registerUser )
            {
                InitializeComponent();
                this.mainWindow = mainWindow;
                this.registerUser = registerUser;
            }

            private void confirmButton_Click(object sender, RoutedEventArgs e)
            {
                   
                User user = registerUser.EnterUserInfo();
                BankWindow bankWindow = new BankWindow(user);
                AccountManager accountManager = new AccountManager(bankWindow);
                accountManager.CreateNewAccount(user);
                userManager.RegisterNewUser(user);
                mainWindow.ClerAllFields();
                mainWindow.GoTOLogIN();
            }

            private void backToRegisterPasswordButton_Click(object sender, RoutedEventArgs e)
            {
                mainWindow.GoTORegisterUser ();
            }
        }
    }

