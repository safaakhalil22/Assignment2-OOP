using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_OOP.structs
{
    internal class InternationalShipment : Shipment
    {
        #region InternationalShipment
        //#region Attrbiutes
        //private string? destinationCountry;
        //private decimal customsFee;
        //#endregion

        //#region Properties
        //public string? DestinationCountry
        //{
        //    get { return destinationCountry; }
        //    set { destinationCountry = string.IsNullOrWhiteSpace(value) ? destinationCountry : value; }
        //}

        //public decimal CustomsFee
        //{
        //    get { return customsFee; }
        //    set { customsFee = value >= 0 ? value : customsFee; }
        //}

      
        //public override decimal EstimatedCost
        //{
        //    get { return base.EstimatedCost + CustomsFee; }
        //}
        //#endregion

        //#region Constructors
       
        //public InternationalShipment(string? trackingCode, string? description, double weight,
        //                              decimal deliveryFee, DeliveryAddress destination,
        //                              string? destinationCountry, decimal customsFee)
        //    : base(trackingCode, description, weight, deliveryFee, destination)
        //{
        //    this.destinationCountry = null;
        //    this.customsFee = 0;

        //    DestinationCountry = destinationCountry;
        //    CustomsFee = customsFee;
        //}
        //#endregion

        //#region Methods
        //public override void PrintShipment()
        //{
        //    Console.WriteLine("International Shipment");
        //    Console.WriteLine();
        //    Console.WriteLine($"Tracking Code      : {TrackingCode}");
        //    Console.WriteLine($"Description        : {Description}");
        //    Console.WriteLine($"Weight             : {Weight} kg");
        //    Console.WriteLine($"Delivery Fee       : {DeliveryFee}");
        //    Console.WriteLine($"Destination Country: {DestinationCountry}");
        //    Console.WriteLine($"Customs Fee        : {CustomsFee}");
        //    Console.WriteLine($"Estimated Cost     : {EstimatedCost}");
        //}
        //#endregion
        #endregion

    }
}

