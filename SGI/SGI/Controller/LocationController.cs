using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGI.Model.Classes;
using System.Windows.Forms;

namespace SGI.Controller
{
    class LocationController
    {
        public List<Location> GetAllLocationsActive()
        {
            List<Location> Location = new List<Location>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_location WHERE IsActive = 1", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    foreach (DataRow row in dt.Rows)
                    {
                        Location newLocation = new Location(row);
                        Location.Add(newLocation);
                    }
                }
            }
            catch(Exception ex)
            {
                if (CDatabase.Connection.State == ConnectionState.Open)
                    MessageBox.Show(ex.Message);
            }
            return Location;
        }

        public List<Location> GetAllLocationsInactive()
        {
            List<Location> Location = new List<Location>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_location WHERE IsActive = 0", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    foreach (DataRow row in dt.Rows)
                    {
                        Location newLocation = new Location(row);
                        Location.Add(newLocation);
                    }
                }
            }
            catch (Exception ex)
            {
                if (CDatabase.Connection.State == ConnectionState.Open)
                    MessageBox.Show(ex.Message);
            }
            return Location;
        }

        public List<Location> GetAllLocations()
        {
            List<Location> Location = new List<Location>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_location ORDER BY isActive DESC", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    foreach (DataRow row in dt.Rows)
                    {
                        Location newLocation = new Location(row);
                        Location.Add(newLocation);
                    }
                }
            }
            catch (Exception ex)
            {
                if (CDatabase.Connection.State == ConnectionState.Open)
                    MessageBox.Show(ex.Message);
            }
            return Location;
        }

        public bool EditSingleLocation(Location newLocation, string Action)
        {
            bool Worked = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand("Location_sp", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Action", SqlDbType.VarChar).Value = Action;
                    cmd.Parameters.Add("@LocationId", SqlDbType.Int).Value = newLocation.LocationId;
                    cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = newLocation.Description;
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = newLocation.Name;
                    cmd.Parameters.Add("@isActive", SqlDbType.Bit).Value = newLocation.Active;
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
