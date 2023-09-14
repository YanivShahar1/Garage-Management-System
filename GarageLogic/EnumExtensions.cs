using System;
using System.Reflection;


namespace GarageLogic
{
    public static class EnumExtensions
    {
        // Custom attribute to hold the display name
        [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
        public sealed class DisplayNameAttribute : Attribute
        {
            public string DisplayName { get; }

            public DisplayNameAttribute(string displayName)
            {
                DisplayName = displayName;
            }
        }

        // Extension method to retrieve the display name
        public static string GetDisplayName(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DisplayNameAttribute)Attribute.GetCustomAttribute(field, typeof(DisplayNameAttribute));
            return attribute?.DisplayName ?? value.ToString();
        }
    }
}
