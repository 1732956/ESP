using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGI.Model.Classes;
using System.Windows.Forms;

namespace SGI.Controller
{
    class ReasonCodeController
    {
        public List<ReasonCode> GetAllActiveReasonCode()
        {
            List<ReasonCode> categories = new List<ReasonCode>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_ReasonCode where Tbl_ReasonCode.isActive = 1", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    foreach (DataRow row in dt.Rows)
                    {
                        ReasonCode newReasonCode = new ReasonCode(row);
                        categories.Add(newReasonCode);
                    }
                }
            }
            catch (Exception ex)
            {
                if (CDatabase.Connection.State == ConnectionState.Open)
                    MessageBox.Show(ex.Message);
            }
            return categories;
        }
    }
}
