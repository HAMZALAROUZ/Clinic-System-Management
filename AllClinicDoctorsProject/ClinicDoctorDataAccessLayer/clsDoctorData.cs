using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClinicDoctorDataAccessLayer
{
    public class clsDoctorData
    {
        public static bool FindDoctor(int DoctorID, ref int PersonID,ref string Specialization)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Select * from Doctors where DoctorID = @DoctorID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@DoctorID", DoctorID);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    PersonID = (int)reader["PersonID"];

                    if(reader["Specialization"] != DBNull.Value)
                    Specialization = (string)reader["Specialization"];
                    else
                    Specialization = null;


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
        public static bool IsTableEmpty()
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "select top 1 found = 1 from Doctors";


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
        public static bool DeleteAllAppointmentsOfDoctor(int DoctorID)
        {

            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Delete From Appointments Where DoctorID = @DoctorID";


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@DoctorID", DoctorID);

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
        public static bool IsDoctorHasAppointments(int DoctorID)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Select Found=1 From Appointments Where DoctorID = @DoctorID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@DoctorID", DoctorID);

            try
            {
                connection.Open();

                object obj = cmd.ExecuteScalar();
                if (obj != null && Convert.ToInt32(obj) > 0)
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
        public static bool IsDoctorExists(int? DoctorID)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Select Found=1 From Doctors Where DoctorID = @DoctorID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@DoctorID", DoctorID);

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
        public static bool UpdateDoctor(int DoctorID,string Specialization)//will update doctors table by DoctorID
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Update Doctors Set Specialization = @Specialization Where DoctorID = @DoctorID";


            SqlCommand cmd = new SqlCommand(query, connection);

            

            if (Specialization != null)
                cmd.Parameters.AddWithValue("@Specialization", Specialization);
            else
                cmd.Parameters.AddWithValue("@Specialization", DBNull.Value);

                cmd.Parameters.AddWithValue("@DoctorID", DoctorID);





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
        public static int AddNewDoctor(int PersonID,string Specialization)
        {
            
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Insert Into Doctors(PersonID,Specialization) Values(@PersonID,@Specialization) Select SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            if(Specialization != null)
            cmd.Parameters.AddWithValue("@Specialization", Specialization);
            else
            cmd.Parameters.AddWithValue("@Specialization", DBNull.Value);

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

        public static bool DeleteDoctorByDoctorID(int DoctorID)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Delete From Doctors Where DoctorID = @DoctorID";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@DoctorID", DoctorID);

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
        public static bool DeleteDoctorByPersonID(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);

            string query = "Delete From Doctors Where PersonID = @PersonID";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("PersonID", PersonID);

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
        public static DataTable GetAllDoctorsData()
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);
            DataTable dt = new DataTable();
            string query = "SELECT DoctorID,Name,DateOfBirth,Gender,PhoneNumber,Email,Address,Specialization FROM   Doctors LEFT OUTER JOIN           Persons ON Doctors.PersonID = Persons.PersonID";

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
