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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        Praktika4Entities content = new Praktika4Entities();
        public Window3()
        {
            InitializeComponent();
            TableWindow.ItemsSource = content.Purchases.ToList();
            StoreNameComboBox.ItemsSource = content.Store.ToList();
            StoreNameComboBox.DisplayMemberPath = "StoreName";
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }
        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            TableWindow.ItemsSource = content.Purchases.ToList();
        }

        private void StoreNameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StoreNameComboBox.SelectedItem != null)
            {
                var select = StoreNameComboBox.SelectedItem as Store;
                TableWindow.ItemsSource = content.Purchases.ToList().Where(item => item.Store_ID == select.ID_Store);
            }
        }
    }
}
