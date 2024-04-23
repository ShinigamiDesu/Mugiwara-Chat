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
    public partial class MainPage : Form
    {
        DataIO dataIO = new DataIO();

        private string _UserID;
        private string _Username;
        private Image _PFP;

        public string UserID { get { return _UserID; } set { _UserID = value; } }
        public string Username { get { return _Username; } set { _Username = value; } }
        public Image PFP { get { return _PFP; } set { _PFP = value; } }


        bool drag = false;
        Point start_point = new Point(0, 0);
        #region Drag
        private void toolbar_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void toolbar_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void toolbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }
        #endregion
        #region SideBar
        bool sidebarExpand = false;
        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == false)
            {
                panel1.Visible = true;
                sidebar.Width += 10;
                if (sidebar.Width == 210)
                {
                    sidebarExpand = true;
                    sidebartimer.Stop();
                }
            }
            else
            {
                panel1.Visible = false;
                sidebar.Width -= 10;
                if (sidebar.Width == 40)
                {
                    sidebarExpand = false;
                    sidebartimer.Stop();
                }
            }
        }

        private void pic_menu_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }
        #endregion

        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            pic_pfp.Image = _PFP;
            lbl_username.Text = _Username;
            sidebar.Width = 40;
            generateFriendsCount(_UserID);
            generateRecentChat(_UserID);
        }

        public void generateFriendsCount(string ID) 
        {
            DataTable OnlineFriends = dataIO.getOnlineFriends(ID);
            string Online = OnlineFriends.Rows.Count.ToString();
            DataTable OfflineFriends = dataIO.getOfflineFriends(ID);
            string Offline = OfflineFriends.Rows.Count.ToString();
            lbl_OnlineFriends.Text = Online + " Online Friends";
            lbl_OfflineFriends.Text = Offline + " Offline Friends";
        }

        public void generateFriendRequests(string ID) 
        {
            main_panel.Controls.Clear();
            Text2 text = new Text2();
            text.ID = _UserID;
            main_panel.Controls.Add(text);
            DataTable dt = dataIO.getFriendRequests(_UserID);
            if (dt != null)
            {
                FriendRequests[] listItems = new FriendRequests[dt.Rows.Count];
                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        listItems[i] = new FriendRequests(this);
                        listItems[i].loggedID = UserID;
                        // Adding User Image
                        MemoryStream ms = new MemoryStream((byte[])row["user_PFP"]);
                        listItems[i].PFP = new Bitmap(ms);
                        // Adding User Username
                        listItems[i].Username = row["user_username"].ToString();
                        // Adding User Full name
                        listItems[i].FullName = row["user_FN"].ToString() + " " + row["user_LN"].ToString();
                        // Adding User ID
                        listItems[i].UserID = row["user_ID"].ToString();
                        main_panel.Controls.Add(listItems[i]);
                    }
                }
            }
        }

        public void generateFriends(string ID) 
        {
            main_panel.Controls.Clear();
            Text3 text3 = new Text3();
            text3.ID = _UserID;
            main_panel.Controls.Add(text3);
            DataTable dt = dataIO.getAllFriends(ID);
            if (dt != null)
            {
                AllFriends[] listItems = new AllFriends[dt.Rows.Count];
                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        listItems[i] = new AllFriends(this);
                        listItems[i].loggedID = UserID;
                        // Adding User Image
                        MemoryStream ms = new MemoryStream((byte[])row["user_PFP"]);
                        listItems[i].PFP = new Bitmap(ms);
                        // Adding User Username
                        listItems[i].Username = row["user_username"].ToString();
                        // Adding User Full name
                        listItems[i].FullName = row["user_FN"].ToString() + " " + row["user_LN"].ToString();
                        // Adding User ID
                        listItems[i].UserID = row["user_ID"].ToString();
                        if (row["user_Status"].ToString() == "1")
                        {
                            listItems[i].Status = pic_green.Image;
                        }
                        else if (row["user_Status"].ToString() == "0")
                        {
                            listItems[i].Status = pic_red.Image;
                        }
                        main_panel.Controls.Add(listItems[i]);
                    }
                }
            }
        }

        public void generateRecentChat(string ID) 
        {
            main_panel.Controls.Clear();
            Text1 text1 = new Text1(this);
            text1.loggedID = _UserID;
            main_panel.Controls.Add(text1);
            DataTable dt = dataIO.getRecentChats(ID);
            if (dt != null)
            {
                chatTemplate[] listItems = new chatTemplate[dt.Rows.Count];
                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        listItems[i] = new chatTemplate(this);
                        listItems[i].loggedID = UserID;
                        // Adding User Image
                        MemoryStream ms = new MemoryStream((byte[])row["user_PFP"]);
                        listItems[i].PFP = new Bitmap(ms);
                        // Adding User Username
                        listItems[i].Username = row["user_username"].ToString();
                        // Adding User Full name
                        listItems[i].FullName = row["user_FN"].ToString() + " " + row["user_LN"].ToString();
                        // Adding User ID
                        listItems[i].UserID = row["user_ID"].ToString();
                        if (row["user_Status"].ToString() == "1")
                        {
                            listItems[i].Status = pic_green.Image;
                        }
                        else if (row["user_Status"].ToString() == "0")
                        {
                            listItems[i].Status = pic_red.Image;
                        }
                        main_panel.Controls.Add(listItems[i]);
                    }
                }
            }

        }

        public void generateGroupSettings(string GroupID, string Name, Image PFP) 
        {
            main_panel.Controls.Clear();
            groupSettings settings = new groupSettings(this);
            settings.loggedID = UserID;
            settings.groupID = GroupID;
            settings.Username = Name;
            settings.PFP = PFP;
            main_panel.Controls.Add(settings);
        }

        public void generateChat(string username, string fullname, Image PFP, string userID) 
        {
            main_panel.Controls.Clear();
            Chat chat = new Chat(this);
            chat.UserID = userID;
            chat.PFP = PFP;
            chat.FullName = fullname;
            chat.Username = username;
            chat.loggedID = UserID;
            main_panel.Controls.Add(chat);

        }

        public void generateGroupChat(string Name, string ID, Image PFP, string Members) 
        {
            main_panel.Controls.Clear();
            groupChat chat = new groupChat(this);
            chat.Username = Name;
            chat.GroupID = ID;
            chat.Members = Members;
            chat.loggedID = UserID;
            chat.PFP = PFP;
            main_panel.Controls.Add(chat);
        }

        public void generateGroups() 
        {
            main_panel.Controls.Clear();
            groupChatMain group = new groupChatMain(this);
            group.loggedID = _UserID;
            main_panel.Controls.Add(group);
        }

        public void generateAddMember(string Name, string GroupID) 
        {
            addMemberMain member = new addMemberMain(this);
            member.UserID = _UserID;
            member.groupID = GroupID;
            main_panel.Controls.Clear();
            main_panel.Controls.Add(member);
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            dataIO.updateStatus(_UserID, 2);
        }

        private void lbl_AddUser_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            AddUserMain mainAdd = new AddUserMain(this);
            mainAdd.UserID = _UserID;   
            main_panel.Controls.Add(mainAdd);
            sidebartimer.Start();
        }

        private void lbl_Requests_Click(object sender, EventArgs e)
        {
            generateFriendRequests(_UserID);
            sidebartimer.Start();
        }

        private void friendUpdateTimer_Tick(object sender, EventArgs e)
        {
            generateFriendsCount(_UserID);
        }

        private void lbl_viewFriends_Click(object sender, EventArgs e)
        {
            generateFriends(_UserID);
            sidebartimer.Start();
        }

        private void lbl_Home_Click(object sender, EventArgs e)
        {
            generateRecentChat(_UserID);
            sidebartimer.Start();
        }

        private void lbl_NewChat_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            newChatMain newchat = new newChatMain(this);
            newchat.ID = _UserID;
            main_panel.Controls.Add(newchat);
            sidebartimer.Start();
        }

        private void lbl_GroupChats_Click(object sender, EventArgs e)
        {
            generateGroups();
            sidebartimer.Start();
        }


    }
}
