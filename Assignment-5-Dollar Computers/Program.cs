using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Assignment-5: Dollar Computers
 * Author: Avijit Bagchi
 * ID# 301007115
 * Version: 1.5 AboutBox created
 * Last Modified: August 2, 2019
 */
namespace Assignment_5_Dollar_Computers
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SplashForm splashForm;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        public static AboutBox aboutBox;
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
            aboutBox = new AboutBox();
            Application.Run(new SplashForm());
        }
    }
}
