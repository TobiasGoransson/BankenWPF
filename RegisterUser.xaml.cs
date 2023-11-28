using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for RegisterUser.xaml
    /// </summary>
    public partial class RegisterUser : UserControl
    {
        UserManager userManager = new UserManager();
        MainWindow mainWindow;
        
        public RegisterUser(MainWindow mainWindow)
        {
            InitializeComponent();
           
            this.mainWindow = mainWindow;
        }
        private void TextBox_PreviewPasswordInput(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string newText = textBox.Text + e.Text;

            if (registerPasswordTextBox.Text == registerVerifyPasswordTextBox.Text)
            {
                e.Handled = true; 
            }
        }
        private void TextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string newText = textBox.Text + e.Text;

            if (!IsValidFormat(newText))
            {
                e.Handled = true; 
            }
        }

       

        public User EnterUserInfo()
        {
           
            string FirstName =  registerFirstNameTextBox.Text;
            string LastName =   registerLastNametextBox.Text;
            string Email =      registerEmailtextBox.Text;
            string Adress =     registerAdressTextBox.Text;
            string UserId =     registerPersonIdTextBox.Text;
            string Password =   registerPasswordTextBox.Text;
           
            
                User user = new User(UserId, Password, FirstName, LastName, Email, Adress);
                return user;

        }

        private void backToLogInButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.GoTOLogIN();
        }
        private bool IsValidFormat(string text)
        {
            // Anpassa detta mönster efter ditt specifika format
            string pattern = @"^\d{8}-\d{4}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(text);
        }
        private bool CheckUserId(string userId)
        {
            if (!IsValidFormat(registerPersonIdTextBox.Text))
            {
                MessageBox.Show("Your user Id needs to have this format YYYYMMDD-****");
               
              return false;
            }
            return true;
        }
        private bool CheckPassword()
        {
            if (registerPasswordTextBox.Text != registerVerifyPasswordTextBox.Text)
            {

                MessageBox.Show("Your Passwords doesnt match");
                return false;
            }
            return true;
        }

        private void nextToRegisterPasswordButton_Click(object sender, RoutedEventArgs e)
        {


            if (CheckUserId(registerPersonIdTextBox.Text) && CheckPassword())
            {
                mainWindow.GoTOConfirmNewUser();
                mainWindow.transferUserData();
            }
            else
            {
                mainWindow.GoTORegisterUser();
            }

        }



        private void registerFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (registerFirstNameTextBox.Text != "")
            {
                txtFirstNamePlaceholder.Visibility = Visibility.Hidden;
            }
            else
            {
                txtFirstNamePlaceholder.Visibility = Visibility.Visible;
            }
        }

        private void registerLastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (registerLastNametextBox.Text != "")
            {
                txtLastNamePlaceholder.Visibility = Visibility.Hidden;
            }
            else
            {
                txtLastNamePlaceholder.Visibility = Visibility.Visible;
            }
        }

        private void registerEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (registerEmailtextBox.Text != "")
            {
                txtEmailPlaceholder.Visibility = Visibility.Hidden;
            }
            else
            {
                txtEmailPlaceholder.Visibility = Visibility.Visible;
            }
        }

        private void registerAdress_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (registerAdressTextBox.Text != "")
            {
                txtAdressPlaceholder.Visibility = Visibility.Hidden;
            }
            else
            {
                txtAdressPlaceholder.Visibility = Visibility.Visible;
            }
        }

        private void registerPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (registerPasswordTextBox.Text != "")
            {
                txtPasswordPlaceholder.Visibility = Visibility.Hidden;
            }
            else
            {
                txtPasswordPlaceholder.Visibility = Visibility.Visible;
            }
        }

        private void registerVerifyPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (registerVerifyPasswordTextBox.Text != "")
            {
                txtVerifyPasswordPlaceholder.Visibility = Visibility.Hidden;
            }
            else
            {
                txtVerifyPasswordPlaceholder.Visibility = Visibility.Visible;
            }
        }

        private void registerPersonId_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (registerPersonIdTextBox.Text != "")
            {
                txtUserIdPlaceholder.Visibility = Visibility.Hidden;
            }
            else
            {
                txtUserIdPlaceholder.Visibility = Visibility.Visible;
            }
        }
    }
}