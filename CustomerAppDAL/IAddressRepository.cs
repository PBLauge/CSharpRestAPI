using CustomerAppDAL.Entities;
using System.Collections.Generic;

namespace CustomerAppDAL
{
    public interface IAddressRepository
    {
        //C
        Address Create(Address address);
        //R
        List<Address> GetAll();
        IEnumerable<Address> GetAllById(List<int> ids);
        Address Get(int Id);
        //U
        //Update is done in the UnitOfWork
        //D
        Address Delete(int Id);
    }
}
