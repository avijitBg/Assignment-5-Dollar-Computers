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
            if (!HasLoadedDataSource())
            {
                MessageBox.Show("Data Source not loaded properly!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Confirm your selection!");
            this.Hide();
            Program.productInfoForm.Show();
        }

        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = true;
            productDataGridViewSelectedItem();
            SelectionTextBox.Text=productDataGridViewSelectedItem();   
        } 
    }
}
