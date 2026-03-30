using bai6.Models;
using bai6.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace bai6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApi : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductApi(IProductRepository repository)
        {
            _repository = repository;
        }

        // GET: api/ProductApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return Ok(await _repository.GetAllAsync());
        }

        // POST: api/ProductApi
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            await _repository.AddAsync(product);
            return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
        }

        // PUT: api/ProductApi/5 (CHỨC NĂNG SỬA)
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest("ID không khớp");
            }

            await _repository.UpdateAsync(product);
            return NoContent(); // Trả về 204 thành công
        }

        // DELETE: api/ProductApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}