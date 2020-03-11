using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SGI.Model.Classes;
using System.Data;

namespace SGI.Controller
{
    class InventoryInController
    {
        public void InventoryIn(int productid, int Qte, int Locid)
        {
            SqlCommand cmd = new SqlCommand("dbo.ScanItemIn_sp", CDatabase.Connection);
            cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = productid;
            cmd.Parameters.Add("@LocId", SqlDbType.Int).Value = Locid;
            cmd.Parameters.Add("@Qty", SqlDbType.Int).Value = Qte;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }

    }
}
