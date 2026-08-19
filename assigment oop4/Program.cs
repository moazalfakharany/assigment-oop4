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
            #region 1
            // a) Difference between Method Overloading and Method Overriding:
            //Method Overloading: Defining multiple methods in the same class with the same name but different parameters(type, number, or order). It happens at compile time(Compile-time Polymorphism).
            //Method Overriding: Redefining a base class method(marked virtual or abstract) in a derived class using the override keyword to provide specific behavior.It happens at runtime(Runtime Polymorphism).

            //b) Difference between Static Binding and Dynamic Binding:

            //Static Binding(Early Binding): The method call is resolved at compile time based on the declared type of the reference variable(e.g., standard non-virtual methods or overloaded methods).

            //Dynamic Binding(Late Binding): The method call is resolved at runtime based on the actual object instance type created in memory(e.g., virtual and overridden methods).

            //Q2 Sealed Classes and Methods

            //a) Purpose of the sealed keyword on a class:

            //It prevents other classes from inheriting from it, stopping further extension of the class hierarchy.

            //b) Difference between a sealed class and a sealed method:

            //Sealed Class: The entire class cannot be inherited(sealed class A { }).

            //Sealed Method: A virtual method overridden in a derived class that is marked sealed override to prevent further derived classes from overriding it again.

            //c) Can a sealed method be overridden? Why?

            //No.The purpose of the sealed modifier on an overridden method is to break the chain of virtual method overriding for subsequent child classes.
            #endregion

         
                Driver driver = new Driver(1, "Ahmed Mohamed", "01000000000");

                DeliveryCenter center = new DeliveryCenter();

                center.Driver = driver;

                Console.WriteLine("=======================================================");
                Console.WriteLine("Delivery Center");
                Console.WriteLine("=======================================================");
                Console.WriteLine($"Driver : {center.Driver.FullName}");
                Console.WriteLine("=======================================================\n");

                DeliveryAddress defaultAddress = new DeliveryAddress("123 St", "Cairo", "Egypt");

                StandardShipment standard = new StandardShipment("SH001", "Laptop", 3, 80, defaultAddress);
                ExpressShipment express = new ExpressShipment("SH002", "Mobile Phone", 2, 60, 30, defaultAddress);
                InternationalShipment intl = new InternationalShipment("SH003", "Television", 8, 120, "Germany", 100, defaultAddress);

                center.AddShipment(standard);
                center.AddShipment(express);
                center.AddShipment(intl);

                center.PrintAllShipments();

                Console.WriteLine("Printing Using DeliveryHelper...\n");

                DeliveryHelper.PrintShipmentDetails(standard);
                Console.WriteLine("Standard Shipment Printed Successfully.\n");

                DeliveryHelper.PrintShipmentDetails(express);
                Console.WriteLine("Express Shipment Printed Successfully.\n");

                DeliveryHelper.PrintShipmentDetails(intl);
                Console.WriteLine("International Shipment Printed Successfully.\n");

                Console.WriteLine(new string('-', 55));

                Console.WriteLine("Updating Weight...\n");
                Console.WriteLine($"Original Weight : {standard.Weight} KG");

                standard.UpdateWeight(5);
                Console.WriteLine($"Updated Weight : {standard.Weight} KG");

                standard.UpdateWeight(5, 0.5);
                Console.WriteLine($"Updated Weight After Packing : {standard.Weight} KG\n");

                Console.WriteLine(new string('-', 55));

                Console.WriteLine("\nPrinting Using Shipment[]...\n");
                Shipment[] shipmentArray = new Shipment[] { standard, express, intl };

                foreach (var s in shipmentArray)
                {
                    if (s is StandardShipment) Console.WriteLine("Standard Shipment...");
                    else if (s is ExpressShipment) Console.WriteLine("Express Shipment...");
                    else if (s is InternationalShipment) Console.WriteLine("International Shipment...");

                    Console.WriteLine(new string('-', 55));
                }
            }
        }
    }
    

