using SGI.Model.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.Controller
{
    class InventoryController
    {
        public DataTable GetLocationInventory(Location currentLoc)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_Inventory where LocationID = " + currentLoc.LocationId, CDatabase.Connection))
            {
                cmd.CommandType = System.Data.CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
        }
    }
}