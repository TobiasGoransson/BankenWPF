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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankAppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserManager userManager = new UserManager();
        LogIn logIn;
        RegisterUser registerUser;
        ConfirmNewUser confirmNewUser;
        
        public MainWindow()
        {
            InitializeComponent();
            
            logIn = new LogIn(this);
            registerUser= new RegisterUser(this);
            confirmNewUser = new ConfirmNewUser(this, registerUser);
            
            GoTOLogIN();
        }
        public void GoTOLogIN()
        {
            userControlContainer.Content = logIn;
        }
        public void GoTORegisterUser()
        {
            userControlContainer.Content = registerUser;
        }
        public void GoTOConfirmNewUser()
        {
            userControlContainer.Content = confirmNewUser;
        }
        public void transferUserData()
        {
            User user = registerUser.EnterUserInfo();
            confirmNewUser.confirmFirstNameTextBlock.Text = user.FirstName;
            confirmNewUser.confirmLastNameTextBlock.Text = user.LastName;
            confirmNewUser.confirmEmailTextBlock.Text = user.Email;
            confirmNewUser.confirmAdressTextBlock.Text = user.Adress;
            confirmNewUser.confirmUserIdTextBlock.Text = user.UserId;
        }
        public void ClerAllFields()
        {
            registerUser.registerFirstNameTextBox.Clear();
            registerUser.registerLastNametextBox.Clear();
            registerUser.registerEmailtextBox.Clear();
            registerUser.registerAdressTextBox.Clear();
            registerUser.registerPersonIdTextBox.Clear();
            registerUser.registerPasswordTextBox.Clear();            
            registerUser.registerVerifyPasswordTextBox.Clear();            
            
        }   
    }       
}           
            
            