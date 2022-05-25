using Pinturas.Business;
using Pinturas.Web.Extensions;
using Pinturas.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pinturas.Web.Controllers
{
    public class CartController : Controller
    {
        private IProductService productService;

        public CartController(IProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult Index()
        {
            var cartCollection = getCollectionFromSession();
            return View(cartCollection);
        }

        public async Task<IActionResult> Add(int id)
        {
            if (await productService.IsExist(id))
            {
                var product = await productService.GetProductById(id);
                CartCollection cartCollection = getCollectionFromSession();
                cartCollection.Add(new CartItem { Product = product, Quantity = 1 });
                saveToSession(cartCollection);
                return Json($"{product.Name} Sepete Eklendi");
            }


            return NotFound();

        }

        private void saveToSession(CartCollection cartCollection)
        {
            HttpContext.Session.SetJson("sepetim", cartCollection);
        }

        private CartCollection getCollectionFromSession()

        {
            CartCollection cartCollection = null;
            cartCollection = HttpContext.Session.GetJson<CartCollection>("sepetim") ?? new CartCollection();          


            return cartCollection;

        }
    }
}
