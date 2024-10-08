﻿using Pinturas.API.Filters;
using Pinturas.Business;
using Pinturas.Dtos.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pinturas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService productService;

        /*
* GET, POST, PUT ve DELETE
*/
        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await productService.GetProducts();
            return Ok(products);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await productService.GetProductById(id);

            if (product != null)
            {
                return Ok(product);
            }

            return NotFound(new { message = $"{id} numaralı ürün bulunamadı" });
        }
        [HttpGet("Ara/{search}")]
        public IActionResult Search(string search)
        {
            return Ok();
        }
        [HttpPost]
        [Authorize(Roles ="Admin,Editor")]
        public async Task<IActionResult> AddProduct(AddProductRequest request)
        {
            if (ModelState.IsValid)
            {
                var lastProductId = await productService.AddProduct(request);
                return CreatedAtAction(nameof(GetProductById), routeValues: new { id = lastProductId }, null);


            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        [IsExists]
        public async Task<IActionResult> Update(int id, UpdateProductRequest request)
        {
            if (ModelState.IsValid)
            {
                await productService.UpdateProduct(request);
                return Ok();

            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        [IsExists]
        public async Task<IActionResult> Delete(int id)
        {
            await productService.DeleteProduct(id);
            return NotFound();
        }
    }
}
