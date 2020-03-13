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
    public class DepartmentController
    {
        public List<Department> GetAllActiveDepartments()
        {
            List<Department> departments = new List<Department>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_Departement where isActive = 1", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    foreach (DataRow row in dt.Rows)
                    {
                        Department newDepartmente = new Department(row);
                        departments.Add(newDepartmente);
                    }
                }
            }
            catch (Exception ex)
            {
                if (CDatabase.Connection.State == ConnectionState.Open)
                    MessageBox.Show(ex.Message);
            }
            return departments;
        }
    }
}
