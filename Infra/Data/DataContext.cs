using Microsoft.EntityFrameworkCore;
using ChangelogProject.Infra.Models;

namespace ChangelogProject.Infra.Data {
	public class DataContext : DbContext, IDataContext {
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<Client> Clients { get; init; }

		public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) => base.SaveChangesAsync(cancellationToken);
	}

}
