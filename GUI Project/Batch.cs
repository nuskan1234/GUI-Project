using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GUI_Project
{
    

    class Batch
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        public Batch()
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

        internal object getData(string v)
        {
            throw new NotImplementedException();
        }
    }
}
