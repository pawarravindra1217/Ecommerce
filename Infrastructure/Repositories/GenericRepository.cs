﻿using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly StoreContext _context;
        public GenericRepository(StoreContext context)
        {
            _context = context;
        }
        public async Task<T> GetByIdAync(int Id)
        {
            return await _context.Set<T>().FindAsync(Id);
        }

        public async Task<IReadOnlyList<T>> ListAllSync()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}
