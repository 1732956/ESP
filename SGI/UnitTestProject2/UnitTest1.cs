﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SGI.Controller;
using SGI.Model.Classes;

using SGI;
using System.Data.SqlClient;
using System.Data;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreerProduit()
        {
            CDatabase.ConnectToData();
            ProductContoller productcontoller = new ProductContoller();
            Product currentProduct = new Product();
            currentProduct.ProductId = 0;
            currentProduct.Name = "TestUnitaireProduitCrééOATF";
            currentProduct.Description = "test1";
            currentProduct.Brand  = "test1";
            currentProduct.Supplier.SupplierID = 1;
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

            Assert.IsTrue(productcontoller.EditSingleProduct(currentProduct, "add"));
        }

        [TestMethod]
        public void UpdateProduit()
        {
            CDatabase.ConnectToData();
            ProductContoller productcontoller = new ProductContoller();
            Product currentProduct = new Product();

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_product where tbl_product.Name = 'TestUnitaireProduitCrééOATF'", CDatabase.Connection))
            {
                cmd.CommandType = System.Data.CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                foreach (DataRow row in dt.Rows)
                {
                    currentProduct.ProductId = Convert.ToInt32(row["ProductId"]);
                }
            }
            currentProduct.Name = "TestUnitaireProduitUpdatéOATF";
            currentProduct.Description = "test2";
            currentProduct.Brand = "test2";
            currentProduct.Supplier.SupplierID = 1;
            currentProduct.Price = 2;
            currentProduct.LastUpdate = DateTime.Now;
            currentProduct.Active = true;
            currentProduct.UnitCount = 2;
            currentProduct.MaxQty = 10;
            currentProduct.MinQty = 2;
            currentProduct.BarCodeId = "test2";
            currentProduct.Category.CategoryID = 1;
            currentProduct.Department.DepartmentId = 1;
            currentProduct.MeasuringUnit.UnitId = 1;

            Assert.IsTrue(productcontoller.EditSingleProduct(currentProduct, "update"));
        }

        [TestMethod]
        public void DeleteProduit()
        {
            CDatabase.ConnectToData();

            SqlCommand cmd = new SqlCommand("DELETE FROM tbl_product where tbl_product.Name = 'TestUnitaireProduitUpdatéOATF'", CDatabase.Connection) ;
            cmd.ExecuteNonQuery();
        }

        [TestMethod]
        public void CreerProduitSansName()
        {
            CDatabase.ConnectToData();
            ProductContoller productcontoller = new ProductContoller();
            Product currentProduct = new Product();
            currentProduct.ProductId = 9999;
            currentProduct.Name = null;
            currentProduct.Description = "test1";
            currentProduct.Brand = "test1";
            currentProduct.Supplier.SupplierID = 1;
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
