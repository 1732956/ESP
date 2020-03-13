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

        public List<Department> GetAllInactiveDepartments()
        {
            List<Department> departments = new List<Department>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_Departement where isActive = 0", CDatabase.Connection))
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

        public List<Department> GetAllDepartments()
        {
            List<Department> departments = new List<Department>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_Departement ORDER BY isActive DESC", CDatabase.Connection))
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

        public bool EditSingleDepartment(Department newDepartment, string Action)
        {
            bool Worked = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand("Departement_sp", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Action", SqlDbType.VarChar).Value = Action;
                    cmd.Parameters.Add("@DepartementId", SqlDbType.Int).Value = newDepartment.DepartmentId;
                    cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = newDepartment.Description;
                    cmd.Parameters.Add("@Nom", SqlDbType.VarChar).Value = newDepartment.Name;
                    cmd.Parameters.Add("@isActive", SqlDbType.Bit).Value = newDepartment.Active;
                    cmd.ExecuteNonQuery();
                    Worked = true;
                }
            }
            catch
            {
                Worked = false;
            }
            return Worked;
        }
    }
}
