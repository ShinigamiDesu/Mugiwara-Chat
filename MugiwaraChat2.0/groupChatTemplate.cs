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
    public partial class groupChatTemplate : UserControl
    {
        DataIO dataIO = new DataIO();
        public string loggedID { get; set; }
        private string _groupID;
        private string _Name;
        private string _Members;
        private Image _PFP;
        private MainPage mainPage;

        public string GroupID { get { return _groupID; } set { _groupID = value; } }
        public string Username { get { return _Name; } set { _Name = value; lbl_name.Text = value; } }
        public Image PFP { get { return _PFP; } set { _PFP = value; pic_PFP.Image = value; } }


        public groupChatTemplate(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        public void generateMemberCount() 
        {
            DataTable dt = dataIO.getGroupMembers(GroupID);
            DataTable dt1 = dataIO.getOnlineMembers(GroupID);
            lbl_members.Text = dt.Rows.Count.ToString() + " Members • " + dt1.Rows.Count.ToString() + " Online";
            _Members = lbl_members.Text;
        }

        private void groupChatTemplate_Load(object sender, EventArgs e)
        {
            generateMemberCount();
        }

        private void pic_forward_Click(object sender, EventArgs e)
        {
            mainPage.generateGroupChat(Username, GroupID, PFP, _Members);
        }
    }
}
