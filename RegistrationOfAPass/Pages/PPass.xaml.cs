using Microsoft.Win32;
using RegistrationOfAPass.Model;
using RegistrationOfAPass.Services;
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

namespace RegistrationOfAPass.Pages
{
    /// <summary>
    /// Логика взаимодействия для PPass.xaml
    /// </summary>
    public partial class PPass : Page
    {
        PassGuest contextPassGuest;
        public PPass(int mode)
        {
            InitializeComponent();
            CBDepartment.ItemsSource = App.DB.Department.ToList();
            CBEmployee.ItemsSource = App.DB.Employee.ToList();
            PassGuest pass = new PassGuest();
            contextPassGuest = pass;
            DataContext= contextPassGuest;
            if(mode == 2)
            {
                GGroup.Visibility = Visibility.Visible;
            }
           
        }

        private void BRegister_Click(object sender, RoutedEventArgs e)
        {
            string error = "";
            if (String.IsNullOrWhiteSpace(contextPassGuest.Surname))
            {
                error += "Фамилия - обязательное поле для заполнения\n";
            }
            if (String.IsNullOrWhiteSpace(contextPassGuest.Name))
            {
                error += "Имя - обязательное поле для заполнения\n";
            }
            if (String.IsNullOrWhiteSpace(contextPassGuest.Patromic))
            {
                error += "Отчество - обязательное поле для заполнения\n";
            }
            if (CBDepartment.SelectedItem == null)
            {
                error += "Подразделение - обязательное поле для заполнения\n";
            }
            if (CBEmployee.SelectedItem == null)
            {
                error += "Сотрудник - обязательное поле для заполнения\n";
            }
            if (String.IsNullOrWhiteSpace(error) != true)
            {
                MessageBox.Show(error);
                return;
            }
            contextPassGuest.PassId = 1;
            App.DB.PassGuest.Add(contextPassGuest);
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BLoadFile_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() { Filter = ".pdf | *.pdf" };
            if (dialog.ShowDialog().GetValueOrDefault())
            {

            }
        }

        private void BLoadPicture_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() { Filter = ".png, .jpg, .jpeg| *.png; *.jpg; *.jpeg" };
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                var image = File.ReadAllBytes(dialog.FileName);
                IPhoto.Source = MyTools.BytesTOImage(image);
            }
        }

        private void BClear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
