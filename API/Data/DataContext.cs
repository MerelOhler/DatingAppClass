using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

/// <summary>
/// The data context class
/// </summary>
public class DataContext(DbContextOptions options) : DbContext(options)
{
    /// <summary>
    /// The users table
    /// </summary>
    public DbSet<AppUser> Users { get; set; }
}
