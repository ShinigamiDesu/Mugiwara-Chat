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
    public partial class groupChat : UserControl
    {
        DataIO dataIO = new DataIO();
        HashSet<string> displayedMessageIds = new HashSet<string>();
        public string loggedID { get; set; }
        private string _groupID;
        private string _Name;
        private string _Members;
        private Image _PFP;
        private MainPage mainPage;

        public string GroupID { get { return _groupID; } set { _groupID = value; } }
        public string Username { get { return _Name; } set { _Name = value; lbl_name.Text = value; } }
        public string Members { get { return _Members; } set { _Members = value; lbl_Members.Text = value; } }
        public Image PFP { get { return _PFP; } set { _PFP = value; pic_PFP.Image = value; } }

        public groupChat(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        private void txt_message_TextChanged(object sender, EventArgs e)
        {
            if (txt_message.Text.Trim() != "")
            {
                pic_send.Visible = true;
            }
            else if (txt_message.Text.Trim() == "")
            {
                pic_send.Visible = false;
            }
            //if (txt_message.Text.Length > 29)
            //{
            //    txt_message.Height = 85;
            //    txt_message.Location = new Point(0, 500);
            //    main_panel.Height = 412;
            //    panel6.Location = new Point(3, 493);
            //}
            //else
            //{
            //    txt_message.Height = 36;
            //    txt_message.Location = new Point(0, 552);
            //    main_panel.Height = 471;
            //    panel6.Location = new Point(3, 551);
            //}
        }

        private void groupChat_Load(object sender, EventArgs e)
        {
            generateChat();
        }

        private void pic_settings_Click(object sender, EventArgs e)
        {
            mainPage.generateGroupSettings(GroupID, Username, PFP);
        }

        public void generateChat() 
        {
            // Get the messages from the database
            DataTable dt = dataIO.getGroupMessages(GroupID);

            // Loop through the DataTable rows
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string messageId = dt.Rows[i]["message_ID"].ToString(); // Assuming there's a message_ID column
                string message = dt.Rows[i]["message"].ToString();
                string fromID = dt.Rows[i]["message_from_ID"].ToString();
                MemoryStream ms = new MemoryStream((byte[])dt.Rows[i]["user_PFP"]);
                Image PFP = new Bitmap(ms);

                // Check if the message ID is already in the HashSet
                if (!displayedMessageIds.Contains(messageId))
                {
                    // If it's a new message, add the message ID to the HashSet
                    displayedMessageIds.Add(messageId);

                    // Create the appropriate user control and add it to main_panel
                    if (fromID == loggedID)
                    {
                        toMessage to = new toMessage();
                        to.Message = message;
                        main_panel.Controls.Add(to);
                    }
                    else
                    {
                        fromMessage from = new fromMessage();
                        from.PFP = PFP;
                        from.Message = message;
                        main_panel.Controls.Add(from);
                    }
                }
            }
        }

        private void pic_send_Click(object sender, EventArgs e)
        {
            int fromID = int.Parse(loggedID);
            int groupID = int.Parse(GroupID);
            string message = txt_message.Text;
            dataIO.addGroupMessage(fromID, groupID, message);
            txt_message.Text = "";
        }

        private void updateChat_Tick(object sender, EventArgs e)
        {
            generateChat();
        }
    }
}
