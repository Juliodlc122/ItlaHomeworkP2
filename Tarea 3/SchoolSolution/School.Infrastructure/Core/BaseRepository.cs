using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School.Domain.Core;
using School.Infrastructure.Context;
using School.Infrastructure.Interfaces;

namespace School.Infrastructure.Core
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly SchoolContext _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(SchoolContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<T?> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task Add(T entity)
        {
            entity.CreatedDate = DateTime.UtcNow;
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task Update(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task Delete(int id)
        {
            var entity = await GetById(id);
            if (entity != null)
            {
                entity.IsDeleted = true; // Soft Delete
                _dbSet.Update(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}