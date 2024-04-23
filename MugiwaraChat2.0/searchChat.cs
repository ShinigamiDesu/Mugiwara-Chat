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
    public partial class searchChat : UserControl
    {
        DataIO dataIO = new DataIO();
        public string loggedID {  get; set; }
        private string _UserID;
        private string _Username;
        private string _FullName;
        private Image _PFP;
        private MainPage mainPage;


        public string UserID { get { return _UserID; } set { _UserID = value; } }
        public string Username { get { return _Username; } set { _Username = value; lbl_username.Text = value; } }
        public string FullName { get { return _FullName; } set { _FullName = value; lbl_FullName.Text = value; } }
        public Image PFP { get { return _PFP; } set { _PFP = value; pic_PFP.Image = value; } }

        public searchChat(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        private void pic_chat_Click(object sender, EventArgs e)
        {
            if(_UserID == loggedID) 
            {
                MessageBox.Show("Cant Start Chat with Yourself");
            }
            else if(!dataIO.checkRecentChats(loggedID, _UserID)) 
            {
                int ID1 = int.Parse(loggedID);
                int ID2 = int.Parse(_UserID);
                dataIO.addNewChat(ID1, ID2);
                mainPage.generateChat(_Username, _FullName, _PFP, _UserID);
            }
            else 
            {
                mainPage.generateChat(_Username, _FullName, _PFP, _UserID);
            }
        }
    }
}
