using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_Dollar_Computers
{
    public class ProductDetails
    {
        enum ProductFeatures
        {
            Product_ID,
            Condition,
            Cost,
            Platform,
            OS,
            Manufacturer,
            Model,
            Memory,
            LCD_Size,
            HDD,
            CPU_Brand,
            CPU_Number,
            CPU_Type,
            GPU_Type,
            CPU_Speed,
            Web_Cam
        }
        public int ProductionId { get; set; }
        public string Condition { get; set; }
        public double Cost { get; set; }
        public string Platform { get; set; }
        public string OS { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Memory { get; set; }
        public int LCDSize { get; set; }
        public string HDD { get; set; }
        public string CPUBrand { get; set; }
        public string CPUNumber { get; set; }
        public string CPUType { get; set; }
        public string GPUType { get; set; }
        public string CPUSpeed { get; set; }
        public string WebCam { get; set; }
    }
}
