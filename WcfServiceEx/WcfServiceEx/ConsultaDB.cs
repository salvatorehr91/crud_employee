using System;
using System.Data;
using System.Data.SqlClient;

namespace WcfServiceEx
{
    public class ConsultaDB
    {
        private const string cs = @"Server=SALVATORE; Database=Desarrollo; User id=chava; password=Roman20";

        public DataTable Ejecuta(string query)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = query;
                        con.Open();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //con.Close();
                        return dt;
                    }
                }
            }
            catch (Exception)
            {
                return (DataTable)null;
            }
        }
    }
}