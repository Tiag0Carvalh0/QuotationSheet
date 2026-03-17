using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace StockApp
{
    internal class Machinery
    {
        //Variables
        public required string Brand { get; set; }
        public required string Device_Name { get; set; }
        public required float Price_On_Purchase { get; set; }
        public required float Consumption { get; set; }
        public required int Year_Of_Purchase { get; set; }

        //Constructors
        public Machinery()
        {
            this.Brand = "Empty";
            this.Device_Name = "Empty";
            this.Price_On_Purchase = 999.99f;
            this.Consumption = 999.99f;
            this.Year_Of_Purchase = 9999;
        }

        public Machinery(string brand, string deviceName, float price, float consuption, int year)
        {
            this.Brand = brand;
            this.Device_Name = deviceName;
            this.Price_On_Purchase = price;
            this.Consumption = consuption;
            this.Year_Of_Purchase = year;
        }


    }
}
