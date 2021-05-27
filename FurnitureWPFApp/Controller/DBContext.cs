using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using FurnitureWPFApp.Classes;
using FurnitureWPFApp.View.Add;
using FurnitureWPFApp.View.Director;
using MySql.Data.MySqlClient;
using Image = System.Drawing.Image;

namespace FurnitureWPFApp.Controller
{
    public class DBContext
    {
        public MySqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }

        public DataTable Authorize(string query)
        {
            MySqlConnection connection = GetConnection();
            DataTable dt_user = new DataTable();
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dt_user);
                return dt_user;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Register(string query)
        {
            MySqlConnection connection = GetConnection();
            bool added = false;
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                int inserted = command.ExecuteNonQuery();
                added = inserted == 1 ? added = true : added = false;
                return added;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                added = false;
                return added;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable GetTable(string table)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection connection = GetConnection();
            try
            {
                connection.Open();
                Console.WriteLine("SELECT * from " + table);
                MySqlCommand command = new MySqlCommand("SELECT * from " + table, connection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }



        public List<AssemblyUnitSpecification> GetAssemblyUnitSpecification()
        {
            List<AssemblyUnitSpecification> assemblyUnitSpecifications = new List<AssemblyUnitSpecification>();
            DataTable dataTable = GetTable("AssemblyUnitSpecification");
            try
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    assemblyUnitSpecifications.Add(new AssemblyUnitSpecification
                    {
                        Product = (string)dataTable.Rows[i][0],
                        AssemblyUnitSpecificationType = (string)dataTable.Rows[i][1],
                        Quantity = (int)dataTable.Rows[i][2]
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return assemblyUnitSpecifications;
        }
        
        public List<Equipment> GetEquipment()
        {
            List<Equipment> equipments = new List<Equipment>();
            DataTable dataTable = GetTable("equipment");
            try
            {
                for(int i = 0; i < dataTable.Rows.Count; i++)
                {
                    equipments.Add(new Equipment
                    {
                        Marking = (string)dataTable.Rows[i][0],
                        EquipmentType = (string)dataTable.Rows[i][1],
                        Characteristics = (string)dataTable.Rows[i][2]
                    });
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return equipments;
        }

        public List<EquipmentType> GetEquipmentType()
        {
            List<EquipmentType> equipmentTypes = new List<EquipmentType>();
            DataTable dataTable = GetTable("EquipmentType");
            try
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    equipmentTypes.Add(new EquipmentType
                    {
                        TypeOfEquipment = (string)dataTable.Rows[i][0],
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return equipmentTypes;
        }

        public List<Furniture> GetFurniture()
        {
            List<Furniture> furnitures = new List<Furniture>();
            DataTable dataTable = GetTable("Furniture");
            try
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    furnitures.Add(new Furniture
                    {
                        VendorCode = (int)dataTable.Rows[i][0],
                        Name = (string)dataTable.Rows[i][1],
                        Unit = (string)dataTable.Rows[i][2],
                        Quantity = (int)dataTable.Rows[i][3],
                        MainSupplier = (string)dataTable.Rows[i][4],
                        Image = (string)dataTable.Rows[i][5],
                        AccessoriesType = (string)dataTable.Rows[i][6],
                        Price = (decimal)dataTable.Rows[i][7],   
                        Weight = (decimal)dataTable.Rows[i][8]
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return furnitures;
        }

        public List<Material> GetMaterial()
        {
            List<Material> materials = new List<Material>();
            DataTable dataTable = GetTable("Material");
            try
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    materials.Add(new Material
                    {
                        VendorCode = (string)dataTable.Rows[i][0],
                        Name = (string)dataTable.Rows[i][1],
                        Unit = (string)dataTable.Rows[i][2],
                        Length = (decimal)dataTable.Rows[i][3],
                        Quantity = (int)dataTable.Rows[i][4],
                        MaterialType = (string)dataTable.Rows[i][5],
                        Price = (decimal)dataTable.Rows[i][6],
                        Gost = (string)dataTable.Rows[i][7],
                        MainSupplier = (string)dataTable.Rows[i][8],
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return materials;
        }

        public List<MaterialSpecification> GetMaterialSpecification()
        {
            List<MaterialSpecification> materialSpecifications = new List<MaterialSpecification>();
            DataTable dataTable = GetTable("MaterialSpecification");
            try
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    materialSpecifications.Add(new MaterialSpecification
                    {
                        Product = (string)dataTable.Rows[i][0],
                        Material = (string)dataTable.Rows[i][1],
                        Quantity = (int)dataTable.Rows[i][2]
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return materialSpecifications;
        }

        public List<OperationSpecification> GetOperationSpecification()
        {
            List<OperationSpecification> operationSpecifications = new List<OperationSpecification>();
            DataTable dataTable = GetTable("OperationSpecification");
            try
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    operationSpecifications.Add(new OperationSpecification
                    {
                        Product = (string)dataTable.Rows[i][0],
                        Operation = (string)dataTable.Rows[i][1],
                        SerialNumber = (int)dataTable.Rows[i][2],
                        EquipmentType = (string)dataTable.Rows[i][3],
                        OperationTime = (string)dataTable.Rows[i][4],
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return operationSpecifications;
        }

        public List<Order> GetOrder()
        {
            List<Order> orders = new List<Order>();
            DataTable dataTable = GetTable("Booking");
            try
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    orders.Add(new Order
                    {
                        Number = (int)dataTable.Rows[i][0],
                        Date = (DateTime)dataTable.Rows[i][1],
                        OrderName = (string)dataTable.Rows[i][2],
                        Product = (string)dataTable.Rows[i][3],
                        Customer = (string)dataTable.Rows[i][4],
                        ResponsibleManager = (string)dataTable.Rows[i][5],
                        Price = (decimal)dataTable.Rows[i][6],
                        PlannedCompletionDate = (DateTime)dataTable.Rows[i][7],
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return orders;
        }

        public List<Product> GetProduct()
        {
            List<Product> products = new List<Product>();
            DataTable dataTable = GetTable("product");
            try
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    products.Add(new Product
                    {
                        Name = (string)dataTable.Rows[i][0].ToString(),
                        Dimensions = (string)dataTable.Rows[i][1].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return products;
        }

        public List<SpecificationFurniture> GetSpecificationFurniture()
        {
            List<SpecificationFurniture> specificationFurnitures = new List<SpecificationFurniture>();
            DataTable dataTable = GetTable("SpecificationFurniture");
            try
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    specificationFurnitures.Add(new SpecificationFurniture
                    {
                        Product = (string)dataTable.Rows[i][0],
                        Furniture = (string)dataTable.Rows[i][1],
                        Quantity = (int)dataTable.Rows[i][2]
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return specificationFurnitures;
        }

        public List<Supplier> GetSupplier()
        {
            List<Supplier> suppliers = new List<Supplier>();
            DataTable dataTable = GetTable("Supplier");
            try
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    suppliers.Add(new Supplier
                    {
                        Name = (string)dataTable.Rows[i][0],
                        Adress = (string)dataTable.Rows[i][1],
                        DeliveryPeriod = (DateTime)dataTable.Rows[i][2]
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return suppliers;
        }

        public List<User> GetUser()
        {
            List<User> users = new List<User>();
            DataTable dataTable = GetTable("User");
            try
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    users.Add(new User
                    {
                        LastName = (string)dataTable.Rows[i][0],
                        FirstName = (string)dataTable.Rows[i][1],
                        Login = (string)dataTable.Rows[i][2],
                        Password = (string)dataTable.Rows[i][3],
                        Role = (string)dataTable.Rows[i][4]
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return users;
        }



        public int AddRow(string table, List<string> values)
        {
            DataTable dataTable = GetTable(table);
            MySqlConnection connection = GetConnection();
            DataColumnCollection columns = dataTable.Columns;
            int added = 0;
            try
            {
                connection.Open();
                string columnString = "";
                int i = 0;
                string valueString = "";
                int v = 0;
                foreach (var column in columns)
                {
                    columnString += i != columns.Count - 1 ? column.ToString() + ", " : column.ToString();
                    i++;
                }
                foreach (var value in values)
                {
                    valueString += v != values.Count - 1 ? "'" + value + "', " : "'" + value + "'";
                    v++;
                }
                Console.WriteLine("INSERT INTO " + table + " (" + columnString + ") VALUES (" + valueString + ")");
                MySqlCommand command = new MySqlCommand("INSERT INTO " + table + " (" + columnString + ") VALUES (" + valueString + ")", connection);
                added = command.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return added;
        }

        public void DeleteRow(string table, List<string> values)
        {
            DataTable dataTable = GetTable(table);
            MySqlConnection connection = GetConnection();
            DataColumnCollection columns = dataTable.Columns;
            string query = "";
            for(int i = 0; i < columns.Count; i++)
            {
                query += i != values.Count - 1 ? columns[i] + " = '" + values[i] + "' AND " : columns[i] + " = '" + values[i] + "'";
            }
            try
            {
                connection.Open();
                Console.WriteLine("DELETE FROM " + table + " WHERE " + query);
                MySqlCommand command = new MySqlCommand("DELETE FROM " + table + " WHERE " + query, connection);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void ShowAddForm(int index)
        {
            switch(index)
            {
                case 0:
                    AssemblyUnitSpecificationAddForm assemblyUnitSpecificationAddForm = new AssemblyUnitSpecificationAddForm();
                    assemblyUnitSpecificationAddForm.Show();
                    break;
                case 1:
                    EquipmentAddForm equipmentAddForm = new EquipmentAddForm();
                    equipmentAddForm.Show();
                    break;
                case 2:
                    EquipmentTypeAddForm equipmentTypeAddForm = new EquipmentTypeAddForm();
                    equipmentTypeAddForm.Show();
                    break;
                case 3:
                    FurnitureAddForm furnitureAddForm = new FurnitureAddForm();
                    furnitureAddForm.Show();
                    break;
                case 4:
                    MaterialAddForm materialAddForm = new MaterialAddForm();
                    materialAddForm.Show();
                    break;
                case 5:
                    MaterialSpecificationAddForm materialSpecificationForm = new MaterialSpecificationAddForm();
                    materialSpecificationForm.Show();
                    break;
                case 6:
                    OperationSpecificationAddForm operationSpecificationForm = new OperationSpecificationAddForm();
                    operationSpecificationForm.Show();
                    break;
                case 7:
                    OrderAddForm orderAddForm = new OrderAddForm();
                    orderAddForm.Show();
                    break;
                case 8:
                    ProductAddForm productAddForm = new ProductAddForm();
                    productAddForm.Show();
                    break;
                case 9:
                    SpecificationFurnitureAddForm specificationFurnitureAddForm = new SpecificationFurnitureAddForm();
                    specificationFurnitureAddForm.Show();
                    break;
                case 10:
                    SupplierAddForm supplierAddForm = new SupplierAddForm();
                    supplierAddForm.Show();
                    break;
                case 11:
                    UserAddForm userAddForm = new UserAddForm();
                    userAddForm.Show();
                    break;
            }
        }
    }
}


