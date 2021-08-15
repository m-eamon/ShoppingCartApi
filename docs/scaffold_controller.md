# Scaffold Controller

### Cart & CartContext Models
The Cart and CartContext classes are used with Entity Framework Core (EF Core) to work with the ShoppingCartDB database.

```csharp
namespace ShoppingCartApi.Models
{
    public class CartItem
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }

        public string Description { get; set; }

        public decimal Price {get; set;}

        public string Retailer {get; set;}
    }
}

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

```

### Add NuGet packages
```shell
dotnet tool install --global dotnet-ef
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

```

### Export the scaffold tool path
```shell
export PATH=$HOME/.dotnet/tools:$PATH
```

### Scaffold CartItem Controller
```shell
dotnet aspnet-codegenerator controller -name CartItemsController -async -api -m CartItem -dc CartContext -outDir Controllers

```

### Verify
CartItemsController for CRUD operations will now be available.



