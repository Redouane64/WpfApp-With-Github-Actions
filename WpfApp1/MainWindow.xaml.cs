﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp1
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}");
            ((Button)sender).IsEnabled = false;
            await Task.Delay(3000)/*.ConfigureAwait(false)*/;
            ((Button)sender).IsEnabled = true;
            Debug.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
