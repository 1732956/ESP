using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace SGI.Model.Classes
{
    public class Location
    {

        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public Location(int pId, string pName, string pDescription, bool pActive)
        {
            LocationId = pId;
            Name = pName;
            Description = pDescription;
            Active = pActive;
        }

        public Location(DataRow row)
        {
            this.LocationId = Convert.ToInt32(row["LocationId"]);
            this.Description = row["Descr"].ToString(); ;
            this.Name = row["Name"].ToString();
        }
       
    }
}
