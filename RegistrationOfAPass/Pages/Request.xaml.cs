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
    /// Логика взаимодействия для Request.xaml
    /// </summary>
    public partial class Request : Page
    {
        public Request()
        {
            InitializeComponent();
        }

        private void Bpersonal_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PPass(1));
        }

        private void BGroup_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PPass(2));
        }
    }
}
