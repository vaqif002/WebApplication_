using NuGet.Protocol.Core.Types;

namespace WebApplication_.Models
{
    public class Product
    {
        public Product() 
        { 
            ProductImages=new List <ProductImage>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int IsDelete { get; set; }
        public int CategoryId { get; set; }
        public CategoryWork CategoryWork { get; set; }
        public virtual List<ProductImage> ProductImages { get; set; }
    }
}
