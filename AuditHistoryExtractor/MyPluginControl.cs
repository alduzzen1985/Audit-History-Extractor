using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata.Query;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Messages;
using AuditHistoryExtractor.AppCode;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk;
using AuditHistoryExtractor.Controls;
using System.Diagnostics;

namespace AuditHistoryExtractor
{
    public partial class MyPluginControl : PluginControlBase
    {
        public MyPluginControl()
        {
            InitializeComponent();
        }

        #region Variables
        string currentEntitySelected;
        FetchExpression fetchExpressionRecordsToExtract;
        EntityCollection recordsExtracted;

        private List<ListViewItem> itemsWithAuditEnabled;
        private List<ListViewItem> itemsWithAuditDisabled;
        private List<ComboBoxEntityField> listFieldsForEntity;
        #endregion

        #region Methods to fill entities and fields
        public void RetrieveAndFillEntitiesList()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Retrieving entities with Enabled Audit",
                Work = (w, e) =>
                {
                    GetListEntitiesWithAuditEnabled();
                    GetListEntitiesWithAuditDisabled();
                },
                ProgressChanged = e =>
                {
                    // If progress has to be notified to user, use the following method:
                    //SetWorkingMessage("Message to display");
                },
                PostWorkCallBack = e =>
                {
                    FillListEntitiesWithAuditEnabled();
                    FillListEntitiesWithAuditDisabled();
                },
                AsyncArgument = null,
                IsCancelable = true,
                MessageWidth = 340,
                MessageHeight = 150
            });
        }

        /// <summary>
        /// Set the Entities list with Audit Disabled
        /// </summary>
        public void GetListEntitiesWithAuditDisabled()
        {
            List<EntityMetadata> entitiesWithAuditDisabled = MetaDataManager.GetEntitiesWithAuditListEnabledOrDisabled(Service, false);
            itemsWithAuditDisabled = new List<ListViewItem>();

            entitiesWithAuditDisabled = entitiesWithAuditDisabled.Where(o => o.DisplayName.UserLocalizedLabel != null).OrderBy(o => o.DisplayName.UserLocalizedLabel.Label).ToList();


            foreach (EntityMetadata entityMetaDataInfo in entitiesWithAuditDisabled)
            {
                if (entityMetaDataInfo.DisplayName.UserLocalizedLabel != null)
                {
                    itemsWithAuditDisabled.Add(new ListViewItem()
                    {
                        Text = entityMetaDataInfo.DisplayName.UserLocalizedLabel.Label + "( " + entityMetaDataInfo.LogicalName + ")",
                        Name = entityMetaDataInfo.LogicalName
                    });
                }
            }
        }

        /// <summary>
        /// Set the Entities list with Audit Enabled
        /// </summary>
        public void GetListEntitiesWithAuditEnabled()
        {
            List<EntityMetadata> entitiesWithAuditEnabled = MetaDataManager.GetEntitiesWithAuditListEnabledOrDisabled(Service, true);
            itemsWithAuditEnabled = new List<ListViewItem>();
            entitiesWithAuditEnabled = entitiesWithAuditEnabled.Where(o => o.DisplayName.UserLocalizedLabel != null).OrderBy(o => o.DisplayName.UserLocalizedLabel.Label).ToList();

            foreach (EntityMetadata entityMetaDataInfo in entitiesWithAuditEnabled)
            {
                itemsWithAuditEnabled.Add(new ListViewItem()
                {
                    Text = entityMetaDataInfo.DisplayName.UserLocalizedLabel.Label + "( " + entityMetaDataInfo.LogicalName + ")",
                    Name = entityMetaDataInfo.LogicalName
                });
            }
        }

        /// <summary>
        /// Retrieve all fields for a specified Entity
        /// </summary>
        /// <param name="entityLogicalName"></param>
        public void GetListOfFieldsForEntity(string entityLogicalName)
        {
            List<EntityMetadata> entityFields = MetaDataManager.GetFieldListForEntity(Service, entityLogicalName);
            listFieldsForEntity = new List<ComboBoxEntityField>();
            foreach (var attributeMetadataInfo in entityFields[0].Attributes)
            {
                if (attributeMetadataInfo.DisplayName.UserLocalizedLabel != null)
                {
                    listFieldsForEntity.Add(new ComboBoxEntityField(attributeMetadataInfo));
                }
            }
        }

        /// <summary>
        /// Fill the List View for Entities with Audit Enabled
        /// </summary>
        public void FillListEntitiesWithAuditEnabled()
        {
            lstEntitiesWithAuditEnabled.Items.Clear();
            lstEntitiesWithAuditEnabled.Items.AddRange(itemsWithAuditEnabled.ToArray());
        }

        /// <summary>
        /// Fill the List View for Entities with Audit Disabled
        /// </summary>
        public void FillListEntitiesWithAuditDisabled()
        {
            lstEntitiesWithAuditDisabled.Items.Clear();
            lstEntitiesWithAuditDisabled.Items.AddRange(itemsWithAuditDisabled.ToArray());
        }


        /// <summary>
        /// Fill Comboboxes to extract the data
        /// </summary>
        public void FillComboListFields()
        {
            cmbFieldToExtract.DataSource = null;
            cmbPrimaryKey.DataSource = null;

            cmbFieldToExtract.Items.Clear();
            cmbPrimaryKey.Items.Clear();

            ComboBoxEntityField[] elementExtract = new ComboBoxEntityField[listFieldsForEntity.Count];
            listFieldsForEntity.CopyTo(elementExtract);

            cmbFieldToExtract.DisplayMember = "Text";
            cmbFieldToExtract.ValueMember = "Value";
            cmbFieldToExtract.DataSource = listFieldsForEntity.OrderBy(o => o.Text).ToList();

            cmbPrimaryKey.DisplayMember = "Text";
            cmbPrimaryKey.ValueMember = "Value";
            cmbPrimaryKey.DataSource = listFieldsForEntity.OrderBy(o => o.Text).ToList();
        }

        #endregion

        #region Form Events
        private void tbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void tbFromEntitiesEnabled_Click(object sender, EventArgs e)
        {
            ExecuteMethod(RetrieveAndFillEntitiesList);
        }

        private void lstEntities_ItemSelectionChanged_1(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                currentEntitySelected = e.Item.Name;
                GetListOfFieldsForEntity(currentEntitySelected);
                FillComboListFields();
            }
        }

        private void btnExtractAuditHistory_Click_1(object sender, EventArgs e)
        {
            if (Service == null)
            {
                DialogResult dialogResult = MessageBox.Show("You must be connected to an Organization.",
                                "No FetchXML Set",
                                 MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrEmpty(txtFetchXML.Text))
            {
                DialogResult dialogResult = MessageBox.Show("A FetchXml is required to filter the data to extract.",
                                 "No FetchXML Set",
                                  MessageBoxButtons.OK);
                return;
            }

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Validating FetchXml and extracting Data.",
                Work = (w, ev) =>
                {
                    try
                    {
                        fetchExpressionRecordsToExtract = new FetchExpression(txtFetchXML.Text);
                        recordsExtracted = Service.RetrieveMultiple(fetchExpressionRecordsToExtract);

                        if (recordsExtracted != null && !recordsExtracted.EntityName.Equals(currentEntitySelected))
                        {
                            ev.Result = "The Entity in the FetchXML doesn't equal to the Entity to extract the data";
                            return;
                        }
                        if (recordsExtracted.Entities.Count == 0)
                        {
                            ev.Result = "No audit history to extract for the selected records.";
                            return;
                        }
                        if (recordsExtracted.Entities.Count == 5000)
                        {
                            ev.Result = "More then 5000 records have been extracted. Try to reduce the amount of records to extract.";

                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        ev.Result = "An error in FetchXML has been found : " + ex.Message;
                    }
                },
                ProgressChanged = ev =>
                {
                    // If progress has to be notified to user, use the following method:
                    //SetWorkingMessage("Message to display");
                },
                PostWorkCallBack = ev =>
                {
                    if (ev.Result != null)
                    {
                        DialogResult dialogResult = MessageBox.Show(ev.Result.ToString(),
                                "Error",
                                 MessageBoxButtons.OK);
                    }
                    else
                    {

                        saveFileDialog1.Filter = "CSV Comma Separated (*.csv)|*.csv|CSV Semicolon Separated (*.csv)|*.csv";
                        saveFileDialog1.DefaultExt = "csv";
                        saveFileDialog1.AddExtension = true;
                        saveFileDialog1.ShowDialog();
                    }
                },
                AsyncArgument = null,
                IsCancelable = true,
                MessageWidth = 340,
                MessageHeight = 150
            });
        }

        private void saveFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            string csvSeparator = ",";
            if (saveFileDialog1.FilterIndex == 1) { csvSeparator = ","; }
            if (saveFileDialog1.FilterIndex == 2) { csvSeparator = ";"; }
         
            var wsmDialog = new FormExtractData(Service, recordsExtracted, csvSeparator);
            wsmDialog.Show();
            wsmDialog.Shown += WsmDialog_Shown;
        }

        private void WsmDialog_Shown(object sender, EventArgs e)
        {
            (sender as FormExtractData).ExportDataInCSV(saveFileDialog1.FileName, cmbPrimaryKey.SelectedValue.ToString(), cmbFieldToExtract.SelectedValue.ToString());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://www.sql2fetchxml.com/");
            Process.Start(sInfo);
        }

        #endregion

       

  
    }
}
