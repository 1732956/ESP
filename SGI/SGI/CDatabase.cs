using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SGI
{
    public static class CDatabase
    {
        public static bool ConnectToData()
        {
            bool ConnectionSuccessfull = false;
            string connectionString = @"Data Source=10.4.1.182;Initial Catalog=DATA_MANOIRQUARTIER;User ID=sa;Password=Espesp2020";
            SqlConnection cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                ConnectionSuccessfull = true;
                cnn.Close();
            }
            catch (Exception ex)
            {
                ConnectionSuccessfull = false;
            }
            return ConnectionSuccessfull;
        }
    }

}

