using BulkyBook.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAccess;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{
		
	}

	public virtual DbSet<Category> Categories { get; set; }
	public virtual DbSet<CoverType> CoverTypes { get; set; }
}
