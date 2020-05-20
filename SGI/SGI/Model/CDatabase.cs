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
        public static SqlConnection Connection;
        public static bool ConnectToData()
        {
            bool ConnectionSuccessfull = false;
            string connectionString = "Data Source=" + Properties.Settings.Default.DataSource + ";Initial Catalog=DATA_MANOIRQUARTIER;User ID=sa;Password=EspEsp2020";
            Connection = new SqlConnection(connectionString);
            try
            {
                Connection.Open();
                ConnectionSuccessfull = true;
            }
            catch
            {
                ConnectionSuccessfull = false;
            }
            return ConnectionSuccessfull;
        }
    }

}

