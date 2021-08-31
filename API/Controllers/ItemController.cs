using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IGenericRepository<Item> _itemRepo;
        public ItemController(IGenericRepository<Item> itemRepo)
        {
            _itemRepo = itemRepo;
        }
        [HttpGet]
        public async Task<ActionResult<List<Item>>> GetItems()
        {
            var Items =  await _itemRepo.ListAllSync();
            return Ok(Items);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Item>> GetItem(int Id)
        {
            return await _itemRepo.GetByIdAync(Id);
        }
    }
}
