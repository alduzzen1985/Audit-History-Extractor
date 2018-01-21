using Microsoft.Xrm.Sdk;
using AuditHistoryExtractor.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuditHistoryExtractor.Controls
{
    public partial class FormExtractData : Form
    {
        #region Variables
        IOrganizationService Service;
        public event EventHandler<EventArgs> Canceled;
        EntityCollection entitiesList;
        string identificator, fieldToExtract, fileName, separator;
        #endregion

        #region Business Logics
        public FormExtractData(IOrganizationService service, EntityCollection entitiesList, string separator)
        {
            Service = service;
            this.entitiesList = entitiesList;
            this.separator = separator;
            InitializeComponent();
        }

        public void ExportDataInCSV(string fileName, string identificator, string fieldToExtract)
        {
            this.fileName = fileName;
            this.identificator = identificator;
            this.fieldToExtract = fieldToExtract;

            if (BackgroundWorkerExtractAuditHistory.IsBusy != true)
            {
                progressExportData.Step = 1;
                progressExportData.Maximum = entitiesList.Entities.Count;
                BackgroundWorkerExtractAuditHistory.RunWorkerAsync();
            }
        }
        #endregion

        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            BackgroundWorkerExtractAuditHistory.CancelAsync();
        }

        private void BackgroundWorkerExtractAuditHistory_DoWork(object sender, DoWorkEventArgs e)
        {
            AuditHistoryManager auditHistoryManager = new AuditHistoryManager(Service, identificator, separator);
            foreach (Entity entity in entitiesList.Entities)
            {
                if (BackgroundWorkerExtractAuditHistory.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                try
                {
                    auditHistoryManager.WriteFileAuditHistory(entity.Id, entity.LogicalName, entity.Attributes[identificator].ToString(), fieldToExtract, fileName);
                    BackgroundWorkerExtractAuditHistory.ReportProgress(1, entity[identificator].ToString());
                }
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show(ex.Message,
                               "Error",
                                MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void BackgroundWorkerExtractAuditHistory_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblCurrentRow.Text = e.UserState.ToString();
            progressExportData.PerformStep();
        }

        private void BackgroundWorkerExtractAuditHistory_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
