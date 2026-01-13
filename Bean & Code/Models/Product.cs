using System.ComponentModel.DataAnnotations.Schema;

namespace Bean___Code.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty ;
        public decimal Price { get; set; }

        public Category CategoryConnection { get; set; }
        public int CategoryKeyId { get; set; }
    }
}
