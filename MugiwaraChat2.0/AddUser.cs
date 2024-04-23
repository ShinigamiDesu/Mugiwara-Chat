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
    public partial class AddUser : UserControl
    {
        DataIO dataIO = new DataIO();
        public string loggedID{ get; set; }
        private string _UserID;
        private string _Username;
        private string _FullName;
        private Image _PFP;

        public string UserID { get { return _UserID; } set { _UserID = value; } }
        public string Username { get { return _Username; } set { _Username = value; lbl_username.Text = value; } }
        public string FullName { get { return _FullName; } set { _FullName = value; lbl_FullName.Text = value; } }
        public Image PFP { get { return _PFP; } set { _PFP = value; pic_PFP.Image = value; } }



        public AddUser()
        {
            InitializeComponent();
        }

        private void pic_add_Click(object sender, EventArgs e)
        {
            if (dataIO.checkFriendRequest(loggedID, _UserID))
            {
                MessageBox.Show("A Friend Request is Already in Place...");
            }
            else if (dataIO.CheckFriends(loggedID, _UserID))
            {
                MessageBox.Show("You are already friends...");
            }
            else 
            {
                int ID1 = int.Parse(loggedID);
                int ID2 = int.Parse(_UserID);
                dataIO.sendFriendRequest(ID1, ID2, Username);
            }
        }

        public void setButtonVisible(bool value) 
        { 
            pic_add.Visible = value;
        }
    }
}
