using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MugiwaraChat2._0
{
    public partial class groupSettings : UserControl
    {

        public string loggedID {  get; set; }
        public string groupID { get; set; }
        private string _Name;
        private string _Members;
        private Image _PFP;

        public string Username { get { return _Name; } set { _Name = value; } }
        public string Members { get { return _Members; } set { _Members = value; lbl_total.Text = value;  } }
        public Image PFP { get { return _PFP; } set { _PFP = value;  } }

        DataIO dataIO = new DataIO();
        private MainPage mainPage;

        public groupSettings(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        private void groupSettings_Load(object sender, EventArgs e)
        {
            DataTable dt = dataIO.getGroupMembers(groupID);
            DataTable dt1 = dataIO.getOnlineMembers(groupID);
            lbl_total.Text = dt.Rows.Count.ToString() + " Members • " + dt1.Rows.Count.ToString() + " Online";
            generateGroupMembers();
        }

        public void generateGroupMembers() 
        {
            members_panel.Controls.Clear();
            DataTable dt = dataIO.getGroupMembers(groupID);
            DataTable isAdmin = dataIO.checkGroupAdmin(groupID, loggedID);
            if (dt != null)
            {
                groupMembersTemplate[] listItems = new groupMembersTemplate[dt.Rows.Count];
                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        listItems[i] = new groupMembersTemplate(this);
                        listItems[i].loggedID = loggedID;
                        listItems[i].GroupID = groupID;
                        if (isAdmin.Rows[0]["isAdmin"].ToString() == "1")
                        {
                            listItems[i].setAdminControl(true);
                        }
                        // Adding User Image
                        MemoryStream ms = new MemoryStream((byte[])row["user_PFP"]);
                        listItems[i].PFP = new Bitmap(ms);
                        // Adding User Full name
                        listItems[i].FullName = row["user_FN"].ToString() + " " + row["user_LN"].ToString();
                        // Adding User ID
                        listItems[i].UserID = row["user_ID"].ToString();
                        ///////////////////////////////////////////////////////////////
                        if (row["isAdmin"].ToString() == "1") 
                        {
                            listItems[i].Username = row["user_username"].ToString() + " • Admin";
                        }
                        else 
                        {
                            listItems[i].Username = row["user_username"].ToString();
                        }
                        if (row["user_Status"].ToString() == "1")
                        {
                            listItems[i].Status = pic_green.Image;
                        }
                        else if (row["user_Status"].ToString() == "0")
                        {
                            listItems[i].Status = pic_red.Image;
                        }
                        if(row["isAdmin"].ToString() == "0") 
                        {
                            listItems[i].setRemoveAdmin(false);
                        }
                        else if(row["isAdmin"].ToString() == "1") 
                        {
                            listItems[i].setMakeAdmin(false);
                        }
                        if (row["user_ID"].ToString() == loggedID)
                        {
                            listItems[i].setRemoveFromGroup(false);
                        }
                        else
                        {
                            listItems[i].setRemoveFromGroup(true);
                        }
                        members_panel.Controls.Add(listItems[i]);
                    }
                }
            }
        }

        private void pic_back_Click(object sender, EventArgs e)
        {
            mainPage.generateGroupChat(_Name, groupID, PFP, lbl_total.Text);
        }

        private void btn_leave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are about to leave the group...", "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                int ID1 = int.Parse(loggedID);
                int ID2 = int.Parse(groupID);
                dataIO.deleteUserFromGroup(ID1, ID2);
                mainPage.generateGroups();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            mainPage.generateAddMember(Username, groupID);
        }
    }
}
