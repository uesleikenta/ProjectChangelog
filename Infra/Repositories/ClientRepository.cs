using ChangelogProject.Infra.Data;
using ChangelogProject.Infra.Models;

namespace ChangelogProject.Infra.Repositories {
	public class ClientRepository : Repository<Client>, IRepository<Client> {
		public ClientRepository(DataContext context) : base(context) {
		}
	}
}