using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_5_Dollar_Computers.View;
using System.Windows.Forms;

namespace DollarComputersTestProject
{
    [TestClass]
    public class UnitTest1
    {
        SelectForm selectForm;
        [TestMethod]
        public void TestThtSelectFormHasLoadedDataSource()
        {
            //arrange
            //SelectForm selectForm;
            //act
            selectForm = new SelectForm();
            //assert
            Assert.IsTrue(selectForm.HasLoadedDataSource());
            //selectForm.ShowInTaskbar = false;
            //selectForm.ShowDialog();
        }
        [TestMethod]
        public void TestThatSelectFormSelectionTextBoxDisplaysSelectedItem()
        {
            //arrange
            //SelectForm selectForm;
            string outputString;
            //act
            selectForm = new SelectForm();
            outputString = selectForm.SelectionTextBox.Text;
            //assert
            Assert.AreEqual("Asus , G71GX-RX05, Price: $719.97", selectForm.SelectionTextBox.Text);
            //selectForm.ShowInTaskbar = false;
            //selectForm.ShowDialog();
        }
    }
}
