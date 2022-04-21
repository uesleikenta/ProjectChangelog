using Microsoft.EntityFrameworkCore;
using ChangelogProject.Infra.Models;

namespace ChangelogProject.Infra.Data {
	public interface IDataContext {
		DbSet<Client> Clients { get; init; }
		Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
	}
}