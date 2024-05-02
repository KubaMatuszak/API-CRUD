using API_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace API_CRUD.Data
{
	public class OrderDbContext : DbContext
	{
		public OrderDbContext(DbContextOptions options) : base(options)
		{
		}
		public DbSet<Order> orders { get; set; }
	}
}
