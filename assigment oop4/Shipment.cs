using System;
using System.Collections.Generic;
using System.Text;

namespace assigment_oop4
{
    public  abstract class Shipment
    {
        public string TrackingCode { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }
        public double DeliveryFee { get; set; }
        public DeliveryAddress Address { get; set; }
        public abstract decimal EstimatedCost { get; } 
        public abstract void PrintShipment();

        public Shipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress address)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Address = address;
        }

        //public virtual double EstimatedCost => DeliveryFee;

        //public virtual void PrintShipment()
        //{
        //    Console.WriteLine($"Tracking Code : {TrackingCode}");
        //    Console.WriteLine($"Description   : {Description}");
        //    Console.WriteLine($"Weight        : {Weight} KG");
        //    Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
        //}

        public void UpdateWeight(double newWeight)
        {
            Weight = newWeight;
        }

        public void UpdateWeight(double newWeight, double extraPackingWeight)
        {
            Weight = newWeight + extraPackingWeight;
        }
    }
}
