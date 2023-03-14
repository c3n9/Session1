using RegistrationOfAPass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.RightsManagement;
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

namespace RegistrationOfAPass.Pages
{
    /// <summary>
    /// Логика взаимодействия для PRegistration.xaml
    /// </summary>
    public partial class PRegistration : Page
    {
        User contextUser;
        public PRegistration(User user)
        {
            InitializeComponent();
            contextUser = user;
            DataContext = contextUser;
        }

        private void BRegistration_Click(object sender, RoutedEventArgs e)
        {
            string error = "";
            if (contextUser.Password.Length < 8)
            {
                error += "Пароль должен быть не менее 8 символов\n";
            }
            if (contextUser.Password.ToLower() == (contextUser.Password))
            {
                error += "Пароль должен содержать символ верхнего регистра\n";
            }
            if (contextUser.Password.ToUpper() == (contextUser.Password))
            {
                error += "Пароль должен содержать символ нижнего регистра\n";
            }
            bool hasNumber = false;
            foreach(var ch in contextUser.Password)
            {
                hasNumber = Char.IsNumber(ch);
                if(hasNumber == true)
                {
                    break;
                }
            }
            if (Regex.IsMatch(contextUser.Password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$") != true)
            {
                error += "Неверный формат пароля";
            }
            if (!hasNumber)
            {
                error += "Строка не содержит цифры";
            }
            if (String.IsNullOrWhiteSpace(error) != true)
            {
                MessageBox.Show(error);
                return;
            }
            string hashPassword = GetHash(contextUser.Password);
            contextUser.Password = hashPassword;

            App.DB.User.Add(contextUser);
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        private string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }

    }
}
