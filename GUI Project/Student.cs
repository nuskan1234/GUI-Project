using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace GUI_Project
{
    class Student
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        public Student()
        {
            con = new SqlConnection("Data Source=DESKTOP-STADLEU;Initial Catalog=StudentAttendence;Integrated Security=True");
        }
        public int Save_Update_Delete(string q)
        {
            con.Open();
            cmd = new SqlCommand(q, con);
            int i = cmd.ExecuteNonQuery();
            
            con.Close();
            return i;
          
        }
        public DataTable Display(string q)
        {
            con.Open();
            da = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        internal DataTable GetStudentDetails(string studentID, string batchID)
        {
            string query = "SELECT * FROM Student WHERE S_id = @StudentID AND Bid = @BatchID";
            DataTable dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand(query, con))
            {
                // Add parameters to the query to prevent SQL injection
                command.Parameters.AddWithValue("@StudentID", studentID);
                command.Parameters.AddWithValue("@BatchID", batchID);

                con.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        internal int UpdateStudentDetails(string studentID, string batchID, string studentName, string address, string phoneNumber, DateTime dob, string password)
        {
            // Construct the SQL query with parameters to avoid SQL injection
            string query = "UPDATE Student SET Sname = @StudentName, Saddress = @Address, Tp = @PhoneNumber, DOB = @DOB, Password = @Password WHERE S_id = @StudentID AND Bid = @BatchID";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                // Add parameters to the query to prevent SQL injection
                command.Parameters.AddWithValue("@StudentID", studentID);
                command.Parameters.AddWithValue("@BatchID", batchID);
                command.Parameters.AddWithValue("@StudentName", studentName);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@DOB", dob);
                command.Parameters.AddWithValue("@Password", password);

                con.Open();

                // Execute the UPDATE query
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected;
            }
        }
    }
}
