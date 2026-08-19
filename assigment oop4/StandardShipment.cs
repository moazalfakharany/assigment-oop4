using System;
using System.Collections.Generic;
using System.Text;

namespace assigment_oop4
{
    public class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress address)
            : base(trackingCode, description, weight, deliveryFee, address) { }

        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment\n");
            base.PrintShipment();
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }
}
