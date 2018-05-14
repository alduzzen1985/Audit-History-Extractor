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
using System.Resources;
using System.Reflection;
using System.Globalization;
using XrmToolBox.Extensibility.Interfaces;
using XrmToolBox;
using XrmToolBox.New;

namespace AuditHistoryExtractor
{
    public partial class MyPluginControl : PluginControlBase, IMessageBusHost
    {
        public MyPluginControl()
        {
            InitializeComponent();
        }

        #region Messages Constants
        private const string MessageRetrievingEntities = "Retrieving entities with Enabled Audit";
        private const string MessageMustBeConnectedToOrganization = "You must be connected to an Organization.";
        private const string MessageFetchXMLRequired = "A FetchXml is required to filter the data to extract.";
        private const string MessageValidatingFetchXML = "Validating FetchXml and extracting Data.";
        private const string MessageMismatchEntitySelectedAndFetchXML = "In the FetchXml you are extracting data for {0} entity instead of the selected entity {1}";
        private const string MessageFetchXMLBuilderNotFound = "FetchXML Builder not found. Please install it";

        private const string MessageNoAuditHistoryForSelectedRecords = "No audit history data available for selected records.";
        private const string MessageToMuchRecords = "More then 5000 records have been extracted. Try to reduce the amount of records to extract.";
        private const string ErrorMessageFetchXML = "An error in FetchXML has been found : ";
        private const string TitleNoFetchXML = "No FetchXML Set.";
        private const string TitleNoFetchXMLBuilder = "Fetch XML Builder Error.";



        #endregion

        #region Variables
        string currentEntitySelected;
        FetchExpression fetchExpressionRecordsToExtract;
        EntityCollection recordsExtracted;

        private List<ListViewItem> itemsWithAuditEnabled;
        private List<ListViewItem> itemsWithAuditDisabled;
        private List<ComboBoxEntityField> listFieldsForEntity;

        public event EventHandler<MessageBusEventArgs> OnOutgoingMessage;
        #endregion

        #region Methods to fill entities and fields
        public void RetrieveAndFillEntitiesList()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = MessageRetrievingEntities,
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
                lblSelectedEntity.Text = e.Item.Text;
                GetListOfFieldsForEntity(currentEntitySelected);
                FillComboListFields();
            }
        }

        private void btnExtractAuditHistory_Click_1(object sender, EventArgs e)
        {


            if (Service == null)
            {
                DialogResult dialogResult = MessageBox.Show(MessageMustBeConnectedToOrganization,
                                TitleNoFetchXML,
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtFetchXML.Text))
            {
                DialogResult dialogResult = MessageBox.Show(MessageFetchXMLRequired,
                                 TitleNoFetchXML,
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            WorkAsync(new WorkAsyncInfo
            {
                Message = MessageValidatingFetchXML,
                Work = (w, ev) =>
                {
                    try
                    {
                        fetchExpressionRecordsToExtract = new FetchExpression(txtFetchXML.Text);
                        recordsExtracted = Service.RetrieveMultiple(fetchExpressionRecordsToExtract);

                        if (recordsExtracted != null && !recordsExtracted.EntityName.Equals(currentEntitySelected))
                        {
                            ev.Result = string.Format(MessageMismatchEntitySelectedAndFetchXML, recordsExtracted, currentEntitySelected);
                            return;
                        }
                        if (recordsExtracted.Entities.Count == 0)
                        {
                            ev.Result = MessageNoAuditHistoryForSelectedRecords;
                            return;
                        }
                        if (recordsExtracted.Entities.Count == 5000)
                        {
                            ev.Result = MessageToMuchRecords;

                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        ev.Result = ErrorMessageFetchXML + ex.Message;
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
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        #region FetchXML Builder 

        private void tbOpenFetchXMLBuilder_Click(object sender, EventArgs e)
        {
            string fetchXMLBuilderName = "FetchXML Builder";
            if (IsPluginInstalled(fetchXMLBuilderName))
            {
                OnOutgoingMessage(this, new MessageBusEventArgs("FetchXML Builder")
                {
                    TargetArgument = txtFetchXML.Text
                });

            }
            else
            {
                MessageBox.Show(MessageFetchXMLBuilderNotFound,
                                  TitleNoFetchXMLBuilder,
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OnIncomingMessage(MessageBusEventArgs message)
        {
            if (message.SourcePlugin == "FetchXML Builder" &&
                message.TargetArgument as string != null)
            {
                txtFetchXML.Text = message.TargetArgument as string;
            }
        }

        /// <summary>
        /// Check if the Plugin is installed. Temporary solution to avoid recursive Message 
        /// </summary>
        /// <param name="pluginName">Plugin to verify if exists</param>
        /// <returns></returns>
        private bool IsPluginInstalled(string pluginName)
        {
            PluginManagerExtended pluginsManager = new PluginManagerExtended(new PluginsForm()) { IsWatchingForNewPlugins = true };
            pluginsManager.Initialize();
            var plugin = pluginsManager.ValidatedPlugins.FirstOrDefault(p => p.Metadata.Name == pluginName);
            return plugin != null;
        }

        #endregion 

    }
}
