using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_OOP.structs
{
    internal class Shipment
    {
        #region Shipment
        #region Attrbiutes
        private string? trackingCode;   // 4 bytes
        private string? description;    // 4 bytes
        private double weight;          // 8 bytes
        private decimal deliveryFee;    // 16 bytes
        #endregion

        #region Properties

        public string? TrackingCode
        {
            get { return trackingCode; }
            private set
            {
                trackingCode = string.IsNullOrWhiteSpace(value) ? trackingCode : value;
            }
        }


        public string? Description
        {
            get { return description; }
            set { description = string.IsNullOrWhiteSpace(value) ? description : value; }
        }


        public double Weight
        {
            get { return weight; }
            set { weight = value > 0 ? value : weight; }
        }


        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set { deliveryFee = value > 0 ? value : deliveryFee; }
        }


        public DeliveryAddress Destination { get; set; }


        public virtual decimal EstimatedCost
        {
            get { return DeliveryFee + ((decimal)Weight * 5); }
        }
        #endregion

        #region Constructors
        public Shipment(string? trackingCode)
        {
            this.trackingCode = null;
            description = null;
            weight = 0;
            deliveryFee = 0;
            Destination = new DeliveryAddress("Unknown City", "Unknown Street", 0);

            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
        }

        public Shipment(string? trackingCode, string? description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.trackingCode = null;
            this.description = null;
            this.weight = 0;
            this.deliveryFee = 0;
            Destination = destination;

            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
        }
        #endregion

        #region Methods
        public void UpdateDeliveryFee(decimal newFee)
        {
            DeliveryFee = newFee > 0 ? newFee : DeliveryFee;
        }

        public virtual void PrintShipment()
        {
            Console.WriteLine("----- Shipment Info -----");
            Console.WriteLine($"Tracking Code  : {TrackingCode}");
            Console.WriteLine($"Description    : {Description}");
            Console.WriteLine($"Weight         : {Weight} kg");
            Console.WriteLine($"Delivery Fee   : {DeliveryFee}");
            Console.WriteLine($"Destination    : {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost : {EstimatedCost}");
            Console.WriteLine("--------------------------");
        }
        #endregion
        #endregion

    }
}
