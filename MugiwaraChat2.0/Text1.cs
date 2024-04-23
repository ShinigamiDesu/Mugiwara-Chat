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
    public partial class Text1 : UserControl
    {
        DataIO dataIO = new DataIO();
        private MainPage mainPage;
        public string loggedID {  get; set; }
        public Text1(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        private void Text1_Load(object sender, EventArgs e)
        {
            DataTable dt = dataIO.getRecentChats(loggedID);
            lbl_chat.Text = "Recent Chats: " + dt.Rows.Count.ToString();
        }

        private void pic_refresh_Click(object sender, EventArgs e)
        {
            mainPage.generateRecentChat(loggedID);
        }
    }
}
