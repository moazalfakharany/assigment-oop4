using System;
using System.Collections.Generic;
using System.Text;

namespace assigment_oop4
{
    public class ExpressShipment : Shipment, ITrackable,IInsurable
    {
        public double ExtraFee { get; set; }
        public ExpressShipment(string trackingCode, string description, double weight, double deliveryFee, double extraFee, DeliveryAddress address)
            : base(trackingCode, description, weight, deliveryFee, address)
        {
            ExtraFee = extraFee;
        }
        public override decimal EstimatedCost => (decimal)(DeliveryFee +(Weight*5) +ExtraFee);


        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment\n");
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
    }
}
