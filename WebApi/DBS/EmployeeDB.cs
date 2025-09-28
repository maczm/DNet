using Microsoft.EntityFrameworkCore;
using WebApi.Models;
namespace WebApi.DBS;

public class EmployeeDB : DbContext
{
    public EmployeeDB(DbContextOptions<EmployeeDB> options) : base(options)
    {
    }
    public DbSet<Employee> Employees { get; set; } = null!;
}
