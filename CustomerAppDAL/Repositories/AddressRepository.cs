using System.Collections.Generic;
using CustomerAppDAL.Entities;
using CustomerAppDAL.Context;
using System.Linq;

namespace CustomerAppDAL.Repositories
{
    class AddressRepository : IAddressRepository
    {
        CustomerAppContext _context;

        public AddressRepository(CustomerAppContext context)
        {
            _context = context;
        }

        public Address Create(Address address)
        {
            _context.Addresses.Add(address);
            return address;
        }

        public Address Delete(int Id)
        {
            var address = Get(Id);
            _context.Addresses.Remove(address);
            return address;
        }

        public Address Get(int Id)
        {
            return _context.Addresses.FirstOrDefault(o => o.Id == Id);
        }

        public List<Address> GetAll()
        {
            return _context.Addresses.ToList();
        }

        public IEnumerable<Address> GetAllById(List<int> ids)
        {
            if (ids == null) { return null; }

            return _context.Addresses.Where(a => ids.Contains(a.Id));
        }
    }
}
