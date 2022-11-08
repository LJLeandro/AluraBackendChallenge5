using AluraBackendChallenge5.Data.ValueObjects;

namespace AluraBackendChallenge5.Repositories
{
    public interface IDataRepository<T>
    {
        Task<IEnumerable<T>> FindAll();
        Task<T> FindById(int id);
        Task<T> Create(T valueObject);
        Task<T> Update(T valueObject);
        Task<bool> Delete(int id);
    }
}
