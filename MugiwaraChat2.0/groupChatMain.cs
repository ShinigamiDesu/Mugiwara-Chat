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
    public partial class groupChatMain : UserControl
    {
        public string loggedID {  get; set; }
        DataIO dataIO = new DataIO();
        private MainPage mainPage;
        public groupChatMain(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        private void pic_add_Click(object sender, EventArgs e)
        {
            addGroupChat add = new addGroupChat();
            add.loggedID = loggedID;
            add.ShowDialog();
        }

        private void groupChatMain_Load(object sender, EventArgs e)
        {
            DataTable dt = dataIO.getGroupChats(loggedID);
            lbl_total.Text = "Group Chats: " + dt.Rows.Count.ToString();
            generateGroupChats();
        }

        public void generateGroupChats() 
        {
            main_panel.Controls.Clear();
            DataTable dt = dataIO.getGroupChats(loggedID);
            if (dt != null)
            {
                groupChatTemplate[] listItems = new groupChatTemplate[dt.Rows.Count];
                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        listItems[i] = new groupChatTemplate(mainPage);
                        listItems[i].loggedID = loggedID;
                        // Adding Group Image
                        MemoryStream ms = new MemoryStream((byte[])row["group_IMG"]);
                        listItems[i].PFP = new Bitmap(ms);
                        // Adding Group Username
                        listItems[i].Username = row["group_Name"].ToString();
                        // Adding Group ID
                        listItems[i].GroupID = row["group_ID"].ToString();
                        main_panel.Controls.Add(listItems[i]);
                    }
                }
            }
        }
    }
}
