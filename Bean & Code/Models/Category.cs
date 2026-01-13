namespace Bean___Code.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        
        public List<Product> ProductConnection { get; set; }
    }
}
