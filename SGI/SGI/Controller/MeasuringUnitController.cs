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
    public class MeasuringUnitController
    {
        public List<MeasuringUnit> GetAllActiveMeasuringUnits()
        {
            List<MeasuringUnit> measuringUnits = new List<MeasuringUnit>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_MesuringUnit where isActive = 1", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    foreach (DataRow row in dt.Rows)
                    {
                        MeasuringUnit newMU = new MeasuringUnit(row);
                        measuringUnits.Add(newMU);
                    }
                }
            }
            catch (Exception ex)
            {
                if (CDatabase.Connection.State == ConnectionState.Open)
                    MessageBox.Show(ex.Message);
            }
            return measuringUnits;
        }

        public List<MeasuringUnit> GetAllInactiveMeasuringUnits()
        {
            List<MeasuringUnit> measuringUnits = new List<MeasuringUnit>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_MesuringUnit where isActive = 0", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    foreach (DataRow row in dt.Rows)
                    {
                        MeasuringUnit newMU = new MeasuringUnit(row);
                        measuringUnits.Add(newMU);
                    }
                }
            }
            catch (Exception ex)
            {
                if (CDatabase.Connection.State == ConnectionState.Open)
                    MessageBox.Show(ex.Message);
            }
            return measuringUnits;
        }

        public List<MeasuringUnit> GetAllMeasuringUnits()
        {
            List<MeasuringUnit> measuringUnits = new List<MeasuringUnit>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_MesuringUnit ORDER by isActive DESC", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    foreach (DataRow row in dt.Rows)
                    {
                        MeasuringUnit newMU = new MeasuringUnit(row);
                        measuringUnits.Add(newMU);
                    }
                }
            }
            catch (Exception ex)
            {
                if (CDatabase.Connection.State == ConnectionState.Open)
                    MessageBox.Show(ex.Message);
            }
            return measuringUnits;
        }

        public bool EditSingleMeasuringUnit(MeasuringUnit newMU, string Action)
        {
            bool Worked = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand("MesuringUnit_sp", CDatabase.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Action", SqlDbType.VarChar).Value = Action;
                    cmd.Parameters.Add("@UnitId", SqlDbType.Int).Value = newMU.UnitId;
                    cmd.Parameters.Add("@Descr", SqlDbType.VarChar).Value = newMU.Description;
                    cmd.Parameters.Add("@UnitCode", SqlDbType.VarChar).Value = newMU.UnitCode;
                    cmd.Parameters.Add("@isActive", SqlDbType.Bit).Value = newMU.Active;
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
