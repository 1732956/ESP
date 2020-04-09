using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.Model.Classes
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ResourcePerson { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public double MinOrderPrice { get; set; }
        public bool Active { get; set; }
        public Supplier(DataRow row)
        {
            this.SupplierID = Convert.ToInt32(row["SupplierID"]);
            this.Name = row["Name"].ToString();
            this.Code = row["Code"].ToString();
            this.ResourcePerson = row["ResourcePerson"].ToString();
            this.Adress = row["Adress"].ToString();
            this.Email = row["Email"].ToString();
            this.PhoneNumber = row["PhoneNumber"].ToString();
            this.MinOrderPrice = Convert.ToDouble(row["MinOrderPrice"]);
            this.Active = Convert.ToBoolean(row["Active"]);
        }

        public Supplier(int SupplierID, string Name, string Code, string ResourcePerson, string Adress, string Email, string PhoneNumber, double MinOrderPrice, bool Active)
        {
            this.SupplierID = SupplierID;
            this.Name = Name;
            this.Code = Code;
            this.ResourcePerson = ResourcePerson;
            this.Adress = Adress;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.MinOrderPrice = MinOrderPrice;
            this.Active = Active;
        }

        public Supplier()
        {
            SupplierID = 0;
            Name = "";
            Code = "";
            ResourcePerson = "";
            Adress = "";
            Email = "";
            PhoneNumber = "";
            MinOrderPrice = 0;
            Active = true;
        }
    }
}
