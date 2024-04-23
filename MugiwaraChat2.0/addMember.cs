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
    public partial class addMember : UserControl
    {
        public string loggedID { get; set; }
        public string groupID { get; set; }
        private string _UserID;
        private string _Username;
        private string _FullName;
        private Image _PFP;
        private MainPage mainPage;
        DataIO dataIO = new DataIO();

        public string UserID { get { return _UserID; } set { _UserID = value; } }
        public string Username { get { return _Username; } set { _Username = value; lbl_username.Text = value; } }
        public string FullName { get { return _FullName; } set { _FullName = value; lbl_FullName.Text = value; } }
        public Image PFP { get { return _PFP; } set { _PFP = value; pic_PFP.Image = value; } }

        public addMember(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        private void pic_add_Click(object sender, EventArgs e)
        {
            int userID = int.Parse(UserID);
            int GroupID = int.Parse(groupID);
            dataIO.addGroupMember(userID, GroupID);
            mainPage.generateGroups();
        }
    }
}
