using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Entities.Models
{
    public partial class CarFactoryContext : DbContext
    {
        public CarFactoryContext()
        {
        }

        public CarFactoryContext(DbContextOptions<CarFactoryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAgency> TbAgency { get; set; }
        public virtual DbSet<TbAgencyCar> TbAgencyCar { get; set; }
        public virtual DbSet<TbCar> TbCar { get; set; }
        public virtual DbSet<TbCarPrice> TbCarPrice { get; set; }
        public virtual DbSet<TbCategory> TbCategory { get; set; }
        public virtual DbSet<TbCountry> TbCountry { get; set; }
        public virtual DbSet<TbCustomer> TbCustomer { get; set; }
        public virtual DbSet<TbManufacturer> TbManufacturer { get; set; }
        public virtual DbSet<TbModel> TbModel { get; set; }
        public virtual DbSet<TbPropCategory> TbPropCategory { get; set; }
        public virtual DbSet<TbPropTitle> TbPropTitle { get; set; }
        public virtual DbSet<TbPropValue> TbPropValue { get; set; }
        public virtual DbSet<TbSales> TbSales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-M5B53P9;Initial Catalog=CarFactory;Persist Security Info=True;User ID=sa;Password=sapass");
            }
        }
        private void HandleCarDelete()
        {
            var entities = ChangeTracker.Entries()
                                .Where(e => e.State == EntityState.Deleted);
            foreach (var entity in entities)
            {
                if (entity.Entity is TbCar)
                {
                    entity.State = EntityState.Modified;
                    var car = entity.Entity as TbCar;
                    car.IsDeleted = true;
                }
            }
        }
        public override int SaveChanges()
        {
            HandleCarDelete();
            return base.SaveChanges();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbCar>().HasQueryFilter(b => (bool)!b.IsDeleted);
            modelBuilder.Entity<TbAgency>(entity =>
            {
                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerName).HasMaxLength(400);

                entity.Property(e => e.Name).HasMaxLength(400);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbAgencyCar>(entity =>
            {
                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.TbAgencyCar)
                    .HasForeignKey(d => d.AgencyId)
                    .HasConstraintName("FK_TbAgencyCar_TbAgency");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.TbAgencyCar)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK_TbAgencyCar_TbCar");
            });

            modelBuilder.Entity<TbCar>(entity =>
            {
                entity.Property(e => e.DesignYear)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TbCar)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_TbCar_TbCategory");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TbCar)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_TbCar_TbCountry");

                entity.HasOne(d => d.Manufacture)
                    .WithMany(p => p.TbCar)
                    .HasForeignKey(d => d.ManufactureId)
                    .HasConstraintName("FK_TbCar_TbManufacturer");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.TbCar)
                    .HasForeignKey(d => d.ModelId)
                    .HasConstraintName("FK_TbCar_TbModel");
            });

            modelBuilder.Entity<TbCarPrice>(entity =>
            {
                entity.Property(e => e.SalesPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Year)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.TbCarPrice)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK_TbCarPrice_TbCar");
            });

            modelBuilder.Entity<TbCategory>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(300);
            });

            modelBuilder.Entity<TbCountry>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<TbCustomer>(entity =>
            {
                entity.Property(e => e.Firstname).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbManufacturer>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(300);
            });

            modelBuilder.Entity<TbModel>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(300);
            });

            modelBuilder.Entity<TbPropCategory>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<TbPropTitle>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(500);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TbPropTitle)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbPropTitle_TbPropCategory");
            });

            modelBuilder.Entity<TbPropValue>(entity =>
            {
                entity.Property(e => e.CarId).HasColumnName("CarID");

                entity.Property(e => e.PropId).HasColumnName("PropID");

                entity.Property(e => e.Value).HasMaxLength(300);

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.TbPropValue)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK_TbPropValue_TbCar");

                entity.HasOne(d => d.Prop)
                    .WithMany(p => p.TbPropValue)
                    .HasForeignKey(d => d.PropId)
                    .HasConstraintName("FK_TbPropValue_TbPropTitle");
            });

            modelBuilder.Entity<TbSales>(entity =>
            {
                entity.Property(e => e.DeliverDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentReceiptCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.TbSales)
                    .HasForeignKey(d => d.AgencyId)
                    .HasConstraintName("FK_TbSales_TbAgency");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.TbSales)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK_TbSales_TbCar");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TbSales)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_TbSales_TCustomer");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
