using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace KJHCore
{
    internal class clsMsSql
    {
        private static string _connectionString = string.Empty;
        private static SqlConnection _cn = new SqlConnection();

        public static string ConnectionString
        {
            get => clsMsSql._connectionString;
            set => clsMsSql._connectionString = value;
        }

        private static void ConnectionOpen(string connectionString)
        {
            try
            {
                if (clsMsSql._cn.State != ConnectionState.Closed)
                    return;
                clsMsSql._cn.ConnectionString = clsMsSql._connectionString;
                clsMsSql._cn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void ConnectionClose() => clsMsSql._cn.Close();

        public static DataTable GetDataTable(string connectionString, string strSQL)
        {
            DataTable dataTable = new DataTable();
            try
            {
                clsMsSql._connectionString = connectionString;
                clsMsSql.ConnectionOpen(connectionString);
                new SqlDataAdapter(strSQL, clsMsSql._cn).Fill(dataTable);
                clsMsSql.ConnectionClose();
            }
            catch (Exception ex)
            {
                clsMsSql.ConnectionClose();
                clsLog.ErrLog(ex, strSQL);
                throw ex;
            }
            return dataTable;
        }

        public static int GetDataTable(
          string connectionString,
          string strSQL,
          SqlParameterCollection oraParms)
        {
            int dataTable;
            try
            {
                clsMsSql._connectionString = connectionString;
                clsMsSql.ConnectionOpen(connectionString);
                SqlCommand cmd = new SqlCommand(strSQL, clsMsSql._cn);
                clsMsSql.Parameters(ref cmd, oraParms);
                dataTable = int.Parse(cmd.ExecuteScalar().ToString());
                clsMsSql.ConnectionClose();
            }
            catch (Exception ex)
            {
                clsMsSql.ConnectionClose();
                clsLog.ErrLog(ex, strSQL);
                throw ex;
            }
            return dataTable;
        }

        public static int SetData(
          string connectionString,
          string strSQL,
          SqlParameterCollection oraParms)
        {
            SqlTransaction sqlTransaction = (SqlTransaction)null;
            SqlCommand cmd = new SqlCommand(strSQL, clsMsSql._cn);
            int num;
            try
            {
                clsMsSql._connectionString = connectionString;
                clsMsSql.ConnectionOpen(connectionString);
                sqlTransaction = clsMsSql._cn.BeginTransaction();
                clsMsSql.Parameters(ref cmd, ref oraParms);
                cmd.Transaction = sqlTransaction;
                num = cmd.ExecuteNonQuery();
                sqlTransaction.Commit();
                clsMsSql.ConnectionClose();
            }
            catch (Exception ex)
            {
                clsLog.ErrLog(ex, strSQL, oraParms);
                sqlTransaction.Rollback();
                clsMsSql.ConnectionClose();
                throw ex;
            }
            return num;
        }

        public static int SetData(string connectionString, string strSQL)
        {
            SqlTransaction sqlTransaction = (SqlTransaction)null;
            SqlCommand sqlCommand = new SqlCommand(strSQL, clsMsSql._cn);
            int num;
            try
            {
                clsMsSql._connectionString = connectionString;
                clsMsSql.ConnectionOpen(connectionString);
                sqlTransaction = clsMsSql._cn.BeginTransaction();
                sqlCommand.Transaction = sqlTransaction;
                num = sqlCommand.ExecuteNonQuery();
                sqlTransaction.Commit();
                clsMsSql.ConnectionClose();
            }
            catch (Exception ex)
            {
                clsLog.ErrLog(ex, strSQL);
                sqlTransaction.Rollback();
                clsMsSql.ConnectionClose();
                throw ex;
            }
            return num;
        }

        public static void Parameters(ref SqlCommand cmd, SqlParameterCollection oraParms)
        {
            try
            {
                int num = 0;
                foreach (SqlParameter oraParm in (DbParameterCollection)oraParms)
                {
                    cmd.Parameters.Add(oraParm.ParameterName, oraParm.SqlDbType, oraParm.Size);
                    cmd.Parameters[oraParm.ParameterName].Value = oraParm.Value;
                    ++num;
                }
            }
            catch (Exception ex)
            {
                clsLog.ErrLog(ex, "[Parameter오류]\n", oraParms);
                throw ex;
            }
        }

        public static void Parameters(ref SqlCommand cmd, ref SqlParameterCollection oraParms)
        {
            try
            {
                int num = 0;
                for (int index = 0; index < oraParms.Count; ++index)
                {
                    if (!string.IsNullOrEmpty(oraParms[index].Value.ToString()))
                    {
                        Encoding encoding = Encoding.GetEncoding("utf-8");
                        byte[] bytes = encoding.GetBytes(oraParms[index].Value.ToString());
                        if (oraParms[index].Size < bytes.Length)
                        {
                            string empty = string.Empty;
                            string s = encoding.GetString(bytes, 0, oraParms[index].Size);
                            if (encoding.GetBytes(s).Length > oraParms[index].Size)
                                oraParms[index].Value = (object)encoding.GetString(bytes, 0, oraParms[index].Size - 1);
                            else
                                oraParms[index].Value = (object)s;
                        }
                    }
                }
                foreach (SqlParameter sqlParameter in (DbParameterCollection)oraParms)
                {
                    cmd.Parameters.Add(sqlParameter.ParameterName, sqlParameter.SqlDbType, sqlParameter.Size);
                    cmd.Parameters[sqlParameter.ParameterName].Value = sqlParameter.Value;
                    ++num;
                }
            }
            catch (Exception ex)
            {
                clsLog.ErrLog(ex, "[Parameter오류]\n", oraParms);
                throw ex;
            }
        }
    }
}
