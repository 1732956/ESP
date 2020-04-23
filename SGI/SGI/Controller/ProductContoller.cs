using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGI.Model.Classes;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SGI.Controller
{
    public class ProductContoller
    {
        public List<Product> GetAllProducts(int isActive)
        {

            List<Product> products = new List<Product>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("Product_sp", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@isActive", SqlDbType.Int).Value = isActive;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    foreach (DataRow row in dt.Rows)
                    {
                        Product newProduct = new Product(row, false);
                        products.Add(newProduct);
                    }
                }
            }
            catch (Exception ex)
            {
                if (CDatabase.Connection.State == ConnectionState.Open)
                    MessageBox.Show(ex.Message);
            }
            return products;
        }

        public bool EditSingleProduct(Product newProduct, string Action)
        {
            bool Worked = false;
            try
            {

                using (SqlCommand cmd = new SqlCommand("ProductManagement_sp", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Action", SqlDbType.VarChar).Value = Action;
                    cmd.Parameters.Add("@Productid", SqlDbType.Int).Value = newProduct.ProductId;
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = newProduct.Name;
                    cmd.Parameters.Add("@Brand", SqlDbType.VarChar).Value = newProduct.Brand;
                    cmd.Parameters.Add("@UnitNbr", SqlDbType.Int).Value = newProduct.UnitCount;
                    cmd.Parameters.Add("@QtyMin", SqlDbType.Int).Value = newProduct.MinQty;
                    cmd.Parameters.Add("@QtyMax", SqlDbType.Int).Value = newProduct.MaxQty;
                    cmd.Parameters.Add("@supplierCode", SqlDbType.VarChar).Value = newProduct.CodeSupplier;
                    cmd.Parameters.Add("@CategoryId", SqlDbType.Int).Value = newProduct.Category.CategoryID;
                    cmd.Parameters.Add("@DepartementId", SqlDbType.Int).Value = newProduct.Department.DepartmentId;
                    cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = newProduct.Description;
                    cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = newProduct.Price;
                    cmd.Parameters.Add("@UnitId", SqlDbType.Int).Value = newProduct.MeasuringUnit.UnitId;
                    cmd.Parameters.Add("@SupplierId", SqlDbType.VarChar).Value = newProduct.Supplier.SupplierID;
                    cmd.Parameters.Add("@isActive", SqlDbType.Bit).Value = newProduct.Active;
                    cmd.ExecuteNonQuery();
                    Worked = true;
                }
            }
            catch
            {
                Worked = false;
            }
            return Worked;
        }

        public Product GetSingleProductInfo(String BarCodeId)
        {
            Product Product = new Product();
            SqlCommand cmd = new SqlCommand("SingleProductInfo_sp", CDatabase.Connection);
            cmd.Parameters.Add("@barCode", SqlDbType.VarChar).Value = BarCodeId;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            foreach (DataRow row in dt.Rows)
            {
                Product = new Product(row, true);
            }
            return Product;
        }
    }

}
