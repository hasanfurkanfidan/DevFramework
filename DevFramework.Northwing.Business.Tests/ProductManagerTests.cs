using System;
using DevFramework.Northwind.Business.Concrete.Managers;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.DataAccess.Concrete.EntityFramework;
using DevFramework.Northwind.Entities.Concrete;
using FluentValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DevFramework.Northwing.Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ValidationException))]

        public void Product_validation_check()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
            ProductManager productManager = new ProductManager(new EfProductDal());
            productManager.Add(new Product
            {
                ProductName = "Computer",
                UnitPrice = 45,
                QuantityPerUnit = "10-500",
                CategoryId = 1,
                
            }); 
            
           

        }
    }
}
