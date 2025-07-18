﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeknofestBackendCsharp.Data;

#nullable disable

namespace TeknofestBackendCsharp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TeknofestBackendCsharp.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("TeknofestBackendCsharp.Models.Place", b =>
                {
                    b.Property<int>("PlaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlaceId"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("PlaceDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceImage")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PlaceName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("PlaceId");

                    b.HasIndex("CityId");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("TeknofestBackendCsharp.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TeknofestBackendCsharp.Models.VisitedPlace", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("PlaceId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.HasKey("UserId", "PlaceId");

                    b.HasIndex("PlaceId");

                    b.ToTable("VisitedPlaces");
                });

            modelBuilder.Entity("TeknofestBackendCsharp.Models.Place", b =>
                {
                    b.HasOne("TeknofestBackendCsharp.Models.City", "City")
                        .WithMany("Places")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("TeknofestBackendCsharp.Models.VisitedPlace", b =>
                {
                    b.HasOne("TeknofestBackendCsharp.Models.Place", "Place")
                        .WithMany("VisitedPlaces")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeknofestBackendCsharp.Models.User", "User")
                        .WithMany("VisitedPlaces")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Place");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TeknofestBackendCsharp.Models.City", b =>
                {
                    b.Navigation("Places");
                });

            modelBuilder.Entity("TeknofestBackendCsharp.Models.Place", b =>
                {
                    b.Navigation("VisitedPlaces");
                });

            modelBuilder.Entity("TeknofestBackendCsharp.Models.User", b =>
                {
                    b.Navigation("VisitedPlaces");
                });
#pragma warning restore 612, 618
        }
    }
}
