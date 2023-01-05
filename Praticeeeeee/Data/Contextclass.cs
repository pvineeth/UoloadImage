using Microsoft.EntityFrameworkCore;
using Praticeeeeee.DTO;
using Praticeeeeee.Models;

namespace Praticeeeeee.Data
{
	public class Contextclass:DbContext
	{
		public Contextclass(DbContextOptions<Contextclass> options)
			: base(options)
		{

		}
		public DbSet<BOOKDTO> Booksp { get; set; }
		
	}
}
