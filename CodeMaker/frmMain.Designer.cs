﻿namespace CodeMaker
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCONNECT = new MaterialSkin.Controls.MaterialButton();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox5 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox7 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox8 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox9 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox10 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox11 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox12 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox13 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox14 = new MaterialSkin.Controls.MaterialCheckbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chkUNICODE = new MaterialSkin.Controls.MaterialSwitch();
            this.chkSel_Q = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkIns_Q = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkUpd_Q = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkDel_Q = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkMer_Q = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkSel_P = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkIns_P = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkUpd_P = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkDel_P = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkMer_P = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkALL = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialTabControl1.SuspendLayout();
            this.tabTABLE.SuspendLayout();
            this.tabSQL.SuspendLayout();
            this.tabSCRIPT.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.materialTabControl1.Location = new System.Drawing.Point(3, 223);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1223, 338);
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
            this.tabTABLE.Size = new System.Drawing.Size(1215, 287);
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
            this.panel1.Size = new System.Drawing.Size(1209, 281);
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
            this.materialLabel1.Location = new System.Drawing.Point(18, 17);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(14, 17);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(39, 15);
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
            this.materialLabel2.Location = new System.Drawing.Point(168, 19);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(37, 17);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "PORT";
            // 
            // txtPORT
            // 
            this.txtPORT.Location = new System.Drawing.Point(216, 15);
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
            this.materialLabel3.Location = new System.Drawing.Point(341, 19);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(14, 17);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(363, 15);
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
            this.materialLabel4.Location = new System.Drawing.Point(485, 19);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(22, 17);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "PW";
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(516, 17);
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
            this.materialLabel5.Location = new System.Drawing.Point(637, 19);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(61, 17);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "DB NAME";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(713, 17);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(100, 21);
            this.txtDB.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1223, 159);
            this.panel4.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkALL);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.materialLabel9);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.materialLabel8);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.materialLabel7);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1223, 104);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SQL Setup";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(748, 22);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 9;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel9.Location = new System.Drawing.Point(590, 26);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(152, 17);
            this.materialLabel9.TabIndex = 8;
            this.materialLabel9.Text = "Sample Data Row Count";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(470, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 7;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel8.Location = new System.Drawing.Point(415, 26);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(49, 17);
            this.materialLabel8.TabIndex = 6;
            this.materialLabel8.Text = "SP affix";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(290, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 5;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel7.Location = new System.Drawing.Point(213, 26);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(57, 17);
            this.materialLabel7.TabIndex = 4;
            this.materialLabel7.Text = "SP Prefix";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 3;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel6.Location = new System.Drawing.Point(18, 26);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(69, 17);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "User Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUNICODE);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.btnCONNECT);
            this.groupBox1.Controls.Add(this.txtDB);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.txtPW);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtPORT);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1223, 49);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DB Info";
            // 
            // btnCONNECT
            // 
            this.btnCONNECT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCONNECT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnCONNECT.Depth = 0;
            this.btnCONNECT.HighEmphasis = true;
            this.btnCONNECT.Icon = null;
            this.btnCONNECT.Location = new System.Drawing.Point(1061, 8);
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
            // materialCheckbox1
            // 
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox1.TabIndex = 0;
            this.materialCheckbox1.Text = "materialCheckbox1";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.ReadOnly = false;
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox2.TabIndex = 0;
            this.materialCheckbox2.Text = "materialCheckbox2";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox3
            // 
            this.materialCheckbox3.Depth = 0;
            this.materialCheckbox3.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox3.Name = "materialCheckbox3";
            this.materialCheckbox3.ReadOnly = false;
            this.materialCheckbox3.Ripple = true;
            this.materialCheckbox3.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox3.TabIndex = 0;
            this.materialCheckbox3.Text = "materialCheckbox3";
            this.materialCheckbox3.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox4
            // 
            this.materialCheckbox4.Depth = 0;
            this.materialCheckbox4.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox4.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox4.Name = "materialCheckbox4";
            this.materialCheckbox4.ReadOnly = false;
            this.materialCheckbox4.Ripple = true;
            this.materialCheckbox4.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox4.TabIndex = 0;
            this.materialCheckbox4.Text = "materialCheckbox4";
            this.materialCheckbox4.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox5
            // 
            this.materialCheckbox5.Depth = 0;
            this.materialCheckbox5.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox5.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox5.Name = "materialCheckbox5";
            this.materialCheckbox5.ReadOnly = false;
            this.materialCheckbox5.Ripple = true;
            this.materialCheckbox5.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox5.TabIndex = 0;
            this.materialCheckbox5.Text = "materialCheckbox5";
            this.materialCheckbox5.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox7
            // 
            this.materialCheckbox7.Checked = true;
            this.materialCheckbox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox7.Depth = 0;
            this.materialCheckbox7.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox7.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox7.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox7.Name = "materialCheckbox7";
            this.materialCheckbox7.ReadOnly = false;
            this.materialCheckbox7.Ripple = true;
            this.materialCheckbox7.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox7.TabIndex = 0;
            this.materialCheckbox7.Text = "test";
            this.materialCheckbox7.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox8
            // 
            this.materialCheckbox8.Depth = 0;
            this.materialCheckbox8.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox8.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox8.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox8.Name = "materialCheckbox8";
            this.materialCheckbox8.ReadOnly = false;
            this.materialCheckbox8.Ripple = true;
            this.materialCheckbox8.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox8.TabIndex = 0;
            this.materialCheckbox8.Text = "materialCheckbox8";
            this.materialCheckbox8.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox9
            // 
            this.materialCheckbox9.Depth = 0;
            this.materialCheckbox9.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox9.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox9.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox9.Name = "materialCheckbox9";
            this.materialCheckbox9.ReadOnly = false;
            this.materialCheckbox9.Ripple = true;
            this.materialCheckbox9.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox9.TabIndex = 0;
            this.materialCheckbox9.Text = "materialCheckbox9";
            this.materialCheckbox9.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox10
            // 
            this.materialCheckbox10.Depth = 0;
            this.materialCheckbox10.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox10.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox10.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox10.Name = "materialCheckbox10";
            this.materialCheckbox10.ReadOnly = false;
            this.materialCheckbox10.Ripple = true;
            this.materialCheckbox10.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox10.TabIndex = 0;
            this.materialCheckbox10.Text = "materialCheckbox10";
            this.materialCheckbox10.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox11
            // 
            this.materialCheckbox11.Depth = 0;
            this.materialCheckbox11.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox11.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox11.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox11.Name = "materialCheckbox11";
            this.materialCheckbox11.ReadOnly = false;
            this.materialCheckbox11.Ripple = true;
            this.materialCheckbox11.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox11.TabIndex = 0;
            this.materialCheckbox11.Text = "materialCheckbox11";
            this.materialCheckbox11.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox12
            // 
            this.materialCheckbox12.Depth = 0;
            this.materialCheckbox12.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox12.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox12.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox12.Name = "materialCheckbox12";
            this.materialCheckbox12.ReadOnly = false;
            this.materialCheckbox12.Ripple = true;
            this.materialCheckbox12.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox12.TabIndex = 0;
            this.materialCheckbox12.Text = "materialCheckbox12";
            this.materialCheckbox12.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox13
            // 
            this.materialCheckbox13.Depth = 0;
            this.materialCheckbox13.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox13.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox13.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox13.Name = "materialCheckbox13";
            this.materialCheckbox13.ReadOnly = false;
            this.materialCheckbox13.Ripple = true;
            this.materialCheckbox13.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox13.TabIndex = 0;
            this.materialCheckbox13.Text = "materialCheckbox13";
            this.materialCheckbox13.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox14
            // 
            this.materialCheckbox14.Depth = 0;
            this.materialCheckbox14.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox14.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox14.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox14.Name = "materialCheckbox14";
            this.materialCheckbox14.ReadOnly = false;
            this.materialCheckbox14.Ripple = true;
            this.materialCheckbox14.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox14.TabIndex = 0;
            this.materialCheckbox14.Text = "materialCheckbox14";
            this.materialCheckbox14.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chkSel_P);
            this.panel5.Controls.Add(this.chkIns_P);
            this.panel5.Controls.Add(this.chkUpd_P);
            this.panel5.Controls.Add(this.chkDel_P);
            this.panel5.Controls.Add(this.chkMer_P);
            this.panel5.Controls.Add(this.chkMer_Q);
            this.panel5.Controls.Add(this.chkDel_Q);
            this.panel5.Controls.Add(this.chkUpd_Q);
            this.panel5.Controls.Add(this.chkIns_Q);
            this.panel5.Controls.Add(this.chkSel_Q);
            this.panel5.Location = new System.Drawing.Point(15, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1150, 43);
            this.panel5.TabIndex = 10;
            // 
            // chkUNICODE
            // 
            this.chkUNICODE.AutoSize = true;
            this.chkUNICODE.Checked = true;
            this.chkUNICODE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUNICODE.Depth = 0;
            this.chkUNICODE.Location = new System.Drawing.Point(830, 9);
            this.chkUNICODE.Margin = new System.Windows.Forms.Padding(0);
            this.chkUNICODE.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkUNICODE.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkUNICODE.Name = "chkUNICODE";
            this.chkUNICODE.Ripple = true;
            this.chkUNICODE.Size = new System.Drawing.Size(117, 37);
            this.chkUNICODE.TabIndex = 11;
            this.chkUNICODE.Text = "UniCode";
            this.chkUNICODE.UseVisualStyleBackColor = true;
            // 
            // chkSel_Q
            // 
            this.chkSel_Q.AutoSize = true;
            this.chkSel_Q.Depth = 0;
            this.chkSel_Q.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkSel_Q.Location = new System.Drawing.Point(0, 0);
            this.chkSel_Q.Margin = new System.Windows.Forms.Padding(0);
            this.chkSel_Q.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkSel_Q.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkSel_Q.Name = "chkSel_Q";
            this.chkSel_Q.ReadOnly = false;
            this.chkSel_Q.Ripple = true;
            this.chkSel_Q.Size = new System.Drawing.Size(104, 43);
            this.chkSel_Q.TabIndex = 0;
            this.chkSel_Q.Text = "Select (Q)";
            this.chkSel_Q.UseVisualStyleBackColor = true;
            // 
            // chkIns_Q
            // 
            this.chkIns_Q.AutoSize = true;
            this.chkIns_Q.Depth = 0;
            this.chkIns_Q.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkIns_Q.Location = new System.Drawing.Point(104, 0);
            this.chkIns_Q.Margin = new System.Windows.Forms.Padding(0);
            this.chkIns_Q.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkIns_Q.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkIns_Q.Name = "chkIns_Q";
            this.chkIns_Q.ReadOnly = false;
            this.chkIns_Q.Ripple = true;
            this.chkIns_Q.Size = new System.Drawing.Size(100, 43);
            this.chkIns_Q.TabIndex = 1;
            this.chkIns_Q.Text = "Insert (Q)";
            this.chkIns_Q.UseVisualStyleBackColor = true;
            // 
            // chkUpd_Q
            // 
            this.chkUpd_Q.AutoSize = true;
            this.chkUpd_Q.Depth = 0;
            this.chkUpd_Q.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkUpd_Q.Location = new System.Drawing.Point(204, 0);
            this.chkUpd_Q.Margin = new System.Windows.Forms.Padding(0);
            this.chkUpd_Q.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkUpd_Q.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkUpd_Q.Name = "chkUpd_Q";
            this.chkUpd_Q.ReadOnly = false;
            this.chkUpd_Q.Ripple = true;
            this.chkUpd_Q.Size = new System.Drawing.Size(111, 43);
            this.chkUpd_Q.TabIndex = 2;
            this.chkUpd_Q.Text = "Update (Q)";
            this.chkUpd_Q.UseVisualStyleBackColor = true;
            // 
            // chkDel_Q
            // 
            this.chkDel_Q.AutoSize = true;
            this.chkDel_Q.Depth = 0;
            this.chkDel_Q.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkDel_Q.Location = new System.Drawing.Point(315, 0);
            this.chkDel_Q.Margin = new System.Windows.Forms.Padding(0);
            this.chkDel_Q.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkDel_Q.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkDel_Q.Name = "chkDel_Q";
            this.chkDel_Q.ReadOnly = false;
            this.chkDel_Q.Ripple = true;
            this.chkDel_Q.Size = new System.Drawing.Size(105, 43);
            this.chkDel_Q.TabIndex = 3;
            this.chkDel_Q.Text = "Delete (Q)";
            this.chkDel_Q.UseVisualStyleBackColor = true;
            // 
            // chkMer_Q
            // 
            this.chkMer_Q.AutoSize = true;
            this.chkMer_Q.Depth = 0;
            this.chkMer_Q.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkMer_Q.Location = new System.Drawing.Point(420, 0);
            this.chkMer_Q.Margin = new System.Windows.Forms.Padding(0);
            this.chkMer_Q.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkMer_Q.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkMer_Q.Name = "chkMer_Q";
            this.chkMer_Q.ReadOnly = false;
            this.chkMer_Q.Ripple = true;
            this.chkMer_Q.Size = new System.Drawing.Size(105, 43);
            this.chkMer_Q.TabIndex = 4;
            this.chkMer_Q.Text = "Merge (Q)";
            this.chkMer_Q.UseVisualStyleBackColor = true;
            // 
            // chkSel_P
            // 
            this.chkSel_P.AutoSize = true;
            this.chkSel_P.Depth = 0;
            this.chkSel_P.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkSel_P.Location = new System.Drawing.Point(630, 0);
            this.chkSel_P.Margin = new System.Windows.Forms.Padding(0);
            this.chkSel_P.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkSel_P.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkSel_P.Name = "chkSel_P";
            this.chkSel_P.ReadOnly = false;
            this.chkSel_P.Ripple = true;
            this.chkSel_P.Size = new System.Drawing.Size(103, 43);
            this.chkSel_P.TabIndex = 5;
            this.chkSel_P.Text = "Select (P)";
            this.chkSel_P.UseVisualStyleBackColor = true;
            // 
            // chkIns_P
            // 
            this.chkIns_P.AutoSize = true;
            this.chkIns_P.Depth = 0;
            this.chkIns_P.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkIns_P.Location = new System.Drawing.Point(733, 0);
            this.chkIns_P.Margin = new System.Windows.Forms.Padding(0);
            this.chkIns_P.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkIns_P.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkIns_P.Name = "chkIns_P";
            this.chkIns_P.ReadOnly = false;
            this.chkIns_P.Ripple = true;
            this.chkIns_P.Size = new System.Drawing.Size(99, 43);
            this.chkIns_P.TabIndex = 6;
            this.chkIns_P.Text = "Insert (P)";
            this.chkIns_P.UseVisualStyleBackColor = true;
            // 
            // chkUpd_P
            // 
            this.chkUpd_P.AutoSize = true;
            this.chkUpd_P.Depth = 0;
            this.chkUpd_P.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkUpd_P.Location = new System.Drawing.Point(832, 0);
            this.chkUpd_P.Margin = new System.Windows.Forms.Padding(0);
            this.chkUpd_P.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkUpd_P.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkUpd_P.Name = "chkUpd_P";
            this.chkUpd_P.ReadOnly = false;
            this.chkUpd_P.Ripple = true;
            this.chkUpd_P.Size = new System.Drawing.Size(110, 43);
            this.chkUpd_P.TabIndex = 7;
            this.chkUpd_P.Text = "Update (P)";
            this.chkUpd_P.UseVisualStyleBackColor = true;
            // 
            // chkDel_P
            // 
            this.chkDel_P.AutoSize = true;
            this.chkDel_P.Depth = 0;
            this.chkDel_P.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkDel_P.Location = new System.Drawing.Point(942, 0);
            this.chkDel_P.Margin = new System.Windows.Forms.Padding(0);
            this.chkDel_P.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkDel_P.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkDel_P.Name = "chkDel_P";
            this.chkDel_P.ReadOnly = false;
            this.chkDel_P.Ripple = true;
            this.chkDel_P.Size = new System.Drawing.Size(104, 43);
            this.chkDel_P.TabIndex = 8;
            this.chkDel_P.Text = "Delete (P)";
            this.chkDel_P.UseVisualStyleBackColor = true;
            // 
            // chkMer_P
            // 
            this.chkMer_P.AutoSize = true;
            this.chkMer_P.Depth = 0;
            this.chkMer_P.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkMer_P.Location = new System.Drawing.Point(1046, 0);
            this.chkMer_P.Margin = new System.Windows.Forms.Padding(0);
            this.chkMer_P.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkMer_P.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkMer_P.Name = "chkMer_P";
            this.chkMer_P.ReadOnly = false;
            this.chkMer_P.Ripple = true;
            this.chkMer_P.Size = new System.Drawing.Size(104, 43);
            this.chkMer_P.TabIndex = 9;
            this.chkMer_P.Text = "Merge (P)";
            this.chkMer_P.UseVisualStyleBackColor = true;
            // 
            // chkALL
            // 
            this.chkALL.AutoSize = true;
            this.chkALL.BackColor = System.Drawing.Color.Red;
            this.chkALL.Checked = true;
            this.chkALL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkALL.Depth = 0;
            this.chkALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkALL.ForeColor = System.Drawing.Color.Red;
            this.chkALL.Location = new System.Drawing.Point(895, 14);
            this.chkALL.Margin = new System.Windows.Forms.Padding(0);
            this.chkALL.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkALL.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkALL.Name = "chkALL";
            this.chkALL.ReadOnly = false;
            this.chkALL.Ripple = true;
            this.chkALL.Size = new System.Drawing.Size(117, 37);
            this.chkALL.TabIndex = 11;
            this.chkALL.Text = "ALL CHECK";
            this.chkALL.UseVisualStyleBackColor = false;
            this.chkALL.CheckedChanged += new System.EventHandler(this.chkALL_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 564);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private MaterialSkin.Controls.MaterialButton btnCONNECT;
        private System.Windows.Forms.TabPage tabLOG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.TextBox textBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox3;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox4;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox5;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox7;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox8;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox9;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox10;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox11;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox12;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox13;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox14;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialSwitch chkUNICODE;
        private MaterialSkin.Controls.MaterialCheckbox chkMer_P;
        private MaterialSkin.Controls.MaterialCheckbox chkDel_P;
        private MaterialSkin.Controls.MaterialCheckbox chkUpd_P;
        private MaterialSkin.Controls.MaterialCheckbox chkIns_P;
        private MaterialSkin.Controls.MaterialCheckbox chkSel_P;
        private MaterialSkin.Controls.MaterialCheckbox chkMer_Q;
        private MaterialSkin.Controls.MaterialCheckbox chkDel_Q;
        private MaterialSkin.Controls.MaterialCheckbox chkUpd_Q;
        private MaterialSkin.Controls.MaterialCheckbox chkIns_Q;
        private MaterialSkin.Controls.MaterialCheckbox chkSel_Q;
        private MaterialSkin.Controls.MaterialCheckbox chkALL;
    }
}

