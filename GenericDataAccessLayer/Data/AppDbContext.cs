using GenericRepositoryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Customer> Customers { get; set; }
}
