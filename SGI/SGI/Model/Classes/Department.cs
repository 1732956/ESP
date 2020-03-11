using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.Model.Classes
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public Department(int pId, string pName, string pDescription, bool pActive)
        {
            DepartmentId = pId;
            Name = pName;
            Description = pDescription;
            Active = pActive;
        }

        public Department(DataRow row)
        {
            this.DepartmentId = Convert.ToInt32(row["DepartementId"]);
            this.Name = row["Nom"].ToString();
            this.Description = row["Description"].ToString();
            this.Active = Convert.ToBoolean(row["isActive"]);
        }
    }
}
