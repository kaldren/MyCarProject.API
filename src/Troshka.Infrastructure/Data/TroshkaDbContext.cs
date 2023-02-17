using Microsoft.EntityFrameworkCore;
using Troshka.Domain.Entities.OwnerAggregate;
using Troshka.Domain.Entities.VehicleAggregate;

namespace Troshka.Infrastructure.Data
{
    public class TroshkaDbContext : DbContext
    {
        public TroshkaDbContext(DbContextOptions<TroshkaDbContext> options) : base(options)
        {
        }

        public DbSet<VehicleEntity> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<VehicleEntity>()
                .ToTable("Vehicles");

            modelBuilder
                .Entity<VehicleCategoryEntity>()
                .ToTable("Categories");

            modelBuilder
                .Entity<VehicleCategoryEntity>()
                .HasData(
                    new VehicleCategoryEntity { Name = "Cars" },
                    new VehicleCategoryEntity { Name = "Buses" },
                    new VehicleCategoryEntity { Name = "Motorcycles" },
                    new VehicleCategoryEntity { Name = "Trucks" },
                    new VehicleCategoryEntity { Name = "Caravans" },
                    new VehicleCategoryEntity { Name = "Boats" },
                    new VehicleCategoryEntity { Name = "Construction" },
                    new VehicleCategoryEntity { Name = "Agriciltural" }
                );

            modelBuilder
                .Entity<VehicleBrandEntity>()
                .ToTable("Brands");

            modelBuilder
                .Entity<VehicleBrandEntity>()
                .HasData(
                    new VehicleBrandEntity { Name = "Alfa Romeo" },
                    new VehicleBrandEntity { Name = "Aston Martin" },
                    new VehicleBrandEntity { Name = "Audi" },
                    new VehicleBrandEntity { Name = "Bentley" },
                    new VehicleBrandEntity { Name = "BMW" },
                    new VehicleBrandEntity { Name = "Bugatti" },
                    new VehicleBrandEntity { Name = "Cadillac" },
                    new VehicleBrandEntity { Name = "Chevrolet" },
                    new VehicleBrandEntity { Name = "Chrysler" },
                    new VehicleBrandEntity { Name = "Citroen" },
                    new VehicleBrandEntity { Name = "Dacia" },
                    new VehicleBrandEntity { Name = "Daewoo" },
                    new VehicleBrandEntity { Name = "Daihatsu" },
                    new VehicleBrandEntity { Name = "Dodge" },
                    new VehicleBrandEntity { Name = "Donkervoort" },
                    new VehicleBrandEntity { Name = "DS" },
                    new VehicleBrandEntity { Name = "Ferrari" },
                    new VehicleBrandEntity { Name = "Fiat" },
                    new VehicleBrandEntity { Name = "Fisker" },
                    new VehicleBrandEntity { Name = "Ford" },
                    new VehicleBrandEntity { Name = "Honda" },
                    new VehicleBrandEntity { Name = "Hummer" },
                    new VehicleBrandEntity { Name = "Hyundai" },
                    new VehicleBrandEntity { Name = "Infiniti" },
                    new VehicleBrandEntity { Name = "Jaguar" },
                    new VehicleBrandEntity { Name = "Jeep" },
                    new VehicleBrandEntity { Name = "Kia" },
                    new VehicleBrandEntity { Name = "Lada" },
                    new VehicleBrandEntity { Name = "Lamborghini" },
                    new VehicleBrandEntity { Name = "Lancia" },
                    new VehicleBrandEntity { Name = "Land Rover" },
                    new VehicleBrandEntity { Name = "Lexus" },
                    new VehicleBrandEntity { Name = "Lotus" },
                    new VehicleBrandEntity { Name = "Maserati" },
                    new VehicleBrandEntity { Name = "Maybach" },
                    new VehicleBrandEntity { Name = "Mazda" },
                    new VehicleBrandEntity { Name = "McLaren" },
                    new VehicleBrandEntity { Name = "Mercedes-Benz" },
                    new VehicleBrandEntity { Name = "MG" },
                    new VehicleBrandEntity { Name = "Mini" },
                    new VehicleBrandEntity { Name = "Mitsubishi" },
                    new VehicleBrandEntity { Name = "Nissan" },
                    new VehicleBrandEntity { Name = "Opel" },
                    new VehicleBrandEntity { Name = "Peugeot" },
                    new VehicleBrandEntity { Name = "Porsche" },
                    new VehicleBrandEntity { Name = "Renault" },
                    new VehicleBrandEntity { Name = "Rolls-Royce" },
                    new VehicleBrandEntity { Name = "Rover" },
                    new VehicleBrandEntity { Name = "Saab" },
                    new VehicleBrandEntity { Name = "Seat" },
                    new VehicleBrandEntity { Name = "Skoda" },
                    new VehicleBrandEntity { Name = "Smart" },
                    new VehicleBrandEntity { Name = "SsangYong" },
                    new VehicleBrandEntity { Name = "Subaru" },
                    new VehicleBrandEntity { Name = "Suzuki" },
                    new VehicleBrandEntity { Name = "Tesla" },
                    new VehicleBrandEntity { Name = "Toyota" },
                    new VehicleBrandEntity { Name = "Volkswagen" },
                    new VehicleBrandEntity { Name = "Volvo" }
                );

            modelBuilder
                .Entity<VehicleModelEntity>()
                .ToTable("Models");

            modelBuilder
                .Entity<OwnerEntity>()
                .ToTable("Owners");
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var insertedEntries = this.ChangeTracker.Entries()
                                   .Where(x => x.State == EntityState.Added)
                                   .Select(x => x.Entity);

            foreach (var insertedEntry in insertedEntries)
            {
                var auditableEntity = insertedEntry as BaseEntity;
                //If the inserted object is an Auditable. 
                if (auditableEntity != null)
                {
                    auditableEntity.DateCreated = DateTimeOffset.UtcNow;
                }
            }

            var modifiedEntries = this.ChangeTracker.Entries()
                       .Where(x => x.State == EntityState.Modified)
                       .Select(x => x.Entity);

            foreach (var modifiedEntry in modifiedEntries)
            {
                //If the inserted object is an Auditable. 
                var auditableEntity = modifiedEntry as BaseEntity;
                if (auditableEntity != null)
                {
                    auditableEntity.DateUpdated = DateTimeOffset.UtcNow;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
