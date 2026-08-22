using System;
using System.Collections.Generic;
using System.Text;

namespace assigment_oop4
{
    public class StandardShipment : Shipment, ITrackable ,IInsurable
    {
        public StandardShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress address)
            : base(trackingCode, description, weight, deliveryFee, address) { }

        public override decimal EstimatedCost =>(decimal)DeliveryFee;

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;

        }

        public string GetTrackingStatus()
        {
            return "Shipment" + TrackingCode + "Is ready";
                }

        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment\n");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }
}
