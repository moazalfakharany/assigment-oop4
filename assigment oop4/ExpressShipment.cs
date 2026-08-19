using System;
using System.Collections.Generic;
using System.Text;

namespace assigment_oop4
{
    public class ExpressShipment : Shipment
    {
        public double ExtraFee { get; set; }
        public ExpressShipment(string trackingCode, string description, double weight, double deliveryFee, double extraFee, DeliveryAddress address)
            : base(trackingCode, description, weight, deliveryFee, address)
        {
            ExtraFee = extraFee;
        }
        public override double EstimatedCost => DeliveryFee + (Weight * 5) + ExtraFee;

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment\n");
            base.PrintShipment();
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }
}
