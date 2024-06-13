using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                CategoryId = "1",
                CategoryName = "Shirt",
                DisplayOrder = 1
            },
            new Category
            {
                CategoryId = "2",
                CategoryName = "Pents",
                DisplayOrder = 2
            });
    }
}