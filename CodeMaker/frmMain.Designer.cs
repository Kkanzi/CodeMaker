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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvTABLE = new System.Windows.Forms.DataGridView();
            this.TABLE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TABLE_COMMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_ROWS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTableSearch = new MaterialSkin.Controls.MaterialButton();
            this.txtTB_DESC = new System.Windows.Forms.TextBox();
            this.Desc = new System.Windows.Forms.Label();
            this.txtTB_NAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gvColumn = new System.Windows.Forms.DataGridView();
            this.COLUMN_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLUMN_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLUMN_COMMENTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NULLABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gvSample = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gvIndexMaster = new System.Windows.Forms.DataGridView();
            this.gvIndexDetail = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCode = new MaterialSkin.Controls.MaterialButton();
            this.txtRDB_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabSQL = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabSCRIPT = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabLOG = new System.Windows.Forms.TabPage();
            this.txtLOG = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
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
            this.grpDIC = new System.Windows.Forms.GroupBox();
            this.btnDIR = new System.Windows.Forms.Button();
            this.txtDIR = new System.Windows.Forms.TextBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.chkALL = new MaterialSkin.Controls.MaterialCheckbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chkSel_P = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkIns_P = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkUpd_P = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkDel_P = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkMer_P = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkMer_Q = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkDel_Q = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkUpd_Q = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkIns_Q = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkSel_Q = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtSample_Cnt = new System.Windows.Forms.TextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSP_Affix = new System.Windows.Forms.TextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSP_Prefix = new System.Windows.Forms.TextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUser_Name = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.grpSetup = new System.Windows.Forms.GroupBox();
            this.chkUNICODE = new MaterialSkin.Controls.MaterialSwitch();
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
            this.INDEX_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INDEX_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FILES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idxCOLUMN_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idxCOLUMNS_COMMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idxCOLUMNS_DATA_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabQUERY = new System.Windows.Forms.TabControl();
            this.SELECT_Q = new System.Windows.Forms.TabPage();
            this.INSERT_Q = new System.Windows.Forms.TabPage();
            this.UPDATE_Q = new System.Windows.Forms.TabPage();
            this.DELETE_Q = new System.Windows.Forms.TabPage();
            this.MERGE_Q = new System.Windows.Forms.TabPage();
            this.SELECT_P = new System.Windows.Forms.TabPage();
            this.INSERT_P = new System.Windows.Forms.TabPage();
            this.UPDATE_P = new System.Windows.Forms.TabPage();
            this.DELETE_P = new System.Windows.Forms.TabPage();
            this.MERGE_P = new System.Windows.Forms.TabPage();
            this.txtSELECT_Q = new System.Windows.Forms.TextBox();
            this.txtINSERT_Q = new System.Windows.Forms.TextBox();
            this.txtUPDATE_Q = new System.Windows.Forms.TextBox();
            this.txtDELETE_Q = new System.Windows.Forms.TextBox();
            this.txtMERGE_Q = new System.Windows.Forms.TextBox();
            this.txtSELECT_P = new System.Windows.Forms.TextBox();
            this.txtINSERT_P = new System.Windows.Forms.TextBox();
            this.txtUPDATE_P = new System.Windows.Forms.TextBox();
            this.txtDELETE_P = new System.Windows.Forms.TextBox();
            this.txtMERGE_P = new System.Windows.Forms.TextBox();
            this.txtRDB_SCHEMA = new System.Windows.Forms.TextBox();
            this.materialTabControl1.SuspendLayout();
            this.tabTABLE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTABLE)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvColumn)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSample)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvIndexMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIndexDetail)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabSQL.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabSCRIPT.SuspendLayout();
            this.tabLOG.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grpDIC.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.grpSetup.SuspendLayout();
            this.tabQUERY.SuspendLayout();
            this.SELECT_Q.SuspendLayout();
            this.INSERT_Q.SuspendLayout();
            this.UPDATE_Q.SuspendLayout();
            this.DELETE_Q.SuspendLayout();
            this.MERGE_Q.SuspendLayout();
            this.SELECT_P.SuspendLayout();
            this.INSERT_P.SuspendLayout();
            this.UPDATE_P.SuspendLayout();
            this.DELETE_P.SuspendLayout();
            this.MERGE_P.SuspendLayout();
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
            this.materialTabControl1.Location = new System.Drawing.Point(3, 259);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1150, 688);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.Tag = "";
            // 
            // tabTABLE
            // 
            this.tabTABLE.Controls.Add(this.splitContainer1);
            this.tabTABLE.ImageKey = "Search.png";
            this.tabTABLE.Location = new System.Drawing.Point(4, 47);
            this.tabTABLE.Name = "tabTABLE";
            this.tabTABLE.Padding = new System.Windows.Forms.Padding(3);
            this.tabTABLE.Size = new System.Drawing.Size(1142, 637);
            this.tabTABLE.TabIndex = 2;
            this.tabTABLE.Tag = "table정보";
            this.tabTABLE.Text = "TABLE";
            this.tabTABLE.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.panel6);
            this.splitContainer1.Size = new System.Drawing.Size(1136, 631);
            this.splitContainer1.SplitterDistance = 538;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvTABLE);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 631);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table Search";
            // 
            // gvTABLE
            // 
            this.gvTABLE.AllowUserToAddRows = false;
            this.gvTABLE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTABLE.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.gvTABLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTABLE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TABLE_NAME,
            this.TABLE_COMMENT,
            this.NUM_ROWS});
            this.gvTABLE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvTABLE.Location = new System.Drawing.Point(3, 52);
            this.gvTABLE.Name = "gvTABLE";
            this.gvTABLE.ReadOnly = true;
            this.gvTABLE.RowTemplate.Height = 23;
            this.gvTABLE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTABLE.Size = new System.Drawing.Size(532, 576);
            this.gvTABLE.TabIndex = 2;
            this.gvTABLE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTABLE_CellClick);
            this.gvTABLE.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTABLE_CellDoubleClick);
            // 
            // TABLE_NAME
            // 
            this.TABLE_NAME.DataPropertyName = "TABLE_NAME";
            this.TABLE_NAME.FillWeight = 80F;
            this.TABLE_NAME.HeaderText = "테이블 명";
            this.TABLE_NAME.Name = "TABLE_NAME";
            this.TABLE_NAME.ReadOnly = true;
            // 
            // TABLE_COMMENT
            // 
            this.TABLE_COMMENT.DataPropertyName = "TABLE_COMMENT";
            this.TABLE_COMMENT.FillWeight = 140F;
            this.TABLE_COMMENT.HeaderText = "주석";
            this.TABLE_COMMENT.Name = "TABLE_COMMENT";
            this.TABLE_COMMENT.ReadOnly = true;
            // 
            // NUM_ROWS
            // 
            this.NUM_ROWS.DataPropertyName = "NUM_ROWS";
            this.NUM_ROWS.FillWeight = 70F;
            this.NUM_ROWS.HeaderText = "행수";
            this.NUM_ROWS.Name = "NUM_ROWS";
            this.NUM_ROWS.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTableSearch);
            this.panel1.Controls.Add(this.txtTB_DESC);
            this.panel1.Controls.Add(this.Desc);
            this.panel1.Controls.Add(this.txtTB_NAME);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnTableSearch
            // 
            this.btnTableSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTableSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTableSearch.Depth = 0;
            this.btnTableSearch.HighEmphasis = true;
            this.btnTableSearch.Icon = null;
            this.btnTableSearch.Location = new System.Drawing.Point(432, 0);
            this.btnTableSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTableSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTableSearch.Name = "btnTableSearch";
            this.btnTableSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTableSearch.Size = new System.Drawing.Size(78, 36);
            this.btnTableSearch.TabIndex = 10;
            this.btnTableSearch.Text = "Search";
            this.btnTableSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnTableSearch.UseAccentColor = false;
            this.btnTableSearch.UseVisualStyleBackColor = true;
            this.btnTableSearch.Click += new System.EventHandler(this.btnTableSearch_Click);
            // 
            // txtTB_DESC
            // 
            this.txtTB_DESC.Location = new System.Drawing.Point(213, 6);
            this.txtTB_DESC.Name = "txtTB_DESC";
            this.txtTB_DESC.Size = new System.Drawing.Size(211, 21);
            this.txtTB_DESC.TabIndex = 9;
            // 
            // Desc
            // 
            this.Desc.AutoSize = true;
            this.Desc.Location = new System.Drawing.Point(177, 9);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(34, 12);
            this.Desc.TabIndex = 8;
            this.Desc.Text = "Desc";
            // 
            // txtTB_NAME
            // 
            this.txtTB_NAME.Location = new System.Drawing.Point(55, 6);
            this.txtTB_NAME.Name = "txtTB_NAME";
            this.txtTB_NAME.Size = new System.Drawing.Size(114, 21);
            this.txtTB_NAME.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 587);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gvColumn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(586, 561);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Columns";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gvColumn
            // 
            this.gvColumn.AllowUserToAddRows = false;
            this.gvColumn.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.gvColumn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvColumn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COLUMN_ID,
            this.PK,
            this.COLUMN_NAME,
            this.COLUMN_COMMENTS,
            this.DATA_TYPE,
            this.NULLABLE});
            this.gvColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvColumn.Location = new System.Drawing.Point(3, 3);
            this.gvColumn.Name = "gvColumn";
            this.gvColumn.ReadOnly = true;
            this.gvColumn.RowTemplate.Height = 23;
            this.gvColumn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvColumn.Size = new System.Drawing.Size(580, 555);
            this.gvColumn.TabIndex = 3;
            this.gvColumn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvColumn_CellDoubleClick);
            // 
            // COLUMN_ID
            // 
            this.COLUMN_ID.DataPropertyName = "COLUMN_ID";
            this.COLUMN_ID.HeaderText = "SEQ";
            this.COLUMN_ID.Name = "COLUMN_ID";
            this.COLUMN_ID.ReadOnly = true;
            this.COLUMN_ID.Width = 40;
            // 
            // PK
            // 
            this.PK.DataPropertyName = "PK";
            this.PK.HeaderText = "PK";
            this.PK.Name = "PK";
            this.PK.ReadOnly = true;
            this.PK.Width = 40;
            // 
            // COLUMN_NAME
            // 
            this.COLUMN_NAME.DataPropertyName = "COLUMN_NAME";
            this.COLUMN_NAME.HeaderText = "컬럼명";
            this.COLUMN_NAME.Name = "COLUMN_NAME";
            this.COLUMN_NAME.ReadOnly = true;
            this.COLUMN_NAME.Width = 120;
            // 
            // COLUMN_COMMENTS
            // 
            this.COLUMN_COMMENTS.DataPropertyName = "COLUMN_COMMENTS";
            this.COLUMN_COMMENTS.HeaderText = "주석";
            this.COLUMN_COMMENTS.Name = "COLUMN_COMMENTS";
            this.COLUMN_COMMENTS.ReadOnly = true;
            this.COLUMN_COMMENTS.Width = 160;
            // 
            // DATA_TYPE
            // 
            this.DATA_TYPE.DataPropertyName = "DATA_TYPE";
            this.DATA_TYPE.HeaderText = "데이터 타입";
            this.DATA_TYPE.Name = "DATA_TYPE";
            this.DATA_TYPE.ReadOnly = true;
            // 
            // NULLABLE
            // 
            this.NULLABLE.DataPropertyName = "NULLABLE";
            this.NULLABLE.HeaderText = "NULL";
            this.NULLABLE.Name = "NULLABLE";
            this.NULLABLE.ReadOnly = true;
            this.NULLABLE.Width = 60;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gvSample);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(586, 561);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SampleData";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gvSample
            // 
            this.gvSample.AllowUserToAddRows = false;
            this.gvSample.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.gvSample.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSample.Location = new System.Drawing.Point(3, 3);
            this.gvSample.Name = "gvSample";
            this.gvSample.ReadOnly = true;
            this.gvSample.RowTemplate.Height = 23;
            this.gvSample.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSample.Size = new System.Drawing.Size(580, 555);
            this.gvSample.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(586, 561);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Index";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gvIndexMaster);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gvIndexDetail);
            this.splitContainer2.Size = new System.Drawing.Size(586, 561);
            this.splitContainer2.SplitterDistance = 195;
            this.splitContainer2.TabIndex = 0;
            // 
            // gvIndexMaster
            // 
            this.gvIndexMaster.AllowUserToAddRows = false;
            this.gvIndexMaster.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.gvIndexMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvIndexMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.INDEX_NAME,
            this.INDEX_TYPE,
            this.FILES});
            this.gvIndexMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvIndexMaster.Location = new System.Drawing.Point(0, 0);
            this.gvIndexMaster.Name = "gvIndexMaster";
            this.gvIndexMaster.ReadOnly = true;
            this.gvIndexMaster.RowTemplate.Height = 23;
            this.gvIndexMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvIndexMaster.Size = new System.Drawing.Size(586, 195);
            this.gvIndexMaster.TabIndex = 3;
            this.gvIndexMaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvIndexMaster_CellClick);
            // 
            // gvIndexDetail
            // 
            this.gvIndexDetail.AllowUserToAddRows = false;
            this.gvIndexDetail.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.gvIndexDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvIndexDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SEQ,
            this.idxCOLUMN_NAME,
            this.idxCOLUMNS_COMMENT,
            this.idxCOLUMNS_DATA_TYPE});
            this.gvIndexDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvIndexDetail.Location = new System.Drawing.Point(0, 0);
            this.gvIndexDetail.Name = "gvIndexDetail";
            this.gvIndexDetail.ReadOnly = true;
            this.gvIndexDetail.RowTemplate.Height = 23;
            this.gvIndexDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvIndexDetail.Size = new System.Drawing.Size(586, 362);
            this.gvIndexDetail.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtRDB_SCHEMA);
            this.panel6.Controls.Add(this.btnCode);
            this.panel6.Controls.Add(this.txtRDB_Name);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(594, 44);
            this.panel6.TabIndex = 2;
            // 
            // btnCode
            // 
            this.btnCode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCode.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCode.Depth = 0;
            this.btnCode.HighEmphasis = true;
            this.btnCode.Icon = null;
            this.btnCode.Location = new System.Drawing.Point(429, 5);
            this.btnCode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCode.Name = "btnCode";
            this.btnCode.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCode.Size = new System.Drawing.Size(137, 36);
            this.btnCode.TabIndex = 10;
            this.btnCode.Text = "Code Generate";
            this.btnCode.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnCode.UseAccentColor = false;
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // txtRDB_Name
            // 
            this.txtRDB_Name.Location = new System.Drawing.Point(207, 8);
            this.txtRDB_Name.Name = "txtRDB_Name";
            this.txtRDB_Name.ReadOnly = true;
            this.txtRDB_Name.Size = new System.Drawing.Size(211, 21);
            this.txtRDB_Name.TabIndex = 9;
            this.txtRDB_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRDB_Name_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Table Name";
            // 
            // tabSQL
            // 
            this.tabSQL.Controls.Add(this.panel2);
            this.tabSQL.ImageKey = "task.png";
            this.tabSQL.Location = new System.Drawing.Point(4, 47);
            this.tabSQL.Name = "tabSQL";
            this.tabSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabSQL.Size = new System.Drawing.Size(1142, 637);
            this.tabSQL.TabIndex = 0;
            this.tabSQL.Tag = "쿼리작성";
            this.tabSQL.Text = "SQL";
            this.tabSQL.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabQUERY);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1136, 631);
            this.panel2.TabIndex = 0;
            // 
            // tabSCRIPT
            // 
            this.tabSCRIPT.Controls.Add(this.panel3);
            this.tabSCRIPT.ImageKey = "upload.png";
            this.tabSCRIPT.Location = new System.Drawing.Point(4, 47);
            this.tabSCRIPT.Name = "tabSCRIPT";
            this.tabSCRIPT.Padding = new System.Windows.Forms.Padding(3);
            this.tabSCRIPT.Size = new System.Drawing.Size(1142, 637);
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
            this.panel3.Size = new System.Drawing.Size(1136, 631);
            this.panel3.TabIndex = 0;
            // 
            // tabLOG
            // 
            this.tabLOG.Controls.Add(this.txtLOG);
            this.tabLOG.ImageKey = "setting.png";
            this.tabLOG.Location = new System.Drawing.Point(4, 47);
            this.tabLOG.Name = "tabLOG";
            this.tabLOG.Size = new System.Drawing.Size(1142, 637);
            this.tabLOG.TabIndex = 3;
            this.tabLOG.Tag = "로그 생성";
            this.tabLOG.Text = "LOG";
            this.tabLOG.UseVisualStyleBackColor = true;
            // 
            // txtLOG
            // 
            this.txtLOG.AnimateReadOnly = false;
            this.txtLOG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtLOG.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLOG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLOG.Depth = 0;
            this.txtLOG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLOG.HideSelection = true;
            this.txtLOG.Location = new System.Drawing.Point(0, 0);
            this.txtLOG.MaxLength = 32767;
            this.txtLOG.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLOG.Name = "txtLOG";
            this.txtLOG.PasswordChar = '\0';
            this.txtLOG.ReadOnly = true;
            this.txtLOG.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLOG.SelectedText = "";
            this.txtLOG.SelectionLength = 0;
            this.txtLOG.SelectionStart = 0;
            this.txtLOG.ShortcutsEnabled = true;
            this.txtLOG.Size = new System.Drawing.Size(1142, 637);
            this.txtLOG.TabIndex = 0;
            this.txtLOG.TabStop = false;
            this.txtLOG.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLOG.UseSystemPasswordChar = false;
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
            this.materialLabel1.Location = new System.Drawing.Point(10, 17);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(14, 17);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(30, 15);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(148, 21);
            this.txtIP.TabIndex = 2;
            this.txtIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel2.Location = new System.Drawing.Point(184, 17);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(37, 17);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "PORT";
            // 
            // txtPORT
            // 
            this.txtPORT.Location = new System.Drawing.Point(225, 15);
            this.txtPORT.Name = "txtPORT";
            this.txtPORT.Size = new System.Drawing.Size(83, 21);
            this.txtPORT.TabIndex = 4;
            this.txtPORT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel3.Location = new System.Drawing.Point(316, 17);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(14, 17);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(336, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(119, 21);
            this.txtID.TabIndex = 6;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel4.Location = new System.Drawing.Point(464, 17);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(22, 17);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "PW";
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(492, 15);
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
            this.materialLabel5.Location = new System.Drawing.Point(604, 17);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(61, 17);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "DB NAME";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(672, 15);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(100, 21);
            this.txtDB.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grpDIC);
            this.panel4.Controls.Add(this.grpInfo);
            this.panel4.Controls.Add(this.grpSetup);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1150, 195);
            this.panel4.TabIndex = 11;
            // 
            // grpDIC
            // 
            this.grpDIC.Controls.Add(this.btnDIR);
            this.grpDIC.Controls.Add(this.txtDIR);
            this.grpDIC.Controls.Add(this.materialLabel10);
            this.grpDIC.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDIC.Location = new System.Drawing.Point(0, 147);
            this.grpDIC.Name = "grpDIC";
            this.grpDIC.Size = new System.Drawing.Size(1150, 47);
            this.grpDIC.TabIndex = 15;
            this.grpDIC.TabStop = false;
            this.grpDIC.Text = "Save File Directory";
            // 
            // btnDIR
            // 
            this.btnDIR.Location = new System.Drawing.Point(468, 17);
            this.btnDIR.Name = "btnDIR";
            this.btnDIR.Size = new System.Drawing.Size(28, 23);
            this.btnDIR.TabIndex = 5;
            this.btnDIR.Text = "...";
            this.btnDIR.UseVisualStyleBackColor = true;
            this.btnDIR.Click += new System.EventHandler(this.btnDIR_Click);
            // 
            // txtDIR
            // 
            this.txtDIR.Location = new System.Drawing.Point(133, 18);
            this.txtDIR.Name = "txtDIR";
            this.txtDIR.Size = new System.Drawing.Size(335, 21);
            this.txtDIR.TabIndex = 4;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel10.Location = new System.Drawing.Point(13, 20);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(111, 17);
            this.materialLabel10.TabIndex = 3;
            this.materialLabel10.Text = "SaveFile Directory";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.chkALL);
            this.grpInfo.Controls.Add(this.panel5);
            this.grpInfo.Controls.Add(this.txtSample_Cnt);
            this.grpInfo.Controls.Add(this.materialLabel9);
            this.grpInfo.Controls.Add(this.txtSP_Affix);
            this.grpInfo.Controls.Add(this.materialLabel8);
            this.grpInfo.Controls.Add(this.txtSP_Prefix);
            this.grpInfo.Controls.Add(this.materialLabel7);
            this.grpInfo.Controls.Add(this.txtUser_Name);
            this.grpInfo.Controls.Add(this.materialLabel6);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInfo.Location = new System.Drawing.Point(0, 55);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(1150, 92);
            this.grpInfo.TabIndex = 14;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "SQL Setup";
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
            this.chkALL.Location = new System.Drawing.Point(781, 15);
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
            this.panel5.Location = new System.Drawing.Point(6, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1077, 37);
            this.panel5.TabIndex = 10;
            // 
            // chkSel_P
            // 
            this.chkSel_P.AutoSize = true;
            this.chkSel_P.Depth = 0;
            this.chkSel_P.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkSel_P.Location = new System.Drawing.Point(557, 0);
            this.chkSel_P.Margin = new System.Windows.Forms.Padding(0);
            this.chkSel_P.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkSel_P.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkSel_P.Name = "chkSel_P";
            this.chkSel_P.ReadOnly = false;
            this.chkSel_P.Ripple = true;
            this.chkSel_P.Size = new System.Drawing.Size(103, 37);
            this.chkSel_P.TabIndex = 5;
            this.chkSel_P.Text = "Select (P)";
            this.chkSel_P.UseVisualStyleBackColor = true;
            // 
            // chkIns_P
            // 
            this.chkIns_P.AutoSize = true;
            this.chkIns_P.Depth = 0;
            this.chkIns_P.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkIns_P.Location = new System.Drawing.Point(660, 0);
            this.chkIns_P.Margin = new System.Windows.Forms.Padding(0);
            this.chkIns_P.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkIns_P.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkIns_P.Name = "chkIns_P";
            this.chkIns_P.ReadOnly = false;
            this.chkIns_P.Ripple = true;
            this.chkIns_P.Size = new System.Drawing.Size(99, 37);
            this.chkIns_P.TabIndex = 6;
            this.chkIns_P.Text = "Insert (P)";
            this.chkIns_P.UseVisualStyleBackColor = true;
            // 
            // chkUpd_P
            // 
            this.chkUpd_P.AutoSize = true;
            this.chkUpd_P.Depth = 0;
            this.chkUpd_P.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkUpd_P.Location = new System.Drawing.Point(759, 0);
            this.chkUpd_P.Margin = new System.Windows.Forms.Padding(0);
            this.chkUpd_P.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkUpd_P.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkUpd_P.Name = "chkUpd_P";
            this.chkUpd_P.ReadOnly = false;
            this.chkUpd_P.Ripple = true;
            this.chkUpd_P.Size = new System.Drawing.Size(110, 37);
            this.chkUpd_P.TabIndex = 7;
            this.chkUpd_P.Text = "Update (P)";
            this.chkUpd_P.UseVisualStyleBackColor = true;
            // 
            // chkDel_P
            // 
            this.chkDel_P.AutoSize = true;
            this.chkDel_P.Depth = 0;
            this.chkDel_P.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkDel_P.Location = new System.Drawing.Point(869, 0);
            this.chkDel_P.Margin = new System.Windows.Forms.Padding(0);
            this.chkDel_P.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkDel_P.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkDel_P.Name = "chkDel_P";
            this.chkDel_P.ReadOnly = false;
            this.chkDel_P.Ripple = true;
            this.chkDel_P.Size = new System.Drawing.Size(104, 37);
            this.chkDel_P.TabIndex = 8;
            this.chkDel_P.Text = "Delete (P)";
            this.chkDel_P.UseVisualStyleBackColor = true;
            // 
            // chkMer_P
            // 
            this.chkMer_P.AutoSize = true;
            this.chkMer_P.Depth = 0;
            this.chkMer_P.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkMer_P.Location = new System.Drawing.Point(973, 0);
            this.chkMer_P.Margin = new System.Windows.Forms.Padding(0);
            this.chkMer_P.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkMer_P.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkMer_P.Name = "chkMer_P";
            this.chkMer_P.ReadOnly = false;
            this.chkMer_P.Ripple = true;
            this.chkMer_P.Size = new System.Drawing.Size(104, 37);
            this.chkMer_P.TabIndex = 9;
            this.chkMer_P.Text = "Merge (P)";
            this.chkMer_P.UseVisualStyleBackColor = true;
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
            this.chkMer_Q.Size = new System.Drawing.Size(105, 37);
            this.chkMer_Q.TabIndex = 4;
            this.chkMer_Q.Text = "Merge (Q)";
            this.chkMer_Q.UseVisualStyleBackColor = true;
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
            this.chkDel_Q.Size = new System.Drawing.Size(105, 37);
            this.chkDel_Q.TabIndex = 3;
            this.chkDel_Q.Text = "Delete (Q)";
            this.chkDel_Q.UseVisualStyleBackColor = true;
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
            this.chkUpd_Q.Size = new System.Drawing.Size(111, 37);
            this.chkUpd_Q.TabIndex = 2;
            this.chkUpd_Q.Text = "Update (Q)";
            this.chkUpd_Q.UseVisualStyleBackColor = true;
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
            this.chkIns_Q.Size = new System.Drawing.Size(100, 37);
            this.chkIns_Q.TabIndex = 1;
            this.chkIns_Q.Text = "Insert (Q)";
            this.chkIns_Q.UseVisualStyleBackColor = true;
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
            this.chkSel_Q.Size = new System.Drawing.Size(104, 37);
            this.chkSel_Q.TabIndex = 0;
            this.chkSel_Q.Text = "Select (Q)";
            this.chkSel_Q.UseVisualStyleBackColor = true;
            // 
            // txtSample_Cnt
            // 
            this.txtSample_Cnt.Location = new System.Drawing.Point(678, 24);
            this.txtSample_Cnt.Name = "txtSample_Cnt";
            this.txtSample_Cnt.Size = new System.Drawing.Size(100, 21);
            this.txtSample_Cnt.TabIndex = 9;
            this.txtSample_Cnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel9.Location = new System.Drawing.Point(520, 26);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(152, 17);
            this.materialLabel9.TabIndex = 8;
            this.materialLabel9.Text = "Sample Data Row Count";
            // 
            // txtSP_Affix
            // 
            this.txtSP_Affix.Location = new System.Drawing.Point(414, 24);
            this.txtSP_Affix.Name = "txtSP_Affix";
            this.txtSP_Affix.Size = new System.Drawing.Size(100, 21);
            this.txtSP_Affix.TabIndex = 7;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel8.Location = new System.Drawing.Point(361, 26);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(49, 17);
            this.materialLabel8.TabIndex = 6;
            this.materialLabel8.Text = "SP affix";
            // 
            // txtSP_Prefix
            // 
            this.txtSP_Prefix.Location = new System.Drawing.Point(255, 24);
            this.txtSP_Prefix.Name = "txtSP_Prefix";
            this.txtSP_Prefix.Size = new System.Drawing.Size(100, 21);
            this.txtSP_Prefix.TabIndex = 5;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel7.Location = new System.Drawing.Point(192, 26);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(57, 17);
            this.materialLabel7.TabIndex = 4;
            this.materialLabel7.Text = "SP Prefix";
            // 
            // txtUser_Name
            // 
            this.txtUser_Name.Location = new System.Drawing.Point(86, 24);
            this.txtUser_Name.Name = "txtUser_Name";
            this.txtUser_Name.Size = new System.Drawing.Size(100, 21);
            this.txtUser_Name.TabIndex = 3;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel6.Location = new System.Drawing.Point(11, 26);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(69, 17);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "User Name";
            // 
            // grpSetup
            // 
            this.grpSetup.Controls.Add(this.chkUNICODE);
            this.grpSetup.Controls.Add(this.materialLabel1);
            this.grpSetup.Controls.Add(this.btnCONNECT);
            this.grpSetup.Controls.Add(this.txtDB);
            this.grpSetup.Controls.Add(this.materialLabel5);
            this.grpSetup.Controls.Add(this.txtPW);
            this.grpSetup.Controls.Add(this.txtIP);
            this.grpSetup.Controls.Add(this.materialLabel4);
            this.grpSetup.Controls.Add(this.materialLabel2);
            this.grpSetup.Controls.Add(this.txtID);
            this.grpSetup.Controls.Add(this.txtPORT);
            this.grpSetup.Controls.Add(this.materialLabel3);
            this.grpSetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSetup.Location = new System.Drawing.Point(0, 0);
            this.grpSetup.Name = "grpSetup";
            this.grpSetup.Size = new System.Drawing.Size(1150, 55);
            this.grpSetup.TabIndex = 13;
            this.grpSetup.TabStop = false;
            this.grpSetup.Text = "DB Info";
            // 
            // chkUNICODE
            // 
            this.chkUNICODE.AutoSize = true;
            this.chkUNICODE.Checked = true;
            this.chkUNICODE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUNICODE.Depth = 0;
            this.chkUNICODE.Location = new System.Drawing.Point(777, 9);
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
            // btnCONNECT
            // 
            this.btnCONNECT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCONNECT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnCONNECT.Depth = 0;
            this.btnCONNECT.HighEmphasis = true;
            this.btnCONNECT.Icon = null;
            this.btnCONNECT.Location = new System.Drawing.Point(947, 9);
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
            this.btnCONNECT.Click += new System.EventHandler(this.btnCONNECT_Click);
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
            // INDEX_NAME
            // 
            this.INDEX_NAME.DataPropertyName = "INDEX_NAME";
            this.INDEX_NAME.FillWeight = 80F;
            this.INDEX_NAME.HeaderText = "인덱스 이름";
            this.INDEX_NAME.Name = "INDEX_NAME";
            this.INDEX_NAME.ReadOnly = true;
            this.INDEX_NAME.Width = 160;
            // 
            // INDEX_TYPE
            // 
            this.INDEX_TYPE.DataPropertyName = "INDEX_TYPE";
            this.INDEX_TYPE.FillWeight = 140F;
            this.INDEX_TYPE.HeaderText = "인덱스 종류";
            this.INDEX_TYPE.Name = "INDEX_TYPE";
            this.INDEX_TYPE.ReadOnly = true;
            this.INDEX_TYPE.Width = 140;
            // 
            // FILES
            // 
            this.FILES.DataPropertyName = "FILES";
            this.FILES.FillWeight = 70F;
            this.FILES.HeaderText = "파일";
            this.FILES.Name = "FILES";
            this.FILES.ReadOnly = true;
            this.FILES.Width = 80;
            // 
            // SEQ
            // 
            this.SEQ.DataPropertyName = "SEQ";
            this.SEQ.FillWeight = 80F;
            this.SEQ.HeaderText = "순번";
            this.SEQ.Name = "SEQ";
            this.SEQ.ReadOnly = true;
            this.SEQ.Width = 60;
            // 
            // idxCOLUMN_NAME
            // 
            this.idxCOLUMN_NAME.DataPropertyName = "COLUMN_NAME";
            this.idxCOLUMN_NAME.FillWeight = 140F;
            this.idxCOLUMN_NAME.HeaderText = "컬럼 이름";
            this.idxCOLUMN_NAME.Name = "idxCOLUMN_NAME";
            this.idxCOLUMN_NAME.ReadOnly = true;
            this.idxCOLUMN_NAME.Width = 180;
            // 
            // idxCOLUMNS_COMMENT
            // 
            this.idxCOLUMNS_COMMENT.DataPropertyName = "COLUMNS_COMMENT";
            this.idxCOLUMNS_COMMENT.FillWeight = 70F;
            this.idxCOLUMNS_COMMENT.HeaderText = "컬럼 주석";
            this.idxCOLUMNS_COMMENT.Name = "idxCOLUMNS_COMMENT";
            this.idxCOLUMNS_COMMENT.ReadOnly = true;
            this.idxCOLUMNS_COMMENT.Width = 180;
            // 
            // idxCOLUMNS_DATA_TYPE
            // 
            this.idxCOLUMNS_DATA_TYPE.DataPropertyName = "COLUMNS_DATA_TYPE";
            this.idxCOLUMNS_DATA_TYPE.HeaderText = "컬럼타입";
            this.idxCOLUMNS_DATA_TYPE.Name = "idxCOLUMNS_DATA_TYPE";
            this.idxCOLUMNS_DATA_TYPE.ReadOnly = true;
            this.idxCOLUMNS_DATA_TYPE.Width = 80;
            // 
            // tabQUERY
            // 
            this.tabQUERY.Controls.Add(this.SELECT_Q);
            this.tabQUERY.Controls.Add(this.INSERT_Q);
            this.tabQUERY.Controls.Add(this.UPDATE_Q);
            this.tabQUERY.Controls.Add(this.DELETE_Q);
            this.tabQUERY.Controls.Add(this.MERGE_Q);
            this.tabQUERY.Controls.Add(this.SELECT_P);
            this.tabQUERY.Controls.Add(this.INSERT_P);
            this.tabQUERY.Controls.Add(this.UPDATE_P);
            this.tabQUERY.Controls.Add(this.DELETE_P);
            this.tabQUERY.Controls.Add(this.MERGE_P);
            this.tabQUERY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabQUERY.Location = new System.Drawing.Point(0, 0);
            this.tabQUERY.Name = "tabQUERY";
            this.tabQUERY.SelectedIndex = 0;
            this.tabQUERY.Size = new System.Drawing.Size(1136, 631);
            this.tabQUERY.TabIndex = 0;
            // 
            // SELECT_Q
            // 
            this.SELECT_Q.Controls.Add(this.txtSELECT_Q);
            this.SELECT_Q.Location = new System.Drawing.Point(4, 22);
            this.SELECT_Q.Name = "SELECT_Q";
            this.SELECT_Q.Padding = new System.Windows.Forms.Padding(3);
            this.SELECT_Q.Size = new System.Drawing.Size(1128, 605);
            this.SELECT_Q.TabIndex = 1;
            this.SELECT_Q.Text = "Select Query";
            this.SELECT_Q.UseVisualStyleBackColor = true;
            // 
            // INSERT_Q
            // 
            this.INSERT_Q.Controls.Add(this.txtINSERT_Q);
            this.INSERT_Q.Location = new System.Drawing.Point(4, 22);
            this.INSERT_Q.Name = "INSERT_Q";
            this.INSERT_Q.Size = new System.Drawing.Size(1128, 605);
            this.INSERT_Q.TabIndex = 2;
            this.INSERT_Q.Text = "Insert Query";
            this.INSERT_Q.UseVisualStyleBackColor = true;
            // 
            // UPDATE_Q
            // 
            this.UPDATE_Q.Controls.Add(this.txtUPDATE_Q);
            this.UPDATE_Q.Location = new System.Drawing.Point(4, 22);
            this.UPDATE_Q.Name = "UPDATE_Q";
            this.UPDATE_Q.Size = new System.Drawing.Size(1128, 605);
            this.UPDATE_Q.TabIndex = 3;
            this.UPDATE_Q.Text = "Update Query";
            this.UPDATE_Q.UseVisualStyleBackColor = true;
            // 
            // DELETE_Q
            // 
            this.DELETE_Q.Controls.Add(this.txtDELETE_Q);
            this.DELETE_Q.Location = new System.Drawing.Point(4, 22);
            this.DELETE_Q.Name = "DELETE_Q";
            this.DELETE_Q.Size = new System.Drawing.Size(1128, 605);
            this.DELETE_Q.TabIndex = 4;
            this.DELETE_Q.Text = "Delete Query";
            this.DELETE_Q.UseVisualStyleBackColor = true;
            // 
            // MERGE_Q
            // 
            this.MERGE_Q.Controls.Add(this.txtMERGE_Q);
            this.MERGE_Q.Location = new System.Drawing.Point(4, 22);
            this.MERGE_Q.Name = "MERGE_Q";
            this.MERGE_Q.Size = new System.Drawing.Size(1128, 605);
            this.MERGE_Q.TabIndex = 5;
            this.MERGE_Q.Text = "Merge Query";
            this.MERGE_Q.UseVisualStyleBackColor = true;
            // 
            // SELECT_P
            // 
            this.SELECT_P.Controls.Add(this.txtSELECT_P);
            this.SELECT_P.Location = new System.Drawing.Point(4, 22);
            this.SELECT_P.Name = "SELECT_P";
            this.SELECT_P.Size = new System.Drawing.Size(1128, 605);
            this.SELECT_P.TabIndex = 6;
            this.SELECT_P.Text = "Select Proc";
            this.SELECT_P.UseVisualStyleBackColor = true;
            // 
            // INSERT_P
            // 
            this.INSERT_P.Controls.Add(this.txtINSERT_P);
            this.INSERT_P.Location = new System.Drawing.Point(4, 22);
            this.INSERT_P.Name = "INSERT_P";
            this.INSERT_P.Size = new System.Drawing.Size(1128, 605);
            this.INSERT_P.TabIndex = 7;
            this.INSERT_P.Text = "Insert Proc";
            this.INSERT_P.UseVisualStyleBackColor = true;
            // 
            // UPDATE_P
            // 
            this.UPDATE_P.Controls.Add(this.txtUPDATE_P);
            this.UPDATE_P.Location = new System.Drawing.Point(4, 22);
            this.UPDATE_P.Name = "UPDATE_P";
            this.UPDATE_P.Size = new System.Drawing.Size(1128, 605);
            this.UPDATE_P.TabIndex = 8;
            this.UPDATE_P.Text = "Update Proc";
            this.UPDATE_P.UseVisualStyleBackColor = true;
            // 
            // DELETE_P
            // 
            this.DELETE_P.Controls.Add(this.txtDELETE_P);
            this.DELETE_P.Location = new System.Drawing.Point(4, 22);
            this.DELETE_P.Name = "DELETE_P";
            this.DELETE_P.Size = new System.Drawing.Size(1128, 605);
            this.DELETE_P.TabIndex = 9;
            this.DELETE_P.Text = "Delete Proc";
            this.DELETE_P.UseVisualStyleBackColor = true;
            // 
            // MERGE_P
            // 
            this.MERGE_P.Controls.Add(this.txtMERGE_P);
            this.MERGE_P.Location = new System.Drawing.Point(4, 22);
            this.MERGE_P.Name = "MERGE_P";
            this.MERGE_P.Size = new System.Drawing.Size(1128, 605);
            this.MERGE_P.TabIndex = 10;
            this.MERGE_P.Text = "Merge Proc";
            this.MERGE_P.UseVisualStyleBackColor = true;
            // 
            // txtSELECT_Q
            // 
            this.txtSELECT_Q.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSELECT_Q.Location = new System.Drawing.Point(3, 3);
            this.txtSELECT_Q.Multiline = true;
            this.txtSELECT_Q.Name = "txtSELECT_Q";
            this.txtSELECT_Q.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSELECT_Q.Size = new System.Drawing.Size(1122, 599);
            this.txtSELECT_Q.TabIndex = 0;
            // 
            // txtINSERT_Q
            // 
            this.txtINSERT_Q.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtINSERT_Q.Location = new System.Drawing.Point(0, 0);
            this.txtINSERT_Q.Multiline = true;
            this.txtINSERT_Q.Name = "txtINSERT_Q";
            this.txtINSERT_Q.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtINSERT_Q.Size = new System.Drawing.Size(1128, 605);
            this.txtINSERT_Q.TabIndex = 1;
            // 
            // txtUPDATE_Q
            // 
            this.txtUPDATE_Q.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUPDATE_Q.Location = new System.Drawing.Point(0, 0);
            this.txtUPDATE_Q.Multiline = true;
            this.txtUPDATE_Q.Name = "txtUPDATE_Q";
            this.txtUPDATE_Q.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUPDATE_Q.Size = new System.Drawing.Size(1128, 605);
            this.txtUPDATE_Q.TabIndex = 1;
            // 
            // txtDELETE_Q
            // 
            this.txtDELETE_Q.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDELETE_Q.Location = new System.Drawing.Point(0, 0);
            this.txtDELETE_Q.Multiline = true;
            this.txtDELETE_Q.Name = "txtDELETE_Q";
            this.txtDELETE_Q.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDELETE_Q.Size = new System.Drawing.Size(1128, 605);
            this.txtDELETE_Q.TabIndex = 1;
            // 
            // txtMERGE_Q
            // 
            this.txtMERGE_Q.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMERGE_Q.Location = new System.Drawing.Point(0, 0);
            this.txtMERGE_Q.Multiline = true;
            this.txtMERGE_Q.Name = "txtMERGE_Q";
            this.txtMERGE_Q.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMERGE_Q.Size = new System.Drawing.Size(1128, 605);
            this.txtMERGE_Q.TabIndex = 1;
            // 
            // txtSELECT_P
            // 
            this.txtSELECT_P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSELECT_P.Location = new System.Drawing.Point(0, 0);
            this.txtSELECT_P.Multiline = true;
            this.txtSELECT_P.Name = "txtSELECT_P";
            this.txtSELECT_P.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSELECT_P.Size = new System.Drawing.Size(1128, 605);
            this.txtSELECT_P.TabIndex = 1;
            // 
            // txtINSERT_P
            // 
            this.txtINSERT_P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtINSERT_P.Location = new System.Drawing.Point(0, 0);
            this.txtINSERT_P.Multiline = true;
            this.txtINSERT_P.Name = "txtINSERT_P";
            this.txtINSERT_P.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtINSERT_P.Size = new System.Drawing.Size(1128, 605);
            this.txtINSERT_P.TabIndex = 1;
            // 
            // txtUPDATE_P
            // 
            this.txtUPDATE_P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUPDATE_P.Location = new System.Drawing.Point(0, 0);
            this.txtUPDATE_P.Multiline = true;
            this.txtUPDATE_P.Name = "txtUPDATE_P";
            this.txtUPDATE_P.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUPDATE_P.Size = new System.Drawing.Size(1128, 605);
            this.txtUPDATE_P.TabIndex = 1;
            // 
            // txtDELETE_P
            // 
            this.txtDELETE_P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDELETE_P.Location = new System.Drawing.Point(0, 0);
            this.txtDELETE_P.Multiline = true;
            this.txtDELETE_P.Name = "txtDELETE_P";
            this.txtDELETE_P.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDELETE_P.Size = new System.Drawing.Size(1128, 605);
            this.txtDELETE_P.TabIndex = 1;
            // 
            // txtMERGE_P
            // 
            this.txtMERGE_P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMERGE_P.Location = new System.Drawing.Point(0, 0);
            this.txtMERGE_P.Multiline = true;
            this.txtMERGE_P.Name = "txtMERGE_P";
            this.txtMERGE_P.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMERGE_P.Size = new System.Drawing.Size(1128, 605);
            this.txtMERGE_P.TabIndex = 1;
            // 
            // txtRDB_SCHEMA
            // 
            this.txtRDB_SCHEMA.Location = new System.Drawing.Point(160, 8);
            this.txtRDB_SCHEMA.Name = "txtRDB_SCHEMA";
            this.txtRDB_SCHEMA.ReadOnly = true;
            this.txtRDB_SCHEMA.Size = new System.Drawing.Size(41, 21);
            this.txtRDB_SCHEMA.TabIndex = 11;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 950);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.panel4);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.HelpButton = true;
            this.Name = "frmMain";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CODE MAKER";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabTABLE.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvTABLE)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvColumn)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSample)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvIndexMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIndexDetail)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabSQL.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabSCRIPT.ResumeLayout(false);
            this.tabLOG.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.grpDIC.ResumeLayout(false);
            this.grpDIC.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.grpSetup.ResumeLayout(false);
            this.grpSetup.PerformLayout();
            this.tabQUERY.ResumeLayout(false);
            this.SELECT_Q.ResumeLayout(false);
            this.SELECT_Q.PerformLayout();
            this.INSERT_Q.ResumeLayout(false);
            this.INSERT_Q.PerformLayout();
            this.UPDATE_Q.ResumeLayout(false);
            this.UPDATE_Q.PerformLayout();
            this.DELETE_Q.ResumeLayout(false);
            this.DELETE_Q.PerformLayout();
            this.MERGE_Q.ResumeLayout(false);
            this.MERGE_Q.PerformLayout();
            this.SELECT_P.ResumeLayout(false);
            this.SELECT_P.PerformLayout();
            this.INSERT_P.ResumeLayout(false);
            this.INSERT_P.PerformLayout();
            this.UPDATE_P.ResumeLayout(false);
            this.UPDATE_P.PerformLayout();
            this.DELETE_P.ResumeLayout(false);
            this.DELETE_P.PerformLayout();
            this.MERGE_P.ResumeLayout(false);
            this.MERGE_P.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabSQL;
        private System.Windows.Forms.TabPage tabSCRIPT;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabTABLE;
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
        private System.Windows.Forms.GroupBox grpSetup;
        private System.Windows.Forms.GroupBox grpInfo;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.TextBox txtSP_Prefix;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.TextBox txtUser_Name;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TextBox txtSP_Affix;
        private System.Windows.Forms.TextBox txtSample_Cnt;
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTB_DESC;
        private System.Windows.Forms.Label Desc;
        private System.Windows.Forms.TextBox txtTB_NAME;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnTableSearch;
        private System.Windows.Forms.DataGridView gvTABLE;
        private System.Windows.Forms.GroupBox grpDIC;
        private System.Windows.Forms.TextBox txtDIR;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.Button btnDIR;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtLOG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TABLE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TABLE_COMMENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_ROWS;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialButton btnCode;
        private System.Windows.Forms.TextBox txtRDB_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView gvColumn;
        private System.Windows.Forms.DataGridView gvSample;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView gvIndexMaster;
        private System.Windows.Forms.DataGridView gvIndexDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_COMMENTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NULLABLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn INDEX_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn INDEX_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FILES;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn idxCOLUMN_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn idxCOLUMNS_COMMENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn idxCOLUMNS_DATA_TYPE;
        private System.Windows.Forms.TabControl tabQUERY;
        private System.Windows.Forms.TabPage SELECT_Q;
        private System.Windows.Forms.TabPage INSERT_Q;
        private System.Windows.Forms.TabPage UPDATE_Q;
        private System.Windows.Forms.TabPage DELETE_Q;
        private System.Windows.Forms.TabPage MERGE_Q;
        private System.Windows.Forms.TabPage SELECT_P;
        private System.Windows.Forms.TabPage INSERT_P;
        private System.Windows.Forms.TabPage UPDATE_P;
        private System.Windows.Forms.TabPage DELETE_P;
        private System.Windows.Forms.TabPage MERGE_P;
        private System.Windows.Forms.TextBox txtSELECT_Q;
        private System.Windows.Forms.TextBox txtINSERT_Q;
        private System.Windows.Forms.TextBox txtUPDATE_Q;
        private System.Windows.Forms.TextBox txtDELETE_Q;
        private System.Windows.Forms.TextBox txtMERGE_Q;
        private System.Windows.Forms.TextBox txtSELECT_P;
        private System.Windows.Forms.TextBox txtINSERT_P;
        private System.Windows.Forms.TextBox txtUPDATE_P;
        private System.Windows.Forms.TextBox txtDELETE_P;
        private System.Windows.Forms.TextBox txtMERGE_P;
        private System.Windows.Forms.TextBox txtRDB_SCHEMA;
    }
}

