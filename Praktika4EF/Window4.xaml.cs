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

namespace Praktika4EF
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        Praktika4Entities content = new Praktika4Entities();
        public Window4()
        {
            InitializeComponent();
            TableWindow.ItemsSource = content.Store.ToList();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }

        private void SearchStoreNameButton_Click(object sender, RoutedEventArgs e)
        {
            TableWindow.ItemsSource = content.Store.ToList().Where(item => item.StoreName.Contains(SearchTextStoreName.Text));
        }

        private void SearchStoreCityPlace_Click(object sender, RoutedEventArgs e)
        {
            TableWindow.ItemsSource = content.Store.ToList().Where(item => item.StoreCityPlace.Contains(SearchTextStoreCityPlace.Text));
        }
    }
}
