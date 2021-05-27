using FurnitureWPFApp.Classes;
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
    public partial class EquipmentAddForm : Window
    {

        DBContext dBContext = new DBContext();

        public EquipmentAddForm()
        {
            InitializeComponent();
            DataTable equipmentType = dBContext.GetTable("equipmenttype");
            for(int i = 0; i < equipmentType.Rows.Count; i++)
            {
                EquipmentTypeCB.Items.Add(equipmentType.Rows[i][0]);
            }
        }

        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            List<string> textBoxes = new List<string>(){
                MarkingTB.Text,
                EquipmentTypeCB.Text,
                CharacteristicTB.Text
            };

            int added = dBContext.AddRow("equipment", textBoxes);
            if(added == 1)
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
