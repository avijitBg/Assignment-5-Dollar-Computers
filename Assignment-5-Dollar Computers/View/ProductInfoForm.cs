using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5_Dollar_Computers.View
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectAnotherButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.selectForm.Show();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.orderForm.Show();
        }


        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            ProductInfoSaveFileDialog.FileName = "Product.txt";
            ProductInfoSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductInfoSaveFileDialog.Filter = "Text Files(*.txt)|*.txt| All Files (*.*)|*.*";

            var result = ProductInfoSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    using (BinaryWriter outputString = new BinaryWriter(File.Open(ProductInfoSaveFileDialog.FileName, FileMode.Create)))
                    {
                        outputString.Write(Program.productDetails.ProductionId.ToString());
                        outputString.Write(Program.productDetails.Cost.ToString());
                        outputString.Write(Program.productDetails.Manufacturer);
                        outputString.Write(Program.productDetails.Model);
                        outputString.Write(Program.productDetails.RamType);
                        outputString.Write(Program.productDetails.RamSize);
                        outputString.Write(Program.productDetails.DisplayType);
                        outputString.Write(Program.productDetails.LCDSize);
                        outputString.Write(Program.productDetails.CPUClass);
                        outputString.Write(Program.productDetails.CPUBrand);
                        outputString.Write(Program.productDetails.CPUType);
                        outputString.Write(Program.productDetails.CPUSpeed);
                        outputString.Write(Program.productDetails.CPUNumber);
                        outputString.Write(Program.productDetails.Condition);
                        outputString.Write(Program.productDetails.OS);
                        outputString.Write(Program.productDetails.Platform);
                        outputString.Write(Program.productDetails.HDDSize);
                        outputString.Write(Program.productDetails.HDDSpeed);
                        outputString.Write(Program.productDetails.GPUType);
                        outputString.Write(Program.productDetails.OpticalDrive);
                        outputString.Write(Program.productDetails.LAN);
                        outputString.Write(Program.productDetails.WIFI);
                        outputString.Write(Program.productDetails.AudioType);
                        outputString.Write(Program.productDetails.Width);
                        outputString.Write(Program.productDetails.Height);
                        outputString.Write(Program.productDetails.Depth);
                        outputString.Write(Program.productDetails.Weight);
                        outputString.Write(Program.productDetails.MouseType);
                        outputString.Write(Program.productDetails.Power);
                        outputString.Write(Program.productDetails.WebCam);

                        outputString.Flush();
                        outputString.Close();
                        outputString.Dispose();

                        MessageBox.Show("File saved...", "Saving file...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (IOException exception)
                {
                    MessageBox.Show("ERROR" + exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductInfoOpenFileDialog.FileName = "Product.txt";
            ProductInfoOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductInfoOpenFileDialog.Filter = "Text Files(*.txt)|*.txt| All Files (*.*)|*.*";

            var result = ProductInfoOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    using (BinaryReader inputString = new BinaryReader(File.Open(ProductInfoOpenFileDialog.FileName, FileMode.Open)))
                    {
                        Program.productDetails.ProductionId = int.Parse(inputString.ReadString());
                        Program.productDetails.Cost = double.Parse(inputString.ReadString());
                        Program.productDetails.Manufacturer = inputString.ReadString();
                        Program.productDetails.Model = inputString.ReadString();
                        Program.productDetails.RamType = inputString.ReadString();
                        Program.productDetails.RamSize = inputString.ReadString();
                        Program.productDetails.DisplayType = inputString.ReadString();
                        Program.productDetails.LCDSize = inputString.ReadString();
                        Program.productDetails.CPUClass = inputString.ReadString();
                        Program.productDetails.CPUBrand = inputString.ReadString();
                        Program.productDetails.CPUType = inputString.ReadString();
                        Program.productDetails.CPUSpeed = inputString.ReadString();
                        Program.productDetails.CPUNumber = inputString.ReadString();
                        Program.productDetails.Condition = inputString.ReadString();
                        Program.productDetails.OS = inputString.ReadString();
                        Program.productDetails.Platform = inputString.ReadString();
                        Program.productDetails.HDDSize = inputString.ReadString();
                        Program.productDetails.HDDSpeed = inputString.ReadString();
                        Program.productDetails.GPUType = inputString.ReadString();
                        Program.productDetails.OpticalDrive = inputString.ReadString();
                        Program.productDetails.AudioType = inputString.ReadString();
                        Program.productDetails.LAN = inputString.ReadString();
                        Program.productDetails.WIFI = inputString.ReadString();
                        Program.productDetails.Width = inputString.ReadString();
                        Program.productDetails.Height = inputString.ReadString();
                        Program.productDetails.Depth = inputString.ReadString();
                        Program.productDetails.Weight = inputString.ReadString();
                        Program.productDetails.MouseType = inputString.ReadString();
                        Program.productDetails.Power = inputString.ReadString();
                        Program.productDetails.WebCam = inputString.ReadString();

                        inputString.Close();
                        inputString.Dispose();
                    }
                    NextButton_Click(sender, e);
                }
                catch (IOException exception)
                {
                    MessageBox.Show("ERROR" + exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIdTextBox.Text = Program.productDetails.ProductionId.ToString();
            ConditionTextBox.Text = Program.productDetails.Condition;
            PriceTextBox.Text = ($"{Program.productDetails.Cost:C2}");
            PlatformTextBox.Text = Program.productDetails.Platform;
            OSTextBox.Text = Program.productDetails.OS;
            ManufacturerTextBox.Text = Program.productDetails.Manufacturer;
            ModelTextBox.Text = Program.productDetails.Model;
            MemoryTextBox.Text = Program.productDetails.HDDSize;
            ScreenTextBox.Text = Program.productDetails.LCDSize;
            HDDTextBox.Text = Program.productDetails.RamSize;
            CPUBrandTextBox.Text = Program.productDetails.CPUBrand;
            CPUNumberTextBox.Text = Program.productDetails.CPUNumber;
            GPUTypeTextBox.Text = Program.productDetails.GPUType;
            CPUTypeTextBox.Text = Program.productDetails.CPUType;
            CPUSpeedTextBox.Text = Program.productDetails.CPUSpeed;
            WebcamTextBox.Text = Program.productDetails.WebCam;
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
