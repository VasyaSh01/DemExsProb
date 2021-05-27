using FurnitureWPFApp.Controller;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
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
    public partial class OrderAddForm : Window
    {
        DBContext dBContext = new DBContext();
        public OrderAddForm()
        {
            InitializeComponent();

            DataTable product = dBContext.GetTable("product");

            for (int i = 0; i < product.Rows.Count; i++)
            {
                ProductCB.Items.Add(product.Rows[i][0]);
            }

            DataTable customer = dBContext.GetTable("user");

            for (int i = 0; i < customer.Rows.Count; i++)
            {
                CustomerCB.Items.Add(customer.Rows[i][2]);
            }

            DataTable responsibleManager = dBContext.GetTable("user WHERE Role='Менеджер'");

            for (int i = 0; i < responsibleManager.Rows.Count; i++)
            {
                ResponsibleManagerCB.Items.Add(responsibleManager.Rows[i][2]);
            }
        }

        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            List<string> textBoxes = new List<string>();

            try
            {
                textBoxes.Add(NumberTB.Text);
                textBoxes.Add(DateCalendar.SelectedDate.Value.ToString("yyyy/MM/dd"));
                textBoxes.Add(OrderNameTB.Text);
                textBoxes.Add(ProductCB.Text);
                textBoxes.Add(CustomerCB.Text);
                textBoxes.Add(ResponsibleManagerCB.Text);
                textBoxes.Add(PriceTB.Text);
                textBoxes.Add(PlannedDateCalendar.SelectedDate.Value.ToString("yyyy/MM/dd"));
                textBoxes.Add(SchemeImage.Source.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            int added = dBContext.AddRow("Booking", textBoxes);
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

        private void Int_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        public void ImageBT_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                SchemeImage.Source = new BitmapImage(fileUri);
            }
        }
    }
}
