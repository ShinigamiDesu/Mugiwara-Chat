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
    public partial class newChatMain : UserControl
    {
        public string ID { get; set; }
        DataIO dataIO = new DataIO();
        private MainPage mainPage;

        public newChatMain(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        private void newChatMain_Load(object sender, EventArgs e)
        {
            generateFriends(ID);
        }

        public void generateFriends(string ID) 
        {
            main_panel.Controls.Clear();
            DataTable dt = dataIO.getAllFriends(ID);
            if (dt != null)
            {
                searchChat[] listItems = new searchChat[dt.Rows.Count];
                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        listItems[i] = new searchChat(mainPage);
                        listItems[i].loggedID = ID;
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

        public void generateUsers(string username) 
        {
            DataTable dt = dataIO.getSearchedUsers(username);
            main_panel.Controls.Clear();
            if (dt != null)
            {
                searchChat[] listItems = new searchChat[dt.Rows.Count];
                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        listItems[i] = new searchChat(mainPage);
                        listItems[i].loggedID = ID;
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

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if(txt_search.Text == "") 
            {
                generateFriends(ID);
            }
            else
            {
                generateUsers(txt_search.Text);
            }
        }
    }
}
