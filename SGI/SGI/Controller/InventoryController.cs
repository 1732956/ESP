using SGI.Model.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGI.Controller
{
    class InventoryController
    {
        public DataTable GetLocationInventory(Location currentLoc, string productColumn, string qtyColumn, string measuringUnitColumn)
        {
            try
            {
                if (currentLoc != null)
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Quantity as " + qtyColumn + ", Name as " + productColumn + ", CONCAT(MeasureQty,' ', MeasureUnit ) as " + measuringUnitColumn + " From Tbl_Inventory INNER JOIN Tbl_Product ON Tbl_Inventory.ProductID_ = Tbl_Product.ProductID  where LocationID = " + currentLoc.LocationId + " AND IsActive = 1", CDatabase.Connection))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        SqlDataReader dr = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        return dt;
                    }
                }
                else
                    return new DataTable();
            }
            catch (Exception ex)
            {
                if (CDatabase.Connection.State == ConnectionState.Open)
                    MessageBox.Show(ex.Message);
                return new DataTable();
            }

        }

        public DataTable GetLocationStock(Location currentLoc)
        {
            try
            {
                if (currentLoc != null)
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Quantity, Name, CONVERT( DEC(18,2), Price) as Price, CONCAT(MeasureQty,' ', MeasureUnit ) as MeasUnit FROM Tbl_Inventory I INNER JOIN Tbl_Product P ON I.ProductID_ = P.ProductID WHERE LocationID = " + currentLoc.LocationId, CDatabase.Connection))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        SqlDataReader dr = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        return dt;
                    }
                }
                else
                    return new DataTable();
            }
            catch (Exception ex)
            {
                if (CDatabase.Connection.State == ConnectionState.Open)
                    MessageBox.Show(ex.Message);
                return new DataTable();
            }
        }

        public DataTable GetProductToDo()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ProductID,Name,Description, CONCAT(MeasureQty,' ',MeasureUnit) as MeasuringUnit, QtyMin,Quantity FROM( " +
                                                        " SELECT tbl_product.ProductID, tbl_product.Name, tbl_product.Description, tbl_product.MeasureQty, tbl_product.MeasureUnit, tbl_product.QtyMin, SUM(Tbl_Inventory.Quantity) as Quantity  FROM tbl_product " +
                                                        " INNER JOIN Tbl_Inventory ON Tbl_Inventory.ProductID_ = tbl_product.ProductID " +
                                                        " GROUP BY tbl_product.ProductID, tbl_product.Name, tbl_product.Description, tbl_product.MeasureQty, tbl_product.MeasureUnit, tbl_product.QtyMin)" +
                                                        " AS aa WHERE Quantity < QtyMin " +
                                                        " UNION " +
                                                        " SELECT ProductID, Name, Description, CONCAT(MeasureQty, ' ', MeasureUnit) as MeasuringUnit, QtyMin, 0 FROM tbl_product " +
                                                        " WHERE NOT EXISTS(SELECT * FROM Tbl_Inventory WHERE Tbl_Inventory.ProductID_ = tbl_product.ProductID)", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                if (CDatabase.Connection.State == ConnectionState.Open)
                    MessageBox.Show(ex.Message);
                return new DataTable();
            }
        }

        public DataTable GetProductToMuch()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ProductID,Name,Description, CONCAT(MeasureQty,' ',MeasureUnit) as MeasuringUnit, QtyMax,Quantity FROM( " +
                                                        " SELECT tbl_product.ProductID, tbl_product.Name, tbl_product.Description, tbl_product.MeasureQty, tbl_product.MeasureUnit, tbl_product.Qtymax, SUM(Tbl_Inventory.Quantity) as Quantity  FROM tbl_product " +
                                                        " INNER JOIN Tbl_Inventory ON Tbl_Inventory.ProductID_ = tbl_product.ProductID " +
                                                        " GROUP BY tbl_product.ProductID, tbl_product.Name, tbl_product.Description, tbl_product.MeasureQty, tbl_product.MeasureUnit, tbl_product.Qtymax)" +
                                                        " AS aa WHERE Quantity > QtyMax ", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                if (CDatabase.Connection.State == ConnectionState.Open)
                    MessageBox.Show(ex.Message);
                return new DataTable();
            }
        }
    }
}