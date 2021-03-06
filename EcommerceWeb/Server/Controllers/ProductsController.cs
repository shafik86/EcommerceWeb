#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EcommerceWeb.Server.Data;
using EcommerceWeb.Shared;
using EcommerceWeb.Client.Services;
using EcommerceWeb.Server.Models.Repository;

namespace EcommerceWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IProductRepository productRepository;
        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        // GET: api/Products/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var result = await productRepository.GetProduct(id);
            if (result == null)
            {
                return NotFound($"Product id : {id} is not found");
            }
            return Ok(result);
        }
        //Search Product by Name, Metal
        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<Product>>> Search(Metal? metal, Types type)
        {
            try
            {
                var result = await productRepository.SearchProduct(metal,type);
                if (result.Any())
                {
                    return Ok(result);
                }

                return NotFound($"tiada Product  {metal} dalam Db");

            }
            catch (Exception)
            {

        //Search Products By Name, Metal

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Error Searching product record");
            }
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var result = await productRepository.GetProducts();
            return Ok(result);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var result = await productRepository.GetProduct(id);
            if (result == null)
            {
                return NotFound($"Product id : {id} is not found");
            }
            return Ok(result);
        }


        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<ActionResult<Product>> UpdateProduct(Product product)
        {
            try
            {
                if (product.ProductId == 0)
                    return BadRequest("Employee ID mismatch");

                var productToUpdate = await productRepository.GetProduct(product.ProductId);

                if (productToUpdate == null)
                    return NotFound($"Employee with Id = {product.ProductId} not found");

                return await productRepository.UpdateProduct(product);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            try
            {
                if (product == null)
                    return BadRequest();

                var createdProduct = await productRepository.AddProduct(product);

                return CreatedAtAction(nameof(GetProduct),
                    new { id = createdProduct.ProductId }, createdProduct);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }
        //Search Product by Name, Metal
        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<Product>>> Search(string name, Metal? metal)
        {
            try
            {
                var result = await productRepository.SearchProduct(name, metal);
                if (result.Any())
                {
                    return Ok(result);
                }
                return NotFound($"tiada Product nama {name} dalam Db");

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Error Searching product record");
            }
        }
        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var productToDelete = await productRepository.GetProduct(id);
            try
            {
                //var employeeToDelete = await employeeRepository.GetEmployee(id);
                if (productToDelete == null)
                {
                    return NotFound($"Product with Id = {id} not found");
                }

                return await productRepository.DeleteProduct(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }

        //private bool ProductExists(int id)
        //{
        //    return _context.Products.Any(e => e.ProductId == id);
        //}
    }
}
