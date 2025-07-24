using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicPersonDataAccessLayer
{
    public class clsPersonData
    {
        public static DataTable GetAllPersonsData()
        {
            SqlConnection sqlConnection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);
            DataTable dataTable = new DataTable();
            string cmdText = "Select * From Persons";
            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    dataTable.Load(sqlDataReader);
                    sqlDataReader.Close();
                    return dataTable;
                }

                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return null;
        }

        public static int AddNewPerson(string Name, char Gender, DateTime? DateOfBirth, string PhoneNumber, string Email, string Address)
        {
            SqlConnection sqlConnection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);
            string cmdText = "Insert Into Persons(Name,DateOfBirth,Gender,PhoneNumber,Email,Address) Values(@Name,@DateOfBirth,@Gender,@PhoneNumber,@Email,@Address) Select SCOPE_IDENTITY()";
            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Name", Name);
            if (DateOfBirth.HasValue)
            {
                sqlCommand.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@DateOfBirth", DBNull.Value);
            }

            sqlCommand.Parameters.AddWithValue("@Gender", Gender);
            sqlCommand.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            if (Email != null)
            {
                sqlCommand.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Email", DBNull.Value);
            }

            if (Address != null)
            {
                sqlCommand.Parameters.AddWithValue("@Address", Address);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Address", DBNull.Value);
            }

            try
            {
                sqlConnection.Open();
                object obj = sqlCommand.ExecuteScalar();
                if (obj != null && int.TryParse(obj.ToString(), out var result))
                {
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }

            return -1;
        }

        public static bool FindPerson(int PersonID, ref string Name, ref DateTime? DateOfBirth, ref char Gender, ref string PhoneNumber, ref string Email, ref string Address)
        {
            SqlConnection sqlConnection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);
            string cmdText = "Select * from Persons where PersonID = @PersonID";
            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    Name = (string)sqlDataReader["Name"];
                    if (sqlDataReader["DateOfBirth"] != DBNull.Value)
                    {
                        DateOfBirth = (DateTime)sqlDataReader["DateOfBirth"];
                    }
                    else
                    {
                        DateOfBirth = null;
                    }

                    Gender = Convert.ToChar(sqlDataReader["Gender"]);
                    PhoneNumber = (string)sqlDataReader["PhoneNumber"];
                    if (sqlDataReader["Email"] != DBNull.Value)
                    {
                        Email = (string)sqlDataReader["Email"];
                    }
                    else
                    {
                        Email = string.Empty;
                    }

                    if (sqlDataReader["Address"] != DBNull.Value)
                    {
                        Address = (string)sqlDataReader["Address"];
                    }
                    else
                    {
                        Address = string.Empty;
                    }

                    sqlDataReader.Close();
                    return true;
                }

                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }

            return false;
        }

        public static bool FindPerson(ref int PersonID, string Name, ref DateTime? DateOfBirth, ref char Gender, ref string PhoneNumber, ref string Email, ref string Address)
        {
            SqlConnection sqlConnection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);
            string cmdText = "Select * from Persons where Name = @Name";
            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Name", Name);
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    Name = (string)sqlDataReader["Name"];
                    if (sqlDataReader["DateOfBirth"] != DBNull.Value)
                    {
                        DateOfBirth = (DateTime)sqlDataReader["DateOfBirth"];
                    }
                    else
                    {
                        DateOfBirth = null;
                    }

                    Gender = Convert.ToChar(sqlDataReader["Gender"]);
                    PhoneNumber = (string)sqlDataReader["PhoneNumber"];
                    if (sqlDataReader["Email"] != DBNull.Value)
                    {
                        Email = (string)sqlDataReader["Email"];
                    }
                    else
                    {
                        Email = string.Empty;
                    }

                    if (sqlDataReader["Address"] != DBNull.Value)
                    {
                        Address = (string)sqlDataReader["Address"];
                    }
                    else
                    {
                        Address = string.Empty;
                    }

                    sqlDataReader.Close();
                    return true;
                }

                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }

            return false;
        }

        //public static DataTable GetAllPatientsData()
        //{
        //    SqlConnection sqlConnection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);
        //    DataTable dataTable = new DataTable();
        //    string cmdText = "Select PatientID,Name,DateOfBirth,Gender,PhoneNumber,Email,Address from Persons inner join Patients on Persons.PersonID = Patients.PersonID";
        //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
        //    try
        //    {
        //        sqlConnection.Open();
        //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        //        if (sqlDataReader.HasRows)
        //        {
        //            dataTable.Load(sqlDataReader);
        //            sqlDataReader.Close();
        //            return dataTable;
        //        }

        //        sqlDataReader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        sqlConnection.Close();
        //    }

        //    return null;
        //}

        //public static DataTable GetAllDoctorsData()
        //{
        //    SqlConnection sqlConnection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);
        //    DataTable dataTable = new DataTable();
        //    string cmdText = "Select DoctorID,Name,DateOfBirth,Gender,PhoneNumber,Email,Address,Specialization from Persons inner join Doctors on Persons.PersonID = Doctors.PersonID";
        //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
        //    try
        //    {
        //        sqlConnection.Open();
        //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        //        if (sqlDataReader.HasRows)
        //        {
        //            dataTable.Load(sqlDataReader);
        //            sqlDataReader.Close();
        //            return dataTable;
        //        }

        //        sqlDataReader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        sqlConnection.Close();
        //    }

        //    return null;
        //}

        public static bool UpdatePerson(int PersonID, string Name, DateTime? DateOfBirth, char Gender, string PhoneNumber, string Email, string Address)
        {
            SqlConnection sqlConnection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);
            string cmdText = "Update Persons Set Name = @Name,DateOfBirth = @DateOfBirth,Gender = @Gender,PhoneNumber = @PhoneNumber,Email = @Email,Address = @Address Where PersonID = @PersonID";
            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Name", Name);
            sqlCommand.Parameters.AddWithValue("@PersonID", PersonID);
            if (DateOfBirth.HasValue)
            {
                sqlCommand.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@DateOfBirth", DBNull.Value);
            }

            sqlCommand.Parameters.AddWithValue("@Gender", Gender);
            sqlCommand.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            if (Email != null)
            {
                sqlCommand.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Email", DBNull.Value);
            }

            if (Address != null)
            {
                sqlCommand.Parameters.AddWithValue("@Address", Address);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Address", DBNull.Value);
            }

            try
            {
                sqlConnection.Open();
                int num = sqlCommand.ExecuteNonQuery();
                if (num > 0)
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
                sqlConnection.Close();
            }

            return false;
        }

        public static bool DeletePerson(int PersonID)
        {
            SqlConnection sqlConnection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);
            string cmdText = "Delete From Persons Where PersonID = @PersonID";
            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                sqlConnection.Open();
                int num = sqlCommand.ExecuteNonQuery();
                if (num > 0)
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
                sqlConnection.Close();
            }

            return false;
        }

        public static bool IsPersonExists(int PersonID)
        {
            SqlConnection sqlConnection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);
            string cmdText = "Select found=1 From Persons Where PersonID = @PersonID";
            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                sqlConnection.Open();
                object obj = sqlCommand.ExecuteScalar();
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
                sqlConnection.Close();
            }

            return false;
        }
    }
}
