using FurnitureWPFApp.Classes;
using FurnitureWPFApp.Controller;
using FurnitureWPFApp.View.Add;
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

namespace FurnitureWPFApp.View.DeputyDirector
{
    public partial class DeputyDirectorTable : Window
    {
        public DeputyDirectorTable()
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

        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            dBContext.ShowAddForm(TableBox.SelectedIndex);
        }

        private void EditBT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (TableBox.SelectedIndex)
                {
                    case 0:
                        var assemblyRow = dataGrid.SelectedItem as AssemblyUnitSpecification;
                        AssemblyUnitSpecificationAddForm assemblyAddForm = new AssemblyUnitSpecificationAddForm();
                        List<string> assemblies = new List<string>()
                    {
                        assemblyRow.Product,
                        assemblyRow.AssemblyUnitSpecificationType,
                        assemblyRow.Quantity.ToString()
                    };
                        assemblyAddForm.Show();
                        assemblyAddForm.ProductCB.Text = assemblyRow.Product;
                        assemblyAddForm.AssemblyUnitSpecificationTB.Text = assemblyRow.AssemblyUnitSpecificationType;
                        assemblyAddForm.QuantityTB.Text = assemblyRow.Quantity.ToString();
                        dBContext.DeleteRow("assemblyunitspecification", assemblies);
                        dataGrid.ItemsSource = dBContext.GetAssemblyUnitSpecification();
                        break;
                    case 1:
                        var equipmentRow = dataGrid.SelectedItem as Equipment;
                        EquipmentAddForm equipmentAddForm = new EquipmentAddForm();
                        List<string> equipments = new List<string>()
                    {
                        equipmentRow.Marking,
                        equipmentRow.EquipmentType,
                        equipmentRow.Characteristics
                    };
                        equipmentAddForm.Show();
                        equipmentAddForm.MarkingTB.Text = equipmentRow.Marking;
                        equipmentAddForm.EquipmentTypeCB.Text = equipmentRow.EquipmentType;
                        equipmentAddForm.CharacteristicTB.Text = equipmentRow.Characteristics;
                        dBContext.DeleteRow("Equipment", equipments);
                        break;
                    case 2:
                        var equipmentTypeRow = dataGrid.SelectedItem as EquipmentType;
                        EquipmentTypeAddForm equipmentTypeAddForm = new EquipmentTypeAddForm();
                        List<string> equipmentTypes = new List<string>()
                    {
                        equipmentTypeRow.TypeOfEquipment,
                    };
                        equipmentTypeAddForm.Show();
                        equipmentTypeAddForm.EquipmentTypeTB.Text = equipmentTypeRow.TypeOfEquipment;
                        dBContext.DeleteRow("EquipmentType", equipmentTypes);
                        break;
                    case 3:
                        var furnitureRow = dataGrid.SelectedItem as Furniture;
                        FurnitureAddForm furnitureAddForm = new FurnitureAddForm();
                        List<string> furnitures = new List<string>()
                    {
                        furnitureRow.VendorCode.ToString(),
                        furnitureRow.Name,
                        furnitureRow.Unit,
                        furnitureRow.Quantity.ToString(),
                        furnitureRow.MainSupplier,
                        furnitureRow.Image,
                        furnitureRow.AccessoriesType,
                        furnitureRow.Price.ToString(),
                        furnitureRow.Weight.ToString()
                    };
                        furnitureAddForm.Show();
                        furnitureAddForm.VendorCodeTB.Text = furnitureRow.VendorCode.ToString();
                        furnitureAddForm.NameTB.Text = furnitureRow.Name;
                        furnitureAddForm.UnitTB.Text = furnitureRow.Unit;
                        furnitureAddForm.QuantityTB.Text = furnitureRow.Quantity.ToString();
                        furnitureAddForm.MainSupplierCB.Text = furnitureRow.MainSupplier;
                        furnitureAddForm.FurnitureImage.Source = null;
                        furnitureAddForm.AccessoriesTypeTB.Text = furnitureRow.AccessoriesType;
                        furnitureAddForm.PriceTB.Text = furnitureRow.Price.ToString();
                        furnitureAddForm.WeightTB.Text = furnitureRow.Weight.ToString();
                        dBContext.DeleteRow("furniture", furnitures);
                        break;
                    case 4:
                        var materialRow = dataGrid.SelectedItem as Material;
                        MaterialAddForm materialAddForm = new MaterialAddForm();
                        List<string> materials = new List<string>()
                    {
                        materialRow.VendorCode.ToString(),
                        materialRow.Name,
                        materialRow.Unit,
                        materialRow.Length.ToString(),
                        materialRow.Quantity.ToString(),
                        materialRow.MaterialType,
                        materialRow.Price.ToString(),
                        materialRow.Gost,
                        materialRow.MainSupplier
                    };
                        materialAddForm.Show();
                        materialAddForm.VendorCodeTB.Text = materialRow.VendorCode.ToString();
                        materialAddForm.NameTB.Text = materialRow.Name;
                        materialAddForm.UnitTB.Text = materialRow.Unit;
                        materialAddForm.LengthTB.Text = materialRow.Length.ToString();
                        materialAddForm.QuantityTB.Text = materialRow.Quantity.ToString();
                        materialAddForm.MaterialTypeTB.Text = materialRow.MaterialType;
                        materialAddForm.PriceTB.Text = materialRow.Price.ToString();
                        materialAddForm.GOSTTB.Text = materialRow.Gost;
                        materialAddForm.MainSupplierCB.Text = materialRow.MainSupplier;
                        dBContext.DeleteRow("material", materials);
                        break;
                    case 5:
                        var materialSpecificationRow = dataGrid.SelectedItem as MaterialSpecification;
                        MaterialSpecificationAddForm materialSpecificationAddForm = new MaterialSpecificationAddForm();
                        List<string> materialSpecifications = new List<string>()
                    {
                        materialSpecificationRow.Product,
                        materialSpecificationRow.Material,
                        materialSpecificationRow.Quantity.ToString(),
                    };
                        materialSpecificationAddForm.Show();
                        materialSpecificationAddForm.ProductCB.Text = materialSpecificationRow.Product;
                        materialSpecificationAddForm.MaterialCB.Text = materialSpecificationRow.Material;
                        materialSpecificationAddForm.QuantityTB.Text = materialSpecificationRow.Quantity.ToString();
                        dBContext.DeleteRow("materialSpecification", materialSpecifications);
                        break;
                    case 6:
                        var operationSpecificationRow = dataGrid.SelectedItem as OperationSpecification;
                        OperationSpecificationAddForm operationSpecificationAddForm = new OperationSpecificationAddForm();
                        List<string> operationSpecifications = new List<string>()
                    {
                        operationSpecificationRow.Product,
                        operationSpecificationRow.Operation,
                        operationSpecificationRow.SerialNumber.ToString(),
                        operationSpecificationRow.EquipmentType,
                        operationSpecificationRow.OperationTime
                    };
                        operationSpecificationAddForm.Show();
                        operationSpecificationAddForm.ProductCB.Text = operationSpecificationRow.Product;
                        operationSpecificationAddForm.OperationTB.Text = operationSpecificationRow.Operation;
                        operationSpecificationAddForm.SerialNumberTB.Text = operationSpecificationRow.SerialNumber.ToString();
                        operationSpecificationAddForm.EquipmentTypeTB.Text = operationSpecificationRow.EquipmentType;
                        operationSpecificationAddForm.EquipmentTypeTB.Text = operationSpecificationRow.OperationTime;
                        dBContext.DeleteRow("operationSpecification", operationSpecifications);
                        break;
                    case 7:
                        var orderRow = dataGrid.SelectedItem as Order;
                        OrderAddForm orderAddForm = new OrderAddForm();
                        List<string> orders = new List<string>()
                    {
                        orderRow.Number.ToString(),
                        orderRow.Date.ToString(),
                        orderRow.OrderName,
                        orderRow.Product,
                        orderRow.Customer,
                        orderRow.ResponsibleManager,
                        orderRow.Price.ToString(),
                        orderRow.PlannedCompletionDate.ToString(),
                        orderRow.OrderingSchemes
                    };
                        orderAddForm.Show();
                        orderAddForm.NumberTB.Text = orderRow.Number.ToString();
                        orderAddForm.DateCalendar.SelectedDate = null;
                        orderAddForm.OrderNameTB.Text = orderRow.OrderName;
                        orderAddForm.ProductCB.Text = orderRow.Product;
                        orderAddForm.CustomerCB.Text = orderRow.Customer;
                        orderAddForm.ResponsibleManagerCB.Text = orderRow.ResponsibleManager;
                        orderAddForm.PriceTB.Text = orderRow.Price.ToString();
                        orderAddForm.PlannedDateCalendar.SelectedDate = null;
                        orderAddForm.SchemeImage.Source = null;
                        dBContext.DeleteRow("booking", orders);
                        break;
                    case 8:
                        var productRow = dataGrid.SelectedItem as Product;
                        ProductAddForm productAddForm = new ProductAddForm();
                        List<string> products = new List<string>()
                    {
                        productRow.Name,
                        productRow.Dimensions,
                    };
                        productAddForm.Show();
                        productAddForm.NameTB.Text = productRow.Name;
                        productAddForm.DimesionsTB.Text = productRow.Dimensions;
                        dBContext.DeleteRow("product", products);
                        break;
                    case 9:
                        var specificationFurnitureRow = dataGrid.SelectedItem as SpecificationFurniture;
                        SpecificationFurnitureAddForm specificationFurnitureAddForm = new SpecificationFurnitureAddForm();
                        List<string> specificationFurnitures = new List<string>()
                    {
                        specificationFurnitureRow.Product,
                        specificationFurnitureRow.Furniture,
                        specificationFurnitureRow.Quantity.ToString()
                    };
                        specificationFurnitureAddForm.Show();
                        specificationFurnitureAddForm.ProductCB.Text = specificationFurnitureRow.Product;
                        specificationFurnitureAddForm.FurnitureCB.Text = specificationFurnitureRow.Furniture;
                        specificationFurnitureAddForm.QuantityTB.Text = specificationFurnitureRow.Quantity.ToString();
                        dBContext.DeleteRow("specificationFurniture", specificationFurnitures);
                        break;
                    case 10:
                        var supplierRow = dataGrid.SelectedItem as Supplier;
                        SupplierAddForm supplierAddForm = new SupplierAddForm();
                        List<string> suppliers = new List<string>()
                    {
                        supplierRow.Name,
                        supplierRow.Adress,
                        supplierRow.DeliveryPeriod.ToString()
                    };
                        supplierAddForm.Show();
                        supplierAddForm.NameTB.Text = supplierRow.Name;
                        supplierAddForm.AdressTB.Text = supplierRow.Adress;
                        supplierAddForm.DeliveryPeriodCalendar.SelectedDate = null;
                        dBContext.DeleteRow("supplier", suppliers);
                        break;
                    case 11:
                        var userRow = dataGrid.SelectedItem as Classes.User;
                        UserAddForm userAddForm = new UserAddForm();
                        List<string> users = new List<string>()
                    {
                        userRow.LastName,
                        userRow.FirstName,
                        userRow.Login,
                        userRow.Password,
                        userRow.Role
                    };
                        userAddForm.Show();
                        userAddForm.LastNameTB.Text = userRow.LastName;
                        userAddForm.FirstNameTB.Text = userRow.FirstName;
                        userAddForm.LoginTB.Text = userRow.Login;
                        userAddForm.PasswordTB.Text = userRow.Password;
                        userAddForm.RoleCB.Text = userRow.Role;
                        dBContext.DeleteRow("user", users);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Выберите строку!");
            }

        }

        private void DeleteBT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (TableBox.SelectedIndex)
                {
                    case 0:
                        var assemblyRow = dataGrid.SelectedItem as AssemblyUnitSpecification;
                        AssemblyUnitSpecificationAddForm assemblyAddForm = new AssemblyUnitSpecificationAddForm();
                        List<string> assemblies = new List<string>()
                    {
                        assemblyRow.Product,
                        assemblyRow.AssemblyUnitSpecificationType,
                        assemblyRow.Quantity.ToString()
                    };
                        dBContext.DeleteRow("assemblyunitspecification", assemblies);
                        dataGrid.ItemsSource = dBContext.GetAssemblyUnitSpecification();
                        break;
                    case 1:
                        var equipmentRow = dataGrid.SelectedItem as Equipment;
                        EquipmentAddForm equipmentAddForm = new EquipmentAddForm();
                        List<string> equipments = new List<string>()
                    {
                        equipmentRow.Marking,
                        equipmentRow.EquipmentType,
                        equipmentRow.Characteristics
                    };
                        dBContext.DeleteRow("Equipment", equipments);
                        break;
                    case 2:
                        var equipmentTypeRow = dataGrid.SelectedItem as EquipmentType;
                        EquipmentTypeAddForm equipmentTypeAddForm = new EquipmentTypeAddForm();
                        List<string> equipmentTypes = new List<string>()
                    {
                        equipmentTypeRow.TypeOfEquipment,
                    };
                        dBContext.DeleteRow("EquipmentType", equipmentTypes);
                        break;
                    case 3:
                        var furnitureRow = dataGrid.SelectedItem as Furniture;
                        FurnitureAddForm furnitureAddForm = new FurnitureAddForm();
                        List<string> furnitures = new List<string>()
                    {
                        furnitureRow.VendorCode.ToString(),
                        furnitureRow.Name,
                        furnitureRow.Unit,
                        furnitureRow.Quantity.ToString(),
                        furnitureRow.MainSupplier,
                        furnitureRow.Image,
                        furnitureRow.AccessoriesType,
                        furnitureRow.Price.ToString(),
                        furnitureRow.Weight.ToString()
                    };
                        dBContext.DeleteRow("furniture", furnitures);
                        break;
                    case 4:
                        var materialRow = dataGrid.SelectedItem as Material;
                        MaterialAddForm materialAddForm = new MaterialAddForm();
                        List<string> materials = new List<string>()
                    {
                        materialRow.VendorCode.ToString(),
                        materialRow.Name,
                        materialRow.Unit,
                        materialRow.Length.ToString(),
                        materialRow.Quantity.ToString(),
                        materialRow.MaterialType,
                        materialRow.Price.ToString(),
                        materialRow.Gost,
                        materialRow.MainSupplier
                    };
                        dBContext.DeleteRow("material", materials);
                        break;
                    case 5:
                        var materialSpecificationRow = dataGrid.SelectedItem as MaterialSpecification;
                        MaterialSpecificationAddForm materialSpecificationAddForm = new MaterialSpecificationAddForm();
                        List<string> materialSpecifications = new List<string>()
                    {
                        materialSpecificationRow.Product,
                        materialSpecificationRow.Material,
                        materialSpecificationRow.Quantity.ToString(),
                    };
                        dBContext.DeleteRow("materialSpecification", materialSpecifications);
                        break;
                    case 6:
                        var operationSpecificationRow = dataGrid.SelectedItem as OperationSpecification;
                        OperationSpecificationAddForm operationSpecificationAddForm = new OperationSpecificationAddForm();
                        List<string> operationSpecifications = new List<string>()
                    {
                        operationSpecificationRow.Product,
                        operationSpecificationRow.Operation,
                        operationSpecificationRow.SerialNumber.ToString(),
                        operationSpecificationRow.EquipmentType,
                        operationSpecificationRow.OperationTime
                    };
                        dBContext.DeleteRow("operationSpecification", operationSpecifications);
                        break;
                    case 7:
                        var orderRow = dataGrid.SelectedItem as Order;
                        OrderAddForm orderAddForm = new OrderAddForm();
                        List<string> orders = new List<string>()
                    {
                        orderRow.Number.ToString(),
                        orderRow.Date.ToString(),
                        orderRow.OrderName,
                        orderRow.Product,
                        orderRow.Customer,
                        orderRow.ResponsibleManager,
                        orderRow.Price.ToString(),
                        orderRow.PlannedCompletionDate.ToString(),
                        orderRow.OrderingSchemes
                    };
                        dBContext.DeleteRow("booking", orders);
                        break;
                    case 8:
                        var productRow = dataGrid.SelectedItem as Product;
                        ProductAddForm productAddForm = new ProductAddForm();
                        List<string> products = new List<string>()
                    {
                        productRow.Name,
                        productRow.Dimensions,
                    };
                        productAddForm.Show();
                        productAddForm.NameTB.Text = productRow.Name;
                        productAddForm.DimesionsTB.Text = productRow.Dimensions;
                        dBContext.DeleteRow("product", products);
                        break;
                    case 9:
                        var specificationFurnitureRow = dataGrid.SelectedItem as SpecificationFurniture;
                        SpecificationFurnitureAddForm specificationFurnitureAddForm = new SpecificationFurnitureAddForm();
                        List<string> specificationFurnitures = new List<string>()
                    {
                        specificationFurnitureRow.Product,
                        specificationFurnitureRow.Furniture,
                        specificationFurnitureRow.Quantity.ToString()
                    };
                        dBContext.DeleteRow("specificationFurniture", specificationFurnitures);
                        break;
                    case 10:
                        var supplierRow = dataGrid.SelectedItem as Supplier;
                        SupplierAddForm supplierAddForm = new SupplierAddForm();
                        List<string> suppliers = new List<string>()
                    {
                        supplierRow.Name,
                        supplierRow.Adress,
                        supplierRow.DeliveryPeriod.ToString()
                    };
                        dBContext.DeleteRow("supplier", suppliers);
                        break;
                    case 11:
                        var userRow = dataGrid.SelectedItem as Classes.User;
                        UserAddForm userAddForm = new UserAddForm();
                        List<string> users = new List<string>()
                    {
                        userRow.LastName,
                        userRow.FirstName,
                        userRow.Login,
                        userRow.Password,
                        userRow.Role
                    };
                        dBContext.DeleteRow("user", users);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Выберите строку!");
            }
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
