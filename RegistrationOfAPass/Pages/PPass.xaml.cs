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
        Pass contextPass;
        List<Pass> contextListPass = new List<Pass>();
        bool _isPersonal;
        public PPass(bool isPersonal)
        {
            InitializeComponent();
            _isPersonal = isPersonal;
            CBDepartment.ItemsSource = App.DB.Department.ToList();
            contextPass = new Pass() { PassStatusId = 1, DateStart = DateTime.Now, DateEnd = DateTime.Now, User = App.loggedUser };
            DataContext = contextPass;
            if (_isPersonal)
            {
                SPGroupList.Visibility = Visibility.Collapsed;
                Grid.SetColumnSpan(SPInfoGuest, 2);
                SPInfoGuest.HorizontalAlignment = HorizontalAlignment.Center;

            }
            else
            {
                SPGroupList.Visibility = Visibility.Visible;
            }
            Refresh();
        }

        private bool ValidatePass()
        {
            string error = "";
            if (String.IsNullOrWhiteSpace(contextPass.Surname))
            {
                error += "Фамилия - обязательное поле для заполнения\n";
            }
            if (String.IsNullOrWhiteSpace(contextPass.Name))
            {
                error += "Имя - обязательное поле для заполнения\n";
            }
            if (String.IsNullOrWhiteSpace(contextPass.Patromic))
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
            //ДАТА ДАТА ДАТАДАТАДАТАДАТАДАТАДАТА
            //картинку
            if (String.IsNullOrWhiteSpace(error) != true)
            {
                MessageBox.Show(error);
                return false;
            }
            return true;
        }

        private void AddGuest()
        {
            if (!ValidatePass())
                return;

            contextListPass.Add(contextPass);
            contextPass = new Pass() { PassStatusId = 1, DateStart = DateTime.Now, DateEnd = DateTime.Now, User = App.loggedUser };
            DataContext = contextPass;
            DGGuests.ItemsSource = contextListPass.ToList();

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            var selectedDepartment = CBDepartment.SelectedItem as Department;
            if (selectedDepartment != null)
                CBEmployee.ItemsSource = App.DB.Employee.Where(e => e.DepartmentId == selectedDepartment.Id).ToList();
        }

        private void BRegister_Click(object sender, RoutedEventArgs e)
        {
            if (_isPersonal)
            {
                if (!ValidatePass())
                    return;
                App.DB.Pass.Add(contextPass);
            }
            else
            {
                if (contextListPass.Count != 0)
                    App.DB.Pass.AddRange(contextListPass);
            }
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
                contextPass.Photo = image;
                DataContext = null;
                DataContext = contextPass;
                //IPhoto.Source = MyTools.BytesTOImage(image);
            }
        }

        private void BClear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            AddGuest();
        }

        private void CBDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }
    }
}
