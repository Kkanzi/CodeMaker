namespace CodeMaker
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabTABLE = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabSQL = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabSCRIPT = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabLOG = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPORT = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCONNECT = new MaterialSkin.Controls.MaterialButton();
            this.chkUNICODE = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialTabControl1.SuspendLayout();
            this.tabTABLE.SuspendLayout();
            this.tabSQL.SuspendLayout();
            this.tabSCRIPT.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabTABLE);
            this.materialTabControl1.Controls.Add(this.tabSQL);
            this.materialTabControl1.Controls.Add(this.tabSCRIPT);
            this.materialTabControl1.Controls.Add(this.tabLOG);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 205);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1178, 356);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.Tag = "";
            // 
            // tabTABLE
            // 
            this.tabTABLE.Controls.Add(this.panel1);
            this.tabTABLE.ImageKey = "Search.png";
            this.tabTABLE.Location = new System.Drawing.Point(4, 47);
            this.tabTABLE.Name = "tabTABLE";
            this.tabTABLE.Padding = new System.Windows.Forms.Padding(3);
            this.tabTABLE.Size = new System.Drawing.Size(1170, 305);
            this.tabTABLE.TabIndex = 2;
            this.tabTABLE.Tag = "table정보";
            this.tabTABLE.Text = "TABLE";
            this.tabTABLE.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 299);
            this.panel1.TabIndex = 0;
            // 
            // tabSQL
            // 
            this.tabSQL.Controls.Add(this.panel2);
            this.tabSQL.ImageKey = "task.png";
            this.tabSQL.Location = new System.Drawing.Point(4, 47);
            this.tabSQL.Name = "tabSQL";
            this.tabSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabSQL.Size = new System.Drawing.Size(1170, 305);
            this.tabSQL.TabIndex = 0;
            this.tabSQL.Tag = "쿼리작성";
            this.tabSQL.Text = "SQL";
            this.tabSQL.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 299);
            this.panel2.TabIndex = 0;
            // 
            // tabSCRIPT
            // 
            this.tabSCRIPT.Controls.Add(this.panel3);
            this.tabSCRIPT.ImageKey = "upload.png";
            this.tabSCRIPT.Location = new System.Drawing.Point(4, 47);
            this.tabSCRIPT.Name = "tabSCRIPT";
            this.tabSCRIPT.Padding = new System.Windows.Forms.Padding(3);
            this.tabSCRIPT.Size = new System.Drawing.Size(1170, 305);
            this.tabSCRIPT.TabIndex = 1;
            this.tabSCRIPT.Tag = "스크립트생성";
            this.tabSCRIPT.Text = "SCRIPT";
            this.tabSCRIPT.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1164, 299);
            this.panel3.TabIndex = 0;
            // 
            // tabLOG
            // 
            this.tabLOG.ImageKey = "setting.png";
            this.tabLOG.Location = new System.Drawing.Point(4, 47);
            this.tabLOG.Name = "tabLOG";
            this.tabLOG.Size = new System.Drawing.Size(1170, 305);
            this.tabLOG.TabIndex = 3;
            this.tabLOG.Tag = "로그 생성";
            this.tabLOG.Text = "LOG";
            this.tabLOG.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Search.png");
            this.imageList1.Images.SetKeyName(1, "task.png");
            this.imageList1.Images.SetKeyName(2, "upload.png");
            this.imageList1.Images.SetKeyName(3, "setting.png");
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel1.Location = new System.Drawing.Point(25, 21);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(14, 17);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(46, 19);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 21);
            this.txtIP.TabIndex = 2;
            this.txtIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel2.Location = new System.Drawing.Point(175, 23);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(37, 17);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "PORT";
            // 
            // txtPORT
            // 
            this.txtPORT.Location = new System.Drawing.Point(223, 19);
            this.txtPORT.Name = "txtPORT";
            this.txtPORT.Size = new System.Drawing.Size(100, 21);
            this.txtPORT.TabIndex = 4;
            this.txtPORT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel3.Location = new System.Drawing.Point(348, 23);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(14, 17);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(370, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 21);
            this.txtID.TabIndex = 6;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel4.Location = new System.Drawing.Point(492, 23);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(22, 17);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "PW";
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(523, 21);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(100, 21);
            this.txtPW.TabIndex = 8;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel5.Location = new System.Drawing.Point(644, 23);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(61, 17);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "DB NAME";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(720, 21);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(100, 21);
            this.txtDB.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCONNECT);
            this.panel4.Controls.Add(this.chkUNICODE);
            this.panel4.Controls.Add(this.materialLabel1);
            this.panel4.Controls.Add(this.txtIP);
            this.panel4.Controls.Add(this.materialLabel2);
            this.panel4.Controls.Add(this.txtPORT);
            this.panel4.Controls.Add(this.materialLabel3);
            this.panel4.Controls.Add(this.txtID);
            this.panel4.Controls.Add(this.materialLabel4);
            this.panel4.Controls.Add(this.txtPW);
            this.panel4.Controls.Add(this.materialLabel5);
            this.panel4.Controls.Add(this.txtDB);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1178, 141);
            this.panel4.TabIndex = 11;
            // 
            // btnCONNECT
            // 
            this.btnCONNECT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCONNECT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnCONNECT.Depth = 0;
            this.btnCONNECT.HighEmphasis = true;
            this.btnCONNECT.Icon = null;
            this.btnCONNECT.Location = new System.Drawing.Point(983, 12);
            this.btnCONNECT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCONNECT.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCONNECT.Name = "btnCONNECT";
            this.btnCONNECT.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCONNECT.Size = new System.Drawing.Size(89, 36);
            this.btnCONNECT.TabIndex = 12;
            this.btnCONNECT.Text = "Connect";
            this.btnCONNECT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCONNECT.UseAccentColor = true;
            this.btnCONNECT.UseVisualStyleBackColor = true;
            // 
            // chkUNICODE
            // 
            this.chkUNICODE.AutoSize = true;
            this.chkUNICODE.Checked = true;
            this.chkUNICODE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUNICODE.Depth = 0;
            this.chkUNICODE.Location = new System.Drawing.Point(844, 15);
            this.chkUNICODE.Margin = new System.Windows.Forms.Padding(0);
            this.chkUNICODE.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkUNICODE.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkUNICODE.Name = "chkUNICODE";
            this.chkUNICODE.ReadOnly = false;
            this.chkUNICODE.Ripple = true;
            this.chkUNICODE.Size = new System.Drawing.Size(94, 37);
            this.chkUNICODE.TabIndex = 11;
            this.chkUNICODE.Text = "UniCode";
            this.chkUNICODE.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 564);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.panel4);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "frmMain";
            this.Text = "CODE MAKER";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabTABLE.ResumeLayout(false);
            this.tabSQL.ResumeLayout(false);
            this.tabSCRIPT.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabSQL;
        private System.Windows.Forms.TabPage tabSCRIPT;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabTABLE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox txtIP;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox txtPORT;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox txtID;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox txtPW;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialCheckbox chkUNICODE;
        private MaterialSkin.Controls.MaterialButton btnCONNECT;
        private System.Windows.Forms.TabPage tabLOG;
    }
}

