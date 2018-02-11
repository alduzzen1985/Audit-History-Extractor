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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPluginControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbFromEntitiesEnabled = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtFetchXML = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAuditEnabled = new System.Windows.Forms.TabPage();
            this.lstEntitiesWithAuditEnabled = new System.Windows.Forms.ListView();
            this.tabPageAuditDisabled = new System.Windows.Forms.TabPage();
            this.lstEntitiesWithAuditDisabled = new System.Windows.Forms.ListView();
            this.btnExtractAuditHistory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFieldToExtract = new System.Windows.Forms.ComboBox();
            this.cmbPrimaryKey = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageAuditEnabled.SuspendLayout();
            this.tabPageAuditDisabled.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbClose,
            this.toolStripSeparator1,
            this.tbFromEntitiesEnabled,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1173, 27);
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
            // txtFetchXML
            // 
            this.txtFetchXML.Location = new System.Drawing.Point(6, 104);
            this.txtFetchXML.Multiline = true;
            this.txtFetchXML.Name = "txtFetchXML";
            this.txtFetchXML.Size = new System.Drawing.Size(564, 286);
            this.txtFetchXML.TabIndex = 30;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAuditEnabled);
            this.tabControl1.Controls.Add(this.tabPageAuditDisabled);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 787);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPageAuditEnabled
            // 
            this.tabPageAuditEnabled.Controls.Add(this.lstEntitiesWithAuditEnabled);
            this.tabPageAuditEnabled.Location = new System.Drawing.Point(4, 25);
            this.tabPageAuditEnabled.Name = "tabPageAuditEnabled";
            this.tabPageAuditEnabled.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuditEnabled.Size = new System.Drawing.Size(452, 758);
            this.tabPageAuditEnabled.TabIndex = 0;
            this.tabPageAuditEnabled.Text = "Entities With Audit Enabled";
            this.tabPageAuditEnabled.UseVisualStyleBackColor = true;
            // 
            // lstEntitiesWithAuditEnabled
            // 
            this.lstEntitiesWithAuditEnabled.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstEntitiesWithAuditEnabled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEntitiesWithAuditEnabled.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstEntitiesWithAuditEnabled.Location = new System.Drawing.Point(3, 3);
            this.lstEntitiesWithAuditEnabled.MultiSelect = false;
            this.lstEntitiesWithAuditEnabled.Name = "lstEntitiesWithAuditEnabled";
            this.lstEntitiesWithAuditEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstEntitiesWithAuditEnabled.Size = new System.Drawing.Size(446, 752);
            this.lstEntitiesWithAuditEnabled.TabIndex = 16;
            this.lstEntitiesWithAuditEnabled.UseCompatibleStateImageBehavior = false;
            this.lstEntitiesWithAuditEnabled.View = System.Windows.Forms.View.List;
            this.lstEntitiesWithAuditEnabled.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstEntities_ItemSelectionChanged_1);
            // 
            // tabPageAuditDisabled
            // 
            this.tabPageAuditDisabled.Controls.Add(this.lstEntitiesWithAuditDisabled);
            this.tabPageAuditDisabled.Location = new System.Drawing.Point(4, 25);
            this.tabPageAuditDisabled.Name = "tabPageAuditDisabled";
            this.tabPageAuditDisabled.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuditDisabled.Size = new System.Drawing.Size(452, 758);
            this.tabPageAuditDisabled.TabIndex = 1;
            this.tabPageAuditDisabled.Text = "Entities with Audit Disabled";
            this.tabPageAuditDisabled.UseVisualStyleBackColor = true;
            // 
            // lstEntitiesWithAuditDisabled
            // 
            this.lstEntitiesWithAuditDisabled.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstEntitiesWithAuditDisabled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEntitiesWithAuditDisabled.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstEntitiesWithAuditDisabled.Location = new System.Drawing.Point(3, 3);
            this.lstEntitiesWithAuditDisabled.Name = "lstEntitiesWithAuditDisabled";
            this.lstEntitiesWithAuditDisabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstEntitiesWithAuditDisabled.Size = new System.Drawing.Size(446, 752);
            this.lstEntitiesWithAuditDisabled.TabIndex = 33;
            this.lstEntitiesWithAuditDisabled.UseCompatibleStateImageBehavior = false;
            this.lstEntitiesWithAuditDisabled.View = System.Windows.Forms.View.List;
            this.lstEntitiesWithAuditDisabled.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstEntities_ItemSelectionChanged_1);
            // 
            // btnExtractAuditHistory
            // 
            this.btnExtractAuditHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnExtractAuditHistory.Image")));
            this.btnExtractAuditHistory.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExtractAuditHistory.Location = new System.Drawing.Point(14, 40);
            this.btnExtractAuditHistory.Name = "btnExtractAuditHistory";
            this.btnExtractAuditHistory.Size = new System.Drawing.Size(212, 38);
            this.btnExtractAuditHistory.TabIndex = 29;
            this.btnExtractAuditHistory.Text = "  Extract Audit History";
            this.btnExtractAuditHistory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExtractAuditHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExtractAuditHistory.UseVisualStyleBackColor = true;
            this.btnExtractAuditHistory.Click += new System.EventHandler(this.btnExtractAuditHistory_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Audit history field";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Record Identifier";
            // 
            // cmbFieldToExtract
            // 
            this.cmbFieldToExtract.FormattingEnabled = true;
            this.cmbFieldToExtract.Location = new System.Drawing.Point(149, 83);
            this.cmbFieldToExtract.Name = "cmbFieldToExtract";
            this.cmbFieldToExtract.Size = new System.Drawing.Size(411, 24);
            this.cmbFieldToExtract.TabIndex = 26;
            // 
            // cmbPrimaryKey
            // 
            this.cmbPrimaryKey.FormattingEnabled = true;
            this.cmbPrimaryKey.Location = new System.Drawing.Point(149, 32);
            this.cmbPrimaryKey.Name = "cmbPrimaryKey";
            this.cmbPrimaryKey.Size = new System.Drawing.Size(411, 24);
            this.cmbPrimaryKey.TabIndex = 25;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(470, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "A FetchXML is required to filter the records for the audit history to extract.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "You can build your Fetch XML from here :";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(295, 71);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 17);
            this.linkLabel1.TabIndex = 35;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LINK";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPrimaryKey);
            this.groupBox1.Controls.Add(this.cmbFieldToExtract);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(487, 485);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 138);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fields Selection";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtFetchXML);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(487, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 405);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter Data ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExtractAuditHistory);
            this.groupBox3.Location = new System.Drawing.Point(487, 665);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(593, 84);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(1173, 814);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageAuditEnabled.ResumeLayout(false);
            this.tabPageAuditDisabled.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbFromEntitiesEnabled;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox txtFetchXML;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAuditEnabled;
        private System.Windows.Forms.ListView lstEntitiesWithAuditEnabled;
        private System.Windows.Forms.TabPage tabPageAuditDisabled;
        private System.Windows.Forms.Button btnExtractAuditHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFieldToExtract;
        private System.Windows.Forms.ComboBox cmbPrimaryKey;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListView lstEntitiesWithAuditDisabled;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
