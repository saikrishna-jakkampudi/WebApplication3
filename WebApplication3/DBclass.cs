using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication3
{
    public class DBclass
    {
        SqlConnection Con = null;
        SqlCommand Cmd = null;
        public int getAppid()
        {
            int C = 0;

            try
            {
                Con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
                Con.Open();
                Cmd = new SqlCommand("select max(Applicationid) from Census", Con);
                string S = Cmd.ExecuteScalar().ToString();
                if (S == "")
                    C++;
                else
                    C = int.Parse(S) + 1;

            }
            catch (SqlException E)
            {

            }
            finally { Con.Close(); }
            return C;
        }

        public List<Population> SaveMembers(List<Population> L)
        {
            
            try
            {
                Con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
                Con.Open();
                Cmd = new SqlCommand("sp_Censu", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                DataTable Db = new DataTable();
                Db.Columns.Add("ApplicationId", typeof(Int32));
                Db.Columns.Add("MemberId", typeof(Int32));
                Db.Columns.Add("FirstName", typeof(string));
                Db.Columns.Add("MiddleName", typeof(string));
                Db.Columns.Add("LastName", typeof(string));
                Db.Columns.Add("Suffix", typeof(string));
                Db.Columns.Add("DOB", typeof(DateTime));
                Db.Columns.Add("Gender", typeof(string));
             
                for (int i = 0; i < L.Count; i++)
                {
                    Db.Rows.Add(L[i].ApplicationId, L[i].MemberId, L[i].FirstName, L[i].MiddleName, L[i].LastName, L[i].Suffix, L[i].DateOfBirth, L[i].Gender);
                }
                SqlParameter P = new SqlParameter("@Cen", Db);
                P.SqlDbType = SqlDbType.Structured;
                Cmd.Parameters.Add(P);
                Cmd.ExecuteNonQuery();
       

            }
            catch (SqlException E)
            { }

            finally
            {
                Con.Close();
            }
            return L;
        }

    }
}
