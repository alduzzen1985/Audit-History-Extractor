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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPluginControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbFromEntitiesEnabled = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbOpenFetchXMLBuilder = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel9 = new System.Windows.Forms.Panel();
            this.grpPreview = new System.Windows.Forms.GroupBox();
            this.dtGrvPreview = new System.Windows.Forms.DataGridView();
            this.RecordId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordKeyValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GrpPaging = new System.Windows.Forms.GroupBox();
            this.pnlPaging = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
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
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.chkLstOperations = new System.Windows.Forms.CheckedListBox();
            this.grpOperationDateTime = new System.Windows.Forms.GroupBox();
            this.btnClearTo = new System.Windows.Forms.Button();
            this.btnClearFrom = new System.Windows.Forms.Button();
            this.dtpTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.tabUserFilters = new System.Windows.Forms.TabPage();
            this.lstViewUsers = new System.Windows.Forms.ListView();
            this.clmFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlSearchUsers = new System.Windows.Forms.Panel();
            this.lnkSelectUsersAll = new System.Windows.Forms.LinkLabel();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.lblNameUsername = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.tabAttributeFilters = new System.Windows.Forms.TabPage();
            this.pnlListAttributes = new System.Windows.Forms.Panel();
            this.lstAttributes = new System.Windows.Forms.ListView();
            this.clmHdrDisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHdrLogicalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHdrType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lnkSelectAttributesAll = new System.Windows.Forms.LinkLabel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchAttribute = new System.Windows.Forms.TextBox();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.pnlLogResult = new System.Windows.Forms.Panel();
            this.dtGrvLogs = new System.Windows.Forms.DataGridView();
            this.StatusImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.infoLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuidRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordKeyValueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkShowGuid = new System.Windows.Forms.CheckBox();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnExtractAuditHistory = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.logBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.grpPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrvPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditHistoryBindingSource)).BeginInit();
            this.GrpPaging.SuspendLayout();
            this.pnlPaging.SuspendLayout();
            this.tabOperations.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpFilterByFetchXml.SuspendLayout();
            this.grpFilterByView.SuspendLayout();
            this.grpFilterMethod.SuspendLayout();
            this.tabFilter.SuspendLayout();
            this.grpBoxActions.SuspendLayout();
            this.grpOperations.SuspendLayout();
            this.grpOperationDateTime.SuspendLayout();
            this.tabUserFilters.SuspendLayout();
            this.pnlSearchUsers.SuspendLayout();
            this.tabAttributeFilters.SuspendLayout();
            this.pnlListAttributes.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.tabLogs.SuspendLayout();
            this.pnlLogResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrvLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.panel8.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1762, 34);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "Get Entities";
            // 
            // tbClose
            // 
            this.tbClose.Image = ((System.Drawing.Image)(resources.GetObject("tbClose.Image")));
            this.tbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbClose.Name = "tbClose";
            this.tbClose.Size = new System.Drawing.Size(79, 29);
            this.tbClose.Text = "Close";
            this.tbClose.Click += new System.EventHandler(this.tbClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // tbFromEntitiesEnabled
            // 
            this.tbFromEntitiesEnabled.Image = ((System.Drawing.Image)(resources.GetObject("tbFromEntitiesEnabled.Image")));
            this.tbFromEntitiesEnabled.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbFromEntitiesEnabled.Name = "tbFromEntitiesEnabled";
            this.tbFromEntitiesEnabled.Size = new System.Drawing.Size(124, 29);
            this.tbFromEntitiesEnabled.Text = "Get Entities";
            this.tbFromEntitiesEnabled.ToolTipText = "Get Entities with Audit Enabled";
            this.tbFromEntitiesEnabled.Click += new System.EventHandler(this.tbFromEntitiesEnabled_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
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
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk_1);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.grpPreview);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(753, 34);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1009, 1558);
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
            this.grpPreview.Size = new System.Drawing.Size(1009, 1558);
            this.grpPreview.TabIndex = 51;
            this.grpPreview.TabStop = false;
            this.grpPreview.Text = "Preview";
            // 
            // dtGrvPreview
            // 
            this.dtGrvPreview.AllowUserToAddRows = false;
            this.dtGrvPreview.AllowUserToDeleteRows = false;
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
            this.dtGrvPreview.ReadOnly = true;
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
            this.dtGrvPreview.Size = new System.Drawing.Size(1003, 1434);
            this.dtGrvPreview.TabIndex = 60;
            // 
            // RecordId
            // 
            this.RecordId.DataPropertyName = "RecordId";
            this.RecordId.HeaderText = "Object Id";
            this.RecordId.MinimumWidth = 8;
            this.RecordId.Name = "RecordId";
            this.RecordId.ReadOnly = true;
            // 
            // recordKeyValueDataGridViewTextBoxColumn
            // 
            this.recordKeyValueDataGridViewTextBoxColumn.DataPropertyName = "RecordKeyValue";
            this.recordKeyValueDataGridViewTextBoxColumn.HeaderText = "RecordKeyValue";
            this.recordKeyValueDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.recordKeyValueDataGridViewTextBoxColumn.Name = "recordKeyValueDataGridViewTextBoxColumn";
            this.recordKeyValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdOnDataGridViewTextBoxColumn
            // 
            this.createdOnDataGridViewTextBoxColumn.DataPropertyName = "CreatedOn";
            this.createdOnDataGridViewTextBoxColumn.HeaderText = "CreatedOn";
            this.createdOnDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.createdOnDataGridViewTextBoxColumn.Name = "createdOnDataGridViewTextBoxColumn";
            this.createdOnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operationDataGridViewTextBoxColumn
            // 
            this.operationDataGridViewTextBoxColumn.DataPropertyName = "Operation";
            this.operationDataGridViewTextBoxColumn.HeaderText = "Operation";
            this.operationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.operationDataGridViewTextBoxColumn.Name = "operationDataGridViewTextBoxColumn";
            this.operationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Action";
            this.actionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            this.actionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attributeNameDataGridViewTextBoxColumn
            // 
            this.attributeNameDataGridViewTextBoxColumn.DataPropertyName = "AttributeName";
            this.attributeNameDataGridViewTextBoxColumn.HeaderText = "AttributeName";
            this.attributeNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.attributeNameDataGridViewTextBoxColumn.Name = "attributeNameDataGridViewTextBoxColumn";
            this.attributeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oldValueDataGridViewTextBoxColumn
            // 
            this.oldValueDataGridViewTextBoxColumn.DataPropertyName = "OldValue";
            this.oldValueDataGridViewTextBoxColumn.HeaderText = "OldValue";
            this.oldValueDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.oldValueDataGridViewTextBoxColumn.Name = "oldValueDataGridViewTextBoxColumn";
            this.oldValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // newValueDataGridViewTextBoxColumn
            // 
            this.newValueDataGridViewTextBoxColumn.DataPropertyName = "NewValue";
            this.newValueDataGridViewTextBoxColumn.HeaderText = "NewValue";
            this.newValueDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.newValueDataGridViewTextBoxColumn.Name = "newValueDataGridViewTextBoxColumn";
            this.newValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // auditHistoryBindingSource
            // 
            this.auditHistoryBindingSource.DataSource = typeof(AuditHistoryExtractor.Classes.AuditHistory);
            // 
            // GrpPaging
            // 
            this.GrpPaging.Controls.Add(this.pnlPaging);
            this.GrpPaging.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrpPaging.Location = new System.Drawing.Point(3, 1458);
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
            this.tabOperations.Controls.Add(this.tabUserFilters);
            this.tabOperations.Controls.Add(this.tabAttributeFilters);
            this.tabOperations.Controls.Add(this.tabLogs);
            this.tabOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOperations.Location = new System.Drawing.Point(0, 0);
            this.tabOperations.Name = "tabOperations";
            this.tabOperations.SelectedIndex = 0;
            this.tabOperations.Size = new System.Drawing.Size(753, 1558);
            this.tabOperations.TabIndex = 51;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.panel1);
            this.tabSearch.Location = new System.Drawing.Point(4, 29);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(745, 1525);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpFilterByFetchXml);
            this.panel1.Controls.Add(this.grpFilterByView);
            this.panel1.Controls.Add(this.grpFilterMethod);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 1519);
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
            this.grpFilterByFetchXml.Location = new System.Drawing.Point(0, 405);
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
            this.grpFilterByView.Location = new System.Drawing.Point(0, 265);
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
            this.tabFilter.Controls.Add(this.grpOperations);
            this.tabFilter.Controls.Add(this.grpOperationDateTime);
            this.tabFilter.Location = new System.Drawing.Point(4, 29);
            this.tabFilter.Name = "tabFilter";
            this.tabFilter.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilter.Size = new System.Drawing.Size(745, 1525);
            this.tabFilter.TabIndex = 1;
            this.tabFilter.Text = "Advanced Filters";
            this.tabFilter.UseVisualStyleBackColor = true;
            // 
            // grpBoxActions
            // 
            this.grpBoxActions.Controls.Add(this.chkLstActions);
            this.grpBoxActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBoxActions.Location = new System.Drawing.Point(3, 303);
            this.grpBoxActions.Name = "grpBoxActions";
            this.grpBoxActions.Size = new System.Drawing.Size(739, 1123);
            this.grpBoxActions.TabIndex = 63;
            this.grpBoxActions.TabStop = false;
            this.grpBoxActions.Text = "Actions";
            // 
            // chkLstActions
            // 
            this.chkLstActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkLstActions.FormattingEnabled = true;
            this.chkLstActions.Location = new System.Drawing.Point(3, 22);
            this.chkLstActions.Name = "chkLstActions";
            this.chkLstActions.Size = new System.Drawing.Size(733, 1098);
            this.chkLstActions.TabIndex = 0;
            // 
            // grpOperations
            // 
            this.grpOperations.Controls.Add(this.chkLstOperations);
            this.grpOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpOperations.Location = new System.Drawing.Point(3, 148);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Size = new System.Drawing.Size(739, 155);
            this.grpOperations.TabIndex = 62;
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
            this.chkLstOperations.Size = new System.Drawing.Size(733, 130);
            this.chkLstOperations.TabIndex = 0;
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
            this.grpOperationDateTime.Location = new System.Drawing.Point(3, 3);
            this.grpOperationDateTime.Name = "grpOperationDateTime";
            this.grpOperationDateTime.Size = new System.Drawing.Size(739, 145);
            this.grpOperationDateTime.TabIndex = 59;
            this.grpOperationDateTime.TabStop = false;
            this.grpOperationDateTime.Text = "Operation Date & Time";
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
            // tabUserFilters
            // 
            this.tabUserFilters.Controls.Add(this.lstViewUsers);
            this.tabUserFilters.Controls.Add(this.pnlSearchUsers);
            this.tabUserFilters.Location = new System.Drawing.Point(4, 29);
            this.tabUserFilters.Name = "tabUserFilters";
            this.tabUserFilters.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserFilters.Size = new System.Drawing.Size(745, 1525);
            this.tabUserFilters.TabIndex = 4;
            this.tabUserFilters.Text = "User Filters";
            this.tabUserFilters.UseVisualStyleBackColor = true;
            // 
            // lstViewUsers
            // 
            this.lstViewUsers.CheckBoxes = true;
            this.lstViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmFullName,
            this.clmUserName});
            this.lstViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewUsers.HideSelection = false;
            this.lstViewUsers.Location = new System.Drawing.Point(3, 95);
            this.lstViewUsers.Name = "lstViewUsers";
            this.lstViewUsers.Size = new System.Drawing.Size(739, 1427);
            this.lstViewUsers.TabIndex = 2;
            this.lstViewUsers.UseCompatibleStateImageBehavior = false;
            this.lstViewUsers.View = System.Windows.Forms.View.Details;
            this.lstViewUsers.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstViewUsers_ItemChecked);
            // 
            // clmFullName
            // 
            this.clmFullName.Text = "Full Name";
            this.clmFullName.Width = 235;
            // 
            // clmUserName
            // 
            this.clmUserName.Text = "User Name";
            this.clmUserName.Width = 288;
            // 
            // pnlSearchUsers
            // 
            this.pnlSearchUsers.Controls.Add(this.lnkSelectUsersAll);
            this.pnlSearchUsers.Controls.Add(this.btnSearchUser);
            this.pnlSearchUsers.Controls.Add(this.lblNameUsername);
            this.pnlSearchUsers.Controls.Add(this.txtUser);
            this.pnlSearchUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchUsers.Location = new System.Drawing.Point(3, 3);
            this.pnlSearchUsers.Name = "pnlSearchUsers";
            this.pnlSearchUsers.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pnlSearchUsers.Size = new System.Drawing.Size(739, 92);
            this.pnlSearchUsers.TabIndex = 1;
            // 
            // lnkSelectUsersAll
            // 
            this.lnkSelectUsersAll.AutoSize = true;
            this.lnkSelectUsersAll.Location = new System.Drawing.Point(8, 56);
            this.lnkSelectUsersAll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkSelectUsersAll.Name = "lnkSelectUsersAll";
            this.lnkSelectUsersAll.Size = new System.Drawing.Size(148, 20);
            this.lnkSelectUsersAll.TabIndex = 8;
            this.lnkSelectUsersAll.TabStop = true;
            this.lnkSelectUsersAll.Text = "Select / Unselect all";
            this.lnkSelectUsersAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSelectUsersAll_LinkClicked);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(496, 9);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(87, 37);
            this.btnSearchUser.TabIndex = 2;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // lblNameUsername
            // 
            this.lblNameUsername.AutoSize = true;
            this.lblNameUsername.Location = new System.Drawing.Point(8, 18);
            this.lblNameUsername.Name = "lblNameUsername";
            this.lblNameUsername.Size = new System.Drawing.Size(137, 20);
            this.lblNameUsername.TabIndex = 1;
            this.lblNameUsername.Text = "Name / Username";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(154, 12);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(325, 26);
            this.txtUser.TabIndex = 0;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress_1);
            // 
            // tabAttributeFilters
            // 
            this.tabAttributeFilters.Controls.Add(this.pnlListAttributes);
            this.tabAttributeFilters.Controls.Add(this.pnlSearch);
            this.tabAttributeFilters.Location = new System.Drawing.Point(4, 29);
            this.tabAttributeFilters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAttributeFilters.Name = "tabAttributeFilters";
            this.tabAttributeFilters.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAttributeFilters.Size = new System.Drawing.Size(745, 1525);
            this.tabAttributeFilters.TabIndex = 3;
            this.tabAttributeFilters.Text = "Attribute Filters";
            this.tabAttributeFilters.UseVisualStyleBackColor = true;
            // 
            // pnlListAttributes
            // 
            this.pnlListAttributes.Controls.Add(this.lstAttributes);
            this.pnlListAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListAttributes.Location = new System.Drawing.Point(4, 93);
            this.pnlListAttributes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlListAttributes.Name = "pnlListAttributes";
            this.pnlListAttributes.Size = new System.Drawing.Size(737, 1427);
            this.pnlListAttributes.TabIndex = 57;
            // 
            // lstAttributes
            // 
            this.lstAttributes.CheckBoxes = true;
            this.lstAttributes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHdrDisplayName,
            this.clmHdrLogicalName,
            this.clmHdrType});
            this.lstAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAttributes.HideSelection = false;
            this.lstAttributes.Location = new System.Drawing.Point(0, 0);
            this.lstAttributes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstAttributes.Name = "lstAttributes";
            this.lstAttributes.Size = new System.Drawing.Size(737, 1427);
            this.lstAttributes.TabIndex = 1;
            this.lstAttributes.UseCompatibleStateImageBehavior = false;
            this.lstAttributes.View = System.Windows.Forms.View.Details;
            this.lstAttributes.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstAttributes_ItemChecked);
            // 
            // clmHdrDisplayName
            // 
            this.clmHdrDisplayName.Text = "Display Name";
            this.clmHdrDisplayName.Width = 163;
            // 
            // clmHdrLogicalName
            // 
            this.clmHdrLogicalName.Text = "Logical Name";
            this.clmHdrLogicalName.Width = 176;
            // 
            // clmHdrType
            // 
            this.clmHdrType.Text = "Data Type";
            this.clmHdrType.Width = 139;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.lnkSelectAttributesAll);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.label2);
            this.pnlSearch.Controls.Add(this.txtSearchAttribute);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(4, 5);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(737, 88);
            this.pnlSearch.TabIndex = 56;
            // 
            // lnkSelectAttributesAll
            // 
            this.lnkSelectAttributesAll.AutoSize = true;
            this.lnkSelectAttributesAll.Location = new System.Drawing.Point(6, 63);
            this.lnkSelectAttributesAll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkSelectAttributesAll.Name = "lnkSelectAttributesAll";
            this.lnkSelectAttributesAll.Size = new System.Drawing.Size(148, 20);
            this.lnkSelectAttributesAll.TabIndex = 7;
            this.lnkSelectAttributesAll.TabStop = true;
            this.lnkSelectAttributesAll.Text = "Select / Unselect all";
            this.lnkSelectAttributesAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSelectAttributesAll_LinkClicked);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(591, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 37);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Logical Name / Display Name";
            // 
            // txtSearchAttribute
            // 
            this.txtSearchAttribute.Location = new System.Drawing.Point(236, 14);
            this.txtSearchAttribute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchAttribute.Name = "txtSearchAttribute";
            this.txtSearchAttribute.Size = new System.Drawing.Size(330, 26);
            this.txtSearchAttribute.TabIndex = 4;
            this.txtSearchAttribute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchAttribute_KeyPress);
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.pnlLogResult);
            this.tabLogs.Controls.Add(this.panel2);
            this.tabLogs.Location = new System.Drawing.Point(4, 29);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogs.Size = new System.Drawing.Size(745, 1521);
            this.tabLogs.TabIndex = 2;
            this.tabLogs.Text = "Logs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // pnlLogResult
            // 
            this.pnlLogResult.Controls.Add(this.dtGrvLogs);
            this.pnlLogResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogResult.Location = new System.Drawing.Point(3, 45);
            this.pnlLogResult.Name = "pnlLogResult";
            this.pnlLogResult.Size = new System.Drawing.Size(739, 1473);
            this.pnlLogResult.TabIndex = 3;
            // 
            // dtGrvLogs
            // 
            this.dtGrvLogs.AllowUserToAddRows = false;
            this.dtGrvLogs.AllowUserToDeleteRows = false;
            this.dtGrvLogs.AutoGenerateColumns = false;
            this.dtGrvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGrvLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGrvLogs.ColumnHeadersHeight = 34;
            this.dtGrvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StatusImage,
            this.infoLog,
            this.GuidRecord,
            this.recordKeyValueDataGridViewTextBoxColumn1,
            this.messageDataGridViewTextBoxColumn});
            this.dtGrvLogs.DataSource = this.logBindingSource1;
            this.dtGrvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrvLogs.Location = new System.Drawing.Point(0, 0);
            this.dtGrvLogs.Name = "dtGrvLogs";
            this.dtGrvLogs.ReadOnly = true;
            this.dtGrvLogs.RowHeadersWidth = 62;
            this.dtGrvLogs.RowTemplate.Height = 28;
            this.dtGrvLogs.Size = new System.Drawing.Size(739, 1473);
            this.dtGrvLogs.TabIndex = 1;
            this.dtGrvLogs.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.drGrwLogs_DataBindingComplete);
            // 
            // StatusImage
            // 
            this.StatusImage.HeaderText = "";
            this.StatusImage.MinimumWidth = 8;
            this.StatusImage.Name = "StatusImage";
            this.StatusImage.ReadOnly = true;
            this.StatusImage.Width = 8;
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
            // GuidRecord
            // 
            this.GuidRecord.DataPropertyName = "recordId";
            this.GuidRecord.HeaderText = "Guid";
            this.GuidRecord.MinimumWidth = 8;
            this.GuidRecord.Name = "GuidRecord";
            this.GuidRecord.ReadOnly = true;
            this.GuidRecord.Visible = false;
            this.GuidRecord.Width = 79;
            // 
            // recordKeyValueDataGridViewTextBoxColumn1
            // 
            this.recordKeyValueDataGridViewTextBoxColumn1.DataPropertyName = "RecordKeyValue";
            this.recordKeyValueDataGridViewTextBoxColumn1.HeaderText = "Record Key Value";
            this.recordKeyValueDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.recordKeyValueDataGridViewTextBoxColumn1.Name = "recordKeyValueDataGridViewTextBoxColumn1";
            this.recordKeyValueDataGridViewTextBoxColumn1.ReadOnly = true;
            this.recordKeyValueDataGridViewTextBoxColumn1.Width = 172;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.chkShowGuid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 42);
            this.panel2.TabIndex = 2;
            // 
            // chkShowGuid
            // 
            this.chkShowGuid.AutoSize = true;
            this.chkShowGuid.Location = new System.Drawing.Point(4, 5);
            this.chkShowGuid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkShowGuid.Name = "chkShowGuid";
            this.chkShowGuid.Size = new System.Drawing.Size(162, 24);
            this.chkShowGuid.TabIndex = 1;
            this.chkShowGuid.Text = "Show record Guid";
            this.chkShowGuid.UseVisualStyleBackColor = true;
            this.chkShowGuid.CheckedChanged += new System.EventHandler(this.chkShowGuid_CheckedChanged);
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnClearFilters);
            this.grpActions.Controls.Add(this.btnApplyFilters);
            this.grpActions.Controls.Add(this.btnPreview);
            this.grpActions.Controls.Add(this.btnExtractAuditHistory);
            this.grpActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpActions.Location = new System.Drawing.Point(0, 1460);
            this.grpActions.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpActions.Name = "grpActions";
            this.grpActions.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpActions.Size = new System.Drawing.Size(753, 98);
            this.grpActions.TabIndex = 54;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            this.grpActions.Visible = false;
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
            // panel8
            // 
            this.panel8.Controls.Add(this.grpActions);
            this.panel8.Controls.Add(this.tabOperations);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 34);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(753, 1558);
            this.panel8.TabIndex = 59;
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
            ((System.ComponentModel.ISupportInitialize)(this.auditHistoryBindingSource)).EndInit();
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
            this.grpFilterMethod.ResumeLayout(false);
            this.grpFilterMethod.PerformLayout();
            this.tabFilter.ResumeLayout(false);
            this.grpBoxActions.ResumeLayout(false);
            this.grpOperations.ResumeLayout(false);
            this.grpOperationDateTime.ResumeLayout(false);
            this.grpOperationDateTime.PerformLayout();
            this.tabUserFilters.ResumeLayout(false);
            this.pnlSearchUsers.ResumeLayout(false);
            this.pnlSearchUsers.PerformLayout();
            this.tabAttributeFilters.ResumeLayout(false);
            this.pnlListAttributes.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.tabLogs.ResumeLayout(false);
            this.pnlLogResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrvLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.Button btnClearTo;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.GroupBox GrpPaging;
        private System.Windows.Forms.Panel pnlPaging;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cmbNumberOfRecords;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.BindingSource logBindingSource;
        private System.Windows.Forms.BindingSource logBindingSource1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkShowGuid;
        private System.Windows.Forms.TabPage tabAttributeFilters;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchAttribute;
        private System.Windows.Forms.Panel pnlListAttributes;
        private System.Windows.Forms.ListView lstAttributes;
        private System.Windows.Forms.ColumnHeader clmHdrDisplayName;
        private System.Windows.Forms.ColumnHeader clmHdrLogicalName;
        private System.Windows.Forms.ColumnHeader clmHdrType;
        private System.Windows.Forms.LinkLabel lnkSelectAttributesAll;
        private System.Windows.Forms.TabPage tabUserFilters;
        private System.Windows.Forms.Panel pnlSearchUsers;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Label lblNameUsername;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ListView lstViewUsers;
        private System.Windows.Forms.ColumnHeader clmFullName;
        private System.Windows.Forms.ColumnHeader clmUserName;
        private System.Windows.Forms.LinkLabel lnkSelectUsersAll;
        private System.Windows.Forms.Panel pnlLogResult;
        private System.Windows.Forms.DataGridView dtGrvLogs;
        private System.Windows.Forms.GroupBox grpBoxActions;
        private System.Windows.Forms.CheckedListBox chkLstActions;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.CheckedListBox chkLstOperations;
        private System.Windows.Forms.DataGridViewImageColumn StatusImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuidRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordKeyValueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
    }
}
