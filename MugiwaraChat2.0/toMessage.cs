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
    public partial class toMessage : UserControl
    {
        private string message;
        public string Message { get { return message; } set { message = value; lbl_message.Text = value; } }

        public toMessage()
        {
            InitializeComponent();
        }
    }
}
