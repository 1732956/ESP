using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.Controller
{
    class InventoryOutController
    {
        public void InventoryOut(int productid ,int Qte, int Locid)
        {
            SqlCommand cmd = new SqlCommand("dbo.ScanItemOut_sp", CDatabase.Connection);
            cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = productid;
            cmd.Parameters.Add("@LocId", SqlDbType.Int).Value = Locid;
            cmd.Parameters.Add("@Qty", SqlDbType.Int).Value = Qte;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }
    }
}
