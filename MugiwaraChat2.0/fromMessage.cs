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
    public partial class fromMessage : UserControl
    {
        private Image _PFP;
        private string message;

        public Image PFP { get { return _PFP; } set { _PFP = value; pic_PFP.Image = value; } }
        public string Message { get { return message; } set { message = value; lbl_Message.Text = value; } }


        public fromMessage()
        {
            InitializeComponent();
        }
    }
}
