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
    public partial class Login : Form
    {
        DataIO dataIO = new DataIO();

        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DataTable dt = dataIO.checkLOGIN(txt_username.Text, txt_password.Text);
            if (dt.Rows.Count > 0) 
            {
                MainPage mainPage = new MainPage();
                mainPage.UserID = dt.Rows[0]["user_ID"].ToString();
                mainPage.Username = dt.Rows[0]["user_username"].ToString();
                MemoryStream ms = new MemoryStream((byte[])dt.Rows[0]["user_PFP"]);
                mainPage.PFP = new Bitmap(ms);
                dataIO.updateStatus(dt.Rows[0]["user_ID"].ToString(), 1);
                mainPage.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Wrong Username or Password.");
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            SignUP sign = new SignUP();
            sign.ShowDialog();
            this.Hide();
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
