using System;
using System.Data;
using System.Data.Common;
using System.Data.OracleClient;
using System.Text;

namespace KJHCore
{
    internal class clsOracle
    {
        private static string _connectionString = string.Empty;
        private static OracleConnection _cn = new OracleConnection();

        public static string ConnectionString
        {
            get => clsOracle._connectionString;
            set => clsOracle._connectionString = value;
        }

        private static void ConnectionOpen(string connectionString)
        {
            try
            {
                if (clsOracle._cn.State != ConnectionState.Closed)
                    return;
                clsOracle._cn.ConnectionString = clsOracle._connectionString;
                clsOracle._cn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void ConnectionClose() => clsOracle._cn.Close();

        public static DataTable GetDataTable(string connectionString, string strSQL)
        {
            DataTable dataTable = new DataTable();
            try
            {
                clsOracle._connectionString = connectionString;
                clsOracle.ConnectionOpen(connectionString);
                new OracleDataAdapter(strSQL, clsOracle._cn).Fill(dataTable);
                clsOracle.ConnectionClose();
            }
            catch (Exception ex)
            {
                clsOracle.ConnectionClose();
                clsLog.ErrLog(ex, strSQL);
                throw ex;
            }
            return dataTable;
        }

        public static int GetDataTable(
          string connectionString,
          string strSQL,
          OracleParameterCollection oraParms)
        {
            int dataTable;
            try
            {
                clsOracle._connectionString = connectionString;
                clsOracle.ConnectionOpen(connectionString);
                OracleCommand cmd = new OracleCommand(strSQL, clsOracle._cn);
                clsOracle.Parameters(ref cmd, oraParms);
                dataTable = int.Parse(cmd.ExecuteOracleScalar().ToString());
                clsOracle.ConnectionClose();
            }
            catch (Exception ex)
            {
                clsOracle.ConnectionClose();
                clsLog.ErrLog(ex, strSQL);
                throw ex;
            }
            return dataTable;
        }

        public static int SetData(
          string connectionString,
          string strSQL,
          OracleParameterCollection oraParms)
        {
            OracleTransaction oracleTransaction = (OracleTransaction)null;
            OracleCommand cmd = new OracleCommand(strSQL, clsOracle._cn);
            int num;
            try
            {
                clsOracle._connectionString = connectionString;
                clsOracle.ConnectionOpen(connectionString);
                oracleTransaction = clsOracle._cn.BeginTransaction();
                clsOracle.Parameters(ref cmd, ref oraParms);
                cmd.Transaction = oracleTransaction;
                num = cmd.ExecuteNonQuery();
                oracleTransaction.Commit();
                clsOracle.ConnectionClose();
            }
            catch (Exception ex)
            {
                clsLog.ErrLog(ex, strSQL, oraParms);
                oracleTransaction.Rollback();
                clsOracle.ConnectionClose();
                throw ex;
            }
            return num;
        }

        public static int SetData(string connectionString, string strSQL)
        {
            OracleTransaction oracleTransaction = (OracleTransaction)null;
            OracleCommand oracleCommand = new OracleCommand(strSQL, clsOracle._cn);
            int num;
            try
            {
                clsOracle._connectionString = connectionString;
                clsOracle.ConnectionOpen(connectionString);
                oracleTransaction = clsOracle._cn.BeginTransaction();
                oracleCommand.Transaction = oracleTransaction;
                num = oracleCommand.ExecuteNonQuery();
                oracleTransaction.Commit();
                clsOracle.ConnectionClose();
            }
            catch (Exception ex)
            {
                clsLog.ErrLog(ex, strSQL);
                oracleTransaction.Rollback();
                clsOracle.ConnectionClose();
                throw ex;
            }
            return num;
        }

        public static void Parameters(ref OracleCommand cmd, OracleParameterCollection oraParms)
        {
            try
            {
                int num = 0;
                foreach (OracleParameter oraParm in (DbParameterCollection)oraParms)
                {
                    cmd.Parameters.Add(oraParm.ParameterName, oraParm.OracleType, oraParm.Size);
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

        public static void Parameters(ref OracleCommand cmd, ref OracleParameterCollection oraParms)
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
                foreach (OracleParameter oracleParameter in (DbParameterCollection)oraParms)
                {
                    cmd.Parameters.Add(oracleParameter.ParameterName, oracleParameter.OracleType, oracleParameter.Size);
                    cmd.Parameters[oracleParameter.ParameterName].Value = oracleParameter.Value;
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
