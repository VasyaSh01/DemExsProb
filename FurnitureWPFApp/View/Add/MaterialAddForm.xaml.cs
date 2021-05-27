using FurnitureWPFApp.Controller;
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
using System.Windows.Shapes;

namespace FurnitureWPFApp.View.Add
{
    public partial class MaterialAddForm : Window
    {
        DBContext dBContext = new DBContext();
        public MaterialAddForm()
        {
            InitializeComponent();
            DataTable supplier = dBContext.GetTable("supplier");
            for (int i = 0; i < supplier.Rows.Count; i++)
            {
                MainSupplierCB.Items.Add(supplier.Rows[i][0]);
            }
        }

        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            List<string> textBoxes = new List<string>(){
                VendorCodeTB.Text,
                NameTB.Text,
                UnitTB.Text,
                LengthTB.Text,
                QuantityTB.Text,
                MaterialTypeTB.Text,
                PriceTB.Text,
                GOSTTB.Text,
                MainSupplierCB.Text
            };

            int added = dBContext.AddRow("Material", textBoxes);
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
    }
}
