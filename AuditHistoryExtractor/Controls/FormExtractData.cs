using Microsoft.Xrm.Sdk;
using AuditHistoryExtractor.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using AuditHistoryExtractor.Classes;
using AuditHistoryExtractor.Classes.Models;
using AuditHistoryExtractor.Enums;
using System.IO;
using CsvHelper;
using AuditHistoryExtractor.Classes.Managers;

namespace AuditHistoryExtractor.Controls
{
    public partial class FormExtractData : Form
    {
        private const string MessageAuditHistoryExtracted = "Audit History extracted successfully";
        private const string TitleExportSuccess = "Export success";

        public delegate void ExtractCompleted(List<AuditHistory> lsAuditHistory, List<Log> lsLogs);
        public event ExtractCompleted OnExtractCompleted;

        private RetrieveAuditHistoryMode retrieveAuditHistoryMode;
        private string filePath;
        private Configuration filterData;
        private CsvWriter csv = null;
        private StreamWriter writer;


        #region Variables
        IOrganizationService Service;


        List<AuditHistory> lsStory = new List<AuditHistory>();
        List<Log> lslog = new List<Log>();


        List<Entity> entitiesList;
        string identificator, fieldToExtract, fileName;

        #endregion

        #region Business Logics

        public FormExtractData(IOrganizationService service, List<Entity> entitiesList, RetrieveAuditHistoryMode retrieveAuditHistoryMode, string filePath, string csvSeparator, Configuration filterData)
        {
            this.retrieveAuditHistoryMode = retrieveAuditHistoryMode;
            this.filePath = filePath;
            this.filterData = filterData;
            this.formExtractData(service, entitiesList);

        }


        public FormExtractData(IOrganizationService service, List<Entity> entitiesList)
        {
            this.retrieveAuditHistoryMode = RetrieveAuditHistoryMode.Preview;
            formExtractData(service, entitiesList);
        }

        private void formExtractData(IOrganizationService service, List<Entity> entitiesList)
        {
            Service = service;
            this.entitiesList = entitiesList;

            InitializeComponent();
        }

        public void RetrieveAuditHistoryForRecords(string identificator)
        {
            this.fileName = fileName;
            this.identificator = identificator;

            this.fieldToExtract = fieldToExtract;

            if (BackgroundWorkerExtractAuditHistory.IsBusy != true)
            {
                progressExportData.Step = 1;
                progressExportData.Maximum = entitiesList.Count;
                this.Focus();

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


            if (this.retrieveAuditHistoryMode == RetrieveAuditHistoryMode.Download)
            {
                writer = new StreamWriter(filePath);
                csv = new CsvWriter(writer);
                csv.WriteHeader<AuditHistory>();
                csv.NextRecord();
              
            }







            AuditHistoryManager auditHistoryManager = new AuditHistoryManager(Service);


            foreach (Entity entity in entitiesList)
            {
                if (BackgroundWorkerExtractAuditHistory.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                try
                {
                    string keyValue = string.IsNullOrEmpty(entity.GetAttributeValue<string>(identificator)) ? string.Empty : entity.GetAttributeValue<string>(identificator);

                    List<AuditHistory> lsHistory = auditHistoryManager.GetAuditHistoryForRecord(entity.Id, entity.LogicalName, entity.GetAttributeValue<string>(identificator), ref lslog);

                    if (this.retrieveAuditHistoryMode == RetrieveAuditHistoryMode.Preview)
                    {
                        lsStory.AddRange(lsHistory);
                    }
                    else
                    {
                       
                        csv.WriteRecords<AuditHistory>(FilterDataManager.ApplyFilterData(lsHistory, filterData));
                        csv.Flush();
                    }
                    
                    BackgroundWorkerExtractAuditHistory.ReportProgress(1, keyValue);
                }
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                    return;
                }
            }




            //MessageBox.Show(MessageAuditHistoryExtracted, TitleExportSuccess, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BackgroundWorkerExtractAuditHistory_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblCurrentRow.Text = e.UserState.ToString();
            progressExportData.PerformStep();
        }

        private void BackgroundWorkerExtractAuditHistory_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (this.retrieveAuditHistoryMode == RetrieveAuditHistoryMode.Download)
            {
                csv.Flush();
                writer.Close();
            }

            if (OnExtractCompleted != null)
            {
                OnExtractCompleted(lsStory, lslog);
            }
            this.Close();
        }
        #endregion
    }
}
