using LitLiteracy.Lib.Domain.Data;
using LitLiterary.Lib.Shared.Contracts.Services;
using LitLiterary.Lib.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LitLiteracy.Lib.Domain.Services
{
    public class LibraryRepository<T> : IRepository<Guid, T> where T: DomainObject
    {
        private readonly LibraryDbContext _context;

        public LibraryRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> CreateAsync(T entity)
        {
            var creationResult = await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return creationResult.Entity;
        }

        public async Task<T> UpdateAsync(Guid id, T entity)
        {
            entity.Id = id;
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity is null) 
                return false;
            
            _context.Set<T>().Remove(entity);
            return true;
        }
    }
}
