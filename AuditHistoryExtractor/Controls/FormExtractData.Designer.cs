namespace AuditHistoryExtractor.Controls
{
    partial class FormExtractData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExtractData));
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.progressExportData = new System.Windows.Forms.ProgressBar();
            this.lblDescriptionCurrentRow = new System.Windows.Forms.Label();
            this.lblCurrentRow = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.BackgroundWorkerExtractAuditHistory = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // progressExportData
            // 
            this.progressExportData.Location = new System.Drawing.Point(47, 39);
            this.progressExportData.Name = "progressExportData";
            this.progressExportData.Size = new System.Drawing.Size(590, 45);
            this.progressExportData.TabIndex = 0;
            // 
            // lblDescriptionCurrentRow
            // 
            this.lblDescriptionCurrentRow.AutoSize = true;
            this.lblDescriptionCurrentRow.Location = new System.Drawing.Point(47, 111);
            this.lblDescriptionCurrentRow.Name = "lblDescriptionCurrentRow";
            this.lblDescriptionCurrentRow.Size = new System.Drawing.Size(184, 17);
            this.lblDescriptionCurrentRow.TabIndex = 1;
            this.lblDescriptionCurrentRow.Text = "Exporting Audit History for : ";
            // 
            // lblCurrentRow
            // 
            this.lblCurrentRow.AutoSize = true;
            this.lblCurrentRow.Location = new System.Drawing.Point(238, 111);
            this.lblCurrentRow.Name = "lblCurrentRow";
            this.lblCurrentRow.Size = new System.Drawing.Size(13, 17);
            this.lblCurrentRow.TabIndex = 2;
            this.lblCurrentRow.Text = "-";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(241, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(115, 39);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BackgroundWorkerExtractAuditHistory
            // 
            this.BackgroundWorkerExtractAuditHistory.WorkerReportsProgress = true;
            this.BackgroundWorkerExtractAuditHistory.WorkerSupportsCancellation = true;
            this.BackgroundWorkerExtractAuditHistory.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerExtractAuditHistory_DoWork);
            this.BackgroundWorkerExtractAuditHistory.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerExtractAuditHistory_ProgressChanged);
            this.BackgroundWorkerExtractAuditHistory.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerExtractAuditHistory_RunWorkerCompleted);
            // 
            // FormExtractData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 223);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblCurrentRow);
            this.Controls.Add(this.lblDescriptionCurrentRow);
            this.Controls.Add(this.progressExportData);
            this.Name = "FormExtractData";
            this.Text = "Extracting Audit History";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ProgressBar progressExportData;
        private System.Windows.Forms.Label lblDescriptionCurrentRow;
        private System.Windows.Forms.Label lblCurrentRow;
        private System.Windows.Forms.Button btnCancel;
        private System.ComponentModel.BackgroundWorker BackgroundWorkerExtractAuditHistory;
    }
}