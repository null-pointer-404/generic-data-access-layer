# GenericRepositoryAPI

<p>Project is a .NET Core Web API implementation using Entity Framework Core with a Generic Repository Pattern for data access. It includes basic CRUD operations for a Customer entity and demonstrates how to implement a scalable and reusable data access layer.</p>

## Project Structure
<ul>
  <li>📦 GenericRepositoryAPI
     <ul> 
       <li> 📂 Controllers
         <ul><li>📜 CustomersController.cs</li></ul>
       </li>
       <li> 📂 Data
          <ul><li>📜 AppDbContext.cs</li></ul>
       </li>
       <li> 📂 Models
         <ul><li>📜 Customer.cs</li></ul>
       </li>
       <li> 📂 Repositories
         <ul>
           <li>📜 IGenericRepository.cs</li>
           <li>📜 GenericRepository.cs</li>
         </ul>
       </li>
     <li> 📜 appsettings.json</li>
     <li> 📜 Program.cs     </li>
     </ul>
   <li> 📜 GenericRepositoryAPI.csproj     </li>
</ul>

## Configure Database Connection
<p>In the appsettings.json file, update the DefaultConnection string to point to your SQL Server database:</p>
<i>
  "ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=MyAppDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
</i>
