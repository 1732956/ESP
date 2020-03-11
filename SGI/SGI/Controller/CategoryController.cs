using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGI.Model.Classes;

namespace SGI.Controller
{
    public class CategoryController
    {
        public List<Category> GetAllActiveCategories()
        {
            List<Category> categories = new List<Category>();
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
            return categories;
        }
    }
}
