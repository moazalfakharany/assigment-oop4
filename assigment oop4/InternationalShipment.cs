using System;
using System.Collections.Generic;
using System.Text;

namespace assigment_oop4
{
    public class InternationalShipment : Shipment ,ITrackable,IInsurable
    {
        public string DestinationCountry { get; set; }
        public double CustomsFee { get; set; }

        public InternationalShipment(string trackingCode, string description, double weight, double deliveryFee, string destinationCountry, double customsFee, DeliveryAddress address)
            : base(trackingCode, description, weight, deliveryFee, address)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public override decimal EstimatedCost =>
            (decimal)(DeliveryFee + (Weight * 5) + CustomsFee);
        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment\n");
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Customs Fee   : {CustomsFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("Generating standard customs report...");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }
    }
}
