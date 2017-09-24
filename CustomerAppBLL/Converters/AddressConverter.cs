using CustomerAppBLL.BusinessObjects;
using CustomerAppDAL.Entities;

namespace CustomerAppBLL.Converters
{
    class AddressConverter
    {

        internal Address Convert(AddressBO address)
        {
            if (address == null) { return null; }
            return new Address()
            {
                Id = address.Id,
                City = address.City,
                Street = address.Street,
                Number = address.Number
            };
        }

        internal AddressBO Convert(Address address)
        {
            if (address == null) { return null; }
            return new AddressBO()
            {
                Id = address.Id,
                City = address.City,
                Street = address.Street,
                Number = address.Number
            };
        }
    }
}
