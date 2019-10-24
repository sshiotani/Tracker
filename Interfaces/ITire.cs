using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static VehicleTracker.Models.Tire;

namespace VehicleTracker.Interfaces
{
    public interface ITire
    {
        string Location { get; set; }
        Condition TireCondition { get; set; }
        int VehicleID { get; set; }
    }
}
