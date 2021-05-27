using FurnitureWPFApp.Controller;
using FurnitureWPFApp.View.Director;
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
    public partial class AssemblyUnitSpecificationAddForm : Window
    {
        DBContext dBContext = new DBContext();

        public AssemblyUnitSpecificationAddForm()
        {
            InitializeComponent();
            DataTable equipmentType = dBContext.GetTable("Product");
            for (int i = 0; i < equipmentType.Rows.Count; i++)
            {
                ProductCB.Items.Add(equipmentType.Rows[i][0]);
            }
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            List<string> textBoxes = new List<string>(){
                ProductCB.Text,
                AssemblyUnitSpecificationTB.Text,
                QuantityTB.Text
            };

            int added = dBContext.AddRow("AssemblyUnitSpecification", textBoxes);
            if (added == 1)
            {
                MessageBox.Show("Успешно!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Произошла ошибка.");
                this.Close();
            }
        }

        private void Quantity_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }
    }
}
