using Microsoft.EntityFrameworkCore;
using TryOData.Data.Entities;
namespace TryOData.Data;

public class MyWorldDbContext : DbContext
{
    public MyWorldDbContext(DbContextOptions<MyWorldDbContext> options) : base(options)
    {
    }
    public DbSet<Employee> Employee { get; set; }
}
