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

                        using (SqlCommand cmd2 = new SqlCommand("ProductDeparments_sp", CDatabase.Connection))
                        {
                            cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd2.Parameters.Add("@ProductId", SqlDbType.Int).Value = newProduct.ProductId;
                            SqlDataReader dr2 = cmd2.ExecuteReader();
                            DataTable dt2 = new DataTable();
                            dt2.Load(dr2);
                            foreach (DataRow row2 in dt2.Rows)
                            {
                                newProduct.addDepartment(row2);
                            }
                        }

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
                    cmd.Parameters.Add("@QtyInventoryOut", SqlDbType.Float).Value = newProduct.QtyInventoryOut;
                    cmd.Parameters.Add("@supplierCode", SqlDbType.VarChar).Value = newProduct.CodeSupplier;
                    cmd.Parameters.Add("@MeasureUnit", SqlDbType.VarChar).Value = newProduct.MeasureUnit;
                    cmd.Parameters.Add("@MeasureQty", SqlDbType.Int).Value = newProduct.MeasureQty;
                    if (newProduct.Category == null)
                        cmd.Parameters.Add("@CategoryId", SqlDbType.Int).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("@CategoryId", SqlDbType.Int).Value = newProduct.Category.CategoryID;
                    String DepString = "";
                    for (int  i = 0;  i < newProduct.Departments.Count;  i++)
                    {
                        DepString += newProduct.Departments[i].DepartmentId.ToString() + ",";
                    }

                    cmd.Parameters.Add("@Departement", SqlDbType.VarChar).Value = DepString;  
                    cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = newProduct.Description;
                    cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = newProduct.Price;
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
