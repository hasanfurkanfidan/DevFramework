using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Devframework.Northwind.Web.Models.ViewModels
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
    }
}