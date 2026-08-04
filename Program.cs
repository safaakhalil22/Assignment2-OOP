using Assignment2_OOP.structs;

namespace Assignment2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1

            Console.Write("Enter Delivery Center Name: ");
            string? centerName = Console.ReadLine();
            DeliveryCenter center = new DeliveryCenter(centerName);
            Console.WriteLine();

            #endregion


            #region Part 2 

            Console.WriteLine("--- Standard Shipment Data ---");
            StandardShipment standard = CreateStandardShipment();
            Console.WriteLine();

            Console.WriteLine("--- Express Shipment Data ---");
            ExpressShipment express = CreateExpressShipment();
            Console.WriteLine();

            Console.WriteLine("--- International Shipment Data ---");
            InternationalShipment international = CreateInternationalShipment();
            Console.WriteLine();

            #endregion


            #region Part 3 

            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);
            Console.WriteLine();

            #endregion


            #region Part 4

            center.PrintAllShipments();
            Console.WriteLine();

            #endregion


            #region Part 5 

            Console.Write("Enter Tracking Code to Search: ");
            string? searchCode = Console.ReadLine();
            Shipment? found = center[searchCode ?? ""];

            if (found != null)
            {
                Console.WriteLine();
                Console.WriteLine("Shipment Found:");
                found.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment Not Found.");
            }
            Console.WriteLine();

            #endregion


            #region Part 6 

            Console.Write("Enter Tracking Code to Remove: ");
            string? removeCode = Console.ReadLine();
            bool removed = center.RemoveShipment(removeCode ?? "");
            Console.WriteLine(removed ? "Shipment Removed Successfully." : "Shipment Not Found.");
            Console.WriteLine();

            #endregion


            #region Part 7 

            Console.WriteLine("======================================================");
            Console.WriteLine("Remaining Shipments");
            Console.WriteLine("======================================================");
            center.PrintAllShipments();

            #endregion
        }

        #region Input Helpers

        private static DeliveryAddress ReadDestination()
        {
            Console.Write("Enter City: ");
            string? city = Console.ReadLine();

            Console.Write("Enter Street: ");
            string? street = Console.ReadLine();

            Console.Write("Enter Building Number: ");
            int buildingNumber = Convert.ToInt32(Console.ReadLine());

            return new DeliveryAddress(city, street, buildingNumber);
        }

        private static StandardShipment CreateStandardShipment()
        {
            Console.Write("Tracking Code: ");
            string? trackingCode = Console.ReadLine();

            Console.Write("Description: ");
            string? description = Console.ReadLine();

            Console.Write("Weight (kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal deliveryFee = Convert.ToDecimal(Console.ReadLine());

            DeliveryAddress destination = ReadDestination();

            return new StandardShipment(trackingCode, description, weight, deliveryFee, destination);
        }

        private static ExpressShipment CreateExpressShipment()
        {
            Console.Write("Tracking Code: ");
            string? trackingCode = Console.ReadLine();

            Console.Write("Description: ");
            string? description = Console.ReadLine();

            Console.Write("Weight (kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal deliveryFee = Convert.ToDecimal(Console.ReadLine());

            DeliveryAddress destination = ReadDestination();

            Console.Write("Extra Fee: ");
            decimal extraFee = Convert.ToDecimal(Console.ReadLine());

            return new ExpressShipment(trackingCode, description, weight, deliveryFee, destination, extraFee);
        }

        private static InternationalShipment CreateInternationalShipment()
        {
            Console.Write("Tracking Code: ");
            string? trackingCode = Console.ReadLine();

            Console.Write("Description: ");
            string? description = Console.ReadLine();

            Console.Write("Weight (kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal deliveryFee = Convert.ToDecimal(Console.ReadLine());

            DeliveryAddress destination = ReadDestination();

            Console.Write("Destination Country: ");
            string? destinationCountry = Console.ReadLine();

            Console.Write("Customs Fee: ");
            decimal customsFee = Convert.ToDecimal(Console.ReadLine());

            return new InternationalShipment(trackingCode, description, weight, deliveryFee,
                                              destination, destinationCountry, customsFee);
        }

        #endregion
    }
}
