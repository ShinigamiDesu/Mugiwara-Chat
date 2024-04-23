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
    public partial class Chat : UserControl
    {
        DataIO dataIO = new DataIO();
        HashSet<string> displayedMessageIds = new HashSet<string>();
        public string loggedID { get; set; }
        private string _UserID;
        private string _Username;
        private string _FullName;
        private Image _PFP;
        private MainPage mainPage;
        public string UserID { get { return _UserID; } set { _UserID = value; } }
        public string Username { get { return _Username; } set { _Username = value; lbl_username.Text = value; } }
        public string FullName { get { return _FullName; } set { _FullName = value; lbl_FullName.Text = value; } }
        public Image PFP { get { return _PFP; } set { _PFP = value; pic_PFP.Image = value; } }

        public Chat(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            displayChat();
        }

        private void txt_message_TextChanged(object sender, EventArgs e)
        {
            if(txt_message.Text.Trim() != "")
            {
                pic_send.Visible = true;
            }
            else if(txt_message.Text.Trim() == "") 
            { 
                pic_send.Visible = false;    
            }
            //if(txt_message.Text.Length > 29) 
            //{
            //    txt_message.Height = 85;
            //    txt_message.Location = new Point(0, 500);
            //    main_panel.Height = 412;
            //    panel6.Location = new Point(3,493);
            //}
            //else 
            //{
            //    txt_message.Height = 36;
            //    txt_message.Location = new Point(0, 552);
            //    main_panel.Height = 471;
            //    panel6.Location = new Point(3, 551);
            //}
        }

        private void pic_settings_Click(object sender, EventArgs e)
        {
            if(btn_delete.Visible == false) 
            {
                btn_delete.Visible = true;
            }
            else 
            {
                btn_delete.Visible = false;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("The chat will be removed from your recent chats, However the chat history will remain incase the chat starts again.", "Confirmation", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                int ID1 = int.Parse(loggedID);
                int ID2 = int.Parse(_UserID);
                dataIO.deleteRecentChat(ID1, ID2);
                mainPage.generateRecentChat(loggedID);
            }
        }

        private void pic_send_Click(object sender, EventArgs e)
        {
            int ID1 = int.Parse(loggedID);
            int ID2 = int.Parse(_UserID);
            dataIO.addPrivateMessage(ID1, ID2, txt_message.Text);
            txt_message.Text = "";
            displayChat();
        }

        public void displayChat()
        {
            // Get the messages from the database
            DataTable dt = dataIO.getPrivateMessages(loggedID, UserID);

            // Loop through the DataTable rows
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string messageId = dt.Rows[i]["message_ID"].ToString(); // Assuming there's a message_ID column
                string message = dt.Rows[i]["message"].ToString();
                string fromID = dt.Rows[i]["message_FromID"].ToString();

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
                        from.PFP = _PFP;
                        from.Message = message;
                        main_panel.Controls.Add(from);
                    }
                }
            }

        }

        private void updateChat_Tick(object sender, EventArgs e)
        {
            displayChat();
        }
    }
}





//main_panel.Controls.Clear();
//DataTable dt = dataIO.getPrivateMessages(loggedID, UserID);
//for(int i = 0;  i < dt.Rows.Count; i++) 
//{ 
//    string message = dt.Rows[i]["message"].ToString();
//    string fromID = dt.Rows[i]["message_FromID"].ToString();
//    string ToID = dt.Rows[i]["message_ToID"].ToString();
//    if(fromID == loggedID) 
//    { 
//        toMessage to = new toMessage();
//        to.Message = message; 
//        main_panel.Controls.Add(to);
//    }
//    else 
//    { 
//        fromMessage from = new fromMessage();
//        from.PFP = _PFP;
//        from.Message = message;
//        main_panel.Controls.Add(from);
//    }
//}