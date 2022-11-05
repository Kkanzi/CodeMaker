using System;
using System.Data;
using System.Data.OracleClient;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace KJHCore
{
    public class CGCOMMON
    {
        private const string _Wn = "\r\n";
        private const string _Wtab1 = "    ";
        private const string _Wtab2 = "        ";
        private const string _Wtab3 = "            ";
        private const string _Wtab4 = "                ";
        private const string _Wtab5 = "                    ";
        private const string _Wtab6 = "                        ";
        private string _oracleConStr;
        private string _mssqlConStr;
        private DataSet _dsResult;
        private string _errorMessage;
        private DBKind _dsdbkind;
        private LANG _lang;
        private string _table_Catalog;
        private string _owner;
        private string _userName;
        private string _createSP_Bdiv;
        private string _createSP_Mdiv;
        private string _selectedTableNm;
        private string _savePath;
        private bool _existError;

        public string OracleConStr
        {
            get => this._oracleConStr;
            set => this._oracleConStr = value;
        }

        public string MssqlConStr
        {
            get => this._mssqlConStr;
            set => this._mssqlConStr = value;
        }

        public DBKind DBKind
        {
            get => this._dsdbkind;
            set => this._dsdbkind = value;
        }

        public LANG Lang
        {
            get => this._lang;
            set => this._lang = value;
        }

        public DataSet DSResult
        {
            get => this._dsResult;
            set => this._dsResult = value;
        }

        public string ErrorMessage
        {
            get => this._errorMessage;
            set => this._errorMessage = value;
        }

        public bool ExistError
        {
            get => this._existError;
            set => this._existError = value;
        }

        public string SelectedTableNm
        {
            get => this._selectedTableNm;
            set => this._selectedTableNm = value;
        }

        public string UserName
        {
            get => this._userName;
            set => this._userName = value;
        }

        public string CreateSP_BDiv
        {
            get => this._createSP_Bdiv;
            set => this._createSP_Bdiv = value;
        }

        public string CreateSP_MDiv
        {
            get => this._createSP_Mdiv;
            set => this._createSP_Mdiv = value;
        }

        public string SavePath
        {
            get => this._savePath;
            set => this._savePath = value;
        }

        public string Table_Catalog
        {
            get => this._table_Catalog;
            set => this._table_Catalog = value;
        }

        public string Owner
        {
            get => this._owner;
            set => this._owner = value;
        }

        public CGCOMMON()
        {
            this.OracleConStr = string.Empty;
            this.MssqlConStr = string.Empty;
            this.Table_Catalog = string.Empty;
            this.DBKind = DBKind.ORACLE;
            this.Lang = LANG.KOR;
            this.DSResult = new DataSet();
            this.ErrorMessage = string.Empty;
            this.ExistError = false;
        }

        public CGCOMMON(
          string OracleConnectionString,
          string MsqlConnectionString,
          DBKind DBkind,
          LANG inLang,
          string prefix,
          string affix,
          string DBname)
        {
            this.OracleConStr = OracleConnectionString;
            this.MssqlConStr = MsqlConnectionString;
            this.DBKind = DBkind;
            this.Lang = inLang;
            this.DSResult = new DataSet();
            this.ErrorMessage = string.Empty;
            this.ExistError = false;
            this._createSP_Bdiv = prefix;
            this._createSP_Mdiv = affix;
            this._table_Catalog = DBname;
        }

        public string GetSelectSql(string tblINm, DataTable inDt, string condition, bool boolPlsql)
        {
            string empty = string.Empty;
            StringBuilder stringBuilder1 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder2 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder3 = new StringBuilder(string.Empty);
            try
            {
                int totalWidth1 = int.Parse(inDt.Rows[0]["COLUMN_NAME_MAX_LEN"].ToString());
                int totalWidth2 = int.Parse(inDt.Rows[0]["COLUMN_NAME_MAX_LEN_PK"].ToString());
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "--" + inDt.Rows[0]["TABLE_COMMENTS"].ToString());
                stringBuilder1.Append((boolPlsql ? "        " : "    ") + "SELECT   ");
                foreach (DataRow row in (InternalDataCollectionBase)inDt.Rows)
                {
                    string str1 = string.IsNullOrEmpty(row["COLUMN_COMMENTS"].ToString()) ? "" : " -- " + row["COLUMN_COMMENTS"].ToString();
                    if (row["COLUMN_ID"].ToString() == "1")
                    {
                        stringBuilder1.AppendLine(condition + "." + row["COLUMN_NAME"].ToString().PadRight(totalWidth1, ' ') + " AS " + row["COLUMN_NAME"].ToString().PadRight(totalWidth1, ' ') + str1);
                    }
                    else
                    {
                        string str2 = row["COLUMN_ID"].ToString() == "1" ? " " : ",";
                        stringBuilder1.AppendLine((boolPlsql ? "                " : "            ") + str2 + condition + "." + row["COLUMN_NAME"].ToString().PadRight(totalWidth1, ' ') + " AS " + row["COLUMN_NAME"].ToString().PadRight(totalWidth1, ' ') + str1);
                    }
                    if (row["PK"].ToString() == "PK")
                    {
                        stringBuilder2.AppendLine((boolPlsql ? "        " : "    ") + "   AND  " + condition + "." + row["COLUMN_NAME"].ToString().PadRight(totalWidth2, ' ') + " = " + (this._dsdbkind == DBKind.MSSQL ? "@" : "") + "IN_" + row["COLUMN_NAME"].ToString());
                        if (string.IsNullOrEmpty(stringBuilder3.ToString()))
                            stringBuilder3.Append(condition + "." + row["COLUMN_NAME"].ToString());
                        else
                            stringBuilder3.Append("," + condition + "." + row["COLUMN_NAME"].ToString());
                    }
                }
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "  FROM  " + tblINm + " " + condition + (this._dsdbkind == DBKind.MSSQL ? " WITH (NOLOCK)" : ""));
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + " WHERE  1 = 1");
                if (!string.IsNullOrEmpty(stringBuilder2.ToString()))
                    stringBuilder1.Append((object)stringBuilder2);
                if (!string.IsNullOrEmpty(stringBuilder3.ToString()))
                {
                    stringBuilder1.Append((boolPlsql ? "        " : "    ") + " ORDER  BY ");
                    stringBuilder1.Append((object)stringBuilder3);
                }
                stringBuilder1.Append(";");
            }
            catch (Exception ex)
            {
                this.ExistError = true;
                string message = empty + ex.Message + Environment.NewLine;
                this.ErrorMessage = message;
                Debug.WriteLine(message);
                clsLog.ErrLog(ex, stringBuilder1.ToString());
            }
            return stringBuilder1.ToString();
        }

        public string GetSelectCheckCountSql(DataTable inDt, string tblINm, string condition)
        {
            string empty = string.Empty;
            StringBuilder stringBuilder1 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder2 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder3 = new StringBuilder(string.Empty);
            try
            {
                int.Parse(inDt.Rows[0]["COLUMN_NAME_MAX_LEN"].ToString());
                int totalWidth = int.Parse(inDt.Rows[0]["COLUMN_NAME_MAX_LEN_PK"].ToString());
                stringBuilder1.AppendLine("        /*INSERT 중복 체크*/");
                stringBuilder1.AppendLine("        SELECT  COUNT(*)");
                stringBuilder1.AppendLine("          INTO  V_CNT");
                foreach (DataRow row in (InternalDataCollectionBase)inDt.Rows)
                {
                    if (row["PK"].ToString() == "PK")
                        stringBuilder2.Append("\r\n           AND  " + condition + "." + row["COLUMN_NAME"].ToString().PadRight(totalWidth, ' ') + " = " + (this._dsdbkind == DBKind.MSSQL ? "@" : "") + "IN_" + row["COLUMN_NAME"].ToString());
                }
                stringBuilder1.AppendLine("          FROM  " + tblINm + " " + condition);
                stringBuilder1.Append("         WHERE  1 = 1");
                if (!string.IsNullOrEmpty(stringBuilder2.ToString()))
                    stringBuilder1.Append((object)stringBuilder2);
                stringBuilder1.AppendLine(";");
                stringBuilder1.AppendLine("        /*사용자 정의 오류 처리*/");
                stringBuilder1.AppendLine("        IF V_CNT > 0 THEN");
                stringBuilder1.AppendLine("            V_STEP:=  '1. Key Count Check';");
                stringBuilder1.AppendLine("            -- DSMSG30001 : 데이터 중복 또는 데이터 누락 오류");
                stringBuilder1.AppendLine("            RAISE_MSG := DF_COMMON.COMMON_MSG_SEL('DSMSG30001', NVL(IN_LANG_CD,'0'));");
                stringBuilder1.AppendLine("            RAISE RAISE_EXT;");
                stringBuilder1.AppendLine("        END IF;");
            }
            catch (Exception ex)
            {
                this.ExistError = true;
                string message = empty + ex.Message + Environment.NewLine;
                this.ErrorMessage = message;
                Debug.WriteLine(message);
                clsLog.ErrLog(ex, stringBuilder1.ToString());
            }
            return stringBuilder1.ToString();
        }

        public string GetInsertSql(string tblNm, DataTable inDt, bool boolPlsql)
        {
            string empty = string.Empty;
            StringBuilder stringBuilder1 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder2 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder3 = new StringBuilder(string.Empty);
            try
            {
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "--" + inDt.Rows[0]["TABLE_COMMENTS"].ToString());
                int num = int.Parse(inDt.Rows[0]["COLUMN_NAME_MAX_LEN"].ToString());
                foreach (DataRow row in (InternalDataCollectionBase)inDt.Rows)
                {
                    string str1 = string.IsNullOrEmpty(row["COLUMN_COMMENTS"].ToString()) ? "" : " -- " + row["COLUMN_COMMENTS"].ToString();
                    string str2 = row["COLUMN_ID"].ToString() == "1" ? " " : ",";
                    stringBuilder2.AppendLine((boolPlsql ? "            " : "        ") + (str2 + row["COLUMN_NAME"].ToString()).PadRight(num + 1, ' ') + " " + str1);
                    switch (row["COLUMN_NAME"].ToString())
                    {
                        case "CRTUSER":
                            stringBuilder3.AppendLine((boolPlsql ? "            " : "        ") + str2 + (this._dsdbkind == DBKind.MSSQL ? "@" : "") + "IN_USER_ID");
                            break;
                        case "CRTTIME":
                            stringBuilder3.AppendLine((boolPlsql ? "            " : "        ") + str2 + (this._dsdbkind == DBKind.MSSQL ? "GETDATE()" : "SYSDATE"));
                            break;
                        case "CRTDATE":
                            stringBuilder3.AppendLine((boolPlsql ? "            " : "        ") + str2 + (this._dsdbkind == DBKind.MSSQL ? "GETDATE()" : "SYSDATE"));
                            break;
                        case "UPTUSER":
                            stringBuilder3.AppendLine((boolPlsql ? "            " : "        ") + str2 + (this._dsdbkind == DBKind.MSSQL ? "@" : "") + "IN_USER_ID");
                            break;
                        case "UPTTIME":
                            stringBuilder3.AppendLine((boolPlsql ? "            " : "        ") + str2 + (this._dsdbkind == DBKind.MSSQL ? "GETDATE()" : "SYSDATE"));
                            break;
                        case "UPTDATE":
                            stringBuilder3.AppendLine((boolPlsql ? "            " : "        ") + str2 + (this._dsdbkind == DBKind.MSSQL ? "GETDATE()" : "SYSDATE"));
                            break;
                        default:
                            stringBuilder3.AppendLine((boolPlsql ? "            " : "        ") + str2 + (this._dsdbkind == DBKind.MSSQL ? "@" : "") + "IN_" + row["COLUMN_NAME"].ToString());
                            break;
                    }
                }
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "INSERT INTO " + tblNm);
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "(");
                stringBuilder1.Append(stringBuilder2.ToString());
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + ")");
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "VALUES");
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "(");
                stringBuilder1.Append(stringBuilder3.ToString());
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + ");");
            }
            catch (Exception ex)
            {
                this.ExistError = true;
                string message = empty + ex.Message + "\r\n";
                this.ErrorMessage = message;
                Debug.WriteLine(message);
                clsLog.ErrLog(ex, stringBuilder1.ToString());
            }
            return stringBuilder1.ToString();
        }

        public string GetUpdateSql(string tblNm, DataTable inDt, bool boolPlsql)
        {
            string empty = string.Empty;
            StringBuilder stringBuilder1 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder2 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder3 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder4 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder5 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder6 = new StringBuilder(string.Empty);
            try
            {
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "--" + inDt.Rows[0]["TABLE_COMMENTS"].ToString());
                int totalWidth1 = int.Parse(inDt.Rows[0]["COLUMN_NAME_MAX_LEN"].ToString());
                int totalWidth2 = int.Parse(inDt.Rows[0]["COLUMN_NAME_MAX_LEN_PK"].ToString());
                foreach (DataRow row in (InternalDataCollectionBase)inDt.Rows)
                {
                    string str1 = string.IsNullOrEmpty(row["COLUMN_COMMENTS"].ToString()) ? "" : " -- " + row["COLUMN_COMMENTS"].ToString();
                    string str2 = row["COLUMN_ID"].ToString() == row["COLUMN_ID_MAX"].ToString() ? " " : ",";
                    if (row["PK"].ToString() != "PK")
                    {
                        switch (row["COLUMN_NAME"].ToString())
                        {
                            case "CRTUSER":
                            case "CRTTIME":
                            case "CRTDATE":
                                break;
                            case "UPTUSER":
                                stringBuilder2.AppendLine((boolPlsql ? "            " : "        ") + "   ," + row["COLUMN_NAME"].ToString().PadRight(totalWidth1, ' ') + " = " + (this._dsdbkind == DBKind.MSSQL ? "@" : "") + "IN_" + "USER_ID".PadRight(totalWidth1 + 3, ' ') + str1);
                                goto case "CRTUSER";
                            case "UPTTIME":
                                stringBuilder2.AppendLine((boolPlsql ? "            " : "        ") + "   ," + row["COLUMN_NAME"].ToString().PadRight(totalWidth1, ' ') + " = " + (this._dsdbkind == DBKind.MSSQL ? "GETDATE()" : "SYSDATE  ").PadRight(totalWidth1 + (this._dsdbkind == DBKind.ORACLE ? 6 : 7), ' ') + str1);
                                goto case "CRTUSER";
                            case "UPTDATE":
                                stringBuilder2.AppendLine((boolPlsql ? "            " : "        ") + "   ," + row["COLUMN_NAME"].ToString().PadRight(totalWidth1, ' ') + " = " + (this._dsdbkind == DBKind.MSSQL ? "GETDATE()" : "SYSDATE  ").PadRight(totalWidth1 + (this._dsdbkind == DBKind.ORACLE ? 6 : 7), ' ') + str1);
                                goto case "CRTUSER";
                            default:
                                if (string.IsNullOrEmpty(stringBuilder2.ToString()))
                                {
                                    stringBuilder2.AppendLine("  " + row["COLUMN_NAME"].ToString().PadRight(totalWidth1, ' ') + " = " + (this._dsdbkind == DBKind.MSSQL ? "@" : "") + "IN_" + row["COLUMN_NAME"].ToString().PadRight(totalWidth1 + 3, ' ') + str1);
                                    goto case "CRTUSER";
                                }
                                else
                                {
                                    stringBuilder2.AppendLine((boolPlsql ? "            " : "        ") + "   ," + row["COLUMN_NAME"].ToString().PadRight(totalWidth1, ' ') + " = " + (this._dsdbkind == DBKind.MSSQL ? "@" : "") + "IN_" + row["COLUMN_NAME"].ToString().PadRight(totalWidth1 + 3, ' ') + str1);
                                    goto case "CRTUSER";
                                }
                        }
                    }
                    if (row["PK"].ToString() == "PK")
                        stringBuilder3.AppendLine((boolPlsql ? "        " : "    ") + "   AND  " + row["COLUMN_NAME"].ToString().PadRight(totalWidth2, ' ') + " = " + (this._dsdbkind == DBKind.MSSQL ? "@" : "") + "IN_" + row["COLUMN_NAME"].ToString().PadRight(totalWidth2 + 3, ' ') + str1);
                }
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "UPDATE  " + tblNm);
                stringBuilder1.Append((boolPlsql ? "        " : "    ") + "   SET");
                stringBuilder1.Append(stringBuilder2.ToString());
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + " WHERE  1 = 1");
                stringBuilder1.Append(stringBuilder3.ToString());
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + ";");
            }
            catch (Exception ex)
            {
                this.ExistError = true;
                string message = empty + ex.Message + "\r\n";
                this.ErrorMessage = message;
                Debug.WriteLine(message);
                clsLog.ErrLog(ex, stringBuilder1.ToString());
            }
            return stringBuilder1.ToString();
        }

        public string GetMergeSql(string tblNm, DataTable inDt, bool boolPlsql)
        {
            string empty = string.Empty;
            StringBuilder stringBuilder1 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder2 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder3 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder4 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder5 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder6 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder7 = new StringBuilder(string.Empty);
            try
            {
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "--" + inDt.Rows[0]["TABLE_COMMENTS"].ToString());
                int totalWidth1 = int.Parse(inDt.Rows[0]["COLUMN_NAME_MAX_LEN"].ToString());
                foreach (DataRow row in (InternalDataCollectionBase)inDt.Rows)
                {
                    string str1 = string.IsNullOrEmpty(row["COLUMN_COMMENTS"].ToString()) ? "" : " -- " + row["COLUMN_COMMENTS"].ToString();
                    string str2 = row["COLUMN_ID"].ToString() == "1" ? " " : ",";
                    if (this._dsdbkind == DBKind.ORACLE)
                    {
                        switch (row["COLUMN_NAME"].ToString())
                        {
                            case "CRTUSER":
                                stringBuilder2.AppendLine((boolPlsql ? "                    " : "                ") + str2 + "IN_" + "USER_ID".PadRight(totalWidth1, ' ') + " AS " + row["COLUMN_NAME"].ToString().PadRight(totalWidth1, ' ') + str1);
                                break;
                            case "CRTTIME":
                                stringBuilder2.AppendLine((boolPlsql ? "                    " : "                ") + str2 + "SYSDATE".PadRight(totalWidth1 + 3, ' ') + " AS " + row["COLUMN_NAME"].ToString().PadRight(totalWidth1, ' ') + str1);
                                break;
                            case "CRTDATE":
                                stringBuilder2.AppendLine((boolPlsql ? "                    " : "                ") + str2 + "SYSDATE".PadRight(totalWidth1 + 3, ' ') + " AS " + row["COLUMN_NAME"].ToString().PadRight(totalWidth1, ' ') + str1);
                                break;
                            case "UPTUSER":
                                stringBuilder2.AppendLine((boolPlsql ? "                    " : "                ") + str2 + "IN_" + "USER_ID".PadRight(totalWidth1, ' ') + " AS " + row["COLUMN_NAME"].ToString().PadRight(totalWidth1, ' ') + str1);
                                break;
                            case "UPTTIME":
                                stringBuilder2.AppendLine((boolPlsql ? "                    " : "                ") + str2 + "SYSDATE".PadRight(totalWidth1 + 3, ' ') + " AS " + row["COLUMN_NAME"].ToString().PadRight(totalWidth1, ' ') + str1);
                                break;
                            case "UPTDATE":
                                stringBuilder2.AppendLine((boolPlsql ? "                    " : "                ") + str2 + "SYSDATE".PadRight(totalWidth1 + 3, ' ') + " AS " + row["COLUMN_NAME"].ToString().PadRight(totalWidth1, ' ') + str1);
                                break;
                            default:
                                stringBuilder2.AppendLine((boolPlsql ? "                    " : "                ") + str2 + "IN_" + row["COLUMN_NAME"].ToString().PadRight(totalWidth1, ' ') + " AS " + row["COLUMN_NAME"].ToString().PadRight(totalWidth1, ' ') + str1);
                                break;
                        }
                    }
                    else if (this._dsdbkind == DBKind.MSSQL)
                    {
                        switch (row["COLUMN_NAME"].ToString())
                        {
                            case "CRTUSER":
                                stringBuilder2.AppendLine((boolPlsql ? "                    " : "                ") + str2 + "@IN_" + "USER_ID".PadRight(totalWidth1, ' ') + str1);
                                break;
                            case "CRTTIME":
                                stringBuilder2.AppendLine((boolPlsql ? "                    " : "                ") + str2 + "GETDATE()".PadRight(totalWidth1 + 4, ' ') + str1);
                                break;
                            case "CRTDATE":
                                stringBuilder2.AppendLine((boolPlsql ? "                    " : "                ") + str2 + "GETDATE()".PadRight(totalWidth1 + 4, ' ') + str1);
                                break;
                            case "UPTUSER":
                                stringBuilder2.AppendLine((boolPlsql ? "                    " : "                ") + str2 + "@IN_" + "USER_ID".PadRight(totalWidth1, ' ') + str1);
                                break;
                            case "UPTTIME":
                                stringBuilder2.AppendLine((boolPlsql ? "                    " : "                ") + str2 + "GETDATE()".PadRight(totalWidth1 + 4, ' ') + str1);
                                break;
                            case "UPTDATE":
                                stringBuilder2.AppendLine((boolPlsql ? "                    " : "                ") + str2 + "GETDATE()".PadRight(totalWidth1 + 4, ' ') + str1);
                                break;
                            default:
                                stringBuilder2.AppendLine((boolPlsql ? "                    " : "                ") + str2 + "@IN_" + row["COLUMN_NAME"].ToString().PadRight(totalWidth1, ' ') + str1);
                                break;
                        }
                    }
                    if (row["PK"].ToString() == "PK")
                    {
                        int totalWidth2 = int.Parse(row["COLUMN_NAME_MAX_LEN_PK"].ToString());
                        if (row["PK_SEQ"].ToString() == "1")
                            stringBuilder3.AppendLine((boolPlsql ? "            " : "        ") + "    A." + row["COLUMN_NAME"].ToString().PadRight(totalWidth2, ' ') + " = B." + row["COLUMN_NAME"].ToString());
                        else
                            stringBuilder3.AppendLine((boolPlsql ? "            " : "        ") + "AND A." + row["COLUMN_NAME"].ToString().PadRight(totalWidth2, ' ') + " = B." + row["COLUMN_NAME"].ToString());
                    }
                    if (row["PK"].ToString() != "PK")
                    {
                        string str3 = string.IsNullOrEmpty(stringBuilder4.ToString()) ? " " : ",";
                        switch (row["COLUMN_NAME"].ToString())
                        {
                            case "CRTUSER":
                            case "CRTTIME":
                            case "CRTDATE":
                                break;
                            default:
                                if (this._dsdbkind == DBKind.MSSQL)
                                {
                                    stringBuilder4.AppendLine((boolPlsql ? "            " : "        ") + str3 + row["COLUMN_NAME"].ToString().PadRight(totalWidth1, ' ') + " = B." + row["COLUMN_NAME"].ToString());
                                    goto case "CRTUSER";
                                }
                                else if (this._dsdbkind == DBKind.ORACLE)
                                {
                                    stringBuilder4.AppendLine((boolPlsql ? "            " : "        ") + str3 + "A." + row["COLUMN_NAME"].ToString().PadRight(totalWidth1, ' ') + " = B." + row["COLUMN_NAME"].ToString());
                                    goto case "CRTUSER";
                                }
                                else
                                    goto case "CRTUSER";
                        }
                    }
                    if (this._dsdbkind == DBKind.MSSQL)
                        stringBuilder5.AppendLine((boolPlsql ? "            " : "        ") + str2 + row["COLUMN_NAME"].ToString());
                    else if (this._dsdbkind == DBKind.ORACLE)
                        stringBuilder5.AppendLine((boolPlsql ? "            " : "        ") + str2 + "A." + row["COLUMN_NAME"].ToString());
                    stringBuilder6.AppendLine((boolPlsql ? "            " : "        ") + str2 + "B." + row["COLUMN_NAME"].ToString());
                    stringBuilder7.Append(str2 + row["COLUMN_NAME"].ToString());
                }
                if (this._dsdbkind == DBKind.MSSQL)
                    stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "MERGE " + tblNm + " AS A");
                else if (this._dsdbkind == DBKind.ORACLE)
                    stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "MERGE INTO  " + tblNm + " A");
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "USING");
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "(");
                if (this._dsdbkind == DBKind.MSSQL)
                    stringBuilder1.AppendLine((boolPlsql ? "            " : "        ") + "VALUES (");
                else if (this._dsdbkind == DBKind.ORACLE)
                    stringBuilder1.AppendLine((boolPlsql ? "            " : "        ") + "SELECT");
                stringBuilder1.Append(stringBuilder2.ToString());
                if (this._dsdbkind == DBKind.MSSQL)
                    stringBuilder1.AppendLine((boolPlsql ? "            " : "        ") + "       )");
                if (this._dsdbkind == DBKind.MSSQL)
                {
                    stringBuilder1.Append((boolPlsql ? "        " : "    ") + ") AS B");
                    stringBuilder1.Append("(");
                    stringBuilder1.Append(stringBuilder7.ToString());
                    stringBuilder1.AppendLine(")");
                }
                else if (this._dsdbkind == DBKind.ORACLE)
                {
                    stringBuilder1.AppendLine((boolPlsql ? "            " : "        ") + "  FROM  DUAL");
                    stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + ") B");
                }
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "ON");
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "(");
                stringBuilder1.Append(stringBuilder3.ToString());
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + ")");
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "WHEN MATCHED THEN");
                if (this._dsdbkind == DBKind.MSSQL)
                {
                    stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "UPDATE");
                    stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "   SET");
                }
                else
                    stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "UPDATE");
                stringBuilder1.Append(stringBuilder4.ToString());
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "WHEN NOT MATCHED THEN");
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "INSERT");
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "(");
                stringBuilder1.Append(stringBuilder5.ToString());
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + ")");
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "VALUES");
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "(");
                stringBuilder1.Append(stringBuilder6.ToString());
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + ");");
            }
            catch (Exception ex)
            {
                this.ExistError = true;
                string message = empty + ex.Message + "\r\n";
                this.ErrorMessage = message;
                Debug.WriteLine(message);
                clsLog.ErrLog(ex, stringBuilder1.ToString());
            }
            return stringBuilder1.ToString();
        }

        public string GetDeleteSql(string tblNm, DataTable inDt, bool boolPlsql)
        {
            string empty = string.Empty;
            StringBuilder stringBuilder1 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder2 = new StringBuilder(string.Empty);
            try
            {
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "--" + inDt.Rows[0]["TABLE_COMMENTS"].ToString());
                int totalWidth = int.Parse(inDt.Rows[0]["COLUMN_NAME_MAX_LEN_PK"].ToString());
                foreach (DataRow row in (InternalDataCollectionBase)inDt.Rows)
                {
                    if (row["PK"].ToString() == "PK")
                        stringBuilder2.AppendLine((boolPlsql ? "        " : "    ") + "   AND  " + row["COLUMN_NAME"].ToString().PadRight(totalWidth, ' ') + " = " + (this._dsdbkind == DBKind.MSSQL ? "@" : "") + "IN_" + row["COLUMN_NAME"].ToString());
                }
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + "DELETE  " + tblNm);
                stringBuilder1.AppendLine((boolPlsql ? "        " : "    ") + " WHERE  1 = 1");
                stringBuilder1.Append(stringBuilder2.ToString());
                stringBuilder1.Append((boolPlsql ? "        " : "    ") + ";");
            }
            catch (Exception ex)
            {
                this.ExistError = true;
                string message = empty + ex.Message + "\r\n";
                this.ErrorMessage = message;
                Debug.WriteLine(message);
                clsLog.ErrLog(ex, stringBuilder1.ToString());
            }
            return stringBuilder1.ToString();
        }

        public string GetSelectSqlP(string tblINm, DataTable inDt, string condition)
        {
            string empty1 = string.Empty;
            StringBuilder stringBuilder1 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder2 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder3 = new StringBuilder(string.Empty);
            try
            {
                int num1 = int.Parse(inDt.Rows[0]["COLUMN_NAME_MAX_LEN_PK"].ToString());
                int maxLen = int.Parse(inDt.Rows[0]["DATA_TYPE_MAX"].ToString());
                int num2 = int.Parse(inDt.Rows[0]["DATA_LEN_STR_MAX"].ToString());
                string empty2 = string.Empty;
                string empty3 = string.Empty;
                this.GetSQLGBNStr(SQLGBN.SELECT, ref empty2, ref empty3);
                if (this._dsdbkind == DBKind.ORACLE)
                    stringBuilder1.Append("PROCEDURE " + this.CreateSP_BDiv + "_" + this.CreateSP_MDiv + "_" + empty3);
                else if (this._dsdbkind == DBKind.MSSQL)
                    stringBuilder1.Append("CREATE PROCEDURE [dbo].[" + this.CreateSP_BDiv + "_" + this.CreateSP_MDiv + "_" + empty3 + "]");
                stringBuilder1.AppendLine(this.GetSPComment(inDt, SQLGBN.SELECT));
                stringBuilder1.AppendLine("(");
                foreach (DataRow row in (InternalDataCollectionBase)inDt.Rows)
                {
                    string str = string.IsNullOrEmpty(row["COLUMN_COMMENTS"].ToString()) ? "" : " -- " + row["COLUMN_COMMENTS"].ToString();
                    if (row["PK"].ToString() == "PK")
                    {
                        if (this._dsdbkind == DBKind.MSSQL)
                            stringBuilder2.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num1 + 5, "@IN_" + row["COLUMN_NAME"].ToString()) + "    " + CGCOMMON.Col_RPad(maxLen + num2, row["DATA_TYPE"].ToString() + row["DATA_LEN_STR"].ToString()) + str);
                        else if (this._dsdbkind == DBKind.ORACLE)
                            stringBuilder2.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num1 + 5, "IN_" + row["COLUMN_NAME"].ToString()) + " IN  " + CGCOMMON.Col_RPad(maxLen, row["DATA_TYPE"].ToString()) + str);
                    }
                }
                if (this._dsdbkind == DBKind.MSSQL)
                {
                    stringBuilder2.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num1 + 5, "@IN_USER_ID") + "    " + CGCOMMON.Col_RPad(maxLen + num2, "NVARCHAR(20)") + " -- 사용자 Session ID ");
                    stringBuilder2.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num1 + 5, "@IN_LANG_CD") + "    " + CGCOMMON.Col_RPad(maxLen + num2, "NVARCHAR(10)") + " -- LANG_CD ");
                }
                else if (this._dsdbkind == DBKind.ORACLE)
                {
                    stringBuilder2.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num1 + 4, "IN_USER_ID") + " IN  " + CGCOMMON.Col_RPad(maxLen, "VARCHAR2") + " -- 사용자 Session ID */");
                    stringBuilder2.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num1 + 4, "IN_LANG_CD") + " IN  " + CGCOMMON.Col_RPad(maxLen, "VARCHAR2") + " -- LANG_CD */");
                }
                stringBuilder1.Append((object)stringBuilder2);
                if (this._dsdbkind == DBKind.ORACLE)
                {
                    if (string.IsNullOrEmpty(stringBuilder2.ToString()))
                        stringBuilder1.AppendLine("    " + CGCOMMON.Col_RPad(num1 + 3, "OUT_CUR") + "  OUT " + CGCOMMON.Col_RPad(maxLen, "T_CURSOR") + "/* Return Cursor */");
                    else
                        stringBuilder1.AppendLine("    " + CGCOMMON.Col_RPad(num1 + 3, ",OUT_CUR") + "  OUT " + CGCOMMON.Col_RPad(maxLen, "T_CURSOR") + " -- Return Cursor */");
                }
                stringBuilder1.AppendLine(")");
                stringBuilder1.AppendLine("AS");
                stringBuilder1.AppendLine("BEGIN");
                if (this._dsdbkind == DBKind.ORACLE)
                    stringBuilder1.AppendLine("    OPEN OUT_CUR FOR");
                stringBuilder1.AppendLine(this.GetSelectSql(tblINm, inDt, condition, true));
                if (this._dsdbkind == DBKind.ORACLE)
                    stringBuilder1.AppendLine("END " + this.CreateSP_BDiv + "_" + this.CreateSP_MDiv + "_" + empty3 + ";");
                else
                    stringBuilder1.AppendLine("END;");
            }
            catch (Exception ex)
            {
                this.ExistError = true;
                string message = empty1 + ex.Message + Environment.NewLine;
                this.ErrorMessage = message;
                Debug.WriteLine(message);
                clsLog.ErrLog(ex, stringBuilder1.ToString());
            }
            return stringBuilder1.ToString();
        }

        public string GetInsertSqlP(string tblINm, DataTable inDt)
        {
            string empty1 = string.Empty;
            StringBuilder stringBuilder1 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder2 = new StringBuilder(string.Empty);
            try
            {
                int.Parse(inDt.Rows[0]["COLUMN_NAME_MAX_LEN_PK"].ToString());
                int maxLen = int.Parse(inDt.Rows[0]["DATA_TYPE_MAX"].ToString());
                int num1 = int.Parse(inDt.Rows[0]["DATA_LEN_STR_MAX"].ToString());
                string empty2 = string.Empty;
                string empty3 = string.Empty;
                this.GetSQLGBNStr(SQLGBN.INSERT, ref empty2, ref empty3);
                int num2 = int.Parse(inDt.Rows[0]["COLUMN_NAME_MAX_LEN"].ToString());
                if (this._dsdbkind == DBKind.ORACLE)
                    stringBuilder1.Append("PROCEDURE " + this.CreateSP_BDiv + "_" + this.CreateSP_MDiv + "_" + empty3);
                else if (this._dsdbkind == DBKind.MSSQL)
                    stringBuilder1.Append("CREATE PROCEDURE [dbo].[" + this.CreateSP_BDiv + "_" + this.CreateSP_MDiv + "_" + empty3 + "]");
                stringBuilder1.AppendLine(this.GetSPComment(inDt, SQLGBN.INSERT));
                stringBuilder1.AppendLine("(");
                foreach (DataRow row in (InternalDataCollectionBase)inDt.Rows)
                {
                    string str = string.IsNullOrEmpty(row["COLUMN_COMMENTS"].ToString()) ? "" : " -- " + row["COLUMN_COMMENTS"].ToString();
                    switch (row["COLUMN_NAME"].ToString())
                    {
                        case "CRTUSER":
                        case "CRTTIME":
                        case "CRTDATE":
                        case "UPTUSER":
                        case "UPTTIME":
                        case "UPTDATE":
                            continue;
                        default:
                            if (this._dsdbkind == DBKind.MSSQL)
                            {
                                stringBuilder2.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num2 + 5, "@IN_" + row["COLUMN_NAME"].ToString()) + "    " + CGCOMMON.Col_RPad(maxLen + num1, row["DATA_TYPE"].ToString() + row["DATA_LEN_STR"].ToString()) + str);
                                goto case "CRTUSER";
                            }
                            else if (this._dsdbkind == DBKind.ORACLE)
                            {
                                stringBuilder2.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num2 + 4, "IN_" + row["COLUMN_NAME"].ToString()) + " IN  " + CGCOMMON.Col_RPad(maxLen, row["DATA_TYPE"].ToString()) + str);
                                goto case "CRTUSER";
                            }
                            else
                                goto case "CRTUSER";
                    }
                }
                stringBuilder1.Append((object)stringBuilder2);
                if (this._dsdbkind == DBKind.MSSQL)
                {
                    stringBuilder1.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num2 + 5, "@IN_USER_ID") + "    " + CGCOMMON.Col_RPad(maxLen + num1, "NVARCHAR(20)") + " -- 사용자 Session ID ");
                    stringBuilder1.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num2 + 5, "@IN_LANG_CD") + "    " + CGCOMMON.Col_RPad(maxLen + num1, "NVARCHAR(10)") + " -- LANG_CD ");
                }
                else if (this._dsdbkind == DBKind.ORACLE)
                {
                    stringBuilder1.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num2 + 4, "IN_USER_ID") + " IN  " + CGCOMMON.Col_RPad(maxLen, "VARCHAR2") + " -- 사용자 Session ID */");
                    stringBuilder1.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num2 + 4, "IN_LANG_CD") + " IN  " + CGCOMMON.Col_RPad(maxLen, "VARCHAR2") + " -- LANG_CD */");
                }
                stringBuilder1.AppendLine(")");
                stringBuilder1.AppendLine("AS");
                stringBuilder1.AppendLine(this.GetPLSQLReturnStr(this._dsdbkind, SQLGBN.INSERT));
                stringBuilder1.AppendLine("BEGIN");
                if (this._dsdbkind == DBKind.ORACLE)
                {
                    stringBuilder1.AppendLine("    BEGIN");
                    stringBuilder1.AppendLine(this.GetSelectCheckCountSql(inDt, tblINm, "A"));
                }
                else if (this._dsdbkind == DBKind.MSSQL)
                {
                    stringBuilder1.AppendLine("    SET @V_STEP = 'INIT'");
                    stringBuilder1.AppendLine();
                    stringBuilder1.AppendLine("    BEGIN TRY");
                }
                stringBuilder1.Append(this.GetInsertSql(tblINm, inDt, true));
                if (this._dsdbkind == DBKind.ORACLE)
                {
                    stringBuilder1.AppendLine(this.GetExceptionStr(this._dsdbkind, SQLGBN.INSERT, CGCOMMON.Rerutn5ParmStr(inDt)));
                    stringBuilder1.AppendLine("    END;");
                    stringBuilder1.AppendLine(this.GetReturnResultStr(this._dsdbkind, SQLGBN.INSERT));
                    stringBuilder1.AppendLine("END " + this.CreateSP_BDiv + "_" + this.CreateSP_MDiv + "_" + empty3 + ";");
                }
                else if (this._dsdbkind == DBKind.MSSQL)
                {
                    stringBuilder1.AppendLine(this.GetExceptionStr(this._dsdbkind, SQLGBN.INSERT, CGCOMMON.Rerutn5ParmStr(inDt)));
                    stringBuilder1.AppendLine("    END TRY");
                    stringBuilder1.Append("    BEGIN CATCH");
                    stringBuilder1.AppendLine(this.GetReturnResultStr(this._dsdbkind, SQLGBN.INSERT));
                    stringBuilder1.AppendLine("    END CATCH;");
                    stringBuilder1.AppendLine("END;");
                }
            }
            catch (Exception ex)
            {
                this.ExistError = true;
                string message = empty1 + ex.Message + Environment.NewLine;
                this.ErrorMessage = message;
                Debug.WriteLine(message);
                clsLog.ErrLog(ex, stringBuilder1.ToString());
            }
            return stringBuilder1.ToString();
        }

        private static string Rerutn5ParmStr(DataTable inDt)
        {
            StringBuilder stringBuilder = new StringBuilder(string.Empty);
            foreach (DataRow row in (InternalDataCollectionBase)inDt.Rows)
            {
                if (row["PK"].ToString() == "PK" && Convert.ToInt16(row["PK_SEQ"].ToString()) < (short)6)
                    stringBuilder.Append(" ," + row["COLUMN_NAME"].ToString());
            }
            return stringBuilder.ToString();
        }

        public string GetUpdateSqlP(string tblINm, DataTable inDt)
        {
            string empty1 = string.Empty;
            StringBuilder stringBuilder1 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder2 = new StringBuilder(string.Empty);
            try
            {
                int.Parse(inDt.Rows[0]["COLUMN_NAME_MAX_LEN_PK"].ToString());
                int maxLen = int.Parse(inDt.Rows[0]["DATA_TYPE_MAX"].ToString());
                int num1 = int.Parse(inDt.Rows[0]["DATA_LEN_STR_MAX"].ToString());
                string empty2 = string.Empty;
                string empty3 = string.Empty;
                this.GetSQLGBNStr(SQLGBN.UPDATE, ref empty2, ref empty3);
                int num2 = int.Parse(inDt.Rows[0]["COLUMN_NAME_MAX_LEN"].ToString());
                if (this._dsdbkind == DBKind.ORACLE)
                    stringBuilder1.Append("PROCEDURE " + this.CreateSP_BDiv + "_" + this.CreateSP_MDiv + "_" + empty3);
                else if (this._dsdbkind == DBKind.MSSQL)
                    stringBuilder1.Append("CREATE PROCEDURE [dbo].[" + this.CreateSP_BDiv + "_" + this.CreateSP_MDiv + "_" + empty3 + "]");
                stringBuilder1.AppendLine(this.GetSPComment(inDt, SQLGBN.UPDATE));
                stringBuilder1.AppendLine("(");
                foreach (DataRow row in (InternalDataCollectionBase)inDt.Rows)
                {
                    string str = string.IsNullOrEmpty(row["COLUMN_COMMENTS"].ToString()) ? "" : " -- " + row["COLUMN_COMMENTS"].ToString();
                    switch (row["COLUMN_NAME"].ToString())
                    {
                        case "CRTUSER":
                        case "CRTTIME":
                        case "CRTDATE":
                        case "UPTUSER":
                        case "UPTTIME":
                        case "UPTDATE":
                            continue;
                        default:
                            if (this._dsdbkind == DBKind.ORACLE)
                            {
                                stringBuilder2.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num2 + 4, "IN_" + row["COLUMN_NAME"].ToString()) + " IN  " + CGCOMMON.Col_RPad(maxLen, row["DATA_TYPE"].ToString()) + str);
                                goto case "CRTUSER";
                            }
                            else if (this._dsdbkind == DBKind.MSSQL)
                            {
                                stringBuilder2.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num2 + 5, "@IN_" + row["COLUMN_NAME"].ToString()) + "    " + CGCOMMON.Col_RPad(maxLen + num1, row["DATA_TYPE"].ToString() + row["DATA_LEN_STR"].ToString()) + str);
                                goto case "CRTUSER";
                            }
                            else
                                goto case "CRTUSER";
                    }
                }
                stringBuilder1.Append((object)stringBuilder2);
                if (this._dsdbkind == DBKind.ORACLE)
                {
                    stringBuilder1.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num2 + 4, "IN_USER_ID") + " IN  " + CGCOMMON.Col_RPad(maxLen, "VARCHAR2") + " -- 사용자 Session ID */");
                    stringBuilder1.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num2 + 4, "IN_LANG_CD") + " IN  " + CGCOMMON.Col_RPad(maxLen, "VARCHAR2") + " -- LANG_CD */");
                }
                else if (this._dsdbkind == DBKind.MSSQL)
                {
                    stringBuilder1.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num2 + 4, "@IN_USER_ID") + "     " + CGCOMMON.Col_RPad(maxLen + num1, "NVARCHAR(20)") + " -- 사용자 Session ID */");
                    stringBuilder1.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num2 + 4, "@IN_LANG_CD") + "     " + CGCOMMON.Col_RPad(maxLen + num1, "NVARCHAR(10)") + " -- LANG_CD */");
                }
                stringBuilder1.AppendLine(")");
                stringBuilder1.AppendLine("AS");
                stringBuilder1.AppendLine(this.GetPLSQLReturnStr(this._dsdbkind, SQLGBN.UPDATE));
                stringBuilder1.AppendLine("BEGIN");
                if (this._dsdbkind == DBKind.ORACLE)
                    stringBuilder1.AppendLine("    BEGIN");
                else if (this._dsdbkind == DBKind.MSSQL)
                {
                    stringBuilder1.AppendLine("    SET @V_STEP = 'INIT'");
                    stringBuilder1.AppendLine();
                    stringBuilder1.AppendLine("    BEGIN TRY");
                }
                stringBuilder1.AppendLine(this.GetUpdateSql(tblINm, inDt, true));
                if (this._dsdbkind == DBKind.ORACLE)
                {
                    stringBuilder1.AppendLine(this.GetExceptionStr(this._dsdbkind, SQLGBN.UPDATE, CGCOMMON.Rerutn5ParmStr(inDt)));
                    stringBuilder1.AppendLine("    END;");
                    stringBuilder1.AppendLine(this.GetReturnResultStr(this._dsdbkind, SQLGBN.UPDATE));
                    stringBuilder1.Append("END " + this.CreateSP_BDiv + "_" + this.CreateSP_MDiv + "_" + empty3 + ";");
                }
                else if (this._dsdbkind == DBKind.MSSQL)
                {
                    stringBuilder1.AppendLine(this.GetExceptionStr(this._dsdbkind, SQLGBN.UPDATE, CGCOMMON.Rerutn5ParmStr(inDt)));
                    stringBuilder1.AppendLine("    END TRY");
                    stringBuilder1.Append("    BEGIN CATCH");
                    stringBuilder1.AppendLine(this.GetReturnResultStr(this._dsdbkind, SQLGBN.UPDATE));
                    stringBuilder1.AppendLine("    END CATCH;");
                    stringBuilder1.AppendLine("END;");
                }
            }
            catch (Exception ex)
            {
                this.ExistError = true;
                string message = empty1 + ex.Message + Environment.NewLine;
                this.ErrorMessage = message;
                Debug.WriteLine(message);
                clsLog.ErrLog(ex, stringBuilder1.ToString());
            }
            return stringBuilder1.ToString();
        }

        public string GetDeleteSqlP(string tblINm, DataTable inDt)
        {
            string empty1 = string.Empty;
            StringBuilder stringBuilder1 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder2 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder3 = new StringBuilder(string.Empty);
            try
            {
                int num1 = int.Parse(inDt.Rows[0]["COLUMN_NAME_MAX_LEN_PK"].ToString());
                int maxLen = int.Parse(inDt.Rows[0]["DATA_TYPE_MAX"].ToString());
                int num2 = int.Parse(inDt.Rows[0]["DATA_LEN_STR_MAX"].ToString());
                string empty2 = string.Empty;
                string empty3 = string.Empty;
                this.GetSQLGBNStr(SQLGBN.DELETE, ref empty2, ref empty3);
                if (this._dsdbkind == DBKind.ORACLE)
                    stringBuilder1.Append("PROCEDURE " + this.CreateSP_BDiv + "_" + this.CreateSP_MDiv + "_" + empty3);
                else if (this._dsdbkind == DBKind.MSSQL)
                    stringBuilder1.Append("CREATE PROCEDURE [dbo].[" + this.CreateSP_BDiv + "_" + this.CreateSP_MDiv + "_" + empty3 + "]");
                stringBuilder1.AppendLine(this.GetSPComment(inDt, SQLGBN.DELETE));
                stringBuilder1.AppendLine("(");
                foreach (DataRow row in (InternalDataCollectionBase)inDt.Rows)
                {
                    string str = string.IsNullOrEmpty(row["COLUMN_COMMENTS"].ToString()) ? "" : " -- " + row["COLUMN_COMMENTS"].ToString();
                    if (row["PK"].ToString() == "PK")
                    {
                        if (this._dsdbkind == DBKind.ORACLE)
                            stringBuilder2.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num1 + 4, "IN_" + row["COLUMN_NAME"].ToString()) + " IN  " + CGCOMMON.Col_RPad(maxLen, row["DATA_TYPE"].ToString()) + str);
                        else if (this._dsdbkind == DBKind.MSSQL)
                            stringBuilder2.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num1 + 5, "@IN_" + row["COLUMN_NAME"].ToString()) + "    " + CGCOMMON.Col_RPad(maxLen + num2, row["DATA_TYPE"].ToString() + row["DATA_LEN_STR"].ToString()) + str);
                    }
                }
                stringBuilder1.Append((object)stringBuilder2);
                if (this._dsdbkind == DBKind.ORACLE)
                {
                    stringBuilder1.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num1 + 4, "IN_USER_ID") + " IN  " + CGCOMMON.Col_RPad(maxLen, "VARCHAR2") + " -- 사용자 Session ID */");
                    stringBuilder1.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num1 + 4, "IN_LANG_CD") + " IN  " + CGCOMMON.Col_RPad(maxLen, "VARCHAR2") + " -- LANG_CD */");
                }
                else if (this._dsdbkind == DBKind.MSSQL)
                {
                    stringBuilder1.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num1 + 5, "@IN_USER_ID") + "    " + CGCOMMON.Col_RPad(maxLen + num2, "NVARCHAR(10)") + " -- 사용자 Session ID */");
                    stringBuilder1.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num1 + 5, "@IN_LANG_CD") + "    " + CGCOMMON.Col_RPad(maxLen + num2, "NVARCHAR(20)") + " -- LANG_CD */");
                }
                stringBuilder1.AppendLine(")");
                stringBuilder1.AppendLine("AS");
                stringBuilder1.AppendLine(this.GetPLSQLReturnStr(this._dsdbkind, SQLGBN.DELETE));
                stringBuilder1.AppendLine("BEGIN");
                if (this._dsdbkind == DBKind.ORACLE)
                    stringBuilder1.AppendLine("    BEGIN");
                else if (this._dsdbkind == DBKind.MSSQL)
                {
                    stringBuilder1.AppendLine("    SET @V_STEP = 'INIT'");
                    stringBuilder1.AppendLine();
                    stringBuilder1.AppendLine("    BEGIN TRY");
                }
                stringBuilder1.AppendLine(this.GetDeleteSql(tblINm, inDt, true));
                if (this._dsdbkind == DBKind.ORACLE)
                {
                    stringBuilder1.AppendLine(this.GetExceptionStr(this._dsdbkind, SQLGBN.DELETE, CGCOMMON.Rerutn5ParmStr(inDt)));
                    stringBuilder1.AppendLine("    END;");
                    stringBuilder1.AppendLine(this.GetReturnResultStr(this._dsdbkind, SQLGBN.DELETE));
                    stringBuilder1.AppendLine("END " + this.CreateSP_BDiv + "_" + this.CreateSP_MDiv + "_" + empty3 + ";");
                }
                else if (this._dsdbkind == DBKind.MSSQL)
                {
                    stringBuilder1.AppendLine(this.GetExceptionStr(this._dsdbkind, SQLGBN.DELETE, CGCOMMON.Rerutn5ParmStr(inDt)));
                    stringBuilder1.AppendLine("    END TRY");
                    stringBuilder1.Append("    BEGIN CATCH");
                    stringBuilder1.AppendLine(this.GetReturnResultStr(this._dsdbkind, SQLGBN.DELETE));
                    stringBuilder1.AppendLine("    END CATCH;");
                    stringBuilder1.AppendLine("END;");
                }
            }
            catch (Exception ex)
            {
                this.ExistError = true;
                string message = empty1 + ex.Message + Environment.NewLine;
                this.ErrorMessage = message;
                Debug.WriteLine(message);
                clsLog.ErrLog(ex, stringBuilder1.ToString());
            }
            return stringBuilder1.ToString();
        }

        public string GetMergeSqlP(string tblINm, DataTable inDt)
        {
            string empty1 = string.Empty;
            StringBuilder stringBuilder1 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder2 = new StringBuilder(string.Empty);
            StringBuilder stringBuilder3 = new StringBuilder(string.Empty);
            try
            {
                int.Parse(inDt.Rows[0]["COLUMN_NAME_MAX_LEN_PK"].ToString());
                int maxLen = int.Parse(inDt.Rows[0]["DATA_TYPE_MAX"].ToString());
                int num1 = int.Parse(inDt.Rows[0]["DATA_LEN_STR_MAX"].ToString());
                string empty2 = string.Empty;
                string empty3 = string.Empty;
                this.GetSQLGBNStr(SQLGBN.MERGE, ref empty2, ref empty3);
                int num2 = int.Parse(inDt.Rows[0]["COLUMN_NAME_MAX_LEN"].ToString());
                if (this._dsdbkind == DBKind.ORACLE)
                    stringBuilder1.Append("PROCEDURE " + this.CreateSP_BDiv + "_" + this.CreateSP_MDiv + "_" + empty3);
                else if (this._dsdbkind == DBKind.MSSQL)
                    stringBuilder1.Append("CREATE PROCEDURE [dbo].[" + this.CreateSP_BDiv + "_" + this.CreateSP_MDiv + "_" + empty3 + "]");
                stringBuilder1.AppendLine(this.GetSPComment(inDt, SQLGBN.MERGE));
                stringBuilder1.AppendLine("(");
                foreach (DataRow row in (InternalDataCollectionBase)inDt.Rows)
                {
                    string str = string.IsNullOrEmpty(row["COLUMN_COMMENTS"].ToString()) ? "" : " -- " + row["COLUMN_COMMENTS"].ToString();
                    switch (row["COLUMN_NAME"].ToString())
                    {
                        case "CRTUSER":
                        case "CRTTIME":
                        case "CRTDATE":
                        case "UPTUSER":
                        case "UPTTIME":
                        case "UPTDATE":
                            continue;
                        default:
                            if (this._dsdbkind == DBKind.ORACLE)
                            {
                                stringBuilder2.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num2 + 4, "IN_" + row["COLUMN_NAME"].ToString()) + " IN  " + CGCOMMON.Col_RPad(maxLen, row["DATA_TYPE"].ToString()) + str);
                                goto case "CRTUSER";
                            }
                            else if (this._dsdbkind == DBKind.MSSQL)
                            {
                                stringBuilder2.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num2 + 5, "@IN_" + row["COLUMN_NAME"].ToString()) + "    " + CGCOMMON.Col_RPad(maxLen + num1, row["DATA_TYPE"].ToString() + row["DATA_LEN_STR"].ToString()) + str);
                                goto case "CRTUSER";
                            }
                            else
                                goto case "CRTUSER";
                    }
                }
                stringBuilder1.Append((object)stringBuilder2);
                if (this._dsdbkind == DBKind.ORACLE)
                {
                    stringBuilder1.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num2 + 4, "IN_USER_ID") + " IN  " + CGCOMMON.Col_RPad(maxLen, "VARCHAR2") + " -- 사용자 Session ID */");
                    stringBuilder1.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num2 + 4, "IN_LANG_CD") + " IN  " + CGCOMMON.Col_RPad(maxLen, "VARCHAR2") + " -- LANG_CD */");
                }
                else if (this._dsdbkind == DBKind.MSSQL)
                {
                    stringBuilder1.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num2 + 5, "@IN_USER_ID") + "    " + CGCOMMON.Col_RPad(maxLen + num1, "NVARCHAR(10)") + " -- 사용자 Session ID */");
                    stringBuilder1.AppendLine("    " + (string.IsNullOrEmpty(stringBuilder2.ToString()) ? " " : ",") + CGCOMMON.Col_RPad(num2 + 5, "@IN_LANG_CD") + "    " + CGCOMMON.Col_RPad(maxLen + num1, "NVARCHAR(20)") + " -- LANG_CD */");
                }
                stringBuilder1.AppendLine(")");
                stringBuilder1.AppendLine("AS");
                stringBuilder1.AppendLine(this.GetPLSQLReturnStr(this._dsdbkind, SQLGBN.MERGE));
                stringBuilder1.AppendLine("BEGIN");
                if (this._dsdbkind == DBKind.ORACLE)
                    stringBuilder1.AppendLine("    BEGIN");
                else if (this._dsdbkind == DBKind.MSSQL)
                {
                    stringBuilder1.AppendLine("    SET @V_STEP = 'INIT'");
                    stringBuilder1.AppendLine();
                    stringBuilder1.AppendLine("    BEGIN TRY");
                }
                stringBuilder1.AppendLine(this.GetMergeSql(tblINm, inDt, true));
                if (this._dsdbkind == DBKind.ORACLE)
                {
                    stringBuilder1.AppendLine(this.GetExceptionStr(this._dsdbkind, SQLGBN.MERGE, CGCOMMON.Rerutn5ParmStr(inDt)));
                    stringBuilder1.AppendLine("    END;");
                    stringBuilder1.AppendLine(this.GetReturnResultStr(this._dsdbkind, SQLGBN.MERGE));
                    stringBuilder1.Append("END " + this.CreateSP_BDiv + "_" + this.CreateSP_MDiv + "_" + empty3 + ";");
                }
                else if (this._dsdbkind == DBKind.MSSQL)
                {
                    stringBuilder1.AppendLine(this.GetExceptionStr(this._dsdbkind, SQLGBN.MERGE, CGCOMMON.Rerutn5ParmStr(inDt)));
                    stringBuilder1.AppendLine("    END TRY");
                    stringBuilder1.Append("    BEGIN CATCH");
                    stringBuilder1.AppendLine(this.GetReturnResultStr(this._dsdbkind, SQLGBN.MERGE));
                    stringBuilder1.AppendLine("    END CATCH;");
                    stringBuilder1.AppendLine("END;");
                }
            }
            catch (Exception ex)
            {
                this.ExistError = true;
                string message = empty1 + ex.Message + Environment.NewLine;
                this.ErrorMessage = message;
                Debug.WriteLine(message);
                clsLog.ErrLog(ex, stringBuilder1.ToString());
            }
            return stringBuilder1.ToString();
        }

        private static string Col_RPad(int maxLen, string strRpad)
        {
            string empty = string.Empty;
            string str = strRpad;
            if (strRpad.Length < 11)
                str = strRpad.PadRight(11, ' ');
            return str.PadRight(maxLen, ' ');
        }

        public DataTable GetDBTableList(DBKind GBN, string strTabNm, string strTabDesc)
        {
            string empty = string.Empty;
            string strSQL = string.Empty;
            DataTable dbTableList = new DataTable();
            try
            {
                this.DSResult.Clear();
                if (GBN == DBKind.ORACLE)
                {
                    strSQL += " SELECT   A.*,B.COMMENTS AS TABLE_COMMENT FROM USER_TABLES A  ";
                    strSQL += " LEFT OUTER JOIN USER_TAB_COMMENTS B";
                    strSQL += " ON  A.TABLE_NAME = B.TABLE_NAME";
                    strSQL += " WHERE  1 = 1";
                    if (!string.IsNullOrEmpty(strTabNm))
                        strSQL = strSQL + " AND UPPER(A.TABLE_NAME) LIKE '%'||UPPER('" + strTabNm + "')||'%'";
                    if (!string.IsNullOrEmpty(strTabDesc))
                        strSQL = strSQL + " AND UPPER(B.COMMENTS) LIKE '%'||'" + strTabDesc + "'||'%'";
                    strSQL += " ORDER BY A.TABLE_NAME";
                    Debug.WriteLine("List Select Done!");
                    dbTableList = clsOracle.GetDataTable(this._oracleConStr, strSQL);
                }
                else
                {
                    strSQL += "  WITH TAS_ROWCNT";
                    strSQL += "  AS ";
                    strSQL += "  (";
                    strSQL += "      SELECT   o.name AS TABLE_NAME,";
                    strSQL += "               i.rows AS NUM_ROWS";
                    strSQL += "      FROM     sysindexes i";
                    strSQL += "               INNER JOIN sysobjects o";
                    strSQL += "               ON       i.id = o.id";
                    strSQL += "      WHERE    i.indid       < 2";
                    strSQL += "      AND      o.xtype       = 'U'";
                    strSQL += "  )";
                    strSQL += "   SELECT * FROM (";
                    strSQL += "     SELECT  A.* ,CAST(B.value AS NVARCHAR(200)) AS TABLE_COMMENT,";
                    strSQL += "             ISNULL((SELECT NUM_ROWS FROM TAS_ROWCNT WHERE TABLE_NAME = A.TABLE_NAME),0) AS NUM_ROWS";
                    strSQL += "     FROM    information_schema.tables A OUTER Apply ::FN_LISTEXTENDEDPROPERTY (NULL, 'SCHEMA', A.TABLE_SCHEMA, 'TABLE', A.TABLE_NAME, DEFAULT, DEFAULT) B";
                    strSQL = strSQL + "     WHERE   A.TABLE_CATALOG =   '" + this._table_Catalog + "'";
                    strSQL += "     AND     A.TABLE_TYPE = 'BASE TABLE'";
                    if (!string.IsNullOrEmpty(strTabNm))
                        strSQL = strSQL + "   AND UPPER(TABLE_NAME) LIKE '%'+UPPER('" + strTabNm + "')+'%'";
                    strSQL += "   ) X";
                    strSQL += "   WHERE 1 = 1";
                    if (!string.IsNullOrEmpty(strTabDesc))
                        strSQL = strSQL + " AND UPPER(X.TABLE_COMMENT) LIKE '%'+'" + strTabDesc + "'+'%'";
                    strSQL += "  ORDER BY     TABLE_NAME ";
                    Debug.WriteLine("List Select Done!");
                    dbTableList = clsMsSql.GetDataTable(this._mssqlConStr, strSQL);
                }
            }
            catch (Exception ex)
            {
                this.ExistError = true;
                string message = empty + ex.Message + "\r\n";
                this.ErrorMessage = message;
                Debug.WriteLine(message);
                clsLog.ErrLog(ex, strSQL);
            }
            return dbTableList;
        }

        public DataTable GetColumnInfoOracle(string tblENm)
        {
            string empty = string.Empty;
            string strSQL = string.Empty;
            DataTable columnInfoOracle = new DataTable();
            try
            {
                this.DSResult.Clear();
                strSQL += "\r\n  SELECT \tX.*,  ";
                strSQL += "\r\n  \t\t\t\tCASE WHEN X.PK = 'PK' THEN MAX(LENGTH(X.COLUMN_NAME)) OVER(PARTITION BY PK) ELSE 0 END AS COLUMN_NAME_MAX_LEN_PK,\t";
                strSQL += "\r\n  \t\t\t\tCASE WHEN X.PK = 'PK' THEN ROW_NUMBER() OVER(ORDER BY X.COLUMN_ID) ELSE NULL END AS PK_SEQ,";
                strSQL += "\r\n                 MAX(LENGTH(X.DATA_TYPE)) OVER() AS DATA_TYPE_MAX,";
                strSQL += "\r\n                 MAX(LENGTH(X.DATA_LEN_STR)) OVER() AS DATA_LEN_STR_MAX";
                strSQL += "\r\n    FROM ";
                strSQL += "\r\n    (";
                strSQL += "\r\n  SELECT   T.TABLE_NAME,";
                strSQL += "\r\n           TC.COMMENTS AS TABLE_COMMENTS,";
                strSQL += "\r\n           C.COLUMN_NAME,";
                strSQL += "\r\n           LENGTH(C.COLUMN_NAME) AS COLUMN_NAME_LEN,";
                strSQL += "\r\n           MAX(LENGTH(C.COLUMN_NAME)) OVER() AS COLUMN_NAME_MAX_LEN,";
                strSQL += "\r\n           MAX(COLUMN_ID) OVER() AS COLUMN_ID_MAX,";
                strSQL += "\r\n           CC.COMMENTS AS COLUMN_COMMENTS,";
                strSQL += "\r\n           C.COLUMN_ID,";
                strSQL += "\r\n           C.DATA_TYPE,";
                strSQL += "\r\n           C.DATA_LENGTH,";
                strSQL += "\r\n           C.DATA_PRECISION,";
                strSQL += "\r\n           C.DATA_SCALE,";
                strSQL += "\r\n           C.NULLABLE,";
                strSQL += "\r\n           CASE WHEN ";
                strSQL += "\r\n           (";
                strSQL += "\r\n             SELECT COUNT(*) FROM USER_CONSTRAINTS P ,USER_CONS_COLUMNS PC";
                strSQL = strSQL + "\r\n             WHERE UPPER(P.OWNER) = UPPER('" + this._owner + "')";
                strSQL += "\r\n             AND P.OWNER = PC.OWNER ";
                strSQL += "\r\n             AND P.TABLE_NAME = PC.TABLE_NAME";
                strSQL += "\r\n             AND P.CONSTRAINT_NAME = PC.CONSTRAINT_NAME";
                strSQL += "\r\n             AND P.CONSTRAINT_TYPE = 'P'";
                strSQL += "\r\n             AND T.TABLE_NAME = P.TABLE_NAME ";
                strSQL += "\r\n             AND C.COLUMN_NAME = PC.COLUMN_NAME";
                strSQL += "\r\n           ) > 0 THEN 'PK' ELSE NULL END AS PK,";
                strSQL += "\r\n             CASE WHEN UPPER(C.DATA_TYPE) LIKE '%CHAR%' THEN '('||TO_CHAR(C.CHAR_COL_DECL_LENGTH)||')'";
                strSQL += "\r\n                  WHEN UPPER(C.DATA_TYPE) LIKE '%INT%'  THEN '' ";
                strSQL += "\r\n                  WHEN UPPER(C.DATA_TYPE) LIKE '%DATE%' THEN '' ";
                strSQL += "\r\n                  WHEN UPPER(C.DATA_TYPE) LIKE '%TIME%' THEN '' ";
                strSQL += "\r\n                  WHEN UPPER(C.DATA_TYPE) LIKE '%TEXT%' THEN '' ";
                strSQL += "\r\n                  WHEN UPPER(C.DATA_TYPE) IN('DECIMAL','NUMBER') THEN '('|| TO_CHAR(C.DATA_PRECISION) ||','||TO_CHAR(C.DATA_SCALE)||')'";
                strSQL += "\r\n                  END AS DATA_LEN_STR";
                strSQL += "\r\n  FROM     USER_TABLES T ,";
                strSQL += "\r\n           USER_TAB_COLS C ,";
                strSQL += "\r\n           USER_TAB_COMMENTS TC ,";
                strSQL += "\r\n           USER_COL_COMMENTS CC";
                strSQL += "\r\n  WHERE    T.TABLE_NAME  = C.TABLE_NAME";
                strSQL += "\r\n  AND      T.TABLE_NAME  = TC.TABLE_NAME";
                strSQL += "\r\n  AND      T.TABLE_NAME  = CC.TABLE_NAME";
                strSQL += "\r\n  AND      C.COLUMN_NAME = CC.COLUMN_NAME";
                strSQL = strSQL + "\r\n  AND      T.TABLE_NAME  ='" + tblENm + "'";
                strSQL += "\r\n  ) X";
                strSQL += "\r\n  ORDER BY X.TABLE_NAME ,";
                strSQL += "\r\n           X.COLUMN_ID";
                columnInfoOracle = clsOracle.GetDataTable(this._oracleConStr, strSQL);
                Debug.WriteLine(tblENm + " Select Done!");
            }
            catch (Exception ex)
            {
                this.ExistError = true;
                string message = empty + ex.Message + "\r\n";
                this.ErrorMessage = message;
                Debug.WriteLine(message);
                clsLog.ErrLog(ex, strSQL);
            }
            return columnInfoOracle;
        }

        public DataTable GetColumnInfoMSSQL(string tblENm)
        {
            string empty = string.Empty;
            string strSQL = string.Empty;
            DataTable columnInfoMssql = new DataTable();
            try
            {
                this.DSResult.Clear();
                strSQL += "\r\n  WITH TBL AS";
                strSQL += "\r\n  (   SELECT  A.* ,";
                strSQL += "\r\n              B.value AS TABLE_COMMENTS";
                strSQL += "\r\n      FROM    information_schema.tables A OUTER Apply ::FN_LISTEXTENDEDPROPERTY (NULL, 'SCHEMA', A.TABLE_SCHEMA, 'TABLE', A.TABLE_NAME, DEFAULT, DEFAULT) B";
                strSQL = strSQL + "\r\n      WHERE   A.TABLE_CATALOG =  '" + this._table_Catalog + "' ";
                strSQL = strSQL + "\r\n      AND     A.TABLE_NAME    ='" + tblENm + "'";
                strSQL += "\r\n  )";
                strSQL += "\r\n  , COLS AS";
                strSQL += "\r\n  ( SELECT    A.* ,";
                strSQL += "\r\n              B.value AS COLUMN_COMMENTS";
                strSQL += "\r\n      FROM    information_schema.columns A OUTER Apply ::FN_LISTEXTENDEDPROPERTY(NULL, 'SCHEMA', A.TABLE_SCHEMA, 'TABLE', A.TABLE_NAME, 'COLUMN', A.COLUMN_NAME) B";
                strSQL = strSQL + "\r\n      WHERE   A.TABLE_CATALOG =  '" + this._table_Catalog + "' ";
                strSQL = strSQL + "\r\n      AND     A.TABLE_NAME     ='" + tblENm + "'";
                strSQL += "\r\n  )";
                strSQL += "\r\n  SELECT  X.*,";
                strSQL += "\r\n          CASE WHEN X.PK = 'PK' THEN MAX(LEN(X.COLUMN_NAME)) OVER(PARTITION BY PK) ELSE 0 END AS COLUMN_NAME_MAX_LEN_PK\t,";
                strSQL += "\r\n          CASE WHEN X.PK = 'PK' THEN ROW_NUMBER() OVER(ORDER BY X.COLUMN_ID) ELSE NULL END AS PK_SEQ,";
                strSQL += "\r\n          MAX(LEN(X.DATA_TYPE)) OVER() AS DATA_TYPE_MAX,";
                strSQL += "\r\n          MAX(LEN(X.DATA_LEN_STR)) OVER() AS DATA_LEN_STR_MAX";
                strSQL += "\r\n  FROM ";
                strSQL += "\r\n  (";
                strSQL += "\r\n      SELECT DISTINCT";
                strSQL += "\r\n             T.TABLE_SCHEMA, ";
                strSQL += "\r\n             T.TABLE_CATALOG,";
                strSQL += "\r\n             T.TABLE_NAME,";
                strSQL += "\r\n             T.TABLE_COMMENTS ,";
                strSQL += "\r\n             C.COLUMN_NAME,";
                strSQL += "\r\n             LEN(C.COLUMN_NAME)             AS COLUMN_NAME_LEN ,";
                strSQL += "\r\n             MAX(LEN(C.COLUMN_NAME)) OVER() AS COLUMN_NAME_MAX_LEN,";
                strSQL += "\r\n             MAX(C.ORDINAL_POSITION) OVER() AS COLUMN_ID_MAX,";
                strSQL += "\r\n             C.COLUMN_COMMENTS,";
                strSQL += "\r\n             C.ORDINAL_POSITION         AS COLUMN_ID,";
                strSQL += "\r\n             UPPER(C.DATA_TYPE)                AS DATA_TYPE,";
                strSQL += "\r\n             C.CHARACTER_MAXIMUM_LENGTH AS DATA_LENGTH,";
                strSQL += "\r\n             C.NUMERIC_PRECISION        AS DATA_PRECISION,";
                strSQL += "\r\n             C.NUMERIC_SCALE            AS DATA_SCALE,";
                strSQL += "\r\n             CASE WHEN C.IS_NULLABLE = 'YES' THEN 'Y' ELSE 'N'END AS NULLABLE,";
                strSQL += "\r\n             CASE WHEN P.CONSTRAINT_NAME > ' ' THEN 'PK' ELSE NULL END AS PK,";
                strSQL += "\r\n             CASE WHEN UPPER(C.DATA_TYPE) LIKE '%CHAR%' THEN '('+CAST(C.CHARACTER_MAXIMUM_LENGTH AS VARCHAR)+')'";
                strSQL += "\r\n                  WHEN UPPER(C.DATA_TYPE) LIKE '%INT%'  THEN '' ";
                strSQL += "\r\n                  WHEN UPPER(C.DATA_TYPE) LIKE '%DATE%' THEN '' ";
                strSQL += "\r\n                  WHEN UPPER(C.DATA_TYPE) LIKE '%TIME%' THEN '' ";
                strSQL += "\r\n                  WHEN UPPER(C.DATA_TYPE) LIKE '%TEXT%' THEN '' ";
                strSQL += "\r\n                  WHEN UPPER(C.DATA_TYPE) IN('DECIMAL','NUMERIC') THEN '('+ CAST(C.NUMERIC_PRECISION AS VARCHAR) +','+CAST(C.NUMERIC_SCALE AS VARCHAR)+')'";
                strSQL += "\r\n                  END AS DATA_LEN_STR";
                strSQL += "\r\n      FROM   TBL T";
                strSQL += "\r\n      LEFT OUTER JOIN COLS C";
                strSQL += "\r\n      ON     T.TABLE_CATALOG = C.TABLE_CATALOG";
                strSQL += "\r\n      AND    T.TABLE_NAME    = C.TABLE_NAME";
                strSQL += "\r\n      LEFT OUTER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE P";
                strSQL += "\r\n      ON     T.TABLE_CATALOG = P.TABLE_CATALOG";
                strSQL += "\r\n      AND    T.TABLE_NAME    = P.TABLE_NAME";
                strSQL += "\r\n      AND    C.COLUMN_NAME   = P.COLUMN_NAME";
                strSQL += "\r\n  ) X ";
                strSQL += "\r\n  ORDER BY X.TABLE_NAME,X.COLUMN_ID ";
                columnInfoMssql = clsMsSql.GetDataTable(this._mssqlConStr, strSQL);
                Debug.WriteLine(tblENm + " Select Done!");
            }
            catch (Exception ex)
            {
                this.ExistError = true;
                string message = empty + ex.Message + "\r\n";
                this.ErrorMessage = message;
                Debug.WriteLine(message);
                clsLog.ErrLog(ex, strSQL);
            }
            return columnInfoMssql;
        }

        public DataTable GetTableSampleData(
          DBKind dsDbkind,
          string tblENm,
          string strSampleRowCnt)
        {
            string empty = string.Empty;
            string strSQL = string.Empty;
            DataTable tableSampleData = new DataTable();
            try
            {
                this.DSResult.Clear();
                string str = strSampleRowCnt;
                try
                {
                    if (string.IsNullOrEmpty(str))
                        str = "10";
                    int int16 = (int)Convert.ToInt16(str);
                }
                catch
                {
                    str = "10";
                }
                if (dsDbkind == DBKind.MSSQL)
                {
                    strSQL = strSQL + "\r\n  SELECT TOP " + str + " * FROM " + tblENm;
                    tableSampleData = clsMsSql.GetDataTable(this._mssqlConStr, strSQL);
                    Debug.WriteLine(tblENm + " Select Done!");
                }
                else
                {
                    strSQL = strSQL + "\r\n  SELECT * FROM " + tblENm + " WHERE ROWNUM < " + Convert.ToString((int)Convert.ToInt16(str) + 1);
                    tableSampleData = clsOracle.GetDataTable(this._oracleConStr, strSQL);
                    Debug.WriteLine(tblENm + " Select Done!");
                }
            }
            catch (Exception ex)
            {
                this.ExistError = true;
                string message = empty + ex.Message + "\r\n";
                this.ErrorMessage = message;
                Debug.WriteLine(message);
                clsLog.ErrLog(ex, strSQL);
            }
            return tableSampleData;
        }

        public DataTable GetIndexInfo(DBKind dsDbkind, string tblENm)
        {
            string empty = string.Empty;
            string strSQL = string.Empty;
            DataTable indexInfo = new DataTable();
            try
            {
                this.DSResult.Clear();
                if (dsDbkind == DBKind.MSSQL)
                {
                    strSQL += "\r\n  SELECT I.NAME       AS INDEX_NAME,";
                    strSQL += "\r\n         I.TYPE_DESC  AS INDEX_TYPE ,";
                    strSQL += "\r\n         S.NAME       AS FILES,";
                    strSQL = strSQL + "\r\n         '" + tblENm + "' AS TABLE_NAME";
                    strSQL += "\r\n  FROM   SYS.TABLES T";
                    strSQL += "\r\n         LEFT OUTER JOIN SYS.INDEXES I ON T.OBJECT_ID = I.OBJECT_ID";
                    strSQL += "\r\n         LEFT OUTER JOIN SYS.DATA_SPACES S ON S.DATA_SPACE_ID = I.DATA_SPACE_ID";
                    strSQL += "\r\n  WHERE  1=1";
                    strSQL = strSQL + "\r\n  AND    T.NAME=  '" + tblENm + "'";
                    indexInfo = clsMsSql.GetDataTable(this._mssqlConStr, strSQL);
                    Debug.WriteLine(tblENm + " Select Done!");
                }
                else
                {
                    strSQL += "\r\n  SELECT   INDEX_NAME,UNIQUENESS AS INDEX_TYPE, TABLESPACE_NAME AS FILES , A.TABLE_NAME";
                    strSQL += "\r\n  FROM     USER_INDEXES A ";
                    strSQL += "\r\n  WHERE    INDEX_TYPE  = 'NORMAL'";
                    strSQL = strSQL + "\r\n  AND      UPPER(TABLE_OWNER) = UPPER('" + this._owner + "')";
                    strSQL = strSQL + "\r\n  AND      TABLE_NAME = '" + tblENm + "'";
                    strSQL += "\r\n  ORDER BY INDEX_NAME";
                    indexInfo = clsOracle.GetDataTable(this._oracleConStr, strSQL);
                    Debug.WriteLine(tblENm + " Select Done!");
                }
            }
            catch (Exception ex)
            {
                this.ExistError = true;
                string message = empty + ex.Message + "\r\n";
                this.ErrorMessage = message;
                Debug.WriteLine(message);
                clsLog.ErrLog(ex, strSQL);
            }
            return indexInfo;
        }

        public DataTable GetIndexConInfo(DBKind dsDbkind, string tblENm, string idxNm)
        {
            string empty = string.Empty;
            string strSQL = string.Empty;
            DataTable indexConInfo = new DataTable();
            try
            {
                this.DSResult.Clear();
                if (dsDbkind == DBKind.MSSQL)
                {
                    strSQL += "\r\n  WITH COLS AS";
                    strSQL += "\r\n  ( SELECT    A.* ,";
                    strSQL += "\r\n              B.value AS COLUMN_COMMENTS";
                    strSQL += "\r\n      FROM    information_schema.columns A OUTER Apply ::FN_LISTEXTENDEDPROPERTY(NULL, 'SCHEMA', A.TABLE_SCHEMA, 'TABLE', A.TABLE_NAME, 'COLUMN', A.COLUMN_NAME) B";
                    strSQL = strSQL + "\r\n      WHERE   A.TABLE_CATALOG =   '" + this._table_Catalog + "' ";
                    strSQL = strSQL + "\r\n      AND     A.TABLE_NAME     =  '" + tblENm + "'";
                    strSQL += "\r\n  )";
                    strSQL += "\r\n   SELECT ic.index_column_id as SEQ  , c.name as COLUMN_NAME,";
                    strSQL += "\r\n               cc.COLUMN_COMMENTS as COLUMNS_COMMENT, ";
                    strSQL += "\r\n               upper(cc.DATA_TYPE)+";
                    strSQL += "\r\n                CASE WHEN UPPER(cc.DATA_TYPE) LIKE '%CHAR%' THEN '('+CAST(cc.CHARACTER_OCTET_LENGTH AS VARCHAR)+')'";
                    strSQL += "\r\n                    WHEN UPPER(cc.DATA_TYPE) LIKE '%INT%'  THEN '' ";
                    strSQL += "\r\n                    WHEN UPPER(cc.DATA_TYPE) LIKE '%DATE%' THEN '' ";
                    strSQL += "\r\n                    WHEN UPPER(cc.DATA_TYPE) LIKE '%TIME%' THEN '' ";
                    strSQL += "\r\n                    WHEN UPPER(cc.DATA_TYPE) LIKE '%TEXT%' THEN '' ";
                    strSQL += "\r\n                    WHEN UPPER(cc.DATA_TYPE) IN('DECIMAL','NUMERIC') THEN '('+ CAST(cc.NUMERIC_PRECISION AS VARCHAR) +','+CAST(cc.NUMERIC_SCALE AS VARCHAR)+')'";
                    strSQL += "\r\n                    END AS COLUMNS_DATA_TYPE";
                    strSQL += "\r\n    FROM  sys.indexes i";
                    strSQL += "\r\n       inner join  sys.all_columns c on i.object_id = c.object_id";
                    strSQL += "\r\n      inner join  sys.index_columns ic on   i.object_id = ic.object_id  and i.index_id = ic.index_id  and c.column_id = ic.column_id";
                    strSQL += "\r\n      left outer join COLS cc on cc.COLUMN_NAME = upper(c.name)";
                    strSQL = strSQL + "\r\n  where i.name = '" + idxNm + "'";
                    strSQL += "\r\n  order by ic.index_column_id ";
                    indexConInfo = clsMsSql.GetDataTable(this._mssqlConStr, strSQL);
                    Debug.WriteLine(tblENm + " Select Done!");
                }
                else
                {
                    strSQL += "\r\n  SELECT  IC.COLUMN_POSITION AS SEQ,";
                    strSQL += "\r\n          IC.COLUMN_NAME,";
                    strSQL += "\r\n          CC.COMMENTS AS COLUMNS_COMMENT,";
                    strSQL += "\r\n          TC.DATA_TYPE||";
                    strSQL += "\r\n          (CASE   WHEN UPPER(TC.DATA_TYPE) LIKE '%CHAR%' THEN '('||TO_CHAR(TC.CHAR_COL_DECL_LENGTH)||')'";
                    strSQL += "\r\n                  WHEN UPPER(TC.DATA_TYPE) LIKE '%INT%'  THEN '' ";
                    strSQL += "\r\n                  WHEN UPPER(TC.DATA_TYPE) LIKE '%DATE%' THEN '' ";
                    strSQL += "\r\n                  WHEN UPPER(TC.DATA_TYPE) LIKE '%TIME%' THEN '' ";
                    strSQL += "\r\n                  WHEN UPPER(TC.DATA_TYPE) LIKE '%TEXT%' THEN '' ";
                    strSQL += "\r\n                  WHEN UPPER(TC.DATA_TYPE) IN('DECIMAL','NUMBER') THEN '('|| TO_CHAR(TC.DATA_PRECISION) ||','||TO_CHAR(TC.DATA_SCALE)||')'";
                    strSQL += "\r\n                  END) AS COLUMNS_DATA_TYPE";
                    strSQL += "\r\n  FROM USER_INDEXES I";
                    strSQL += "\r\n      LEFT OUTER JOIN USER_ind_columns IC";
                    strSQL += "\r\n          ON I.INDEX_NAME = IC.INDEX_NAME AND I.TABLE_NAME = IC.TABLE_NAME ";
                    strSQL += "\r\n      LEFT OUTER JOIN USER_TAB_COLUMNS TC";
                    strSQL += "\r\n          ON IC.TABLE_NAME = TC.TABLE_NAME AND IC.COLUMN_NAME = TC.COLUMN_NAME";
                    strSQL += "\r\n      LEFT OUTER JOIN USER_COL_COMMENTS CC";
                    strSQL += "\r\n          ON IC.TABLE_NAME = CC.TABLE_NAME AND IC.COLUMN_NAME = CC.COLUMN_NAME";
                    strSQL = strSQL + "\r\n  WHERE  I.INDEX_NAME = '" + idxNm + "'";
                    strSQL += "\r\n  AND    I.INDEX_TYPE = 'NORMAL'";
                    strSQL = strSQL + "\r\n  AND    I.TABLE_OWNER =  UPPER('" + this._owner + "')";
                    strSQL += "\r\n  ORDER BY IC.COLUMN_POSITION";
                    indexConInfo = clsOracle.GetDataTable(this._oracleConStr, strSQL);
                    Debug.WriteLine(tblENm + " Select Done!");
                }
            }
            catch (Exception ex)
            {
                this.ExistError = true;
                string message = empty + ex.Message + "\r\n";
                this.ErrorMessage = message;
                Debug.WriteLine(message);
                clsLog.ErrLog(ex, strSQL);
            }
            return indexConInfo;
        }

        public DataTable GetDBObject(DBKind dsDbkind, string dbType, string dbTypeNm)
        {
            string empty = string.Empty;
            string strSQL = string.Empty;
            DataTable dbObject = new DataTable();
            try
            {
                this.DSResult.Clear();
                if (dsDbkind == DBKind.MSSQL)
                {
                    strSQL += "\r\n  \tSELECT   A.NAME AS OBJECT_NAME";
                    strSQL += "\r\n              , A.status AS STATUS";
                    strSQL += "\r\n               ,A.crdate  AS CREATED";
                    strSQL += "\r\n               ,A.refdate AS LAST_DDL_TIME";
                    strSQL += "\r\n  \t  FROM sys.sysobjects  AS A WITH (NOLOCK)";
                    strSQL += "\r\n  \t\t   LEFT JOIN  sys.database_principals obj WITH (NOLOCK) ON A.UID = obj.principal_id";
                    strSQL += "\r\n  \t WHERE NOT xtype IN ('X','S','SQ','IT','RF','L')";
                    strSQL += "\r\n    \t   AND A.UID = (SELECT top 1 schema_id FROM SYS.schemas WHERE NAME = SCHEMA_NAME())";
                    strSQL = strSQL + "\r\n  \t   AND A.XTYPE = CASE WHEN '" + dbType + "' = 'PROCEDURE' THEN 'P' ";
                    strSQL = strSQL + "\r\n                            WHEN '" + dbType + "' = 'SCALA FUNCTION' THEN 'FN' ";
                    strSQL = strSQL + "\r\n                            WHEN '" + dbType + "' = 'TABLE FUNCTION' THEN 'TF' ";
                    strSQL = strSQL + "\r\n                            WHEN '" + dbType + "' = 'INLINE FUNCTION' THEN 'IF' ";
                    strSQL = strSQL + "\r\n                            WHEN '" + dbType + "' = 'TRIGER' THEN 'TR' ";
                    strSQL = strSQL + "\r\n                            WHEN '" + dbType + "' = 'VIEW' THEN 'V' ";
                    strSQL = strSQL + "\r\n                            WHEN '" + dbType + "' = 'CHECK' THEN 'C' ";
                    strSQL = strSQL + "\r\n                            WHEN '" + dbType + "' = 'DEFAULT' THEN 'D' ";
                    strSQL = strSQL + "\r\n                            WHEN '" + dbType + "' = 'ROLE' THEN 'R' ELSE '' END ";
                    if (!string.IsNullOrEmpty(dbTypeNm))
                        strSQL = strSQL + "\r\n  \t   AND UPPER(A.NAME) LIKE '%'+UPPER('" + dbTypeNm + "')+'%'";
                    strSQL += "\r\n  \t ORDER BY A.NAME;";
                    dbObject = clsMsSql.GetDataTable(this._mssqlConStr, strSQL);
                    Debug.WriteLine(dbType + " Select Done!");
                }
                else
                {
                    strSQL += "\r\n  SELECT  OBJECT_NAME, ";
                    strSQL += "\r\n          STATUS,";
                    strSQL += "\r\n          CREATED,";
                    strSQL += "\r\n          LAST_DDL_TIME ";
                    strSQL += "\r\n   FROM USER_OBJECTS";
                    strSQL = strSQL + "\r\n  WHERE OBJECT_TYPE =  '" + dbType + "'";
                    if (!string.IsNullOrEmpty(dbTypeNm))
                        strSQL = strSQL + "\r\n  AND UPPER(OBJECT_NAME) LIKE '%'||'" + dbTypeNm + "'||'%'";
                    strSQL += "\r\n  ORDER BY  OBJECT_NAME";
                    dbObject = clsOracle.GetDataTable(this._oracleConStr, strSQL);
                    Debug.WriteLine(dbType + " Select Done!");
                }
            }
            catch (Exception ex)
            {
                this.ExistError = true;
                string message = empty + ex.Message + "\r\n";
                this.ErrorMessage = message;
                Debug.WriteLine(message);
                clsLog.ErrLog(ex, strSQL);
            }
            return dbObject;
        }

        public DataTable GetDBObjectScript(DBKind dsDbkind, string objType, string objNm)
        {
            string empty = string.Empty;
            string strSQL = string.Empty;
            DataTable dbObjectScript = new DataTable();
            try
            {
                this.DSResult.Clear();
                if (dsDbkind == DBKind.MSSQL)
                {
                    strSQL += "\r\n   SELECT\tB.text ";
                    strSQL += "\r\n  FROM\tsys.sysobjects AS A WITH (NOLOCK)";
                    strSQL += "\r\n  \t\tINNER JOIN sys.syscomments AS B WITH (NOLOCK)\tON A.id = B.id";
                    strSQL = strSQL + "\r\n  WHERE\tA.name =  '" + objNm + "'";
                    dbObjectScript = clsMsSql.GetDataTable(this._mssqlConStr, strSQL);
                    Debug.WriteLine(objNm + " Select Done!");
                }
                else
                {
                    strSQL += "\r\n  SELECT TEXT AS TEXT ";
                    strSQL += "\r\n  from user_source";
                    strSQL = strSQL + "\r\n  WHERE TYPE =  '" + objType + "'";
                    strSQL = strSQL + "\r\n  AND NAME =  '" + objNm + "'";
                    strSQL += "\r\n  ORDER BY LINE";
                    dbObjectScript = clsOracle.GetDataTable(this._oracleConStr, strSQL);
                    Debug.WriteLine(objNm + " Select Done!");
                }
            }
            catch (Exception ex)
            {
                this.ExistError = true;
                string message = empty + ex.Message + "\r\n";
                this.ErrorMessage = message;
                Debug.WriteLine(message);
                clsLog.ErrLog(ex, strSQL);
            }
            return dbObjectScript;
        }

        private string GetSPComment(DataTable inDt, SQLGBN inSqlGbn)
        {
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            this.GetSQLGBNStr(inSqlGbn, ref empty1, ref empty2);
            string empty3 = string.Empty;
            string spComment;
            if (this._lang == LANG.KOR)
                spComment = empty3 + "\r\n/******************************************************************************************" + "\r\n  1. 프로시져명  :  " + this.CreateSP_BDiv + "_" + this.CreateSP_MDiv + "_" + empty2 + "\r\n  2. 제목(기능)  : " + inDt.Rows[0]["TABLE_COMMENTS"].ToString() + " " + empty1 + "\r\n  3. 작  성  일  : " + DateTime.Now.ToString("yyyy-MM-dd") + "\r\n  4. 작  성  자  : (주)동서정보기술" + "\r\n  5. 적용Program :  " + string.Empty + "\r\n*******************************************************************************************" + "\r\n  6. 수정이력      수정일         수정자         수정내역" + "\r\n                " + DateTime.Now.ToString("yyyy-MM-dd") + "    " + CGCOMMON.Col_RPad(13, this.UserName) + "생성" + "\r\n******************************************************************************************/";
            else
                spComment = empty3 + "\r\n/******************************************************************************************" + "\r\n  1. PROCEDURE ID   : " + this.CreateSP_BDiv + "_" + this.CreateSP_MDiv + "_" + empty2 + "\r\n  2. PROCEDURE NAME : " + inDt.Rows[0]["TABLE_COMMENTS"].ToString() + " " + empty1 + "\r\n  3. CREATED DATE   : " + DateTime.Now.ToString("yyyy-MM-dd") + "\r\n  4. MADE BY        : DongSeo IT.Co.LTD" + "\r\n  5. USED PROGRAM   : " + string.Empty + "\r\n*******************************************************************************************" + "\r\n  6. HISTORY          DATE         NAME         DESCRIPTION" + "\r\n                      " + DateTime.Now.ToString("yyyy-MM-dd") + "   " + CGCOMMON.Col_RPad(10, this.UserName) + "CREATE" + "\r\n******************************************************************************************/";
            return spComment;
        }

        public int SetTableComment(DBKind dsDbkind, string strTableName, string strComment)
        {
            string empty = string.Empty;
            int num = 0;
            if (dsDbkind == DBKind.MSSQL)
            {
                try
                {
                    num = clsMsSql.SetData(this._mssqlConStr, empty + "EXEC sp_updateextendedproperty N'MS_Description',N'" + strComment + "',N'schema',N'dbo',N'table',N'" + strTableName + "'");
                }
                catch
                {
                    num = clsMsSql.SetData(this._mssqlConStr, string.Empty + "EXEC sp_addextendedproperty N'MS_Description',N'" + strComment + "',N'schema',N'dbo',N'table',N'" + strTableName + "'");
                }
            }
            else if (dsDbkind != DBKind.ORACLE)
                ;
            return num;
        }

        public int SetColumnsComment(
          DBKind dsDbkind,
          string strTableName,
          string strColumnsName,
          string strComment)
        {
            string empty = string.Empty;
            int num = 0;
            if (dsDbkind == DBKind.MSSQL)
            {
                try
                {
                    num = clsMsSql.SetData(this._mssqlConStr, empty + "EXEC sp_updateextendedproperty N'MS_Description',N'" + strComment + "',N'schema',N'dbo',N'table',N'" + strTableName + "',N'column',N'" + strColumnsName + "'");
                }
                catch
                {
                    num = clsMsSql.SetData(this._mssqlConStr, string.Empty + "EXEC sp_addextendedproperty N'MS_Description',N'" + strComment + "',N'schema',N'dbo',N'table',N'" + strTableName + "',N'column',N'" + strColumnsName + "'");
                }
            }
            else if (dsDbkind != DBKind.ORACLE)
                ;
            return num;
        }

        private string GetPLSQLReturnStr(DBKind dsDbkind, SQLGBN inSqlGbn)
        {
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            this.GetSQLGBNStr(inSqlGbn, ref empty1, ref empty2);
            string plsqlReturnStr = string.Empty;
            switch (dsDbkind)
            {
                case DBKind.ORACLE:
                    plsqlReturnStr = plsqlReturnStr + "    RAISE_MSG    VARCHAR2(1000);" + "\r\n    V_STEP       VARCHAR2(50)    := '0. Init';" + "\r\n    V_CNT        NUMBER(5)       := 0;";
                    break;
                case DBKind.MSSQL:
                    plsqlReturnStr = plsqlReturnStr + "    DECLARE @V_MSG  NVARCHAR(MAX)" + "\r\n    DECLARE @V_STEP NVARCHAR(50)";
                    break;
            }
            return plsqlReturnStr;
        }

        private string GetExceptionStr(DBKind dsDbkind, SQLGBN inSqlGbn, string strParm5)
        {
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            this.GetSQLGBNStr(inSqlGbn, ref empty1, ref empty2);
            string exceptionStr = string.Empty;
            switch (dsDbkind)
            {
                case DBKind.ORACLE:
                    string str1 = exceptionStr + "\r\n        IF (SQL%ROWCOUNT = 0 ) THEN" + "\r\n            V_STEP:=  '" + (object)inSqlGbn + " ERROR';";
                    int num;
                    switch (inSqlGbn)
                    {
                        case SQLGBN.INSERT:
                            str1 = str1 + "\r\n            -- DSMSG30103 : 등록된 데이터가 존재하지 않습니다.';" + "\r\n            RAISE_MSG := DF_COMMON.COMMON_MSG_SEL('DSMSG30103', NVL(IN_LANG_CD,'0'));";
                            goto label_8;
                        case SQLGBN.UPDATE:
                            num = 0;
                            break;
                        case SQLGBN.DELETE:
                            str1 = str1 + "\r\n            -- DSMSG30105 : 삭제된 데이터가 존재하지 않습니다.';" + "\r\n            RAISE_MSG := DF_COMMON.COMMON_MSG_SEL('DSMSG30105', NVL(IN_LANG_CD,'0'));";
                            goto label_8;
                        default:
                            num = inSqlGbn != SQLGBN.MERGE ? 1 : 0;
                            break;
                    }
                    if (num == 0)
                        str1 = str1 + "\r\n            -- DSMSG30104 : 수정된 데이터가 존재하지 않습니다.';" + "\r\n            RAISE_MSG := DF_COMMON.COMMON_MSG_SEL('DSMSG30104', NVL(IN_LANG_CD,'0'));";
                    label_8:
                    exceptionStr = str1 + "\r\n            RAISE RAISE_EXT;" + "\r\n        END IF;" + "\r\n    EXCEPTION" + "\r\n        WHEN RAISE_EXT THEN" + "\r\n            /* USER Define Error */" + "\r\n            DF_COMMON.COMMON_ERROR_20000(SQLCODE, V_STEP, RAISE_MSG" + strParm5 + ");" + "\r\n        WHEN OTHERS THEN" + "\r\n            /* DB Define Error */" + "\r\n            DF_COMMON.COMMON_ERROR_20001(SQLCODE, V_STEP, SQLERRM);";
                    break;
                case DBKind.MSSQL:
                    if (inSqlGbn == SQLGBN.INSERT || inSqlGbn == SQLGBN.UPDATE || inSqlGbn == SQLGBN.DELETE || inSqlGbn == SQLGBN.MERGE)
                    {
                        string str2 = exceptionStr + "\r\n        /* " + (object)inSqlGbn + " ERROR 처리 */" + "\r\n        IF @@ROWCOUNT = 0" + "\r\n        BEGIN" + "\r\n            SET @V_STEP = '" + (object)inSqlGbn + " ERROR'";
                        exceptionStr = (inSqlGbn != SQLGBN.DELETE ? str2 + "\r\n            SET @V_MSG = dbo.[FN_LANG_SELECT] (@IN_PLANT_CD, @IN_FACT_CD, 'DSYSMSGMST', 'DSMSG20002', '', @IN_LANG_CD)" + "\r\n            /* DSMSG20002 : 저장에 실패 하였습니다. */" : str2 + "\r\n            SET @V_MSG = dbo.[FN_LANG_SELECT] (@IN_PLANT_CD, @IN_FACT_CD, 'DSYSMSGMST', 'DSMSG30057', '',@IN_LANG_CD)" + "\r\n            /* DSMSG30057 : 삭제할 항목이 없습니다. */") + "\r\n" + "\r\n            RAISERROR (@V_MSG, 16, 1);  /* Message text, Severity, State */" + "\r\n            RETURN" + "\r\n        END;";
                    }
                    break;
            }
            return exceptionStr;
        }

        private string GetReturnResultStr(DBKind dsDbkind, SQLGBN inSqlGbn)
        {
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            this.GetSQLGBNStr(inSqlGbn, ref empty1, ref empty2);
            string returnResultStr = string.Empty;
            if (dsDbkind == DBKind.MSSQL)
                returnResultStr = returnResultStr + "\r\n        SELECT @V_MSG = dbo.[FN_GET_ERR_MSG] (ERROR_PROCEDURE(), ERROR_LINE(), ISNULL(ERROR_MESSAGE(),@V_MSG)); /* ERROR 프로시저, ERROR 라인, ERROR 메시지*/" + "\r\n        RAISERROR (@V_MSG, 16, 1); /* Message text, Severity, State */";
            return returnResultStr;
        }

        private void GetSQLGBNStr(SQLGBN inSqlGbn, ref string strSqlGbn, ref string strSqlDiv)
        {
            switch (inSqlGbn)
            {
                case SQLGBN.SELECT:
                    strSqlGbn = "SELECT";
                    strSqlDiv = "SEL";
                    break;
                case SQLGBN.INSERT:
                    strSqlGbn = "INSERT";
                    strSqlDiv = "INS";
                    break;
                case SQLGBN.UPDATE:
                    strSqlGbn = "UPDATE";
                    strSqlDiv = "UPT";
                    break;
                case SQLGBN.DELETE:
                    strSqlGbn = "DELETE";
                    strSqlDiv = "DEL";
                    break;
                case SQLGBN.MERGE:
                    strSqlGbn = "MERGE";
                    strSqlDiv = "MER";
                    break;
            }
        }

        public void CreateFile(FILEGBN fileGbn, string inStr, string tblENm)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(this.SavePath);
            if (!directoryInfo.Exists)
                directoryInfo.Create();
            switch (fileGbn)
            {
                case FILEGBN.SELECT_SQL:
                    File.WriteAllText(this.SavePath + tblENm + "_SEL.sql", inStr);
                    break;
                case FILEGBN.INSERT_SQL:
                    File.WriteAllText(this.SavePath + tblENm + "_INS.sql", inStr);
                    break;
                case FILEGBN.UPDATE_SQL:
                    File.WriteAllText(this.SavePath + tblENm + "_UPT.sql", inStr);
                    break;
                case FILEGBN.DELETE_SQL:
                    File.WriteAllText(this.SavePath + tblENm + "_DEL.sql", inStr);
                    break;
                case FILEGBN.MERGE_SQL:
                    File.WriteAllText(this.SavePath + tblENm + "_MGR.sql", inStr);
                    break;
                case FILEGBN.SELECT_P_SQL:
                    File.WriteAllText(this.SavePath + this._createSP_Bdiv + "_" + this._createSP_Mdiv + "_SEL.sql", inStr);
                    break;
                case FILEGBN.INSERT_P_SQL:
                    File.WriteAllText(this.SavePath + this._createSP_Bdiv + "_" + this._createSP_Mdiv + "_INS.sql", inStr);
                    break;
                case FILEGBN.UPDATE_P_SQL:
                    File.WriteAllText(this.SavePath + this._createSP_Bdiv + "_" + this._createSP_Mdiv + "_UPT.sql", inStr);
                    break;
                case FILEGBN.DELETE_P_SQL:
                    File.WriteAllText(this.SavePath + this._createSP_Bdiv + "_" + this._createSP_Mdiv + "_DEL.sql", inStr);
                    break;
                case FILEGBN.MERGE_P_SQL:
                    File.WriteAllText(this.SavePath + this._createSP_Bdiv + "_" + this._createSP_Mdiv + "_MGR.sql", inStr);
                    break;
            }
        }

        private OracleType getOracleType(string ColumnDBType)
        {
            OracleType oracleType;
            switch (ColumnDBType)
            {
                case "BLOB":
                    oracleType = OracleType.Blob;
                    break;
                case "CHAR":
                    oracleType = OracleType.Char;
                    break;
                case "DATE":
                    oracleType = OracleType.DateTime;
                    break;
                case "LONG":
                    oracleType = OracleType.Double;
                    break;
                case "LONG RAW":
                    oracleType = OracleType.LongRaw;
                    break;
                case "NCHAR":
                    oracleType = OracleType.NChar;
                    break;
                case "NCLOB":
                    oracleType = OracleType.NClob;
                    break;
                case "NUMBER":
                    oracleType = OracleType.Number;
                    break;
                case "NVARCHAR2":
                    oracleType = OracleType.NVarChar;
                    break;
                case "TIMESTAMP(0) WITH TIME ZONE":
                    oracleType = OracleType.Timestamp;
                    break;
                case "VARCHAR2":
                    oracleType = OracleType.VarChar;
                    break;
                default:
                    oracleType = OracleType.VarChar;
                    break;
            }
            return oracleType;
        }
    }
}
