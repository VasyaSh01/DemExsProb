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
    public partial class SupplierAddForm : Window
    {
        DBContext dBContext = new DBContext();

        public SupplierAddForm()
        {
            InitializeComponent();
        }

        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            List<string> textBoxes = new List<string>();
            try
            {
                textBoxes.Add(NameTB.Text);
                textBoxes.Add(AdressTB.Text);
                textBoxes.Add(DeliveryPeriodCalendar.SelectedDate.Value.ToString("yyyy/MM/dd"));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            int added = dBContext.AddRow("Supplier", textBoxes);
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
