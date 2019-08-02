﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Assignment-5: Dollar Computers
 * Author: Avijit Bagchi
 * ID# 301007115
 * Version: 1.1 StartForm created
 * Last Modified: August 2, 2019
 */
namespace Assignment_5_Dollar_Computers
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static StartForm startForm;
        public static SelectForm selectForm;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            startForm = new StartForm();
            selectForm = new SelectForm();
            Application.Run(new StartForm());
        }
    }
}
