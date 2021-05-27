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

namespace FurnitureWPFApp.View.Add
{
    public partial class UserAddForm : Window
    {
        DBContext dBContext = new DBContext();

        public UserAddForm()
        {
            InitializeComponent();
        }

        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            List<string> textBoxes = new List<string>(){
                LastNameTB.Text,
                FirstNameTB.Text,
                LoginTB.Text,
                PasswordTB.Text,
                RoleCB.Text
            };

            int added = dBContext.AddRow("User", textBoxes);
            if (added == 1)
            {
                MessageBox.Show("Запись успешно добавлена.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Произошла ошибка при добавлении записи.");
                this.Close();
            }
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
