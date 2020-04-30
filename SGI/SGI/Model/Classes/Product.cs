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
        public double Price { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool Active { get; set; }
        public int UnitCount { get; set; }
        public int MaxQty { get; set; }
        public int MinQty { get; set; }
        public string BarCodeId { get; set; }
        public string MeasureUnit { get; set; }
        public int MeasureQty { get; set; }
        public Category Category { get; set; }
        public Supplier Supplier { get; set; }
        public String   CodeSupplier { get; set; }
        public List<Department> Departments { get; set; }

        public Product(DataRow row, bool isSingle)
        {
            if (!isSingle)
            {
                this.ProductId = Convert.ToInt32(row["ProductId"]);
                this.Name = row["Name"].ToString();
                this.Brand = row["Brand"].ToString();
                this.Description = row["Description"].ToString();
                this.Price = Convert.ToDouble(row["Price"]);
                this.LastUpdate = Convert.ToDateTime(row["LastUpdate"]);
                this.Active = Convert.ToBoolean(row["isActive"]);
                this.UnitCount = Convert.ToInt32(row["UnitNbr"]);
                this.MaxQty = Convert.ToInt32(row["QtyMax"]);
                this.MinQty = Convert.ToInt32(row["QtyMin"]);
                this.BarCodeId = row["BarCodeId"].ToString();
                this.CodeSupplier = row["SupplierCode"].ToString();
                this.MeasureUnit = row["MeasureUnit"].ToString();
                this.MeasureQty = Convert.ToInt32(row["MeasureQty"]);
                this.Supplier = new Supplier(Convert.ToInt32(row["SupID"]), row["SupName"].ToString(), row["SupResPers"].ToString(), row["SupAdress"].ToString(), row["SupEmail"].ToString(), row["SupPhone"].ToString(), Convert.ToDouble(row["SupMinOrderPrice"]), Convert.ToBoolean(row["SupActive"]));
                this.Category = new Category(Convert.ToInt32(row["CategoryId"]), row["CategoryDescription"].ToString(), Convert.ToBoolean(row["CategoryIsActive"]));
                this.Departments = new List<Department>();
            }
            else
            {
                this.ProductId = Convert.ToInt32(row["ProductId"]);
                this.Name = row["ProductName"].ToString();
                this.Brand = row["Brand"].ToString();
                this.Description = row["DescrProduct"].ToString();
                this.Price = Convert.ToDouble(row["Price"]);
                this.BarCodeId = row["BarCodeId"].ToString();
                this.MeasureUnit = row["MeasureUnit"].ToString();
                this.MeasureQty = Convert.ToInt32(row["MeasureQty"]);
                this.Supplier = new Supplier(0, row["SupName"].ToString(), "", "", "", "", 0, true);
                this.Category = new Category(0, row["CatDescr"].ToString(), true);
                this.Departments = new List<Department>();




            }
        }

        public void addDepartment(DataRow row)
        {
            this.Departments.Add(new Department(Convert.ToInt32(row["DepartementID"]), row["DepNom"].ToString(), row["Description"].ToString(),Convert.ToBoolean(row["IsActive"])));
        }


        public Product()
        {
            ProductId = 0;
            Name = "";
            Brand = "";
            Description = "";
            Supplier = new Supplier();
            Price = 0;
            LastUpdate = DateTime.Now;
            Active = true;
            UnitCount = 0;
            MaxQty = 0;
            MinQty = 0;
            BarCodeId = "";
            Category = new Category();
            Departments = new List<Department>();
            CodeSupplier = "";
            MeasureQty = 0;
            MeasureUnit = "";
        }

        public Product(int id, string name, string brand, string description, Supplier supplier, int price, bool active,
            int unitcount, int maxqty, int minqty, Category category, List<Department> departments, string codesupplier, string measureUnit,
            int measureQty)
        {
            ProductId = id;
            Name = name;
            Brand = brand;
            Description = description;
            Supplier = supplier;
            Price = price;
            Active = active;
            UnitCount = unitcount;
            MaxQty = maxqty;
            MinQty = minqty;
            Category = category;
            Departments = departments;
            CodeSupplier = codesupplier;
        }
    }
}
