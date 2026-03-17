using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace StockApp
{
    internal class Material
    {

        //Variables
        public required string Brand { get; set; }
        public required string Color { get; set; }
        public required float Price { get; set; }
        public int Nozzle_Temp { get; set; }
        public int Bed_Temp { get; set; }

        // Constructors
        public Material()
        {
            this.Brand = "Empty";
            this.Color = "Empty";
            this.Price = 0.00f;
        }

        public Material(string brand, string color, float price, int noozleTemp = 0, int bedTemp = 60)
        {
            this.Brand = brand;
            this.Color = color;
            this.Price = price;
            this.Nozzle_Temp = noozleTemp;
            this.Bed_Temp = bedTemp;
        }

    }
}
