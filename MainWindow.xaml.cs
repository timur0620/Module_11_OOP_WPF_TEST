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

namespace Module_11_OOP_WPF_TEST
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Repository data;
        public MainWindow()
        {
            InitializeComponent();
            data = Repository.CreateRepository();
            comboBox.ItemsSource = data.DepartmentDB;
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            comboBox.Items.Refresh();
            llistViewWorkers.Items.Refresh();
        }
        private bool find(Worker arg)
        {
            return arg.DepartmentId == (comboBox.SelectedItem as Department).DepartmentId;
        }

        private void cbSelected(object sender, SelectionChangedEventArgs e)
        {
            llistViewWorkers.ItemsSource = data.WorkerDB.Where(find);
        }
    }
}
