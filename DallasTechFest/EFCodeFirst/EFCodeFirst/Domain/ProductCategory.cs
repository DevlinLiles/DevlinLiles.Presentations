namespace EFCodeFirst.Domain
{
    public class ProductCategory : Entity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public Product Product { get; set; }
    }
}