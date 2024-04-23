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
    public partial class Text3 : UserControl
    {
        public string ID { get; set; }
        DataIO dataIO = new DataIO();

        public Text3()
        {
            InitializeComponent();
        }

        private void Text3_Load(object sender, EventArgs e)
        {
            DataTable dt = dataIO.getAllFriends(ID);
            lbl_total.Text = "Your Total Friends: " + dt.Rows.Count.ToString();
        }
    }
}
