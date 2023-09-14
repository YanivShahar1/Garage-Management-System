using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageLogic.Info
{
    public struct OwnerInfo
    {
        public string OwnerName { get; }
        public PhoneNumber OwnerPhone { get; }
        public OwnerInfo(string ownerName, PhoneNumber ownerPhone)
        {
            OwnerName = ownerName ?? throw new ArgumentNullException(nameof(ownerName), "Owner name cannot be null.");
            OwnerPhone = ownerPhone ?? throw new ArgumentNullException(nameof(ownerPhone), "Owner phone cannot be null.");
        }
    }
}
