using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MugiwaraChat2._0
{
    public partial class groupMembersTemplate : UserControl
    {
        DataIO dataIO = new DataIO();
        public string loggedID { get; set; }
        public string GroupID { get; set; }
        private string _UserID;
        private string _Username;
        private string _FullName;
        private Image _PFP;
        private Image _Status;
        private MainPage mainPage;
        private groupSettings groupSettings;

        public string UserID { get { return _UserID; } set { _UserID = value; } }
        public string Username { get { return _Username; } set { _Username = value; lbl_username.Text = value; } }
        public string FullName { get { return _FullName; } set { _FullName = value; lbl_FullName.Text = value; } }
        public Image PFP { get { return _PFP; } set { _PFP = value; pic_PFP.Image = value; } }
        public Image Status { get { return _Status; } set { _Status = value; pic_status.Image = value; } }

        public groupMembersTemplate(groupSettings groupSettings)
        {
            InitializeComponent();
            this.groupSettings = groupSettings;
        }

        public void setAdminControl(bool value) 
        {
            pic_action.Visible = value;
        }

        private void pic_action_Click(object sender, EventArgs e)
        {
            if(adminPanel.Visible == false) 
            {
                panel1.Location = new Point(4, 105);
                adminPanel.Visible = true;
            }
            else 
            {
                panel1.Location = new Point(4, 84);
                adminPanel.Visible = false;
            }
        }

        private void groupMembersTemplate_Load(object sender, EventArgs e)
        {
        }

        public void setRemoveAdmin(bool value) 
        { 
            btn_removeAdmin.Visible = value;
        }

        public void setMakeAdmin(bool value)
        {
            btn_assign.Visible = value;
        }

        public void setRemoveFromGroup(bool value)
        {
            btn_removeGroup.Visible = value;
        }

        private void btn_assign_Click(object sender, EventArgs e)
        {
            dataIO.setGroupAdmin(GroupID, UserID);
        }

        private void btn_removeGroup_Click(object sender, EventArgs e)
        {
            int groupID = int.Parse(GroupID);
            int userID = int.Parse(UserID);
            DataTable dt2 = dataIO.checkGroupCreator(GroupID);
            if (dt2.Rows[0]["group_CreatorID"].ToString() == UserID)
            {
                MessageBox.Show("Cannot Remove Since They Are The Creator Of The Group...");
            }
            else 
            {
                dataIO.removeMemberFromGroup(groupID, userID);
                DataTable dt = dataIO.getGroupMembers(GroupID);
                DataTable dt1 = dataIO.getOnlineMembers(GroupID);
                groupSettings.Members = dt.Rows.Count.ToString() + " Members • " + dt1.Rows.Count.ToString() + " Online";
                groupSettings.generateGroupMembers();
            }
            
        }

        private void btn_removeAdmin_Click(object sender, EventArgs e)
        {
            dataIO.removeAdmin(GroupID, UserID);    
        }
    }
}
