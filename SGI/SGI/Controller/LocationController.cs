﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGI.Model.Classes;

namespace SGI.Controller
{
    class LocationController
    {
        public List<Location> GetAllLocationsActive()
        {
            List<Location> Location = new List<Location>();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_location", CDatabase.Connection))
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
            return Location;
        }
    }
}
