using MatteoRbProject.Models;
using Microsoft.EntityFrameworkCore;

namespace MatteoRbProject.Context
{
    public class MatteoRbProjectContext : DbContext
    {
        public MatteoRbProjectContext(DbContextOptions<MatteoRbProjectContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appartment>()
                .HasOne(a => a.Advert)
                .WithOne(ad => ad.Appartment)
                .HasForeignKey<Advert>(ad => ad.AppartmentId);

            modelBuilder.Entity<Appartment>()
                     .HasOne<Address>(a => a.Address)
                     .WithMany(p => p.Appartments)
                     .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Property>()
                    .HasOne<QueueRule>(p => p.QueueRule)
                    .WithMany(q => q.Properties)
                    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Appartment>()
                   .HasOne<QueueRule>(p => p.QueueRule)
                   .WithMany(q => q.Appartments)
                   .OnDelete(DeleteBehavior.Restrict);

            Guid queueGuid1 = Guid.Parse("9aa02117-7045-4633-9297-e8ead75035cf");
            Guid queueGuid2 = Guid.Parse("e6d45b39-2c2c-4880-ba9e-ffd3c52c4ebb");
            Guid queueGuid3 = Guid.Parse("6055f821-bf36-4a3a-981d-3e80236adcb0");

            Guid propertyGuid1 = Guid.Parse("5eba581f-1428-4630-bc95-f3e1b6ae02ca");
            Guid propertyGuid2 = Guid.Parse("77113cee-6316-4ed3-8003-9eefa714d0fd");
            Guid propertyGuid3 = Guid.Parse("dc69538b-3542-4177-bb33-498a2c4b3a91");

            Guid addressGuid1 = Guid.Parse("b1e70dd0-5bad-4ef1-8945-ff03ca919baa");
            Guid addressGuid2 = Guid.Parse("0b06e800-bf7c-4d65-b00f-722f2280f5b9");
            Guid addressGuid3 = Guid.Parse("3b915c92-bba9-48d4-84d5-c142f92a4d25");

            Guid appartmentGuid1 = Guid.Parse("7201b81b-3d99-4476-ac3c-1f4518b7e9f9");
            Guid appartmentGuid2 = Guid.Parse("cd80e77e-5815-4b4a-8ca7-45bf51dd42d3");
            Guid appartmentGuid3 = Guid.Parse("213c995a-0463-4030-aa10-227b39e989e7");

            Guid advertGuid1 = Guid.Parse("24753fad-0fb9-4250-ab3a-07a5038efadc");
            Guid advertGuid2 = Guid.Parse("1b8c7aee-fcf2-45c7-8c96-ef0325f441f5");
            Guid advertGuid3 = Guid.Parse("e0ea918d-4406-4830-beaa-ec8025b326c7");

            modelBuilder.Entity<QueueRule>().HasData(new QueueRule { Id = queueGuid1, Name = "Köregel 1" });
            modelBuilder.Entity<QueueRule>().HasData(new QueueRule { Id = queueGuid2, Name = "Köregel 2" });
            modelBuilder.Entity<QueueRule>().HasData(new QueueRule { Id = queueGuid3, Name = "Köregel 3" });

            modelBuilder.Entity<Property>().HasData(new Property { Id = propertyGuid1, ObjectNumber = "1234-5678", LMNumber = 123456, QueueRuleId = queueGuid1 });
            modelBuilder.Entity<Property>().HasData(new Property { Id = propertyGuid2, ObjectNumber = "8765-4321", LMNumber = 234561, QueueRuleId = queueGuid2 });
            modelBuilder.Entity<Property>().HasData(new Property { Id = propertyGuid3, ObjectNumber = "9876-5432", LMNumber = 345612, QueueRuleId = queueGuid3 });

            modelBuilder.Entity<Address>().HasData(new Address { Id = addressGuid1, Street = "Snapphanevägen", Number = 12, NumberAffix = "C", City = "Kristianstad", PostalCode = "291 50", County = "Skåne", PropertyId = propertyGuid1 });
            modelBuilder.Entity<Address>().HasData(new Address { Id = addressGuid2, Street = "Blekingevägen", Number = 18, NumberAffix = "E", City = "Kristianstad", PostalCode = "291 30", County = "Skåne", PropertyId = propertyGuid2 });
            modelBuilder.Entity<Address>().HasData(new Address { Id = addressGuid3, Street = "Kanalgatan", Number = 7, NumberAffix = "B", City = "Kristianstad", PostalCode = "291 21", County = "Skåne", PropertyId = propertyGuid3 });

            modelBuilder.Entity<Appartment>().HasData(new Appartment { Id = appartmentGuid1, AddressId = addressGuid1, QueueRuleId = queueGuid1, PropertyId = propertyGuid1, ObjectNumber = "9876-5432", LMNumber = 345612 });

            modelBuilder.Entity<Appartment>().HasData(new Appartment { Id = appartmentGuid2, AddressId = addressGuid2, QueueRuleId = queueGuid2, PropertyId = propertyGuid2, ObjectNumber = "9876-5432", LMNumber = 345612, AdvertId = advertGuid2 });

            modelBuilder.Entity<Appartment>().HasData(new Appartment { Id = appartmentGuid3, AddressId = addressGuid3, QueueRuleId = queueGuid3, PropertyId = propertyGuid2, ObjectNumber = "9876-5432", LMNumber = 345612 });


            modelBuilder.Entity<Advert>().HasData(new Advert { Id = advertGuid1, AppartmentId = appartmentGuid2, AdvertText = "Detta är den fetaste lägenheten på marknaden. Inga djur, inga rökare, inga människor!" });
            var queueGuids = SeedingData.GenerateGuids(100);
            var propertyGuids = SeedingData.GenerateGuids(100);
            var addressGuids = SeedingData.GenerateGuids(100);
            var appartmentGuids = SeedingData.GenerateGuids(100);
            var advertGuids = SeedingData.GenerateGuids(100);

            // Seed QueueRules
            for (int i = 0; i < queueGuids.Count; i++)
            {
                modelBuilder.Entity<QueueRule>().HasData(new QueueRule { Id = queueGuids[i], Name = $"Köregel {i + 1}" });
            }

            // Seed Properties and maintain relationships
            for (int i = 0; i < propertyGuids.Count; i++)
            {
                modelBuilder.Entity<Property>().HasData(new Property
                {
                    Id = propertyGuids[i],
                    ObjectNumber = $"ObjectNumber{i + 1}",
                    LMNumber = i + 1,
                    QueueRuleId = queueGuids[i % queueGuids.Count]
                });
            }

            // Seed Addresses and maintain relationships
            for (int i = 0; i < addressGuids.Count; i++)
            {
                modelBuilder.Entity<Address>().HasData(new Address
                {
                    Id = addressGuids[i],
                    Street = $"Street{i + 1}",
                    Number = i + 1,
                    NumberAffix = $"Affix{i + 1}",
                    City = $"City{i + 1}",
                    PostalCode = $"PostalCode{i + 1}",
                    County = $"County{i + 1}",
                    PropertyId = propertyGuids[i % propertyGuids.Count]
                });
            }

            // Seed Appartments and maintain relationships
            for (int i = 0; i < appartmentGuids.Count; i++)
            {
                modelBuilder.Entity<Appartment>().HasData(new Appartment
                {
                    Id = appartmentGuids[i],
                    AddressId = addressGuids[i % addressGuids.Count],
                    QueueRuleId = queueGuids[i % queueGuids.Count],
                    PropertyId = propertyGuids[i % propertyGuids.Count],
                    ObjectNumber = $"ObjectNumber{i + 1}",
                    LMNumber = i + 1,
                    AdvertId = advertGuids[i % advertGuids.Count]
                });
            }

            // Seed Adverts and maintain relationships
            for (int i = 0; i < advertGuids.Count; i++)
            {
                modelBuilder.Entity<Advert>().HasData(new Advert
                {
                    Id = advertGuids[i],
                    AppartmentId = appartmentGuids[i % appartmentGuids.Count],
                    AdvertText = $"AdvertText{i + 1}"
                });
            }

        }

    public DbSet<Property> Properties {get; set;}
        public DbSet<Appartment> Appartments {get; set;}
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<QueueRule> QueueRules { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Application> Applications { get; set; }



    }
}

