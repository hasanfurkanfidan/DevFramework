using System;
using System.Linq;
using DevFramework.Northwind.DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevFramework.Northwind.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();
            var result = productDal.GetList();
            Assert.AreEqual(77, result.Count);
        }
        [TestMethod]
        public void Get_all_with_filter_products()
        {
            EfProductDal productDal = new EfProductDal();
            var result = productDal.GetList(p => p.ProductName.Contains("a"));
            Assert.AreEqual(58, result.Count);
        }
        [TestMethod]
        public void Get_all_returns_all_categories()
        {
            EfCategoryDal categoryDal = new EfCategoryDal();
            var result = categoryDal.GetList();
            Assert.AreEqual(8, result.Count);
        }
        [TestMethod]
        public void Get_all_returns_all_products_with_categories()
        {
            EfProductDal productDal = new EfProductDal();
            var result = productDal.GetProductDetails();
            Assert.AreEqual(77, result.Count);
        }

    }
}
