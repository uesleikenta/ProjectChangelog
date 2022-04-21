namespace ChangelogProject.Infra.Repositories {
	public interface IRepository<T> where T : class {
		Task<T?> GetById(string id);
		Task<IEnumerable<T>> GetAll();
		Task<T> Create(T obj);
		Task<T> Update(T obj);
		Task<T> Delete(string id);
	}
}