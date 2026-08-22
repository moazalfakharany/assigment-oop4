using System;
using System.Collections.Generic;
using System.Text;

namespace assigment_oop4
{
    public class DeliveryCenter
    {
        private List<Shipment> shipments = new List<Shipment>();
        public Driver Driver { get; set; }

        public void AddShipment(Shipment shipment)
        {
            shipments.Add(shipment);
        }
        public void PrintTrackingStatuses()
        {
            foreach (ITrackable t in shipments)
            {
                Console.WriteLine(t.GetTrackingStatus());
            }
        }

        public void RemoveShipment(Shipment shipment)
        {
            shipments.Remove(shipment);
        }

        public void PrintAllShipments()
        {
            foreach (var shipment in shipments)
            {
                shipment.PrintShipment();
                Console.WriteLine(new string('-', 55));
            }

        }

    }
}
