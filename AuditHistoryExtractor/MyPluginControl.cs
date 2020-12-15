using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using AuditHistoryExtractor.AppCode;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk;
using AuditHistoryExtractor.Controls;
using System.Diagnostics;
using XrmToolBox.Extensibility.Interfaces;
using XrmToolBox;
using AuditHistoryExtractor.Classes;
using AuditHistoryExtractor.Collections;
using AuditHistoryExtractor.Enums;
using System.Web.UI.WebControls;
using AuditHistoryExtractor.Classes.Managers;
using AuditHistoryExtractor.Classes.Models;

namespace AuditHistoryExtractor
{
    public partial class MyPluginControl : PluginControlBase, IMessageBusHost
    {
        public MyPluginControl()
        {
            InitializeComponent();

            chkLstOperations.DataSource = null;
            chkLstOperations.Items.Clear();
            chkLstOperations.DataSource = AuditHistoryCollections.operations;
            chkLstOperations.DisplayMember = "description";
            chkLstOperations.ValueMember = "operationid";

            chkLstActions.DataSource = null;
            chkLstActions.Items.Clear();
            chkLstActions.DataSource = AuditHistoryCollections.actions;
            chkLstActions.DisplayMember = "description";
            chkLstActions.ValueMember = "operationid";

        }

        #region Messages Constants
        private const string MessageRetrievingEntities = "Retrieving entities with Enabled Audit";
        private const string MessageMustBeConnectedToOrganization = "You must be connected to an Organization.";
        private const string MessageFetchXMLRequired = "A FetchXml is required to filter the data to extract.";
        private const string MessageValidatingFetchXML = "Validating FetchXml and extracting Data.";
        private const string MessageMismatchEntitySelectedAndFetchXML = "In the FetchXml you are extracting data for {0} entity instead of the selected entity {1}";
        private const string MessageFetchXMLBuilderNotFound = "FetchXML Builder not found. Please install it";
        private const string MessageOldVersion = "Dynamic CRM version 8 or newer is required";


        private const string MessageNoAuditHistoryForSelectedRecords = "No audit history data available for selected records.";
        private const string MessageToMuchRecords = "More then 5000 records have been extracted. Try to reduce the amount of records to extract.";
        private const string ErrorMessageFetchXML = "An error in FetchXML has been found : ";
        private const string TitleNoFetchXML = "No FetchXML Set.";
        private const string TitleNoFetchXMLBuilder = "Fetch XML Builder Error.";
        private const string TitleVersionNotValid = "Version not valid.";

        private const string RetrievingEntityViewAndFields = "Retrieving Entity Detail";
        private const string FileSavedSuccessfully = "File saved successfully !";
        private const string TitleExportCSV = "Export CSV";



        #endregion

        #region Variables
        private int pageNumber = 1;
        string currentEntitySelected;
        FetchExpression fetchExpressionRecordsToExtract;
        List<Entity> recordsExtracted;
        private enum RetrieveAuditHistoryMode { Preview = 1, Download = 2 };


        private List<ComboBoxEntityField> lsTextFieldsForEntity;
        private List<ComboBoxEntityField> lsAllFieldsForEntity;
        private List<ComboBoxEntities> lsEntities;
        private List<ComboBoxEntityField> lsSelectedAttributes;

        List<Guid> lsSelectedUsers;

        List<ViewDetail> lsViewsForEntity;
        List<EntityMetadata> lsStringFieldsForEntity;
        List<EntityMetadata> lsAllFields;
        List<AuditHistory> lsAuditHistory;

        private List<User> lsUsers;
        //private List<User> lsSelectedUsers;

        private bool selectAll = false;

        private int NumberOfRecordsToDisplay
        {
            get { return string.IsNullOrEmpty(cmbNumberOfRecords.SelectedItem.ToString()) ? 10 : Int32.Parse(cmbNumberOfRecords.SelectedItem.ToString()); }
        }


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
                    GetListEntities();


