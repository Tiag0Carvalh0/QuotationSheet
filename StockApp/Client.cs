using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Metrics;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StockApp
{
    internal class Client
    {

        //Variables
        public required string Name { get; set; }
        public required string Phone_Number { get; set; }
        public required string Country { get; set; }
        public required string City { get; set; }
        public required string Region { get; set; }
        public required string PostalCode { get; set; }
        public required string Address { get; set; }
        public string? Email { get; set; }

        // Contructors
        public Client() {
            this.Name = "Empty";
            this.Phone_Number = "+999999999";
            this.Country = "Empty";
            this.City = "Empty";
            this.Region = "Empty";
            this.PostalCode = "999-999";
            this.Address = "Empty";
            this.Email = "Empty";
        }

        public Client(string name, string phone, string country, string city, string region, string zipCode, string address, string email = "Empty" )
        {
            this.Name = name;
            this.Phone_Number = phone;
            this.Country = country;
            this.City = city;
            this.Region = region;
            this.PostalCode = zipCode;
            this.Address = address;
            this.Email = email;

        }




    }
}
