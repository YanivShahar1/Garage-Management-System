using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace GarageLogic.Info
{
    public class PhoneNumber
    {
        private string _phoneNumber;
        public string CountryCode { get; } 
        public string CountryName { get; }

        // Define a dictionary to store regular expression patterns for different countries.
        private static Dictionary<string, string> CountryPatterns = new Dictionary<string, string>
        {
            { "US", @"^\d{10}$" }, // Example pattern for the United States (10-digit numbers).
            { "UK", @"^\d{11}$" }, // Example pattern for the United Kingdom (11-digit numbers).
            { "IL", @"^0[23489]{1}[0-9]{7}$" }, // Pattern for Israel (10-digit numbers starting with 0).
            { "FR", @"^0[1-9]{1}[0-9]{8}$" }, // Pattern for France (10-digit numbers starting with 0).
            // TODO : Add patterns for other countries as needed.
        };
        public string Value
        {
            get { return _phoneNumber; }
            set
            {
                if (IsValidPhoneNumber(value, CountryCode))
                {
                    _phoneNumber = value;
                }
                else
                {
                    throw new ArgumentException("Invalid phone number format.");
                }
            }
        }

        public PhoneNumber(string ownerPhoneNumber, string countryCode)
        {
            Value = ownerPhoneNumber;
            CountryCode = countryCode ?? throw new ArgumentNullException(nameof(countryCode), "Country code cannot be null.");
            CountryName = GetCountryNameByCode(countryCode);
        }
        public PhoneNumber(string ownerPhoneNumber)
        {
            Value = ownerPhoneNumber;

            // Automatically determine the user's country code based on current culture settings.
            CountryCode = GetCurrentCountryCode();

            // Get the localized country name based on the determined country code.
            CountryName = GetCountryNameByCode(CountryCode);
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

        public static bool IsValidPhoneNumber(string phoneNumber, string country)
        {
            // Check if the specified country has a custom pattern defined.
            if (CountryPatterns.TryGetValue(country, out string pattern))
            {
                return !string.IsNullOrWhiteSpace(phoneNumber) && Regex.IsMatch(phoneNumber, pattern);
            }
            else
            {
                // If no custom pattern is defined, use a default pattern (e.g., 7 to 15 digits).
                return IsValidPhoneNumber(phoneNumber);
            }
        }

        // Default validation method for phone numbers without specifying a country.
        private static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Use a default regular expression pattern for phone numbers.
            string pattern = @"^\d{7,15}$";
            return !string.IsNullOrWhiteSpace(phoneNumber) && Regex.IsMatch(phoneNumber, pattern);
        }
    }

}
