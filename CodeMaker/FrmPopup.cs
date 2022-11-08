using KJHCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CodeMaker
{
    public partial class FrmPopup : Form
    {
        private string strComment = string.Empty;
        private CGCOMMON csg = null;
        private string strTabelName = string.Empty;

        public string OutComment;

        public FrmPopup()
        {
            InitializeComponent();
        }

        public FrmPopup(CGCOMMON cg, string tablename, string value)
        {
            InitializeComponent();

            csg = cg;
            strTabelName = tablename;
            strComment = value;
        }

        private void FrmPopup_Load(object sender, EventArgs e)
        {
            txtBOX.Text = strComment;
        }

        private void Save()
        {
            try
            {
                OutComment = txtBOX.Text;

                if (csg.SetTableComment(DBKind.MSSQL, strTabelName, txtBOX.Text) != 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtBOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Save();
            }
        }
    }
}
