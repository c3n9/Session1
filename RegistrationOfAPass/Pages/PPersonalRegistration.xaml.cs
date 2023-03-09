using Microsoft.Win32;
using RegistrationOfAPass.Model;
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
    /// Логика взаимодействия для PersonalRegistration.xaml
    /// </summary>
    public partial class PersonalRegistration : Page
    {
        public PersonalRegistration()
        {
            InitializeComponent();
        }

        private void BLoadFile_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() { Filter = ".pdf | *.pdf" };
        }

        private void BLoadPicture_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() { Filter = ".png,.jpeg,.jpg|*.png; *.jpeg; *.jpg" };
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                var picture = new Pass();
                var image = File.ReadAllBytes(dialog.FileName);
            }
        }

        private void BClear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BRegister_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
