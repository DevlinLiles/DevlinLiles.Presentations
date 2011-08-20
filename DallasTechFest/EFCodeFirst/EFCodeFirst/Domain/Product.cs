using System.ComponentModel.DataAnnotations;

namespace EFCodeFirst.Domain
{
    public class Product : Entity
    {
       
        [Required]
        public string Name { get; set; }

        public ProductCategory Category { get; set; }
    }
}