using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicMedicalRecordDataAcccessLayer
{
    public class clsMedicalRecordData
    {
        public static DataTable GelAllMedicalRecords()
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);
            DataTable dt = new DataTable();
            string query = "Select * From MedicalRecords";

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

        public static bool FindMedicalRecord(int MedicalRecordID, ref string VisitDescription, ref string Diagnosis, ref string AdditionalNotes)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Select * from MedicalRecords where MedicalRecordID = @MedicalRecordID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["VisitDescription"] != DBNull.Value)
                        VisitDescription = (string)reader["VisitDescription"];
                    else
                        VisitDescription = null;

                    if (reader["Diagnosis"] != DBNull.Value)
                        Diagnosis = (string)reader["Diagnosis"];
                    else
                        Diagnosis = null;

                    if (reader["AdditionalNotes"] != DBNull.Value)
                        AdditionalNotes = (string)reader["AdditionalNotes"];
                    else
                        AdditionalNotes = null;

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

        public static int AddNewMedicalRecord(string VisitDescription, string Diagnosis, string AdditionalNotes)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Insert Into MedicalRecords(VisitDescription,Diagnosis,AdditionalNotes) Values(@VisitDescription,@Diagnosis,@AdditionalNotes) Select SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, connection);


            if (VisitDescription != null)
                cmd.Parameters.AddWithValue("@VisitDescription", VisitDescription);
            else
                cmd.Parameters.AddWithValue("@VisitDescription", DBNull.Value);

            if (Diagnosis != null)
                cmd.Parameters.AddWithValue("@Diagnosis", Diagnosis);
            else
                cmd.Parameters.AddWithValue("@Diagnosis", DBNull.Value);

            if (AdditionalNotes != null)
                cmd.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
            else
                cmd.Parameters.AddWithValue("@AdditionalNotes", DBNull.Value);



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

        public static bool UpdateMedicalRecord(int MedicalRecordID, string VisitDescription, string Diagnosis, string AdditionalNotes)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Update MedicalRecords Set VisitDescription = @VisitDescription,Diagnosis = @Diagnosis,AdditionalNotes = @AdditionalNotes Where MedicalRecordID = @MedicalRecordID";


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

            if (VisitDescription != null)
                cmd.Parameters.AddWithValue("@VisitDescription", VisitDescription);
            else
                cmd.Parameters.AddWithValue("@VisitDescription", DBNull.Value);

            if (Diagnosis != null)
                cmd.Parameters.AddWithValue("@Diagnosis", Diagnosis);
            else
                cmd.Parameters.AddWithValue("@Diagnosis", DBNull.Value);

            if (AdditionalNotes != null)
                cmd.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
            else
                cmd.Parameters.AddWithValue("@AdditionalNotes", DBNull.Value);




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

        public static bool IsMedicalRecordExists(int MedicalRecordID)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Select found=1 From MedicalRecords Where MedicalRecordID = @MedicalRecordID";


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

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

        public static bool DeleteMedicalRecord(int MedicalRecordID)
        {

            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Delete From MedicalRecords Where MedicalRecordID = @MedicalRecordID";


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

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
    }
}

