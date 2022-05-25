using Pinturas.Web.Extensions;
using Pinturas.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pinturas.Web.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var collection = HttpContext.Session.GetJson<CartCollection>("sepetim");
            return View(collection);
        }
    }
}
