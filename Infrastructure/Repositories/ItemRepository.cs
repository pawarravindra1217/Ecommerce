using Core.Entities;
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
    public class ItemRepository : IItemRepository
    {
        private readonly StoreContext _context;

        public ItemRepository(StoreContext context)
        {
            _context = context;
        }
        public async Task<Item> GetItemByIdAync(int Id)
        {
            return await _context.Items.FindAsync(Id);
        }

        public async Task<IReadOnlyList<Item>> GetItemsAsync()
        {
            return await _context.Items.ToListAsync();
        }
    }
}
