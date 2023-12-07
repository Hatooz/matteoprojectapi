using MatteoRbProject.Models;

namespace MatteoRbProject.ExtentionMethods
{
    public static class ExtensionMethods
    {

        public static PropertyDTO ToDto(this Property property)
        {
            PropertyDTO dto = new()
            {
                Id = property.Id,
                QueueRule = new QueueRuleDTO() { Id = property.QueueRule.Id, Name = property.QueueRule.Name},
                LMNumber = property.LMNumber,
                ObjectNumber = property.ObjectNumber,
                Addresses = property.Addresses.Select(address => address.ToDto()).ToList(),
                Appartments = property.Appartments.Select(appartment => appartment.ToListDto()).ToList(),

            };
            return dto;
        }


        public static AppartmentListDTO ToListDto (this Appartment appartment)
        {
            AppartmentListDTO dto = new()
            {
                Id = appartment.Id,
                PropertyId = appartment.PropertyId,
                AddressId = appartment.AddressId,
                QueueRuleId = appartment.QueueRuleId,
                AdvertId = appartment.AdvertId  
            };

            return dto;
        }

        public static AppartmentDTO ToDto(this Appartment appartment)
        {
            AppartmentDTO dto = new()
            {
                Id = appartment.Id,
                PropertyId = appartment.PropertyId,
                Address = appartment.Address.ToDto(),
                QueueRule = appartment.QueueRule.ToDto(),
                Advert = appartment.Advert?.ToDto(),
                ObjectNumber = appartment.ObjectNumber,
                LMNumber = appartment.LMNumber,
                TotalApplications = appartment.Applications?.Count,
            };

            return dto;
        }

        public static AddressDTO ToDto (this Address address)
        {
            AddressDTO dto = new()
            {
                Id = address.Id,
                Street = address.Street,
                City = address.City,
                County = address.County,
                PostalCode = address.PostalCode,
                Number = address.Number,
                NumberAffix = address.NumberAffix,
            };
            return dto;
        }

        public static QueueRuleDTO ToDto (this QueueRule rule)
        {
            QueueRuleDTO dto = new()
            {
                Id = rule.Id,
                Name = rule.Name,
            };
            return dto;
        }

        public static AdvertDTO ToDto ( this Advert advert)
        {
            AdvertDTO dto = new()
            {
                Id = advert.Id,
                AdvertText = advert.AdvertText,
                PublishedAt = advert.PublishedAt,
                RentalDate = advert.RentalDate,
            };

            return dto;
        }
    }
}
