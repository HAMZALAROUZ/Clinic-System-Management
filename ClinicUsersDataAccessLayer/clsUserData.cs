using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClinicUsersDataAccessLayer
{
    public class clsUserData
    {
        public static int AddNewUser(string UserName,string Name, string Password, int Permission)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.ConnectionString);
            string query = "Insert Into Users (UserName,Name,Password,Permission) Values (@UserName,@Name,@Password,@Permission)  Select SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permission", Permission);

            try
            {
                connection.Open();
                object obj = command.ExecuteScalar();

                if (obj != null && int.TryParse(obj.ToString(), out int ID))
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
        public static bool FindUser(int UserID, ref string UserName,ref string Name, ref string Password, ref int Permission)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.ConnectionString);
            string query = "Select * from Users  Where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    UserName = (string)reader["UserName"];
                    Name = (string)reader["Name"];
                    Password = (string)reader["Password"];
                    Permission = (int)reader["Permission"];
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
        //Find User By UserName
        public static bool FindUser(ref int UserID, string UserName,ref string Name ,ref string Password, ref int Permission)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.ConnectionString);
            string query = "Select * from Users  Where UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {


                    UserID = (int)reader["UserID"];
                    Name = (string)reader["Name"];
                    Password = (string)reader["Password"];
                    Permission = (int)reader["Permission"];
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
        //Find User By Name
        public static bool FindUserByName(ref int UserID,  string UserName,ref string Name, ref string Password, ref int Permission)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.ConnectionString);
            string query = "Select * from Users  Where UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {


                    UserID = (int)reader["UserID"];                    
                    Name = (string)reader["Name"];
                    Password = (string)reader["Password"];
                    Permission = (int)reader["Permission"];
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
        public static bool UpdateUser(int UserID, string UserName, string Name, string Password, int Permission)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.ConnectionString);
            string query = "Update Users Set UserName = @UserName,Name = @Name,Password = @Password,Permission = @Permission Where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permission", Permission);

            try
            {
                connection.Open();
                int AffectedRows = command.ExecuteNonQuery();

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

        public static DataTable GetAllUsersData()
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.ConnectionString);
            string query = "Select * From Users";
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

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

        public static bool IsUserExists(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.ConnectionString);
            string query = "Select Found = 1 From Users Where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                object obj = command.ExecuteScalar();

                if (obj != null && int.TryParse(obj.ToString(), out int ID))
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

        public static bool DeleteUser(int UserID)//
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.ConnectionString);
            string query = "Delete From Users Where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                int AffectedRows = command.ExecuteNonQuery();

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
    }
}
