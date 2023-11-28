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
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : UserControl
    {
        UserManager userManager = new UserManager();
        List<User> users;
        MainWindow mainWindow;
        User user { get; set; }

        public LogIn(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }


        public User CheckLoggIn()
        {
            users = userManager.CreateUserList();
            foreach (User user in users)
            {
                if (UserIdBox.Text == user.UserId && PasswordTextBox.Text == user.Password)
                {
                    return user;
                    break;
                }
            }
            return null;
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            User user = CheckLoggIn();
            if (user == null)
            {
                MessageBox.Show("Invali UserId / Password");
                PasswordTextBox.Clear();
            }
            else
            {
                UserIdBox.Clear();
                PasswordTextBox.Clear();
                mainWindow.Hide();
                BankWindow bankWindow = new BankWindow(user);
                bankWindow.Show();
                bankWindow.UserFirstName.Text = user.FirstName;
                bankWindow.ListAccounts(user);
            }
        }

        private void registerNewUserButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.GoTORegisterUser();
        }
    }
}