using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_5_Dollar_Computers.View;

namespace DollarComputersTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestThtSelectFormHasLoadedDataSource()
        {
            //arrange
            SelectForm selectForm;
            //act
            selectForm = new SelectForm();
            //assert
            Assert.IsTrue(selectForm.HasLoadedDataSource());
        }
    }
}
