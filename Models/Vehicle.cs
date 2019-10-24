using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTracker.Models
{
    public class Vehicle
    {   
        public int ID { get; set; }
        [DisplayName("Vehicle Name")]
        public string VehicleName { get; set; }
        [DisplayName("Vehicle Type")]
        [EnumDataType(typeof(VehicleType))]
        public VehicleType Type { get; set; }     
        public enum VehicleType { Car, Truck, MotorCycle, Boat}
        [DisplayName("Vehicle Fuel Level")]
        public enum FuelLevel { Full, ThreeQuarter, Half, OneQuarter, Empty}
        [EnumDataType(typeof(FuelLevel))]
        public FuelLevel CurrentFuelLevel { get; set; }
        [DisplayName("Number of Tires")]
        public int NumberOfTires { get; set; }
        public List<Tire> tires { get; set; }
        
    }
}
