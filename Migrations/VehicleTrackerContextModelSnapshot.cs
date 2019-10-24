﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleTracker.Models;

namespace VehicleTracker.Migrations
{
    [DbContext(typeof(VehicleTrackerContext))]
    partial class VehicleTrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VehicleTracker.Models.Tire", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location");

                    b.Property<int>("TireCondition");

                    b.Property<int>("VehicleID");

                    b.HasKey("ID");

                    b.HasIndex("VehicleID");

                    b.ToTable("Tire");
                });

            modelBuilder.Entity("VehicleTracker.Models.Vehicle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrentFuelLevel");

                    b.Property<int>("NumberOfTires");

                    b.Property<int>("Type");

                    b.Property<string>("VehicleName");

                    b.HasKey("ID");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("VehicleTracker.Models.Tire", b =>
                {
                    b.HasOne("VehicleTracker.Models.Vehicle")
                        .WithMany("tires")
                        .HasForeignKey("VehicleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
