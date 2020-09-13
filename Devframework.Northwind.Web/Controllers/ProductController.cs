using Devframework.Northwind.Web.Models.AddViewModels;
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
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index()
        {
            var model = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };
            return View(model);
        }
        public ActionResult Add()
        {
            _productService.Add(new DevFramework.Northwind.Entities.Concrete.Product
            {
                ProductName = "Computer",
                CategoryId = 1,
                QuantityPerUnit = "ABC",
                UnitPrice = 4500
            });
            return View();
        }

    }
}