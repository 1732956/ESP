using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.Model.Classes
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public Category(int pId, string pDescription, bool pActive)
        {
            CategoryID = pId;
            Description = pDescription;
            Active = pActive;
        }

        public Category(DataRow row)
        {     
           	this.CategoryID = Convert.ToInt32(row["CategoryId"]);
           	this.Description = row["Description"].ToString();
           	this.Active = Convert.ToBoolean(row["isActive"]);
        }
        public Category()
        {
        	CategoryID = 0;
        	Description = "";
        	Active = true;
        }
        

    }
}
