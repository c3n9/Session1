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

namespace RegistrationOfAPass.Pages
{
    /// <summary>
    /// Логика взаимодействия для PPass.xaml
    /// </summary>
    public partial class PPass : Page
    {
        public PPass(int mode)
        {
            InitializeComponent();
            CBDepartment.ItemsSource = App.DB.Department.ToList();
            CBFullName.ItemsSource = App.DB.Employee.ToList();
           
        }

        private void BRegister_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BLoadFile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BLoadPicture_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BClear_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
