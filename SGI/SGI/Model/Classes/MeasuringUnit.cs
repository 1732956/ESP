using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.Model.Classes
{
    public class MeasuringUnit
    {
        public int UnitId { get; set; }
        public string Description { get; set; }
        public string UnitCode { get; set; }
        public bool Active { get; set; }
        public MeasuringUnit(int pId, string pUnitCode, string pDescription, bool pActive)
        {
            UnitId = pId;
            UnitCode = pUnitCode;
            Description = pDescription;
            Active = pActive;
        }

        public MeasuringUnit()
        {
            UnitId      = 0;
            UnitCode    = "";
            Description = "";
            Active      = true;
        }

        public MeasuringUnit(DataRow row)
        {
            UnitId = Convert.ToInt32(row["MesuringUnitID"]);
            UnitCode = row["UnitCode"].ToString();
            Description = row["Description"].ToString();
            Active = Convert.ToBoolean(row["isActive"]);
        }
    }
}
