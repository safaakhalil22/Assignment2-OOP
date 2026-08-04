using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_OOP.structs
{
    internal class DeliveryCenter
    {
        #region DeliveryCenter
        //#region Attrbiutes
        //private const int MaxShipments = 20;
        //private Shipment?[] shipments;  
        //private int count;
        //#endregion

        //#region Properties
        //public string? CenterName { get; set; }
        //#endregion

        //#region Constructors
        //public DeliveryCenter(string? centerName)
        //{
        //    CenterName = string.IsNullOrWhiteSpace(centerName) ? "Unknown Center" : centerName;
        //    shipments = new Shipment?[MaxShipments];
        //    count = 0;
        //}
        //#endregion

        //#region Indexers
        //// Indexer by position.
        //public Shipment? this[int index]
        //{
        //    get
        //    {
        //        if (index < 0 || index >= count)
        //            return null;
        //        return shipments[index];
        //    }
        //}

       
        //public Shipment? this[string trackingCode]
        //{
        //    get
        //    {
        //        for (int i = 0; i < count; i++)
        //        {
        //            if (shipments[i]?.TrackingCode == trackingCode)
        //                return shipments[i];
        //        }
        //        return null;
        //    }
        //}
        //#endregion

        //#region Methods
        //public bool AddShipment(Shipment shipment)
        //{
        //    if (count >= MaxShipments)
        //    {
        //        Console.WriteLine("Delivery Center is full. Cannot add more shipments.");
        //        return false;
        //    }

        //    shipments[count] = shipment;
        //    count++;
        //    Console.WriteLine("Shipment Added Successfully.");
        //    return true;
        //}

        
        //public bool RemoveShipment(string trackingCode)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        if (shipments[i]?.TrackingCode == trackingCode)
        //        {
        //            for (int j = i; j < count - 1; j++)
        //            {
        //                shipments[j] = shipments[j + 1];
        //            }

        //            shipments[count - 1] = null;
        //            count--;
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //public void PrintAllShipments()
        //{
        //    Console.WriteLine("======================================================");
        //    Console.WriteLine($"Delivery Center : {CenterName}");
        //    Console.WriteLine("======================================================");

        //    for (int i = 0; i < count; i++)
        //    {
        //        shipments[i]?.PrintShipment();

        //        if (i < count - 1)
        //        {
        //            Console.WriteLine();
        //            Console.WriteLine("------------------------------------------------------");
        //            Console.WriteLine();
        //        }
        //    }
        //}
        //#endregion
        #endregion

    }
}

