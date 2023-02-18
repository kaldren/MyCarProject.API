using Microsoft.EntityFrameworkCore;
using Troshka.Domain.Entities.OwnerAggregate;
using Troshka.Domain.Entities.VehicleAggregate;
using Troshka.Domain.Entities.VehicleAggregate.Car;

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
                .Entity<CategoryEntity>()
                .ToTable("Categories");

            modelBuilder
                .Entity<CategoryEntity>()
                .HasData(
                    new CategoryEntity { Id = "0Uun56AGjKNM2f07qMBS", Name = "Cars" },
                    new CategoryEntity { Id = "AhHuT41lRddLH1wachlm", Name = "Buses" },
                    new CategoryEntity { Id = "DARdvjHJcTyGCYGekfIn", Name = "Motorcycles" },
                    new CategoryEntity { Id = "ExCL3LNxUqXNC8LFF8rL", Name = "Trucks" },
                    new CategoryEntity { Id = "GFF7R0xsM4muSxEG8k0J", Name = "Caravans" },
                    new CategoryEntity { Id = "lnm5mTuNV56JTQQYWPRe", Name = "Boats" },
                    new CategoryEntity { Id = "NUSX1N5R2xUS9WfTo3lp", Name = "Construction" },
                    new CategoryEntity { Id = "poo2JeVEhMn8wJz0KJdR", Name = "Agriciltural" }
                );

            #region Cars
            modelBuilder
                .Entity<CarBrandEntity>()
                .ToTable("CarBrands");

            modelBuilder
                .Entity<CarBrandEntity>()
                .HasData(
                    new CarBrandEntity { Id = "06MxFkB3ArFfVraVWN1u", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "AC" },
                    new CarBrandEntity { Id = "0SlIJFKD3VdaMAEnxfTT", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Abarth" },
                    new CarBrandEntity { Id = "2FEzeyYHYe3zlhjMeaEF", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Acura" },
                    new CarBrandEntity { Id = "2SBENlnqR76XRNAjbAs3", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Aixam" },
                    new CarBrandEntity { Id = "2VS5yLgAuj7VmYeRVxTD", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Alfa Romeo" },
                    new CarBrandEntity { Id = "2xSRLgR4QgzYhDLjfgAM", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Alpina" },
                    new CarBrandEntity { Id = "3qGrKAnyJ2rmHlevXb8c", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Aro" },
                    new CarBrandEntity { Id = "3yTpJND7nxjtqoDcuc5M", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Asia" },
                    new CarBrandEntity { Id = "470SJrcKER8YaPHSS0br", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Aston martin" },
                    new CarBrandEntity { Id = "48xSUCHrRIfABkLmGHxD", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Audi" },
                    new CarBrandEntity { Id = "5aFWwvagmpfBWQlHxU5M", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Austin" },
                    new CarBrandEntity { Id = "5kDhCqXf6JTAIvz61oEz", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "BMW" },
                    new CarBrandEntity { Id = "5TgVdpBPF4SsQWVFP08j", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Bentley" },
                    new CarBrandEntity { Id = "65B72rCez5bGWR7Po3Ny", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Berliner" },
                    new CarBrandEntity { Id = "6mI4J3fGUdG5KvEHYjqL", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Bertone" },
                    new CarBrandEntity { Id = "7ReFhJXxyx7pAkvlW1eS", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Borgward" },
                    new CarBrandEntity { Id = "8mIlNn2498yIC72vgKBK", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Brilliance" },
                    new CarBrandEntity { Id = "9NRn3UNnrPnf2yJoGIBH", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Bugatti" },
                    new CarBrandEntity { Id = "aPIB6410rSAP3jxueo2Y", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Buick" },
                    new CarBrandEntity { Id = "ATbb9NezfDxSdpBXdqd6", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Cadillac" },
                    new CarBrandEntity { Id = "Ax8799hb0Tb2gk2WARk6", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Carbodies" },
                    new CarBrandEntity { Id = "B42TXsELwNJNBewRvcu5", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Chery" },
                    new CarBrandEntity { Id = "BESQA89ghmpmxnMv6lb4", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Chevrolet" },
                    new CarBrandEntity { Id = "bshsdfzU1lNaPe58k9Io", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Chrysler" },
                    new CarBrandEntity { Id = "bXGDbcoVlUUFaUAeuBhU", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Citroen" },
                    new CarBrandEntity { Id = "bymbQs0TabKzPsrN3TlL", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Corvette" },
                    new CarBrandEntity { Id = "CDKhu32A8uPkeWM4eblC", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Cupra" },
                    new CarBrandEntity { Id = "cjnwEk8Wle037jtonYsj", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "DONGFENG" },
                    new CarBrandEntity { Id = "cYgoBzV1QqkgGALBMqxE", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "DS" },
                    new CarBrandEntity { Id = "cYlq5o6z4W9RcnLLB6zq", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Dacia" },
                    new CarBrandEntity { Id = "D67BxpjC6stcD4YYGmdn", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Daewoo" },
                    new CarBrandEntity { Id = "D6a4Vo3VE2WzDdgA5AFo", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Daihatsu" },
                    new CarBrandEntity { Id = "d6V8Py7xGhHTTVvS02QR", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Daimler" },
                    new CarBrandEntity { Id = "Dfej8VedBqRvW5SVCeo3", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Datsun" },
                    new CarBrandEntity { Id = "dksqVUhgDuHJ9KJ2uqyP", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Dkw" },
                    new CarBrandEntity { Id = "DsQDYqGhCx8KL7zF4UFK", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Dodge" },
                    new CarBrandEntity { Id = "DumA309cvKSKLalqcW6h", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Dr" },
                    new CarBrandEntity { Id = "DV94kh1MyMbGW3P4aac5", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Eagle" },
                    new CarBrandEntity { Id = "e7NrNKeWFc73uCAkz1Ar", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "FSO" },
                    new CarBrandEntity { Id = "eF1lrB1EP63Y0DablBJF", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Ferrari" },
                    new CarBrandEntity { Id = "EMczl7VAvCRwT3kAz4In", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Fiat" },
                    new CarBrandEntity { Id = "emn3h8NrhdSz7ojPBV2H", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Ford" },
                    new CarBrandEntity { Id = "etMtb4JLm7eB90mlnd72", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "GOUPIL" },
                    new CarBrandEntity { Id = "eUMYrz00U0nQH5KTc7uR", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Gaz" },
                    new CarBrandEntity { Id = "fAVrUUNVKFbMuNlP7oUW", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Geely" },
                    new CarBrandEntity { Id = "FcCNt3RVlzMFl9Jtw38m", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Genesis" },
                    new CarBrandEntity { Id = "Fjw2xBL9BqCaQBzxcxDI", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Geo" },
                    new CarBrandEntity { Id = "FtX2HosXUQDnvSScsyP8", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Gmc" },
                    new CarBrandEntity { Id = "FXHe5SU6zyIfYHPGygNC", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Gonow" },
                    new CarBrandEntity { Id = "GBnMMAvdjskIFpKTYLb1", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Great Wall" },
                    new CarBrandEntity { Id = "ghyFhm7jzcjYDrjMVLs1", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Haval" },
                    new CarBrandEntity { Id = "gXuBjVjveGKf3R9Kc9vE", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Heinkel" },
                    new CarBrandEntity { Id = "h6Bfvk5LdFwXv9QzKLxU", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Hillman" },
                    new CarBrandEntity { Id = "hajLAGmn9WWXQco4CXw1", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Honda" },
                    new CarBrandEntity { Id = "Hc1zhgoBCF1639Rp1PkY", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Hummer" },
                    new CarBrandEntity { Id = "HhvYG9GBNEg7RhQBIjtY", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Hyundai" },
                    new CarBrandEntity { Id = "HKjqbIm3EQ96YdfpakFI", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Ifa" },
                    new CarBrandEntity { Id = "HrERVHUdBMrdUrgLsvuT", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Infiniti" },
                    new CarBrandEntity { Id = "hy7DsFSFE0ugKvGj8Hfk", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Innocenti" },
                    new CarBrandEntity { Id = "IIqtbBpQcKHy7TVA10Nl", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Isuzu" },
                    new CarBrandEntity { Id = "IR6qs66ukTVnB4w0NIFq", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Iveco" },
                    new CarBrandEntity { Id = "j0N3jEL5HfQ9Ve0KVNUl", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "JAC" },
                    new CarBrandEntity { Id = "J3wnurM4CgKVkRFfRvHs", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "JAS" },
                    new CarBrandEntity { Id = "JqgJmqpSsWvQ7b60GLvq", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Jaguar" },
                    new CarBrandEntity { Id = "jyCumAseWnFjQjPzn3kQ", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Jeep" },
                    new CarBrandEntity { Id = "k4Lylg5nrM6Vt1MrWfxS", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Jpx" },
                    new CarBrandEntity { Id = "KCEkkBQL72L0jmEutbgl", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Kia" },
                    new CarBrandEntity { Id = "kF0x9WcUJs7aHYtoKzWY", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Lada" },
                    new CarBrandEntity { Id = "KQMma7dRwtXlcym9oSWC", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Laforza" },
                    new CarBrandEntity { Id = "KRmmVEwPAtzSzJQgD6HY", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Lamborghini" },
                    new CarBrandEntity { Id = "KvyHwQN3QMrXmgbsvne9", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Lancia" },
                    new CarBrandEntity { Id = "kXULxNaVDJWKs2ACmH5C", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Land Rover" },
                    new CarBrandEntity { Id = "l5Xv7WgEwDFBEEnFG9uC", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Landwind" },
                    new CarBrandEntity { Id = "laJM8lrsRY8D0eRYypqk", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Lexus" },
                    new CarBrandEntity { Id = "LcuKvSewzBSW3KEJdLIa", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Lifan" },
                    new CarBrandEntity { Id = "lEVEcrE9FIVtGbtFarHV", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Lincoln" },
                    new CarBrandEntity { Id = "lgRSEHsdarS0gC4osQWQ", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Lotus" },
                    new CarBrandEntity { Id = "Lxge9Bn07u7pWE0RqbwJ", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "MG" },
                    new CarBrandEntity { Id = "m5L90Q8l2fTcbPyeA3GF", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Mahindra" },
                    new CarBrandEntity { Id = "mEjXfYc5wzIHYnGGpCbE", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Maserati" },
                    new CarBrandEntity { Id = "MlFe1uw8xqqhdAUnqcHd", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Matra" },
                    new CarBrandEntity { Id = "MvMqrrJaUbAAVIvJHQcu", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Maybach" },
                    new CarBrandEntity { Id = "MX3aL9JN6gD0F4KRl0Nq", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Mazda" },
                    new CarBrandEntity { Id = "n1jg2wtcteSRvhvMGm4n", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "McLaren" },
                    new CarBrandEntity { Id = "nDxKpo5IAKk62ekEBbNS", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Mercedes-Benz" },
                    new CarBrandEntity { Id = "nm2AJSoa0dWnayDNBRnh", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Mercury" },
                    new CarBrandEntity { Id = "NMcNGk5M7BQVx7sruCbI", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Mg" },
                    new CarBrandEntity { Id = "nsITvMBs2Ujtv8rQ0KJM", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Microcar" },
                    new CarBrandEntity { Id = "nul5YjFdxToWeg1GrlCX", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Mini" },
                    new CarBrandEntity { Id = "nWD6UJdXnV7cjq8tP6R8", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Mitsubishi" },
                    new CarBrandEntity { Id = "oyETMjvBlpVLEDFlVADI", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Morgan" },
                    new CarBrandEntity { Id = "p4hD4RsKIPD68JMtt4N2", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Moskvich" },
                    new CarBrandEntity { Id = "p6Wbw5sW2Fj67lvp482v", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Nissan" },
                    new CarBrandEntity { Id = "pjQ5tv7x5L1UYaKzhokc", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Oldsmobile" },
                    new CarBrandEntity { Id = "PpQFVF4cAQlfX3BppjFB", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Opel" },
                    new CarBrandEntity { Id = "PsbTIAKWHCVgruG7IgRE", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Perodua" },
                    new CarBrandEntity { Id = "pTCUtnhqCmkJALgYU8NY", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Peugeot" },
                    new CarBrandEntity { Id = "Q6kJ5uDgBmklCCBwofrx", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Pgo" },
                    new CarBrandEntity { Id = "QExc6n8HRxp39gGTKXSt", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Plymouth" },
                    new CarBrandEntity { Id = "qnkV2dT7G6arP780Dwxs", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Polestar" },
                    new CarBrandEntity { Id = "QojugShL0F4QRXbwv1r3", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Polonez" },
                    new CarBrandEntity { Id = "QS0jwSg5owyS3XS5xnbY", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Pontiac" },
                    new CarBrandEntity { Id = "R0e7DzoQBFL5UIyTpqDP", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Porsche" },
                    new CarBrandEntity { Id = "R9BIHlzCwb67GPT89e7F", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Proton" },
                    new CarBrandEntity { Id = "RgqbbBCJaJLWTlu87M9R", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Qoros" },
                    new CarBrandEntity { Id = "RRr4RDrnqyqmT3ehdy6Q", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Renault" },
                    new CarBrandEntity { Id = "RuSMmRIATbwWRYSkgIrH", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Rieju" },
                    new CarBrandEntity { Id = "rYJp3Jg61wKdUqFGSAp3", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Rolls-Royce" },
                    new CarBrandEntity { Id = "sAKTDDgl9EDeyYnG77R8", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Rover" },
                    new CarBrandEntity { Id = "SGKURGhEbYHIdqkxpDJh", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "SECMA" },
                    new CarBrandEntity { Id = "Sn4CRrl6hfVTTra5B0pd", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "SH auto" },
                    new CarBrandEntity { Id = "sQ5C4f7H60rzJLhMA0T5", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Saab" },
                    new CarBrandEntity { Id = "sSh78RpjbHGvjL43TzMl", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Samand" },
                    new CarBrandEntity { Id = "Sw3e46nyzgd7zmMPVG4r", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Santana" },
                    new CarBrandEntity { Id = "sx9Vqv3yxRnX4SGwQa4y", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Saturn" },
                    new CarBrandEntity { Id = "T8karRTfSTcM29oupBnt", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Scion" },
                    new CarBrandEntity { Id = "t9gPoXWQAlKYkzxc7EaK", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Seat" },
                    new CarBrandEntity { Id = "TjjXJlSeru5Ccm3G2Vet", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Shatenet" },
                    new CarBrandEntity { Id = "TJTAqICS7fjRu8I4afxm", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Shuanghuan" },
                    new CarBrandEntity { Id = "Tuaz0kuNQvU5jsy459u2", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Simca" },
                    new CarBrandEntity { Id = "TXVRNj5SbqClTvNfEI8c", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Skoda" },
                    new CarBrandEntity { Id = "u3lzgWdKo9KaByo34lmN", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Smart" },
                    new CarBrandEntity { Id = "u7vXPV3aAy2tk09ebfk7", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Ssang yong" },
                    new CarBrandEntity { Id = "UG6N8tBL4hpBPkjX12Bh", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "SsangYong" },
                    new CarBrandEntity { Id = "ulCdKx22IbD50hbfYtIE", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Subaru" },
                    new CarBrandEntity { Id = "UpE1pLHfAgAQDHEVWdAb", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Suzuki" },
                    new CarBrandEntity { Id = "UpsGGKBQ2fXfNQBgABoF", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Talbot" },
                    new CarBrandEntity { Id = "v1Q2gNvx2B1YX6h2w0TR", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Tata" },
                    new CarBrandEntity { Id = "v4vruTNk6WkdcxN3fFA0", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Tavria" },
                    new CarBrandEntity { Id = "V9HWmNFfpUS2Y5eLqrct", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Tazzari" },
                    new CarBrandEntity { Id = "vMFor3Ks1QECjDpWHUqW", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Tempo" },
                    new CarBrandEntity { Id = "vYf86TFDqUkh9RcEN9VN", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Terberg" },
                    new CarBrandEntity { Id = "W5TnArCA9xCEodsTpDHG", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Tesla" },
                    new CarBrandEntity { Id = "wC0Q8eUqQLkE6cpVwHgu", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Tofas" },
                    new CarBrandEntity { Id = "wDseIgWSpqkLesX2ftwn", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Toyota" },
                    new CarBrandEntity { Id = "whPfE6p1LaKgaGTWoNqj", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Trabant" },
                    new CarBrandEntity { Id = "wMQSzkfJzJhYwfV22Ew6", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Triumph" },
                    new CarBrandEntity { Id = "wwSqJWvMPuau2LBxW24w", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Uaz" },
                    new CarBrandEntity { Id = "XECbl6phGcsYXQWHwrT7", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "VROMOS" },
                    new CarBrandEntity { Id = "xHqKd4nN6cMLEAaL4zdp", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "VW" },
                    new CarBrandEntity { Id = "XQ0Nk2N0zDYDydY9CEpC", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Volga" },
                    new CarBrandEntity { Id = "xqP1xuan2MoXnMkwolM7", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Volvo" },
                    new CarBrandEntity { Id = "Xsx7AcUNguMUYwC2eInr", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Warszawa" },
                    new CarBrandEntity { Id = "XW7Xpw80z3VgX82egcWN", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Wartburg" },
                    new CarBrandEntity { Id = "Xz43eo1VM5H41uNJ9x28", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Wiesmann" },
                    new CarBrandEntity { Id = "yjnmBGS0tfeUY6wppqlL", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Xinkai" },
                    new CarBrandEntity { Id = "YK3JYVEmHcskgB4f1s9M", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Xinshun" },
                    new CarBrandEntity { Id = "yL0kvEf81nf8Sd7CGQys", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Yogomo" },
                    new CarBrandEntity { Id = "YSHfWTR5rJ8vCR2S95xp", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Zastava" },
                    new CarBrandEntity { Id = "YUWNuWGy76j0cK9LWTP8", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Zaz" },
                    new CarBrandEntity { Id = "zlaX6newWoQPagELHC4J", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Other" },
                    new CarBrandEntity { Id = "zmtbQwqcCyHjrSKk77Se", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Победа" },
                    new CarBrandEntity { Id = "zpPwsvLWKJ4CmjHmU1ES", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "София" },
                    new CarBrandEntity { Id = "zvQcGcl1nR7SpAfIMvxF", CategoryId = "0Uun56AGjKNM2f07qMBS", Name = "Чайка" }
                );
            #endregion Cars

            #region Trucks
            #endregion Trucks

            #region Motorcycles
            #endregion Motorcycles

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
