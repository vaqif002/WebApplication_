namespace WebApplication_.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public bool IsActive { get; set; }
        public int Productid { get; set; }
        public Product product { get; set; }
    }

}
