using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GUI_Project
{
    class Module
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        public Module()
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

       /* internal DataTable GetModuleDetails(string moduleID)
        {
            string query = "SELECT ModuleName, NumLectures FROM Modules WHERE ModuleID = @ModuleID";


            {
                con.Open();

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@ModuleID", moduleID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new DataTable
                            {
                                ModuleName = reader["ModuleName"].ToString(),
                                NumLectures = Convert.ToInt32(reader["NumLectures"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        internal int UpdateModuleDetails(string moduleID, string moduleName, int numLectures)
        {
            string query = "UPDATE Modules SET ModuleName = @ModuleName, NumLectures = @NumLectures WHERE ModuleID = @ModuleID";

            {
                con.Open();

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@ModuleName", moduleName);
                    command.Parameters.AddWithValue("@NumLectures", numLectures);
                    command.Parameters.AddWithValue("@ModuleID", moduleID);

                    return command.ExecuteNonQuery();
                }
            }
        }*/
    }
}
