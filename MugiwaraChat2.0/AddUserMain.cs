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

    public partial class AddUserMain : UserControl
    {
        private MainPage mainPage;
        DataIO dataIO = new DataIO();
        public string UserID { get; set; }

        public AddUserMain(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            if(txt_username.Text == "") 
            { 
                main_panel.Controls.Clear();
            }
            else 
            {
                DataTable dt = dataIO.getSearchedUsers(txt_username.Text);
                main_panel.Controls.Clear();
                if (dt != null)
                {
                    AddUser[] listItems = new AddUser[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new AddUser();
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
                            //if(existingFriend.Rows.Count > 0)
                            //{
                            //    listItems[i].setButtonVisible(false);
                            //}
                            //else 
                            //{
                            //    listItems[i].setButtonVisible(true);
                            //}
                            main_panel.Controls.Add(listItems[i]);
                        }
                    }
                }
            }
        }
    }
}
