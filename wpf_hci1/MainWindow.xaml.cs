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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_hci1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UnosAkcija(object sender, RoutedEventArgs e)
        {
            var v = new Resource();
            v.Show();
        }

        private void TypeAction(object sender, RoutedEventArgs e)
        {
            var v = new ResourceType();
            v.Show();
        }

        private void LabelAction(object sender, RoutedEventArgs e)
        {
            var v = new Label();
            v.Show();
        }
    }
}
