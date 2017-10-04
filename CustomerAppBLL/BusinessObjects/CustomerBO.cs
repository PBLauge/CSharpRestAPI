using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomerAppBLL.BusinessObjects
{
    public class CustomerBO
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string LastName { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; } 
                
        }

        public List<int> AddressIds { get; set; }

        public List<AddressBO> Addresses { get; set; }
    }
}
