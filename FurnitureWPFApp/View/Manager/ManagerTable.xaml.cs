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

namespace FurnitureWPFApp.View.Manager
{
    public partial class ManagerTable : Window
    {
        public ManagerTable()
        {
            InitializeComponent();
        }

        DBContext dBContext = new DBContext();
        public void TableBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (TableBox.SelectedIndex)
            {
                case 0:
                    dataGrid.ItemsSource = dBContext.GetAssemblyUnitSpecification();
                    break;
                case 1:
                    dataGrid.ItemsSource = dBContext.GetEquipment();
                    break;
                case 2:
                    dataGrid.ItemsSource = dBContext.GetEquipmentType();
                    break;
                case 3:
                    dataGrid.ItemsSource = dBContext.GetFurniture();
                    break;
                case 4:
                    dataGrid.ItemsSource = dBContext.GetMaterial();
                    break;
                case 5:
                    dataGrid.ItemsSource = dBContext.GetMaterialSpecification();
                    break;
                case 6:
                    dataGrid.ItemsSource = dBContext.GetOperationSpecification();
                    break;
                case 7:
                    dataGrid.ItemsSource = dBContext.GetOrder();
                    break;
                case 8:
                    dataGrid.ItemsSource = dBContext.GetProduct();
                    break;
                case 9:
                    dataGrid.ItemsSource = dBContext.GetSpecificationFurniture();
                    break;
                case 10:
                    dataGrid.ItemsSource = dBContext.GetSupplier();
                    break;
                case 11:
                    dataGrid.ItemsSource = dBContext.GetUser();
                    break;
            }
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            DirectorForm directorForm = new DirectorForm();
            directorForm.Show();
        }

        private void RefreshBT_Click(object sender, RoutedEventArgs e)
        {
            switch (TableBox.SelectedIndex)
            {
                case 0:
                    dataGrid.ItemsSource = dBContext.GetAssemblyUnitSpecification();
                    break;
                case 1:
                    dataGrid.ItemsSource = dBContext.GetEquipment();
                    break;
                case 2:
                    dataGrid.ItemsSource = dBContext.GetEquipmentType();
                    break;
                case 3:
                    dataGrid.ItemsSource = dBContext.GetFurniture();
                    break;
                case 4:
                    dataGrid.ItemsSource = dBContext.GetMaterial();
                    break;
                case 5:
                    dataGrid.ItemsSource = dBContext.GetMaterialSpecification();
                    break;
                case 6:
                    dataGrid.ItemsSource = dBContext.GetOperationSpecification();
                    break;
                case 7:
                    dataGrid.ItemsSource = dBContext.GetOrder();
                    break;
                case 8:
                    dataGrid.ItemsSource = dBContext.GetProduct();
                    break;
                case 9:
                    dataGrid.ItemsSource = dBContext.GetSpecificationFurniture();
                    break;
                case 10:
                    dataGrid.ItemsSource = dBContext.GetSupplier();
                    break;
                case 11:
                    dataGrid.ItemsSource = dBContext.GetUser();
                    break;
            }
        }
    }
}
