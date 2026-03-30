using System.ComponentModel.DataAnnotations.Schema;

namespace bai6.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")] // Fix lỗi cảnh báo bạn gặp lúc nãy
        public decimal Price { get; set; }

        public string Description { get; set; } = string.Empty;
    }
}