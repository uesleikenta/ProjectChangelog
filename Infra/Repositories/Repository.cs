using ChangelogProject.Infra.Data;
namespace ChangelogProject.Infra.Repositories {
	public class Repository<T> : IRepository<T> where T : class, new() {
		protected readonly DataContext _context;

		public Repository(DataContext context) {
			_context = context;
		}

		public async Task<T?> GetById(string id) {
			return await _context.Set<T>().FindAsync(id);
		}

		public async Task<IEnumerable<T>> GetAll() {
			return _context.Set<T>().ToList();
		}

		public async Task<T> Create(T obj) {
			_context.Set<T>().Add(obj);
			await _context.SaveChangesAsync();
			return obj;
		}

		public async Task<T> Update(T obj) {
			var objToUpdate = _context.Entry(obj);
			objToUpdate = _context.Set<T>().Attach(obj);
			await _context.SaveChangesAsync();
			return obj;
		}

		public async Task<T> Delete(string id) {
			var obj = await GetById(id);
			_context.Set<T>().Remove(obj);
			await _context.SaveChangesAsync();
			return obj;
		}
	}
}