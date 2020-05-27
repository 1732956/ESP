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
    public class CategoryController
    {
        public List<Category> GetAllActiveCategories()
        {
            List<Category> categories = new List<Category>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_Category where isActive = 1", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    foreach (DataRow row in dt.Rows)
                    {
                        Category newCategory = new Category(row);
                        categories.Add(newCategory);
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

        public List<Category> GetAllInactiveCategories()
        {
            List<Category> categories = new List<Category>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_Category where isActive = 0", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    foreach (DataRow row in dt.Rows)
                    {
                        Category newCategory = new Category(row);
                        categories.Add(newCategory);
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

        public List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_Category ORDER BY isActive DESC", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    foreach (DataRow row in dt.Rows)
                    {
                        Category newCategory = new Category(row);
                        categories.Add(newCategory);
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

        public bool EditSingleCategory(Category newCategory, string Action)
        {
            bool Worked = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand("Category_sp", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Action", SqlDbType.VarChar).Value = Action;
                    cmd.Parameters.Add("@CategoryId", SqlDbType.Int).Value = newCategory.CategoryID;
                    cmd.Parameters.Add("@Descr", SqlDbType.VarChar).Value = newCategory.Description;
                    cmd.Parameters.Add("@isActive", SqlDbType.Bit).Value = newCategory.Active;
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

        public bool ifAlreadyExist(Category currentCategory)
        {
            bool alreadyExist = false;

            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_category WHERE Description = '" + currentCategory.Description + "'", CDatabase.Connection);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if(Convert.ToInt32(dt.Rows[i]["CategoryId"]) != currentCategory.CategoryID)
                        alreadyExist = true;
                }
            }

            return alreadyExist;
        }
    }
}


