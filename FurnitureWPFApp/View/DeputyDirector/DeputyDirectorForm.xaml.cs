﻿using FurnitureWPFApp.View.DeputyDirector;
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

namespace FurnitureWPFApp.View
{
    public partial class DeputyDirectorForm : Window
    {
        public DeputyDirectorForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DeputyDirectorTable deputyDirectorTable = new DeputyDirectorTable();
            deputyDirectorTable.Show();
            this.Close();
        }

        private void ExitBT_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}
