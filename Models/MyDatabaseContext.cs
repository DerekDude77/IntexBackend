using Microsoft.EntityFrameworkCore;

namespace IntexDatabaseConnection.Models
{
    public class MyDatabaseContext : DbContext
    {

        public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options)
        : base(options)
        {
        }

        //public DbSet<YourModel> YourModels { get; set; }
        // Add more DbSet properties for your other tables

    }
}

// CONFIGURE THIS TO MATCH THE DATA CONTAINED IN THE POSTGRESQL DATABASE
