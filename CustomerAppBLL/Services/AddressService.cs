using System;
using System.Collections.Generic;
using System.Text;
using CustomerAppBLL.BusinessObjects;
using CustomerAppBLL.Converters;
using CustomerAppDAL;
using System.Linq;

namespace CustomerAppBLL.Services
{
    class AddressService : IAddressService
    {
        AddressConverter conv = new AddressConverter();
        DALFacade facade;
        public AddressService(DALFacade facade)
        {
            this.facade = facade;
        }

        public AddressBO Create(AddressBO address)
        {
            using (var uow = facade.UnitOfWork)
            {
                var newAddress = uow.AddressRepository.Create(conv.Convert(address));
                uow.Complete();
                return conv.Convert(newAddress);
            }
        }

        public AddressBO Delete(int Id)
        {
            using (var uow = facade.UnitOfWork)
            {
                var newAddress = uow.AddressRepository.Delete(Id);
                uow.Complete();
                return conv.Convert(newAddress);
            }
        }

        public AddressBO Get(int Id)
        {
            using (var uow = facade.UnitOfWork)
            {
                return conv.Convert(uow.AddressRepository.Get(Id));
            }
        }

        public List<AddressBO> GetAll()
        {
            using (var uow = facade.UnitOfWork)
            {
                return uow.AddressRepository.GetAll().Select(conv.Convert).ToList();
            }
        }

        public AddressBO Update(AddressBO address)
        {
            using (var uow = facade.UnitOfWork)
            {
                var addressFromDb = uow.AddressRepository.Get(address.Id);
                if (addressFromDb == null)
                {
                    throw new InvalidOperationException("Address not found");
                }

                addressFromDb.City = address.City;
                addressFromDb.Number = address.Number;
                addressFromDb.Street = address.Street;
                uow.Complete();
                return conv.Convert(addressFromDb);
            }
        }
    }
}
