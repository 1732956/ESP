using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.Model.Classes
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string Supplier { get; set; }
        public string SupplierCode { get; set; }
        public double Price { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool Active { get; set; }
        public int UnitCount { get; set; }
        public int MaxQty { get; set; }
        public int MinQty { get; set; }
        public string BarCodeId { get; set; }
        public Category Category { get; set; }
        public Department Department { get; set; }
        public MeasuringUnit MeasuringUnit { get; set; }

        public Product(DataRow row, bool isSingle)
        {
            if (!isSingle)
            {
                this.ProductId = Convert.ToInt32(row["ProductId"]);
                this.Name = row["Name"].ToString();
                this.Brand = row["Brand"].ToString();
                this.Description = row["Description"].ToString();
            this.Supplier = row["SupplierName"].ToString();
            this.SupplierCode = row["SupplierCode"].ToString();
                this.Price = Convert.ToDouble(row["Price"]);
            this.LastUpdate = Convert.ToDateTime(row["LastUpdate"]);
                this.Active = Convert.ToBoolean(row["isActive"]);
                this.UnitCount = Convert.ToInt32(row["UnitNbr"]);
                this.MaxQty = Convert.ToInt32(row["QtyMax"]);
                this.MinQty = Convert.ToInt32(row["QtyMin"]);
                this.BarCodeId = row["BarCodeId"].ToString();
                this.Category = new Category(Convert.ToInt32(row["CategoryId"]), row["CategoryDescription"].ToString(), Convert.ToBoolean(row["CategoryIsActive"]));
                this.Department = new Department(Convert.ToInt32(row["DepartementId"]), row["DepartmentName"].ToString(), row["DepartmentDescription"].ToString(), Convert.ToBoolean(row["DepartmentIsActive"]));
                this.MeasuringUnit = new MeasuringUnit(Convert.ToInt32(row["MeasuringUnitId"]), row["UnitCode"].ToString(), row["MeasuringUnitDescription"].ToString(), Convert.ToBoolean(row["MeasuringUnitIsActive"]));

            }
            else
            {
                this.ProductId = Convert.ToInt32(row["ProductId"]);
                this.Name = row["ProductName"].ToString();
                this.Brand = row["Brand"].ToString();
                this.Description = row["DescrProduct"].ToString();
                this.Price = Convert.ToDouble(row["Price"]);
                this.BarCodeId = row["BarCodeId"].ToString();
                this.Category = new Category(0, row["CatDescr"].ToString(), true);
                this.Department = new Department(0, row["DepNom"].ToString(), "",true);
                this.MeasuringUnit = new MeasuringUnit();
            }
        }

        public Product()
        {
            ProductId = 0;
            Name = "";
            Brand = "";
            Description = "";
            Supplier = "";
            SupplierCode = "";
            Price = 0;
            LastUpdate = DateTime.Now;
            Active = true;
            UnitCount = 0;
            MaxQty = 0;
            MinQty = 0;
            BarCodeId = "";
            Category = new Category();
            Department = new Department();
            MeasuringUnit = new MeasuringUnit();
        }
    }
}
