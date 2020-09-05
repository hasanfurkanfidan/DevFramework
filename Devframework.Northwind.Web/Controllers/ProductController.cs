using Devframework.Northwind.Web.Models.ViewModels;
using DevFramework.Northwind.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Devframework.Northwind.Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private readonly IProductService _productService;
        public ActionResult Index()
        {
            var model = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };
            return View(model);
        }
    }
}