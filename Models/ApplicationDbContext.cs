using Microsoft.EntityFrameworkCore;

namespace bai6.Models
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor này bắt buộc phải có để nhận cấu hình từ Program.cs
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Khai báo bảng Products
        public DbSet<Product> Products { get; set; }
    }
}