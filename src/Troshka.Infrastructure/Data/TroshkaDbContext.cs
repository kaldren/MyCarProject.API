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
                    new VehicleCategoryEntity { Id = "0Uun56AGjKNM2f07qMBS", Name = "Cars" },
                    new VehicleCategoryEntity { Id = "AhHuT41lRddLH1wachlm", Name = "Buses" },
                    new VehicleCategoryEntity { Id = "DARdvjHJcTyGCYGekfIn", Name = "Motorcycles" },
                    new VehicleCategoryEntity { Id = "ExCL3LNxUqXNC8LFF8rL", Name = "Trucks" },
                    new VehicleCategoryEntity { Id = "GFF7R0xsM4muSxEG8k0J", Name = "Caravans" },
                    new VehicleCategoryEntity { Id = "lnm5mTuNV56JTQQYWPRe", Name = "Boats" },
                    new VehicleCategoryEntity { Id = "NUSX1N5R2xUS9WfTo3lp", Name = "Construction" },
                    new VehicleCategoryEntity { Id = "poo2JeVEhMn8wJz0KJdR", Name = "Agriciltural" }
                );

            modelBuilder
                .Entity<VehicleBrandEntity>()
                .ToTable("Brands");

            modelBuilder
                .Entity<VehicleBrandEntity>()
                .HasData(
                    new VehicleBrandEntity { Id = "06MxFkB3ArFfVraVWN1u", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "AC" },
                    new VehicleBrandEntity { Id = "0SlIJFKD3VdaMAEnxfTT", Name = "Abarth" },
                    new VehicleBrandEntity { Id = "2FEzeyYHYe3zlhjMeaEF", Name = "Acura" },
                    new VehicleBrandEntity { Id = "2SBENlnqR76XRNAjbAs3", Name = "Aixam" },
                    new VehicleBrandEntity { Id = "2VS5yLgAuj7VmYeRVxTD", Name = "Alfa Romeo" },
                    new VehicleBrandEntity { Id = "2xSRLgR4QgzYhDLjfgAM", Name = "Alpina" },
                    new VehicleBrandEntity { Id = "3qGrKAnyJ2rmHlevXb8c", Name = "Aro" },
                    new VehicleBrandEntity { Id = "3yTpJND7nxjtqoDcuc5M", Name = "Asia" },
                    new VehicleBrandEntity { Id = "470SJrcKER8YaPHSS0br", Name = "Aston martin" },
                    new VehicleBrandEntity { Id = "48xSUCHrRIfABkLmGHxD", Name = "Audi" },
                    new VehicleBrandEntity { Id = "5aFWwvagmpfBWQlHxU5M", Name = "Austin" },
                    new VehicleBrandEntity { Id = "5kDhCqXf6JTAIvz61oEz", Name = "BMW" },
                    new VehicleBrandEntity { Id = "5TgVdpBPF4SsQWVFP08j", Name = "Bentley" },
                    new VehicleBrandEntity { Id = "65B72rCez5bGWR7Po3Ny", Name = "Berliner" },
                    new VehicleBrandEntity { Id = "6mI4J3fGUdG5KvEHYjqL", Name = "Bertone" },
                    new VehicleBrandEntity { Id = "7ReFhJXxyx7pAkvlW1eS", Name = "Borgward" },
                    new VehicleBrandEntity { Id = "8mIlNn2498yIC72vgKBK", Name = "Brilliance" },
                    new VehicleBrandEntity { Id = "9NRn3UNnrPnf2yJoGIBH", Name = "Bugatti" },
                    new VehicleBrandEntity { Id = "aPIB6410rSAP3jxueo2Y", Name = "Buick" },
                    new VehicleBrandEntity { Id = "ATbb9NezfDxSdpBXdqd6", Name = "Cadillac" },
                    new VehicleBrandEntity { Id = "Ax8799hb0Tb2gk2WARk6", Name = "Carbodies" },
                    new VehicleBrandEntity { Id = "B42TXsELwNJNBewRvcu5", Name = "Chery" },
                    new VehicleBrandEntity { Id = "BESQA89ghmpmxnMv6lb4", Name = "Chevrolet" },
                    new VehicleBrandEntity { Id = "bshsdfzU1lNaPe58k9Io", Name = "Chrysler" },
                    new VehicleBrandEntity { Id = "bXGDbcoVlUUFaUAeuBhU", Name = "Citroen" },
                    new VehicleBrandEntity { Id = "bymbQs0TabKzPsrN3TlL", Name = "Corvette" },
                    new VehicleBrandEntity { Id = "CDKhu32A8uPkeWM4eblC", Name = "Cupra" },
                    new VehicleBrandEntity { Id = "cjnwEk8Wle037jtonYsj", Name = "DONGFENG" },
                    new VehicleBrandEntity { Id = "cYgoBzV1QqkgGALBMqxE", Name = "DS" },
                    new VehicleBrandEntity { Id = "cYlq5o6z4W9RcnLLB6zq", Name = "Dacia" },
                    new VehicleBrandEntity { Id = "D67BxpjC6stcD4YYGmdn", Name = "Daewoo" },
                    new VehicleBrandEntity { Id = "D6a4Vo3VE2WzDdgA5AFo", Name = "Daihatsu" },
                    new VehicleBrandEntity { Id = "d6V8Py7xGhHTTVvS02QR", Name = "Daimler" },
                    new VehicleBrandEntity { Id = "Dfej8VedBqRvW5SVCeo3", Name = "Datsun" },
                    new VehicleBrandEntity { Id = "dksqVUhgDuHJ9KJ2uqyP", Name = "Dkw" },
                    new VehicleBrandEntity { Id = "DsQDYqGhCx8KL7zF4UFK", Name = "Dodge" },
                    new VehicleBrandEntity { Id = "DumA309cvKSKLalqcW6h", Name = "Dr" },
                    new VehicleBrandEntity { Id = "DV94kh1MyMbGW3P4aac5", Name = "Eagle" },
                    new VehicleBrandEntity { Id = "e7NrNKeWFc73uCAkz1Ar", Name = "FSO" },
                    new VehicleBrandEntity { Id = "eF1lrB1EP63Y0DablBJF", Name = "Ferrari" },
                    new VehicleBrandEntity { Id = "EMczl7VAvCRwT3kAz4In", Name = "Fiat" },
                    new VehicleBrandEntity { Id = "emn3h8NrhdSz7ojPBV2H", Name = "Ford" },
                    new VehicleBrandEntity { Id = "etMtb4JLm7eB90mlnd72", Name = "GOUPIL" },
                    new VehicleBrandEntity { Id = "eUMYrz00U0nQH5KTc7uR", Name = "Gaz" },
                    new VehicleBrandEntity { Id = "fAVrUUNVKFbMuNlP7oUW", Name = "Geely" },
                    new VehicleBrandEntity { Id = "FcCNt3RVlzMFl9Jtw38m", Name = "Genesis" },
                    new VehicleBrandEntity { Id = "Fjw2xBL9BqCaQBzxcxDI", Name = "Geo" },
                    new VehicleBrandEntity { Id = "FtX2HosXUQDnvSScsyP8", Name = "Gmc" },
                    new VehicleBrandEntity { Id = "FXHe5SU6zyIfYHPGygNC", Name = "Gonow" },
                    new VehicleBrandEntity { Id = "GBnMMAvdjskIFpKTYLb1", Name = "Great Wall" },
                    new VehicleBrandEntity { Id = "ghyFhm7jzcjYDrjMVLs1", Name = "Haval" },
                    new VehicleBrandEntity { Id = "gXuBjVjveGKf3R9Kc9vE", Name = "Heinkel" },
                    new VehicleBrandEntity { Id = "h6Bfvk5LdFwXv9QzKLxU", Name = "Hillman" },
                    new VehicleBrandEntity { Id = "hajLAGmn9WWXQco4CXw1", Name = "Honda" },
                    new VehicleBrandEntity { Id = "Hc1zhgoBCF1639Rp1PkY", Name = "Hummer" },
                    new VehicleBrandEntity { Id = "HhvYG9GBNEg7RhQBIjtY", Name = "Hyundai" },
                    new VehicleBrandEntity { Id = "HKjqbIm3EQ96YdfpakFI", Name = "Ifa" },
                    new VehicleBrandEntity { Id = "HrERVHUdBMrdUrgLsvuT", Name = "Infiniti" },
                    new VehicleBrandEntity { Id = "hy7DsFSFE0ugKvGj8Hfk", Name = "Innocenti" },
                    new VehicleBrandEntity { Id = "IIqtbBpQcKHy7TVA10Nl", Name = "Isuzu" },
                    new VehicleBrandEntity { Id = "IR6qs66ukTVnB4w0NIFq", Name = "Iveco" },
                    new VehicleBrandEntity { Id = "j0N3jEL5HfQ9Ve0KVNUl", Name = "JAC" },
                    new VehicleBrandEntity { Id = "J3wnurM4CgKVkRFfRvHs", Name = "JAS" },
                    new VehicleBrandEntity { Id = "JqgJmqpSsWvQ7b60GLvq", Name = "Jaguar" },
                    new VehicleBrandEntity { Id = "jyCumAseWnFjQjPzn3kQ", Name = "Jeep" },
                    new VehicleBrandEntity { Id = "k4Lylg5nrM6Vt1MrWfxS", Name = "Jpx" },
                    new VehicleBrandEntity { Id = "KCEkkBQL72L0jmEutbgl", Name = "Kia" },
                    new VehicleBrandEntity { Id = "kF0x9WcUJs7aHYtoKzWY", Name = "Lada" },
                    new VehicleBrandEntity { Id = "KQMma7dRwtXlcym9oSWC", Name = "Laforza" },
                    new VehicleBrandEntity { Id = "KRmmVEwPAtzSzJQgD6HY", Name = "Lamborghini" },
                    new VehicleBrandEntity { Id = "KvyHwQN3QMrXmgbsvne9", Name = "Lancia" },
                    new VehicleBrandEntity { Id = "kXULxNaVDJWKs2ACmH5C", Name = "Land Rover" },
                    new VehicleBrandEntity { Id = "l5Xv7WgEwDFBEEnFG9uC", Name = "Landwind" },
                    new VehicleBrandEntity { Id = "laJM8lrsRY8D0eRYypqk", Name = "Lexus" },
                    new VehicleBrandEntity { Id = "LcuKvSewzBSW3KEJdLIa", Name = "Lifan" },
                    new VehicleBrandEntity { Id = "lEVEcrE9FIVtGbtFarHV", Name = "Lincoln" },
                    new VehicleBrandEntity { Id = "lgRSEHsdarS0gC4osQWQ", Name = "Lotus" },
                    new VehicleBrandEntity { Id = "Lxge9Bn07u7pWE0RqbwJ", Name = "MG" },
                    new VehicleBrandEntity { Id = "m5L90Q8l2fTcbPyeA3GF", Name = "Mahindra" },
                    new VehicleBrandEntity { Id = "mEjXfYc5wzIHYnGGpCbE", Name = "Maserati" },
                    new VehicleBrandEntity { Id = "MlFe1uw8xqqhdAUnqcHd", Name = "Matra" },
                    new VehicleBrandEntity { Id = "MvMqrrJaUbAAVIvJHQcu", Name = "Maybach" },
                    new VehicleBrandEntity { Id = "MX3aL9JN6gD0F4KRl0Nq", Name = "Mazda" },
                    new VehicleBrandEntity { Id = "n1jg2wtcteSRvhvMGm4n", Name = "McLaren" },
                    new VehicleBrandEntity { Id = "nDxKpo5IAKk62ekEBbNS", Name = "Mercedes-Benz" },
                    new VehicleBrandEntity { Id = "nm2AJSoa0dWnayDNBRnh", Name = "Mercury" },
                    new VehicleBrandEntity { Id = "NMcNGk5M7BQVx7sruCbI", Name = "Mg" },
                    new VehicleBrandEntity { Id = "nsITvMBs2Ujtv8rQ0KJM", Name = "Microcar" },
                    new VehicleBrandEntity { Id = "nul5YjFdxToWeg1GrlCX", Name = "Mini" },
                    new VehicleBrandEntity { Id = "nWD6UJdXnV7cjq8tP6R8", Name = "Mitsubishi" },
                    new VehicleBrandEntity { Id = "oyETMjvBlpVLEDFlVADI", Name = "Morgan" },
                    new VehicleBrandEntity { Id = "p4hD4RsKIPD68JMtt4N2", Name = "Moskvich" },
                    new VehicleBrandEntity { Id = "p6Wbw5sW2Fj67lvp482v", Name = "Nissan" },
                    new VehicleBrandEntity { Id = "pjQ5tv7x5L1UYaKzhokc", Name = "Oldsmobile" },
                    new VehicleBrandEntity { Id = "PpQFVF4cAQlfX3BppjFB", Name = "Opel" },
                    new VehicleBrandEntity { Id = "PsbTIAKWHCVgruG7IgRE", Name = "Perodua" },
                    new VehicleBrandEntity { Id = "pTCUtnhqCmkJALgYU8NY", Name = "Peugeot" },
                    new VehicleBrandEntity { Id = "Q6kJ5uDgBmklCCBwofrx", Name = "Pgo" },
                    new VehicleBrandEntity { Id = "QExc6n8HRxp39gGTKXSt", Name = "Plymouth" },
                    new VehicleBrandEntity { Id = "qnkV2dT7G6arP780Dwxs", Name = "Polestar" },
                    new VehicleBrandEntity { Id = "QojugShL0F4QRXbwv1r3", Name = "Polonez" },
                    new VehicleBrandEntity { Id = "QS0jwSg5owyS3XS5xnbY", Name = "Pontiac" },
                    new VehicleBrandEntity { Id = "R0e7DzoQBFL5UIyTpqDP", Name = "Porsche" },
                    new VehicleBrandEntity { Id = "R9BIHlzCwb67GPT89e7F", Name = "Proton" },
                    new VehicleBrandEntity { Id = "RgqbbBCJaJLWTlu87M9R", Name = "Qoros" },
                    new VehicleBrandEntity { Id = "RRr4RDrnqyqmT3ehdy6Q", Name = "Renault" },
                    new VehicleBrandEntity { Id = "RuSMmRIATbwWRYSkgIrH", Name = "Rieju" },
                    new VehicleBrandEntity { Id = "rYJp3Jg61wKdUqFGSAp3", Name = "Rolls-Royce" },
                    new VehicleBrandEntity { Id = "sAKTDDgl9EDeyYnG77R8", Name = "Rover" },
                    new VehicleBrandEntity { Id = "SGKURGhEbYHIdqkxpDJh", Name = "SECMA" },
                    new VehicleBrandEntity { Id = "Sn4CRrl6hfVTTra5B0pd", Name = "SH auto" },
                    new VehicleBrandEntity { Id = "sQ5C4f7H60rzJLhMA0T5", Name = "Saab" },
                    new VehicleBrandEntity { Id = "sSh78RpjbHGvjL43TzMl", Name = "Samand" },
                    new VehicleBrandEntity { Id = "Sw3e46nyzgd7zmMPVG4r", Name = "Santana" },
                    new VehicleBrandEntity { Id = "sx9Vqv3yxRnX4SGwQa4y", Name = "Saturn" },
                    new VehicleBrandEntity { Id = "T8karRTfSTcM29oupBnt", Name = "Scion" },
                    new VehicleBrandEntity { Id = "t9gPoXWQAlKYkzxc7EaK", Name = "Seat" },
                    new VehicleBrandEntity { Id = "TjjXJlSeru5Ccm3G2Vet", Name = "Shatenet" },
                    new VehicleBrandEntity { Id = "TJTAqICS7fjRu8I4afxm", Name = "Shuanghuan" },
                    new VehicleBrandEntity { Id = "Tuaz0kuNQvU5jsy459u2", Name = "Simca" },
                    new VehicleBrandEntity { Id = "TXVRNj5SbqClTvNfEI8c", Name = "Skoda" },
                    new VehicleBrandEntity { Id = "u3lzgWdKo9KaByo34lmN", Name = "Smart" },
                    new VehicleBrandEntity { Id = "u7vXPV3aAy2tk09ebfk7", Name = "Ssang yong" },
                    new VehicleBrandEntity { Id = "UG6N8tBL4hpBPkjX12Bh", Name = "SsangYong" },
                    new VehicleBrandEntity { Id = "ulCdKx22IbD50hbfYtIE", Name = "Subaru" },
                    new VehicleBrandEntity { Id = "UpE1pLHfAgAQDHEVWdAb", Name = "Suzuki" },
                    new VehicleBrandEntity { Id = "UpsGGKBQ2fXfNQBgABoF", Name = "Talbot" },
                    new VehicleBrandEntity { Id = "v1Q2gNvx2B1YX6h2w0TR", Name = "Tata" },
                    new VehicleBrandEntity { Id = "v4vruTNk6WkdcxN3fFA0", Name = "Tavria" },
                    new VehicleBrandEntity { Id = "V9HWmNFfpUS2Y5eLqrct", Name = "Tazzari" },
                    new VehicleBrandEntity { Id = "vMFor3Ks1QECjDpWHUqW", Name = "Tempo" },
                    new VehicleBrandEntity { Id = "vYf86TFDqUkh9RcEN9VN", Name = "Terberg" },
                    new VehicleBrandEntity { Id = "W5TnArCA9xCEodsTpDHG", Name = "Tesla" },
                    new VehicleBrandEntity { Id = "wC0Q8eUqQLkE6cpVwHgu", Name = "Tofas" },
                    new VehicleBrandEntity { Id = "wDseIgWSpqkLesX2ftwn", Name = "Toyota" },
                    new VehicleBrandEntity { Id = "whPfE6p1LaKgaGTWoNqj", Name = "Trabant" },
                    new VehicleBrandEntity { Id = "wMQSzkfJzJhYwfV22Ew6", Name = "Triumph" },
                    new VehicleBrandEntity { Id = "wwSqJWvMPuau2LBxW24w", Name = "Uaz" },
                    new VehicleBrandEntity { Id = "XECbl6phGcsYXQWHwrT7", Name = "VROMOS" },
                    new VehicleBrandEntity { Id = "xHqKd4nN6cMLEAaL4zdp", Name = "VW" },
                    new VehicleBrandEntity { Id = "XQ0Nk2N0zDYDydY9CEpC", Name = "Volga" },
                    new VehicleBrandEntity { Id = "xqP1xuan2MoXnMkwolM7", Name = "Volvo" },
                    new VehicleBrandEntity { Id = "Xsx7AcUNguMUYwC2eInr", Name = "Warszawa" },
                    new VehicleBrandEntity { Id = "XW7Xpw80z3VgX82egcWN", Name = "Wartburg" },
                    new VehicleBrandEntity { Id = "Xz43eo1VM5H41uNJ9x28", Name = "Wiesmann" },
                    new VehicleBrandEntity { Id = "yjnmBGS0tfeUY6wppqlL", Name = "Xinkai" },
                    new VehicleBrandEntity { Id = "YK3JYVEmHcskgB4f1s9M", Name = "Xinshun" },
                    new VehicleBrandEntity { Id = "yL0kvEf81nf8Sd7CGQys", Name = "Yogomo" },
                    new VehicleBrandEntity { Id = "YSHfWTR5rJ8vCR2S95xp", Name = "Zastava" },
                    new VehicleBrandEntity { Id = "YUWNuWGy76j0cK9LWTP8", Name = "Zaz" },
                    new VehicleBrandEntity { Id = "zlaX6newWoQPagELHC4J", Name = "Other" },
                    new VehicleBrandEntity { Id = "zmtbQwqcCyHjrSKk77Se", Name = "Победа" },
                    new VehicleBrandEntity { Id = "zpPwsvLWKJ4CmjHmU1ES", Name = "София" },
                    new VehicleBrandEntity { Id = "zvQcGcl1nR7SpAfIMvxF", Name = "Чайка" }
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
