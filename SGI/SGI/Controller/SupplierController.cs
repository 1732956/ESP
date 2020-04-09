using SGI.Model.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGI.Controller
{
    class SupplierController
    {
        public List<Supplier> GetAllSuppliersActive()
        {
            List<Supplier> Supplier = new List<Supplier>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_Supplier WHERE Active = 1", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    foreach (DataRow row in dt.Rows)
                    {
                        Supplier newSupplier = new Supplier(row);
                        Supplier.Add(newSupplier);
                    }
                }
            }
            catch (Exception ex)
            {
                if (CDatabase.Connection.State == ConnectionState.Open)
                    MessageBox.Show(ex.Message);
            }
            return Supplier;
        }

        public List<Supplier> GetAllSuppliersInactive()
        {
            List<Supplier> Supplier = new List<Supplier>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_Supplier WHERE Active = 0", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    foreach (DataRow row in dt.Rows)
                    {
                        Supplier newSupplier = new Supplier(row);
                        Supplier.Add(newSupplier);
                    }
                }
            }
            catch (Exception ex)
            {
                if (CDatabase.Connection.State == ConnectionState.Open)
                    MessageBox.Show(ex.Message);
            }
            return Supplier;
        }

        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> Supplier = new List<Supplier>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_Supplier ORDER BY Active DESC", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    foreach (DataRow row in dt.Rows)
                    {
                        Supplier newSupplier = new Supplier(row);
                        Supplier.Add(newSupplier);
                    }
                }
            }
            catch (Exception ex)
            {
                if (CDatabase.Connection.State == ConnectionState.Open)
                    MessageBox.Show(ex.Message);
            }
            return Supplier;
        }

        public bool EditSingleSupplier(Supplier newSupplier, string Action)
        {
            bool Worked = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand("Supplier_sp", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Action", SqlDbType.VarChar).Value = Action;
                    cmd.Parameters.Add("@SupplierId", SqlDbType.Int).Value = newSupplier.SupplierID;
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = newSupplier.Name;
                    cmd.Parameters.Add("@Code", SqlDbType.VarChar).Value = newSupplier.Code;
                    cmd.Parameters.Add("@ResourcePerson", SqlDbType.VarChar).Value = newSupplier.ResourcePerson;
                    cmd.Parameters.Add("@Adress", SqlDbType.VarChar).Value = newSupplier.Adress;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = newSupplier.Email;
                    cmd.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = newSupplier.PhoneNumber;
                    cmd.Parameters.Add("@MinOrderPrice", SqlDbType.Money).Value = newSupplier.MinOrderPrice;
                    cmd.Parameters.Add("@Active", SqlDbType.Bit).Value = newSupplier.Active;
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
    }
}
