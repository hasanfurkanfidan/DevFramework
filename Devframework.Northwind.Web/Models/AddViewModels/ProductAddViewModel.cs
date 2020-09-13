using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Devframework.Northwind.Web.Models.AddViewModels
{
    public class ProductAddViewModel
    {
      

        public virtual string ProductName { get; set; }

        public virtual int CategoryId { get; set; }

        public virtual string QuantityPerUnit { get; set; }

        public virtual decimal UnitPrice { get; set; }
    }
}