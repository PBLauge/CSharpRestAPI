using System;

namespace CustomerAppDAL.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }


        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
