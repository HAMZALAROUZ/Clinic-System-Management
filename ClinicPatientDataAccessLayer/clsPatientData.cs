using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClinicPatientDataAccessLayer
{
    public class clsPatientData
    {
        public static DataTable GetAllPatients()
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);
            DataTable dt = new DataTable();
            string query = "SELECT PatientID,Name,DateOfBirth,Gender,PhoneNumber,Email,Address FROM   Patients LEFT OUTER JOIN           Persons ON Patients.PersonID = Persons.PersonID";

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

        public static bool IsTableEmpty()
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "select top 1 found = 1 from Patients";


            SqlCommand cmd = new SqlCommand(query, connection);

            

            try
            {
                connection.Open();
                object obj = cmd.ExecuteScalar();
                if (obj != null)
                {
                    return false;
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
            return true;
        }
        public static int AddNewPatient(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Insert Into Patients(PersonID) Values(@PersonID) Select SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            
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
        public static bool DeleteAllAppointmentOfPatient(int id)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Delete From Appointments Where PatientID = @id";


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@id", id);

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
        public static bool FindPatient(int id,ref int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Select * from Patients where PatientID = @id";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    PersonID = (int)reader["PersonID"];
                    
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
        
        public static bool IsPatientHaveAppointments(int PatientID)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Select Found=1 From Appointments Where PatientID = @PatientID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PatientID", PatientID);

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
        public static bool DeletePatientByPatientID(int PatientID)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Delete From Patients Where PatientID = @PatientID";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PatientID", PatientID);

            try
            {
                connection.Open();

                int RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected > 0)
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
        public static bool DeletePatientByPersonID(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Delete From Patients Where PersonID = @PersonID";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                int RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected > 0)
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

        public static bool IsPatientExists(int PatientID)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Select Found=1 From Patients Where PatientID = @PatientID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PatientID", PatientID);

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
