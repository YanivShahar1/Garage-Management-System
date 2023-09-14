using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageLogic.Vehicles
{
    public struct OwnerInfo
    {
        public string OwnerName { get; }
        public string OwnerPhone { get; }
        public OwnerInfo(string ownerName, string ownerPhone)
        {
            OwnerName = ownerName ?? throw new ArgumentNullException(nameof(ownerName), "Owner name cannot be null.");
            OwnerPhone = ownerPhone ?? throw new ArgumentNullException(nameof(ownerPhone), "Owner phone cannot be null.");
        }
    }
}
