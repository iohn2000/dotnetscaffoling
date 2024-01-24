# scaffolding
- `dotnet add package Microsoft.EntityFrameworkCore.Design`
- `dotnet add package Microsoft.EntityFrameworkCore.SqlServer`
- `dotnet ef dbcontext scaffold "Data Source=.\SQLEXPRESS;Initial Catalog=DxpNavAtData_container;Integrated Security=SSPI;TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer -o Models`


