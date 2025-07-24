using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicPaymentDataAccess
{
    public class clsPaymentData
    {
        public static bool IsPaymentRelatedToAnyAppointment(int PaymentID)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);
            DataTable dt = new DataTable();
            string query = "Select top 1 found=1 From Appointments where PaymentID = @PaymentID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PaymentID",PaymentID);
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
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public static DataTable GetAllPayments()
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);
            DataTable dt = new DataTable();
            string query = "Select * From Payments";

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

        public static int AddNewPayment(DateTime PaymentDate,string PaymentMethod,decimal AmountPaid,string AdditionalNotes)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);
            string query = "Insert Into Payments(PaymentDate,PaymentMethod,AmountPaid,AdditionalNotes) Values (@PaymentDate,@PaymentMethod,@AmountPaid,@AdditionalNotes) Select SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
            if(PaymentMethod != null)
            command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            else
            command.Parameters.AddWithValue("@PaymentMethod", DBNull.Value);

            command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
            if(AdditionalNotes != null)
            command.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
            else
            command.Parameters.AddWithValue("@AdditionalNotes", DBNull.Value);

            try
            {
                connection.Open ();

                object obj = command.ExecuteScalar();

                if(obj!=null && int.TryParse(obj.ToString(), out int id))
                {
                    return id;
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

        public static bool UpdatePayment(int PaymentID,DateTime PaymentDate,string PaymentMethod,Decimal AmountPaid,string AdditionalNotes)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);
            string query = "Update Payments Set PaymentDate = @PaymentDate,PaymentMethod = @PaymentMethod,AmountPaid = @AmountPaid,AdditionalNotes = @AdditionalNotes where PaymentID = @PaymentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);
            command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
            if (PaymentMethod != null)
                command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            else
                command.Parameters.AddWithValue("@PaymentMethod", DBNull.Value);

            command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
            if (AdditionalNotes != null)
                command.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
            else
                command.Parameters.AddWithValue("@AdditionalNotes", DBNull.Value);

            try
            {
                connection.Open ();
                int AffectedRows = command.ExecuteNonQuery();

                if(AffectedRows>0)
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
                connection.Close ();
            }
            return false;
        }

        public static bool FindPayment(int PaymentID,ref DateTime PaymentDate,ref string PaymentMethod,ref Decimal AmountPaid,ref string AdditionalNotes)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);
            string query = "Select * From Payments Where PaymentID = @PaymentID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    PaymentDate =(DateTime) reader["PaymentDate"];
                    if (reader["PaymentMethod"] != DBNull.Value)
                        PaymentMethod = (string)reader["PaymentMethod"];
                    else
                        PaymentMethod = "";
                    AmountPaid = (decimal) reader["AmountPaid"];
                    if (reader["AdditionalNotes"] != DBNull.Value)
                        AdditionalNotes = (string)reader["AdditionalNotes"];
                    else
                        AdditionalNotes = "";

                    reader.Close ();
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

        public static bool DeletePayment(int PaymentID)
        {
            SqlConnection connection = new SqlConnection(clsDBAccessSetting.DataAccessSetting);
            string query = "Delete From Payments Where PaymentID = @PaymentID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);

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
