using Microsoft.EntityFrameworkCore;
using TodoApp.Models;  // Make sure Todo.cs exists in this namespace

namespace TodoApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor that passes options to the base DbContext class
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet represents a collection of Todo objects (mapped to the Todos table in the database)
        public DbSet<Todo> Todos { get; set; } = null!;
        // The = null!; tells C# the property will be initialized by EF Core, avoiding nullable warnings
    }
}
