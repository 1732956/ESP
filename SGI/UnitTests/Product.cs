﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SGI.Controller;
using SGI.Model.Classes;
using SGI;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace UnitTestProject2
{
    [TestClass]
    public class Product
    {
        [TestMethod]
        public void CreerProduit()
        {
            CDatabase.ConnectToData();
            ProductContoller productcontoller = new ProductContoller();
            SGI.Model.Classes.Product currentProduct = new SGI.Model.Classes.Product();
            currentProduct.ProductId = 0;
            currentProduct.Name = "TestUnitaireProduitCrééOATF";
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
            currentProduct.Departments = new List<Department>();
            currentProduct.Departments.Add(new Department(1, "Buanderie", "desc", true));
            Assert.IsTrue(productcontoller.EditSingleProduct(currentProduct, "add"));
        }

        [TestMethod]
        public void UpdateProduit()
        {
            CDatabase.ConnectToData();
            ProductContoller productcontoller = new ProductContoller();
            SGI.Model.Classes.Product currentProduct = new SGI.Model.Classes.Product();

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
            currentProduct.Departments = new List<Department>();
            currentProduct.Departments.Add(new Department(1, "Buanderie", "desc", true));
            Assert.IsTrue(productcontoller.EditSingleProduct(currentProduct, "update"));
        }

        [TestMethod]
        public void DeleteProduit()
        {
            CDatabase.ConnectToData();
            using (SqlCommand cmd = new SqlCommand("DELETE FROM tbl_product where tbl_product.Name = 'TestUnitaireProduitUpdatéOATF'", CDatabase.Connection))
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            using (SqlCommand cmd2 = new SqlCommand("DELETE FROM tbl_product where tbl_product.Name = 'TestUnitaireProduitCrééOATF'", CDatabase.Connection))
            {
                cmd2.CommandType = System.Data.CommandType.Text;
                cmd2.ExecuteNonQuery();
            }
        }

        [TestMethod]
        public void CreerProduitSansName()
        {
            CDatabase.ConnectToData();
            ProductContoller productcontoller = new ProductContoller();
            SGI.Model.Classes.Product currentProduct = new SGI.Model.Classes.Product();
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
            currentProduct.Departments = new List<Department>();
            Assert.IsFalse(productcontoller.EditSingleProduct(currentProduct, "update"));
        }
    }
}
