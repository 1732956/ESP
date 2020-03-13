using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SGI.Model.Classes
{
    class ReasonCode
    {
        public int ReasonId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public ReasonCode(int pId, string pCode, string pDescription, bool pActive)
        {
            ReasonId = pId;
            Code = pCode;
            Description = pDescription;
            Active = pActive;
        }

        public ReasonCode(DataRow row)
        {
            this.ReasonId = Convert.ToInt32(row["ReasonId"]);
            this.Description = row["Description"].ToString(); ;
            this.Code = row["Code"].ToString();
        }
    }
}
