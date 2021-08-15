# Create New Api

### Requirments
* .Net Framework V5
* dotnet cli
* Visual Studio Code


### Create 
This project was created using the following commands

```
dotnet new webapi - o ShoppingCartApi
cd ShoppingCartApi
dotnet add package Microsoft.EntityFrameworkCore.InMemory    
```

Trust the HTTP development certificate (Linux)

```
dotnet dev-certs https    
```

### Verify
Run the application and verify that you can see the swagger page.

```
dotnet run
```
Go to where the app has been started, by default its usually https://localhost:5001/swagger/index.html

