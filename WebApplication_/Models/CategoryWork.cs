namespace WebApplication_.Models
{
    public class CategoryWork
    {
        public CategoryWork() {
         products=new List<Product>();
            }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public virtual List<Product> products { get; set; }
    }
}
