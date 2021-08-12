using Microsoft.EntityFrameworkCore;

namespace ShoppingCartApi.Models
{
    public class CartContext : DbContext
    {
        public CartContext(DbContextOptions<CartContext> options)
            : base(options)
        {
        }

        public DbSet<CartItem> Items { get; set; }
    }
}