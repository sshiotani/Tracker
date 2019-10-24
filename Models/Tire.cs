using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTracker.Models
{
    public class Tire
    {
        public int ID { get; set; }
        [DisplayName("Tire Location")]
        public string Location { get; set; }
        public enum Condition {Good, Fair, Bad}
        [EnumDataType(typeof(Condition))]
        [DisplayName("Tire Condition")]
        public Condition TireCondition { get; set; }
        public int VehicleID { get; set; }

    }
}
