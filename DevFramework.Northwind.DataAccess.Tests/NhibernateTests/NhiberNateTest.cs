using System;
using DevFramework.Core.DataAccess.NHibernate;
using DevFramework.Northwind.DataAccess.Concrete.EntityFramework;
using DevFramework.Northwind.DataAccess.Concrete.NHibernate;
using DevFramework.Northwind.DataAccess.Concrete.NHibernate.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevFramework.Northwind.DataAccess.Tests.NhibernateTests
{
    [TestClass]
    public class NhiberNateTest
    {
        [TestMethod]
        public void Get_all_with_NHiberNate_product()
        {
            var nhProductDal = new NhProductDal(new SqlServerHelper());
            var result = nhProductDal.GetList();
            Assert.AreEqual(77, result.Count);
        }
        [TestMethod]
        public void Get_all_with_NHiberNate_category()
        {
            var nhCategoryDal = new NhCategoryDal(new SqlServerHelper());
            var result = nhCategoryDal.GetList();
            Assert.AreEqual(8, result.Count);
        }

    }
}
