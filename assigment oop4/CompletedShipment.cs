using System;
using System.Collections.Generic;
using System.Text;

namespace assigment_oop4
{
    public sealed class CompletedShipment : Shipment
    {
        public DateTime CompletionDate { get; set; }

        public CompletedShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress address, DateTime completionDate)
            : base(trackingCode, description, weight, deliveryFee, address)
        {
            CompletionDate = completionDate;
        }
    }
}
