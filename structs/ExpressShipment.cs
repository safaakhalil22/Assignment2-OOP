using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_OOP.structs
{
    internal class ExpressShipment : Shipment
    {
        #region ExpressShipment
        #region Attrbiutes
        private decimal extraFee;
        #endregion

        #region Properties
        public decimal ExtraFee
        {
            get { return extraFee; }
            set { extraFee = value >= 0 ? value : extraFee; }
        }

      
        public override decimal EstimatedCost
        {
            get { return base.EstimatedCost + ExtraFee; }
        }
        #endregion

        #region Constructors
        
        public ExpressShipment(string? trackingCode, string? description, double weight,
                                decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            this.extraFee = 0;
            ExtraFee = extraFee;
        }
        #endregion

        #region Methods
        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code  : {TrackingCode}");
            Console.WriteLine($"Description    : {Description}");
            Console.WriteLine($"Weight         : {Weight} kg");
            Console.WriteLine($"Delivery Fee   : {DeliveryFee}");
            Console.WriteLine($"Extra Fee      : {ExtraFee}");
            Console.WriteLine($"Estimated Cost : {EstimatedCost}");
        }
        #endregion
        #endregion

    }
}

