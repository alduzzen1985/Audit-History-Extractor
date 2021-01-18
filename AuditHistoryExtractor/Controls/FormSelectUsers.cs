using AuditHistoryExtractor.Classes;
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
    public partial class FormSelectUsers : Form
    {
        List<string> selectedRecords;
        private List<User> lsUsers;
        private bool selectAll = false;


        public delegate void UsersSelected(List<User> lsUsers);
        public event UsersSelected OnUserSelected;


        public FormSelectUsers(List<User> lsUsers)
        {
            InitializeComponent();
            selectedRecords = new List<string>();
            this.lsUsers = lsUsers;
            FillListView(lsUsers);

        }

        private void FillListView(List<User> lsUsers)
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


            foreach (string selectedItem in selectedRecords)
            {
                if (lstViewUsers.Items.ContainsKey(selectedItem))
                {
                    lstViewUsers.Items[selectedItem].Checked = true;
                }

               
            }

            lstViewUsers.ItemChecked += lstViewUsers_ItemChecked;
        }

        private void btnSelectUnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lstItem in lstViewUsers.Items)
            {
                lstItem.Checked = !selectAll;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            List<User> lstSelectedUsers = new List<User>();
            foreach (ListViewItem lstItem in lstViewUsers.CheckedItems)
            {
                lstSelectedUsers.Add(new User(new Guid(lstItem.Name), lstItem.SubItems[1].Text, lstItem.Text));
            }

            if (OnUserSelected != null)
            {
                OnUserSelected(lstSelectedUsers);
            }
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


            string txt = txtUser.Text.ToLower();
            FillListView(lsUsers.Where(x => x.FullName.ToLower().Contains(txt) || x.Username.Contains(txt)).ToList());
        }

        private void lstViewUsers_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                selectedRecords.Add(e.Item.Name);
            }
            else
            {
                selectedRecords.Remove(e.Item.Name);
            }

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                string txt = txtUser.Text.ToLower();
                FillListView(lsUsers.Where(x => x.FullName.ToLower().Contains(txt) || x.Username.Contains(txt)).ToList());

            }
        }
    }
}
