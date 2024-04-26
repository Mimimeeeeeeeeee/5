using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Лб4.Model;
using Лб4.ViewModel;

namespace Лб4.View
{
    /// <summary>
    /// Логика взаимодействия для WindowsRole.xaml
    /// </summary>
    public partial class WindowsRole : Window
    {
        RoleViewModel vmRole;
        public WindowsRole()
        {
            InitializeComponent();
            vmRole = new RoleViewModel();
            DataContext = vmRole;
            lvRole.ItemsSource = vmRole.ListRole;
        }

    }
}
