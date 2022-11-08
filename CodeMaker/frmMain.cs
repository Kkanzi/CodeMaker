using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using KJHCore;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CodeMaker
{
    public partial class frmMain : MaterialForm
    {
        CGCOMMON gc = null;
        
        public frmMain()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

            clsLog.filePath = Application.StartupPath;
        }
        #region 이벤트
        private void frmMain_Load(object sender, EventArgs e)
        {
            ConfigLoad();

            chkALL_CheckedChanged(null, null);
        }


        /// <summary>
        /// 텍스트박스 숫자만 입력가능하게 하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //숫자만 입력되도록 필터링             
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리             
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                PrintLog(ex);
            }
        }

        private void chkALL_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkALL.Checked)
                {
                    chkSel_Q.Checked = true;
                    chkIns_Q.Checked = true;
                    chkUpd_Q.Checked = true;
                    chkDel_Q.Checked = true;
                    chkMer_Q.Checked = true;

                    chkSel_P.Checked = true;
                    chkIns_P.Checked = true;
                    chkUpd_P.Checked = true;
                    chkDel_P.Checked = true;
                    chkMer_P.Checked = true;
                }
                else
                {
                    chkSel_Q.Checked = false;
                    chkIns_Q.Checked = false;
                    chkUpd_Q.Checked = false;
                    chkDel_Q.Checked = false;
                    chkMer_Q.Checked = false;
                                       
                    chkSel_P.Checked = false;
                    chkIns_P.Checked = false;
                    chkUpd_P.Checked = false;
                    chkDel_P.Checked = false;
                    chkMer_P.Checked = false;
                }
            }
            catch (Exception ex)
            {
                PrintLog(ex);
            }
        }

        private void btnCONNECT_Click(object sender, EventArgs e)
        {
            try
            {
                if (gc != null)
                {
                    MaterialMessageBox.Show("이미 연결되었습니다.", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (string.IsNullOrEmpty(txtIP.Text.Trim()))
                {
                    MaterialMessageBox.Show("IP를 입력해주시기 바랍니다.", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtPORT.Text.Trim()))
                {
                    MaterialMessageBox.Show("PORT를 입력해주시기 바랍니다.", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtID.Text.Trim()))
                {
                    MaterialMessageBox.Show("ID를 입력해주시기 바랍니다.", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtPW.Text.Trim()))
                {
                    MaterialMessageBox.Show("Password를 입력해주시기 바랍니다.", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtDB.Text.Trim()))
                {
                    MaterialMessageBox.Show("DB Name을 입력해주시기 바랍니다.", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtSP_Prefix.Text.Trim()))
                {
                    MaterialMessageBox.Show("SP생성 접두사를 입력해주시기 바랍니다.", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtSP_Affix.Text.Trim()))
                {
                    MaterialMessageBox.Show("SP생성 접속사를 입력해주시기 바랍니다.", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string MsSqlConn = $@"data source = {txtIP.Text.Trim()},{txtPORT.Text.Trim()} ; initial Catalog = {txtDB.Text.Trim()} ; user id = {txtID.Text.Trim()} ;PASSWORD = {txtPW.Text.Trim()}";

                gc = new CGCOMMON(string.Empty, MsSqlConn, DBKind.MSSQL, LANG.KOR, txtSP_Prefix.Text, txtSP_Affix.Text, txtDB.Text);

                TableSearch();
            }
            catch (Exception ex)
            {
                PrintLog(ex);
            }
            finally
            {
                ConfigSave();
            }
        }

        private void btnTableSearch_Click(object sender, EventArgs e)
        {
            TableSearch();
        }

        private void btnDIR_Click(object sender, EventArgs e)
        {
            try
            { 
                FolderBrowserDialog fd = new FolderBrowserDialog();

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    txtDIR.Text = fd.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                PrintLog(ex);
            }
        }

        private void gvTABLE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gvTABLE.Rows.Count > 0)
                {
                    string strTableName = gvTABLE.Rows[e.RowIndex].Cells["TABLE_NAME"].Value.ToString();
                    string strComment = gvTABLE.Rows[e.RowIndex].Cells["TABLE_COMMENT"].Value.ToString();

                    //e.RowIndex;
                    FrmPopup frm = new FrmPopup(gc, strTableName, strComment);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        TableSearch();
                        //frm.OutComment
                    }
                }
            }
            catch (Exception ex)
            {
                PrintLog(ex);
            }
            
        }

        private void gvTABLE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gvTABLE.Rows.Count > 0)
                {
                    string strTableName = gvTABLE.Rows[e.RowIndex].Cells["TABLE_NAME"].Value.ToString();

                    DataTable dt = gc.GetColumnInfoMSSQL(strTableName);

                    if (dt.Rows.Count > 0)
                    {
                        gvColumn.DataSource = dt;

                        gvColumn.Columns["TABLE_SCHEMA"].Visible = false;
                        gvColumn.Columns["TABLE_CATALOG"].Visible = false;
                        gvColumn.Columns["TABLE_NAME"].Visible = false;
                        gvColumn.Columns["TABLE_COMMENTS"].Visible = false;
                        gvColumn.Columns["COLUMN_NAME_LEN"].Visible = false;
                        gvColumn.Columns["COLUMN_NAME_MAX_LEN"].Visible = false;
                        gvColumn.Columns["COLUMN_ID_MAX"].Visible = false;
                        gvColumn.Columns["DATA_LENGTH"].Visible = false;
                        gvColumn.Columns["DATA_PRECISION"].Visible = false;
                        gvColumn.Columns["DATA_SCALE"].Visible = false;
                        gvColumn.Columns["DATA_LEN_STR"].Visible = false;
                        gvColumn.Columns["COLUMN_NAME_MAX_LEN_PK"].Visible = false;
                        gvColumn.Columns["PK_SEQ"].Visible = false;
                        gvColumn.Columns["DATA_TYPE_MAX"].Visible = false;
                        gvColumn.Columns["DATA_LEN_STR_MAX"].Visible = false;
                        
                        txtRDB_Name.Text = strTableName;
                    }
                    else
                    {
                        gvColumn.DataSource = null;
                        txtRDB_Name.Text = string.Empty;
                        MaterialMessageBox.Show("테이블에 등록된 컬럼이 존재하지 않습니다.", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                PrintLog(ex);
            }
        }

        #endregion


        #region 메서드
        private void PrintLog(Exception ex)
        {
            StringBuilder sb = new StringBuilder(string.Empty);

            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(ex.Message);
            sb.AppendLine(ex.StackTrace);
            sb.AppendLine("");

            txtLOG.Text += sb.ToString();

            clsLog.ErrLog(ex);
        }

        private void TableSearch()
        {
            gvTABLE.DataSource = null;
            gvColumn.DataSource = null;

            if (gc == null)
            {
                MaterialMessageBox.Show("먼저 DB Connect를 해주시기바랍니다.", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = new DataTable();
            dt = gc.GetDBTableList(DBKind.MSSQL, txtTB_NAME.Text, txtTB_DESC.Text);

            if (dt.Rows.Count > 0)
            {
                gvTABLE.DataSource = dt;

                gvTABLE.Columns["TABLE_CATALOG"].Visible = false;
                gvTABLE.Columns["TABLE_SCHEMA"].Visible = false;
                gvTABLE.Columns["TABLE_TYPE"].Visible = false;

                gvTABLE.Columns["TABLE_NAME"].FillWeight = 80;
                gvTABLE.Columns["TABLE_COMMENT"].FillWeight = 140;
                gvTABLE.Columns["NUM_ROWS"].FillWeight = 70;
            }
            else
            {
                gvTABLE.DataSource = null;
                gvColumn.DataSource = null;
                txtRDB_Name.Text = string.Empty;

                MaterialMessageBox.Show("DB에 등록된 테이블이 존재하지 않습니다.", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ConfigLoad()
        {
            txtIP.Text = AppConfigHelper.GetAppConfig("MSSQLIP");
            txtPORT.Text = AppConfigHelper.GetAppConfig("MSSQLPORT");
            txtID.Text = AppConfigHelper.GetAppConfig("MSSQLID");
            txtPW.Text = AppConfigHelper.GetAppConfig("MSSQLPW");
            txtDB.Text = AppConfigHelper.GetAppConfig("MSSQLDBNAME");
            txtUser_Name.Text = AppConfigHelper.GetAppConfig("USERNAME");
            txtSP_Prefix.Text = AppConfigHelper.GetAppConfig("PREFIX");
            txtSP_Affix.Text = AppConfigHelper.GetAppConfig("AFFIX");
            txtSample_Cnt.Text = AppConfigHelper.GetAppConfig("SAM_ROW_CNT");
            txtDIR.Text = AppConfigHelper.GetAppConfig("SAVEFILE_DIR");
        }

        private void ConfigSave()
        {
            AppConfigHelper.SetAppConfig("MSSQLIP", txtIP.Text);
            AppConfigHelper.SetAppConfig("MSSQLPORT", txtPORT.Text);
            AppConfigHelper.SetAppConfig("MSSQLID", txtID.Text);
            AppConfigHelper.SetAppConfig("MSSQLPW", txtPW.Text);
            AppConfigHelper.SetAppConfig("MSSQLDBNAME", txtDB.Text);
            AppConfigHelper.SetAppConfig("USERNAME", txtUser_Name.Text);
            AppConfigHelper.SetAppConfig("PREFIX", txtSP_Prefix.Text);
            AppConfigHelper.SetAppConfig("AFFIX", txtSP_Affix.Text);
            AppConfigHelper.SetAppConfig("SAM_ROW_CNT", txtSample_Cnt.Text);
            AppConfigHelper.SetAppConfig("SAVEFILE_DIR", txtDIR.Text);
        }




        #endregion

        
    }
}
