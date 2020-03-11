using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGI.Model.Classes;
using System.Data.SqlClient;
using System.Data;

namespace SGI.Controller
{
    public class ProductContoller
    {
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            using (SqlCommand cmd = new SqlCommand("Product_sp", CDatabase.Connection))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                foreach(DataRow row in dt.Rows)
                {
                    Product newProduct = new Product(row);
                    products.Add(newProduct);
                }
            }
            return products;
        }
    }
}
