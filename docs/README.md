dotnet new webapi -o ShoppingCartApi
cd ShoppingCartApi
dotnet add package Microsoft.EntityFrameworkCore.InMemory


linux
dotnet dev-certs https 

Connection string for db - Docker container

Add CartItem and CartContext models

Scaffold the CartItems Controller

export PATH=$HOME/.dotnet/tools:$PATH

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet tool install -g dotnet-aspnet-codegenerator
dotnet aspnet-codegenerator controller -name CartItemsController -async -api -m CartItem -dc CartContext -outDir Controllers