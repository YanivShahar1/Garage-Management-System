using System;
using System.Globalization;

namespace GarageLogic.Info
{
    public class OwnerInfo
    {
        public string _name { get; }
        public PhoneNumber _phoneNumber { get; }
        public OwnerInfo(string ownerName, string ownerPhoneNumber)
        {
            _name = ownerName ?? throw new ArgumentNullException(nameof(ownerName), "Owner name cannot be null.");
            _phoneNumber = new PhoneNumber(ownerPhoneNumber);
        }

        private string GetCurrentCountryCode()
        {
            try
            {
                // Get the current region (country) code based on the current culture.
                var currentRegion = RegionInfo.CurrentRegion;
                return currentRegion.TwoLetterISORegionName;
            }
            catch (Exception)
            {
                // Handle cases where the country code cannot be determined.
                return "Unknown";
            }
        }

        private string GetCountryNameByCode(string code)
        {
            try
            {
                var regionInfo = new RegionInfo(code);
                return regionInfo.DisplayName; // Get the localized country name.
            }
            catch (ArgumentException)
            {
                // Handle invalid country codes.
                return "Unknown";
            }
        }
    }
}
