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
        private readonly IItemRepository _repo;
        public ItemController(IItemRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<ActionResult<List<Item>>> GetItems()
        {
            var Items =  await _repo.GetItemsAsync();
            return Ok(Items);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Item>> GetItem(int Id)
        {
            return await _repo.GetItemByIdAync(Id);
        }
    }
}
