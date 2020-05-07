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

        public bool VerifyQty(int productid, int Qte, int Locid, bool AlreadyNotEnough)
        {
            bool hasNotEnough = AlreadyNotEnough;

            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_inventory WHERE ProductID_ = " + productid.ToString() + " AND LocationID = " + Locid.ToString() + " AND Quantity >= " + Qte.ToString(), CDatabase.Connection);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            if (dt.Rows.Count <= 0)
            {
                hasNotEnough= true;
            }

            return hasNotEnough;
        }

        

    }
}
