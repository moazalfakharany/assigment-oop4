using System.Numerics;
using System.Timers;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assigment_oop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeliveryAddress address = new DeliveryAddress("Main St", "Cairo", "12345");

            StandardShipment standard = new StandardShipment("SH001", "Laptop", 5.0, 95.0, address);
            ExpressShipment express = new ExpressShipment("SH002", "Electronics", 2.0, 100.0, 30.0, address);
            InternationalShipment international = new InternationalShipment("SH003", "Documents", 10.0, 260.0, "Germany", 50.0, address);

            DeliveryCenter center = new DeliveryCenter();
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            center.PrintAllShipments();

            Console.WriteLine("==========================================");
            Console.WriteLine("Tracking Status");
            Console.WriteLine();

            center.PrintTrackingStatuses();

            Console.WriteLine("==========================================");
            Console.WriteLine("Insurance");
            Console.WriteLine();

            DeliveryReport report = new DeliveryReport();
            report.PrintInsurance(standard);
            Console.WriteLine();
            report.PrintInsurance(express);
            Console.WriteLine();
            report.PrintInsurance(international);
            Console.WriteLine();

            Console.WriteLine("==========================================");
            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
        }
    }
}