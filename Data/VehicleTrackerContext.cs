using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehicleTracker.Models;

namespace VehicleTracker.Models
{
    public class VehicleTrackerContext : DbContext
    {
        public VehicleTrackerContext (DbContextOptions<VehicleTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<VehicleTracker.Models.Vehicle> Vehicle { get; set; }

        public DbSet<VehicleTracker.Models.Tire> Tire { get; set; }
    }
}
