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

    public partial class AllFriends : UserControl
    {
        DataIO dataIO = new DataIO();
        public string loggedID { get; set; }
        private string _UserID;
        private string _Username;
        private string _FullName;
        private Image _PFP;
        private Image _Status;
        private MainPage mainPage;


        public string UserID { get { return _UserID; } set { _UserID = value; } }
        public string Username { get { return _Username; } set { _Username = value; lbl_username.Text = value; } }
        public string FullName { get { return _FullName; } set { _FullName = value; lbl_FullName.Text = value; } }
        public Image PFP { get { return _PFP; } set { _PFP = value; pic_PFP.Image = value; } }
        public Image Status { get { return _Status; } set { _Status = value; pic_Status.Image = value; } }

        public AllFriends(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        private void pic_manage_Click(object sender, EventArgs e)
        {
            if(pic_Status.Visible == true && btn_remove.Visible == false) 
            {
                pic_Status.Visible = false;
                btn_remove.Visible = true;
            }
            else 
            {
                pic_Status.Visible = true;
                btn_remove.Visible = false;
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int ID1 = int.Parse(loggedID);
            int ID2 = int.Parse(_UserID);
            dataIO.removeFriend(ID1, ID2);
            mainPage.generateFriendsCount(loggedID);
            mainPage.generateFriends(loggedID);
        }
    }
}
