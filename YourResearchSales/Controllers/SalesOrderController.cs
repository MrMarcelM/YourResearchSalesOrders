using Microsoft.AspNetCore.Mvc;
using YourResearchSales.Models;

namespace YourResearchSales.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalesOrderController : ControllerBase
    {
        private readonly ApplicationDbContext _context; 
        private readonly ILogger<SalesOrderController> _logger;

        public SalesOrderController(ApplicationDbContext context, ILogger<SalesOrderController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Item
            {
                SalesOrderID = Random.Shared.Next(0, 999),
                ID = Random.Shared.Next(0, 999),
                Article = "Special Item",
                Amount = Random.Shared.Next(0, 999),
            })
            .ToArray();
        }
    }
}
