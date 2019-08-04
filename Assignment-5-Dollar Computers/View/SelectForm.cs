using Assignment_5_Dollar_Computers.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5_Dollar_Computers.View
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
                NextButton.Enabled = false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }

        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = true;
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var rows = ProductDataGridView.Rows;
            var columnCount = ProductDataGridView.ColumnCount;
            var cells = rows[rowIndex].Cells;
            //rows[rowIndex].Selected = true;
            //string outputString = string.Empty;
            //for (int index = 0; index < columnCount; index++)
            //{
            //    outputString += cells[index].Value.ToString() + " ";
            //}
            Program.productDetails.ProductionId = int.Parse(cells[(int)ProductDetails.ProductFeatures.Product_ID].Value.ToString());
            Program.productDetails.Cost = double.Parse(cells[(int)ProductDetails.ProductFeatures.Cost].Value.ToString());
            Program.productDetails.Manufacturer = (cells[(int)ProductDetails.ProductFeatures.Manufacturer].Value.ToString());
            Program.productDetails.Model = cells[(int)ProductDetails.ProductFeatures.Model].Value.ToString();
            Program.productDetails.RamType = cells[(int)ProductDetails.ProductFeatures.RAM_Type].Value.ToString();
            Program.productDetails.RamSize = cells[(int)ProductDetails.ProductFeatures.RAM_Size].Value.ToString();
            Program.productDetails.DisplayType = cells[(int)ProductDetails.ProductFeatures.Display_Type].Value.ToString();
            Program.productDetails.LCDSize = cells[(int)ProductDetails.ProductFeatures.LCD_Size].Value.ToString();
            Program.productDetails.CPUClass = cells[(int)ProductDetails.ProductFeatures.CPU_Class].Value.ToString();
            Program.productDetails.CPUBrand = cells[(int)ProductDetails.ProductFeatures.CPU_Brand].Value.ToString();
            Program.productDetails.CPUType = cells[(int)ProductDetails.ProductFeatures.CPU_Type].Value.ToString();
            Program.productDetails.CPUSpeed = cells[(int)ProductDetails.ProductFeatures.CPU_Speed].Value.ToString();
            Program.productDetails.CPUNumber = cells[(int)ProductDetails.ProductFeatures.CPU_Number].Value.ToString();
            Program.productDetails.Condition = cells[(int)ProductDetails.ProductFeatures.Condition].Value.ToString();
            Program.productDetails.OS = cells[(int)ProductDetails.ProductFeatures.OS].Value.ToString();
            Program.productDetails.Platform = cells[(int)ProductDetails.ProductFeatures.Platform].Value.ToString();
            Program.productDetails.HDDSize = cells[(int)ProductDetails.ProductFeatures.HDD_Size].Value.ToString();
            Program.productDetails.HDDSpeed = cells[(int)ProductDetails.ProductFeatures.HDD_Speed].Value.ToString();
            Program.productDetails.GPUType = cells[(int)ProductDetails.ProductFeatures.GPU_Type].Value.ToString();
            Program.productDetails.OpticalDrive = cells[(int)ProductDetails.ProductFeatures.Optical_drive].Value.ToString();
            Program.productDetails.AudioType = cells[(int)ProductDetails.ProductFeatures.Audio_Type].Value.ToString();
            Program.productDetails.LAN = cells[(int)ProductDetails.ProductFeatures.LAN].Value.ToString();
            Program.productDetails.WIFI = cells[(int)ProductDetails.ProductFeatures.WIFI].Value.ToString();
            Program.productDetails.Width = cells[(int)ProductDetails.ProductFeatures.Width].Value.ToString();
            Program.productDetails.Height = cells[(int)ProductDetails.ProductFeatures.Height].Value.ToString();
            Program.productDetails.Depth = cells[(int)ProductDetails.ProductFeatures.Depth].Value.ToString();
            Program.productDetails.Weight = cells[(int)ProductDetails.ProductFeatures.Weight].Value.ToString();
            Program.productDetails.MouseType = cells[(int)ProductDetails.ProductFeatures.Mouse_Type].Value.ToString();
            Program.productDetails.Power = cells[(int)ProductDetails.ProductFeatures.Power].Value.ToString();
            Program.productDetails.WebCam = cells[(int)ProductDetails.ProductFeatures.Web_Cam].Value.ToString();

            string manufacturer = Program.productDetails.Manufacturer.ToString();
            string model = Program.productDetails.Model.ToString();
            double cost = Program.productDetails.Cost;
            SelectionTextBox.Text = ($"{manufacturer}, {model}, Price: {cost:C2}");
        }

    }
}
