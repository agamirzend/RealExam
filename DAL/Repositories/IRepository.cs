using DAL.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories;

public interface IRepository<T> where T : BaseEntity, new()
{
    DbSet<T> Table { get; }

    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAync(int id);
    Task CreateAsync(T entity);
    void Update(T entity);
    void Delete(T entity);

    Task<int> SaveChangesAsync();
}
