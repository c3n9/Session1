using RegistrationOfAPass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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
            if (String.IsNullOrWhiteSpace(contextUser.FullName))
            {
                error += "Введите ФИО\n";
            }
            if (String.IsNullOrWhiteSpace(contextUser.NumberPhone))
            {
                error += "Введите номер телефона\n";
            }
            if (String.IsNullOrWhiteSpace(contextUser.Email))
            {
                error += "Введите E-mail\n";
            }
            if(contextUser.Birth == null)
            {
                error += "Введите дату рождения\n";
            }
            if (String.IsNullOrWhiteSpace(contextUser.Login))
            {
                error += "Введите логин\n";
            }
            if (String.IsNullOrWhiteSpace(contextUser.Password))
            {
                error += "Введите пароль\n";
            }
            if (String.IsNullOrEmpty(contextUser.Passport))
            {
                error += "Введите серию и номер паспорта\n";
            }
            if(contextUser.Appointment == null)
            {
                error += "Введите назначение\n";
            }
            if(String.IsNullOrWhiteSpace(error) != true)
            {
                MessageBox.Show(error);
                return;
            }

            if (contextUser.Password.Length < 8)
            {
                error += "Пароль должен быть не менее 8 символов";
            }
            if(contextUser.Password.ToLower() == (contextUser.Password))
            {
                error += "Пароль должен содержать символ верхнего регистра";
            }
            if (contextUser.Password.ToUpper() == (contextUser.Password))
            {
                error += "Пароль должен содержать символ нижнего регистра";
            }
            Regex regex = new Regex("@А-яA-z0-9");
            if (regex.IsMatch(contextUser.Password))
            {
                MessageBox.Show("Неверный формат пароля");
            }
            App.DB.User.Add(contextUser);
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
