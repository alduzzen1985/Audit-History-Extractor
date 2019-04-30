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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbFromEntitiesEnabled = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbOpenFetchXMLBuilder = new System.Windows.Forms.ToolStripButton();
            this.btnExtractAuditHistory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPrimaryKey = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtFetchXML = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpFilterByFetchXml = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblViews = new System.Windows.Forms.Label();
            this.cmbViews = new System.Windows.Forms.ComboBox();
            this.lblEntities = new System.Windows.Forms.Label();
            this.cmbEntities = new System.Windows.Forms.ComboBox();
            this.rdbView = new System.Windows.Forms.RadioButton();
            this.rdbFetchXml = new System.Windows.Forms.RadioButton();
            this.chkPersonalView = new System.Windows.Forms.CheckBox();
            this.lblFilterDataBy = new System.Windows.Forms.Label();
            this.grpFilterByView = new System.Windows.Forms.GroupBox();
            this.grpFilterMethod = new System.Windows.Forms.GroupBox();
            this.dtGrvPreview = new System.Windows.Forms.DataGridView();
            this.recordKeyValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpPreview = new System.Windows.Forms.GroupBox();
            this.lblAuditNotEnabled = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.grpFilterByFetchXml.SuspendLayout();
            this.grpFilterByView.SuspendLayout();
            this.grpFilterMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrvPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditHistoryBindingSource)).BeginInit();
            this.grpPreview.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1728, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "Get Entities";
            // 
            // tbClose
            // 
            this.tbClose.Image = ((System.Drawing.Image)(resources.GetObject("tbClose.Image")));
            this.tbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbClose.Name = "tbClose";
            this.tbClose.Size = new System.Drawing.Size(69, 24);
            this.tbClose.Text = "Close";
            this.tbClose.Click += new System.EventHandler(this.tbClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tbFromEntitiesEnabled
            // 
            this.tbFromEntitiesEnabled.Image = ((System.Drawing.Image)(resources.GetObject("tbFromEntitiesEnabled.Image")));
            this.tbFromEntitiesEnabled.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbFromEntitiesEnabled.Name = "tbFromEntitiesEnabled";
            this.tbFromEntitiesEnabled.Size = new System.Drawing.Size(108, 24);
            this.tbFromEntitiesEnabled.Text = "Get Entities";
            this.tbFromEntitiesEnabled.ToolTipText = "Get Entities with Audit Enabled";
            this.tbFromEntitiesEnabled.Click += new System.EventHandler(this.tbFromEntitiesEnabled_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tbOpenFetchXMLBuilder
            // 
            this.tbOpenFetchXMLBuilder.Image = ((System.Drawing.Image)(resources.GetObject("tbOpenFetchXMLBuilder.Image")));
            this.tbOpenFetchXMLBuilder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbOpenFetchXMLBuilder.Name = "tbOpenFetchXMLBuilder";
            this.tbOpenFetchXMLBuilder.Size = new System.Drawing.Size(274, 24);
            this.tbOpenFetchXMLBuilder.Text = "Create Query from FetchXML Builder";
            this.tbOpenFetchXMLBuilder.Visible = false;
            this.tbOpenFetchXMLBuilder.Click += new System.EventHandler(this.tbOpenFetchXMLBuilder_Click);
            // 
            // btnExtractAuditHistory
            // 
            this.btnExtractAuditHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnExtractAuditHistory.Image")));
            this.btnExtractAuditHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtractAuditHistory.Location = new System.Drawing.Point(252, 36);
            this.btnExtractAuditHistory.Name = "btnExtractAuditHistory";
            this.btnExtractAuditHistory.Size = new System.Drawing.Size(212, 38);
            this.btnExtractAuditHistory.TabIndex = 29;
            this.btnExtractAuditHistory.Text = "  Export to CSV";
            this.btnExtractAuditHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExtractAuditHistory.UseMnemonic = false;
            this.btnExtractAuditHistory.UseVisualStyleBackColor = true;
            this.btnExtractAuditHistory.Click += new System.EventHandler(this.btnExtractAuditHistory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Primary Key Field";
            // 
            // cmbPrimaryKey
            // 
            this.cmbPrimaryKey.FormattingEnabled = true;
            this.cmbPrimaryKey.Location = new System.Drawing.Point(146, 75);
            this.cmbPrimaryKey.Name = "cmbPrimaryKey";
            this.cmbPrimaryKey.Size = new System.Drawing.Size(411, 24);
            this.cmbPrimaryKey.TabIndex = 25;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk_1);
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnPreview);
            this.grpActions.Controls.Add(this.btnExtractAuditHistory);
            this.grpActions.Location = new System.Drawing.Point(15, 663);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(765, 111);
            this.grpActions.TabIndex = 38;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            this.grpActions.Visible = false;
            // 
            // btnPreview
            // 
            this.btnPreview.Image = global::AuditHistoryExtractor.Properties.Resources.preview24x24;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.Location = new System.Drawing.Point(23, 36);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(203, 38);
            this.btnPreview.TabIndex = 30;
            this.btnPreview.Text = "Preview Data";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(287, 29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 17);
            this.linkLabel1.TabIndex = 35;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LINK";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtFetchXML
            // 
            this.txtFetchXML.Location = new System.Drawing.Point(9, 49);
            this.txtFetchXML.Multiline = true;
            this.txtFetchXML.Name = "txtFetchXML";
            this.txtFetchXML.Size = new System.Drawing.Size(750, 287);
            this.txtFetchXML.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "You can build your Fetch XML from here :";
            // 
            // grpFilterByFetchXml
            // 
            this.grpFilterByFetchXml.AutoSize = true;
            this.grpFilterByFetchXml.Controls.Add(this.label6);
            this.grpFilterByFetchXml.Controls.Add(this.label5);
            this.grpFilterByFetchXml.Controls.Add(this.txtFetchXML);
            this.grpFilterByFetchXml.Controls.Add(this.linkLabel1);
            this.grpFilterByFetchXml.Location = new System.Drawing.Point(15, 321);
            this.grpFilterByFetchXml.Name = "grpFilterByFetchXml";
            this.grpFilterByFetchXml.Size = new System.Drawing.Size(765, 357);
            this.grpFilterByFetchXml.TabIndex = 37;
            this.grpFilterByFetchXml.TabStop = false;
            this.grpFilterByFetchXml.Text = "Filter Data with FetchXML";
            this.grpFilterByFetchXml.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "or using the FetchXML Builder Button";
            // 
            // lblViews
            // 
            this.lblViews.AutoSize = true;
            this.lblViews.Location = new System.Drawing.Point(6, 33);
            this.lblViews.Name = "lblViews";
            this.lblViews.Size = new System.Drawing.Size(44, 17);
            this.lblViews.TabIndex = 39;
            this.lblViews.Text = "Views";
            // 
            // cmbViews
            // 
            this.cmbViews.FormattingEnabled = true;
            this.cmbViews.Location = new System.Drawing.Point(74, 33);
            this.cmbViews.Name = "cmbViews";
            this.cmbViews.Size = new System.Drawing.Size(390, 24);
            this.cmbViews.TabIndex = 40;
            this.cmbViews.SelectedIndexChanged += new System.EventHandler(this.cmbViews_SelectedIndexChanged);
            // 
            // lblEntities
            // 
            this.lblEntities.AutoSize = true;
            this.lblEntities.Location = new System.Drawing.Point(6, 37);
            this.lblEntities.Name = "lblEntities";
            this.lblEntities.Size = new System.Drawing.Size(43, 17);
            this.lblEntities.TabIndex = 41;
            this.lblEntities.Text = "Entity";
            // 
            // cmbEntities
            // 
            this.cmbEntities.FormattingEnabled = true;
            this.cmbEntities.Location = new System.Drawing.Point(146, 34);
            this.cmbEntities.Name = "cmbEntities";
            this.cmbEntities.Size = new System.Drawing.Size(411, 24);
            this.cmbEntities.TabIndex = 42;
            this.cmbEntities.SelectedIndexChanged += new System.EventHandler(this.cmbEntities_SelectedIndexChanged);
            // 
            // rdbView
            // 
            this.rdbView.AutoSize = true;
            this.rdbView.Location = new System.Drawing.Point(146, 116);
            this.rdbView.Name = "rdbView";
            this.rdbView.Size = new System.Drawing.Size(58, 21);
            this.rdbView.TabIndex = 43;
            this.rdbView.TabStop = true;
            this.rdbView.Text = "View";
            this.rdbView.UseVisualStyleBackColor = true;
            this.rdbView.CheckedChanged += new System.EventHandler(this.rdbView_CheckedChanged);
            // 
            // rdbFetchXml
            // 
            this.rdbFetchXml.AutoSize = true;
            this.rdbFetchXml.Location = new System.Drawing.Point(213, 116);
            this.rdbFetchXml.Name = "rdbFetchXml";
            this.rdbFetchXml.Size = new System.Drawing.Size(92, 21);
            this.rdbFetchXml.TabIndex = 44;
            this.rdbFetchXml.TabStop = true;
            this.rdbFetchXml.Text = "FetchXML";
            this.rdbFetchXml.UseVisualStyleBackColor = true;
            this.rdbFetchXml.CheckedChanged += new System.EventHandler(this.rdbFetchXml_CheckedChanged);
            // 
            // chkPersonalView
            // 
            this.chkPersonalView.AutoSize = true;
            this.chkPersonalView.Location = new System.Drawing.Point(486, 33);
            this.chkPersonalView.Name = "chkPersonalView";
            this.chkPersonalView.Size = new System.Drawing.Size(157, 21);
            this.chkPersonalView.TabIndex = 43;
            this.chkPersonalView.Text = "Show Personal View";
            this.chkPersonalView.UseVisualStyleBackColor = true;
            this.chkPersonalView.CheckedChanged += new System.EventHandler(this.chkPersonalView_CheckedChanged);
            // 
            // lblFilterDataBy
            // 
            this.lblFilterDataBy.AutoSize = true;
            this.lblFilterDataBy.Location = new System.Drawing.Point(6, 118);
            this.lblFilterDataBy.Name = "lblFilterDataBy";
            this.lblFilterDataBy.Size = new System.Drawing.Size(123, 17);
            this.lblFilterDataBy.TabIndex = 46;
            this.lblFilterDataBy.Text = "Filter Data using : ";
            // 
            // grpFilterByView
            // 
            this.grpFilterByView.AutoSize = true;
            this.grpFilterByView.Controls.Add(this.chkPersonalView);
            this.grpFilterByView.Controls.Add(this.lblViews);
            this.grpFilterByView.Controls.Add(this.cmbViews);
            this.grpFilterByView.Location = new System.Drawing.Point(15, 212);
            this.grpFilterByView.Name = "grpFilterByView";
            this.grpFilterByView.Size = new System.Drawing.Size(765, 83);
            this.grpFilterByView.TabIndex = 44;
            this.grpFilterByView.TabStop = false;
            this.grpFilterByView.Text = "Filter by View";
            this.grpFilterByView.Visible = false;
            // 
            // grpFilterMethod
            // 
            this.grpFilterMethod.AutoSize = true;
            this.grpFilterMethod.Controls.Add(this.lblAuditNotEnabled);
            this.grpFilterMethod.Controls.Add(this.cmbPrimaryKey);
            this.grpFilterMethod.Controls.Add(this.label1);
            this.grpFilterMethod.Controls.Add(this.lblFilterDataBy);
            this.grpFilterMethod.Controls.Add(this.rdbView);
            this.grpFilterMethod.Controls.Add(this.lblEntities);
            this.grpFilterMethod.Controls.Add(this.rdbFetchXml);
            this.grpFilterMethod.Controls.Add(this.cmbEntities);
            this.grpFilterMethod.Location = new System.Drawing.Point(15, 42);
            this.grpFilterMethod.Name = "grpFilterMethod";
            this.grpFilterMethod.Size = new System.Drawing.Size(765, 164);
            this.grpFilterMethod.TabIndex = 47;
            this.grpFilterMethod.TabStop = false;
            this.grpFilterMethod.Text = "Filter Method";
            // 
            // dtGrvPreview
            // 
            this.dtGrvPreview.AutoGenerateColumns = false;
            this.dtGrvPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrvPreview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGrvPreview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordKeyValueDataGridViewTextBoxColumn,
            this.createdOnDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.operationDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn,
            this.attributeNameDataGridViewTextBoxColumn,
            this.oldValueDataGridViewTextBoxColumn,
            this.newValueDataGridViewTextBoxColumn});
            this.dtGrvPreview.DataSource = this.auditHistoryBindingSource;
            this.dtGrvPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrvPreview.Location = new System.Drawing.Point(3, 18);
            this.dtGrvPreview.Name = "dtGrvPreview";
            this.dtGrvPreview.RowTemplate.Height = 24;
            this.dtGrvPreview.Size = new System.Drawing.Size(902, 829);
            this.dtGrvPreview.TabIndex = 48;
            // 
            // recordKeyValueDataGridViewTextBoxColumn
            // 
            this.recordKeyValueDataGridViewTextBoxColumn.DataPropertyName = "RecordKeyValue";
            this.recordKeyValueDataGridViewTextBoxColumn.HeaderText = "RecordKeyValue";
            this.recordKeyValueDataGridViewTextBoxColumn.Name = "recordKeyValueDataGridViewTextBoxColumn";
            // 
            // createdOnDataGridViewTextBoxColumn
            // 
            this.createdOnDataGridViewTextBoxColumn.DataPropertyName = "CreatedOn";
            this.createdOnDataGridViewTextBoxColumn.HeaderText = "CreatedOn";
            this.createdOnDataGridViewTextBoxColumn.Name = "createdOnDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // operationDataGridViewTextBoxColumn
            // 
            this.operationDataGridViewTextBoxColumn.DataPropertyName = "Operation";
            this.operationDataGridViewTextBoxColumn.HeaderText = "Operation";
            this.operationDataGridViewTextBoxColumn.Name = "operationDataGridViewTextBoxColumn";
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Action";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            // 
            // attributeNameDataGridViewTextBoxColumn
            // 
            this.attributeNameDataGridViewTextBoxColumn.DataPropertyName = "AttributeName";
            this.attributeNameDataGridViewTextBoxColumn.HeaderText = "AttributeName";
            this.attributeNameDataGridViewTextBoxColumn.Name = "attributeNameDataGridViewTextBoxColumn";
            // 
            // oldValueDataGridViewTextBoxColumn
            // 
            this.oldValueDataGridViewTextBoxColumn.DataPropertyName = "OldValue";
            this.oldValueDataGridViewTextBoxColumn.HeaderText = "OldValue";
            this.oldValueDataGridViewTextBoxColumn.Name = "oldValueDataGridViewTextBoxColumn";
            // 
            // newValueDataGridViewTextBoxColumn
            // 
            this.newValueDataGridViewTextBoxColumn.DataPropertyName = "NewValue";
            this.newValueDataGridViewTextBoxColumn.HeaderText = "NewValue";
            this.newValueDataGridViewTextBoxColumn.Name = "newValueDataGridViewTextBoxColumn";
            // 
            // auditHistoryBindingSource
            // 
            this.auditHistoryBindingSource.DataSource = typeof(AuditHistoryExtractor.Classes.AuditHistory);
            // 
            // grpPreview
            // 
            this.grpPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPreview.Controls.Add(this.dtGrvPreview);
            this.grpPreview.Location = new System.Drawing.Point(800, 42);
            this.grpPreview.Name = "grpPreview";
            this.grpPreview.Size = new System.Drawing.Size(908, 850);
            this.grpPreview.TabIndex = 49;
            this.grpPreview.TabStop = false;
            this.grpPreview.Text = "Preview";
            // 
            // lblAuditNotEnabled
            // 
            this.lblAuditNotEnabled.AutoSize = true;
            this.lblAuditNotEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuditNotEnabled.ForeColor = System.Drawing.Color.Red;
            this.lblAuditNotEnabled.Location = new System.Drawing.Point(564, 36);
            this.lblAuditNotEnabled.Name = "lblAuditNotEnabled";
            this.lblAuditNotEnabled.Size = new System.Drawing.Size(141, 17);
            this.lblAuditNotEnabled.TabIndex = 47;
            this.lblAuditNotEnabled.Text = "Audit not enabled.";
            this.lblAuditNotEnabled.Visible = false;
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.grpPreview);
            this.Controls.Add(this.grpFilterMethod);
            this.Controls.Add(this.grpFilterByView);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpFilterByFetchXml);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(1728, 968);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpFilterByFetchXml.ResumeLayout(false);
            this.grpFilterByFetchXml.PerformLayout();
            this.grpFilterByView.ResumeLayout(false);
            this.grpFilterByView.PerformLayout();
            this.grpFilterMethod.ResumeLayout(false);
            this.grpFilterMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrvPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditHistoryBindingSource)).EndInit();
            this.grpPreview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbFromEntitiesEnabled;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btnExtractAuditHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPrimaryKey;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtFetchXML;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpFilterByFetchXml;
        private System.Windows.Forms.ToolStripButton tbOpenFetchXMLBuilder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblViews;
        private System.Windows.Forms.ComboBox cmbViews;
        private System.Windows.Forms.Label lblEntities;
        private System.Windows.Forms.ComboBox cmbEntities;
        private System.Windows.Forms.RadioButton rdbView;
        private System.Windows.Forms.RadioButton rdbFetchXml;
        private System.Windows.Forms.CheckBox chkPersonalView;
        private System.Windows.Forms.Label lblFilterDataBy;
        private System.Windows.Forms.GroupBox grpFilterByView;
        private System.Windows.Forms.GroupBox grpFilterMethod;
        private System.Windows.Forms.DataGridView dtGrvPreview;
        private System.Windows.Forms.GroupBox grpPreview;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.BindingSource auditHistoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordKeyValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblAuditNotEnabled;
    }
}
