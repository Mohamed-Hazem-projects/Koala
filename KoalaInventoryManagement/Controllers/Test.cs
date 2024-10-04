using Inventory.Data.Models;
using Inventory.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KoalaInventoryManagement.Controllers
{
    public class Test : Controller
    {
        private readonly IUnitOfWork _unit;
        public Test(IUnitOfWork unit)
        {
            _unit = unit;
        }
        public async Task<IActionResult> Get(int Id)
        {
            var x = await _unit.Categories.GetbyIdAsync(Id);
            _unit.Dispose();
            return Ok(x);
        }
        public async Task<IActionResult> GetAll()
        {
            var x = await _unit.Categories.GetAllAsync();
            _unit.Dispose();
            return Ok(x);
        }
        public async Task<IActionResult> Add(Category c)
        {
            await _unit.Categories.AddAsync(c);
            await _unit.CompleteAsync();
            _unit.Dispose();
            return Ok();
        }
    }
}
