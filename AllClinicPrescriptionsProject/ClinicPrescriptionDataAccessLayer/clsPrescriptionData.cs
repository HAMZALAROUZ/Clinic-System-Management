using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClinicPrescriptionDataAccessLayer
{
    public class clsPrescriptionData
    {
        public static int AddNewPrescription(int MedicalRecordID, string MedicationName, string Dosage, string Frequency, DateTime StartDate, DateTime EndDate, string SpecialInstructions)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Insert Into Prescriptions(MedicalRecordID,MedicationName,Dosage,Frequency,StartDate,EndDate,SpecialInstructions) Values(@MedicalRecordID,@MedicationName,@Dosage,@Frequency,@StartDate,@EndDate,@SpecialInstructions) Select SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, connection);


            cmd.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            cmd.Parameters.AddWithValue("@MedicationName", MedicationName);
            cmd.Parameters.AddWithValue("@Dosage", Dosage);
            cmd.Parameters.AddWithValue("@Frequency", Frequency);
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@EndDate", EndDate);
            if(SpecialInstructions != null) 
            cmd.Parameters.AddWithValue("@SpecialInstructions", SpecialInstructions);
            else
            cmd.Parameters.AddWithValue("@SpecialInstructions", DBNull.Value);

            try
            {
                connection.Open();

                object obj = cmd.ExecuteScalar();

                if (obj != null && int.TryParse(obj.ToString(), out int D))
                {
                    return D;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return -1;
        }

        public static bool UpdatePrescription(int PrescriptionID,int MedicalRecordID, string MedicationName, string Dosage, string Frequency, DateTime StartDate, DateTime EndDate, string SpecialInstructions)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Update Prescriptions Set MedicalRecordID = @MedicalRecordID,MedicationName = @MedicationName,Dosage = @Dosage,Frequency = @Frequency,StartDate = @StartDate,EndDate = @EndDate,SpecialInstructions  = @SpecialInstructions Where PrescriptionID = @PrescriptionID";


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);
            cmd.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            cmd.Parameters.AddWithValue("@MedicationName", MedicationName);
            cmd.Parameters.AddWithValue("@Dosage", Dosage);
            cmd.Parameters.AddWithValue("@Frequency", Frequency);
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@EndDate", EndDate);
            if (SpecialInstructions != null)
                cmd.Parameters.AddWithValue("@SpecialInstructions", SpecialInstructions);
            else
                cmd.Parameters.AddWithValue("@SpecialInstructions", DBNull.Value);




            try
            {
                connection.Open();

                int AffectedRows = cmd.ExecuteNonQuery();

                if (AffectedRows > 0)
                {
                    return true;
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public static bool DeletePrescription(int PrescriptionID)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Delete From Prescriptions Where PrescriptionID = @PrescriptionID";


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);

            try
            {
                connection.Open();
                int AffectedRows = cmd.ExecuteNonQuery();
                if (AffectedRows > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public static bool IsPrescriptionExists(int PrescriptionID)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Select found=1 From Prescriptions Where PrescriptionID = @PrescriptionID";


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);

            try
            {
                connection.Open();
                object obj = cmd.ExecuteScalar();
                if (obj != null)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public static bool FindPrescription(int PrescriptionID,ref int MedicalRecordID,ref string MedicationName,ref string Dosage,ref string Frequency,ref DateTime StartDate,ref DateTime EndDate,ref string SpecialInstructions)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Select * from Prescriptions where PrescriptionID = @PrescriptionID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MedicalRecordID = (int)reader["MedicalRecordID"];
                    MedicationName = (string)reader["MedicationName"];
                    Dosage = (string)reader["Dosage"];
                    Frequency = (string)reader["Frequency"];
                    StartDate = (DateTime)reader["StartDate"];
                    EndDate = (DateTime)reader["EndDate"];
                    if(reader["SpecialInstructions"] != DBNull.Value)
                    SpecialInstructions = (string)reader["SpecialInstructions"];
                    else
                    SpecialInstructions = string.Empty;

                    reader.Close();
                    return true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public static DataTable GetAllPrescriptions()
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);
            DataTable dt = new DataTable();
            string query = "Select * From Prescriptions";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return null;
        }
    }
}
