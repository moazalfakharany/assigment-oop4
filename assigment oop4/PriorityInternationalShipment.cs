using System;
using System.Collections.Generic;
using System.Text;

namespace assigment_oop4
{
    public class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode, string description, double weight, double deliveryFee, string destinationCountry, double customsFee, DeliveryAddress address)
            : base(trackingCode, description, weight, deliveryFee, destinationCountry, customsFee, address) { }

        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine("Generating priority customs report with expedited clearance...");
        }
    }
}