                    UserHelper userHelper = new UserHelper(Service);
                    lsUsers = userHelper.GetListUsers();
                    lsSelectedUsers = new List<Guid>();

                },
                ProgressChanged = e =>
                {
                    // If progress has to be notified to user, use the following method:
                    //SetWorkingMessage("Message to display");
                },
                PostWorkCallBack = e =>
                {
                    FillListEntities(chkEntitiesWithAudit.Checked);
                    FillListViewUsers(lsUsers);
                },
                AsyncArgument = null,
                IsCancelable = true,
                MessageWidth = 340,
                MessageHeight = 150
            });
        }


        public void GetListEntities()
        {

            lsEntities = MetaDataManager.GetListEntities(Service);
        }

        private void FillListEntities(bool withAuditEnabled)
        {
            cmbEntities.DataSource = null;
            cmbEntities.Items.Clear();
            cmbEntities.DataSource = lsEntities.Where(x => x.IsAuditEnabled == withAuditEnabled).ToList();
            cmbEntities.DisplayMember = "DisplayName";
            cmbEntities.ValueMember = "ObjectTypeCode";


        }





        /// <summary>
        /// Retrieve all fields for a specified Entity
        /// </summary>
        /// <param name="entityLogicalName"></param>
        public void FillComboListFieldsForEntity(string entityLogicalName)
        {
            if (lsStringFieldsForEntity != null)
            {
                lsTextFieldsForEntity = lsStringFieldsForEntity[0].Attributes.Where(x => x.DisplayName.UserLocalizedLabel != null).Select(x => new ComboBoxEntityField()
                {
                    Value = x.LogicalName,
                    AttributeType = x.AttributeTypeName.Value,
                    Text = x.DisplayName.UserLocalizedLabel.Label + " (" + x.LogicalName + ")"
                }).ToList();

                cmbPrimaryKey.DataSource = null;
                cmbPrimaryKey.Items.Clear();
                cmbPrimaryKey.DisplayMember = "Text";
                cmbPrimaryKey.ValueMember = "Value";
                cmbPrimaryKey.DataSource = lsTextFieldsForEntity.OrderBy(o => o.Text).ToList();
                if (lsStringFieldsForEntity[0].PrimaryNameAttribute != null)
                {
                    cmbPrimaryKey.SelectedItem = lsTextFieldsForEntity.Where(x => x.Value == lsStringFieldsForEntity[0].PrimaryNameAttribute).FirstOrDefault();
                }


                lsAllFieldsForEntity = lsAllFields[0].Attributes.Where(x => x.DisplayName.UserLocalizedLabel != null).Select(x => new ComboBoxEntityField()
                {
                    Value = x.LogicalName,
                    AttributeType = x.AttributeTypeName.Value,
                    Text = x.DisplayName.UserLocalizedLabel.Label + " (" + x.LogicalName + ")",
                    DisplayName = x.DisplayName.UserLocalizedLabel.Label
                }).OrderBy(x => x.DisplayName).ToList();

                lsSelectedAttributes = new List<ComboBoxEntityField>();

                FillListAttributes(lsAllFieldsForEntity);

            }

        }



        #endregion

        #region Form Events

        private void tbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void tbFromEntitiesEnabled_Click(object sender, EventArgs e)
        {
            if (ConnectionDetail != null && !string.IsNullOrEmpty(ConnectionDetail.OrganizationVersion))
            {
                int version = 0;
                int.TryParse(ConnectionDetail.OrganizationVersion.Split('.')[0], out version);

                if (version < 7)
                {
                    MessageBox.Show(MessageOldVersion,
                         TitleVersionNotValid,
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ExecuteMethod(RetrieveAndFillEntitiesList);


                }
            }
            else
            {
                MessageBox.Show("Please, connect to CRM.",
                       "No connection",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void saveFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            RetrieveAuditHistory(RetrieveAuditHistoryMode.Download);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://www.sql2fetchxml.com/");
            Process.Start(sInfo);
        }

        private void cmbEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            ComboBoxEntities selectedValue = cmb.SelectedItem as ComboBoxEntities;
            if (selectedValue != null)
            {
                FillComboBoxesFieldaAndViews(selectedValue);
            }
        }

        private void cmbViews_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbViews.SelectedItem != null)
            {

                txtFetchXML.Text = System.Xml.Linq.XDocument.Parse((cmbViews.SelectedItem as ViewDetail).FetchXML).ToString();

                SetButtonPaging(1);
            }
        }

        private void rdbView_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbView.Enabled)
            {
                grpFilterByView.Visible = true;
                grpFilterByFetchXml.Visible = false;
                grpActions.Visible = true;
                grpActions.Location = new Point(grpFilterByView.Location.X, grpFilterByView.Height + grpFilterByView.Location.Y);
                tbOpenFetchXMLBuilder.Visible = false;
            }
        }

        private void rdbFetchXml_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbView.Enabled)
            {
                grpFilterByView.Visible = false;
                grpFilterByFetchXml.Visible = true;
                grpFilterByFetchXml.Location = grpFilterByView.Location;
                grpActions.Visible = true;
                grpActions.Location = new Point(grpFilterByView.Location.X, grpFilterByFetchXml.Height + grpFilterByFetchXml.Location.Y);
                tbOpenFetchXMLBuilder.Visible = true;
            }
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
            PluginManagerExtended.Instance.IsWatchingForNewPlugins = true;
            var plugin = PluginManagerExtended.Instance.ValidatedPlugins.FirstOrDefault(p => p.Metadata.Name == pluginName);
            return plugin != null;
        }

        #endregion



        /// <summary>
        /// Fill the Views and Fields comboboxes by the selected entity
        /// </summary>
        /// <param name="selectedEntity"></param>
        private void FillComboBoxesFieldaAndViews(ComboBoxEntities selectedEntity)
        {

            lblAuditHistoryNotEnabled.Visible = !selectedEntity.IsAuditEnabled;

            WorkAsync(new WorkAsyncInfo
            {
                Message = RetrievingEntityViewAndFields,
                Work = (w, ev) =>
                {
                    try
                    {
                        if (chkPersonalView.Checked)
                        {
                            lsViewsForEntity = MetaDataManager.GetListUserViews(Service, selectedEntity.LogicalName, selectedEntity.ObjectTypeCode);
                        }
                        else
                        {
                            lsViewsForEntity = MetaDataManager.GetListViews(Service, selectedEntity.LogicalName, selectedEntity.ObjectTypeCode, true);
                        }

                        lsAllFields = MetaDataManager.GetListFieldsForEntity(Service, selectedEntity.LogicalName);
                        lsStringFieldsForEntity = MetaDataManager.GetStringFieldsFieldListForEntity(Service, selectedEntity.LogicalName);
                    }
                    catch (Exception ex)
                    {
                        ev.Result = ex.Message;
                    }
                },
                PostWorkCallBack = ev =>
                {
                    if (ev.Result == null)
                    {
                        FillComboListViews();
                        FillComboListFieldsForEntity(selectedEntity.LogicalName);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show(ev.Result.ToString(),
                              "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                },
                AsyncArgument = null,
                IsCancelable = true,
                MessageWidth = 340,
                MessageHeight = 150
            });

        }

        private void FillComboListViews()
        {
            cmbViews.DataSource = null;
            cmbViews.Items.Clear();
            cmbViews.DataSource = lsViewsForEntity;
            cmbViews.ValueMember = "Savedqueryid";
            cmbViews.DisplayMember = "Name";
        }



        #region ButtonActions Download/Preview

        private void btnExtractAuditHistory_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "CSV Comma Separated (*.csv)|*.csv|CSV Semicolon Separated (*.csv)|*.csv";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.ShowDialog();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            RetrieveAuditHistory(RetrieveAuditHistoryMode.Preview, true, pageNumber, NumberOfRecordsToDisplay);
        }


        #endregion

        private bool CheckIfConnectedToCrm()
        {
            if (Service == null)
            {
                DialogResult dialogResult = MessageBox.Show(MessageMustBeConnectedToOrganization,
                                TitleNoFetchXML,
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void RetrieveAuditHistory(RetrieveAuditHistoryMode retrieveMode, bool previewMode = false, int page = 1, int numberOfRecords = 5000)
        {
            if (!CheckIfConnectedToCrm()) { return; }

            if (string.IsNullOrEmpty(txtFetchXML.Text))
            {
                DialogResult dialogResult = MessageBox.Show(MessageFetchXMLRequired,
                                 TitleNoFetchXML,
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            currentEntitySelected = (cmbEntities.SelectedItem as ComboBoxEntities).LogicalName;
            ComboBoxEntityField cmbPrimaryKeySelectedItem = cmbPrimaryKey.SelectedItem as ComboBoxEntityField;
            //ComboBoxEntityField cmbField = cmbFields.SelectedItem as ComboBoxEntityField;


            WorkAsync(new WorkAsyncInfo
            {
                Message = MessageValidatingFetchXML,
                Work = (w, ev) =>
                {
                    try
                    {
                        recordsExtracted = new List<Entity>();
                        bool moreRecords = false;
                        //int page = 1;
                        string cookie = string.Empty;


                        //To retrieve the Identifier of the record
                        string newFetch = FetchXMLHelper.AddAttributeFilter(txtFetchXML.Text, cmbPrimaryKeySelectedItem.Value);

                        do
                        {
                            string xml = "";


                            xml = FetchXMLHelper.AddCookie(newFetch, cookie, page, numberOfRecords);

                            EntityCollection collection = Service.RetrieveMultiple(new FetchExpression(xml));

                            if (collection != null && !collection.EntityName.Equals(currentEntitySelected))
                            {
                                ev.Result = string.Format(MessageMismatchEntitySelectedAndFetchXML, collection.EntityName, currentEntitySelected);
                                return;
                            }
                            if (page == 1 && collection.Entities.Count == 0)
                            {
                                ev.Result = MessageNoAuditHistoryForSelectedRecords;
                                return;
                            }
                            if (collection.Entities.Count > 0)
                            {
                                recordsExtracted.AddRange(collection.Entities);
                                moreRecords = collection.MoreRecords;

                                if (moreRecords)
                                {
                                    page++;
                                    cookie = System.Security.SecurityElement.Escape(collection.PagingCookie);
                                }
                            }

                        } while (moreRecords && retrieveMode == RetrieveAuditHistoryMode.Download);

                        ev.Result = recordsExtracted;
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



                    if (ev.Result != null && ev.Result.GetType().Equals(typeof(String)))
                    {
                        DialogResult dialogResult = MessageBox.Show(ev.Result.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var wsmDialog = new FormExtractData(Service, ev.Result as List<Entity>);
                        wsmDialog.Show();
                        wsmDialog.RetrieveAuditHistoryForRecords(cmbPrimaryKeySelectedItem.Value);

                        if (retrieveMode == RetrieveAuditHistoryMode.Preview)
                        {
                            wsmDialog.OnExtractCompleted += WsmDialog_OnExtractCompleted;
                        }
                        else
                        {
                            wsmDialog.OnExtractCompleted += WsmDialog_OnExtractCompletedSave;
                        }

                    }
                },
                AsyncArgument = null,
                IsCancelable = true,
                MessageWidth = 340,
                MessageHeight = 150
            });
        }

        private void WsmDialog_OnExtractCompleted(List<AuditHistory> lsAuditHistory, List<Log> lsLog)
        {
            this.lsAuditHistory = lsAuditHistory;



            dtGrvPreview.DataSource = FilterData();
            SetBackgroundColor();
            btnNext.Enabled = lsAuditHistory != null && lsAuditHistory.Count > 0;

            dtGrvLogs.DataSource = lsLog;
        }

        private List<AuditHistory> FilterData()
        {
            List<AuditHistory> lsAuditHistoryFiltered = lsAuditHistory;

            if (lsAuditHistoryFiltered == null) { return null; }

            if (chkLstOperations.CheckedItems.Count > 0)
            {
                List<int> selectedOperations = new List<int>();
                foreach (Operation operationItem in chkLstOperations.CheckedItems)
                {
                    selectedOperations.Add(operationItem.operationid);
                }

                lsAuditHistoryFiltered = lsAuditHistoryFiltered.Where(x => selectedOperations.Contains(x.OperationId)).ToList();
            }

            if (chkLstActions.CheckedItems.Count > 0)
            {
                List<int> selectedActions = new List<int>();
                foreach (Operation operationItem in chkLstActions.CheckedItems)
                {
                    selectedActions.Add(operationItem.operationid);
                }

                lsAuditHistoryFiltered = lsAuditHistoryFiltered.Where(x => selectedActions.Contains(x.ActionId)).ToList();
            }


            if (lsSelectedUsers != null && lsSelectedUsers.Count > 0)
            {
                lsAuditHistoryFiltered = lsAuditHistoryFiltered.Where(x => (lsSelectedUsers).Contains(x.UserId)).ToList();
            }

            if (dtpDateFrom.Format != DateTimePickerFormat.Custom)
            {
                lsAuditHistoryFiltered = lsAuditHistoryFiltered.Where(x => x.CreatedOn >= (dtpDateFrom.Value.Date + dtpTimeFrom.Value.TimeOfDay)).ToList();
            }


            if (dtpDateTo.Format != DateTimePickerFormat.Custom)
            {
                lsAuditHistoryFiltered = lsAuditHistoryFiltered.Where(x => x.CreatedOn <= (dtpDateTo.Value.Date + dtpTimeTo.Value.TimeOfDay)).ToList();
            }


            if (lstAttributes.CheckedItems.Count > 0)
            {
                lsAuditHistoryFiltered = lsAuditHistoryFiltered.Where(x => lsSelectedAttributes.Where(a => x.AttributeName == a.Value).Any()).ToList();
            }



            return lsAuditHistoryFiltered;
        }



        private void WsmDialog_OnExtractCompletedSave(List<AuditHistory> lsAuditHistory, List<Log> lsLog)
        {

            //Fill

            dtGrvLogs.DataSource = lsLog;


            List<int> selectedOperations = new List<int>();
            foreach (Operation operationItem in chkLstOperations.CheckedItems)
            {
                selectedOperations.Add(operationItem.operationid);
            }

            string csvSeparator = ",";
            if (saveFileDialog1.FilterIndex == 1) { csvSeparator = ","; }
            if (saveFileDialog1.FilterIndex == 2) { csvSeparator = ";"; }

            ComboBoxEntityField cmbPrimaryKeySelectedItem = cmbPrimaryKey.SelectedItem as ComboBoxEntityField;

            try
            {
                CSVHelper.WriteFile(saveFileDialog1.FileName, csvSeparator, cmbPrimaryKeySelectedItem.Text, FilterData());
                DialogResult dialogResult = MessageBox.Show(FileSavedSuccessfully,
                                TitleExportCSV,
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show(ex.Message,
                               TitleExportCSV,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void SetBackgroundColor()
        {
            Guid previousGuid = Guid.Empty;
            Color gray = Color.FromArgb(237, 237, 237);
            Color lastColor = new Color();

            foreach (DataGridViewRow row in dtGrvPreview.Rows)
            {

                AuditHistory history = row.DataBoundItem as AuditHistory;


                if (previousGuid.Equals(Guid.Empty))
                {
                    row.DefaultCellStyle.BackColor = gray;
                }
                else if (previousGuid.Equals(history.RecordId))
                {
                    row.DefaultCellStyle.BackColor = lastColor;
                }
                else if (!history.RecordId.Equals(previousGuid) && lastColor.Equals(gray))
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = gray;
                }

                lastColor = row.DefaultCellStyle.BackColor;
                previousGuid = history.RecordId;
            }
        }

        private void chkPersonalView_CheckedChanged(object sender, EventArgs e)
        {

            ComboBoxEntities selectedValue = cmbEntities.SelectedItem as ComboBoxEntities;
            if (selectedValue != null)
            {
                FillComboBoxesFieldaAndViews(selectedValue);
            }
        }



        private void rdAllFields_CheckedChanged(object sender, EventArgs e)
        {

            //TODO : Logic to enable the Filter for the Attributes
        }

        private void chkEntitiesWithAudit_CheckedChanged(object sender, EventArgs e)
        {
            FillListEntities(chkEntitiesWithAudit.Checked);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SetButtonPaging(pageNumber + 1);
            RetrieveAuditHistory(RetrieveAuditHistoryMode.Preview, true, pageNumber, NumberOfRecordsToDisplay);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            SetButtonPaging(pageNumber - 1);
            RetrieveAuditHistory(RetrieveAuditHistoryMode.Preview, true, pageNumber, NumberOfRecordsToDisplay);
        }


        private void cmbNumberOfRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            pageNumber = 1;
            lblPageNumber.Text = pageNumber.ToString();
            RetrieveAuditHistory(RetrieveAuditHistoryMode.Preview, true, pageNumber, NumberOfRecordsToDisplay);
        }

        private void SetButtonPaging(int page)
        {
            pageNumber = page;
            btnPrevious.Enabled = pageNumber > 1;
            lblPageNumber.Text = pageNumber.ToString();
        }


        private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpDateFrom.Format = DateTimePickerFormat.Long;
            dtpTimeFrom.Format = DateTimePickerFormat.Time;

        }



        private void dtpDateTo_ValueChanged(object sender, EventArgs e)
        {
            dtpDateTo.Format = DateTimePickerFormat.Long;
            dtpTimeTo.Format = DateTimePickerFormat.Time;

        }



        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            if (!CheckIfConnectedToCrm()) { return; }


            dtGrvPreview.DataSource = FilterData();
            SetBackgroundColor();
            btnNext.Enabled = lsAuditHistory != null && lsAuditHistory.Count > 0;
        }

        private void btnClearFrom_Click(object sender, EventArgs e)
        {
            ClearDateAndTimeField(dtpDateFrom, dtpDateFrom);
        }


        private void btnClearTo_Click(object sender, EventArgs e)
        {
            ClearDateAndTimeField(dtpDateTo, dtpTimeTo);
        }


        private void ClearDateAndTimeField(DateTimePicker date, DateTimePicker time)
        {
            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = " ";
            time.Format = DateTimePickerFormat.Custom;
            time.CustomFormat = " ";
        }



        private void btnClearFilters_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < chkLstActions.Items.Count; i++)
            {
                chkLstActions.SetItemChecked(i, false);
            }

            ClearDateAndTimeField(dtpDateFrom, dtpTimeFrom);
            ClearDateAndTimeField(dtpDateTo, dtpTimeTo);

            for (int i = 0; i < chkLstOperations.Items.Count; i++)
            {
                chkLstOperations.SetItemChecked(i, false);
            }



            foreach (ListViewItem item in lstAttributes.Items)
            {
                item.Checked = false;
            }

            foreach (ListViewItem item in lstViewUsers.Items)
            {
                item.Checked = false;
            }

            //Todo : Finish the Clear




        }

        private void pnlPaging_Resize(object sender, EventArgs e)
        {

        }

        private void GrpPaging_Resize(object sender, EventArgs e)
        {
            pnlPaging.Location = new Point()
            {
                X = GrpPaging.Width / 2 - pnlPaging.Width / 2,
                Y = GrpPaging.Height / 2 - pnlPaging.Height / 2
            };
            base.OnResize(e);
        }

        private void drGrwLogs_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dtGrvLogs.Rows.Count > 1)
            {
                foreach (DataGridViewRow currentRow in dtGrvLogs.Rows)
                {
                    SetImageStatusOperation(currentRow);
                }
            }
        }


        private void SetImageStatusOperation(DataGridViewRow currentRow)
        {
            if (currentRow.Cells["infoLog"] != null)
            {
                switch ((InfoLogEnum)currentRow.Cells["infoLog"].Value)
                {
                    case InfoLogEnum.Info:
                        currentRow.Cells["StatusImage"].Value = AuditHistoryExtractor.Properties.Resources.info;
                        break;
                    case InfoLogEnum.Success:
                        currentRow.Cells["StatusImage"].Value = AuditHistoryExtractor.Properties.Resources.success;
                        break;
                    case InfoLogEnum.Error:
                        currentRow.Cells["StatusImage"].Value = AuditHistoryExtractor.Properties.Resources.error;
                        break;

                };
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string txtToSearch = txtSearchAttribute.Text.ToLower();
            FillListAttributes(lsAllFieldsForEntity.Where(x => x.DisplayName.ToLower().Contains(txtToSearch)).
                OrderBy(x => x.DisplayName).ToList());
        }


        private void FillListAttributes(List<ComboBoxEntityField> lsAttributes)
        {
            lstAttributes.ItemChecked -= lstAttributes_ItemChecked;
            lstAttributes.Items.Clear();
            foreach (ComboBoxEntityField field in lsAttributes)
            {
                ListViewItem listItem = new ListViewItem(field.DisplayName);
                listItem.Name = field.Value;
                listItem.SubItems.Add(field.Value);
                listItem.SubItems.Add(field.AttributeType);
                listItem.Checked = (lsSelectedAttributes.Where(x => x.Value == field.Value).Any());
                lstAttributes.Items.Add(listItem);
            }
            lstAttributes.ItemChecked += lstAttributes_ItemChecked;
        }

        private void lstAttributes_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {

                lsSelectedAttributes.Add(new ComboBoxEntityField()
                {
                    DisplayName = e.Item.SubItems[0].Text,
                    Value = e.Item.SubItems[1].Text,
                    AttributeType = e.Item.SubItems[2].Text
                });



                //listSelectedAttributes.Remove(e.Item)

                // selectedRecords.Add(e.Item.Name);
            }
            else
            {
                lsSelectedAttributes.Remove(lsSelectedAttributes.Where(x => x.Value == e.Item.Name).FirstOrDefault());
                //selectedRecords.Remove(e.Item.Name);
            }
        }

        private void txtSearchAttribute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                string txtToSearch = txtSearchAttribute.Text.ToLower();
                FillListAttributes(lsAllFieldsForEntity.Where(x => x.DisplayName.ToLower().Contains(txtToSearch)).
                    OrderBy(x => x.DisplayName).ToList());

            }
        }

        private bool selectAllAttributes = true;

        private void lnkSelectAttributesAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (ListViewItem item in lstAttributes.Items)
            {
                item.Checked = selectAllAttributes;
            }
            selectAllAttributes = !selectAllAttributes;
        }




        private void FillListViewUsers(List<User> lsUsers)
        {//lstViewUsers_ItemChecked


            lstViewUsers.ItemChecked -= lstViewUsers_ItemChecked;


            lstViewUsers.Items.Clear();
            foreach (User user in lsUsers)
            {
                ListViewItem listItem = new ListViewItem(user.FullName);
                listItem.Name = user.UserId.ToString();
                listItem.SubItems.Add(user.Username);
                lstViewUsers.Items.Add(listItem);

            }


            foreach (Guid selectedItem in lsSelectedUsers)
            {
                if (lstViewUsers.Items.ContainsKey(selectedItem.ToString()))
                {
                    lstViewUsers.Items[selectedItem.ToString()].Checked = true;
                }
            }

            lstViewUsers.ItemChecked += lstViewUsers_ItemChecked;
        }


        private void lstViewUsers_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                lsSelectedUsers.Add(new Guid(e.Item.Name));
            }
            else
            {
                lsSelectedUsers.Remove(new Guid(e.Item.Name));
            }

        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lstItem in lstViewUsers.Items)
            {
                lstItem.Checked = !selectAll;
            }
        }



        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                string txt = txtUser.Text.ToLower();
                FillListViewUsers(lsUsers.Where(x => x.FullName.ToLower().Contains(txt) || x.Username.Contains(txt)).ToList());

            }
        }

        private void lnkSelectUsersAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (ListViewItem lstItem in lstViewUsers.Items)
            {
                lstItem.Checked = !selectAll;
            }
            selectAll = !selectAll;
        }

        private void txtUser_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                string txt = txtUser.Text.ToLower();
                FillListViewUsers(lsUsers.Where(x => x.FullName.ToLower().Contains(txt) || x.Username.Contains(txt)).ToList());
            }
        }

        private void chkShowGuid_CheckedChanged(object sender, EventArgs e)
        {

            dtGrvLogs.Columns[2].Visible = chkShowGuid.Checked;

        }
    }
}
