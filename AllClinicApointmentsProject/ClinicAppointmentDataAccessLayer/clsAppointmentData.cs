using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppointmentDataAccessLayer
{
    public class clsAppointmentData
    {
        public static DataTable GetAllAppointments()
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);
            DataTable dt = new DataTable();
            string query = "Select * From Appointments";

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

        public static bool FindAppointment(int AppointmentID,ref int PatientID,ref int DoctorID ,ref DateTime AppointmentDateTime, ref string AppointmentStatus, ref int?   MedicalRecordID ,ref int? PaymentID)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);
            
            string query = "Select * From Appointments Where AppointmentID = @AppointmentID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    PatientID = (int)reader["PatientID"];
                    DoctorID = (int)reader["DoctorID"];
                    AppointmentDateTime = (DateTime)reader["AppointmentDateTime"];
                    AppointmentStatus = (string)reader["AppointmentStatus"];
                    if(reader["MedicalRecordID"] != DBNull.Value)
                    MedicalRecordID = (int)reader["MedicalRecordID"];
                    else
                    MedicalRecordID = null;
                    if (reader["PaymentID"] != DBNull.Value)
                        PaymentID = (int)reader["PaymentID"];
                    else
                        PaymentID = null;
                    reader.Close();
                    return true;
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
            return false;
        }

        public static int AddNewAppointment(int PatientID, int DoctorID,DateTime AppointmentDateTime,string AppointmentStatus,int? MedicalRecordID, int? PaymentID)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "insert into Appointments(PatientID,DoctorID,AppointmentDateTime,AppointmentStatus,MedicalRecordID,PaymentID) Values (@PatientID,@DoctorID,@AppointmentDateTime,@AppointmentStatus,@MedicalRecordID,@PaymentID) Select SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, connection);

            
            cmd.Parameters.AddWithValue("@PatientID", PatientID);
            cmd.Parameters.AddWithValue("@DoctorID", DoctorID);
            cmd.Parameters.AddWithValue("@AppointmentDateTime", AppointmentDateTime);
            cmd.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);
            if(MedicalRecordID != null)
            cmd.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            else
            cmd.Parameters.AddWithValue("@MedicalRecordID", DBNull.Value);
            if(PaymentID != null)
            cmd.Parameters.AddWithValue("@PaymentID", PaymentID);
            else
                cmd.Parameters.AddWithValue("@PaymentID", DBNull.Value);
            try
            {
                connection.Open();

                object obj = cmd.ExecuteScalar();

                if(obj != null && int.TryParse(obj.ToString(),out int ID))
                {
                    return ID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return -1;
        }

        public static bool UpdateAppointment(int AppointmentID, int PatientID, int DoctorID, DateTime AppointmentDateTime, string AppointmentStatus, int? MedicalRecordID, int? PaymentID)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Update Appointments Set PatientID = @PatientID,DoctorID=@DoctorID ,AppointmentDateTime = @AppointmentDateTime,AppointmentStatus = @AppointmentStatus,MedicalRecordID = @MedicalRecordID,PaymentID = @PaymentID Where AppointmentID = @AppointmentID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            cmd.Parameters.AddWithValue("@PatientID", PatientID);
            cmd.Parameters.AddWithValue("@DoctorID", DoctorID);
            cmd.Parameters.AddWithValue("@AppointmentDateTime", AppointmentDateTime);
            cmd.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);
            if (MedicalRecordID != null)
                cmd.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
            else
                cmd.Parameters.AddWithValue("@MedicalRecordID", DBNull.Value);
            if (PaymentID != null)
                cmd.Parameters.AddWithValue("@PaymentID", PaymentID);
            else
                cmd.Parameters.AddWithValue("@PaymentID", DBNull.Value);
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
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public static bool DeleteAppointment(int AppointmentID)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Delete From Appointments Where AppointmentID = @AppointmentID";


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID);

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

        public static bool IsAppointmentExists(int AppointmentID)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Select found=1 From Appointments Where AppointmentID = @AppointmentID";


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID);

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
    }
}
