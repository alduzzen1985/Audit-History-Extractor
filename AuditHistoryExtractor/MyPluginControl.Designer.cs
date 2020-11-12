namespace AuditHistoryExtractor
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPluginControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel9 = new System.Windows.Forms.Panel();
            this.grpPreview = new System.Windows.Forms.GroupBox();
            this.dtGrvPreview = new System.Windows.Forms.DataGridView();
            this.RecordId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrpPaging = new System.Windows.Forms.GroupBox();
            this.pnlPaging = new System.Windows.Forms.Panel();
            this.cmbNumberOfRecords = new System.Windows.Forms.ComboBox();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.tabOperations = new System.Windows.Forms.TabControl();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpFilterByFetchXml = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFetchXML = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.grpFilterByView = new System.Windows.Forms.GroupBox();
            this.chkPersonalView = new System.Windows.Forms.CheckBox();
            this.lblViews = new System.Windows.Forms.Label();
            this.cmbViews = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblField = new System.Windows.Forms.Label();
            this.cmbFields = new System.Windows.Forms.ComboBox();
            this.rdSpecificField = new System.Windows.Forms.RadioButton();
            this.rdAllFields = new System.Windows.Forms.RadioButton();
            this.grpFilterMethod = new System.Windows.Forms.GroupBox();
            this.chkEntitiesWithAudit = new System.Windows.Forms.CheckBox();
            this.lblAuditHistoryNotEnabled = new System.Windows.Forms.Label();
            this.cmbPrimaryKey = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFilterDataBy = new System.Windows.Forms.Label();
            this.rdbView = new System.Windows.Forms.RadioButton();
            this.lblEntities = new System.Windows.Forms.Label();
            this.rdbFetchXml = new System.Windows.Forms.RadioButton();
            this.cmbEntities = new System.Windows.Forms.ComboBox();
            this.tabFilter = new System.Windows.Forms.TabPage();
            this.grpBoxActions = new System.Windows.Forms.GroupBox();
            this.chkLstActions = new System.Windows.Forms.CheckedListBox();
            this.grpUsers = new System.Windows.Forms.GroupBox();
            this.lstSelectedUsers = new System.Windows.Forms.ListView();
            this.columnFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpOperationDateTime = new System.Windows.Forms.GroupBox();
            this.dtpTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.chkLstOperations = new System.Windows.Forms.CheckedListBox();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.dtGrvLogs = new System.Windows.Forms.DataGridView();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnExtractAuditHistory = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnClearUsers = new System.Windows.Forms.Button();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.btnClearTo = new System.Windows.Forms.Button();
            this.btnClearFrom = new System.Windows.Forms.Button();
            this.tbClose = new System.Windows.Forms.ToolStripButton();
            this.tbFromEntitiesEnabled = new System.Windows.Forms.ToolStripButton();
            this.tbOpenFetchXMLBuilder = new System.Windows.Forms.ToolStripButton();
            this.StatusImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.GuidRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordKeyValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordKeyValueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.logBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.grpPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrvPreview)).BeginInit();
            this.GrpPaging.SuspendLayout();
            this.pnlPaging.SuspendLayout();
            this.tabOperations.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpFilterByFetchXml.SuspendLayout();
            this.grpFilterByView.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpFilterMethod.SuspendLayout();
            this.tabFilter.SuspendLayout();
            this.grpBoxActions.SuspendLayout();
            this.grpUsers.SuspendLayout();
            this.grpOperationDateTime.SuspendLayout();
            this.grpOperations.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrvLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbClose,
            this.toolStripSeparator1,
            this.tbFromEntitiesEnabled,
            this.toolStripSeparator2,
            this.tbOpenFetchXMLBuilder});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1762, 38);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "Get Entities";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk_1);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.grpPreview);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(753, 38);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1009, 1554);
            this.panel9.TabIndex = 60;
            // 
            // grpPreview
            // 
            this.grpPreview.Controls.Add(this.dtGrvPreview);
            this.grpPreview.Controls.Add(this.GrpPaging);
            this.grpPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPreview.Location = new System.Drawing.Point(0, 0);
            this.grpPreview.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpPreview.Name = "grpPreview";
            this.grpPreview.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpPreview.Size = new System.Drawing.Size(1009, 1554);
            this.grpPreview.TabIndex = 51;
            this.grpPreview.TabStop = false;
            this.grpPreview.Text = "Preview";
            // 
            // dtGrvPreview
            // 
            this.dtGrvPreview.AutoGenerateColumns = false;
            this.dtGrvPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrvPreview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrvPreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrvPreview.ColumnHeadersHeight = 34;
            this.dtGrvPreview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordId,
            this.recordKeyValueDataGridViewTextBoxColumn,
            this.createdOnDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.operationDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn,
            this.attributeNameDataGridViewTextBoxColumn,
            this.oldValueDataGridViewTextBoxColumn,
            this.newValueDataGridViewTextBoxColumn});
            this.dtGrvPreview.DataSource = this.auditHistoryBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrvPreview.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrvPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrvPreview.Location = new System.Drawing.Point(3, 24);
            this.dtGrvPreview.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtGrvPreview.Name = "dtGrvPreview";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrvPreview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGrvPreview.RowHeadersWidth = 62;
            this.dtGrvPreview.RowTemplate.Height = 24;
            this.dtGrvPreview.Size = new System.Drawing.Size(1003, 1430);
            this.dtGrvPreview.TabIndex = 60;
            // 
            // RecordId
            // 
            this.RecordId.DataPropertyName = "RecordId";
            this.RecordId.HeaderText = "Object Id";
            this.RecordId.MinimumWidth = 8;
            this.RecordId.Name = "RecordId";
            // 
            // GrpPaging
            // 
            this.GrpPaging.Controls.Add(this.pnlPaging);
            this.GrpPaging.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrpPaging.Location = new System.Drawing.Point(3, 1454);
            this.GrpPaging.Name = "GrpPaging";
            this.GrpPaging.Size = new System.Drawing.Size(1003, 95);
            this.GrpPaging.TabIndex = 58;
            this.GrpPaging.TabStop = false;
            this.GrpPaging.Resize += new System.EventHandler(this.GrpPaging_Resize);
            // 
            // pnlPaging
            // 
            this.pnlPaging.Controls.Add(this.btnPrevious);
            this.pnlPaging.Controls.Add(this.btnNext);
            this.pnlPaging.Controls.Add(this.cmbNumberOfRecords);
            this.pnlPaging.Controls.Add(this.lblPage);
            this.pnlPaging.Controls.Add(this.lblPageNumber);
            this.pnlPaging.Location = new System.Drawing.Point(308, 28);
            this.pnlPaging.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPaging.Name = "pnlPaging";
            this.pnlPaging.Size = new System.Drawing.Size(387, 60);
            this.pnlPaging.TabIndex = 58;
            // 
            // cmbNumberOfRecords
            // 
            this.cmbNumberOfRecords.FormattingEnabled = true;
            this.cmbNumberOfRecords.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "75",
            "100"});
            this.cmbNumberOfRecords.Location = new System.Drawing.Point(186, 12);
            this.cmbNumberOfRecords.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbNumberOfRecords.Name = "cmbNumberOfRecords";
            this.cmbNumberOfRecords.Size = new System.Drawing.Size(74, 28);
            this.cmbNumberOfRecords.TabIndex = 53;
            this.cmbNumberOfRecords.Text = "10";
            this.cmbNumberOfRecords.SelectedIndexChanged += new System.EventHandler(this.cmbNumberOfRecords_SelectedIndexChanged);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(8, 17);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(58, 20);
            this.lblPage.TabIndex = 55;
            this.lblPage.Text = "Page : ";
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Location = new System.Drawing.Point(62, 18);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(18, 20);
            this.lblPageNumber.TabIndex = 56;
            this.lblPageNumber.Text = "1";
            // 
            // tabOperations
            // 
            this.tabOperations.Controls.Add(this.tabSearch);
            this.tabOperations.Controls.Add(this.tabFilter);
            this.tabOperations.Controls.Add(this.tabLogs);
            this.tabOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOperations.Location = new System.Drawing.Point(0, 0);
            this.tabOperations.Name = "tabOperations";
            this.tabOperations.SelectedIndex = 0;
            this.tabOperations.Size = new System.Drawing.Size(753, 1554);
            this.tabOperations.TabIndex = 51;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.panel1);
            this.tabSearch.Location = new System.Drawing.Point(4, 29);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabSearch.Size = new System.Drawing.Size(745, 1521);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpFilterByFetchXml);
            this.panel1.Controls.Add(this.grpFilterByView);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.grpFilterMethod);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 1515);
            this.panel1.TabIndex = 62;
            // 
            // grpFilterByFetchXml
            // 
            this.grpFilterByFetchXml.AutoSize = true;
            this.grpFilterByFetchXml.Controls.Add(this.label6);
            this.grpFilterByFetchXml.Controls.Add(this.label5);
            this.grpFilterByFetchXml.Controls.Add(this.txtFetchXML);
            this.grpFilterByFetchXml.Controls.Add(this.linkLabel1);
            this.grpFilterByFetchXml.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFilterByFetchXml.Location = new System.Drawing.Point(0, 554);
            this.grpFilterByFetchXml.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpFilterByFetchXml.Name = "grpFilterByFetchXml";
            this.grpFilterByFetchXml.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpFilterByFetchXml.Size = new System.Drawing.Size(739, 441);
            this.grpFilterByFetchXml.TabIndex = 57;
            this.grpFilterByFetchXml.TabStop = false;
            this.grpFilterByFetchXml.Text = "Filter Data with FetchXML";
            this.grpFilterByFetchXml.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "or using the FetchXML Builder Button";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "You can build your Fetch XML from here :";
            // 
            // txtFetchXML
            // 
            this.txtFetchXML.Location = new System.Drawing.Point(10, 60);
            this.txtFetchXML.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtFetchXML.Multiline = true;
            this.txtFetchXML.Name = "txtFetchXML";
            this.txtFetchXML.Size = new System.Drawing.Size(624, 352);
            this.txtFetchXML.TabIndex = 30;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(314, 35);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(44, 20);
            this.linkLabel1.TabIndex = 35;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LINK";
            // 
            // grpFilterByView
            // 
            this.grpFilterByView.Controls.Add(this.chkPersonalView);
            this.grpFilterByView.Controls.Add(this.lblViews);
            this.grpFilterByView.Controls.Add(this.cmbViews);
            this.grpFilterByView.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFilterByView.Location = new System.Drawing.Point(0, 414);
            this.grpFilterByView.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpFilterByView.Name = "grpFilterByView";
            this.grpFilterByView.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpFilterByView.Size = new System.Drawing.Size(739, 140);
            this.grpFilterByView.TabIndex = 55;
            this.grpFilterByView.TabStop = false;
            this.grpFilterByView.Text = "Filter by View";
            this.grpFilterByView.Visible = false;
            // 
            // chkPersonalView
            // 
            this.chkPersonalView.AutoSize = true;
            this.chkPersonalView.Location = new System.Drawing.Point(10, 40);
            this.chkPersonalView.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chkPersonalView.Name = "chkPersonalView";
            this.chkPersonalView.Size = new System.Drawing.Size(179, 24);
            this.chkPersonalView.TabIndex = 43;
            this.chkPersonalView.Text = "Show Personal View";
            this.chkPersonalView.UseVisualStyleBackColor = true;
            this.chkPersonalView.CheckedChanged += new System.EventHandler(this.chkPersonalView_CheckedChanged);
            // 
            // lblViews
            // 
            this.lblViews.AutoSize = true;
            this.lblViews.Location = new System.Drawing.Point(8, 85);
            this.lblViews.Name = "lblViews";
            this.lblViews.Size = new System.Drawing.Size(51, 20);
            this.lblViews.TabIndex = 39;
            this.lblViews.Text = "Views";
            // 
            // cmbViews
            // 
            this.cmbViews.FormattingEnabled = true;
            this.cmbViews.Location = new System.Drawing.Point(84, 85);
            this.cmbViews.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbViews.Name = "cmbViews";
            this.cmbViews.Size = new System.Drawing.Size(438, 28);
            this.cmbViews.TabIndex = 40;
            this.cmbViews.SelectedIndexChanged += new System.EventHandler(this.cmbViews_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblField);
            this.groupBox1.Controls.Add(this.cmbFields);
            this.groupBox1.Controls.Add(this.rdSpecificField);
            this.groupBox1.Controls.Add(this.rdAllFields);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 265);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(739, 149);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Audit History for";
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(8, 95);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(43, 20);
            this.lblField.TabIndex = 3;
            this.lblField.Text = "Field";
            this.lblField.Visible = false;
            // 
            // cmbFields
            // 
            this.cmbFields.FormattingEnabled = true;
            this.cmbFields.Location = new System.Drawing.Point(82, 95);
            this.cmbFields.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbFields.Name = "cmbFields";
            this.cmbFields.Size = new System.Drawing.Size(438, 28);
            this.cmbFields.TabIndex = 2;
            this.cmbFields.Visible = false;
            // 
            // rdSpecificField
            // 
            this.rdSpecificField.AutoSize = true;
            this.rdSpecificField.Location = new System.Drawing.Point(182, 45);
            this.rdSpecificField.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdSpecificField.Name = "rdSpecificField";
            this.rdSpecificField.Size = new System.Drawing.Size(160, 24);
            this.rdSpecificField.TabIndex = 1;
            this.rdSpecificField.Text = "Only specific Field";
            this.rdSpecificField.UseVisualStyleBackColor = true;
            this.rdSpecificField.CheckedChanged += new System.EventHandler(this.rdSpecificField_CheckedChanged);
            // 
            // rdAllFields
            // 
            this.rdAllFields.AutoSize = true;
            this.rdAllFields.Checked = true;
            this.rdAllFields.Location = new System.Drawing.Point(10, 45);
            this.rdAllFields.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdAllFields.Name = "rdAllFields";
            this.rdAllFields.Size = new System.Drawing.Size(163, 24);
            this.rdAllFields.TabIndex = 0;
            this.rdAllFields.TabStop = true;
            this.rdAllFields.Text = "All Fields changed";
            this.rdAllFields.UseVisualStyleBackColor = true;
            this.rdAllFields.CheckedChanged += new System.EventHandler(this.rdAllFields_CheckedChanged);
            // 
            // grpFilterMethod
            // 
            this.grpFilterMethod.Controls.Add(this.chkEntitiesWithAudit);
            this.grpFilterMethod.Controls.Add(this.lblAuditHistoryNotEnabled);
            this.grpFilterMethod.Controls.Add(this.cmbPrimaryKey);
            this.grpFilterMethod.Controls.Add(this.label1);
            this.grpFilterMethod.Controls.Add(this.lblFilterDataBy);
            this.grpFilterMethod.Controls.Add(this.rdbView);
            this.grpFilterMethod.Controls.Add(this.lblEntities);
            this.grpFilterMethod.Controls.Add(this.rdbFetchXml);
            this.grpFilterMethod.Controls.Add(this.cmbEntities);
            this.grpFilterMethod.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFilterMethod.Location = new System.Drawing.Point(0, 0);
            this.grpFilterMethod.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpFilterMethod.Name = "grpFilterMethod";
            this.grpFilterMethod.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpFilterMethod.Size = new System.Drawing.Size(739, 265);
            this.grpFilterMethod.TabIndex = 53;
            this.grpFilterMethod.TabStop = false;
            this.grpFilterMethod.Text = "Filter Method";
            // 
            // chkEntitiesWithAudit
            // 
            this.chkEntitiesWithAudit.AutoSize = true;
            this.chkEntitiesWithAudit.Checked = true;
            this.chkEntitiesWithAudit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEntitiesWithAudit.Location = new System.Drawing.Point(10, 38);
            this.chkEntitiesWithAudit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chkEntitiesWithAudit.Name = "chkEntitiesWithAudit";
            this.chkEntitiesWithAudit.Size = new System.Drawing.Size(246, 24);
            this.chkEntitiesWithAudit.TabIndex = 48;
            this.chkEntitiesWithAudit.Text = "Show Only with Audit Enabled";
            this.chkEntitiesWithAudit.UseVisualStyleBackColor = true;
            this.chkEntitiesWithAudit.CheckedChanged += new System.EventHandler(this.chkEntitiesWithAudit_CheckedChanged);
            // 
            // lblAuditHistoryNotEnabled
            // 
            this.lblAuditHistoryNotEnabled.AutoSize = true;
            this.lblAuditHistoryNotEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuditHistoryNotEnabled.ForeColor = System.Drawing.Color.Red;
            this.lblAuditHistoryNotEnabled.Location = new System.Drawing.Point(6, 122);
            this.lblAuditHistoryNotEnabled.Name = "lblAuditHistoryNotEnabled";
            this.lblAuditHistoryNotEnabled.Size = new System.Drawing.Size(212, 20);
            this.lblAuditHistoryNotEnabled.TabIndex = 47;
            this.lblAuditHistoryNotEnabled.Text = "Audit History not enabled";
            this.lblAuditHistoryNotEnabled.Visible = false;
            // 
            // cmbPrimaryKey
            // 
            this.cmbPrimaryKey.FormattingEnabled = true;
            this.cmbPrimaryKey.Location = new System.Drawing.Point(171, 163);
            this.cmbPrimaryKey.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbPrimaryKey.Name = "cmbPrimaryKey";
            this.cmbPrimaryKey.Size = new System.Drawing.Size(462, 28);
            this.cmbPrimaryKey.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Primary Key Field";
            // 
            // lblFilterDataBy
            // 
            this.lblFilterDataBy.AutoSize = true;
            this.lblFilterDataBy.Location = new System.Drawing.Point(8, 209);
            this.lblFilterDataBy.Name = "lblFilterDataBy";
            this.lblFilterDataBy.Size = new System.Drawing.Size(137, 20);
            this.lblFilterDataBy.TabIndex = 46;
            this.lblFilterDataBy.Text = "Filter Data using : ";
            // 
            // rdbView
            // 
            this.rdbView.AutoSize = true;
            this.rdbView.Location = new System.Drawing.Point(164, 208);
            this.rdbView.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdbView.Name = "rdbView";
            this.rdbView.Size = new System.Drawing.Size(68, 24);
            this.rdbView.TabIndex = 43;
            this.rdbView.TabStop = true;
            this.rdbView.Text = "View";
            this.rdbView.UseVisualStyleBackColor = true;
            this.rdbView.CheckedChanged += new System.EventHandler(this.rdbView_CheckedChanged);
            // 
            // lblEntities
            // 
            this.lblEntities.AutoSize = true;
            this.lblEntities.Location = new System.Drawing.Point(8, 82);
            this.lblEntities.Name = "lblEntities";
            this.lblEntities.Size = new System.Drawing.Size(49, 20);
            this.lblEntities.TabIndex = 41;
            this.lblEntities.Text = "Entity";
            // 
            // rdbFetchXml
            // 
            this.rdbFetchXml.AutoSize = true;
            this.rdbFetchXml.Location = new System.Drawing.Point(240, 208);
            this.rdbFetchXml.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdbFetchXml.Name = "rdbFetchXml";
            this.rdbFetchXml.Size = new System.Drawing.Size(108, 24);
            this.rdbFetchXml.TabIndex = 44;
            this.rdbFetchXml.TabStop = true;
            this.rdbFetchXml.Text = "FetchXML";
            this.rdbFetchXml.UseVisualStyleBackColor = true;
            this.rdbFetchXml.CheckedChanged += new System.EventHandler(this.rdbFetchXml_CheckedChanged);
            // 
            // cmbEntities
            // 
            this.cmbEntities.FormattingEnabled = true;
            this.cmbEntities.Location = new System.Drawing.Point(171, 78);
            this.cmbEntities.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbEntities.Name = "cmbEntities";
            this.cmbEntities.Size = new System.Drawing.Size(462, 28);
            this.cmbEntities.TabIndex = 42;
            this.cmbEntities.SelectedIndexChanged += new System.EventHandler(this.cmbEntities_SelectedIndexChanged);
            // 
            // tabFilter
            // 
            this.tabFilter.Controls.Add(this.grpBoxActions);
            this.tabFilter.Controls.Add(this.grpUsers);
            this.tabFilter.Controls.Add(this.grpOperationDateTime);
            this.tabFilter.Controls.Add(this.grpOperations);
            this.tabFilter.Location = new System.Drawing.Point(4, 29);
            this.tabFilter.Name = "tabFilter";
            this.tabFilter.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabFilter.Size = new System.Drawing.Size(745, 1521);
            this.tabFilter.TabIndex = 1;
            this.tabFilter.Text = "Filter";
            this.tabFilter.UseVisualStyleBackColor = true;
            // 
            // grpBoxActions
            // 
            this.grpBoxActions.Controls.Add(this.chkLstActions);
            this.grpBoxActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBoxActions.Location = new System.Drawing.Point(3, 587);
            this.grpBoxActions.Name = "grpBoxActions";
            this.grpBoxActions.Size = new System.Drawing.Size(739, 695);
            this.grpBoxActions.TabIndex = 61;
            this.grpBoxActions.TabStop = false;
            this.grpBoxActions.Text = "Actions";
            // 
            // chkLstActions
            // 
            this.chkLstActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkLstActions.FormattingEnabled = true;
            this.chkLstActions.Location = new System.Drawing.Point(3, 22);
            this.chkLstActions.Name = "chkLstActions";
            this.chkLstActions.Size = new System.Drawing.Size(733, 670);
            this.chkLstActions.TabIndex = 0;
            // 
            // grpUsers
            // 
            this.grpUsers.Controls.Add(this.btnRemoveUser);
            this.grpUsers.Controls.Add(this.btnClearUsers);
            this.grpUsers.Controls.Add(this.lstSelectedUsers);
            this.grpUsers.Controls.Add(this.btnAddUsers);
            this.grpUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpUsers.Location = new System.Drawing.Point(3, 296);
            this.grpUsers.Name = "grpUsers";
            this.grpUsers.Size = new System.Drawing.Size(739, 291);
            this.grpUsers.TabIndex = 60;
            this.grpUsers.TabStop = false;
            this.grpUsers.Text = "Users";
            // 
            // lstSelectedUsers
            // 
            this.lstSelectedUsers.CheckBoxes = true;
            this.lstSelectedUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFullName,
            this.columnUserName});
            this.lstSelectedUsers.HideSelection = false;
            this.lstSelectedUsers.Location = new System.Drawing.Point(8, 37);
            this.lstSelectedUsers.Name = "lstSelectedUsers";
            this.lstSelectedUsers.Size = new System.Drawing.Size(690, 195);
            this.lstSelectedUsers.TabIndex = 1;
            this.lstSelectedUsers.UseCompatibleStateImageBehavior = false;
            this.lstSelectedUsers.View = System.Windows.Forms.View.Details;
            this.lstSelectedUsers.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstSelectedUsers_ItemChecked);
            // 
            // columnFullName
            // 
            this.columnFullName.Text = "Full Name";
            this.columnFullName.Width = 200;
            // 
            // columnUserName
            // 
            this.columnUserName.Text = "UserName";
            this.columnUserName.Width = 239;
            // 
            // grpOperationDateTime
            // 
            this.grpOperationDateTime.Controls.Add(this.btnClearTo);
            this.grpOperationDateTime.Controls.Add(this.btnClearFrom);
            this.grpOperationDateTime.Controls.Add(this.dtpTimeTo);
            this.grpOperationDateTime.Controls.Add(this.dtpDateTo);
            this.grpOperationDateTime.Controls.Add(this.lblTo);
            this.grpOperationDateTime.Controls.Add(this.dtpTimeFrom);
            this.grpOperationDateTime.Controls.Add(this.dtpDateFrom);
            this.grpOperationDateTime.Controls.Add(this.lblFromDate);
            this.grpOperationDateTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpOperationDateTime.Location = new System.Drawing.Point(3, 151);
            this.grpOperationDateTime.Name = "grpOperationDateTime";
            this.grpOperationDateTime.Size = new System.Drawing.Size(739, 145);
            this.grpOperationDateTime.TabIndex = 59;
            this.grpOperationDateTime.TabStop = false;
            this.grpOperationDateTime.Text = "Operation Date & Time";
            // 
            // dtpTimeTo
            // 
            this.dtpTimeTo.CustomFormat = " ";
            this.dtpTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeTo.Location = new System.Drawing.Point(315, 82);
            this.dtpTimeTo.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpTimeTo.Name = "dtpTimeTo";
            this.dtpTimeTo.ShowUpDown = true;
            this.dtpTimeTo.Size = new System.Drawing.Size(104, 26);
            this.dtpTimeTo.TabIndex = 5;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = " ";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(112, 80);
            this.dtpDateTo.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(198, 26);
            this.dtpDateTo.TabIndex = 4;
            this.dtpDateTo.ValueChanged += new System.EventHandler(this.dtpDateTo_ValueChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(15, 78);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(27, 20);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "To";
            // 
            // dtpTimeFrom
            // 
            this.dtpTimeFrom.CustomFormat = " ";
            this.dtpTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeFrom.Location = new System.Drawing.Point(315, 32);
            this.dtpTimeFrom.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpTimeFrom.Name = "dtpTimeFrom";
            this.dtpTimeFrom.ShowUpDown = true;
            this.dtpTimeFrom.Size = new System.Drawing.Size(104, 26);
            this.dtpTimeFrom.TabIndex = 2;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = " ";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(112, 32);
            this.dtpDateFrom.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(198, 26);
            this.dtpDateFrom.TabIndex = 1;
            this.dtpDateFrom.ValueChanged += new System.EventHandler(this.dtpDateFrom_ValueChanged);
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(16, 34);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(50, 20);
            this.lblFromDate.TabIndex = 0;
            this.lblFromDate.Text = "From ";
            // 
            // grpOperations
            // 
            this.grpOperations.Controls.Add(this.chkLstOperations);
            this.grpOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpOperations.Location = new System.Drawing.Point(3, 3);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Size = new System.Drawing.Size(739, 148);
            this.grpOperations.TabIndex = 58;
            this.grpOperations.TabStop = false;
            this.grpOperations.Text = "Operation Types";
            // 
            // chkLstOperations
            // 
            this.chkLstOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkLstOperations.FormattingEnabled = true;
            this.chkLstOperations.HorizontalScrollbar = true;
            this.chkLstOperations.Location = new System.Drawing.Point(3, 22);
            this.chkLstOperations.Name = "chkLstOperations";
            this.chkLstOperations.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkLstOperations.Size = new System.Drawing.Size(733, 123);
            this.chkLstOperations.TabIndex = 0;
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnClearFilters);
            this.grpActions.Controls.Add(this.btnApplyFilters);
            this.grpActions.Controls.Add(this.btnPreview);
            this.grpActions.Controls.Add(this.btnExtractAuditHistory);
            this.grpActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpActions.Location = new System.Drawing.Point(0, 1456);
            this.grpActions.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpActions.Name = "grpActions";
            this.grpActions.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpActions.Size = new System.Drawing.Size(753, 98);
            this.grpActions.TabIndex = 54;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            this.grpActions.Visible = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.grpActions);
            this.panel8.Controls.Add(this.tabOperations);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 38);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(753, 1554);
            this.panel8.TabIndex = 59;
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.dtGrvLogs);
            this.tabLogs.Location = new System.Drawing.Point(4, 29);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogs.Size = new System.Drawing.Size(745, 1521);
            this.tabLogs.TabIndex = 2;
            this.tabLogs.Text = "Logs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // dtGrvLogs
            // 
            this.dtGrvLogs.AllowUserToAddRows = false;
            this.dtGrvLogs.AllowUserToDeleteRows = false;
            this.dtGrvLogs.AutoGenerateColumns = false;
            this.dtGrvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGrvLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtGrvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StatusImage,
            this.infoLog,
            this.GuidRecord,
            this.recordKeyValueDataGridViewTextBoxColumn1,
            this.messageDataGridViewTextBoxColumn});
            this.dtGrvLogs.DataSource = this.logBindingSource1;
            this.dtGrvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrvLogs.Location = new System.Drawing.Point(3, 3);
            this.dtGrvLogs.Name = "dtGrvLogs";
            this.dtGrvLogs.ReadOnly = true;
            this.dtGrvLogs.RowHeadersWidth = 62;
            this.dtGrvLogs.RowTemplate.Height = 28;
            this.dtGrvLogs.Size = new System.Drawing.Size(739, 1515);
            this.dtGrvLogs.TabIndex = 0;
            this.dtGrvLogs.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.drGrwLogs_DataBindingComplete);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Image = global::AuditHistoryExtractor.Properties.Resources.back;
            this.btnPrevious.Location = new System.Drawing.Point(96, 6);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(84, 48);
            this.btnPrevious.TabIndex = 52;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Image = global::AuditHistoryExtractor.Properties.Resources.next;
            this.btnNext.Location = new System.Drawing.Point(268, 6);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(84, 48);
            this.btnNext.TabIndex = 54;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Image = global::AuditHistoryExtractor.Properties.Resources.removeFilter;
            this.btnClearFilters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearFilters.Location = new System.Drawing.Point(556, 32);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(184, 48);
            this.btnClearFilters.TabIndex = 32;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.Image = global::AuditHistoryExtractor.Properties.Resources.addFilter;
            this.btnApplyFilters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplyFilters.Location = new System.Drawing.Point(376, 32);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new System.Drawing.Size(174, 48);
            this.btnApplyFilters.TabIndex = 31;
            this.btnApplyFilters.Text = "Apply Filters";
            this.btnApplyFilters.UseVisualStyleBackColor = true;
            this.btnApplyFilters.Click += new System.EventHandler(this.btnApplyFilters_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Image = global::AuditHistoryExtractor.Properties.Resources.preview24x24;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.Location = new System.Drawing.Point(12, 32);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(174, 48);
            this.btnPreview.TabIndex = 30;
            this.btnPreview.Text = "Preview Data";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnExtractAuditHistory
            // 
            this.btnExtractAuditHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnExtractAuditHistory.Image")));
            this.btnExtractAuditHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtractAuditHistory.Location = new System.Drawing.Point(189, 32);
            this.btnExtractAuditHistory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnExtractAuditHistory.Name = "btnExtractAuditHistory";
            this.btnExtractAuditHistory.Size = new System.Drawing.Size(182, 48);
            this.btnExtractAuditHistory.TabIndex = 29;
            this.btnExtractAuditHistory.Text = "  Export to CSV";
            this.btnExtractAuditHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExtractAuditHistory.UseMnemonic = false;
            this.btnExtractAuditHistory.UseVisualStyleBackColor = true;
            this.btnExtractAuditHistory.Click += new System.EventHandler(this.btnExtractAuditHistory_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Enabled = false;
            this.btnRemoveUser.Image = global::AuditHistoryExtractor.Properties.Resources.removeUser22;
            this.btnRemoveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveUser.Location = new System.Drawing.Point(194, 237);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(200, 48);
            this.btnRemoveUser.TabIndex = 3;
            this.btnRemoveUser.Text = "Remove Users";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnClearUsers
            // 
            this.btnClearUsers.Image = global::AuditHistoryExtractor.Properties.Resources.clear241;
            this.btnClearUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearUsers.Location = new System.Drawing.Point(400, 237);
            this.btnClearUsers.Name = "btnClearUsers";
            this.btnClearUsers.Size = new System.Drawing.Size(176, 48);
            this.btnClearUsers.TabIndex = 2;
            this.btnClearUsers.Text = "Clear Users";
            this.btnClearUsers.UseVisualStyleBackColor = true;
            this.btnClearUsers.Click += new System.EventHandler(this.btnClearUsers_Click);
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.Image = global::AuditHistoryExtractor.Properties.Resources.addUser22;
            this.btnAddUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUsers.Location = new System.Drawing.Point(8, 237);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(180, 48);
            this.btnAddUsers.TabIndex = 0;
            this.btnAddUsers.Text = "Add Users";
            this.btnAddUsers.UseVisualStyleBackColor = true;
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUsers_Click);
            // 
            // btnClearTo
            // 
            this.btnClearTo.Image = global::AuditHistoryExtractor.Properties.Resources.clear24;
            this.btnClearTo.Location = new System.Drawing.Point(440, 78);
            this.btnClearTo.Name = "btnClearTo";
            this.btnClearTo.Size = new System.Drawing.Size(48, 34);
            this.btnClearTo.TabIndex = 7;
            this.btnClearTo.UseVisualStyleBackColor = true;
            this.btnClearTo.Click += new System.EventHandler(this.btnClearTo_Click);
            // 
            // btnClearFrom
            // 
            this.btnClearFrom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClearFrom.Image = global::AuditHistoryExtractor.Properties.Resources.clear24;
            this.btnClearFrom.Location = new System.Drawing.Point(440, 28);
            this.btnClearFrom.Name = "btnClearFrom";
            this.btnClearFrom.Size = new System.Drawing.Size(48, 34);
            this.btnClearFrom.TabIndex = 6;
            this.btnClearFrom.UseVisualStyleBackColor = true;
            this.btnClearFrom.Click += new System.EventHandler(this.btnClearFrom_Click);
            // 
            // tbClose
            // 
            this.tbClose.Image = ((System.Drawing.Image)(resources.GetObject("tbClose.Image")));
            this.tbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbClose.Name = "tbClose";
            this.tbClose.Size = new System.Drawing.Size(79, 33);
            this.tbClose.Text = "Close";
            this.tbClose.Click += new System.EventHandler(this.tbClose_Click);
            // 
            // tbFromEntitiesEnabled
            // 
            this.tbFromEntitiesEnabled.Image = ((System.Drawing.Image)(resources.GetObject("tbFromEntitiesEnabled.Image")));
            this.tbFromEntitiesEnabled.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbFromEntitiesEnabled.Name = "tbFromEntitiesEnabled";
            this.tbFromEntitiesEnabled.Size = new System.Drawing.Size(124, 33);
            this.tbFromEntitiesEnabled.Text = "Get Entities";
            this.tbFromEntitiesEnabled.ToolTipText = "Get Entities with Audit Enabled";
            this.tbFromEntitiesEnabled.Click += new System.EventHandler(this.tbFromEntitiesEnabled_Click);
            // 
            // tbOpenFetchXMLBuilder
            // 
            this.tbOpenFetchXMLBuilder.Image = ((System.Drawing.Image)(resources.GetObject("tbOpenFetchXMLBuilder.Image")));
            this.tbOpenFetchXMLBuilder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbOpenFetchXMLBuilder.Name = "tbOpenFetchXMLBuilder";
            this.tbOpenFetchXMLBuilder.Size = new System.Drawing.Size(324, 29);
            this.tbOpenFetchXMLBuilder.Text = "Create Query from FetchXML Builder";
            this.tbOpenFetchXMLBuilder.Visible = false;
            this.tbOpenFetchXMLBuilder.Click += new System.EventHandler(this.tbOpenFetchXMLBuilder_Click);
            // 
            // StatusImage
            // 
            this.StatusImage.HeaderText = "";
            this.StatusImage.MinimumWidth = 8;
            this.StatusImage.Name = "StatusImage";
            this.StatusImage.ReadOnly = true;
            this.StatusImage.Width = 8;
            // 
            // GuidRecord
            // 
            this.GuidRecord.DataPropertyName = "recordId";
            this.GuidRecord.HeaderText = "Guid";
            this.GuidRecord.MinimumWidth = 8;
            this.GuidRecord.Name = "GuidRecord";
            this.GuidRecord.ReadOnly = true;
            this.GuidRecord.Width = 79;
            // 
            // recordKeyValueDataGridViewTextBoxColumn
            // 
            this.recordKeyValueDataGridViewTextBoxColumn.DataPropertyName = "RecordKeyValue";
            this.recordKeyValueDataGridViewTextBoxColumn.HeaderText = "RecordKeyValue";
            this.recordKeyValueDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.recordKeyValueDataGridViewTextBoxColumn.Name = "recordKeyValueDataGridViewTextBoxColumn";
            // 
            // createdOnDataGridViewTextBoxColumn
            // 
            this.createdOnDataGridViewTextBoxColumn.DataPropertyName = "CreatedOn";
            this.createdOnDataGridViewTextBoxColumn.HeaderText = "CreatedOn";
            this.createdOnDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.createdOnDataGridViewTextBoxColumn.Name = "createdOnDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // operationDataGridViewTextBoxColumn
            // 
            this.operationDataGridViewTextBoxColumn.DataPropertyName = "Operation";
            this.operationDataGridViewTextBoxColumn.HeaderText = "Operation";
            this.operationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.operationDataGridViewTextBoxColumn.Name = "operationDataGridViewTextBoxColumn";
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Action";
            this.actionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            // 
            // attributeNameDataGridViewTextBoxColumn
            // 
            this.attributeNameDataGridViewTextBoxColumn.DataPropertyName = "AttributeName";
            this.attributeNameDataGridViewTextBoxColumn.HeaderText = "AttributeName";
            this.attributeNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.attributeNameDataGridViewTextBoxColumn.Name = "attributeNameDataGridViewTextBoxColumn";
            // 
            // oldValueDataGridViewTextBoxColumn
            // 
            this.oldValueDataGridViewTextBoxColumn.DataPropertyName = "OldValue";
            this.oldValueDataGridViewTextBoxColumn.HeaderText = "OldValue";
            this.oldValueDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.oldValueDataGridViewTextBoxColumn.Name = "oldValueDataGridViewTextBoxColumn";
            // 
            // newValueDataGridViewTextBoxColumn
            // 
            this.newValueDataGridViewTextBoxColumn.DataPropertyName = "NewValue";
            this.newValueDataGridViewTextBoxColumn.HeaderText = "NewValue";
            this.newValueDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.newValueDataGridViewTextBoxColumn.Name = "newValueDataGridViewTextBoxColumn";
            // 
            // auditHistoryBindingSource
            // 
            this.auditHistoryBindingSource.DataSource = typeof(AuditHistoryExtractor.Classes.AuditHistory);
            // 
            // infoLog
            // 
            this.infoLog.DataPropertyName = "infoLog";
            this.infoLog.HeaderText = "infoLog";
            this.infoLog.MinimumWidth = 8;
            this.infoLog.Name = "infoLog";
            this.infoLog.ReadOnly = true;
            this.infoLog.Visible = false;
            this.infoLog.Width = 98;
            // 
            // recordKeyValueDataGridViewTextBoxColumn1
            // 
            this.recordKeyValueDataGridViewTextBoxColumn1.DataPropertyName = "RecordKeyValue";
            this.recordKeyValueDataGridViewTextBoxColumn1.HeaderText = "Record Key Value";
            this.recordKeyValueDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.recordKeyValueDataGridViewTextBoxColumn1.Name = "recordKeyValueDataGridViewTextBoxColumn1";
            this.recordKeyValueDataGridViewTextBoxColumn1.ReadOnly = true;
            this.recordKeyValueDataGridViewTextBoxColumn1.Width = 121;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "Message";
            this.messageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            this.messageDataGridViewTextBoxColumn.ReadOnly = true;
            this.messageDataGridViewTextBoxColumn.Width = 110;
            // 
            // logBindingSource1
            // 
            this.logBindingSource1.DataSource = typeof(AuditHistoryExtractor.Classes.Models.Log);
            // 
            // logBindingSource
            // 
            this.logBindingSource.DataSource = typeof(AuditHistoryExtractor.Classes.Models.Log);
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(1762, 1592);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.grpPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrvPreview)).EndInit();
            this.GrpPaging.ResumeLayout(false);
            this.pnlPaging.ResumeLayout(false);
            this.pnlPaging.PerformLayout();
            this.tabOperations.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpFilterByFetchXml.ResumeLayout(false);
            this.grpFilterByFetchXml.PerformLayout();
            this.grpFilterByView.ResumeLayout(false);
            this.grpFilterByView.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpFilterMethod.ResumeLayout(false);
            this.grpFilterMethod.PerformLayout();
            this.tabFilter.ResumeLayout(false);
            this.grpBoxActions.ResumeLayout(false);
            this.grpUsers.ResumeLayout(false);
            this.grpOperationDateTime.ResumeLayout(false);
            this.grpOperationDateTime.PerformLayout();
            this.grpOperations.ResumeLayout(false);
            this.grpActions.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.tabLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrvLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbFromEntitiesEnabled;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton tbOpenFetchXMLBuilder;
        private System.Windows.Forms.BindingSource auditHistoryBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.GroupBox grpPreview;
        private System.Windows.Forms.DataGridView dtGrvPreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordId;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordKeyValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabOperations;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpFilterByFetchXml;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFetchXML;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox grpFilterByView;
        private System.Windows.Forms.CheckBox chkPersonalView;
        private System.Windows.Forms.Label lblViews;
        private System.Windows.Forms.ComboBox cmbViews;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.ComboBox cmbFields;
        private System.Windows.Forms.RadioButton rdSpecificField;
        private System.Windows.Forms.RadioButton rdAllFields;
        private System.Windows.Forms.GroupBox grpFilterMethod;
        private System.Windows.Forms.CheckBox chkEntitiesWithAudit;
        private System.Windows.Forms.Label lblAuditHistoryNotEnabled;
        private System.Windows.Forms.ComboBox cmbPrimaryKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFilterDataBy;
        private System.Windows.Forms.RadioButton rdbView;
        private System.Windows.Forms.Label lblEntities;
        private System.Windows.Forms.RadioButton rdbFetchXml;
        private System.Windows.Forms.ComboBox cmbEntities;
        private System.Windows.Forms.TabPage tabFilter;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.CheckedListBox chkLstOperations;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnExtractAuditHistory;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox grpOperationDateTime;
        private System.Windows.Forms.DateTimePicker dtpTimeFrom;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpTimeTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnClearFrom;
        private System.Windows.Forms.GroupBox grpUsers;
        private System.Windows.Forms.ListView lstSelectedUsers;
        private System.Windows.Forms.ColumnHeader columnFullName;
        private System.Windows.Forms.ColumnHeader columnUserName;
        private System.Windows.Forms.Button btnAddUsers;
        private System.Windows.Forms.GroupBox grpBoxActions;
        private System.Windows.Forms.CheckedListBox chkLstActions;
        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.Button btnClearTo;
        private System.Windows.Forms.Button btnClearUsers;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.GroupBox GrpPaging;
        private System.Windows.Forms.Panel pnlPaging;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cmbNumberOfRecords;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.DataGridView dtGrvLogs;
        private System.Windows.Forms.BindingSource logBindingSource;
        private System.Windows.Forms.BindingSource logBindingSource1;
        private System.Windows.Forms.DataGridViewImageColumn StatusImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuidRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordKeyValueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
    }
}
