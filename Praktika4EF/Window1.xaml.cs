﻿using System;
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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Praktika4Entities content = new Praktika4Entities();
        public Window1()
        {
            InitializeComponent();
            TableWindow.ItemsSource = content.Customers.ToList();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            TableWindow.ItemsSource = content.Customers.ToList().Where(item => item.CustomerName.Contains(SearchText.Text));
        }
    }
}
