using DAL.Contexts;
using DAL.Models.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace DAL.Repositories;

public class Repository<T> : IRepository<T> where T : BaseEntity, new()
{
    private readonly AppDbContext _context;

    public Repository(AppDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public async Task CreateAsync(T entity)
    {
        await Table.AddAsync(entity);
    }

    public void Delete(T entity)
    {
        Table.Remove(entity);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        IEnumerable<T> entities = await Table.ToListAsync();
        return entities;

    }
    public async Task<T> GetByIdAync(int id)
    {
        var entity = await Table.FindAsync(id);
        return entity;
    }

    public async Task<int> SaveChangesAsync()
    {
        int rows = await _context.SaveChangesAsync();
        return rows;
    }

    public void Update(T entity)
    {
        Table.Update(entity);
    }
}
