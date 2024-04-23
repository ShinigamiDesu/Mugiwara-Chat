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
    public partial class Text2 : UserControl
    {
        DataIO dataIO = new DataIO();
        public string ID { get; set; }
        public Text2()
        {
            InitializeComponent();
        }

        private void Text2_Load(object sender, EventArgs e)
        {
            DataTable dt = dataIO.getFriendRequests(ID);
            lbl_req.Text = "Friend Requests: " + dt.Rows.Count.ToString();
        }

        private void lbl_req_Click(object sender, EventArgs e)
        {

        }
    }
}
