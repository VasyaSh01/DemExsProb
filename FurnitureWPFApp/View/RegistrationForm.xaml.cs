using FurnitureWPFApp.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class RegistrationForm : Window
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void BackBt_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            passwordTb.Text = passwordPb.Password;
            passwordPb.Visibility = Visibility.Collapsed;
            passwordTb.Visibility = Visibility.Visible;
            passwordTb.Focus();
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            passwordPb.Password = passwordTb.Text;
            passwordPb.Visibility = Visibility.Visible;
            passwordTb.Visibility = Visibility.Collapsed;
            passwordPb.Focus();
        }

        private void SubmitBt_Click(object sender, RoutedEventArgs e)
        {
            bool emptyFieldError = CheckEmptyFields();
            bool passError = CheckPassword();

            if (emptyFieldError == true)

            {
                MessageBox.Show("Все поля должны быть заполнены!");
                SetFieldsEmpty();
            }

            if(passError == true && emptyFieldError == false)
            {
                MessageBox.Show("Пароль должен состоять из заглавных и строчных букв латинского алфафита, цифр и специальных символов '*&{}|+,', а также повторяющихся символов более 3 раз подряд.");
                SetPasswordFieldEmpty();
            }

            if (emptyFieldError == false && passError == false)
            {
                passwordPb.Password = checkBox.IsChecked == true ? passwordPb.Password = passwordTb.Text : passwordPb.Password; 
                bool added = RegisterUser();
                if(added == true)
                {
                    MainWindow mainWindow = new MainWindow();
                    MessageBox.Show("New user has been added!");
                    SetFieldsEmpty();
                    this.Close();
                    mainWindow.Show();
                }
            }
        }

        private bool RegisterUser()
        {
            bool added = false;
            string registerQuery = "INSERT INTO furnituredb.user (last_name, first_name, login, password, role) " +
                "VALUES ('" + lastNameTb.Text + "', '" + firstNameTb.Text + "', '" + loginTb.Text + "', '" + passwordPb.Password + "', 'Заказчик')";
            DBContext dBContext = new DBContext();
            added = dBContext.Register(registerQuery);
            return added;
        }

        private bool CheckEmptyFields()
        {
            bool error = false;
            string password = checkBox.IsChecked == true ? password = passwordTb.Text : password = passwordPb.Password;
            string[] textboxes = new string[] { lastNameTb.Text, firstNameTb.Text, loginTb.Text, password };
            foreach (var textbox in textboxes)
            {
                error = textbox == "" ? error = true : error = false;
            }
            return error;
        }

        private bool CheckPassword()
        {
            bool error = false;
            string password = checkBox.IsChecked == true ? password = passwordTb.Text : password = passwordPb.Password;
            Regex passwordRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])(?!(.)\1{2})[A-Za-z\d@$!%*?&]{6,18}$");
            Regex repeatingSymbols = new Regex(@"^(.)\1{ 2}");
            error = passwordRegex.IsMatch(password) && !repeatingSymbols.IsMatch(password) == true ? error = false : error = true;
            return error;
        }

        private void SetFieldsEmpty()
        {
            lastNameTb.Text = "";
            firstNameTb.Text = "";
            loginTb.Text = "";
            passwordTb.Text = "";
            passwordPb.Password = "";
            checkBox.IsChecked = false;
        }

        private void SetPasswordFieldEmpty()
        {
            passwordTb.Text = "";
            passwordPb.Password = "";
            checkBox.IsChecked = false;
        }
    }
}
