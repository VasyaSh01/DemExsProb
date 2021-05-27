using FurnitureWPFApp.Controller;
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

namespace FurnitureWPFApp.View.User
{
    public partial class UserTable : Window
    {
        DBContext dBContext = new DBContext();
        public UserTable()
        {
            InitializeComponent();
            dataGrid.ItemsSource = dBContext.GetProduct();
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            UserForm userForm = new UserForm();
            userForm.Show();
        }

        private void RefreshBT_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = dBContext.GetProduct();
        }
    }
}
