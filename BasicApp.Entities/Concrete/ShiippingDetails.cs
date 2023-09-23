using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace BasicApp.Entities.Concrete
{
    public class ShiippingDetails
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Range(15, 75)]
        public int Age { get; set; }




    }
}
