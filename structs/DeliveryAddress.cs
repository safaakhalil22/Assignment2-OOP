using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_OOP.structs
{
    public struct DeliveryAddress
    {
        #region DeliveryAddress
        #region Attributes
        public string? City;
        public string? Street;
        public int BuildingNumber;
        #endregion

        #region Constructors
        public DeliveryAddress(string? city, string? street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }
        #endregion

        #region Methods
        public string GetFullAddress()
        {
            return $"{BuildingNumber} {Street}, {City}";
        }

        public override string ToString()
        {
            return GetFullAddress();
        }
        #endregion
        #endregion
    }
}
