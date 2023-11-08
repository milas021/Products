using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Context.AppDbContxt;
using Products.Model;

namespace Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpPost("product")]
        public async Task<IActionResult> Get()
        {
            var db = new AppDbContext();
            var result = db.Products.ToList();

            return Ok(result);
        }
    }
}
