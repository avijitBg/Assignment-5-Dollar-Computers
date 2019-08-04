using Assignment_5_Dollar_Computers.Data;
using Assignment_5_Dollar_Computers.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Assignment-5: Dollar Computers
 * Author: Avijit Bagchi
 * ID# 301007115
 * Version: 2.2 SelectionTextBox functionality created
 * Last Modified: August 3, 2019
 */
namespace Assignment_5_Dollar_Computers.View
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SplashForm splashForm;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        private static AboutBox aboutBox;
        public static Product products;
        public static ProductDetails productDetails;

        internal static AboutBox AboutBox { get => aboutBox; set => aboutBox = value; }

        //internal static AboutBox AboutBox { get => aboutBox; set => aboutBox = value; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splashForm = new SplashForm();
            startForm = new StartForm();
            selectForm = new SelectForm();
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            AboutBox = new AboutBox();
            products = new Product();
            productDetails = new ProductDetails();
            Application.Run(new SplashForm());
        }
    }
}
