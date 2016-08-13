/*
 * Context class that associate the model with the database.
 * Defines a property for each table in the database that I want to work with. EF should use the Product model type to represent rows in the Products table.
 * Property Name = Table
 * DbSet<T> = Model Type
 * 
 * Model and repository logic in SportsStore.Domain, database connection information in Web.config in SportsStore.WebUI
 */
using SportsStore.Domain.Entities;
using System.Data.Entity;


namespace SportsStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
