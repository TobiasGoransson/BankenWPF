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
    /// Interaction logic for ShowUserInfo.xaml
    /// </summary>
    public partial class ShowUserInfo : UserControl
    {
        public ShowUserInfo()
        {
            InitializeComponent();
        }
        public void GetUserInfo(User user)
        {
            UserManager userManager = new UserManager();
            List<User> users=userManager.CreateUserList();
            foreach (User user1  in users)
            {
                if (user1.UserId == user.UserId)
                {
                    contuserIDTextBlock.Text        = user1.UserId;
                    contfristNameTextBlock.Text     = user1.FirstName;
                    contlastNameTextBlock.Text      = user1.LastName;
                    contemailTextBlock.Text         = user1.Email;
                    contadressTextBlock.Text        = user1.Adress;
                }
            }
        }
    }
}
