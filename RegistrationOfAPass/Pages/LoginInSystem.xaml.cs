    using RegistrationOfAPass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace RegistrationOfAPass.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginInSystem.xaml
    /// </summary>
    public partial class LoginInSystem : Page
    {
        public LoginInSystem()
        {
            InitializeComponent();
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            var user = App.DB.User.FirstOrDefault(u => u.Login == TBLogin.Text);
            if (user == null)
            {
                MessageBox.Show("Wrong login");
                return;
            }
            if (user.Password != GetHash(PBPassword.Password))
            {
                MessageBox.Show("Wrong password");
                return;
            }
            App.loggedUser = user;
            NavigationService.Navigate(new Request());
        }

        private void BRegistration_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PRegistration(new User()));
        }

        private string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }

        private void BGuest_Click(object sender, RoutedEventArgs e)
        {
            App.loggedUser = null;
            NavigationService.Navigate(new Request());
        }
    }
}
