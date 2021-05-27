using FurnitureWPFApp.Controller;
using FurnitureWPFApp.View;
using FurnitureWPFApp.View.User;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace FurnitureWPFApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateCaptcha();
        }

        DBContext dBContext = new DBContext();

        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool correct = CheckCaptcha();
            passwordPB.Password = checkBox.IsChecked == true ? passwordPB.Password = passwordTB.Text : passwordPB.Password;
            string authorizeQuery = "SELECT * FROM user WHERE login='" + loginTB.Text + "'AND password='" + passwordPB.Password + "'";
            DataTable dt_user = dBContext.Authorize(authorizeQuery);
            if (dt_user.Rows.Count == 1 && correct == true)
            {
                switch (dt_user.Rows[0][4].ToString().ToLower())
                {
                    case "заказчик":
                        UserForm userForm = new UserForm();
                        userForm.Show();
                        this.Hide();
                        break;
                    case "менеджер":
                        ManagerForm managerForm = new ManagerForm();
                        managerForm.Show();
                        this.Hide();
                        break;
                    case "мастер":
                        MasterForm masterForm = new MasterForm();
                        masterForm.Show();
                        this.Hide();
                        break;
                    case "заместитель директора":
                        DeputyDirectorForm deputyDirectorForm = new DeputyDirectorForm();
                        deputyDirectorForm.Show();
                        this.Hide();
                        break;
                    case "директор":
                        DirectorForm directorForm = new DirectorForm();
                        directorForm.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show($"Unknown role {dt_user.Rows[0][4].ToString().ToLower()}");
                        break;
                }
            }
            else if(correct == true && dt_user.Rows.Count != 1 && passwordPB.Password != "" && loginTB.Text != "")
            {
                MessageBox.Show("Пользователь не найден!");
            }
            else if(passwordPB.Password == "" || loginTB.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
            else if(correct == false && passwordPB.Password != "" && loginTB.Text != "")
            {
                MessageBox.Show("Неверно введена капча!");
            }
        }


        private void RegisterBT_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateCaptcha();
            AnswerTB.Text = "";
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            passwordTB.Text = passwordPB.Password;
            passwordPB.Visibility = Visibility.Collapsed;
            passwordTB.Visibility = Visibility.Visible;
            passwordTB.Focus();
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            passwordPB.Password = passwordTB.Text;
            passwordPB.Visibility = Visibility.Visible;
            passwordTB.Visibility = Visibility.Collapsed;
            passwordPB.Focus();
        }

        private void CreateCaptcha()
        {
            string allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";
            allowchar += "1,2,3,4,5,6,7,8,9,0";
            char[] sep = { ',' };
            string[] array = allowchar.Split(sep);
            string pwd = "";
            string temp = "";
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                temp = array[(random.Next(0, array.Length))];
                pwd += temp;
            }
            CaptchaBox.Text = pwd;
        }

        public bool CheckCaptcha()
        {
            bool checkCaptcha = AnswerTB.Text == CaptchaBox.Text ? true : false;
            return checkCaptcha;
        }

        private void ExitBT_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
