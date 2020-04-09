using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SGI.Controller;
using SGI.Model.Classes;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreerProduit()
        {
            ProductContoller productcontoller = new ProductContoller();
            Product currentProduct = new Product();
            currentProduct.ProductId = 9999;
            currentProduct.Description = "test1";
            currentProduct.Brand  = "test1";
            currentProduct.Supplier = "test1";
            currentProduct.SupplierCode = "test1";
            currentProduct.Price = 2;
            currentProduct.LastUpdate = DateTime.Now;
            currentProduct.Active = true;
            currentProduct.UnitCount = 2;
            currentProduct.MaxQty = 10;
            currentProduct.MinQty = 2;
            currentProduct.BarCodeId = "test1";
            currentProduct.Category.CategoryID = 1;
            currentProduct.Department.DepartmentId = 1;
            currentProduct.MeasuringUnit.UnitId = 1;

            Assert.IsFalse(productcontoller.EditSingleProduct(currentProduct, "update"));
        }
    }
}
