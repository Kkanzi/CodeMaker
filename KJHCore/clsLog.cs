using System;
using System.Data.Common;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.IO;

namespace KJHCore
{
    public class clsLog
    {
        private static string _filePath = "C:\\DSINFO\\CodeMaker\\Log";
        private static string _newLine = "\r\n";

        public static string filePath
        {
            get => clsLog._filePath;
            set => clsLog._filePath = value;
        }

        private static void CreateDir(string filePath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(clsLog._filePath);
            if (!directoryInfo.Exists)
                directoryInfo.Create();
            if (File.Exists(filePath))
                return;
            using (File.CreateText(filePath))
                ;
        }

        public static void ErrLog(string msg)
        {
            string str = string.Format("{0}{1}{2}", (object)clsLog._filePath, (object)"\\", (object)("err_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt"));
            clsLog.CreateDir(str);
            File.AppendAllText(str, DateTime.Now.ToString() + clsLog._newLine);
            File.AppendAllText(str, msg + clsLog._newLine);
            File.AppendAllText(str, clsLog._newLine + clsLog._newLine);
        }

        public static void ErrLog(Exception ex)
        {
            string str = string.Format("{0}{1}{2}", (object)clsLog._filePath, (object)"\\", (object)("err_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt"));
            clsLog.CreateDir(str);
            File.AppendAllText(str, DateTime.Now.ToString() + clsLog._newLine);
            File.AppendAllText(str, ex.Message + clsLog._newLine);
            File.AppendAllText(str, ex.StackTrace + clsLog._newLine);
            File.AppendAllText(str, clsLog._newLine + clsLog._newLine);
        }

        public static void ErrLog(Exception ex, string strSQL)
        {
            string str = string.Format("{0}{1}{2}", (object)clsLog._filePath, (object)"\\", (object)("err_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt"));
            clsLog.CreateDir(str);
            File.AppendAllText(str, DateTime.Now.ToString() + clsLog._newLine);
            File.AppendAllText(str, ex.Message + clsLog._newLine);
            File.AppendAllText(str, ex.StackTrace + clsLog._newLine);
            File.AppendAllText(str, "=================================SQL Start====================================" + clsLog._newLine);
            File.AppendAllText(str, strSQL + clsLog._newLine);
            File.AppendAllText(str, "=================================SQL End======================================" + clsLog._newLine);
            File.AppendAllText(str, clsLog._newLine + clsLog._newLine);
        }

        public static void ErrLog(Exception ex, string strSQL, OracleParameterCollection oraParms)
        {
            string str1 = string.Format("{0}{1}{2}", (object)clsLog._filePath, (object)"\\", (object)("err_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt"));
            string empty = string.Empty;
            clsLog.CreateDir(str1);
            File.AppendAllText(str1, DateTime.Now.ToString() + clsLog._newLine);
            File.AppendAllText(str1, ex.Message + clsLog._newLine);
            File.AppendAllText(str1, ex.StackTrace + clsLog._newLine);
            File.AppendAllText(str1, "=================================SQL Start====================================" + clsLog._newLine);
            File.AppendAllText(str1, strSQL + clsLog._newLine);
            File.AppendAllText(str1, "=================================SQL End======================================" + clsLog._newLine);
            File.AppendAllText(str1, clsLog._newLine);
            File.AppendAllText(str1, "===========================OracleParameter Start==============================" + clsLog._newLine);
            string str2 = strSQL;
            foreach (OracleParameter oraParm in (DbParameterCollection)oraParms)
                str2 = str2.Replace(oraParm.ParameterName, "'" + oraParm.Value + "'");
            File.AppendAllText(str1, str2 + clsLog._newLine);
            File.AppendAllText(str1, "===========================OracleParameter End================================" + clsLog._newLine);
            File.AppendAllText(str1, clsLog._newLine + clsLog._newLine);
        }

        public static void ErrLog(Exception ex, string strSQL, SqlParameterCollection oraParms)
        {
            string str1 = string.Format("{0}{1}{2}", (object)clsLog._filePath, (object)"\\", (object)("err_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt"));
            string empty = string.Empty;
            clsLog.CreateDir(str1);
            File.AppendAllText(str1, DateTime.Now.ToString() + clsLog._newLine);
            File.AppendAllText(str1, ex.Message + clsLog._newLine);
            File.AppendAllText(str1, ex.StackTrace + clsLog._newLine);
            File.AppendAllText(str1, "=================================SQL Start====================================" + clsLog._newLine);
            File.AppendAllText(str1, strSQL + clsLog._newLine);
            File.AppendAllText(str1, "=================================SQL End======================================" + clsLog._newLine);
            File.AppendAllText(str1, clsLog._newLine);
            File.AppendAllText(str1, "===========================OracleParameter Start==============================" + clsLog._newLine);
            string str2 = strSQL;
            foreach (SqlParameter oraParm in (DbParameterCollection)oraParms)
                str2 = str2.Replace(oraParm.ParameterName, "'" + oraParm.Value + "'");
            File.AppendAllText(str1, str2 + clsLog._newLine);
            File.AppendAllText(str1, "===========================OracleParameter End================================" + clsLog._newLine);
            File.AppendAllText(str1, clsLog._newLine + clsLog._newLine);
        }

        public static void Log(string msg)
        {
            string str = string.Format("{0}{1}{2}", (object)clsLog._filePath, (object)"\\", (object)("log_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt"));
            clsLog.CreateDir(str);
            File.AppendAllText(str, DateTime.Now.ToString() + clsLog._newLine);
            File.AppendAllText(str, msg + clsLog._newLine);
            File.AppendAllText(str, clsLog._newLine + clsLog._newLine);
        }
    }
}
