using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5_Dollar_Computers.View
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.AboutBox.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        private void ProductInfoTextBox_TextChanged(object sender, EventArgs e)
        {
            //string outputText = ProductInfoTextBox.Text;
            //outputText = Program.productDetails.LCDSize;
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            PlatformTextBox.Text = Program.productDetails.Platform;
            ConditiontextBox.Text= Program.productDetails.Condition;
            ModeltextBox.Text= Program.productDetails.Model;
            ManufacturerTextBox.Text= Program.productDetails.Manufacturer;

            ProductInfoTextBox.Text += Program.productDetails.LCDSize + "\r\n";
            ProductInfoTextBox.Text += "\r\n";
            ProductInfoTextBox.Text += Program.productDetails.RamSize + "\r\n";
            ProductInfoTextBox.Text += "\r\n";
            ProductInfoTextBox.Text += Program.productDetails.CPUBrand + "\r\n";
            ProductInfoTextBox.Text += "\r\n";
            ProductInfoTextBox.Text += Program.productDetails.CPUType + "\r\n";
            ProductInfoTextBox.Text += "\r\n";
            ProductInfoTextBox.Text += Program.productDetails.CPUNumber + "\r\n";
            ProductInfoTextBox.Text += "\r\n";
            ProductInfoTextBox.Text += Program.productDetails.CPUSpeed + "\r\n";
            ProductInfoTextBox.Text += "\r\n";
            ProductInfoTextBox.Text += Program.productDetails.HDDSize + "\r\n";
            ProductInfoTextBox.Text += "\r\n";
            ProductInfoTextBox.Text += Program.productDetails.GPUType + "\r\n";
            ProductInfoTextBox.Text += "\r\n";
            ProductInfoTextBox.Text += Program.productDetails.WebCam + "\r\n";
            ProductInfoTextBox.Text += "\r\n";
            ProductInfoTextBox.Text += Program.productDetails.OS + "\r\n";

            double price= Program.productDetails.Cost;
            double tax = Program.productDetails.Cost * .13;
            double totalPrice = price + tax;
            PriceTextBox.Text = ($"{price:C2}").ToString();
            TaxTextBox.Text = ($"{tax:C2}").ToString();
            TotalpriceTextBox.Text= ($"{totalPrice:C2}").ToString();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            //DialogResult dialog = MessageBox.Show("Thanks for purchasing from Dollar Computers!\n\nYour order will be processed within 7-10 business days", MessageBoxButtons.OK);
            DialogResult dialog = MessageBox.Show(this, "Thanks for purchasing from Dollar Computers!\n\nYour order will be processed within 7-10 business days",
                                    "Order Submitted!!!",MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
            if (dialog == DialogResult.OK) ;
                if (dialog == DialogResult.OK)
                {
                    Application.Exit();
                }
        }
    }
}
