using CustomerAppBLL.BusinessObjects;
using System.Collections.Generic;

namespace CustomerAppBLL
{
    public interface IAddressService
    {
        //C
        AddressBO Create(AddressBO address);
        //R
        List<AddressBO> GetAll();
        AddressBO Get(int Id);
        //U
        AddressBO Update(AddressBO address);
        //D
        AddressBO Delete(int Id);
    }
}
