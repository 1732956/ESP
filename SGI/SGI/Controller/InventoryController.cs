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
    }
}