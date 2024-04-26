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
using System.Windows.Shapes;
using Лб4.Model;
using Лб4.ViewModel;

namespace Лб4.View
{
    /// <summary>
    /// Логика взаимодействия для WindowsNewEmployee.xaml
    /// </summary>
    public partial class WindowsNewEmployee : Window
    {
        public WindowsNewEmployee()
        {
            InitializeComponent();
            CbRole.ItemsSource = new RoleViewModel().ListRole;
        }

        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            if (CbRole.SelectedItem == null)
            {
                MessageBox.Show("Нужно выбрать роль!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            DialogResult = true;
        }
        private void tbBirthday_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (tbBirthday.Visibility == Visibility.Hidden)
            {
                ClBirthday.Visibility = Visibility.Visible;
            }
            else
            {
                ClBirthday.Visibility = Visibility.Hidden;
            }
        }

    }
}
