# Database connection

### Configuration
Ensure database connection is setup with the correct context and Docker connection in the <strong>startup.cs</strong> file. 

```csharp
 public void ConfigureServices(IServiceCollection services)
 {

    services.AddControllers();

    //SQL Server - Docker image
    services.AddDbContext<ProductContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("LocalDockerConnection")));        
            
    ervices.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "ShoppingCartApi", Version = "v1" });
    });
}

```

The LocalDocker connection is configured in the <strong>appsettings.json</strong> file.

```json
{
  "ConnectionStrings": {
    "LocalDockerConnection": "Server=shoppingcart-db,1433;Database=ShoppingCartDB;User ID=sa;Password=Passw0rd;Trusted_Connection=False;MultipleActiveResultSets=true"
    }
}

```
The ShoppingCartDB database is created (if it doesn't already existed) by the cdb.Database.EnsureCreated() method in the <strong>startup.cs</strong> file.  The CartContext is passed the Configure method.

```csharp
public void Configure(IApplicationBuilder app, IWebHostEnvironment env, CartContext cdb)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ShoppingCartApi v1"));
    }

    // create the ShoppingCartDB database
    cdb.Database.EnsureCreated();
    app.UseHttpsRedirection();

    app.UseRouting();

    app.UseAuthorization();

    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });
}

 ```