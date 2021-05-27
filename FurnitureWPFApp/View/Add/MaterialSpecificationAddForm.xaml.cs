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
    public partial class MaterialSpecificationAddForm : Window
    {
        DBContext dBContext = new DBContext();
        public MaterialSpecificationAddForm()
        {
            InitializeComponent();

            DataTable product = dBContext.GetTable("product");

            for (int i = 0; i < product.Rows.Count; i++)
            {
                ProductCB.Items.Add(product.Rows[i][0]);
            }

            DataTable material = dBContext.GetTable("material");

            for (int i = 0; i < material.Rows.Count; i++)
            {
                MaterialCB.Items.Add(material.Rows[i][1]);
            }
        }

        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            List<string> textBoxes = new List<string>(){
                ProductCB.Text,
                MaterialCB.Text,
                QuantityTB.Text
            };

            int added = dBContext.AddRow("MaterialSpecification", textBoxes);
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
