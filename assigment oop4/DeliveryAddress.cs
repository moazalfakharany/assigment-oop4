using System;
using System.Collections.Generic;
using System.Text;

namespace assigment_oop4
{
    public class DeliveryAddress
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public DeliveryAddress(string street, string city, string country)
        {
            Street = street;
            City = city;
            Country = country;
        }
    }
}
