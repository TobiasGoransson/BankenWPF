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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankAppWPF
{
    /// <summary>
    /// Interaction logic for EditUserInfo.xaml
    /// </summary>
    public partial class EditUserInfo : UserControl
    {
        BankWindow bankWindow;
        User user;
        UserManager userManager = new UserManager();
        List<User> users;
        public EditUserInfo(BankWindow bankWindow, User user)
        {
            InitializeComponent();
            this.bankWindow = bankWindow;
            this.user = user;
            
        }
        public void GetUserInfoEdit(User user)
        {
            users = userManager.CreateUserList();
            foreach (User user1 in users)
            {
                if (user1.UserId == user.UserId)
                {
                    contEdituserIDTextBlock.Text = user1.UserId;
                    contEditfristNameTextBox.Text = user1.FirstName;
                    contEditlastNameTextBox.Text = user1.LastName;
                    contEditemailTextBox.Text = user1.Email;
                    contEditadressTextBox.Text = user1.Adress;
                }
            }
        }

        private void saveEditedUserButton_Click(object sender, RoutedEventArgs e)
        {
            EditUser();
            
            bankWindow.HideTextblockUserInfo();
            users = userManager.CreateUserList();
            foreach (User user1 in users)
            {
                if (user1.UserId == user.UserId)
                {
                    ShowUserInfo showUserInfo = new ShowUserInfo();
                    bankWindow.ShowTextblockUserInfo();
                    showUserInfo.GetUserInfo(user);
                    bankWindow.userControlContainer.Content = showUserInfo;
                    break;
                }
            }
        }
        public void EditUser()
        { 
            string UserId = contEdituserIDTextBlock.Text;
            string FirstName = contEditfristNameTextBox.Text;
            string LastName = contEditlastNameTextBox.Text;
            string Email = contEditemailTextBox.Text;
            string Adress = contEditadressTextBox.Text;

            userManager.DeleteUsersFile();
         
            foreach (User user1 in users)
            {
                if (user1.UserId == UserId)
                {
                    user1.FirstName = FirstName;
                    user1.LastName = LastName;
                    user1.Email = Email;
                    user1.Adress = Adress;
                }
                userManager.RegisterNewUser(user1);
            }
        }

        private void canselEditButton_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility=Visibility.Hidden;
            bankWindow.HideTextblockUserInfo();
        }
    }
}