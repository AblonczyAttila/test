﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace AdminPanel
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;

            MainFrame.Navigate(new LoginPage());
        }

        


    }
}