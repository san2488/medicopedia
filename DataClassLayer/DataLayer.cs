using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataClassLayer
{
    public class DataLayer
    {
 
  //Query for inserting into a table
        public SqlCommand Insert(SqlCommand cmdSQL, string connString)
        {
            SqlConnection connSQL = null;
            try
            {
                using (connSQL = new SqlConnection(connString))
                {
                    cmdSQL.Connection = connSQL;
                    connSQL.Open();
                    cmdSQL.ExecuteNonQuery();
                    return cmdSQL;
                }
            }
            catch
            {

                throw;
            }
            finally
            {
                if (connSQL != null)
                {
                    connSQL.Close();
                    connSQL.Dispose();
                }
            }
        }
 //Query for updating a table
        public SqlCommand Update(SqlCommand cmdSQL, string connString)
        {
            SqlConnection connSQL = null;
            try
            {
                using (connSQL = new SqlConnection(connString))
                {
                    cmdSQL.Connection = connSQL;
                    connSQL.Open();
                    cmdSQL.ExecuteNonQuery();
                    return cmdSQL;
                }
            }
            catch
            {

                throw;
            }
            finally
            {
                if (connSQL != null)
                {
                    connSQL.Close();
                    connSQL.Dispose();
                }
            }
        }
  //Query for deleting from a table
        public SqlCommand Delete(SqlCommand cmdSQL, string connString)
        {
            SqlConnection connSQL = null;
            try
            {
                using (connSQL = new SqlConnection(connString))
                {
                    cmdSQL.Connection = connSQL;
                    connSQL.Open();
                    cmdSQL.ExecuteNonQuery();
                    return cmdSQL;
                }
            }
            catch
            {

                throw;
            }
            finally
            {
                if (connSQL != null)
                {
                    connSQL.Close();
                    connSQL.Dispose();
                }
            }
        }
 //Query for selecting from a table
        public SqlCommand Select(SqlCommand cmdSQL, string connString)
        {
            SqlConnection connSQL = null;
            try
            {
                using (connSQL = new SqlConnection(connString))
                {
                    cmdSQL.Connection = connSQL;
                    connSQL.Open();
                    cmdSQL.ExecuteNonQuery();
                    return cmdSQL;
                }
            }
            catch
            {

                throw;
            }
            finally
            {
                if (connSQL != null)
                {
                    connSQL.Close();
                    connSQL.Dispose();
                }
            }
        }

        public DataSet GetQuery(SqlCommand cmd, string connection)
        {
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                using (conn)
                {
                    cmd.Connection = conn;
                    conn.Open();
                    da.Fill(ds, "querrie");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return ds;
        } 
    }

}
