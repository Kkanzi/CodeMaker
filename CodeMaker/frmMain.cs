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

            clsLog.filePath = "";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
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
                clsLog.ErrLog(ex.Message);
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
                clsLog.ErrLog(ex.Message);
            }
        }
    }
}
